CREATE TABLE Usuarios(
UsuarioId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nombres VARCHAR(50),
Apellidos VARCHAR(50),
NombreUsuario VARCHAR(50),
Contrasena VARCHAR(200),
TipoUsuario VARCHAR(20));

GO

create table Rutas(
RutaId int NOT NULL IDENTITY(1,1)PRIMARY KEY,
Descripcion varchar(200));

GO

CREATE TABLE Cobradores(
CobradorId INT IDENTITY(1,1) PRIMARY KEY,
Nombres VARCHAR(50),
Apellidos VARCHAR(50),
Direccion VARCHAR(100),
Telefono VARCHAR(14),
Celular VARCHAR(14),
Cedula varchar(13) UNIQUE CHECK (LEN(Cedula) = 13));

GO

CREATE TABLE Clientes(
ClienteId INT IDENTITY(1,1) PRIMARY KEY,
RutaId INT FOREIGN KEY REFERENCES Rutas(RutaId),
Nombres VARCHAR(50),
Apellidos VARCHAR(50),
Apodos VARCHAR(30),
Sexo BIT,
Direccion VARCHAR(150),
Referencia VARCHAR(50),
Cedula VARCHAR(13) UNIQUE CHECK (LEN(Cedula) = 13),
Telefono VARCHAR(14),
Celular VARCHAR(14)
);
SELECT * FROM Usuarios; 
SELECT * FROM Rutas;
SELECT * FROM Cobradores;
SELECT * FROM Clientes;

DROP TABLE Usuarios;DROP TABLE Rutas;DROP TABLE Cobradores;DROP TABLE Clientes;



