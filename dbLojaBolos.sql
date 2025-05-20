-- drop database dbLojaBolos;

create database dbLojaBolos;

use dbLojaBolos;

create table tbRegistro(
codReg int not null auto_increment,
data date,
codigo int,
preco decimal(9,2),
nome varchar(100),
quantidade char(100),
valorTotal decimal(9,2),
totalVenda varchar(100),
primary key (codReg)
);

create table tbProdutos(
codProd int not null auto_increment,
nome varchar(100) not null,
preco decimal(9,2) not null,
descricao varchar(100),
primary key (codProd)
); 

CREATE TABLE tbVendas (
codVend INT NOT NULL AUTO_INCREMENT,
dataVenda DATE,
valor DECIMAL(9,2),
quantidade CHAR(100),
PRIMARY KEY (codVend),
codProd INT, 
CONSTRAINT fk_codProd FOREIGN KEY (codProd) REFERENCES tbProdutos(codProd) ON DELETE SET NULL
);


desc tbProdutos;
desc tbVendas;
desc tbRegistro;

select * from tbRegistro;