create database biblioteca

create table autor(
	id_autor serial,
	nome_nacionalidade varchar(50),
	PRIMARY KEY(id_autor)
)


create table categoria(
	id_categoria serial,
	tipo_categoria varchar(30),
	PRIMARY KEY(id_categoria)
)


create table editora(
	id_editora serial,
	nome varchar(30),
	PRIMARY KEY(id_editora)
)


create table livro(
	isbn varchar(30),
	titulo varchar(50),
	ano_publicacao integer,
	fk_editora serial,
	fk_autor serial,
	fk_categoria serial,
	foreign key(fk_editora) references editora(id_editora),
	foreign key(fk_autor) references autor(id_autor),
	foreign key(fk_categoria) references categoria(id_categoria),
	primary key(isbn)
)

--CADASTROS:
--Editora
insert into editora (nome) values ('Rocco');
insert into editora (nome) values ('Wmf Martins Fontes');
insert into editora (nome) values ('Casa da Palavra');
insert into editora (nome) values ('Belas Letras');
insert into editora (nome) values ('Matrix');

--Categoria
insert into categoria (tipo_categoria) values ('Literatura Juvenil');
insert into categoria (tipo_categoria) values ('Ficção Científica');
insert into categoria (tipo_categoria) values ('Humor');

--Autor
insert into autor (nome_nacionalidade) values ('J. K. Rowling (Inglaterra)');
insert into autor (nome_nacionalidade) values ('Clive Staples Lewis (Inglaterra)');
insert into autor (nome_nacionalidade) values ('Affonso Solano (Brasil)');
insert into autor (nome_nacionalidade) values ('Marcos Piangers (Brasil)');
insert into autor (nome_nacionalidade) values ('Ciro Botelho - Tiririca (Brasil)');
insert into autor (nome_nacionalidade) values ('Bianca Mól (Brasil)');

--Livro
Insert into livro values (8532511015, 'Harry Potter e A Pedra Filosofal', 2000, 1, 1, 1);
Insert into livro values (9788578270698, 'As Crônicas de Nárnia', 2009, 2, 2, 1);
Insert into livro values (9788577343348, 'O Espadachim de Carvão', 2013, 3, 3, 2);
Insert into livro values (9788581742458, 'O Papai É Pop', 2015, 4, 4, 3);
Insert into livro values (9788582302026, 'Pior Que Tá Não Fica', 2015, 5, 5, 3);
Insert into livro values (9788577345670, 'Garota Desdobrável', 2015, 3, 6, 1);
Insert into livro values (8532512062, 'Harry Potter e o prisioneiro de Azkaban', 2000, 1, 1, 1);


--Ordem alfabética de título
select 
	livro.isbn,
	livro.titulo,
	livro.ano_publicacao,
	editora.nome,
	autor.nome_nacionalidade,
	categoria.tipo_categoria
from livro
join categoria on categoria.id_categoria = livro.fk_categoria
join editora on editora.id_editora = livro.fk_editora
join autor on autor.id_autor = livro.fk_autor
order by titulo asc


--Ordem alfabética de autor
select 
	livro.isbn,
	livro.titulo,
	livro.ano_publicacao,
	editora.nome,
	autor.nome_nacionalidade,
	categoria.tipo_categoria
from livro
join categoria on categoria.id_categoria = livro.fk_categoria
join editora on editora.id_editora = livro.fk_editora
join autor on autor.id_autor = livro.fk_autor
order by nome_nacionalidade asc


--Ordem de ano
select 
	livro.isbn,
	livro.titulo,
	livro.ano_publicacao,
	editora.nome,
	autor.nome_nacionalidade,
	categoria.tipo_categoria
from livro
join categoria on categoria.id_categoria = livro.fk_categoria
join editora on editora.id_editora = livro.fk_editora
join autor on autor.id_autor = livro.fk_autor
order by nome_nacionalidade asc

--Ordem entre os anos 2000 e 2010 das categorias de humor ou ficção científica
select 
	livro.isbn,
	livro.titulo,
	livro.ano_publicacao,
	editora.nome,
	autor.nome_nacionalidade,
	categoria.tipo_categoria
from livro
join categoria on categoria.id_categoria = livro.fk_categoria
join editora on editora.id_editora = livro.fk_editora
join autor on autor.id_autor = livro.fk_autor
where categoria.tipo_categoria = 'Ficção Científica' or categoria.tipo_categoria = 'Humor'
and livro.ano_publicacao > 2000 and livro.ano_publicacao < 2010
order by livro.ano_publicacao asc
