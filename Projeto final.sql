USE master;
GO

DROP DATABASE SistemaFinanceiro;
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

INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Casa', 200.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Carro', 350.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Outros', 150.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Alimentação', 300.00);
INSERT INTO Categoria(DescricaoCat, Orcamento) VALUES('Farmácia', 300.00);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(1, 'Água', -45.50, getdate(), '04-03-2012', '04-05-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(1, 'Lúz', -87.00, getdate(), '04-06-2012', '04-06-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(3, 'Outros', -100.50, getdate(), '04-20-2012', '04-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -35.50, getdate(), '04-06-2012', '04-06-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -55.50, getdate(), '04-11-2012', '04-11-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -15.50, getdate(), '04-16-2012', '04-16-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -49.50, getdate(), '04-21-2012', '04-21-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -60.50, getdate(), '04-26-2012', '04-26-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -20.50, getdate(), '04-30-2012', '04-30-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(5, 'Remédio', -35.50, getdate(), '04-19-2012', '04-19-2012', 1); 
           
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(1, 'Água', -35.50, '05-03-2012', '05-03-2012', '05-05-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(1, 'Lúz', -75.00, '05-16-2012', '05-16-2012', '05-16-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(3, 'Outros', -35.50, '05-17-2012', '05-17-2012', '05-17-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -60.50, '05-06-2012', '05-06-2012', '05-06-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -30.50, '05-11-2012', '05-11-2012', '05-11-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -40.50, '05-16-2012', '05-16-2012', '05-16-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -38.50, '05-21-2012', '05-21-2012', '05-21-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -40.50, '05-26-2012', '05-26-2012', '05-26-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(2, 'Gasolina', -55.50, '05-31-2012', '05-31-2012', '05-31-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(5, 'Remédio', -35.50, '05-20-2012', '05-20-2012', '05-19-2012', 1);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento, Recorrente) VALUES(3, 'Celular 1/12', -50.00, '05-20-2012', '05-20-2012', '05-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 2/12', -50.00, '05-20-2012', '06-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 3/12', -50.00, '05-20-2012', '07-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 4/12', -50.00, '05-20-2012', '08-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 5/12', -50.00, '05-20-2012', '09-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 6/12', -50.00, '05-20-2012', '10-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 7/12', -50.00, '05-20-2012', '11-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 8/12', -50.00, '05-20-2012', '12-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 9/12', -50.00, '05-20-2012', '01-20-2013', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 10/12', -50.00, '05-20-2012', '02-20-2013', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 11/12', -50.00, '05-20-2012', '03-20-2013', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(3, 'Celular 12/12', -50.00, '05-20-2012', '04-20-2013', 1);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataPagamento, DataVencimento,  Recorrente) VALUES(1, 'Geladeira 1/12', -75.00, '04-20-2012', '04-20-2012', '04-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 2/12', -75.00, '05-20-2012', '05-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 3/12', -75.00, '05-20-2012', '06-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 4/12', -75.00, '05-20-2012', '07-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 5/12', -75.00, '05-20-2012', '08-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 6/12', -75.00, '05-20-2012', '09-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 7/12', -75.00, '05-20-2012', '10-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 8/12', -75.00, '05-20-2012', '11-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 9/12', -75.00, '05-20-2012', '12-20-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 10/12', -75.00, '05-20-2012', '01-20-2013', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 11/12', -75.00, '05-20-2012', '02-20-2013', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, DataVencimento, Recorrente) VALUES(1, 'Geladeira 12/12', -75.00, '05-20-2012', '03-20-2013', 1);

INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, recorrente) VALUES(3, 'Salário', 2000.00, getdate(), 2);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, recorrente) VALUES(3, 'Esmola', 15.00, '06-04-2012', 1);
INSERT INTO Registros(Categoria, Descricao, Valor, DataCadastro, recorrente) VALUES(3, 'Auxilio financeiro', 50.00, '06-05-2012', 2);

select * from Registros;
go

select * from Categoria;
go
 
