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

desc tbProdutos;

--insert into tbProdutos(nome,preco,descricao) values();

select * from tbProdutos;

--select nome from tbProdutos;

--select * from tbProdutos where preco = preco;

--update tbProdutos set nome = nome,preco = preco,descricao = descricao where codProd = codProd;

delete from tbProdutos where codProd = codProd;