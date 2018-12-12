create table Usuarios(
UsuarioId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nombres varchar(50),
Apellidos varchar(50),
NombreUsuario varchar(50),
Contrasena Varchar(200),
TipoUsuario varchar(20));

go

create table Rutas(
RutaId int NOT NULL IDENTITY(1,1)PRIMARY KEY,
Descripcion varchar(200));

select * from Usuarios; 
select * from Rutas;

DROP TABLE Usuarios;DROP TABLE Rutas;



