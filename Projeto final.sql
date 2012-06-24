USE master;
GO

CREATE DATABASE SistemaFinanceiro;
GO

USE SistemaFinanceiro;
GO

CREATE TABLE Categoria(
CodigoCat INT  NOT NULL PRIMARY KEY IDENTITY,
DescricaoCat VARCHAR(20) NOT NULL,
Orcamento DECIMAL(6,2) NOT NULL);
GO

CREATE TABLE Registros(
Codigo INT NOT NULL PRIMARY KEY IDENTITY,
Descricao VARCHAR(40) NOT NULL,
Valor DECIMAL(6,2) NOT NULL ,
Categoria INT  NOT NULL FOREIGN KEY REFERENCES Categoria(CodigoCat),
Recorrente tinyint,
DataVencimento DATE,
DataPagamento DATE,
DataCadastro DATE NOT NULL);
GO