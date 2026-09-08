using System;
using System.Collections.Generic;
using System.Data;

namespace modeloss.Entidades
{
    public partial class Cita
    {
        public static DataTable ListarCita(string buscar = "") { return DatosEntidad.Consultar("SELECT ci.IdCita, c.Nombres+' '+c.Apellidos AS Cliente, a.Nombre+' '+a.Apellido AS Agente, p.Codigo AS Propiedad, ci.Fecha, ci.Hora, e.Nombre AS Estado FROM Citas ci INNER JOIN Clientes c ON ci.IdCliente=c.IdCliente INNER JOIN Agentes a ON ci.IdAgente=a.IdAgente INNER JOIN Propiedades p ON ci.IdPropiedad=p.IdPropiedad INNER JOIN Estados e ON ci.IdEstado=e.IdEstado WHERE c.Nombres LIKE @buscar OR c.Apellidos LIKE @buscar OR a.Nombre LIKE @buscar OR p.Codigo LIKE @buscar", buscar); }
        public static DataRow ObtenerCita(int id) { return DatosEntidad.Obtener("Citas", "IdCita", id); }

        public static void ValidarServidor(Dictionary<string, object> v)
        {
            if (!v.ContainsKey("IdCliente") || Convert.ToInt32(v["IdCliente"]) <= 0) throw new Exception("Seleccione un cliente válido.");
            if (!v.ContainsKey("IdAgente") || Convert.ToInt32(v["IdAgente"]) <= 0) throw new Exception("Seleccione un agente válido.");
            if (!v.ContainsKey("IdPropiedad") || Convert.ToInt32(v["IdPropiedad"]) <= 0) throw new Exception("Seleccione una propiedad válida.");

            if (!v.ContainsKey("Fecha") || v["Fecha"] == DBNull.Value) throw new Exception("La fecha de la cita es obligatoria.");
            DateTime fecha = Convert.ToDateTime(v["Fecha"]);
            if (fecha < DateTime.Today) throw new Exception("No se puede agendar una cita en una fecha pasada.");

            if (!v.ContainsKey("Hora") || v["Hora"] == DBNull.Value) throw new Exception("La hora de la cita es obligatoria.");
            if (!v.ContainsKey("IdEstado") || Convert.ToInt32(v["IdEstado"]) <= 0) throw new Exception("Seleccione un estado válido.");
        }

        public static void GuardarCita(Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Guardar("Citas", v); }
        public static void ActualizarCita(int id, Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Actualizar("Citas", "IdCita", id, v); }
        public static void EliminarCita(int id) { DatosEntidad.Eliminar("Citas", "IdCita", id); }
    }
}
