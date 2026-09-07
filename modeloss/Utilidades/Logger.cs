using System;
using System.Diagnostics;
using System.IO;

namespace modeloss.Utilidades
{
    public static class Logger
    {
        private static readonly string LogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app_log.txt");

        public static void Debug(string mensaje)
        {
            try
            {
                string linea = DateTime.Now.ToString("s") + " [DEBUG] " + mensaje;
                System.Diagnostics.Debug.WriteLine(linea);
                File.AppendAllText(LogFile, linea + Environment.NewLine);
            }
            catch
            {
                // no hacer nada en logger si falla
            }
        }

        public static void Error(string mensaje)
        {
            try
            {
                string linea = DateTime.Now.ToString("s") + " [ERROR] " + mensaje;
                System.Diagnostics.Debug.WriteLine(linea);
                File.AppendAllText(LogFile, linea + Environment.NewLine);
            }
            catch
            {
            }
        }
    }
}
