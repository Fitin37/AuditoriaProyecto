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
    CONSTRAINT FK_Propiedades_Estados FOREIGN KEY(IdEstado) REFERENCES Estados(IdEstado)