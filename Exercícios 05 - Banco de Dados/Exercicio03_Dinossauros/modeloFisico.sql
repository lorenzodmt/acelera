create database dinossauros

CREATE TABLE dinossauros (
    idDinossauro SERIAL PRIMARY KEY,
    nome VARCHAR,
	fk_grupo_idGrupo SERIAL,
    toneladas FLOAT,
    anoDescoberta INTEGER,
    descobridor VARCHAR,
	fk_eras_idEras SERIAL,
    pais VARCHAR
);

CREATE TABLE eras (
    idEras SERIAL PRIMARY KEY,
    nome VARCHAR,
    anoInicio FLOAT,
    anoFim FLOAT
);

CREATE TABLE grupo (
    idGrupo SERIAL PRIMARY KEY,
    nome VARCHAR
);
 
ALTER TABLE dinossauros ADD CONSTRAINT FK_dinossauros_2
    FOREIGN KEY (fk_eras_idEras)
    REFERENCES eras (idEras)
    ON DELETE RESTRICT;
 
ALTER TABLE dinossauros ADD CONSTRAINT FK_dinossauros_3
    FOREIGN KEY (fk_grupo_idGrupo)
    REFERENCES grupo (idGrupo)
    ON DELETE RESTRICT;
	

--CADASTROS:
--Grupo
insert into grupo (nome) values ('Anquilossauros');
insert into grupo (nome) values ('Ceratopsídeos');
insert into grupo (nome) values ('Estegossauros');
insert into grupo (nome) values ('Terápodes');

--Eras
insert into eras (nome, anoInicio, anoFim) values ('Cretáceo', 145, 66);
insert into eras (nome, anoInicio, anoFim) values ('Cretáceo', 70, 66);
insert into eras (nome, anoInicio, anoFim) values ('Jurássico', 201, 145);
insert into eras (nome, anoInicio, anoFim) values ('Cretáceo', 85, 75);
insert into eras (nome, anoInicio, anoFim) values ('Jurássico', 155, 150);
insert into eras (nome, anoInicio, anoFim) values ('Cretáceo', 67, 65);
insert into eras (nome, anoInicio, anoFim) values ('Cretáceo', 66, 63);

--Dinossauros
insert into dinossauros (nome, fk_grupo_idGrupo, toneladas, anoDescoberta, descobridor, fk_eras_idEras, pais) values ('Saichania', 1, 4, 1977, 'Maryanska', 1, 'Mongólia');
insert into dinossauros (nome, fk_grupo_idGrupo, toneladas, anoDescoberta, descobridor, fk_eras_idEras, pais) values ('Tricerátops', 2, 6, 1887, 'John Bell Hatcher', 2, 'Canadá');
insert into dinossauros (nome, fk_grupo_idGrupo, toneladas, anoDescoberta, descobridor, fk_eras_idEras, pais) values ('Kentrossauro', 3, 2, 1909, 'Cientistas Alemães', 3, 'Tanzânia');
insert into dinossauros (nome, fk_grupo_idGrupo, toneladas, anoDescoberta, descobridor, fk_eras_idEras, pais) values ('Pinacossauro', 1, 6, 1999, 'Museu Americano de História Natural', 4, 'China');
insert into dinossauros (nome, fk_grupo_idGrupo, toneladas, anoDescoberta, descobridor, fk_eras_idEras, pais) values ('Alossauro', 4, 3, 1877, 'Othniel Charles Marsh', 5, 'América do Norte');
insert into dinossauros (nome, fk_grupo_idGrupo, toneladas, anoDescoberta, descobridor, fk_eras_idEras, pais) values ('Torossauro', 2, 8, 1891, 'Jhon Bell Hatcher', 6, 'USA');
insert into dinossauros (nome, fk_grupo_idGrupo, toneladas, anoDescoberta, descobridor, fk_eras_idEras, pais) values ('Anquilossauro', 1, 8, 1906, 'Barnum Brown', 7, 'América do Norte');

--Ordem alfabética de nome
select
	dinossauros.nome,
	grupo.nome,
	dinossauros.toneladas,
	dinossauros.anoDescoberta,
	dinossauros.descobridor,
	eras.nome, eras.anoInicio, eras.anoFim,
	dinossauros.pais
from dinossauros
join grupo on grupo.idGrupo = dinossauros.fk_grupo_idGrupo
join eras on eras.idEras = dinossauros.fk_eras_idEras
order by dinossauros.nome

--Ordem alfabética de descobridor
select
	dinossauros.nome,
	grupo.nome,
	dinossauros.toneladas,
	dinossauros.anoDescoberta,
	dinossauros.descobridor,
	eras.nome, eras.anoInicio, eras.anoFim,
	dinossauros.pais
from dinossauros
join grupo on grupo.idGrupo = dinossauros.fk_grupo_idGrupo
join eras on eras.idEras = dinossauros.fk_eras_idEras
order by dinossauros.descobridor


--Ordem de ano de descoberta do grupo Anquilossauros
select
	dinossauros.nome,
	grupo.nome,
	dinossauros.toneladas,
	dinossauros.anoDescoberta,
	dinossauros.descobridor,
	eras.nome, eras.anoInicio, eras.anoFim,
	dinossauros.pais
from dinossauros
join grupo on grupo.idGrupo = dinossauros.fk_grupo_idGrupo
join eras on eras.idEras = dinossauros.fk_eras_idEras
where grupo.nome = 'Anquilossauros'
order by dinossauros.anoDescoberta asc


--Ordem de ano de descoberta entre 1900 e 1999 dos grupos Ceratopsídeos ou Anquilossauros
select
	dinossauros.nome,
	grupo.nome,
	dinossauros.toneladas,
	dinossauros.anoDescoberta,
	dinossauros.descobridor,
	eras.nome, eras.anoInicio, eras.anoFim,
	dinossauros.pais
from dinossauros
join grupo on grupo.idGrupo = dinossauros.fk_grupo_idGrupo
join eras on eras.idEras = dinossauros.fk_eras_idEras
where grupo.nome = 'Anquilossauros' or grupo.nome = 'Ceratopsídeos'
and dinossauros.anoDescoberta > 1900 and dinossauros.anoDescoberta < 1999
order by dinossauros.anoDescoberta asc

