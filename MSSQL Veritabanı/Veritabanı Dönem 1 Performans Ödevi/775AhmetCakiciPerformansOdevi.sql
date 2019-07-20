create database okul;
use okul;

create table MedeniDurum
(
MedeniDurumNo int identity(1,1)primary key,
Bilgi varchar(5)not null
);
insert into MedeniDurum(Bilgi)values('Evli'),('Bekar');
select*from MedeniDurum;

create table Cinsiyet
(
CinsiyetNo int identity(1,1)primary key,
Cinsiyet char(5) not null
);
insert into Cinsiyet(Cinsiyet)values('Erkek'),('Bayan')
select*from Cinsiyet

create table KanGrubu
(
KanGrubuNo int identity(1,1)primary key,
Bilgi varchar(6)not null
);
insert into KanGrubu(Bilgi)values('A rH+'),('A rH-'),('B rH+'),('B rH-'),('0 rH+'),('0 rH-');
select*from KanGrubu

create table Gorev
(
GorevNo int identity(1,1)primary key,
GorevAd varchar(25)not null
); 
insert into Gorev(GorevAd)values('Temizlik Ýþleri'),('Bekçi'),('Çay Ocaðý Çalýsaný')
select*from Gorev;

create table Egitim
(
EgitimNo int identity(1,1)primary key,
EgitimDurumu varchar(19)not null
);
insert into Egitim (EgitimDurumu)values('Ýlkokul'),('Orta Okul'),('Lise'),('Üniversite')
select*from Egitim

create table Personel
(
PersonelNo int identity(1,1)primary key,
Ad varchar(15)not null,
Soyad varchar(20)not null,
Tc char(11),
DogumTarihi date,
IseBaslamaTarihi date,
Tel char(10),
Maas decimal(7,2),
CinsiyetNo int,
KanGrubuNo int,
GorevNo int,
EgitimNo int,
MedeniDurumNo int,
Constraint FK_Cinsiyet foreign key (CinsiyetNo) references Cinsiyet(CinsiyetNo),
Constraint FK_KanGrubu foreign key (KanGrubuNo) references KanGrubu(KanGrubuNo),
Constraint FK_Gorev foreign key (GorevNo) references Gorev(GorevNo),
Constraint FK_Egitim foreign key (EgitimNo) references Egitim(EgitimNo),
Constraint FK_MDurum foreign key (MedeniDurumNo) references MedeniDurum(MedeniDurumNo)
);
insert into personel(Ad,Soyad,Tc,DogumTarihi,IseBaslamaTarihi,Tel,Maas,CinsiyetNo,KanGrubuNo,GorevNo,EgitimNo,MedeniDurumNo)values
('Nahide','Aslan',20298765434,'1971.02.03','2015.02.02',5418239898,1300,2,3,3,2,2),('Zeki','Gulseer',76245698721,'1983.12.05','2015.02.02',5317709898,1300,1,6,2,1,1),('Selami','Kadýoðlu',20294378192,'1978.02.23','2015.02.02',5333996733,1300,1,5,3,2,2),
('Helin','Konyar',37898745627,'1979.10.02','2015.02.02',5428976578,1400,2,2,1,3,1),('Ezgi','Yalçýn',17823467898,'1984.08.09','2015.02.02',5455109618,1400,2,1,1,2,2),('Talha','Aldýk',4789874562,'1971.02.03','2015.02.02',5539902321,1500,1,3,2,3,1);
select * from Personel

create table Kat
(
Katno int identity(1,1)primary key,
Kat varchar(15)not null
);
insert into Kat(Kat)values('Zemin Kat'),('Birinci Kat'),('Ýkinci Kat'),('Üçüncü Kat');
select * from Kat

create table Sinif
(
SinifNo int identity(1,1)primary key,
SinifAd varchar(10)not null,
KatNo int,
Constraint FK_Kat foreign key(KatNo)references Kat(KatNo)
);
insert into Sinif(SinifAd,Katno)values('9/A',1),('9/B',1),('10/A',2),('10/B',2),('11/A',3),('11/B',4),('12/A',4)
select * from Sinif

create table Meslek
(
MeslekNo int identity(1,1)primary key,
MeslekAd varchar(20)
);
insert into Meslek(MeslekAd)values('Doktor'),('Mimar'),('Tüccar'),('Mobilyacý'),('Spor Antrenörü'),('Mühendis'),('Öðretmen'),('Emlakçý'),('Muhasebeci'),('Teknisyen');
select * from Meslek

create table Veli
(
VeliNo int identity(1,1)primary key,
Ad varchar(15)not null,
Soyad varchar(20)not null,
MeslekNo int,
EgitimNo int,
Constraint FK_Meslek foreign key (MeslekNo) references Meslek(MeslekNo),
Constraint FK_Egitimm foreign key (EgitimNo) references Egitim(EgitimNo)
);
insert into Veli (Ad,Soyad,MeslekNo,EgitimNo)values
('Samet','Aksoy',1,4),('Omer','Saha',8,2),('Oguz','Demiralay',2,2),('Ceren','Avýcabasý',1,3),
('Büþra','Ýlayda',2,3),('Orhan','Aslan',4,2),('Oguzhan','Altundað',3,1),('Deniz','Basri',3,2),
('Hasan','Arslan',3,4),('Kaan','Altýn',5,3),('Nahide','Avcý',5,2),('Eda','Arvas',4,1),
('Selami','Akýncý',4,3),('Onur','Gümüþ',3,3),('Mustafa','Eren',6,2),('Emine','Hacýömer',7,1),
('Hüseyin','Çoban',5,4),('Recep','Celaloðlu',1,2),('Murat','Yokuþ',2,2),('Eren','Adna',6,4),
('Taha','Çim',4,4),('Resul','Okay',4,3),('Melisa','Demirdað',3,4),('Erkan','Aygün',5,1),
('Mehmet','Bekir',6,3),('Salih','Dede',3,2),('Mete','Karaman',1,2),('Arda','Yardým',3,2),
('Sevda','Korkmaz',7,3),('Sancar','Özkaya',2,3),('Munir','Yurdusev',10,3),('Fulya','Uyar',2,3),
('Zuhal','Eyibil',8,4),('Seda','Uyar',1,2),('Melik','Deniz',2,4),('Furkan','Yýldýrým',3,3),
('Yusuf','Aldýk',9,4),('Sefa','Dengiz',2,3),('Ýrem','Çerci',3,2),('Furkan','Menteþ',2,2),
('Zeki','Dilan',7,3),('Sena','Saraçoðlu',9,2),('Latif','Ertaþ',2,4),('Halide','Özçaylak',9,4),
('Umut','Gülseren',5,4),('Seher','Menteþ',10,3),('Kübra','Öz',4,3),('Ýrem','Yýldýrým',9,2),
('Umut','Korkmaz',4,4),('Seren','Keskin',8,2),('Mert','Genç',6,3),('Ýsmail','Akay',8,2),
('Tarik','Ece',9,3),('Serkan','Üçköyoðlu',10,2),('Kenan','Kalaycýoðlu',7,2),('Kerem','Yýlmaz',10,1),
('Sezer','Selamoðlu',2,3),('sevda','Biz',2,4);
select * from Veli

create table Ogrenci
(
OgrenciNo int identity(1,1) primary key,
Ad varchar(15)not null,
Soyad varchar(20)not null,
Tc char(11),
DogumTarihi date,
VeliNo int,
CinsiyetNo int,
SinifNo int,
Constraint FK_Veli foreign key (VeliNo) references Veli(VeliNo),
Constraint FK_Cinsiyett foreign key (CinsiyetNo) references Cinsiyet(CinsiyetNo),
Constraint FK_Sinif foreign key (SinifNo) references Sinif(SinifNo),
);
insert into Ogrenci(Ad,Soyad,Tc,DogumTarihi,VeliNo,CinsiyetNo,SinifNo)values
('Ahmet','Aksoy',20278543278,'2002.11.11',1,1,1),('Kübra','Evyapan',89556789245,'2002.12.13',2,2,1),('Buðra','Demiralay',90876542678,'2002.01.23',3,1,1),
('Mehmet','Avýcabasý',29078767521,'2002.12.31',4,1,1),('Þeyma','Ýlayda',20270987652,'2002.02.14',5,2,1),('Ömer','Aslan',20978123451,'2002.05.21',6,1,1),
('Veli','Altundag',56378256312,'2002.04.03',7,1,1),('Afra','Basri',89203678763,'2002.03.18',8,2,1),('Ceren','Arslan',20270198712,'2002.03.11',9,2,2),
('Gökhan','Altýn',20267327839,'2002.12.24',10,1,2),('Hüda','Avcý',20278123678,'2002.09.19',11,2,2),('Zeki','Arvas',23134223456,'2002.02.21',12,1,2),
('Doðukan','Akýncý',37190876589,'2002.10.11',13,1,2),('Þule','Gümüþ',89723478652,'2002.03.12',14,2,2),('Rýdvan','Eren',19023498123,'2002.09.13',15,1,2),
('Emre','Haciömer',30389023456,'2002.11.21',16,1,2),('Esra','Çoban',2098902313,'2001.09.21',17,2,3),('Rýfat','Celaloðlu',57123478921,'2001.01.04',18,1,3),
('Emircan','Yokuþ',89234578923,'2001.12.21',19,1,3),('Melike','Adna',22236789234,'2001.04.22',20,2,3),('Melisa','Çim',29078923452,'2001.12.02',21,2,3),
('Göksel','Okay',12900023467,'2001.04.03',22,1,3),('Büþra','Demirdað',20978245623,'2001.05.29',23,2,3),('Fatma','Aygün',19078923412,'2001.01.21',24,2,3),
('Kaan','Bekir',78256789234,'2001.12.21',25,1,4),('Zeynep','Dede',20278902341,'2001.12.21',26,2,4),('Saliha','Karaman',29076347891,'2001.01.05',27,2,4),
('Kerem','Yardým',20126789012,'2001.08.21',28,1,4),('Dilara','Korkmaz',29856723451,'2001.12.29',29,2,4),('Ýbrahim','Özkaya',20270989712,'2001.02.09',30,1,4),
('Barýþ','Yurdusev',19045627898,'2001.07.07',31,1,4),('Damla','Uyar',33087523412,'2001.09.09',32,2,4),('Can','Eyibil',20270198818,'2000.01.07',33,1,5),
('Hakan','Uyar',56721389234,'2000.11.21',34,1,5),('Fulya','Deniz',90912345612,'2000.12.02',35,2,5),('Deniz','Yýldýrým',49467256731,'2000.02.22',36,2,5),
('Bora','Aldýk',30314067231,'2000.11.07',37,1,5),('Özge','Dengiz',59521255612,'2000.11.27',38,2,5),('Ýrem','Çerci',10124554323,'2000.09.01',39,2,5),
('Bora','Menteþ',17899076555,'2000.09.27',40,1,5),('Özlem','Dilan',12233167234,'2000.03.17',41,2,6),('Berna','Saraçoðlu',11289065012,'2000.01.11',42,2,6),
('Bahri','Ertaþ',20988023411,'2000.04.23',43,1,6),('Buse','Özçaylak',92189021244,'2000.05.21',44,2,6),('Yücel','Gulseren',19247823411,'2000.01.07',45,1,6),
('Taha','Menteþ',13288067521,'2000.12.07',46,1,6),('Dilan','Öz',24511078921,'2000.10.27',47,2,6),('Yaðmur','Yýldýrým',33190274123,'2000.05.27',48,2,6),
('Batuhan','Korkmaz',20270199022,'1999.06.18',49,1,7),('Buket','Keskin',95678923499,'1999.09.08',50,2,7),('Nur','Ýlcihanoðlu',20470199021,'1999.06.11',51,2,7),
('Yusuf','Arý',20123467822,'1999.06.09',52,1,7),('Mine','Genç',23170198818,'1999.12.01',53,2,7),('Orhan','Akay',23411278900,'1999.03.11',54,1,7),
('Baran','Ece',19256728931,'1999.11.12',55,1,7),('Ýsra','Üçköyoðlu',31289234411,'1999.01.10',56,2,7),('Cem','Kalaycýoðlu',20278923144,'1999.06.14',57,1,7),
('Emir','Yýlmaz',23489725631,'1999.03.19',58,1,7);
select*from Ogrenci

create table Ders
(
DersNo int identity(1,1)primary key,
DersAd varchar(20)not null
);
insert into Ders(DersAd)values('Nesne Tabanlý Prog.'),('Mesleki Ýngilizce'),('Veri Tabaný');
select * from Ders

create table Ogretmen
(
OgretmenNo int identity(1,1) primary key,
Ad varchar(30)not null,
Soyad varchar(30)not null,
DersNo int,
Constraint FK_Derss foreign key (DersNo) references Ders(DersNo)
);
insert into Ogretmen(Ad,Soyad,DersNo)values
('Aleyna','Öztürk',1),('Banu','Çalýþkan',1),('Hulusi','Oflaz',1),
('Yiðit','Menteþ',2),('Ýsmail','Güler',2),('Damla','Melis',2),
('Fýrat','Kazan',3),('Ercan','Özdemir',3),('Fulya','Acar',3);
select * from Ogretmen

create table Sinav
(
SinavNo int identity(1,1) primary key ,
BirinciSinav tinyint,
IkinciSinav tinyint,
BirinciPerformans tinyint,
IkinciPerformans tinyint,
OgrenciNo int,
DersNo int,
Constraint FK_OgrenciNo foreign key (OgrenciNo) references Ogrenci(OgrenciNo),
Constraint FK_Ders foreign key (DersNo) references Ders(DersNo)
);
insert into Sinav(OgrenciNo,DersNo,BirinciSinav,IkinciSinav,BirinciPerformans,IkinciPerformans)values
(1,1,70,70,80,80),(1,2,45,43,100,100),(1,3,25,21,80,74),
(2,1,21,56,80,80),(2,2,65,55,80,90),(2,3,40,50,100,85),
(3,1,60,80,90,90),(3,2,65,31,100,75),(3,3,45,25,100,70),
(4,1,47,78,80,80),(4,2,47,32,80,85),(4,3,11,02,55,43),
(5,1,30,55,60,60),(5,2,25,70,60,70),(5,3,5,20,50,50),
(6,1,45,58,60,60),(6,2,43,58,65,65),(6,3,93,87,80,80),
(7,1,53,27,50,60),(7,2,50,50,70,75),(7,3,100,100,100,100),
(8,1,34,64,60,65),(8,2,22,47,50,50),(8,3,10,15,30,30),
(9,1,35,50,60,60),(9,2,34,73,70,70),(9,3,44,55,50,50),
(10,1,60,48,60,60),(10,2,50,44,70,70),(10,3,23,49,55,55),
(11,1,57,77,70,75),(11,2,50,50,60,65),(11,3,45,53,60,60),
(12,1,25,38,50,55),(12,2,40,44,50,65),(12,3,59,54,65,70),
(13,1,83,68,80,80),(13,2,23,11,45,50),(13,3,54,33,45,60),
(14,1,35,41,55,55),(14,2,25,13,40,40),(14,3,69,77,75,80),
(15,1,26,11,40,45),(15,2,55,69,70,70),(15,3,44,71,65,65),
(16,1,89,75,80,85),(16,2,35,50,50,55),(16,3,23,70,65,65),
(17,1,61,46,65,55),(17,2,54,60,60,60),(17,3,22,45,40,40),
(18,1,45,60,60,60),(18,2,22,35,50,50),(18,3,23,54,60,60),
(19,1,100,100,100,100),(19,2,50,75,70,70),(19,3,15,25,30,60),
(20,1,35,64,65,65),(20,2,13,54,45,50),(20,3,5,5,20,20),
(21,1,95,89,90,95),(21,2,77,63,60,65),(21,3,79,45,50,50),
(22,1,55,54,60,60),(22,2,25,44,50,50),(22,3,89,55,60,70),
(23,1,23,49,55,65),(23,2,43,66,55,65),(23,3,24,58,50,50),
(24,1,60,50,50,50),(24,2,90,90,75,85),(24,3,83,100,90,95),
(25,1,45,23,50,50),(25,2,67,53,55,65),(25,3,44,65,60,60),
(26,1,23,44,50,55),(26,2,83,85,85,85),(26,3,23,44,50,50),
(27,1,0,0,10,10),(27,2,45,70,55,65),(27,3,75,69,70,70),
(28,1,10,23,40,45),(28,2,45,44,50,60),(28,3,22,80,90,90),
(29,1,15,50,45,50),(29,2,73,75,70,70),(29,3,29,35,50,50),
(30,1,50,0,30,30),(30,2,25,73,50,65),(30,3,58,63,65,65),
(31,1,43,51,55,55),(31,2,18,43,50,55),(31,3,78,55,65,65),
(32,1,68,73,60,75),(32,2,43,75,65,75),(32,3,05,22,40,40),
(33,1,56,25,55,65),(33,2,93,71,80,85),(33,3,54,50,55,65),
(34,1,67,79,70,70),(34,2,43,67,65,65),(34,3,50,50,55,65),
(35,1,13,05,40,45),(35,2,0,05,30,30),(35,3,100,100,100,100),
(36,1,100,87,80,85),(36,2,44,23,50,55),(36,3,45,30,50,55),
(37,1,70,75,60,75),(37,2,50,44,60,65),(37,3,22,50,60,65),
(38,1,51,60,60,60),(38,2,10,50,60,60),(38,3,23,02,30,30),
(39,1,88,71,75,80),(39,2,13,24,40,45),(39,3,34,55,60,65),
(40,1,12,01,30,30),(40,2,89,65,70,75),(40,3,33,56,55,65),
(41,1,90,85,100,80),(41,2,34,43,80,80),(41,3,23,45,70,65),
(42,1,55,32,80,75),(42,2,32,43,75,70),(42,3,22,23,45,55),
(43,1,67,32,90,90),(43,2,54,76,70,70),(43,3,45,32,40,45),
(44,1,34,54,70,70),(44,2,55,55,70,70),(44,3,80,70,98,67),
(45,1,84,23,85,98),(45,2,21,45,70,70),(45,3,45,76,95,95),
(46,1,78,83,100,100),(46,2,76,12,55,65),(46,3,55,45,85,75),
(47,1,32,42,50,50),(47,2,54,75,90,90),(47,3,45,58,85,85),
(48,1,50,55,65,65),(48,2,55,75,85,85),(48,3,55,55,70,80),
(49,1,42,23,65,65),(49,2,13,05,30,10),(49,3,90,100,95,90),
(50,1,67,64,70,70),(50,2,64,32,60,65),(50,3,43,32,70,90),
(51,1,76,87,90,90),(51,2,70,80,90,90),(51,3,74,76,100,100),
(52,1,23,12,45,45),(52,2,80,80,90,90),(52,3,55,35,70,70),
(53,1,23,81,80,85),(53,2,47,82,75,72),(53,3,45,43,70,60),
(54,1,45,55,90,95),(54,2,23,56,75,75),(54,3,52,60,55,50),
(55,1,59,71,70,75),(55,2,55,59,70,85),(55,3,87,78,95,100),
(56,1,58,68,70,70),(56,2,80,86,90,95),(56,3,42,11,40,55),
(57,1,23,54,55,55),(57,2,12,04,30,50),(57,3,33,27,40,45),
(58,1,45,64,50,70),(58,2,77,93,85,90),(58,3,53,42,50,55);
select * from Sinav

create table Devamsizlik
(
DevamsizlikNo int identity(1,1)primary key,
OzurluDevamsizlik tinyint,
OzursuzDevamsizlik tinyint,
OgrenciNo int,
Constraint FK_OgrenciiNo foreign key (OgrenciNo) references Ogrenci(OgrenciNo)
);
insert into Devamsizlik(OgrenciNo,OzurluDevamsizlik,OzursuzDevamsizlik)values
(1,1,0),(2,3,2),(3,2,8),(4,2,5),(5,1,1),
(6,3,0),(7,3,1),(8,3,2),(9,3,5),(10,1,4),
(11,5,0),(12,2,2),(13,4,1),(14,3,6),(15,1,2),
(16,7,0),(17,4,4),(18,5,1),(19,3,6),(20,2,3),
(21,2,0),(22,7,3),(23,5,3),(24,2,5),(25,1,4),
(26,9,0),(27,4,2),(28,5,4),(29,4,4),(30,2,3),
(31,2,0),(32,7,8),(33,2,2),(34,0,3),(35,4,4),
(36,3,0),(37,8,8),(38,1,3),(39,9,2),(40,0,1),
(41,2,0),(42,3,7),(43,1,2),(44,7,21),(45,11,3),
(46,4,0),(47,4,4),(48,1,2),(49,4,8),(50,23,0),
(51,0,0),(52,3,3),(53,0,4),(54,3,7),(55,12,2),
(56,0,0),(57,2,1),(58,2,4);
select * from Devamsizlik