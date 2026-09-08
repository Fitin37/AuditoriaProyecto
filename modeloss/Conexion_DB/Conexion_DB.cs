using System;
using System.Data.SqlClient;

namespace modeloss.Conexion_DB
{
    public static class Conexion_DB
    {
        // Se usa "localhost" para forzar la conexión directa a la instancia predeterminada local
        private const string Servidor = "ELIDIOS \\SQLEXPRESS";
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