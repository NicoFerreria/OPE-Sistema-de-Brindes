CREATE TABLE 'Usuario' (
	'id_vendedor'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	'nome_vend'	TEXT NOT NULL,
	'login'	TEXT NOT NULL,
	'contas'	INTEGER,
	'senha_login'	TEXT NOT NULL
)

CREATE TABLE 'Cliente' (
	'id_clt'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	'cnpj_clt'	INTEGER NOT NULL UNIQUE,
	'nome_fantasia_clt'	TEXT NOT NULL,
	'razao_social_clt'	TEXT NOT NULL,
	'status_clt'	INTEGER(1) NOT NULL DEFAULT 0,
	'endereco_clt' TEXT NOT NULL,
	'numero_clt' INTEGER,
	'telefone_clt' INTEGER,
	'nome_contato_clt' TEXT,
	'complemento_clt' TEXT,
	'email_contato_clt' TEXT
)

CREATE TABLE 'Fornecedor' (
	'id_fornec'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	'cnpj_fornec'	INTEGER NOT NULL UNIQUE,
	'nome_fantasia_fornec'	TEXT NOT NULL,
	'razao_social_fornec'	TEXT NOT NULL,
	'status_fornec' INTEGER(1) NOT NULL DEFAULT 0,
	'endereco_fornec' TEXT NOT NULL, 
	'numero_fornec' INTEGER,	
	'telefone_fornec' INTEGER,
	'nome_contato_fornec' TEXT,
	'email_contato_fornec' TEXT
)

CREATE TABLE 'Terceiras' (
	'id_tercei'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	'CNPJ_Terc'	INTEGER NOT NULL UNIQUE,
	'Nome_terc'	TEXT NOT NULL,
	'Telefone_terc'	INTEGER,
	'Endereco_terc'	TEXT
)

CREATE TABLE 'Produto' (
	'id_prod'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	'cod_prod'	INTEGER NOT NULL,
	'desc_prod' TEXT NOT NULL,
	'categoria_prod' TEXT NOT NULL,
	'status_prod' INTEGER NOT NULL DEFAULT 0
)
CREATE TABLE 'Orcamento' (
	'id_orc'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	'Status_orc'	TEXT NOT NULL DEFAULT 'ABERTO',
	'id_produ'	INTEGER NOT NULL,
	'valor_unit_orc'	INTEGER,
	'valor_orc'	INTEGER,
	'id_clt'	INTEGER NOT NULL,
	'nome_clt'	INTEGER NOT NULL,
	'Endereco_clt'	INTEGER NOT NULL,
	'Telefone_clt'	INTEGER NOT NULL,
	'CPF_Clt'	INTEGER NOT NULL,
	'qtd_unit_produ'	INTEGER NOT NULL,
	'Vendedor'	TEXT NOT NULL,
	FOREIGN KEY('id_produ') REFERENCES 'Produto'('id_produ'),
	FOREIGN KEY('nome_clt') REFERENCES 'Cliente'('Nome_clt'),
	FOREIGN KEY('id_clt') REFERENCES 'Cliente'('Id_clt'),
	FOREIGN KEY('Endereco_clt') REFERENCES 'Cliente'('Endereco_clt'),
	FOREIGN KEY('Telefone_clt') REFERENCES 'Cliente'('Telefone_clt'),
	FOREIGN KEY('CPF_Clt') REFERENCES 'Cliente'('CPF')
)

CREATE TABLE 'ItemPedido' (
	'id_orc'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	'id_ped'	INTEGER UNIQUE,
	'id_produ'	INTEGER NOT NULL,
	'Valor_unit_produ'	INTEGER,
	'qtd_unit_produ_orc'	INTEGER NOT NULL,
	FOREIGN KEY('id_produ') REFERENCES 'Produto'('id_produ'),
	FOREIGN KEY('qtd_unit_produ_orc') REFERENCES 'Orcamento'('qtd_unit_produ')
)