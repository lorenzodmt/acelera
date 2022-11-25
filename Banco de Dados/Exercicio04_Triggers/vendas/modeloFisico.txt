create database exercicioTriggers

CREATE TABLE Produto
(
 cod_prod INT PRIMARY KEY,
 descricao VARCHAR(50) UNIQUE,
 qtde_disponivel INT NOT NULL DEFAULT 0
);

INSERT INTO Produto VALUES (1, 'Feijão', 10);
INSERT INTO Produto VALUES (2, 'Arroz', 5);
INSERT INTO Produto VALUES (3, 'Farinha', 15);

CREATE TABLE ItensVenda
(
 cod_venda  INT,
 id_produto INT,
 qtde_vendida INT,
 FOREIGN KEY (cod_venda) REFERENCES Produto(cod_prod) ON DELETE CASCADE
);

insert into ItensVenda values (1, 1, 3);
insert into ItensVenda values (2, 2, 5);
insert into ItensVenda values (3, 1, 3);
insert into ItensVenda values (4, 2, 5);

CREATE TRIGGER t_atualiza_estoque
BEFORE INSERT ON ItensVenda
FOR EACH ROW
EXECUTE PROCEDURE atualiza_estoque();

CREATE OR REPLACE FUNCTION atualiza_estoque() RETURNS TRIGGER
AS
$$
DECLARE
	qtde integer;
BEGIN
	SELECT qtde_disponivel from Produto where cod_prod = NEW.id_produto into qtde;
	if qtde < NEW.qtde_vendida then
		raise exception 'Quantidade indisponível em estoque.';
	else
		update Produto set qtde_disponivel = qtde_disponivel - NEW.qtde_vendida
			where cod_prod = NEW.id_produto;
	end if;
	return NEW;
END
$$ LANGUAGE plpgsql;