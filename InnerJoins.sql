use GestionInmobilaria ;
go





SELECT 
    v.IdVenta,
    c.Nombres + ' ' + c.Apellidos AS Cliente,
    p.Direccion AS Propiedad,
    u.Nombre AS VendidoPor,
    v.PrecioVenta,
    v.FechaVenta
FROM Ventas v
INNER JOIN Clientes c ON v.IdCliente = c.IdCliente
INNER JOIN Propiedades p ON v.IdPropiedad = p.IdPropiedad
INNER JOIN Usuarios u ON v.IdUsuario = u.IdUsuario;




SELECT 
    a.IdAlquiler,
    c.Nombres + ' ' + c.Apellidos AS Cliente,
    p.Direccion AS Propiedad,
    u.Nombre AS GestionadoPor,
    a.FechaInicio,
    a.FechaFin,
    a.PagoMensual
FROM Alquileres a
INNER JOIN Clientes c ON a.IdCliente = c.IdCliente
INNER JOIN Propiedades p ON a.IdPropiedad = p.IdPropiedad
INNER JOIN Usuarios u ON a.IdUsuario = u.IdUsuario;

SELECT 
    pa.IdPago,
    pa.FechaPago,
    pa.Monto,
    mp.Nombre AS MetodoPago,
    e.Nombre AS Estado
FROM Pagos pa
INNER JOIN Alquileres al ON pa.IdAlquiler = al.IdAlquiler
INNER JOIN MetodosPago mp ON pa.IdMetodoPago = mp.IdMetodoPago
INNER JOIN Estados e ON pa.IdEstado = e.IdEstado;


SELECT 
    ci.IdCita,
    c.Nombres + ' ' + c.Apellidos AS Cliente,
    ag.Nombre + ' ' + ag.Apellido AS Agente,
    p.Direccion AS Propiedad,
    ci.Fecha,
    ci.Hora,
    e.Nombre AS Estado
FROM Citas ci
INNER JOIN Clientes c ON ci.IdCliente = c.IdCliente
INNER JOIN Agentes ag ON ci.IdAgente = ag.IdAgente
INNER JOIN Propiedades p ON ci.IdPropiedad = p.IdPropiedad
INNER JOIN Estados e ON ci.IdEstado = e.IdEstado;


SELECT 
    m.IdMantenimiento,
    p.Direccion AS Propiedad,
    m.Descripcion,
    m.Fecha,
    m.Costo,
    e.Nombre AS Estado
FROM Mantenimientos m
INNER JOIN Propiedades p ON m.IdPropiedad = p.IdPropiedad
INNER JOIN Estados e ON m.IdEstado = e.IdEstado;

SELECT 
    p.IdPropiedad,
    p.Codigo,
    tp.Nombre AS Tipo,
    p.Direccion,
    mu.Nombre AS Municipio,
    d.Nombre AS Departamento,
    p.Precio,
    e.Nombre AS Estado
FROM Propiedades p
INNER JOIN TiposPropiedad tp ON p.IdTipoPropiedad = tp.IdTipoPropiedad
INNER JOIN Municipios mu ON p.IdMunicipio = mu.IdMunicipio
INNER JOIN Departamentos d ON mu.IdDepartamento = d.IdDepartamento
INNER JOIN Estados e ON p.IdEstado = e.IdEstado;

SELECT 
    mu.IdMunicipio,
    mu.Nombre AS Municipio,
    d.Nombre AS Departamento
FROM Municipios mu
INNER JOIN Departamentos d ON mu.IdDepartamento = d.IdDepartamento;

SELECT 
    u.IdUsuario,
    u.Nombre,
    u.Usuario,
    r.Nombre AS Rol,
    e.Nombre AS Estado
FROM Usuarios u
INNER JOIN Roles r ON u.IdRol = r.IdRol
INNER JOIN Estados e ON u.IdEstado = e.IdEstado;


SELECT 
    ag.IdAgente,
    ag.Nombre + ' ' + ag.Apellido AS Agente,
    ag.Comision,
    e.Nombre AS Estado
FROM Agentes ag
INNER JOIN Estados e ON ag.IdEstado = e.IdEstado;

