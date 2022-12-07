create table DBSM.PREDIOS_Lorenzo (
    ID_PREDIO integer not null primary key,
    ID_BEM integer,
    NOME_PREDIO varchar(60),
    LOCALIZACAO varchar(60),
    OBSERVACAO clob,
    TIPO_POSSE_ITEM integer,
    TIPO_POSSE_TAB integer,
    NUM_PREDIO varchar(10),
    BLOCO varchar(10),
    LOCAL_FISICO_TAB integer,
    LOCAL_FISICO_ITEM integer,
    COD_OPERADOR integer,
    DT_ALTERACAO date,
    HR_ALTERACAO date,
    CONCORRENCIA integer,
    ENDERECO_FISICO varchar(15))




create table DBSM.ESPACOS_Lorenzo (
    ID_ESPACO integer not null primary key,
    ID_PREDIO integer references PREDIOS_A(ID_PREDIO),
    NOME_ESPACO varchar(40),
    AREA decimal(11,2),
    DIMENSOES varchar(20),
    CAPACIDADE integer,
    TIPO_ESPACO_ITEM integer,
    TIPO_ESPACO_TAB integer,
    NUM_SALA varchar(10),
    COD_OPERADOR integer,
    DT_ALTERACAO date,
    HR_ALTERACAO date,
    CONCORRENCIA integer,
    ENDERECO_FISICO varchar(15))

