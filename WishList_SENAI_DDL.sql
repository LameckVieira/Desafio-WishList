CREATE DATABASE WishList_SENAI;
GO

USE WishList_SENAI;
GO

CREATE TABLE Usuarios
(
	idUsuario				INT PRIMARY KEY IDENTITY
	,Email					VARCHAR(200) NOT NULL
	,Senha					VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Desejos
(
	idDesejo				INT PRIMARY KEY IDENTITY
	,idUsuario				INT FOREIGN KEY REFERENCES Usuarios(idUsuario)
	,DescricaoDesejo		VARCHAR(300) NOT NULL
	,DataCriacao			DATE
);
GO
