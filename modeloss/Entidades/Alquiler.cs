using modeloss.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace modeloss.Entidades
{
    public partial class Alquiler
    {
        public static DataTable ListarAlquiler1(string buscar = "") { return DatosEntidad.Consultar("SELECT a.IdAlquiler, c.Nombres+' '+c.Apellidos AS Cliente, p.Codigo AS Propiedad, u.Nombre AS Usuario, a.FechaInicio AS [Fecha de inicio], a.FechaFin AS [Fecha de fin], a.PagoMensual AS [Pago mensual] FROM Alquileres a INNER JOIN Clientes c ON a.IdCliente=c.IdCliente INNER JOIN Propiedades p ON a.IdPropiedad=p.IdPropiedad INNER JOIN Usuarios u ON a.IdUsuario=u.IdUsuario WHERE c.Nombres LIKE @buscar OR c.Apellidos LIKE @buscar OR p.Codigo LIKE @buscar OR u.Nombre LIKE @buscar", buscar); }
        public static DataRow ObtenerAlquiler1(int id) { return DatosEntidad.Obtener("Alquileres", "IdAlquiler", id); }
    
        public static void ValidarServidor(Dictionary<string, object> v)
        {
            if (!v.ContainsKey("IdCliente") || Convert.ToInt32(v["IdCliente"]) <= 0) throw new Exception("Seleccione un cliente válido.");
            if (!v.ContainsKey("IdPropiedad") || Convert.ToInt32(v["IdPropiedad"]) <= 0) throw new Exception("Seleccione una propiedad válida.");
            if (!v.ContainsKey("IdUsuario") || Convert.ToInt32(v["IdUsuario"]) <= 0) throw new Exception("El usuario responsable es obligatorio.");

            if (!v.ContainsKey("FechaInicio") || v["FechaInicio"] == DBNull.Value) throw new Exception("La fecha de inicio es obligatoria.");
            if (!v.ContainsKey("FechaFin") || v["FechaFin"] == DBNull.Value) throw new Exception("La fecha de fin es obligatoria.");

            DateTime inicio = Convert.ToDateTime(v["FechaInicio"]);
            DateTime fin = Convert.ToDateTime(v["FechaFin"]);
            if (!ValidacionHelper.FechaMayorQue(inicio, fin)) throw new Exception("La fecha de fin debe ser posterior a la fecha de inicio.");

            if (!v.ContainsKey("PagoMensual") || v["PagoMensual"] == DBNull.Value) throw new Exception("El pago mensual es obligatorio.");
            decimal pago = Convert.ToDecimal(v["PagoMensual"]);
            if (!ValidacionHelper.EsNumeroPositivo(pago)) throw new Exception("El pago mensual debe ser mayor que cero.");
        }

        public static void Guardar(Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Guardar("Alquileres", v); }

        public static void Actualizar(int id, Dictionary<string, object> v)
        {
            ValidarServidor(v);
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Alquileres", "IdAlquiler", id, "IdUsuario", modeloss.Sesion.UsuarioId))
                    throw new Exception("No tiene permisos para editar este alquiler.");
            }
            DatosEntidad.Actualizar("Alquileres", "IdAlquiler", id, v);
        }

        public static void Eliminar(int id)
        {
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Alquileres", "IdAlquiler", id, "IdUsuario", modeloss.Sesion.UsuarioId)) throw new Exception("No tiene permisos para eliminar este alquiler.");
            }
            DatosEntidad.Eliminar("Alquileres", "IdAlquiler", id);
        }
    }
}
