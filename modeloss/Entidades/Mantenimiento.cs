using modeloss.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace modeloss.Entidades
{
    public partial class Mantenimiento
    {
        public static DataTable ListarMantenimiento(string buscar = "") { return DatosEntidad.Consultar("SELECT m.IdMantenimiento, p.Codigo AS Propiedad, m.Descripcion, m.Fecha, m.Costo, e.Nombre AS Estado FROM Mantenimientos m INNER JOIN Propiedades p ON m.IdPropiedad=p.IdPropiedad INNER JOIN Estados e ON m.IdEstado=e.IdEstado WHERE p.Codigo LIKE @buscar OR m.Descripcion LIKE @buscar OR e.Nombre LIKE @buscar", buscar); }
        public static DataRow ObtenerMantenimiento(int id) { return DatosEntidad.Obtener("Mantenimientos", "IdMantenimiento", id); }

        public static void ValidarServidor(Dictionary<string, object> v)
        {
            if (!v.ContainsKey("IdPropiedad") || Convert.ToInt32(v["IdPropiedad"]) <= 0) throw new Exception("Seleccione una propiedad válida.");
            if (!v.ContainsKey("Descripcion") || string.IsNullOrWhiteSpace(Convert.ToString(v["Descripcion"]))) throw new Exception("La descripción es obligatoria.");

            if (!v.ContainsKey("Fecha") || v["Fecha"] == DBNull.Value) throw new Exception("La fecha es obligatoria.");
            DateTime fecha = Convert.ToDateTime(v["Fecha"]);
            if (fecha > DateTime.Today) throw new Exception("La fecha de mantenimiento no puede ser futura.");

            if (!v.ContainsKey("Costo") || v["Costo"] == DBNull.Value) throw new Exception("El costo es obligatorio.");
            decimal costo = Convert.ToDecimal(v["Costo"]);
            if (!ValidacionHelper.EsNumeroPositivo(costo)) throw new Exception("El costo debe ser mayor que cero.");

            if (!v.ContainsKey("IdEstado") || Convert.ToInt32(v["IdEstado"]) <= 0) throw new Exception("Seleccione un estado válido.");
        }

        public static void GuardarMantenimiento(Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Guardar("Mantenimientos", v); }
        public static void ActualizarMantenimiento(int id, Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Actualizar("Mantenimientos", "IdMantenimiento", id, v); }
        public static void EliminarMantenimiento(int id) { DatosEntidad.Eliminar("Mantenimientos", "IdMantenimiento", id); }
    }
}
