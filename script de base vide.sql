/* Nom(s) : 
Gabriel Jacob
Alexis Lavertu
*/


/* PARTIE 2 */
/* détruit la bd si elle existe */
use master 
Go 
IF  EXISTS (SELECT name FROM sys.databases WHERE name = 'AL_GJ_Travail')
  drop database AL_GJ_Travail
  GO
/* création de votre bd et de vos tables */
  Create Database AL_GJ_Travail
  go
  Use AL_GJ_Travail
  go
  set dateformat ymd
  go
/* Cas òu toutes les contraintes sont définis DANS le create de la table, auncune contrainte après le create (dans le cas d'une table avec clé étrangère)*/
CREATE TABLE tbl_Marque
(no_Marque int primary key not null identity,
nom_Marque nvarchar(255) not null unique
)
go
Create table tbl_Projet
(no_Projet int primary key not null identity,
nom_projet nvarchar(255) null,
description_projet nvarchar(255) not null unique
)
go
Create table tbl_Employe
(no_Employe int primary key not null identity,
Nom nvarchar(255) not null,
Prénom nvarchar(255) not null,
Courriel nvarchar(255) not null
)
go
/* Cas où toutes les contraintes sont définis APRÈS la creation de la table (dans le cas d'une table avec clé étrangère)*/
Create table tbl_Inventaire
(no_Piece int primary key not null identity,
no_Piece_Entreprise nvarchar(100) unique,
nom_Piece nvarchar(255) not null,
description_Piece nvarchar(255) not null,
quantite int not null default 0,
quantite_Critique int null default 0,
quantite_Minimum int null default 0,
no_Marque int foreign key references tbl_Marque(no_Marque) not null
)
go
alter table tbl_Inventaire
add constraint check_quantite check (quantite >= 0)
go
Create table tbl_Impute
(no_Impute int not null identity,
no_Piece int not null,
no_Projet int not null,
no_Employe int not null,
date DateTime null,
quantite_Retire int null
)
go
/* contraintes */
Alter table tbl_Impute
add constraint def_date default '2000-01-01 00:00:00' for date,
constraint grp_PKs primary key (no_Impute, no_Piece, no_Projet, no_Employe),
constraint fk_no_Piece foreign key (no_Piece) references tbl_Inventaire(no_Piece),
constraint fk_no_Projet foreign key (no_Projet) references tbl_Projet(no_Projet),
constraint fk_no_Employe foreign key (no_Employe) references tbl_Employe(no_Employe),
constraint def_quantite_Retire default 0 for quantite_Retire
go
/* modification d'un null en not null */
Alter table tbl_Projet
Alter column nom_projet nvarchar(255) not null
go


/* PARTIE 3 */

/* insertion de données en batch à partir de lt_DonneesLibres*/
Insert into tbl_Employe (Nom, Prénom, Courriel)
Select Nom, Prénom, Courriel from ltDonneesLibres.dbo.Feuil2$DonnéesExternes_1
go
/* insertion données spécifiques */
/* 1- */
Insert into tbl_Marque (nom_Marque)
Values ('Marque spécial')
go
Insert into tbl_Projet(nom_projet,description_projet)
Values ('Projet spécial','fornite')
go
Insert into tbl_Inventaire(nom_Piece,no_Piece_Entreprise, description_Piece, quantite, quantite_Minimum, quantite_Critique, no_Marque)
Values ('Pièce spécial','P1','Cette pièce est super duper spéciale',69,0,5, 1)
go
Insert into tbl_Employe (Nom, Prénom, Courriel)
Values ('Auger', 'Benoit', 'benoit.auger2@montreal.ca')
go
Insert into tbl_Impute(no_Employe, no_Piece, no_Projet, date, quantite_Retire)
Values (104, 1, 1, '2020-02-15 00:00:00', 10)
go
/*Update tbl_Inventaire set quantite = quantite - 10
Where no_Piece = 1
go*/
/* 2- */
Select * from tbl_Employe
Where Nom = 'Auger' And Prénom = 'Benoit'
go
Insert into tbl_Projet(nom_projet, description_projet)
Values ('Projet de tours 2','MOn projet (Alexis)')
go
Insert into tbl_Impute(no_Employe, no_Piece, no_Projet, date, quantite_Retire)
Values (27, 1, 2, '2023-01-15 00:00:00', 5)
go
/*Update tbl_Inventaire
set quantite = quantite - 5
where no_Piece = 1
go*/
/* 3- */
Insert into tbl_Employe(Nom, Prénom, Courriel)
Values ('Jacob', 'Gabriel', '2137323@cegepba.qc.ca')
go
insert into tbl_Impute(no_Employe, no_Piece, no_Projet, date, quantite_Retire)
Values (105, 1, 1, '2023-02-15 00:00:00', 11)
go
/*Update tbl_Inventaire
set quantite = quantite - 11
where no_Piece = 1
go*/

/* 4 ajouts par table */
go
Insert into tbl_Marque(nom_Marque)
Values ('NVidia'),
('Asus'), ('Intel')
go
Insert into tbl_Inventaire(nom_Piece,no_Piece_Entreprise,description_Piece,quantite,quantite_Critique,quantite_Minimum,no_marque)
Values ('Carte graphique','CG1','une carte','40','10', '20',2),
('Carte mère','CM1','mère','200','10', '15',3),
('Processeur','P2','procceseur','30','15', '20',4)
go
insert into tbl_Projet(nom_Projet, description_projet)
values('ordidateur portable','projet portable'),('tours ordinateur','projet de tours pour quelquun'),('Serveur','serveur pour compagnie')
go
insert into tbl_Employe(Prénom,Nom,Courriel)
values('Jésus','crist','JésusCrist@JeSuisUnMessi.com'),('Olivier','Ouiellete','OlivierGamer@gmail.com'),('Jean-Phillipe','Debleaua','JeanPhil@FILIPO.com')
go
Insert into tbl_Impute(no_Piece,no_Projet,no_Employe,date,quantite_Retire)
Values (2,3,106,'2020-04-22 00:00:00',10),
(3,4,107,'2021-10-22 00:00:00',20),
(4,4,108,'2023-02-22 00:00:00',30)
go
/* UN grand select pour démontrer les ajouts imposés */
Select * from tbl_Employe
where no_Employe >105
go
Select* from tbl_Impute
go
Select* from tbl_Inventaire
go
Select* from tbl_Marque
go
Select* from tbl_Projet
go
/* test des contraintes de la partie 2, les mettre en commentaire car ils donneront une erreur et on ne veut pas 
   que notre script donne des erreurs à l'exécution*/
/* matière première pas < 0 */
/*update tbl_Inventaire set quantite = quantite - 1000000
where no_Piece = 1*/

/* nombre de commandes minimum > 0 ET défaut de la date */
/*insert into tbl_Impute(no_Piece,no_Projet,no_Employe,quantite_Retire)
values(1,4,107, 2)
go*/

/* marque unique */
  /*insert into tbl_Marque(nom_Marque)
values('marque spéciale')
go*/

/* description de projet  unique */
/*Insert into tbl_Projet(nom_projet,description_projet)
values ('1','1')*/


	/* partie 4 */

		Create procedure RecherchePieceParNoPiece
		@noPieceDemandé nvarchar(100)
		AS
		select no_Piece_Entreprise, nom_Piece, quantite
		from tbl_Inventaire
		where no_Piece_Entreprise like '%'+@noPieceDemandé+'%'
		GO

		create procedure selectionnerEmployeSelonRecherche
		@searchTerm nvarchar(50) 
		AS
		select no_Employe, Nom + ' ' + Prénom + ' ' + Courriel as 'InfoEmploye'
		from tbl_Employe
		where Nom like '%'+@searchTerm+'%' or Prénom like '%'+@searchTerm+'%'
		order by Nom, Prénom
		GO

		Create procedure getImputeByYearAndMonth
		@no_Piece_Entreprise nvarchar(100),
		@yearSearchTerm nvarchar(10)
		as
		select no_Impute, date, quantite_Retire, tbl_Projet.description_projet, tbl_Employe.Nom, tbl_Employe.Prénom from tbl_Impute
		inner join tbl_Inventaire on tbl_Impute.no_Piece = tbl_Inventaire.no_Piece
		inner join tbl_Employe on tbl_Impute.no_Employe = tbl_Employe.no_Employe
		inner join tbl_Projet on tbl_Impute.no_Projet = tbl_Projet.no_Projet
		where tbl_Inventaire.no_Piece_Entreprise = @no_Piece_Entreprise and date > @yearSearchTerm 
		go

		Create procedure SuppressionDobjetDeLInventaire
        @QuantiteAEnlever int,@no_Piece int
        as
        update tbl_Inventaire set quantite = quantite - @QuantiteAEnlever
        where no_Piece = @no_Piece
		go

	/*Travail Pratique 2*/

		Create table tbl_quantiteAccepteePourProjet
		(
		no_Projet int foreign key references tbl_Projet(no_Projet) not null,
		no_Piece int foreign key references tbl_Inventaire(no_Piece) not null,
		quantiteAcceptee int check (quantiteAcceptee >= 0)
		)
		go
		alter table tbl_quantiteAccepteePourProjet
		add constraint pK_ProjetEtPiece primary key (no_Projet, no_Piece)
		go
		


