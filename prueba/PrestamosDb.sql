CREATE DATABASE SotechLending
go
use SotechLending
go

CREATE TABLE Usuarios(
UsuarioId INT IDENTITY(1001,1) PRIMARY KEY,
Nombres VARCHAR(50),
Apellidos VARCHAR(50),
NombresUsuarios varchar(40),
Contrasena VARCHAR(32),
Estado INT,
);

CREATE TABLE Rutas(
RutaId INT IDENTITY(1001,1) PRIMARY KEY,
Descripcion VARCHAR(200),
);

CREATE TABLE Cobradores(
CobradorId INT IDENTITY(1001,1) PRIMARY KEY,
Nombres VARCHAR(50),
Apellidos VARCHAR(50),
Activo bit,
Direccion VARCHAR(100),
Celular VARCHAR(13),
Cedula varchar(11) UNIQUE CHECK (LEN(Cedula) = 11)
);


CREATE TABLE RutasCobradores(
RutasCobradoresId INT IDENTITY PRIMARY KEY,
RutaId INT FOREIGN KEY REFERENCES Rutas(RutaId),
CobradorId INT FOREIGN KEY REFERENCES Cobradores(CobradorId)
);


CREATE TABLE Clientes(
ClienteId INT IDENTITY(1001,1) PRIMARY KEY,
RutaId INT FOREIGN KEY REFERENCES Rutas(RutaId),
Nombres VARCHAR(50),
Apellidos VARCHAR(50),
Apodos VARCHAR(30),
Direccion VARCHAR(150),
Referencia VARCHAR(50),
Cedula VARCHAR(11) UNIQUE CHECK (LEN(Cedula) = 11),
Telefono VARCHAR(13),
Celular VARCHAR(13)
);


CREATE TABLE Prestamos(
PrestamoId INT IDENTITY(1001,1) PRIMARY KEY,
ClienteId INT FOREIGN KEY REFERENCES Clientes(ClienteId),
TipoPrestamoId INT FOREIGN KEY REFERENCES TipoPrestamos(TipoPrestamoId),
Fecha DATE,
FechaInicial DATE,
Monto FLOAT, 
PorcientoInteres FLOAT,
CantidadCuota INT,
Frecuencia INT,
TipoAcuerdo INT,
TipoCalculo INT,
MontoCuota DOUBLE,
MontoCapital DOUBLE,
);

CREATE TABLE TipoPrestamos(
TipoPrestamoId INT IDENTITY(1001,1) PRIMARY KEY,
Descripcion VARCHAR(150),
Interes FLOAT,
CantidadCuota INT,
Frecuencia INT,
TipoAcuerdo INT,
TipoMora INT,
PorcientoMora INT,
);

                       
CREATE TABLE Cobros(
CobroId INT IDENTITY(1001,1) PRIMARY KEY,
ClienteId INT FOREIGN KEY REFERENCES Clientes(ClienteId),
PrestamoId INT FOREIGN KEY REFERENCES Prestamos(PrestamoId),
Fecha DATE,
)