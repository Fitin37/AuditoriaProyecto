using System;
using System.Data.SqlClient;

namespace modeloss.Conexion_DB
{
    public static class Conexion_DB
    {

        private const string Servidor = ".\\SQLEXPRESS";

      

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