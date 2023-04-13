-- Query Criar base de dados Nova
-- Criar Base de dados
CREATE DATABASE @BancoDeDados;
USE @BancoDeDados;

-- Criar Tabelas
-- Tabela de Usuarios

CREATE TABLE OCTA (
NomeTabela Varchar(10),
Descricao VARCHAR(30),
TbFilho TINYINT(1),
TbPai VARCHAR(10),
PRIMARY KEY (NomeTabela)
);

CREATE TABLE `cta1` (
	NomeTabela Varchar(10),
	`NomeCampo` VARCHAR(10) NOT NULL,
	`PrimariKey` TINYINT(1),
	`NTNulo` TINYINT(1),
	`AutoI` TINYINT(1),
	`Tipo` VARCHAR(10),
	`Tamanho` INT(11),
	`Unico` TINYINT(1),
	TPid VARCHAR(30),
	PRIMARY KEY (`NomeTabela`, `NomeCampo`),
	UNIQUE INDEX `NomeCampo` (`NomeCampo`),
	FOREIGN KEY (`NomeTabela`) 
	REFERENCES `octa` (`NomeTabela`) ON UPDATE CASCADE ON DELETE CASCADE
);

USE beconfig;
INSERT cadastrosdb (Banco,Nome,CNPJ,VersaoBase) VALUES ('@BancoDeDados','@Nome','@CNPJ','@VersaoBase');