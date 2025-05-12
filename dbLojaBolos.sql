-- drop database dbLojaBolos;

create database dbLojaBolos;

use dbLojaBolos;

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

-- insert into tbProdutos(nome,preco,descricao) values('matheus',100,'abc');

-- insert into tbVendas(dataVenda,valor,quantidade,codProd) values('2025/04/25',150,'12',1);

-- insert into tbVendas(valor) values();

-- insert into tbProdutos(nome,preco,descricao) values();

-- select codProd as Codigo, nome as Produto, preco as Preco, descricao as Descrição from tbProdutos;

-- select nome from tbProdutos;

-- select * from tbProdutos where preco = preco;

-- update tbProdutos set nome = nome,preco = preco,descricao = descricao where codProd = codProd;

-- delete from tbProdutos where codProd = codProd;

-- select p.nome, v.valor,v.quantidade from tbVendas as v inner join tbProdutos as p on v.codProd = p.codProd;

select * from tbVendas;