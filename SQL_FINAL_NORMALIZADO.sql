USE master;
GO
IF DB_ID('GestionInmobiliaria') IS NOT NULL
BEGIN
    ALTER DATABASE GestionInmobiliaria SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE GestionInmobiliaria;
END
GO
CREATE DATABASE GestionInmobiliaria;
GO
USE GestionInmobiliaria;
GO

CREATE TABLE Roles(
    IdRol INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE Estados(
    IdEstado INT IDENTITY PRIMARY KEY,
    TipoEntidad VARCHAR(30) NOT NULL,
    Nombre VARCHAR(30) NOT NULL,
    CONSTRAINT UQ_Estados UNIQUE(TipoEntidad, Nombre)
);

CREATE TABLE TiposPropiedad(
    IdTipoPropiedad INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Departamentos(
    IdDepartamento INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Municipios(
    IdMunicipio INT IDENTITY PRIMARY KEY,
    IdDepartamento INT NOT NULL,
    Nombre VARCHAR(80) NOT NULL,
    CONSTRAINT UQ_Municipio UNIQUE(IdDepartamento, Nombre),
    CONSTRAINT FK_Municipios_Departamentos FOREIGN KEY(IdDepartamento) REFERENCES Departamentos(IdDepartamento)
);

CREATE TABLE MetodosPago(
    IdMetodoPago INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE Clientes(
    IdCliente INT IDENTITY PRIMARY KEY,
    Nombres VARCHAR(100) NOT NULL,
    Apellidos VARCHAR(100) NOT NULL,
    DUI VARCHAR(10) NOT NULL UNIQUE,
    Telefono VARCHAR(20) NOT NULL,
    Correo VARCHAR(100) NULL,
    Direccion VARCHAR(200) NOT NULL,
    IdEstado INT NOT NULL,
    CONSTRAINT FK_Clientes_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)
);

CREATE TABLE Agentes(
    IdAgente INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20) NOT NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Comision DECIMAL(5,2) NOT NULL CHECK(Comision >= 0 AND Comision <= 100),
    IdEstado INT NOT NULL,
    CONSTRAINT FK_Agentes_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)
);

CREATE TABLE Usuarios(
    IdUsuario INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Usuario VARCHAR(50) NOT NULL UNIQUE,
    Contrasena VARCHAR(100) NOT NULL,
    IdRol INT NOT NULL,
    IdEstado INT NOT NULL,
    IdCliente INT NULL,
    IdAgente INT NULL,
    CONSTRAINT FK_Usuarios_Roles FOREIGN KEY(IdRol) REFERENCES Roles(IdRol),
    CONSTRAINT FK_Usuarios_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado),
    CONSTRAINT FK_Usuarios_Clientes FOREIGN KEY(IdCliente) REFERENCES Clientes(IdCliente),
    CONSTRAINT FK_Usuarios_Agentes FOREIGN KEY(IdAgente) REFERENCES Agentes(IdAgente)
);

CREATE TABLE Propiedades(
    IdPropiedad INT IDENTITY PRIMARY KEY,
    Codigo VARCHAR(20) NOT NULL UNIQUE,
    IdTipoPropiedad INT NOT NULL,
    Direccion VARCHAR(200) NOT NULL,
    IdMunicipio INT NOT NULL,
    Precio DECIMAL(12,2) NOT NULL CHECK(Precio > 0),
    IdEstado INT NOT NULL,
    Descripcion VARCHAR(500) NULL,
    FechaRegistro DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    CONSTRAINT FK_Propiedades_Tipos FOREIGN KEY(IdTipoPropiedad) REFERENCES TiposPropiedad(IdTipoPropiedad),
    CONSTRAINT FK_Propiedades_Municipios FOREIGN KEY(IdMunicipio) REFERENCES Municipios(IdMunicipio),
<<<<<<< HEAD
    CONSTRAINT FK_Propiedades_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)
);

CREATE TABLE Ventas(
    IdVenta INT IDENTITY PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdPropiedad INT NOT NULL,
    IdUsuario INT NOT NULL,
    FechaVenta DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    PrecioVenta DECIMAL(12,2) NOT NULL CHECK(PrecioVenta > 0),
    CONSTRAINT FK_Ventas_Clientes FOREIGN KEY(IdCliente) REFERENCES Clientes(IdCliente) ON DELETE CASCADE,
    CONSTRAINT FK_Ventas_Propiedades FOREIGN KEY(IdPropiedad) REFERENCES Propiedades(IdPropiedad) ON DELETE CASCADE,
    CONSTRAINT FK_Ventas_Usuarios FOREIGN KEY(IdUsuario) REFERENCES Usuarios(IdUsuario) ON DELETE CASCADE
);

CREATE TABLE Alquileres(
    IdAlquiler INT IDENTITY PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdPropiedad INT NOT NULL,
    IdUsuario INT NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaFin DATE NOT NULL,
    PagoMensual DECIMAL(12,2) NOT NULL CHECK(PagoMensual > 0),
    CONSTRAINT CK_Alquiler_Fechas CHECK(FechaFin > FechaInicio),
    CONSTRAINT FK_Alquileres_Clientes FOREIGN KEY(IdCliente) REFERENCES Clientes(IdCliente) ON DELETE CASCADE,
    CONSTRAINT FK_Alquileres_Propiedades FOREIGN KEY(IdPropiedad) REFERENCES Propiedades(IdPropiedad) ON DELETE CASCADE,
    CONSTRAINT FK_Alquileres_Usuarios FOREIGN KEY(IdUsuario) REFERENCES Usuarios(IdUsuario) ON DELETE CASCADE
);

CREATE TABLE Pagos(
    IdPago INT IDENTITY PRIMARY KEY,
    IdAlquiler INT NOT NULL,
    FechaPago DATE NOT NULL,
    Monto DECIMAL(12,2) NOT NULL CHECK(Monto > 0),
    IdMetodoPago INT NOT NULL,
    IdEstado INT NOT NULL,
    CONSTRAINT FK_Pagos_Alquileres FOREIGN KEY(IdAlquiler) REFERENCES Alquileres(IdAlquiler) ON DELETE CASCADE,
    CONSTRAINT FK_Pagos_Metodos FOREIGN KEY(IdMetodoPago) REFERENCES MetodosPago(IdMetodoPago),
    CONSTRAINT FK_Pagos_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)
);

CREATE TABLE Citas(
    IdCita INT IDENTITY PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdAgente INT NOT NULL,
    IdPropiedad INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    IdEstado INT NOT NULL,
    CONSTRAINT FK_Citas_Clientes FOREIGN KEY(IdCliente) REFERENCES Clientes(IdCliente) ON DELETE CASCADE,
    CONSTRAINT FK_Citas_Agentes FOREIGN KEY(IdAgente) REFERENCES Agentes(IdAgente) ON DELETE CASCADE,
    CONSTRAINT FK_Citas_Propiedades FOREIGN KEY(IdPropiedad) REFERENCES Propiedades(IdPropiedad) ON DELETE CASCADE,
    CONSTRAINT FK_Citas_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)
);

CREATE TABLE Mantenimientos(
    IdMantenimiento INT IDENTITY PRIMARY KEY,
    IdPropiedad INT NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
    Fecha DATE NOT NULL,
    Costo DECIMAL(12,2) NOT NULL CHECK(Costo >= 0),
    IdEstado INT NOT NULL,
    CONSTRAINT FK_Mantenimientos_Propiedades FOREIGN KEY(IdPropiedad) REFERENCES Propiedades(IdPropiedad) ON DELETE CASCADE,
    CONSTRAINT FK_Mantenimientos_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)
);
GO

INSERT Roles(Nombre) VALUES ('Administrador'),('Agente'),('Cliente');
INSERT Roles(Nombre) VALUES ('Gerente'),('Supervisor'),('Recepcionista'),('Contador'),('Cajero'),('Asesor'),('Auditor'),('Soporte'),('Mantenimiento'),('Propietario'),('Arrendador'),('Vendedor'),('Consultor'),('Invitado');

INSERT Estados(TipoEntidad,Nombre) VALUES
('Usuario','Activo'),('Usuario','Inactivo'),('Agente','Activo'),('Agente','Inactivo'),
('Cliente','Activo'),('Cliente','Inactivo'),
('Propiedad','Disponible'),('Propiedad','Vendida'),('Propiedad','Alquilada'),('Propiedad','Inactiva'),
('Pago','Pendiente'),('Pago','Pagado'),('Pago','Anulado'),
('Cita','Pendiente'),('Cita','Confirmada'),('Cita','Realizada'),('Cita','Cancelada'),
('Mantenimiento','Pendiente'),('Mantenimiento','En proceso'),('Mantenimiento','Finalizado');

INSERT TiposPropiedad(Nombre) VALUES ('Casa'),('Apartamento'),('Terreno'),('Local comercial');
INSERT TiposPropiedad(Nombre) VALUES ('Oficina'),('Bodega'),('Edificio'),('Quinta'),('Finca'),('Rancho'),('Casa de playa'),('Condominio'),('Duplex'),('Penthouse'),('Habitacion'),('Parqueo'),('Nave industrial');

INSERT Departamentos(Nombre) VALUES ('San Salvador'),('La Libertad'),('Santa Ana'),('San Miguel');
INSERT Departamentos(Nombre) VALUES ('Ahuachapan'),('Cabanas'),('Chalatenango'),('Cuscatlan'),('La Paz'),('La Union'),('Morazan'),('San Vicente'),('Sonsonate'),('Usulutan'),('Otro'),('Exterior'),('No especificado');

INSERT Municipios(IdDepartamento,Nombre) VALUES
(1,'San Salvador Centro'),(1,'Soyapango'),(1,'Ilopango'),
(2,'Santa Tecla'),(2,'Antiguo Cuscatlan'),(2,'Zaragoza'),
(3,'Santa Ana Centro'),(3,'Metapan'),(4,'San Miguel Centro'),
(5,'Ahuachapan Centro'),(6,'Sensuntepeque'),(7,'Chalatenango Centro'),
(8,'Cojutepeque'),(9,'Zacatecoluca'),(10,'La Union Centro'),
(11,'San Francisco Gotera'),(12,'San Vicente Centro');

INSERT MetodosPago(Nombre) VALUES ('Efectivo'),('Transferencia'),('Tarjeta'),('Cheque');
INSERT MetodosPago(Nombre) VALUES ('Deposito bancario'),('Pago movil'),('Bitcoin'),('PayPal'),('Giro'),('Remesa'),('Debito automatico'),('Credito'),('Vale'),('Orden de pago'),('Pago en linea'),('POS'),('Otro');

-- Contraseña inicial: 2026
INSERT Usuarios(Nombre,Usuario,Contrasena,IdRol,IdEstado) VALUES
('Administrador General','admin','$2b$10$Ie.sUSbIRKujQSBMRCdZoOGMKiAY.Jvd.BqOwV8vsefxjp6ZN/H/m',1,1),
('Agente de prueba','agente','$2b$10$4A1LxM2Sv00CMrLvlWEcXuLb62pNnJGysVCNs/LAxb9OfZk9gBwf2',2,1),
('Cliente de prueba','cliente','$2b$10$jrbpLtN64qkkDNNmzJz7MOhUHDYTtC8lkKF3nNLqXmwQ4kBjTX2ru',3,1);

-- CORRECCIÓN: Se agrega IdEstado = 5 ('Cliente', 'Activo')
INSERT Clientes(Nombres,Apellidos,DUI,Telefono,Correo,Direccion,IdEstado) VALUES
('Juan Jose','Ramirez Hernandez','01234567-1','7123-4567','juan@gmail.com','San Salvador', 5),
('Maria Beatriz','Santos Mejia','02345678-2','7234-5678','maria@gmail.com','Santa Tecla', 5);

INSERT Agentes(Nombre,Apellido,Telefono,Correo,Comision,IdEstado) VALUES
('Juan','Perez','7123-4567','juan@nova.com',5.00,3),
('Maria','Lopez','7234-5678','maria@nova.com',4.50,3);

INSERT Propiedades(Codigo,IdTipoPropiedad,Direccion,IdMunicipio,Precio,IdEstado,Descripcion) VALUES
('PROP-001',1,'Colonia Escalon, casa 12',1,150000,7,'Casa de dos plantas'),
('PROP-002',2,'Torre El Pedregal, apartamento 4B',5,220000,7,'Apartamento con tres habitaciones');

INSERT Ventas(IdCliente,IdPropiedad,IdUsuario,FechaVenta,PrecioVenta)
VALUES(1,1,1,CAST(GETDATE() AS DATE),150000);

INSERT Alquileres(IdCliente,IdPropiedad,IdUsuario,FechaInicio,FechaFin,PagoMensual)
VALUES(2,2,2,CAST(GETDATE() AS DATE),DATEADD(YEAR,1,CAST(GETDATE() AS DATE)),1200);

INSERT Pagos(IdAlquiler,FechaPago,Monto,IdMetodoPago,IdEstado)
VALUES(1,CAST(GETDATE() AS DATE),1200,2,12);

INSERT Citas(IdCliente,IdAgente,IdPropiedad,Fecha,Hora,IdEstado)
VALUES(1,1,2,DATEADD(DAY,7,CAST(GETDATE() AS DATE)),'10:00',14);

INSERT Mantenimientos(IdPropiedad,Descripcion,Fecha,Costo,IdEstado)
VALUES(2,'Revision preventiva',CAST(GETDATE() AS DATE),75,18);
GO

-- Generar registros iterativos
DECLARE @i INT = 4;
WHILE (SELECT COUNT(*) FROM Usuarios) < 17
BEGIN
    INSERT Usuarios(Nombre,Usuario,Contrasena,IdRol,IdEstado)
    VALUES('Usuario de prueba '+CAST(@i AS VARCHAR), 'usuario'+RIGHT('00'+CAST(@i AS VARCHAR),2), '$2b$10$Ie.sUSbIRKujQSBMRCdZoOGMKiAY.Jvd.BqOwV8vsefxjp6ZN/H/m', CASE WHEN @i%2=0 THEN 2 ELSE 3 END, 1);
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 3;
WHILE (SELECT COUNT(*) FROM Clientes) < 17
BEGIN
    -- CORRECCIÓN: Se agrega IdEstado = 5
    INSERT Clientes(Nombres,Apellidos,DUI,Telefono,Correo,Direccion,IdEstado)
    VALUES('Cliente '+CAST(@i AS VARCHAR),'Apellido '+CAST(@i AS VARCHAR),RIGHT('00000000'+CAST(10000000+@i AS VARCHAR),8)+'-'+CAST(@i%10 AS VARCHAR),'7000-'+RIGHT('0000'+CAST(@i AS VARCHAR),4),'cliente'+CAST(@i AS VARCHAR)+'@correo.com','Direccion del cliente '+CAST(@i AS VARCHAR), 5);
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 3;
WHILE (SELECT COUNT(*) FROM Agentes) < 17
BEGIN
    INSERT Agentes(Nombre,Apellido,Telefono,Correo,Comision,IdEstado)
    VALUES('Agente '+CAST(@i AS VARCHAR),'Apellido '+CAST(@i AS VARCHAR),'7100-'+RIGHT('0000'+CAST(@i AS VARCHAR),4),'agente'+CAST(@i AS VARCHAR)+'@nova.com',4.00+(@i%4),3);
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 3;
WHILE (SELECT COUNT(*) FROM Propiedades) < 17
BEGIN
    INSERT Propiedades(Codigo,IdTipoPropiedad,Direccion,IdMunicipio,Precio,IdEstado,Descripcion,FechaRegistro)
    VALUES('PROP-'+RIGHT('000'+CAST(@i AS VARCHAR),3),((@i-1)%17)+1,'Direccion de propiedad '+CAST(@i AS VARCHAR),((@i-1)%17)+1,50000+(@i*5000),7,'Propiedad de prueba '+CAST(@i AS VARCHAR),CAST(GETDATE() AS DATE));
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 2;
WHILE (SELECT COUNT(*) FROM Ventas) < 17
BEGIN
    INSERT Ventas(IdCliente,IdPropiedad,IdUsuario,FechaVenta,PrecioVenta)
    VALUES(@i,@i,((@i-1)%17)+1,DATEADD(DAY,-@i,CAST(GETDATE() AS DATE)),50000+(@i*5000));
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 2;
WHILE (SELECT COUNT(*) FROM Alquileres) < 17
BEGIN
    INSERT Alquileres(IdCliente,IdPropiedad,IdUsuario,FechaInicio,FechaFin,PagoMensual)
    VALUES(@i,@i,((@i-1)%17)+1,DATEADD(MONTH,-1,CAST(GETDATE() AS DATE)),DATEADD(MONTH,11,CAST(GETDATE() AS DATE)),500+(@i*25));
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 2;
WHILE (SELECT COUNT(*) FROM Pagos) < 17
BEGIN
    INSERT Pagos(IdAlquiler,FechaPago,Monto,IdMetodoPago,IdEstado)
    VALUES(@i,DATEADD(DAY,-(@i%20),CAST(GETDATE() AS DATE)),500+(@i*25),((@i-1)%17)+1,12);
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 2;
WHILE (SELECT COUNT(*) FROM Citas) < 17
BEGIN
    INSERT Citas(IdCliente,IdAgente,IdPropiedad,Fecha,Hora,IdEstado)
    VALUES(@i,@i,@i,DATEADD(DAY,@i,CAST(GETDATE() AS DATE)),TIMEFROMPARTS(8+(@i%8),0,0,0,0),14);
    SET @i=@i+1;
END;
GO

DECLARE @i INT = 2;
WHILE (SELECT COUNT(*) FROM Mantenimientos) < 17
BEGIN
    INSERT Mantenimientos(IdPropiedad,Descripcion,Fecha,Costo,IdEstado)
    VALUES(@i,'Mantenimiento preventivo '+CAST(@i AS VARCHAR),DATEADD(DAY,-(@i%10),CAST(GETDATE() AS DATE)),50+(@i*10),18);
    SET @i=@i+1;
END;
GO

-- Actualizaciones de datos especificos
UPDATE u SET u.Nombre=x.Nombre, u.Usuario=x.Usuario
FROM Usuarios u INNER JOIN (VALUES
(1,'Carlos Mendoza','admin'),(2,'Ana Gomez','agente'),(3,'Luis Perez','cliente'),
(4,'Sophia Rodriguez','srodriguez'),(5,'Diego Martinez','dmartinez'),
(6,'Elena Fuentes','efuentes'),(7,'Mario Lopez','mlopez'),(8,'Laura Torres','ltorres'),
(9,'Jorge Hernandez','jhernandez'),(10,'Claudia Rivas','crivas'),
(11,'Roberto Carlos','rcarlos'),(12,'Patricia Mejia','pmejia'),
(13,'Jose Melendez','jmelendez'),(14,'Ricardo Flores','rflores'),
(15,'Manuel Duran','mduran'),(16,'Valeria Castro','vcastro'),(17,'Fernando Reyes','freyes')
)x(IdUsuario,Nombre,Usuario) ON u.IdUsuario=x.IdUsuario;

UPDATE c SET c.Nombres=x.Nombres,c.Apellidos=x.Apellidos,c.DUI=x.DUI,
c.Telefono=x.Telefono,c.Correo=x.Correo,c.Direccion=x.Direccion
FROM Clientes c INNER JOIN (VALUES
(1,'Juan Jose','Ramirez Hernandez','01234567-1','7123-4567','juan@gmail.com','Colonia Escalon, San Salvador'),
(2,'Maria Beatriz','Santos Mejia','02345678-2','7234-5678','maria@gmail.com','Santa Tecla, La Libertad'),
(3,'Pedro Alvarado','Alfonso Cruz','03456789-3','7345-6789','pedro@mail.com','Ciudad Merliot, Santa Tecla'),
(4,'Lucia Fernanda','Aguilar Beltran','04567890-4','7456-7890','lucia@mail.com','San Benito, San Salvador'),
(5,'Miguel Angel','Merentiel Flores','05678901-5','7567-8901','miguel@mail.com','Residencial Altavista, Ilopango'),
(6,'Gabriela Noemy','Perez Aguilar','06789012-6','7678-9012','gaby@mail.com','Quintamar, La Libertad'),
(7,'Fernando David','Hernandez Morales','07890123-7','7789-0123','fer@mail.com','Metapan, Santa Ana'),
(8,'Rosa Julia','Flores Martinez','08901234-8','7890-1234','rosa@mail.com','San Miguel Centro'),
(9,'Alejandro Javier','Rivas Pena','09012345-9','7901-2345','ale@mail.com','Lourdes, Colon'),
(10,'Diana Marcela','Diaz Vasquez','00123456-0','7012-3456','diana@mail.com','Sonsonate Centro'),
(11,'Jose Enrique','Portillo Rivera','01122334-5','7112-2334','jose@mail.com','Usulutan Centro'),
(12,'Carmen Alicia','Sanchez Orellana','02233445-6','7223-3445','carmen@mail.com','Zacatecoluca, La Paz'),
(13,'Francisco Antonio','Lozano Solis','03344556-7','7334-4556','pancho@mail.com','Sensuntepeque, Cabanas'),
(14,'Veronice Estela','Jacinto Ayala','04455667-8','7445-5667','vero@mail.com','San Vicente Centro'),
(15,'Oscar Rene','Carabantes Miranda','05566778-9','7556-6778','oscar@mail.com','Chalatenango Centro'),
(16,'Andrea Sofia','Molina Chavez','06677889-0','7667-7889','andrea@mail.com','Santa Ana Centro'),
(17,'Mauricio Daniel','Reyes Portillo','07788990-1','7778-8990','mauricio@mail.com','San Salvador Centro')
)x(IdCliente,Nombres,Apellidos,DUI,Telefono,Correo,Direccion) ON c.IdCliente=x.IdCliente;

UPDATE a SET a.Nombre=x.Nombre,a.Apellido=x.Apellido,a.Telefono=x.Telefono,
a.Correo=x.Correo,a.Comision=x.Comision,a.IdEstado=x.IdEstado
FROM Agentes a INNER JOIN (VALUES
(1,'Juan','Perez','7123-4567','juan@inmobiliaria.com',5.00,3),
(2,'Maria','Lopez','7234-5678','maria@inmobiliaria.com',4.50,3),
(3,'Carlos','Gomez','7345-6789','carlos@inmobiliaria.com',6.00,3),
(4,'Ana','Martinez','7456-7890','ana@inmobiliaria.com',5.50,3),
(5,'Luis','Hernandez','7567-8901','luis@inmobiliaria.com',5.00,3),
(6,'Sofia','Rivera','7001-1006','sofia.rivera@nova.com',5.00,3),
(7,'Daniel','Castro','7001-1007','daniel.castro@nova.com',4.50,3),
(8,'Valeria','Flores','7001-1008','valeria.flores@nova.com',5.25,3),
(9,'Miguel','Ortiz','7001-1009','miguel.ortiz@nova.com',5.00,3),
(10,'Gabriela','Mendez','7001-1010','gabriela.mendez@nova.com',4.75,3),
(11,'Fernando','Torres','7001-1011','fernando.torres@nova.com',5.50,3),
(12,'Andrea','Reyes','7001-1012','andrea.reyes@nova.com',4.50,3),
(13,'Roberto','Cruz','7001-1013','roberto.cruz@nova.com',6.00,3),
(14,'Paola','Vasquez','7001-1014','paola.vasquez@nova.com',5.00,3),
(15,'Ricardo','Aguilar','7001-1015','ricardo.aguilar@nova.com',4.75,4),
(16,'Natalia','Campos','7001-1016','natalia.campos@nova.com',5.25,3),
(17,'Samuel','Hernandez','7001-1017','samuel.hernandez@nova.com',5.00,3)
)x(IdAgente,Nombre,Apellido,Telefono,Correo,Comision,IdEstado) ON a.IdAgente=x.IdAgente;

UPDATE p SET p.Codigo=x.Codigo,p.IdTipoPropiedad=x.IdTipo,p.Direccion=x.Direccion,
p.IdMunicipio=x.IdMunicipio,p.Precio=x.Precio,p.IdEstado=x.IdEstado,p.Descripcion=x.Descripcion
FROM Propiedades p INNER JOIN (VALUES
(1,'PROP-001',1,'Av. Las Magnolias #12',1,150000.00,8,'Casa de dos plantas con jardin'),
(2,'PROP-002',2,'Torre El Pedregal Apto 4B',5,220000.00,9,'Vista panoramica, 3 habitaciones'),
(3,'PROP-003',3,'Km 25 Carretera al Puerto',6,450000.00,7,'Terreno plano ideal para desarrollo'),
(4,'PROP-004',1,'Residencial Los Suenos',4,320000.00,8,'Acabados de lujo, piscina privada'),
(5,'PROP-005',2,'Condominio San Benito',1,1100.00,9,'Amueblado, precio mensual'),
(6,'PROP-006',3,'Lote 14, Urbanizacion El Sitial',7,35000.00,7,'Acceso a agua y luz electrica'),
(7,'PROP-007',1,'Colonia Buenos Aires',9,85000.00,8,'Cerca de centros comerciales'),
(8,'PROP-008',2,'Apartamentos Escalon Vista',1,125000.00,7,'Estreno, cochera para 2 vehiculos'),
(9,'PROP-009',3,'Playa El Tunco',6,180000.00,7,'Excelente ubicacion turistica'),
(10,'PROP-010',1,'Paseo General Escalon',1,210000.00,7,'Ideal para oficinas o vivienda'),
(11,'PROP-011',2,'Torres del Sol',5,950.00,9,'Seguridad 24 horas y areas comunes'),
(12,'PROP-012',3,'Valle de Jiboa',17,25000.00,7,'Uso agricola o habitacional'),
(13,'PROP-013',1,'Residencial Pinares de Suiza',4,140000.00,8,'Zona fresca y segura'),
(14,'PROP-014',2,'Condominio Puerta del Alma',5,1300.00,9,'Moderno, amenidades incluidas'),
(15,'PROP-015',3,'Cerca de bypass Ahuachapan',10,60000.00,7,'Factibilidad de servicios'),
(16,'PROP-016',4,'Local comercial Metrocentro',1,185000.00,7,'Local amplio para negocio'),
(17,'PROP-017',5,'Centro financiero Santa Elena',5,275000.00,7,'Oficina moderna con estacionamiento')
)x(IdPropiedad,Codigo,IdTipo,Direccion,IdMunicipio,Precio,IdEstado,Descripcion) ON p.IdPropiedad=x.IdPropiedad;

UPDATE Mantenimientos SET Descripcion=CASE IdMantenimiento
WHEN 1 THEN 'Reparacion de tuberias' WHEN 2 THEN 'Pintura de paredes interiores'
WHEN 3 THEN 'Revision del sistema electrico' WHEN 4 THEN 'Cambio de cerraduras'
WHEN 5 THEN 'Limpieza general de la propiedad' WHEN 6 THEN 'Reparacion del techo'
WHEN 7 THEN 'Mantenimiento de aire acondicionado' WHEN 8 THEN 'Reparacion de ventanas'
WHEN 9 THEN 'Cambio de iluminacion' WHEN 10 THEN 'Revision del sistema de agua'
WHEN 11 THEN 'Reparacion de porton principal' WHEN 12 THEN 'Tratamiento contra humedad'
WHEN 13 THEN 'Mantenimiento de jardin' WHEN 14 THEN 'Reparacion de piso'
WHEN 15 THEN 'Inspeccion general de la propiedad' WHEN 16 THEN 'Revision de puertas y ventanas'
WHEN 17 THEN 'Mantenimiento preventivo general' END;
GO

-- Vistas
CREATE VIEW vw_Ventas AS
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
GO

CREATE VIEW vw_Alquileres AS
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
GO

CREATE VIEW vw_Pagos AS
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
GO

CREATE VIEW vw_Citas AS
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
GO

CREATE VIEW vw_Mantenimientos AS
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
GO

CREATE VIEW vw_Propiedades AS
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
GO

CREATE VIEW vw_Municipios AS
SELECT 
    mu.IdMunicipio,
    mu.Nombre AS Municipio,
    d.Nombre AS Departamento
FROM Municipios mu
INNER JOIN Departamentos d ON mu.IdDepartamento = d.IdDepartamento;
GO

CREATE VIEW vw_Usuarios AS
SELECT 
    u.IdUsuario,
    u.Nombre,
    u.Usuario,
    r.Nombre AS Rol,
    e.Nombre AS Estado
FROM Usuarios u
INNER JOIN Roles r ON u.IdRol = r.IdRol
INNER JOIN Estados e ON u.IdEstado = e.IdEstado;
GO

CREATE VIEW vw_Agentes AS
SELECT 
    ag.IdAgente,
    ag.Nombre + ' ' + ag.Apellido AS Agente,
    ag.Comision,
    e.Nombre AS Estado
FROM Agentes ag
INNER JOIN Estados e ON ag.IdEstado = e.IdEstado;
GO

-- Comprobación final
SELECT 'Roles' AS Tabla, COUNT(*) AS Registros FROM Roles UNION ALL
SELECT 'Estados',COUNT(*) FROM Estados UNION ALL SELECT 'TiposPropiedad',COUNT(*) FROM TiposPropiedad UNION ALL
SELECT 'Departamentos',COUNT(*) FROM Departamentos UNION ALL SELECT 'Municipios',COUNT(*) FROM Municipios UNION ALL
SELECT 'MetodosPago',COUNT(*) FROM MetodosPago UNION ALL SELECT 'Usuarios',COUNT(*) FROM Usuarios UNION ALL
SELECT 'Clientes',COUNT(*) FROM Clientes UNION ALL SELECT 'Agentes',COUNT(*) FROM Agentes UNION ALL
SELECT 'Propiedades',COUNT(*) FROM Propiedades UNION ALL SELECT 'Ventas',COUNT(*) FROM Ventas UNION ALL
SELECT 'Alquileres',COUNT(*) FROM Alquileres UNION ALL SELECT 'Pagos',COUNT(*) FROM Pagos UNION ALL
SELECT 'Citas',COUNT(*) FROM Citas UNION ALL SELECT 'Mantenimientos',COUNT(*) FROM Mantenimientos;
GO

ALTER TABLE Mantenimientos
ADD IdUsuario INT NULL
    CONSTRAINT FK_Mantenimientos_Usuarios FOREIGN KEY REFERENCES Usuarios(IdUsuario);

ALTER TABLE Agentes
ADD IdUsuario INT NULL
    CONSTRAINT FK_Agentes_Usuarios FOREIGN KEY REFERENCES Usuarios(IdUsuario);

    SELECT Codigo, COUNT(*) AS Repetidos
FROM Propiedades
GROUP BY Codigo
HAVING COUNT(*) > 1;

ALTER TABLE Propiedades
ADD CONSTRAINT UQ_Propiedades_Codigo UNIQUE (Codigo);
=======
    CONSTRAINT FK_Propiedades_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)
>>>>>>> c93e92a6e311600b01a5e99d676c85661227dc68
