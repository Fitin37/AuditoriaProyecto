using System;
using System.Data;
using System.Data.SqlClient;

namespace modeloss.Seguridad
{
    /// <summary>
    /// Autenticación mínima. Comprueba usuario/contraseña (texto plano o bcrypt) frente a la tabla Usuarios
    /// y, si coincide, carga la sesión desde la base de datos (roles) usando Sesion.CargarDesdeBase.
    /// Reemplazar por un sistema con contraseñas hasheadas cuando migréis la BD.
    /// </summary>
    public static class Auth
    {
        /// <summary>
        /// Intenta autenticar. Devuelve true si las credenciales son válidas y la sesión se inicializó.
        /// mensaje contiene información para mostrar en la UI en caso de fallo.
        /// </summary>
        public static bool Login(string usuario, string contrasena, out string mensaje)
        {
            mensaje = string.Empty;
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                mensaje = "Ingrese usuario y contraseña.";
                return false;
            }

            try
            {
                string cadena = modeloss.Conexion_DB.Conexion_DB.CadenaConexion;
                using (SqlConnection conexion = new SqlConnection(cadena))
                using (SqlCommand comando = conexion.CreateCommand())
                {
                    // Ajustado a su esquema: IdUsuario es la PK
                    comando.CommandText = "SELECT IdUsuario, Contrasena FROM Usuarios WHERE Usuario = @usuario";
                    comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NVarChar, 50) { Value = usuario });
                    conexion.Open();
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            mensaje = "Usuario o contraseña incorrectos.";
                            return false;
                        }

                        int id = dr.GetInt32(0);
                        object objPass = dr.IsDBNull(1) ? null : dr.GetValue(1);
                        string passEnBD = objPass?.ToString() ?? string.Empty;

                        // Verificar contraseña usando PasswordHelper (soporta bcrypt, pbkdf2 o texto plano como fallback)
                        bool passOk = modeloss.Seguridad.PasswordHelper.VerifyPassword(passEnBD, contrasena);
                        if (!passOk)
                        {
                            mensaje = "Usuario o contraseña incorrectos.";
                            return false;
                        }

                        // Credenciales correctas, cargar rol desde BD
                        bool sesionOk = modeloss.Sesion.CargarDesdeBase(id);
                        if (!sesionOk)
                        {
                            mensaje = "No se pudo asignar rol al usuario. Contacte al administrador.";
                            return false;
                        }

                        mensaje = "OK";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al acceder a la base de datos: " + ex.Message;
                return false;
            }
        }


    }
}
