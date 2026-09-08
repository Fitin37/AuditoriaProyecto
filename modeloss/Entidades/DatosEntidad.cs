using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace modeloss.Entidades
{
    // Cambiado de 'internal' a 'public' para que las entidades tengan acceso desde cualquier capa
    public static class DatosEntidad
    {
        // Valida nombres de identificadores usados en consultas (tabla, columnas, llaves)
        // Permite letras, dígitos y guión bajo. Previene inyección a través de nombres.
        private static bool EsNombreValido(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            foreach (char c in nombre)
            {
                if (!(char.IsLetterOrDigit(c) || c == '_' || c == '.')) return false;
            }
            return true;
        }
        public static DataTable Consultar(string consulta, string buscar)
        {
            using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
            {
                adaptador.SelectCommand.Parameters.AddWithValue("@buscar", "%" + (buscar ?? "").Trim() + "%");
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // Overload to allow queries that expect an integer parameter named @id
        public static DataTable Consultar(string consulta, int id)
        {
            using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
            {
                adaptador.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public static DataRow Obtener(string tabla, string llave, int id)
        {
            string consulta = "SELECT * FROM " + tabla + " WHERE " + llave + " = @id";
            using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
            {
                adaptador.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                return datos.Rows.Count == 0 ? null : datos.Rows[0];
            }
        }

        public static void Guardar(string tabla, Dictionary<string, object> valores)
        {
            // Validar si el rol actual tiene permiso para crear registros
            if (!Sesion.TienePermiso(tabla, "Crear"))
            {
                throw new Exception("Su rol (" + Sesion.Rol + ") no tiene permisos para crear registros en " + tabla + ".");
            }

            if (valores == null || valores.Count == 0)
                throw new ArgumentException("No hay valores para guardar.", nameof(valores));

            if (!EsNombreValido(tabla))
                throw new ArgumentException("Nombre de tabla inválido.", nameof(tabla));

            // Normalizar claves: quitar '@' si vienen incluidas y validar cada nombre
            List<string> campos = new List<string>();
            Dictionary<string, object> parametros = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            foreach (var kv in valores)
            {
                string clave = kv.Key?.Trim() ?? string.Empty;
                if (clave.StartsWith("@")) clave = clave.Substring(1);
                if (!EsNombreValido(clave)) throw new ArgumentException("Nombre de campo inválido: " + kv.Key);
                if (parametros.ContainsKey(clave)) throw new ArgumentException("Campo duplicado: " + clave);
                campos.Add(clave);
                parametros[clave] = kv.Value ?? DBNull.Value;
            }

            // Validaciones básicas a nivel servidor (ejemplo: Codigo único para Propiedades)
            try
            {
                if (string.Equals(tabla, "Propiedades", StringComparison.OrdinalIgnoreCase) && parametros.ContainsKey("Codigo"))
                {
                    bool unico = modeloss.Utilidades.ValidacionHelper.EsCodigoUnico(tabla, "Codigo", parametros["Codigo"]?.ToString());
                    if (!unico) throw new InvalidOperationException("El código de propiedad ya existe.");
                }

                string consulta = "INSERT INTO " + tabla + " (" + string.Join(",", campos) + ") VALUES (" + string.Join(",@", campos).Insert(0, "@") + ")";
                Ejecutar(consulta, parametros);
            }
            catch (SqlException ex)
            {
                // Manejar errores comunes (constraint unique)
                modeloss.Utilidades.Logger.Error("SQL Error en Guardar: " + ex.Message);
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("No se pudo guardar. Ya existe un registro con el mismo valor único.");
                throw;
            }
            catch (InvalidOperationException ioe)
            {
                throw new Exception(ioe.Message);
            }
        }

        public static void Actualizar(string tabla, string llave, int id, Dictionary<string, object> valores)
        {
            // Validar si el rol actual tiene permiso para editar registros
            if (!Sesion.TienePermiso(tabla, "Editar"))
            {
                throw new Exception("Su rol (" + Sesion.Rol + ") no tiene permisos para actualizar registros en " + tabla + ".");
            }

            if (!EsNombreValido(tabla)) throw new ArgumentException("Nombre de tabla inválido.", nameof(tabla));
            if (!EsNombreValido(llave)) throw new ArgumentException("Nombre de llave inválido.", nameof(llave));
            if (valores == null || valores.Count == 0) throw new ArgumentException("No hay valores para actualizar.", nameof(valores));

            // Construir parámetros normalizados evitando sobrescrituras
            List<string> cambios = new List<string>();
            Dictionary<string, object> parametros = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            foreach (var kv in valores)
            {
                string clave = kv.Key?.Trim() ?? string.Empty;
                if (clave.StartsWith("@")) clave = clave.Substring(1);
                if (!EsNombreValido(clave)) throw new ArgumentException("Nombre de campo inválido: " + kv.Key);
                if (parametros.ContainsKey(clave)) throw new ArgumentException("Campo duplicado: " + clave);
                cambios.Add(clave + "=@" + clave);
                parametros[clave] = kv.Value ?? DBNull.Value;
            }

            parametros["id"] = id;
            try
            {
                // Validación de unicidad si se intenta cambiar Codigo en Propiedades
                if (string.Equals(tabla, "Propiedades", StringComparison.OrdinalIgnoreCase) && parametros.ContainsKey("Codigo"))
                {
                    bool unico = modeloss.Utilidades.ValidacionHelper.EsCodigoUnico(tabla, "Codigo", parametros["Codigo"]?.ToString(), llave, id);
                    if (!unico) throw new InvalidOperationException("El código de propiedad ya existe para otro registro.");
                }

                string consulta = "UPDATE " + tabla + " SET " + string.Join(",", cambios) + " WHERE " + llave + "=@id";
                Ejecutar(consulta, parametros);
            }
            catch (SqlException ex)
            {
                modeloss.Utilidades.Logger.Error("SQL Error en Actualizar: " + ex.Message);
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("No se pudo actualizar. Existe un valor duplicado que viola una restricción única.");
                throw;
            }
            catch (InvalidOperationException ioe)
            {
                throw new Exception(ioe.Message);
            }
        }

        public static void Eliminar(string tabla, string llave, int id)
        {
            // Validar si el rol actual tiene permiso para eliminar registros
            if (!Sesion.TienePermiso(tabla, "Eliminar"))
            {
                throw new Exception("Su rol (" + Sesion.Rol + ") no tiene permisos para eliminar registros en " + tabla + ".");
            }

            if (!EsNombreValido(tabla)) throw new ArgumentException("Nombre de tabla inválido.", nameof(tabla));
            if (!EsNombreValido(llave)) throw new ArgumentException("Nombre de llave inválido.", nameof(llave));

            Dictionary<string, object> valores = new Dictionary<string, object>();
            valores["id"] = id;
            try
            {
                Ejecutar("DELETE FROM " + tabla + " WHERE " + llave + "=@id", valores);
            }
            catch (SqlException ex)
            {
                modeloss.Utilidades.Logger.Error("SQL Error en Eliminar: " + ex.Message);
                throw;
            }
        }

        private static void Ejecutar(string consulta, Dictionary<string, object> valores)
        {
            using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                foreach (KeyValuePair<string, object> valor in valores)
                {
                    // Evita duplicar el símbolo @ si ya viene incluido en la clave del diccionario
                    string nombreParametro = valor.Key.StartsWith("@") ? valor.Key : "@" + valor.Key;
                    comando.Parameters.AddWithValue(nombreParametro, valor.Value ?? DBNull.Value);
                }
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        // Overloads que verifican ownership: devuelve true si existe el registro con id y ownerId coincide
        public static bool EsPropietario(string tabla, string llave, int id, string columnaOwner, int ownerId)
        {
            if (!EsNombreValido(tabla) || !EsNombreValido(llave) || !EsNombreValido(columnaOwner)) return false;
            string consulta = "SELECT COUNT(1) FROM " + tabla + " WHERE " + llave + "=@id AND " + columnaOwner + "=@owner";
            try
            {
                using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@owner", ownerId);
                    conexion.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                modeloss.Utilidades.Logger.Error("Error EsPropietario: " + ex.Message);
                return false;
            }
        }

        // Método para cargar catálogos por tabla (usado en UI)
        public static DataTable ObtenerCatalogo(string consulta, params SqlParameter[] parametros)
        {
            using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
            {
                if (parametros != null && parametros.Length > 0)
                {
                    foreach (var p in parametros) adaptador.SelectCommand.Parameters.Add(p);
                }
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // Métodos convenientes para cargar catálogos usados en formularios
        public static DataTable GetTiposPropiedad()
        {
            return ObtenerCatalogo("SELECT IdTipoPropiedad, Nombre FROM TiposPropiedad ORDER BY Nombre");
        }

        public static DataTable GetDepartamentos()
        {
            return ObtenerCatalogo("SELECT IdDepartamento, Nombre FROM Departamentos ORDER BY Nombre");
        }

        public static DataTable GetMunicipiosPorDepartamento(int idDepartamento)
        {
            return ObtenerCatalogo("SELECT IdMunicipio, Nombre FROM Municipios WHERE IdDepartamento=@id ORDER BY Nombre", new SqlParameter("@id", idDepartamento));
        }

        public static DataTable GetEstadosPorTipo(string tipoEntidad)
        {
            return ObtenerCatalogo("SELECT IdEstado, Nombre FROM Estados WHERE TipoEntidad=@tipo ORDER BY Nombre", new SqlParameter("@tipo", tipoEntidad));
        }

        public static DataTable GetMetodosPago()
        {
            return ObtenerCatalogo("SELECT IdMetodoPago, Nombre FROM MetodosPago ORDER BY Nombre");
        }

        public static DataTable Catalogo(string consulta, int? id = null)
        {
            using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
            {
                if (id.HasValue) adaptador.SelectCommand.Parameters.AddWithValue("@id", id.Value);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }


    }
}