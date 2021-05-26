USE WishList_SENAI;
GO

INSERT INTO Usuarios (Email, Senha)
VALUES						('usuarioTeste@gmail.com', 'Senai@312');
GO

INSERT INTO Desejos (idUsuario, DescricaoDesejo, DataCriacao)
VALUES						(1, 'Esse é um desejo de teste :)', getdate());
GO
