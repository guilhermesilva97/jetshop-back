# jetshop-back

Instruções para rodar o projeto:
 
1 - Utilizar essa query do SQL para criar um banco de dados local: 

-- STEP 1
CREATE DATABASE JetMarket

-- STEP 2
USE JetMarket

-- STEP 3
CREATE TABLE Product (
Id UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
Name NVARCHAR(150),
Image NVARCHAR(MAX),
Description NVARCHAR(2000),
Stock INT,
Status bit,
Price decimal )

-- STEP 4
INSERT INTO 
	Product
VALUES 
	(NEWID(), 
	'Notebook Dell i7 9ª Geração 8 gb de RAM HD SSD 240GB', 
	'https://a-static.mlcdn.com.br/1500x1500/notebook-dell-inspiron-15-3000-3501-a25p-intel-core-i3-4gb-256gb-ssd-156-led-windows-10/magazineluiza/228079200/8a14fa5828e95c1e2052dbbc5ee91e67.jpg', 
	'Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took.',  
	10,
	1,
	3599),
	(NEWID(), 
	'Monitor AOC 20" 144Hz', 
	'https://images-americanas.b2w.io/produtos/01/00/img/1664881/2/1664881234_1GG.jpg',
	'Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took.',  
	5,
	1,
	1399),
	(NEWID(), 
	'Monitor LG 22" 240Hz', 
	'https://i.zst.com.br/thumbs/12/14/33/1673344642.jpg', 
	'Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took.',  
	8,
	1,
	1749),
	(NEWID(), 
	'Mouse Razer Deathadder Essential 5600dpi', 
	'https://images.kabum.com.br/produtos/fotos/49841/49841_1507735187_index_g.jpg', 
	'Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took.',  
	0,
	0,
	599)
  
2 - Colocar o app settings da API apontando para a instância local do banco de dados.
