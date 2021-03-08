create database biblio
use biblio

create table adherents(
codAdh int primary key identity,
nomAdh varchar(20),
adrAdh varchar(20),
telAdh varchar(20),
cinAdh varchar(6),
dnAdh date,
typAdh varchar(20)
)

create table ouvrages(
codeOuv int primary key,
titOuv varchar(20),
nomAut varchar(20),
typPouv varchar(20),
resOuv varchar(20),
theme varchar(20),
nomcol varchar(20),
nomDit varchar(20),
dateDit date,
datAch date
)

create table Emprunts(
NumEmp int primary key,
codAdh int,
codOuv int,
dateEmp date,
dateRet date,
constraint fk_empunts_adherents foreign key(codAdh) references adherents(codAdh),
constraint fk_emprunts_ouvrages foreign key(codOuv) references ouvrages(codeOuv)
)

-- Le code adh�rent doit �tre automatiquement incr�menter. (1Pts
-- j'ai ajoute la contraint identity
select * from adherents
where left(nomAdh,1)='c'