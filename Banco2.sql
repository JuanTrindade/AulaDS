create database projetods;

use projetods;

CREATE TABLE Pessoa
(
	idPessoa INT PRIMARY KEY IDENTITY(1,1),
	cargo VARCHAR(100),
	dtNascimento date,
	sexo VARCHAR(100),
	ativo binary(01),
	telFixo VARCHAR(15),
	telCelular VARCHAR(15),
	Rg VARCHAR(100),
	Cpf VARCHAR(12),
	Nome VARCHAR(100),
	userName VARCHAR(100) NOT NULL,
	email VARCHAR(150) NOT NULL,
	senha VARCHAR(100) NOT NULL,
)

SELECT * from Pessoa;

INSERT INTO Pessoa (Nome,userName,email,senha) Values ('juan trindade','juantrindade','juantrindade123@gmail.com','123456');

INSERT INTO Pessoa (Nome,userName,email,senha,cargo) Values ('marcelo pelaes','Marcelo','marcelinho123@gmail.com','marcelaoo','Funcionario');

UPDATE Pessoa set Cargo = 'Admin' WHERE idPessoa = 1;