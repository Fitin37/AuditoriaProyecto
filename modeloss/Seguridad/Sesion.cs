using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace modeloss
{
    /// <summary>
    /// Implementación mínima de Sesion y reglas en memoria para permisos.
    /// - Rol: "Administrador", "Agente", "Cliente", "Invitado" (por defecto).
    /// - UsuarioId: id del usuario actualmente autenticado (opcional).
    ///
    /// Nota: esta implementación es en memoria y sirve para pruebas.
    /// Para producción, sustituirla por comprobaciones en base de datos
    /// o por un servicio de autorización centralizado.
    /// </summary>
    public static class Sesion
    {
        // Rol del usuario actual
        public static string Rol { get; set; } = "Invitado";

        // Id del usuario autenticado (útil para comprobaciones de propiedad)
        public static int UsuarioId { get; set; } = -1;

        /// <summary>
        /// Carga el rol del usuario a partir de la base de datos usando el id de usuario.
        /// Intenta varias consultas comunes para adaptarse a distintos esquemas.
        /// Devuelve true si pudo determinar un rol y asignarlo a Sesion.Rol.
        /// </summary>
        public static bool CargarDesdeBase(int usuarioId)
        {
            if (usuarioId <= 0) return false;
            var rolesValidos = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Administrador", "Agente", "Cliente" };
            try
            {
                string cadena = modeloss.Conexion_DB.Conexion_DB.CadenaConexion;
                using (SqlConnection conexion = new SqlConnection(cadena))
                using (SqlCommand comando = conexion.CreateCommand())
                {
                    comando.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = usuarioId });
                    conexion.Open();

                    // Intento 1: Usuarios join Roles (Usuarios.IdRol -> Roles.IdRol, Roles.Nombre)
                    comando.CommandText = "SELECT r.Nombre FROM Usuarios u JOIN Roles r ON u.IdRol = r.IdRol WHERE u.IdUsuario = @id";
                    object valor = comando.ExecuteScalar();
                    if (valor != null && valor != DBNull.Value)
                    {
                        string rolEncontrado = valor.ToString();
                        if (rolesValidos.Contains(rolEncontrado))
                        {
                            Rol = rolEncontrado;
                            UsuarioId = usuarioId;
                            return true;
                        }
                        return false;
                    }

                    // Intento 2: obtener Rol desde Roles vía subconsulta
                    comando.CommandText = "SELECT r.Nombre FROM Roles r WHERE r.IdRol = (SELECT IdRol FROM Usuarios WHERE IdUsuario = @id)";
                    valor = comando.ExecuteScalar();
                    if (valor != null && valor != DBNull.Value)
                    {
                        string rolEncontrado = valor.ToString();
                        if (rolesValidos.Contains(rolEncontrado))
                        {
                            Rol = rolEncontrado;
                            UsuarioId = usuarioId;
                            return true;
                        }
                        return false;
                    }

                    // Intento 3: columna RoleName en Usuarios
                    comando.CommandText = "SELECT RoleName FROM Usuarios WHERE IdUsuario = @id";
                    valor = comando.ExecuteScalar();
                    if (valor != null && valor != DBNull.Value)
                    {
                        string rolEncontrado = valor.ToString();
                        if (rolesValidos.Contains(rolEncontrado))
                        {
                            Rol = rolEncontrado;
                            UsuarioId = usuarioId;
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch
            {
                // No propagar excepción; devolver false
            }

            Rol = "Invitado";
            UsuarioId = -1;
            return false;
        }

        /// <summary>
        /// Comprueba si el rol actual tiene permiso para realizar 'accion' sobre 'tabla'.
        /// Opcionalmente se puede pasar recursoOwnerId para operaciones que dependan
        /// de propiedad (editar/eliminar sobre registros propios).
        /// </summary>
        public static bool TienePermiso(string tabla, string accion, int recursoOwnerId = -1)
        {
            if (string.IsNullOrWhiteSpace(accion)) return false;
            string acc = accion.Trim().ToLowerInvariant();
            string rol = (Rol ?? "Invitado").Trim();

            // Administrador: todo
            if (rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase)) return true;

           
            // Agente: puede leer/crear/editar pero no eliminar globalmente
            if (rol.Equals("Agente", StringComparison.OrdinalIgnoreCase))
            {
                if (acc == "eliminar") return false;
                if (string.IsNullOrWhiteSpace(tabla)) return acc != "eliminar";
                string t = tabla.ToLowerInvariant();
                if (t.Contains("propiedad") || t.Contains("cliente") || t.Contains("venta") || t.Contains("alquiler") || t.Contains("pago") || t.Contains("agente") || t.Contains("mantenimiento"))
                    return acc == "leer" || acc == "crear" || acc == "editar";
                return acc == "leer";
            }

            // Cliente: lectura de propiedades y creación de operaciones; edición de su propio perfil
            if (rol.Equals("Cliente", StringComparison.OrdinalIgnoreCase))
            {
                if (string.IsNullOrWhiteSpace(tabla)) return acc == "leer" || acc == "crear";
                string t = tabla.ToLowerInvariant();
                if (t.Contains("propiedad") || t.Contains("catalogo")) return acc == "leer";
                if (t.Contains("venta") || t.Contains("alquiler") || t.Contains("pago")) return acc == "crear" || acc == "leer";
                if (t.Contains("usuario") || t.Contains("perfil") || t.Contains("clientes"))
                {
                    if (acc == "editar" && recursoOwnerId > 0 && recursoOwnerId == UsuarioId) return true;
                    return acc == "leer";
                }
                return acc == "leer";
            }

            // Invitado u otros: solo lectura limitada
            if (acc == "leer")
            {
                if (!string.IsNullOrWhiteSpace(tabla) && (tabla.ToLowerInvariant().Contains("propiedad") || tabla.ToLowerInvariant().Contains("catalogo"))) return true;
            }

            return false;
        }
    }
}
