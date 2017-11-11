create database db_RH

create table login_usr(
usuario varchar (20) primary key,
senha varchar (30),
nome varchar (150),
tema int,
estilo int
)

create table setor(
codSetor int identity (1,1) primary key,
setor varchar(20)
)


insert into setor values ('Financeiro')
insert into setor values ('Logistica')
insert into setor values ('Produção')
insert into setor values ('RH')
insert into setor values ('Vendas')


create table funcionario(
cod_func int identity(1,1) primary key,
nome_func varchar(150),
cpf_func varchar(14),
banco_Func varchar (30),
cont_banco_func int, 
agencia_banco_func int,
salario_func money,
codSetor int references setor(codSetor),
dataAdim date
)

create table holerite(
codHolerite int identity (1,1) primary key,
cod_func int references funcionario(cod_func),
dataEmissao date,
ht int,
hf int,
salLiq money
)