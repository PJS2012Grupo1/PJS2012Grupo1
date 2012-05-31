CREATE DATABASE SistemaFinanceiro;
GO

USE SistemaFinanceiro;
GO

CREATE TABLE Categoria(
Codigo INT  NOT NULL PRIMARY KEY IDENTITY,
Descri��o VARCHAR(20) NOT NULL,
Orcamento DECIMAL(6,2) NOT NULL);
GO

CREATE TABLE Registros(
Codigo INT NOT NULL PRIMARY KEY IDENTITY,
Descricao VARCHAR(40) NOT NULL ,
Valor DECIMAL(6,2) NOT NULL ,
Categoria INT  NOT NULL FOREIGN KEY REFERENCES Categoria(Codigo),
Status1 tinyint,
DataVencimento DATE,
DataPagamento DATE,
DataCadastro DATE not null,
Parcelas int);
GO



INSERT INTO Categoria(Descri��o, Orcamento) VALUES('Casa', 200.00);
INSERT INTO Categoria(Descri��o, Orcamento) VALUES('Carro', 350.00);
INSERT INTO Categoria(Descri��o, Orcamento) VALUES('Outros', 150.00);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(1, '�gua', -35.50, getdate(),'05-23-2012', '06-09-2012', null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(1, 'L�z', -75.00, getdate(), '05-13-2012', '06-08-2012', null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(3, 'Outros', -35.50, getdate(), '05-17-2012', '06-15-2012',  null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(2, 'Gasolina', -60.50, getdate(), '05-22-2012', '06-18-2012',  null, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, DataPagamento, Parcelas, Status1) VALUES(3, 'Rem�dio', -35.50, getdate(), '05-20-2012', '06-25-2012', null, 1);

select * from Registros;
go