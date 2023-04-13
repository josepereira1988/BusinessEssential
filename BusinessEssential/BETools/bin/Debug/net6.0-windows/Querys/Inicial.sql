CREATE DATABASE BEConfig;
USE beconfig;

CREATE TABLE CadastrosDB (
id int NOT NULL AUTO_INCREMENT,
Banco Varchar(30),
Nome VARCHAR(60),
CNPJ VARCHAR(14),
VersaoBase int,
PRIMARY KEY (id));

CREATE TABLE OCTA (
NomeTabela Varchar(10),
Descricao VARCHAR(30),
TbFilho TINYINT(1),
TbPai VARCHAR(10),
DelCas TINYINT(1),
PRIMARY KEY (NomeTabela)
);

CREATE TABLE cta1 (
	NomeTabela Varchar(10),
	NomeCampo VARCHAR(10) NOT NULL,
	PrimariKey TINYINT(1),
	NTNulo TINYINT(1),
	AutoI TINYINT(1),
	Tipo VARCHAR(10),
	Tamanho INT(11),
	Unico TINYINT(1),
	CHEstran TINYINT(1),
	CPEstran VARCHAR(10),
	TBEstran VARCHAR(10),
	TPid VARCHAR(30),
	PRIMARY KEY (`NomeTabela`, `NomeCampo`),
	UNIQUE INDEX `NomeCampo` (`NomeCampo`),
	FOREIGN KEY (`NomeTabela`) 
	REFERENCES `octa` (`NomeTabela`) ON UPDATE CASCADE ON DELETE CASCADE
);