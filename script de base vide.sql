/* Nom(s) : 
Gabriel Jacob
Alexis Lavertu
*/


/* PARTIE 2 */
/* d�truit la bd si elle existe */
use master 
Go 
IF  EXISTS (SELECT name FROM sys.databases WHERE name = 'AL_GJ_Travail')
  drop database AL_GJ_Travail
  GO
/* cr�ation de votre bd et de vos tables */
  Create Database AL_GJ_Travail
  go
  Use AL_GJ_Travail
  go
  set dateformat ymd
  go
/* Cas �u toutes les contraintes sont d�finis DANS le create de la table, auncune contrainte apr�s le create (dans le cas d'une table avec cl� �trang�re)*/
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
Pr�nom nvarchar(255) not null,
Courriel nvarchar(255) not null
)
go
/* Cas o� toutes les contraintes sont d�finis APR�S la creation de la table (dans le cas d'une table avec cl� �trang�re)*/
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

/* insertion de donn�es en batch � partir de lt_DonneesLibres*/
Insert into tbl_Employe (Nom, Pr�nom, Courriel)
Select Nom, Pr�nom, Courriel from ltDonneesLibres.dbo.Feuil2$Donn�esExternes_1
go
/* insertion donn�es sp�cifiques */
/* 1- */
Insert into tbl_Marque (nom_Marque)
Values ('Marque sp�cial')
go
Insert into tbl_Projet(nom_projet,description_projet)
Values ('Projet sp�cial','fornite')
go
Insert into tbl_Inventaire(nom_Piece,no_Piece_Entreprise, description_Piece, quantite, quantite_Minimum, quantite_Critique, no_Marque)
Values ('Pi�ce sp�cial','P1','Cette pi�ce est super duper sp�ciale',69,0,5, 1)
go
Insert into tbl_Employe (Nom, Pr�nom, Courriel)
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
Where Nom = 'Auger' And Pr�nom = 'Benoit'
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
Insert into tbl_Employe(Nom, Pr�nom, Courriel)
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
Values ('Carte graphique','CG1','une carte graphique','40','10', '20',2),
('Carte m�re','CM1','carte m�re','200','10', '15',3),
('Processeur','P2','procceseur','30','15', '20',4)
go
insert into tbl_Projet(nom_Projet, description_projet)
values('ordidateur portable','projet portable'),('tours ordinateur','projet de tours pour quelquun'),('Serveur','serveur pour compagnie')
go
insert into tbl_Employe(Pr�nom,Nom,Courriel)
values('J�sus','crist','J�susCrist@JeSuisUnMessi.com'),('Olivier','Ouiellete','OlivierGamer@gmail.com'),('Jean-Phillipe','Debleaua','JeanPhil@FILIPO.com')
go
Insert into tbl_Impute(no_Piece,no_Projet,no_Employe,date,quantite_Retire)
Values (2,3,106,'2020-04-22 00:00:00',10),
(3,4,107,'2021-10-22 00:00:00',20),
(4,4,108,'2023-02-22 00:00:00',30)
go
/* UN grand select pour d�montrer les ajouts impos�s */
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
   que notre script donne des erreurs � l'ex�cution*/
/* mati�re premi�re pas < 0 */
/*update tbl_Inventaire set quantite = quantite - 1000000
where no_Piece = 1*/

/* nombre de commandes minimum > 0 ET d�faut de la date */
/*insert into tbl_Impute(no_Piece,no_Projet,no_Employe,quantite_Retire)
values(1,4,107, 2)
go*/

/* marque unique */
  /*insert into tbl_Marque(nom_Marque)
values('marque sp�ciale')
go*/

/* description de projet  unique */
/*Insert into tbl_Projet(nom_projet,description_projet)
values ('1','1')*/


	/* partie 4 */

		Create procedure RecherchePieceParNoPiece
		@noPieceDemand� nvarchar(100)
		AS
		select no_Piece_Entreprise, nom_Piece, quantite
		from tbl_Inventaire
		where no_Piece_Entreprise like '%'+@noPieceDemand�+'%'
		GO

		create procedure selectionnerEmployeSelonRecherche
		@searchTerm nvarchar(50) 
		AS
		select no_Employe, Nom + ' ' + Pr�nom + ' ' + Courriel as 'InfoEmploye'
		from tbl_Employe
		where Nom like '%'+@searchTerm+'%' or Pr�nom like '%'+@searchTerm+'%'
		order by Nom, Pr�nom
		GO

		Create procedure getImputeByYearAndMonth
		@no_Piece_Entreprise nvarchar(100),
		@yearSearchTerm nvarchar(10)
		as
		select no_Impute, date, quantite_Retire, tbl_Projet.description_projet, tbl_Employe.Nom, tbl_Employe.Pr�nom from tbl_Impute
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
		quantiteAcceptee int
		)
		go


		alter table tbl_quantiteAccepteePourProjet
		add constraint pK_ProjetEtPiece primary key (no_Projet, no_Piece),
		constraint C_quantiteeAcceptee check (quantiteAcceptee >= 0)
		go


		insert into tbl_quantiteAccepteePourProjet (no_Piece, no_Projet, quantiteAcceptee)
		values (4, 5, 20),(3, 5, 20),(1, 5, 20),
		(3, 4, 10), (2, 3, 30), (1, 2, 40), (2, 2, 40), (4, 2, 40)
		go

		create view vueListerQuantiteAccepteePourProjet
		as
		select tbl_quantiteAccepteePourProjet.no_Piece, no_Projet, no_Piece_Entreprise, tbl_Inventaire.description_Piece, quantiteAcceptee from tbl_quantiteAccepteePourProjet
				inner join tbl_Inventaire on tbl_quantiteAccepteePourProjet.no_Piece = tbl_Inventaire.no_Piece
		go

		create procedure modifierQuantiteeAcceptee
		@no_Projet int,
		@no_Piece int,
		@quantiteAcceptee int
		as

		update vueListerQuantiteAccepteePourProjet
		set quantiteAcceptee = @quantiteAcceptee
		where no_Piece = @no_Piece and no_Projet = @no_Projet
		go

		

		create procedure SupprimerUnProjet
		@no_projet int
		as
		SET NOCOUNT ON;
		begin try
			begin transaction
 	 			/*delete from tbl_Impute where no_Projet = @no_projet*/
				delete from tbl_quantiteAccepteePourProjet where no_Projet = @no_projet
				delete  from tbl_Projet where no_Projet = @no_projet
	 		commit transaction
		end try
		begin catch
		if @@trancount > 0
			begin
				rollback transaction;
				throw 51000,'probl�me durant l''ex�cution, le projet s�lectionn� poss�des des imputations, la destruction a �t� annul�e',1; /* no erreur > 50 000 et < 2 147 483 647 , state entre 0 et 255 (s�v�rit�)*/
			end
		end catch
		go
		/*cree un projet
		declare @no_projet int
		insert into tbl_Projet(nom_projet,description_projet)
		values('test' , 'un petit test') 
		set @no_projet = SCOPE_IDENTITY()
		insert into tbl_quantiteAccepteePourProjet(no_Projet,no_Piece,quantiteAcceptee)
		values(@no_projet,2,30),(@no_projet,3,30)
		select * from tbl_Projet where @no_projet = no_Projet
		select * from tbl_quantiteAccepteePourProjet where @no_projet = no_Projet
		go*/

		/*  marche
		exec SupprimerUnProjet 5*/
		/* ne marchera pas
		exec SupprimerUnProjet 4*/

		update vueListerQuantiteAccepteePourProjet 
		set quantiteAcceptee =  50
		where no_Piece = 1 and no_Projet = 2
		go
		select * from vueListerQuantiteAccepteePourProjet
		go
		
		create trigger verifierQueQuantiteAccepteeNEstPasDepasse
		on tbl_Impute
		for insert,update
		as
		SET NOCOUNT ON
		begin
		if exists (	select * from inserted
					inner join tbl_quantiteAccepteePourProjet on inserted.no_Projet = tbl_quantiteAccepteePourProjet.no_Projet
					and inserted.no_Piece = tbl_quantiteAccepteePourProjet.no_Piece
					inner join tbl_Impute on inserted.no_Projet = tbl_Impute.no_Projet and inserted.no_Piece = tbl_Impute.no_Piece 
					/*where quantite_Retire > quantiteAcceptee*/
					where quantiteAcceptee < (select sum(quantite_Retire) from tbl_Impute
												where inserted.no_Piece = tbl_Impute.no_Piece
												and inserted.no_Projet = tbl_Impute.no_Projet))
												
				begin
			THROW 51000, 'Votre quantit� d�passe la quantit� accept� pour la pi�ce de ce projet', 99;
			rollback
			end
		end
		set nocount off
		go

		/*marche*/
		set dateformat ymd; 
		go
		insert into tbl_Impute(no_Employe, no_Piece, no_Projet, date, quantite_Retire)
		values (1, 1, 2, getDate(), 1), (1, 1, 2, GETDATE(), 20), (1, 2, 3, GETDATE(), 15), (1, 2, 3, GETDATE(), 1)
		go
		delete from tbl_Impute where no_Piece = 1 and no_Projet = 2
		delete from tbl_Impute where no_Piece = 2 and no_Projet = 2
		go

		/*marche pas*/
		/*insert into tbl_Impute(no_Employe, no_Piece, no_Projet, date, quantite_Retire)
		values (1, 1, 2, getDate(), 11), (1, 1, 2, GETDATE(), 30), (1, 2, 3, GETDATE(), 15), (1, 2, 3, GETDATE(), 100)
		go*/
		
		alter table tbl_Projet
		add concurrenceTimeStamp TimeStamp not null
	