using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace modeloss
{
    public static class Sesion
    {
        // Rol del usuario actual ("Administrador", "Agente", "Cliente", "Invitado")
        public static string Rol { get; set; } = "Invitado";

        // Id del usuario autenticado
        public static int UsuarioId { get; set; } = -1;

        // Ids de vinculación directa con entidades (Nullables si no aplican)
        public static int? IdCliente { get; set; } = null;
        public static int? IdAgente { get; set; } = null;

        // Propiedades de apoyo para evaluar permisos/perfiles de forma limpia
        public static bool EsCliente => IdCliente.HasValue && IdCliente.Value > 0;
        public static bool EsAgente => IdAgente.HasValue && IdAgente.Value > 0;

        /// <summary>
        /// Carga el rol, IdCliente e IdAgente a partir de la base de datos usando el IdUsuario.
        /// </summary>
        public static bool CargarDesdeBase(int usuarioId)
        {
            if (usuarioId <= 0) return LimpiarSesion();

            try
            {
                string cadena = modeloss.Conexion_DB.Conexion_DB.CadenaConexion;
                using (SqlConnection conexion = new SqlConnection(cadena))
                using (SqlCommand comando = conexion.CreateCommand())
                {
                    // Consulta los datos del usuario incluyendo sus FK hacia Clientes y Agentes
                    comando.CommandText = @"
                        SELECT r.Nombre AS Rol, u.IdCliente, u.IdAgente 
                        FROM Usuarios u 
                        INNER JOIN Roles r ON u.IdRol = r.IdRol 
                        WHERE u.IdUsuario = @id";

                    comando.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = usuarioId });
                    conexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            Rol = lector["Rol"] != DBNull.Value ? lector["Rol"].ToString() : "Invitado";
                            UsuarioId = usuarioId;

                            // Asignación de IdCliente / IdAgente
                            IdCliente = lector["IdCliente"] != DBNull.Value ? Convert.ToInt32(lector["IdCliente"]) : (int?)null;
                            IdAgente = lector["IdAgente"] != DBNull.Value ? Convert.ToInt32(lector["IdAgente"]) : (int?)null;

                            return true;
                        }
                    }
                }
            }
            catch
            {
                // Manejo de error o log si se requiere
            }

            return LimpiarSesion();
        }

        private static bool LimpiarSesion()
        {
            Rol = "Invitado";
            UsuarioId = -1;
            IdCliente = null;
            IdAgente = null;
            return false;
        }

        public static bool TienePermiso(string tabla, string accion, int recursoOwnerId = -1)
        {
            if (string.IsNullOrWhiteSpace(accion)) return false;
            string acc = accion.Trim().ToLowerInvariant();
            string rol = (Rol ?? "Invitado").Trim();

            // Administrador: acceso total
            if (rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase)) return true;


            // Agente: puede ver/crear/editar pero no eliminar
            if (rol.Equals("Agente", StringComparison.OrdinalIgnoreCase) || EsAgente)

           
            // Agente: puede leer/crear/editar pero no eliminar globalmente
            if (rol.Equals("Agente", StringComparison.OrdinalIgnoreCase))

            {
                if (acc == "eliminar") return false;
                if (string.IsNullOrWhiteSpace(tabla)) return acc != "eliminar";
                string t = tabla.ToLowerInvariant();

                if (t.Contains("propiedad") || t.Contains("cliente") || t.Contains("venta") ||
                    t.Contains("alquiler") || t.Contains("pago") || t.Contains("cita") || t.Contains("mantenimiento"))
                if (t.Contains("propiedad") || t.Contains("cliente") || t.Contains("venta") || t.Contains("alquiler") || t.Contains("pago") || t.Contains("agente") || t.Contains("mantenimiento"))

                    return acc == "leer" || acc == "crear" || acc == "editar";
                return acc == "leer";
            }

            // Cliente: lectura general y creación de operaciones
            if (rol.Equals("Cliente", StringComparison.OrdinalIgnoreCase) || EsCliente)
            {
                if (string.IsNullOrWhiteSpace(tabla)) return acc == "leer" || acc == "crear";
                string t = tabla.ToLowerInvariant();
                if (t.Contains("propiedad") || t.Contains("catalogo")) return acc == "leer";
                if (t.Contains("venta") || t.Contains("alquiler") || t.Contains("pago") || t.Contains("cita"))
                    return acc == "crear" || acc == "leer";
                if (t.Contains("usuario") || t.Contains("perfil") || t.Contains("clientes"))
                {
                    if (acc == "editar" && recursoOwnerId > 0 && recursoOwnerId == UsuarioId) return true;
                    return acc == "leer";
                }
                return acc == "leer";
            }

            // Invitado
            if (acc == "leer" && !string.IsNullOrWhiteSpace(tabla))
            {
                if (tabla.ToLowerInvariant().Contains("propiedad") || tabla.ToLowerInvariant().Contains("catalogo")) return true;
            }

            return false;
        }
    }
}