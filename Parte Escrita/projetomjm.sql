create database projetomjm;

use projetomjm;

drop table projeto;

create table projeto(
    codigo int primary key auto_increment not null,
    nome varchar(150) not null,
    tipo varchar(150) not null,
    descricao varchar(150) not null,
    orcamento decimal(5,2) not null,
    statu varchar(150) not null,
    integrante varchar(150) not null
)engine=innodb; 

create table entrar(
    login varchar(150) not null,
    senha varchar(150) not null
)engine=innodb; 

select * from entrar;

delete from projeto where codigo = 1;

select * from entrar where login = 'Penha' and senha = 123;

