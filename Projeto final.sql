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
Descricao VARCHAR(40) NOT NULL ,
Valor DECIMAL(6,2) NOT NULL ,
Categoria INT  NOT NULL FOREIGN KEY REFERENCES Categoria(CodigoCat),
Status1 tinyint,
DataVencimento DATE,
DataPagamento DATE,
DataCadastro DATE not null,
Parcelas int);
GO

INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Casa', 200.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Carro', 350.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Outros', 150.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Alimentação', 300.00);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(1, 'Água', -35.50, getdate(),'05-23-2012', '06-09-2012', null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(1, 'Lúz', -75.00, getdate(), '05-13-2012', '06-08-2012', null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(3, 'Outros', -35.50, getdate(), '05-17-2012', '06-15-2012',  null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(2, 'Gasolina', -60.50, getdate(), '05-22-2012', '06-18-2012',  null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(3, 'Remédio', -35.50, getdate(), '05-20-2012', '06-25-2012', null, 1);

select * from Registros;
go

select * from Categoria;
go
 