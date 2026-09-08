using System;
using System.Data.SqlClient;

namespace modeloss.Conexion_DB
{
    public static class Conexion_DB
    {
        // Se usa "localhost" para forzar la conexión directa a la instancia predeterminada local
<<<<<<< HEAD
        private const string Servidor = ".\\SQLEXPRESS";
=======
        private const string Servidor = "ELIDIOS \\SQLEXPRESS";
>>>>>>> c93e92a6e311600b01a5e99d676c85661227dc68
        private const string BaseDeDatos = "GestionInmobiliaria";

        public static string CadenaConexion
        {
            get
            {
                return $@"Data Source={Servidor};Initial Catalog={BaseDeDatos};Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
            }
        }
    }
}