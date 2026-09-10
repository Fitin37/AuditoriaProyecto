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

        public static void ValidarServidor(Dictionary<string, object> v, int id = 0)
        {
            if (!v.ContainsKey("IdTipoPropiedad") || v["IdTipoPropiedad"] == null || Convert.ToInt32(v["IdTipoPropiedad"]) <= 0)
                throw new Exception("Seleccione un tipo de propiedad válido.");

            if (!v.ContainsKey("Direccion") || string.IsNullOrWhiteSpace(Convert.ToString(v["Direccion"])))
                throw new Exception("La dirección es obligatoria.");

            if (!v.ContainsKey("IdMunicipio") || v["IdMunicipio"] == null || Convert.ToInt32(v["IdMunicipio"]) <= 0)
                throw new Exception("Seleccione un municipio válido.");

            if (!v.ContainsKey("Precio") || v["Precio"] == null || v["Precio"] == DBNull.Value)
                throw new Exception("El precio es obligatorio.");
            decimal precio = Convert.ToDecimal(v["Precio"]);
            if (precio <= 0) throw new Exception("El precio debe ser mayor que cero.");

            if (!v.ContainsKey("IdEstado") || v["IdEstado"] == null || Convert.ToInt32(v["IdEstado"]) <= 0)
                throw new Exception("Seleccione un estado válido.");

            if (!v.ContainsKey("FechaRegistro") || v["FechaRegistro"] == null || v["FechaRegistro"] == DBNull.Value)
                throw new Exception("La fecha de registro es obligatoria.");
            DateTime f = Convert.ToDateTime(v["FechaRegistro"]);
            if (f > DateTime.Today) throw new Exception("La fecha de registro no puede ser futura.");

            if (v.ContainsKey("Codigo") && v["Codigo"] != null && v["Codigo"] != DBNull.Value)
            {
                string codigo = Convert.ToString(v["Codigo"]);
                if (string.IsNullOrWhiteSpace(codigo)) throw new Exception("El código de la propiedad no puede estar vacío.");

                bool unico = (id == 0)
                    ? ValidacionHelper.EsCodigoUnico("Propiedades", "Codigo", codigo)
                    : ValidacionHelper.EsCodigoUnico("Propiedades", "Codigo", codigo, "IdPropiedad", id);

                if (!unico) throw new Exception("El código de la propiedad ya existe.");
            }
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

        public static DataTable Listar(string buscar = "") => ListarAlquiler1(buscar);
        public static DataTable ListarAlquiler(string buscar = "") => ListarAlquiler1(buscar);
        public static DataRow Obtener(int id) => ObtenerAlquiler1(id);
    }
}
