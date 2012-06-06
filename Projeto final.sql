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
Recorrente tinyint,
DataVencimento DATE,
DataPagamento DATE,
DataCadastro DATE NOT NULL,
Parcelas int NOT NULL);
GO
--Categoria, Descricao, Valor, DataCadastro, DataPagamento, recorrente

INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Casa', 200.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Carro', 350.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Outros', 150.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Alimentação', 300.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Farmácia', 300.00);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(1, 'Água', -45.50, getdate(), '04-03-2012', '04-05-2012', 1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(1, 'Lúz', -87.00, getdate(), '04-16-2012', '04-16-2012', 1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(3, 'Outros', -100.50, getdate(), '04-20-2012', '04-20-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -35.50, getdate(), '04-06-2012', '04-06-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -55.50, getdate(), '04-11-2012', '04-11-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -15.50, getdate(), '04-16-2012', '04-16-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -49.50, getdate(), '04-21-2012', '04-21-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -60.50, getdate(), '04-26-2012', '04-26-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -20.50, getdate(), '04-31-2012', '04-31-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(5, 'Remédio', -35.50, getdate(), '04-19-2012', '04-19-2012', 1, 1); 
           
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(1, 'Água', -35.50, getdate(), '05-03-2012', '05-05-2012', 1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(1, 'Lúz', -75.00, getdate(), '05-16-2012', '05-16-2012', 1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(3, 'Outros', -35.50, getdate(), '05-17-2012', '05-17-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -60.50, getdate(), '05-06-2012', '05-06-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -30.50, getdate(), '05-11-2012', '05-11-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -40.50, getdate(), '05-16-2012', '05-16-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -38.50, getdate(), '05-21-2012', '05-21-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -40.50, getdate(), '05-26-2012', '05-26-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(2, 'Gasolina', -55.50, getdate(), '05-31-2012', '05-31-2012',  1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(5, 'Remédio', -35.50, getdate(), '05-19-2012', '05-19-2012', 1, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(3, 'Celular', -600.00, getdate(), '05-20-2012', '05-20-2012', 12, 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Parcelas, Recorrente) VALUES(1, 'Geladeira', -900.00, getdate(), '05-20-2012', '05-20-2012', 12, 1);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, recorrente) VALUES(3, 'Salário', 2000.00, getdate(), '01-20-2012', 2);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, recorrente) VALUES(3, 'MegaSena', 800.00, getdate(), '06-01-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, recorrente) VALUES(3, 'Aposta', 150.00, getdate(), '06-02-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, recorrente) VALUES(3, 'Esmola', 15.00, getdate(), '06-04-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, recorrente) VALUES(3, 'Auxilio financeiro', 50.00, getdate(), '06-05-2012', 2);

select * from Registros;
go

select * from Categoria;
go
 
