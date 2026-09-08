using System;
using System.Collections.Generic;
using System.Data;
using modeloss.Utilidades;


namespace modeloss.Entidades
{
    public partial class Usuario
    {
        public static DataTable Listar(string buscar = "") { return DatosEntidad.Consultar("SELECT u.IdUsuario, u.Nombre, u.Usuario, r.Nombre AS Rol, e.Nombre AS Estado FROM Usuarios u INNER JOIN Roles r ON u.IdRol=r.IdRol INNER JOIN Estados e ON u.IdEstado=e.IdEstado WHERE u.Nombre LIKE @buscar OR u.Usuario LIKE @buscar OR r.Nombre LIKE @buscar", buscar); }
        public static DataRow Obtener(int id) { return DatosEntidad.Obtener("Usuarios", "IdUsuario", id); }

        public static void ValidarServidor(Dictionary<string, object> v, int id = 0)
        {
            // Nombre requerido
            if (!v.ContainsKey("Nombre") || string.IsNullOrWhiteSpace(Convert.ToString(v["Nombre"]))) throw new Exception("El nombre es obligatorio.");

            // Usuario (nombre de acceso) requerido y único
            if (!v.ContainsKey("Usuario") || string.IsNullOrWhiteSpace(Convert.ToString(v["Usuario"]))) throw new Exception("El nombre de usuario es obligatorio.");
            string usuario = Convert.ToString(v["Usuario"]);
            bool unico = (id == 0) ? ValidacionHelper.EsCodigoUnico("Usuarios", "Usuario", usuario) : ValidacionHelper.EsCodigoUnico("Usuarios", "Usuario", usuario, "IdUsuario", id);
            if (!unico) throw new Exception("El nombre de usuario ya está en uso.");

            // Contraseña mínima (solo en creación o si se proporciona en actualización)
            if (id == 0)
            {
                if (!v.ContainsKey("Contrasena") || string.IsNullOrWhiteSpace(Convert.ToString(v["Contrasena"]))) throw new Exception("La contraseña es obligatoria.");
                if (Convert.ToString(v["Contrasena"]).Length < 6) throw new Exception("La contraseña debe tener al menos 6 caracteres.");
            }
            else
            {
                if (v.ContainsKey("Contrasena") && !string.IsNullOrWhiteSpace(Convert.ToString(v["Contrasena"])) && Convert.ToString(v["Contrasena"]).Length < 6) throw new Exception("La nueva contraseña debe tener al menos 6 caracteres.");
            }

            // IdRol e IdEstado deben existir (básico: >0)
            if (!v.ContainsKey("IdRol") || Convert.ToInt32(v["IdRol"]) <= 0) throw new Exception("Seleccione un rol válido.");
            if (!v.ContainsKey("IdEstado") || Convert.ToInt32(v["IdEstado"]) <= 0) throw new Exception("Seleccione un estado válido.");
        }

        public static void Guardar(Dictionary<string, object> v) {
            ValidarServidor(v, 0);
            // Hash de contraseña antes de guardar
            v["Contrasena"] = global::BCrypt.Net.BCrypt.HashPassword(Convert.ToString(v["Contrasena"]));
            DatosEntidad.Guardar("Usuarios", v);
        }

        public static void Actualizar(int id, Dictionary<string, object> v) {
            ValidarServidor(v, id);
            if (v.ContainsKey("Contrasena") && !string.IsNullOrWhiteSpace(Convert.ToString(v["Contrasena"]))) v["Contrasena"] = global::BCrypt.Net.BCrypt.HashPassword(Convert.ToString(v["Contrasena"]));
            DatosEntidad.Actualizar("Usuarios", "IdUsuario", id, v);
        }

        public static void Eliminar(int id) { DatosEntidad.Eliminar("Usuarios", "IdUsuario", id); }
    }

    public partial class Cliente
    {
        public static DataTable Listar(string buscar = "") { return DatosEntidad.Consultar("SELECT IdCliente, Nombres, Apellidos, DUI, Telefono, Correo, Direccion FROM Clientes WHERE Nombres LIKE @buscar OR Apellidos LIKE @buscar OR DUI LIKE @buscar OR Telefono LIKE @buscar", buscar); }
        public static DataRow Obtener(int id) { return DatosEntidad.Obtener("Clientes", "IdCliente", id); }

        public static void ValidarServidor(Dictionary<string, object> v)
        {
            if (!v.ContainsKey("Nombres") || string.IsNullOrWhiteSpace(Convert.ToString(v["Nombres"]))) throw new Exception("El campo Nombres es obligatorio.");
            if (!v.ContainsKey("Apellidos") || string.IsNullOrWhiteSpace(Convert.ToString(v["Apellidos"]))) throw new Exception("El campo Apellidos es obligatorio.");
            if (v.ContainsKey("Correo") && !string.IsNullOrWhiteSpace(Convert.ToString(v["Correo"])) && !ValidacionHelper.EsEmail(Convert.ToString(v["Correo"]))) throw new Exception("El correo electrónico no tiene un formato válido.");
        }

        public static void Guardar(Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Guardar("Clientes", v); }
        public static void Actualizar(int id, Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Actualizar("Clientes", "IdCliente", id, v); }
        public static void Eliminar(int id) { DatosEntidad.Eliminar("Clientes", "IdCliente", id); }
    }

    public partial class Agente
    {
        public static DataTable Listar(string buscar = "") { return DatosEntidad.Consultar("SELECT a.IdAgente, a.Nombre, a.Apellido, a.Telefono, a.Correo, a.Comision, e.Nombre AS Estado FROM Agentes a INNER JOIN Estados e ON a.IdEstado=e.IdEstado WHERE a.Nombre LIKE @buscar OR a.Apellido LIKE @buscar OR a.Correo LIKE @buscar", buscar); }
        public static DataRow Obtener(int id) { return DatosEntidad.Obtener("Agentes", "IdAgente", id); }

        public static void ValidarServidor(Dictionary<string, object> v)
        {
            if (!v.ContainsKey("Nombre") || string.IsNullOrWhiteSpace(Convert.ToString(v["Nombre"]))) throw new Exception("El nombre del agente es obligatorio.");
            if (!v.ContainsKey("Apellido") || string.IsNullOrWhiteSpace(Convert.ToString(v["Apellido"]))) throw new Exception("El apellido del agente es obligatorio.");
            if (v.ContainsKey("Correo") && !string.IsNullOrWhiteSpace(Convert.ToString(v["Correo"])) && !ValidacionHelper.EsEmail(Convert.ToString(v["Correo"]))) throw new Exception("El correo electrónico no tiene un formato válido.");
            if (v.ContainsKey("Comision") && v["Comision"] != DBNull.Value)
            {
                decimal com = Convert.ToDecimal(v["Comision"]);
                if (com < 0) throw new Exception("La comisión no puede ser negativa.");
            }
        }

        public static void Guardar(Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Guardar("Agentes", v); }

        public static void Actualizar(int id, Dictionary<string, object> v)
        {
            ValidarServidor(v);
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Agentes", "IdAgente", id, "IdUsuario", modeloss.Sesion.UsuarioId))
                    throw new Exception("Solo puede editar su propio perfil de agente.");
            }
            DatosEntidad.Actualizar("Agentes", "IdAgente", id, v);
        }

        public static void Eliminar(int id)
        {
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
                throw new Exception("Solo un administrador puede eliminar agentes.");
            DatosEntidad.Eliminar("Agentes", "IdAgente", id);
        }
    }
    public partial class Propiedad
    {
        public static DataTable ListarPropiedad(string buscar = "") //solo cambia lo que se muestra en el grid; no afecta Obtener(id) porque ese método usa SELECT * sobre la tabla directamente, no esta consulta.
        {
            return DatosEntidad.Consultar("SELECT p.IdPropiedad AS [Id], p.Codigo, t.Nombre AS Tipo, p.Direccion, m.Nombre AS Municipio, d.Nombre AS Departamento, p.Precio, e.Nombre AS Estado, p.Descripcion, p.FechaRegistro AS [Fecha de registro] FROM Propiedades p INNER JOIN TiposPropiedad t ON p.IdTipoPropiedad=t.IdTipoPropiedad INNER JOIN Municipios m ON p.IdMunicipio=m.IdMunicipio INNER JOIN Departamentos d ON m.IdDepartamento=d.IdDepartamento INNER JOIN Estados e ON p.IdEstado=e.IdEstado WHERE p.Codigo LIKE @buscar OR t.Nombre LIKE @buscar OR p.Direccion LIKE @buscar OR m.Nombre LIKE @buscar OR d.Nombre LIKE @buscar", buscar);
        }

        public static DataRow ObtenerPropiedad(int id) { return DatosEntidad.Obtener("Propiedades", "IdPropiedad", id); }

        public static void Guardar(Dictionary<string, object> v)
        {
            // Generar código automático si no viene proporcionado
            if (!v.ContainsKey("Codigo") || v["Codigo"] == DBNull.Value || string.IsNullOrWhiteSpace(Convert.ToString(v["Codigo"])))
            {
                v["Codigo"] = GenerarCodigo();
            }
            DatosEntidad.Guardar("Propiedades", v);
        }

        public static void ValidarServidor(Dictionary<string, object> v)
        {
            if (v.ContainsKey("Precio") && v["Precio"] != DBNull.Value)
            {
                decimal precio = Convert.ToDecimal(v["Precio"]);
                if (precio <= 0) throw new Exception("El precio debe ser mayor que cero.");
            }
            if (v.ContainsKey("FechaRegistro") && v["FechaRegistro"] != DBNull.Value)
            {
                DateTime f = Convert.ToDateTime(v["FechaRegistro"]);
                if (f > DateTime.Today) throw new Exception("La fecha de registro no puede ser futura.");
            }
            // Codigo único si se proporciona
            if (v.ContainsKey("Codigo") && v["Codigo"] != DBNull.Value)
            {
                string codigo = Convert.ToString(v["Codigo"]);
                if (string.IsNullOrWhiteSpace(codigo)) throw new Exception("El código de la propiedad no puede estar vacío.");
                bool unico = ValidacionHelper.EsCodigoUnico("Propiedades", "Codigo", codigo);
                if (!unico) throw new Exception("El código de la propiedad ya existe.");
            }
        }

        private static string GenerarCodigo()
        {
            DataTable dt = DatosEntidad.Catalogo("SELECT ISNULL(MAX(IdPropiedad), 0) + 1 AS Siguiente FROM Propiedades");
            int siguiente = Convert.ToInt32(dt.Rows[0]["Siguiente"]);
            return "PROP-" + siguiente.ToString("000");
        }

        public static void Actualizar(int id, Dictionary<string, object> v)
        {
            ValidarServidor(v);
            DatosEntidad.Actualizar("Propiedades", "IdPropiedad", id, v);
        }

        public static void Eliminar(int id) { DatosEntidad.Eliminar("Propiedades", "IdPropiedad", id); }
    }

    public partial class Venta
    {
        public static DataTable ListarVenta(string buscar = "") { return DatosEntidad.Consultar("SELECT v.IdVenta, c.Nombres+' '+c.Apellidos AS Cliente, p.Codigo AS Propiedad, u.Nombre AS Usuario, v.FechaVenta AS [Fecha de venta], v.PrecioVenta AS [Precio de venta] FROM Ventas v INNER JOIN Clientes c ON v.IdCliente=c.IdCliente INNER JOIN Propiedades p ON v.IdPropiedad=p.IdPropiedad INNER JOIN Usuarios u ON v.IdUsuario=u.IdUsuario WHERE c.Nombres LIKE @buscar OR c.Apellidos LIKE @buscar OR p.Codigo LIKE @buscar OR u.Nombre LIKE @buscar", buscar); }
        public static DataRow ObtenerVenta (int id) { return DatosEntidad.Obtener("Ventas", "IdVenta", id); }
        public static void GuardarVenta(Dictionary<string, object> v) { DatosEntidad.Guardar("Ventas", v); }
        public static void ActualizarVenta(int id, Dictionary<string, object> v)
        {
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Ventas", "IdVenta", id, "IdUsuario", modeloss.Sesion.UsuarioId))
                    throw new Exception("No tiene permisos para editar esta venta.");
            }
            DatosEntidad.Actualizar("Ventas", "IdVenta", id, v);
        }

        public static void EliminarVenta(int id)
        {
            if (!modeloss.Sesion.TienePermiso("Ventas", "Eliminar", modeloss.Sesion.UsuarioId)) throw new Exception("Su rol no tiene permisos para eliminar esta venta.");
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Ventas", "IdVenta", id, "IdUsuario", modeloss.Sesion.UsuarioId)) throw new Exception("No tiene permisos para eliminar esta venta.");
            }
            DatosEntidad.Eliminar("Ventas", "IdVenta", id);
        }
    }

    public partial class Alquiler
    {
        public static DataTable ListarAlquiler(string buscar = "") { return DatosEntidad.Consultar("SELECT a.IdAlquiler, c.Nombres+' '+c.Apellidos AS Cliente, p.Codigo AS Propiedad, u.Nombre AS Usuario, a.FechaInicio AS [Fecha de inicio], a.FechaFin AS [Fecha de fin], a.PagoMensual AS [Pago mensual] FROM Alquileres a INNER JOIN Clientes c ON a.IdCliente=c.IdCliente INNER JOIN Propiedades p ON a.IdPropiedad=p.IdPropiedad INNER JOIN Usuarios u ON a.IdUsuario=u.IdUsuario WHERE c.Nombres LIKE @buscar OR c.Apellidos LIKE @buscar OR p.Codigo LIKE @buscar OR u.Nombre LIKE @buscar", buscar); }
        public static DataRow ObtenerAlquiler(int id) { return DatosEntidad.Obtener("Alquileres", "IdAlquiler", id); }
        public static void GuardarAlquiler(Dictionary<string, object> v) { DatosEntidad.Guardar("Alquileres", v); }
        public static void ActualizarAlquiler(int id, Dictionary<string, object> v)
        {
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Alquileres", "IdAlquiler", id, "IdUsuario", modeloss.Sesion.UsuarioId))
                    throw new Exception("No tiene permisos para editar este alquiler.");
            }
            DatosEntidad.Actualizar("Alquileres", "IdAlquiler", id, v);
        }

        public static void EliminarAlquiler(int id)
        {
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Alquileres", "IdAlquiler", id, "IdUsuario", modeloss.Sesion.UsuarioId)) throw new Exception("No tiene permisos para eliminar este alquiler.");
            }
            DatosEntidad.Eliminar("Alquileres", "IdAlquiler", id);
        }
    }

    public partial class Pago
    {
        public static DataTable Listar(string buscar = "") { return DatosEntidad.Consultar("SELECT pa.IdPago, c.Nombres+' '+c.Apellidos AS Cliente, p.Codigo AS Propiedad, pa.FechaPago AS [Fecha de pago], pa.Monto, mp.Nombre AS [Metodo de pago], e.Nombre AS Estado FROM Pagos pa INNER JOIN Alquileres a ON pa.IdAlquiler=a.IdAlquiler INNER JOIN Clientes c ON a.IdCliente=c.IdCliente INNER JOIN Propiedades p ON a.IdPropiedad=p.IdPropiedad INNER JOIN MetodosPago mp ON pa.IdMetodoPago=mp.IdMetodoPago INNER JOIN Estados e ON pa.IdEstado=e.IdEstado WHERE c.Nombres LIKE @buscar OR c.Apellidos LIKE @buscar OR p.Codigo LIKE @buscar OR mp.Nombre LIKE @buscar", buscar); }
        public static DataRow Obtener(int id) { return DatosEntidad.Obtener("Pagos", "IdPago", id); }

        public static void ValidarServidor(Dictionary<string, object> v)
        {
            if (!v.ContainsKey("IdAlquiler") || Convert.ToInt32(v["IdAlquiler"]) <= 0) throw new Exception("Seleccione un alquiler válido para el pago.");
            if (!v.ContainsKey("FechaPago") || v["FechaPago"] == DBNull.Value) throw new Exception("La fecha de pago es obligatoria.");
            DateTime fechaPago = Convert.ToDateTime(v["FechaPago"]);
            if (fechaPago > DateTime.Today) throw new Exception("La fecha de pago no puede ser futura.");
            if (!v.ContainsKey("Monto") || v["Monto"] == DBNull.Value) throw new Exception("El monto es obligatorio.");
            decimal monto = Convert.ToDecimal(v["Monto"]);
            if (monto <= 0) throw new Exception("El monto debe ser mayor que cero.");
            if (!v.ContainsKey("IdMetodoPago") || Convert.ToInt32(v["IdMetodoPago"]) <= 0) throw new Exception("Seleccione un método de pago válido.");
            if (!v.ContainsKey("IdEstado") || Convert.ToInt32(v["IdEstado"]) <= 0) throw new Exception("Seleccione un estado válido para el pago.");
        }

        public static void Guardar(Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Guardar("Pagos", v); }
        public static void Actualizar(int id, Dictionary<string, object> v) { ValidarServidor(v); DatosEntidad.Actualizar("Pagos", "IdPago", id, v); }
        public static void Eliminar(int id) { DatosEntidad.Eliminar("Pagos", "IdPago", id); }
    }

    public partial class Cita
    {
        public static DataTable Listar(string buscar = "") { return DatosEntidad.Consultar("SELECT ci.IdCita, c.Nombres+' '+c.Apellidos AS Cliente, a.Nombre+' '+a.Apellido AS Agente, p.Codigo AS Propiedad, ci.Fecha, ci.Hora, e.Nombre AS Estado FROM Citas ci INNER JOIN Clientes c ON ci.IdCliente=c.IdCliente INNER JOIN Agentes a ON ci.IdAgente=a.IdAgente INNER JOIN Propiedades p ON ci.IdPropiedad=p.IdPropiedad INNER JOIN Estados e ON ci.IdEstado=e.IdEstado WHERE c.Nombres LIKE @buscar OR c.Apellidos LIKE @buscar OR a.Nombre LIKE @buscar OR p.Codigo LIKE @buscar", buscar); }
        public static DataRow Obtener(int id) { return DatosEntidad.Obtener("Citas", "IdCita", id); }
        public static void Guardar(Dictionary<string, object> v) { DatosEntidad.Guardar("Citas", v); }
        public static void Actualizar(int id, Dictionary<string, object> v) { DatosEntidad.Actualizar("Citas", "IdCita", id, v); }
        public static void Eliminar(int id) { DatosEntidad.Eliminar("Citas", "IdCita", id); }
    }

    public partial class Mantenimiento
    {
        public static DataTable Listar(string buscar = "") { return DatosEntidad.Consultar("SELECT m.IdMantenimiento, p.Codigo AS Propiedad, m.Descripcion, m.Fecha, m.Costo, e.Nombre AS Estado FROM Mantenimientos m INNER JOIN Propiedades p ON m.IdPropiedad=p.IdPropiedad INNER JOIN Estados e ON m.IdEstado=e.IdEstado WHERE p.Codigo LIKE @buscar OR m.Descripcion LIKE @buscar OR e.Nombre LIKE @buscar", buscar); }
        public static DataRow Obtener(int id) { return DatosEntidad.Obtener("Mantenimientos", "IdMantenimiento", id); }

        public static void Guardar(Dictionary<string, object> v)
        {
            // Sella el registro con el usuario que lo crea, para que el ownership funcione después
            v["IdUsuario"] = modeloss.Sesion.UsuarioId;
            DatosEntidad.Guardar("Mantenimientos", v);
        }

        public static void Actualizar(int id, Dictionary<string, object> v)
        {
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Mantenimientos", "IdMantenimiento", id, "IdUsuario", modeloss.Sesion.UsuarioId))
                    throw new Exception("No tiene permisos para editar este mantenimiento.");
            }
            DatosEntidad.Actualizar("Mantenimientos", "IdMantenimiento", id, v);
        }

        public static void Eliminar(int id)
        {
            if (!string.Equals(modeloss.Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                if (!DatosEntidad.EsPropietario("Mantenimientos", "IdMantenimiento", id, "IdUsuario", modeloss.Sesion.UsuarioId))
                    throw new Exception("No tiene permisos para eliminar este mantenimiento.");
            }
            DatosEntidad.Eliminar("Mantenimientos", "IdMantenimiento", id);
        }
    }
    public static class Catalogos
    {
        public static DataTable Roles() { return DatosEntidad.Catalogo("SELECT IdRol, Nombre FROM Roles ORDER BY Nombre"); }
        public static DataTable Estados(string tipo) { return DatosEntidad.Consultar("SELECT IdEstado, Nombre FROM Estados WHERE TipoEntidad LIKE @buscar ORDER BY Nombre", tipo); }
        public static DataTable TiposPropiedad() { return DatosEntidad.Catalogo("SELECT IdTipoPropiedad, Nombre FROM TiposPropiedad ORDER BY Nombre"); }
        public static DataTable Departamentos() { return DatosEntidad.Catalogo("SELECT IdDepartamento, Nombre FROM Departamentos ORDER BY Nombre"); }
        public static DataTable Municipios(int idDepartamento) { return DatosEntidad.Catalogo("SELECT IdMunicipio, Nombre FROM Municipios WHERE IdDepartamento=@id ORDER BY Nombre", idDepartamento); }
        public static DataTable Clientes() { return DatosEntidad.Catalogo("SELECT IdCliente, Nombres+' '+Apellidos AS Nombre FROM Clientes ORDER BY Nombres"); }
        public static DataTable Propiedades() { return DatosEntidad.Catalogo("SELECT IdPropiedad, Codigo+' - '+Direccion AS Nombre FROM Propiedades ORDER BY Codigo"); }
        public static DataTable Usuarios() { return DatosEntidad.Catalogo("SELECT IdUsuario, Nombre FROM Usuarios ORDER BY Nombre"); }
        public static DataTable Agentes() { return DatosEntidad.Catalogo("SELECT IdAgente, Nombre+' '+Apellido AS Nombre FROM Agentes ORDER BY Nombre"); }
        public static DataTable Alquileres() { return DatosEntidad.Catalogo("SELECT a.IdAlquiler, CAST(a.IdAlquiler AS VARCHAR)+' - '+c.Nombres+' - '+p.Codigo AS Nombre FROM Alquileres a INNER JOIN Clientes c ON a.IdCliente=c.IdCliente INNER JOIN Propiedades p ON a.IdPropiedad=p.IdPropiedad ORDER BY a.IdAlquiler"); }
        public static DataTable MetodosPago() { return DatosEntidad.Catalogo("SELECT IdMetodoPago, Nombre FROM MetodosPago ORDER BY Nombre"); }
    }
}
