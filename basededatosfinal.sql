create database ClinicaDental
go

use ClinicaDental
go

create table Venta (
idVenta int identity (1,1) primary key,
nombreVen varchar(50),
precio decimal (8,2),
cantidad int
);
go


create table Rol( 
idRol int identity (1,1) primary key,
nombreRol varchar (50) not null
);
go

create table Especialidad (
idEspecialidad int primary key identity(1,1),
nombreEspecialidad varchar(50),
);
go

create table Usuario (
idUsuario int identity (1,1) primary key,
nombreUsu varchar(50),
apellidoUsu varchar(50),
fechaNaciUsu date,
duiUsu varchar(20) unique,
telefonoUsu varchar(25),
correoUsu varchar(50),
id_Rol int,
id_Especialidad int,
foreign key (id_Rol) references Rol (idRol),
foreign key (id_Especialidad) references Especialidad (idEspecialidad)
);
go


create table Paciente (
idPaceinte int identity (1,1) primary key,
nombrePa varchar (50),
apellidoPa varchar (50),
fechaNacimiento date,
telefonoPa varchar (25),
dirrecionPa varchar (90),
correoPa varchar (50),
dui varchar (20) Unique ,
);
go

Create view DatosCita as 
select idCita as ID, nombrePa as [Nombre del paciente], apellidoPa as [Apellido del paciente], razonCita as [Razón de la cita], fechaHoraCita as [Fecha y hora]
from Cita
left join
Paciente on Paciente.idPaceinte=Cita.id_Paciente

select *From DatosCita


create table Cita (
idCita int identity (1,1) primary key,
razonCita varchar (100),
fechaHoraCita time,
id_Paciente int
foreign key (id_Paciente) references Paciente
);
go 


create table Expediente (
idExpediente int primary key identity(1,1),
enfermedades varchar(50) null ,
alergias varchar(50) null,     
pacienteId int,            
foreign key (pacienteId) references Paciente (idPaceinte)
);
go

create view MostrarTrabajadores as 
SELECT idUsuario as ID, nombreUsu as Nombre, apellidoUsu as Apellido, fechaNaciUsu as [Fecha de nacimiento], 
       duiUsu as DUI, telefonoUsu as Telefono, correoUsu as Correo, idRol AS Rol, idEspecialidad AS Especialidad FROM Usuario 
LEFT JOIN 
Rol ON Rol.idRol = Usuario.id_Rol 
LEFT JOIN 
Especialidad ON Especialidad.idEspecialidad= Usuario.id_Especialidad


select *from MostrarTrabajadores

insert into Paciente values ('René', 'Morales', '1985-05-20', '7201-2244', ,'rene.morales@clinicadental.com', '015487239'),
('Carla', 'Medina', '1990-08-11', '7745-3310', ,'carla.medina@clinicadental.com', '027543810'),
('Esteban', 'Velásquez', '1987-03-09', '7310-9988', ,'esteban.velasquez@clinicadental.com', '038712945'),
('Silvia', 'Martínez', '1992-11-02', '7154-1109', ,'silvia.martinez@clinicadental.com', '047521893'),
('Oscar', 'Navarro', '1983-12-18', '7520-6631', ,'oscar.navarro@clinicadental.com', '051239478'),
('Iliana', 'Escobar', '1986-01-23', '7680-4455', ,'iliana.escobar@clinicadental.com', '042358719'),
('Rodrigo', 'Pineda', '1991-06-07', '7077-8822', ,'rodrigo.pineda@clinicadental.com', '036789452'),
('Marcela', 'Trujillo', '1989-04-29', '7930-2155', ,'marcela.trujillo@clinicadental.com', '059814237'),
('Álvaro', 'Reyes', '1993-09-16', '7230-1998', ,'alvaro.reyes@clinicadental.com', '026748391'),
('Norma', 'Cáceres', '1984-07-05', '7901-3350', ,'norma.caceres@clinicadental.com', '019384751'),
('Mauricio', 'Delgado', '1988-02-14', '7822-9076', ,'mauricio.delgado@clinicadental.com', '062149378'),
('Karina', 'Figueroa', '1995-10-30', '7644-1101', ,'karina.figueroa@clinicadental.com', '073521894'),
('Ernesto', 'Aguilar', '1982-08-08', '7755-4210', ,'ernesto.aguilar@clinicadental.com', '084713569'),
('Pamela', 'Lara', '1994-03-12', '7922-3300', ,'pamela.lara@clinicadental.com', '098123745'),
('Víctor', 'Rosales', '1986-06-25', '7811-6644', ,'victor.rosales@clinicadental.com', '048293175');

select *from Paciente
select idCita as ID, nombrePa as [Nombre del paciente], 
