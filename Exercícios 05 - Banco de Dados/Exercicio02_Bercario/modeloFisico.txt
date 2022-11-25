create database bercario

CREATE TABLE bebe (
	idBebe SERIAL PRIMARY KEY,
    altura FLOAT,
    peso FLOAT,
    dataNasc DATE,
    nome VARCHAR,
    fk_mae_idMae SERIAL,
    fk_medico_CRM SERIAL
);

CREATE TABLE mae (
	idMae SERIAL PRIMARY KEY,
    nome VARCHAR,
    endereco VARCHAR,
    telefone VARCHAR,
    dataNasc DATE
);

CREATE TABLE medico (
    CRM SERIAL PRIMARY KEY,
    nome VARCHAR,
    telefone VARCHAR,
    especialidade VARCHAR
);
 
ALTER TABLE bebe ADD CONSTRAINT FK_bebe_2
    FOREIGN KEY (fk_mae_idMae)
    REFERENCES mae (idMae)
    ON DELETE RESTRICT;
 
ALTER TABLE bebe ADD CONSTRAINT FK_bebe_3
    FOREIGN KEY (fk_medico_CRM)
    REFERENCES medico (CRM)
    ON DELETE RESTRICT;