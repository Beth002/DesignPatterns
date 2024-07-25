

CREATE DATABASE labo_db
go
use labo_db
go
create table tClient
(
	id int primary key identity(1,1),
	noms nvarchar(100),
	adresse nvarchar(100),
	contact nvarchar(15)
)
go
create table tCategorie
(
	id int primary key identity(1,1),
	designation nvarchar(100)
)
go
create table tProduit
(
	id int primary key identity(1,1),
	nom_produit nvarchar(100),
	pu decimal(30,2),
	refCatgorie int foreign key references tCategorie(id)
)
go
create table tVente
(
	id int primary key identity(1,1),
	date_vente date,
	refClient int foreign key references tClient(id)
)
go
create table tDetailVente
(
	id int primary key identity(1,1),	
	refProduit int foreign key references tProduit(id),
	qte int,
	pu_vente decimal(30,2)
)
