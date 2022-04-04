create database Skupstinskooni;
use Skupstinskooni;

create table Stranka
(id_stranke int primary key, naziv nvarchar(30), desnolevo nvarchar(30), predsednik nvarchar(30), brojnalisti nvarchar(30), godinaosnivanja nvarchar(30));

create table Auto
(id_auta int primary key, marka nvarchar(30), model nvarchar(30), cena int, godiste int, blindirano nvarchar(30), stakla nvarchar(30), spojleri nvarchar(30),
 nitro nvarchar(30), manuel nvarchar(30));

create table Poslanik
(id_Poslanika int primary key, ime nvarchar(30), prezime nvarchar(30), godiste int, pol nvarchar(30), diploma nvarchar(30), bv_stan nvarchar(30), plata int,
 id_auta int references Auto(id), id_stranke int references Stranka(id));


insert into Auto(id,marka,model,cena,godiste,blindirano,stakla,spojleri,nitro,manuel) values (5,'bmw','x5',20000,2015,'da','da','da','da','ne')
insert into Stranka(id,naziv,desnolevo,predsednik,brojnalisti,godinaosnivanja) values (7,'dss','desno','jovanovic',7,2012)
insert into Poslanik(id_poslanika,ime,prezime,godiste,pol,diploma,bv_stan,plata,id_auta,id_stranke) values (6,'Marinika','Tepic',1976,'zena','da','ne',250,1,2)


/* Izbacuje sve korumpirane poslanike i kola koja voze */ select ime,prezime,marka,model  from Poslanik  join Auto on Poslanik.id_auta= Auto.id where diploma = 'ne'

/* Izbacuje ko je lider stranke na osnovu unetih podataka */ select predsednik from Stranka where naziv='&naziv';