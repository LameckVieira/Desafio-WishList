USE WishList_SENAI;
GO

SELECT * FROM Usuarios
GO

SELECT * FROM Desejos
GO

SELECT Email, DescricaoDesejo, DataCriacao 
FROM Desejos
INNER JOIN Usuarios
ON Desejos.idUsuario = Usuarios.idUsuario