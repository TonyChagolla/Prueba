CREATE DATABASE Prueba;

USE [Prueba];
 drop table empleados
 drop table usuarios

CREATE TABLE usuarios
(
	userId int not null PRIMARY KEY IDENTITY(1,1),
	[Login] varchar(100),
	Nombre varchar(100),
	Paterno varchar(100),
	Materno varchar(100)
);

CREATE TABLE empleados
(
	userId int not null PRIMARY KEY,
	Sueldo float not null,
	FechaIngreso date not null
	CONSTRAINT fk_userId
	FOREIGN KEY (userId) 
	REFERENCES usuarios(userId)
	ON DELETE CASCADE
)