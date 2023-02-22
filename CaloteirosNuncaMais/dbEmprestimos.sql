USE master
GO
CREATE DATABASE dbEmprestimos
GO
USE dbEmprestimos
--drop database dbEmprestimos
GO
CREATE TABLE Emprestimo (
	Id int primary key identity(1,1),
	Nome varchar(max) not null,
	Email varchar(max) not null,
	Valor decimal(10,2) check(Valor > 0) not null,
	MesesAtrasados int default 0,
	Pago varchar(max) null,
	DataEmp date not null,
	DataPrevisao date not null,
	Assinatura varbinary(max) null
)