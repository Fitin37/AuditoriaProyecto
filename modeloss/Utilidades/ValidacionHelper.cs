using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace modeloss.Utilidades
{
    public static class ValidacionHelper
    {
        public static bool Requerido(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        public static bool MaxLength(string valor, int max)
        {
            if (valor == null) return true;
            return valor.Trim().Length <= max;
        }

        public static bool EsNumeroPositivo(decimal valor)
        {
            return valor > 0;
        }

        public static bool FechaMayorQue(DateTime inicio, DateTime fin)
        {
            return fin > inicio;
        }

        public static bool EsEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                // Simple regex, suficiente para validación básica
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            }
            catch
            {
                return false;
            }
        }

        // Comprobación en BD para unicidad de un campo en una tabla
        public static bool EsCodigoUnico(string tabla, string columna, string valor)
        {
            if (string.IsNullOrWhiteSpace(tabla) || string.IsNullOrWhiteSpace(columna)) return false;
            string consulta = $"SELECT COUNT(1) FROM {tabla} WHERE {columna} = @valor";
            try
            {
                using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@valor", valor ?? (object)DBNull.Value);
                    conexion.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // Variante que excluye un id (para updates)
        public static bool EsCodigoUnico(string tabla, string columna, string valor, string llave, int id)
        {
            if (string.IsNullOrWhiteSpace(tabla) || string.IsNullOrWhiteSpace(columna) || string.IsNullOrWhiteSpace(llave)) return false;
            string consulta = $"SELECT COUNT(1) FROM {tabla} WHERE {columna} = @valor AND {llave} <> @id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@valor", valor ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@id", id);
                    conexion.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count == 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
