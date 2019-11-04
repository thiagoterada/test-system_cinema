CREATE DATABASE CINEMA;
USE CINEMA;

CREATE TABLE FILME(idFilme int primary key auto_increment,
				   nm varchar(40) not null,
                   classif int not null,
                   categ varchar(40) not null,
                   durac varchar(8) not null,
                   ano int not null
);

CREATE TABLE SESSAO(idSessao int primary key auto_increment,
					dt date not null,
                    hr time not null,
                    nroSala int not null,
                    idFilme int not null,
                    capSala int not null,
                    tipo varchar(4) not null,
                    valor decimal(10,2) not null
);