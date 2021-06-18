/*
use master;
drop database Hospital;

create database Hospital;
use Hospital;
*/


/* Patient table */

create table Patient 
(
	PatientID int IDENTITY(1,1) not null,
	Height int ,
	HName varChar(100),
	BType varChar(10),
	Fname varChar(40),
	Lname varChar(40),
	Weight int,
	Area varChar(40),
	City varChar(40),
	AddedDate Date,
	PStatus varChar(40),
	Gender varChar(10),
	DocID int,
	BedID int,
	RoomNo int,
	age int,
	Primary key (PatientID)
);


/* Hospital table */
create table Hospital
(
	HName varChar(100) not null,
	City varChar(40),
	Area varChar(40),
	Primary key (HName)
);


/* Room table */
create table Room
(
    RoomNo int IDENTITY(1,1) not null,
	roomType varchar(40),
    primary key (RoomNo)
);


/* Bill table */
create table Bill
(
	Bill_ID int IDENTITY(1,1) not null,
	Bill_price int,
	PatientID int,
	primary key(Bill_ID)
);


/* Doctor table */
create table Doctor
(
	DocID int IDENTITY(1,1) not null,
	Name varchar(50),
	primary key(DocID)
);


/* Bed table */
create table Bed
(
	BedID  int IDENTITY(1,1),
	RoomNo int,
	primary key(BedID, RoomNo)
);


/* Department table */
create table Department
(
	Dno int IDENTITY(1,1) not null,
	Dname varchar(40),
	Primary key (Dno)
);


/* DOC IS IN DEP table */
create table DocIsInDep
(
	DocID int,
	Dno int,
	primary key(DocID,Dno)
);


/* Patient_PhoneNo table */
create table Patient_PhoneNo
(
	PhoneNo int not null,
	PatientID int not null,
	Primary key (PhoneNo,PatientID)
);


/* Patient_Disease table */
create table Patient_Disease
(
	Disease varchar(40) not null,
	PatientID int not null,
	Primary key (Disease,PatientID)
);


/* Patient_treatment table */
create table Patient_treatment
(
    Treatment varchar(50),
    price int,
    PatientID int,
    primary key(Treatment,PatientID)
);


/* Hospital Has Room table */
create table HospitalHasRoom
(
	HName varchar(100) not null,
	RoomNo int not null,
	primary key (HName, RoomNo)
);


/* Hospital Has Dep table */
create table HospitalHasDep
(
	HName varchar(100) not null,
	Dno int not null,
	primary key (HName, Dno)
);





/* add foreign keys*/

/* add (Patient) foreign keys*/
alter table Patient
add foreign key(HName) references Hospital(HName)
on update cascade
on delete cascade

alter table Patient
add foreign key(DocID) references Doctor(DocID)
on update cascade
on delete cascade

alter table Patient
add foreign key(BedID, RoomNo) references Bed(BedID, RoomNo)
on update cascade
on delete cascade


/* add (DocIsInDep) foreign keys*/
alter table DocIsInDep
add foreign key(DocID) references Doctor(DocID)
on update cascade
on delete cascade

alter table DocIsInDep
add foreign key(Dno) references Department(Dno)
on update cascade
on delete cascade


/* add (Bill) foreign keys*/
alter table Bill
add foreign key(PatientID) references Patient(PatientID)
on update cascade
on delete cascade


/* add (Bed) foreign keys*/
alter table Bed
add foreign key(RoomNo) references Room(RoomNo)
on update cascade
on delete cascade


/* add (Patient PhoneNo) foreign keys*/
alter table Patient_PhoneNo
add foreign key(PatientID) references Patient(PatientID)
on update cascade
on delete cascade


/* add (Patient Disease) foreign keys*/
alter table Patient_Disease
add foreign key(PatientID) references Patient(PatientID)
on update cascade
on delete cascade


/* add (Patient Treatment) foreign keys*/
alter table Patient_treatment
add foreign key(PatientID) references Patient(PatientID)
on update cascade
on delete cascade


/* add (Hospital Has Room) foreign keys*/
alter table HospitalHasRoom
add foreign key(HName) references Hospital(HName)
on update cascade
on delete cascade

alter table HospitalHasRoom
add foreign key(RoomNo) references Room(RoomNo)
on update cascade
on delete cascade


/* add (Hospital Has Dep) foreign keys*/
alter table HospitalHasDep
add foreign key(HName) references Hospital(HName)
on update cascade
on delete cascade

alter table HospitalHasDep
add foreign key(Dno) references Department(Dno)
on update cascade
on delete cascade








/* Insert data for Doctor Table */
insert into Doctor (name) values ('Teddie Muddiman');
insert into Doctor (name) values ( 'Rollo Haire');
insert into Doctor (name) values ('Domeniga Dotson');
insert into Doctor (name) values ('Tabby Pulham');
insert into Doctor (name) values ( 'Yorgo Kless');
insert into Doctor (name) values ( 'Kerby Larchier');
insert into Doctor (name) values ('Chen Clashe');
insert into Doctor (name) values ( 'Eduardo Tackley');
insert into Doctor (name) values ( 'Pierrette Blunsen');
insert into Doctor (name) values ( 'Cherri Rowledge');
insert into Doctor (name) values ('Elston Cudihy');
insert into Doctor (name) values ( 'Vanny Veness');
insert into Doctor (name) values ( 'Berkley Neighbour');
insert into Doctor (name) values ( 'Dionis Cookson');
insert into Doctor (name) values ( 'Row Langrish');
insert into Doctor (name) values ( 'Isador Philipsen');
insert into Doctor (name) values ( 'Ilsa Cowles');
insert into Doctor (name) values ( 'Fawnia Workes');
insert into Doctor (name) values ( 'Jobye Gundrey');
insert into Doctor (name) values ( 'Tatiana McCroft');
insert into Doctor (name) values ( 'Lotta Leale');
insert into Doctor (name) values ('Morton Huxton');
insert into Doctor (name) values ( 'Yurik Lydiard');
insert into Doctor (name) values ( 'Allx O Neil');
insert into Doctor (name) values ( 'Becki Oxbie');




/* Insert data for Department Table */
insert into Department ( dname) values ( 'Oncology');
insert into Department ( dname) values ('Outpatient Department');
insert into Department ( dname) values ( 'Inpatient Service');
insert into Department ( dname) values ( 'General surgery');
insert into Department ( dname) values ( 'Microbiology');
insert into Department ( dname) values ('Ophthalmology');
insert into Department ( dname) values ('Orthopaedics');
insert into Department ( dname) values ('Radiotherapy');
insert into Department ( dname) values ('Ear nose and throat');
insert into Department ( dname) values ('morgue');
insert into Department (dname) values ('Accident and emergency');



/* Insert data for DocIsInDep Table */
insert into DocIsInDep (docid, dno) values (25, 1);
insert into DocIsInDep (docid, dno) values ( 1 , 1);
insert into DocIsInDep (docid, dno) values ( 2 , 4);
insert into DocIsInDep (docid, dno) values ( 3 , 10);
insert into DocIsInDep (docid, dno) values ( 4 , 10);
insert into DocIsInDep (docid, dno) values ( 5 , 1);
insert into DocIsInDep (docid, dno) values ( 6 , 11);
insert into DocIsInDep (docid, dno) values ( 7 , 11);
insert into DocIsInDep (docid, dno) values ( 8 , 1);
insert into DocIsInDep (docid, dno) values ( 9 , 9);
insert into DocIsInDep (docid, dno) values ( 10 , 5);
insert into DocIsInDep (docid, dno) values ( 11 , 2);
insert into DocIsInDep (docid, dno) values ( 12 , 4);
insert into DocIsInDep (docid, dno) values ( 13 , 7);
insert into DocIsInDep (docid, dno) values ( 14 , 2);
insert into DocIsInDep (docid, dno) values ( 15 , 4);
insert into DocIsInDep (docid, dno) values ( 16 , 9);
insert into DocIsInDep (docid, dno) values ( 17 , 6);
insert into DocIsInDep (docid, dno) values ( 18 , 10);
insert into DocIsInDep (docid, dno) values ( 19 , 6);
insert into DocIsInDep (docid, dno) values ( 20 , 9);
insert into DocIsInDep (docid, dno) values ( 21 , 5);
insert into DocIsInDep (docid, dno) values ( 22 , 10);
insert into DocIsInDep (docid, dno) values ( 23 , 11);
insert into DocIsInDep (docid, dno) values ( 24 , 8);




/* Insert data for Room Table */
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');
insert into Room (roomtype) values ('Operation Theaters');
insert into Room (roomtype) values ('ICU');
insert into Room (roomtype) values ('patient room');

​





/* Insert data for Bed Table */
insert into Bed (roomno) values (1);
insert into Bed (roomno) values (2);
insert into Bed (roomno) values (3);
insert into Bed (roomno) values (4);
insert into Bed (roomno) values (5);
insert into Bed (roomno) values (6);
insert into Bed (roomno) values (7);
insert into Bed (roomno) values (8);
insert into Bed (roomno) values (9);
insert into Bed (roomno) values (10);
insert into Bed (roomno) values (11);
insert into Bed (roomno) values (12);
insert into Bed (roomno) values (13);
insert into Bed (roomno) values (14);
insert into Bed (roomno) values (15);
insert into Bed (roomno) values (16);
insert into Bed (roomno) values (17);
insert into Bed (roomno) values (18);
insert into Bed (roomno) values (19);
insert into Bed (roomno) values (20);
insert into Bed (roomno) values (21);
insert into Bed (roomno) values (22);
insert into Bed (roomno) values (23);
insert into Bed (roomno) values (24);
insert into Bed (roomno) values (25);
insert into Bed (roomno) values (26);
insert into Bed (roomno) values (27);
insert into Bed (roomno) values (28);
insert into Bed (roomno) values (29);
insert into Bed (roomno) values (30);
insert into Bed (roomno) values (31);
insert into Bed (roomno) values (32);
insert into Bed (roomno) values (33);
insert into Bed (roomno) values (34);
insert into Bed (roomno) values (35);
insert into Bed (roomno) values (36);
insert into Bed (roomno) values (37);
insert into Bed (roomno) values (38);
insert into Bed (roomno) values (39);
insert into Bed (roomno) values (40);
insert into Bed (roomno) values (41);
insert into Bed (roomno) values (42);
insert into Bed (roomno) values (43);
insert into Bed (roomno) values (44);
insert into Bed (roomno) values (45);
insert into Bed (roomno) values (46);
insert into Bed (roomno) values (47);
insert into Bed (roomno) values (48);
insert into Bed (roomno) values (49);
insert into Bed (roomno) values (50);
insert into Bed (roomno) values (51);
insert into Bed (roomno) values (52);
insert into Bed (roomno) values (53);
insert into Bed (roomno) values (54);
insert into Bed (roomno) values (55);
insert into Bed (roomno) values (56);
insert into Bed (roomno) values (57);
insert into Bed (roomno) values (58);
insert into Bed (roomno) values (59);
insert into Bed (roomno) values (60);
insert into Bed (roomno) values (61);
insert into Bed (roomno) values (62);
insert into Bed (roomno) values (63);
insert into Bed (roomno) values (64);
insert into Bed (roomno) values (65);
insert into Bed (roomno) values (66);
insert into Bed (roomno) values (67);
insert into Bed (roomno) values (68);
insert into Bed (roomno) values (69);
insert into Bed (roomno) values (70);
insert into Bed (roomno) values (71);
insert into Bed (roomno) values (72);
insert into Bed (roomno) values (73);
insert into Bed (roomno) values (74);
insert into Bed (roomno) values (75);
insert into Bed (roomno) values (76);
insert into Bed (roomno) values (77);
insert into Bed (roomno) values (78);
insert into Bed (roomno) values (79);
insert into Bed (roomno) values (80);
insert into Bed (roomno) values (81);
insert into Bed (roomno) values (82);
insert into Bed (roomno) values (83);
insert into Bed (roomno) values (84);
insert into Bed (roomno) values (85);
insert into Bed (roomno) values (86);
insert into Bed (roomno) values (87);
insert into Bed (roomno) values (88);
insert into Bed (roomno) values (89);
insert into Bed (roomno) values (90);
insert into Bed (roomno) values (91);
insert into Bed (roomno) values (92);
insert into Bed (roomno) values (93);
insert into Bed (roomno) values (94);
insert into Bed (roomno) values (95);
insert into Bed (roomno) values (96);
insert into Bed (roomno) values (97);
insert into Bed (roomno) values (98);
insert into Bed (roomno) values (99);
insert into Bed (roomno) values (100);
insert into Bed (roomno) values (1);
insert into Bed (roomno) values (2);
insert into Bed (roomno) values (3);
insert into Bed (roomno) values (4);
insert into Bed (roomno) values (5);
insert into Bed (roomno) values (6);
insert into Bed (roomno) values (7);
insert into Bed (roomno) values (8);
insert into Bed (roomno) values (9);
insert into Bed (roomno) values (10);
insert into Bed (roomno) values (11);
insert into Bed (roomno) values (12);
insert into Bed (roomno) values (13);
insert into Bed (roomno) values (14);
insert into Bed (roomno) values (15);
insert into Bed (roomno) values (16);
insert into Bed (roomno) values (17);
insert into Bed (roomno) values (18);
insert into Bed (roomno) values (19);
insert into Bed (roomno) values (20);
insert into Bed (roomno) values (21);
insert into Bed (roomno) values (22);
insert into Bed (roomno) values (23);
insert into Bed (roomno) values (24);
insert into Bed (roomno) values (25);
insert into Bed (roomno) values (26);
insert into Bed (roomno) values (27);
insert into Bed (roomno) values (28);
insert into Bed (roomno) values (29);
insert into Bed (roomno) values (30);
insert into Bed (roomno) values (31);
insert into Bed (roomno) values (32);
insert into Bed (roomno) values (33);
insert into Bed (roomno) values (34);
insert into Bed (roomno) values (35);
insert into Bed (roomno) values (36);
insert into Bed (roomno) values (37);
insert into Bed (roomno) values (38);
insert into Bed (roomno) values (39);
insert into Bed (roomno) values (40);
insert into Bed (roomno) values (41);
insert into Bed (roomno) values (42);
insert into Bed (roomno) values (43);
insert into Bed (roomno) values (44);
insert into Bed (roomno) values (45);
insert into Bed (roomno) values (46);
insert into Bed (roomno) values (47);
insert into Bed (roomno) values (48);
insert into Bed (roomno) values (49);
insert into Bed (roomno) values (50);
insert into Bed (roomno) values (51);
insert into Bed (roomno) values (52);
insert into Bed (roomno) values (53);
insert into Bed (roomno) values (54);
insert into Bed (roomno) values (55);
insert into Bed (roomno) values (56);
insert into Bed (roomno) values (57);
insert into Bed (roomno) values (58);
insert into Bed (roomno) values (59);
insert into Bed (roomno) values (60);
insert into Bed (roomno) values (61);
insert into Bed (roomno) values (62);
insert into Bed (roomno) values (63);
insert into Bed (roomno) values (64);
insert into Bed (roomno) values (65);
insert into Bed (roomno) values (66);
insert into Bed (roomno) values (67);
insert into Bed (roomno) values (68);
insert into Bed (roomno) values (69);
insert into Bed (roomno) values (70);
insert into Bed (roomno) values (71);
insert into Bed (roomno) values (72);
insert into Bed (roomno) values (73);
insert into Bed (roomno) values (74);
insert into Bed (roomno) values (75);
insert into Bed (roomno) values (76);
insert into Bed (roomno) values (77);
insert into Bed (roomno) values (78);
insert into Bed (roomno) values (79);
insert into Bed (roomno) values (80);
insert into Bed (roomno) values (81);
insert into Bed (roomno) values (82);
insert into Bed (roomno) values (83);
insert into Bed (roomno) values (84);
insert into Bed (roomno) values (85);
insert into Bed (roomno) values (86);
insert into Bed (roomno) values (87);
insert into Bed (roomno) values (88);
insert into Bed (roomno) values (89);
insert into Bed (roomno) values (90);
insert into Bed (roomno) values (91);
insert into Bed (roomno) values (92);
insert into Bed (roomno) values (93);
insert into Bed (roomno) values (94);
insert into Bed (roomno) values (95);
insert into Bed (roomno) values (96);
insert into Bed (roomno) values (97);
insert into Bed (roomno) values (98);
insert into Bed (roomno) values (99);
insert into Bed (roomno) values (100);
insert into Bed (roomno) values (1);
insert into Bed (roomno) values (2);
insert into Bed (roomno) values (3);
insert into Bed (roomno) values (4);
insert into Bed (roomno) values (5);
insert into Bed (roomno) values (6);
insert into Bed (roomno) values (7);
insert into Bed (roomno) values (8);
insert into Bed (roomno) values (9);
insert into Bed (roomno) values (10);
insert into Bed (roomno) values (11);
insert into Bed (roomno) values (12);
insert into Bed (roomno) values (13);
insert into Bed (roomno) values (14);
insert into Bed (roomno) values (15);
insert into Bed (roomno) values (16);
insert into Bed (roomno) values (17);
insert into Bed (roomno) values (18);
insert into Bed (roomno) values (19);
insert into Bed (roomno) values (20);
insert into Bed (roomno) values (21);
insert into Bed (roomno) values (22);
insert into Bed (roomno) values (23);
insert into Bed (roomno) values (24);
insert into Bed (roomno) values (25);
insert into Bed (roomno) values (26);
insert into Bed (roomno) values (27);
insert into Bed (roomno) values (28);
insert into Bed (roomno) values (29);
insert into Bed (roomno) values (30);
insert into Bed (roomno) values (31);
insert into Bed (roomno) values (32);
insert into Bed (roomno) values (33);
insert into Bed (roomno) values (34);
insert into Bed (roomno) values (35);
insert into Bed (roomno) values (36);
insert into Bed (roomno) values (37);
insert into Bed (roomno) values (38);
insert into Bed (roomno) values (39);
insert into Bed (roomno) values (40);
insert into Bed (roomno) values (41);
insert into Bed (roomno) values (42);
insert into Bed (roomno) values (43);
insert into Bed (roomno) values (44);
insert into Bed (roomno) values (45);
insert into Bed (roomno) values (46);
insert into Bed (roomno) values (47);
insert into Bed (roomno) values (48);
insert into Bed (roomno) values (49);
insert into Bed (roomno) values (50);
insert into Bed (roomno) values (51);
insert into Bed (roomno) values (52);
insert into Bed (roomno) values (53);
insert into Bed (roomno) values (54);
insert into Bed (roomno) values (55);
insert into Bed (roomno) values (56);
insert into Bed (roomno) values (57);
insert into Bed (roomno) values (58);
insert into Bed (roomno) values (59);
insert into Bed (roomno) values (60);
insert into Bed (roomno) values (61);
insert into Bed (roomno) values (62);
insert into Bed (roomno) values (63);
insert into Bed (roomno) values (64);
insert into Bed (roomno) values (65);
insert into Bed (roomno) values (66);
insert into Bed (roomno) values (67);
insert into Bed (roomno) values (68);
insert into Bed (roomno) values (69);
insert into Bed (roomno) values (70);
insert into Bed (roomno) values (71);
insert into Bed (roomno) values (72);
insert into Bed (roomno) values (73);
insert into Bed (roomno) values (74);
insert into Bed (roomno) values (75);
insert into Bed (roomno) values (76);
insert into Bed (roomno) values (77);
insert into Bed (roomno) values (78);
insert into Bed (roomno) values (79);
insert into Bed (roomno) values (80);
insert into Bed (roomno) values (81);
insert into Bed (roomno) values (82);
insert into Bed (roomno) values (83);
insert into Bed (roomno) values (84);
insert into Bed (roomno) values (85);
insert into Bed (roomno) values (86);
insert into Bed (roomno) values (87);
insert into Bed (roomno) values (88);
insert into Bed (roomno) values (89);
insert into Bed (roomno) values (90);
insert into Bed (roomno) values (91);
insert into Bed (roomno) values (92);
insert into Bed (roomno) values (93);
insert into Bed (roomno) values (94);
insert into Bed (roomno) values (95);
insert into Bed (roomno) values (96);
insert into Bed (roomno) values (97);
insert into Bed (roomno) values (98);
insert into Bed (roomno) values (99);
insert into Bed (roomno) values (100);







/* Insert data for Hospital Table  */
insert into Hospital (hname, city, area) values ('al montazah Hospital', 'Alexandria', 'al montazah');
insert into Hospital (hname, city, area) values ('Adam International Hospital', 'Aswan', 'el shellal');
insert into Hospital (hname, city, area) values ('Abbasia', 'cairo', 'Abbasia');
insert into Hospital (hname, city, area) values ('El Demerdash', 'Beheira', 'Damanhour');
insert into Hospital (hname, city, area) values ('Agooza Hospital', 'Giza', 'Agooza');
insert into Hospital (hname, city, area) values ('El Salam Hospital', 'Cairo', 'Maadi');
insert into Hospital (hname, city, area) values ('Elexandria Psychiatric centre', 'Alexandria', 'Moharam Bek');
insert into Hospital (hname, city, area) values ('Elzahra Hospital', 'cairo', 'maadi');
insert into Hospital (hname, city, area) values ('El Salam International Hospital ', 'Faiyum', 'New Faiyum');
insert into Hospital (hname, city, area) values ('Amoun Hospital', 'Gharbia', 'El Mahalla El Kubra');
insert into Hospital (hname, city, area) values ('Zamalek Hospital', 'Giza', 'el Mohandseen');
insert into Hospital (hname, city, area) values ('Gabal Akhdar', 'Ismailia', 'Fayid');
insert into Hospital (hname, city, area) values ('Asyout University Hospital', 'Asyout', 'Asyout');
insert into Hospital (hname, city, area) values ('Badran Hospital', 'Luxor', 'Luxor');
insert into Hospital (hname, city, area) values ('Maddi Hospital', 'Matrouh', 'El Alamein');
insert into Hospital (hname, city, area) values ('Zed Cairo General Hospital', 'Cairo', 'Zamalek');
insert into Hospital (hname, city, area) values ('Cairo general Center', 'Cairo', 'Heliopolis');
insert into Hospital (hname, city, area) values ('Cairo Medical Center', 'Cairo', 'Downtown');
insert into Hospital (hname, city, area) values ('Cleopatra Hospital', 'Giza', 'Haram');
insert into Hospital (hname, city, area) values ('Coptic Hospital', 'Port Said', 'Port Fuad');
insert into Hospital (hname, city, area) values ('Dar El Fouad Hospital', 'Giza', '6th of october');
insert into Hospital (hname, city, area) values ('Dar el Hekma Hospital', 'Qena', 'Dishna');
insert into Hospital (hname, city, area) values ('Dar el Salam General Hospital', 'Red Sea', 'hurgada');
insert into Hospital (hname, city, area) values ('Dar el Oyoun Hospital', 'Sharqia', 'New Salhia');
insert into Hospital (hname, city, area) values ('Dar El Teb medical Center', 'Sohag', 'Tahta');




/* Insert data for HospitalHasRoom Table */
insert into HospitalHasRoom (hname, roomno) values ('al montazah Hospital', 1);
insert into HospitalHasRoom (hname, roomno) values ('Adam International Hospital', 2);
insert into HospitalHasRoom (hname, roomno) values ('Abbasia', 3);
insert into HospitalHasRoom (hname, roomno) values ('El Demerdash', 4);
insert into HospitalHasRoom (hname, roomno) values ('Agooza Hospital', 5);
insert into HospitalHasRoom (hname, roomno) values ('El Salam Hospital', 6);
insert into HospitalHasRoom (hname, roomno) values ('Elexandria Psychiatric centre', 7);
insert into HospitalHasRoom (hname, roomno) values ('Elzahra Hospital', 8);
insert into HospitalHasRoom (hname, roomno) values ('El Salam International Hospital', 9);
insert into HospitalHasRoom (hname, roomno) values ('Amoun Hospital', 10);
insert into HospitalHasRoom (hname, roomno) values ('Zamalek Hospital', 11);
insert into HospitalHasRoom (hname, roomno) values ('Gabal Akhdar', 12);
insert into HospitalHasRoom (hname, roomno) values ('Asyout University Hospital', 13);
insert into HospitalHasRoom (hname, roomno) values ('Badran Hospital', 14);
insert into HospitalHasRoom (hname, roomno) values ('Maddi Hospital', 15);
insert into HospitalHasRoom (hname, roomno) values ('Zed Cairo General Hospital', 16);
insert into HospitalHasRoom (hname, roomno) values ('Cairo general Center', 17);
insert into HospitalHasRoom (hname, roomno) values ('Cairo Medical Center', 18);
insert into HospitalHasRoom (hname, roomno) values ('Cleopatra Hospital', 19);
insert into HospitalHasRoom (hname, roomno) values ('Coptic Hospital', 20);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Fouad Hospital', 21);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Hekma Hospital', 22);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Salam General Hospital', 23);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Oyoun Hospital', 24);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Teb medical Center', 25);
insert into HospitalHasRoom (hname, roomno) values ('al montazah Hospital', 26);
insert into HospitalHasRoom (hname, roomno) values ('Adam International Hospital', 27);
insert into HospitalHasRoom (hname, roomno) values ('Abbasia', 28);
insert into HospitalHasRoom (hname, roomno) values ('El Demerdash', 29);
insert into HospitalHasRoom (hname, roomno) values ('Agooza Hospital', 30);
insert into HospitalHasRoom (hname, roomno) values ('El Salam Hospital', 31);
insert into HospitalHasRoom (hname, roomno) values ('Elexandria Psychiatric centre', 32);
insert into HospitalHasRoom (hname, roomno) values ('Elzahra Hospital', 33);
insert into HospitalHasRoom (hname, roomno) values ('El Salam International Hospital', 34);
insert into HospitalHasRoom (hname, roomno) values ('Amoun Hospital', 35);
insert into HospitalHasRoom (hname, roomno) values ('Zamalek Hospital', 36);
insert into HospitalHasRoom (hname, roomno) values ('Gabal Akhdar', 37);
insert into HospitalHasRoom (hname, roomno) values ('Asyout University Hospital', 38);
insert into HospitalHasRoom (hname, roomno) values ('Badran Hospital', 39);
insert into HospitalHasRoom (hname, roomno) values ('Maddi Hospital', 40);
insert into HospitalHasRoom (hname, roomno) values ('Zed Cairo General Hospital', 41);
insert into HospitalHasRoom (hname, roomno) values ('Cairo general Center', 42);
insert into HospitalHasRoom (hname, roomno) values ('Cairo Medical Center', 43);
insert into HospitalHasRoom (hname, roomno) values ('Cleopatra Hospital', 44);
insert into HospitalHasRoom (hname, roomno) values ('Coptic Hospital', 45);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Fouad Hospital', 46);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Hekma Hospital', 47);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Salam General Hospital', 48);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Oyoun Hospital', 49);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Teb medical Center', 50);
insert into HospitalHasRoom (hname, roomno) values ('al montazah Hospital', 51);
insert into HospitalHasRoom (hname, roomno) values ('Adam International Hospital', 52);
insert into HospitalHasRoom (hname, roomno) values ('Abbasia', 53);
insert into HospitalHasRoom (hname, roomno) values ('El Demerdash', 54);
insert into HospitalHasRoom (hname, roomno) values ('Agooza Hospital', 55);
insert into HospitalHasRoom (hname, roomno) values ('El Salam Hospital', 56);
insert into HospitalHasRoom (hname, roomno) values ('Elexandria Psychiatric centre', 57);
insert into HospitalHasRoom (hname, roomno) values ('Elzahra Hospital', 58);
insert into HospitalHasRoom (hname, roomno) values ('El Salam International Hospital', 59);
insert into HospitalHasRoom (hname, roomno) values ('Amoun Hospital', 60);
insert into HospitalHasRoom (hname, roomno) values ('Zamalek Hospital', 61);
insert into HospitalHasRoom (hname, roomno) values ('Gabal Akhdar', 62);
insert into HospitalHasRoom (hname, roomno) values ('Asyout University Hospital', 63);
insert into HospitalHasRoom (hname, roomno) values ('Badran Hospital', 64);
insert into HospitalHasRoom (hname, roomno) values ('Maddi Hospital', 65);
insert into HospitalHasRoom (hname, roomno) values ('Zed Cairo General Hospital', 66);
insert into HospitalHasRoom (hname, roomno) values ('Cairo general Center', 67);
insert into HospitalHasRoom (hname, roomno) values ('Cairo Medical Center', 68);
insert into HospitalHasRoom (hname, roomno) values ('Cleopatra Hospital', 69);
insert into HospitalHasRoom (hname, roomno) values ('Coptic Hospital', 70);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Fouad Hospital', 71);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Hekma Hospital', 72);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Salam General Hospital', 73);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Oyoun Hospital', 74);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Teb medical Center', 75);
insert into HospitalHasRoom (hname, roomno) values ('al montazah Hospital', 76);
insert into HospitalHasRoom (hname, roomno) values ('Adam International Hospital', 77);
insert into HospitalHasRoom (hname, roomno) values ('Abbasia', 78);
insert into HospitalHasRoom (hname, roomno) values ('El Demerdash', 79);
insert into HospitalHasRoom (hname, roomno) values ('Agooza Hospital', 80);
insert into HospitalHasRoom (hname, roomno) values ('El Salam Hospital', 81);
insert into HospitalHasRoom (hname, roomno) values ('Elexandria Psychiatric centre', 82);
insert into HospitalHasRoom (hname, roomno) values ('Elzahra Hospital', 83);
insert into HospitalHasRoom (hname, roomno) values ('El Salam International Hospital', 84);
insert into HospitalHasRoom (hname, roomno) values ('Amoun Hospital', 85);
insert into HospitalHasRoom (hname, roomno) values ('Zamalek Hospital', 86);
insert into HospitalHasRoom (hname, roomno) values ('Gabal Akhdar', 87);
insert into HospitalHasRoom (hname, roomno) values ('Asyout University Hospital', 88);
insert into HospitalHasRoom (hname, roomno) values ('Badran Hospital', 89);
insert into HospitalHasRoom (hname, roomno) values ('Maddi Hospital', 90);
insert into HospitalHasRoom (hname, roomno) values ('Zed Cairo General Hospital', 91);
insert into HospitalHasRoom (hname, roomno) values ('Cairo general Center', 92);
insert into HospitalHasRoom (hname, roomno) values ('Cairo Medical Center', 93);
insert into HospitalHasRoom (hname, roomno) values ('Cleopatra Hospital', 94);
insert into HospitalHasRoom (hname, roomno) values ('Coptic Hospital', 95);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Fouad Hospital', 96);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Hekma Hospital', 97);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Salam General Hospital', 98);
insert into HospitalHasRoom (hname, roomno) values ('Dar el Oyoun Hospital', 99);
insert into HospitalHasRoom (hname, roomno) values ('Dar El Teb medical Center', 100);






/* Insert data for HospitalHasDep Table */
insert into HospitalHasDep (hname, dno) values ('al montazah Hospital', 4);
insert into HospitalHasDep (hname, dno) values ('Adam International Hospital', 5);
insert into HospitalHasDep (hname, dno) values ('Abbasia', 3);
insert into HospitalHasDep (hname, dno) values ('El Demerdash', 9);
insert into HospitalHasDep (hname, dno) values ('Agooza Hospital', 10);
insert into HospitalHasDep (hname, dno) values ('El Salam Hospital', 1);
insert into HospitalHasDep (hname, dno) values ('Elexandria Psychiatric centre', 8);
insert into HospitalHasDep (hname, dno) values ('Elzahra Hospital', 1);
insert into HospitalHasDep (hname, dno) values ('El Salam International Hospital ', 2);
insert into HospitalHasDep (hname, dno) values ('Amoun Hospital', 4);
insert into HospitalHasDep (hname, dno) values ('Zamalek Hospital', 2);
insert into HospitalHasDep (hname, dno) values ('Gabal Akhdar', 7);
insert into HospitalHasDep (hname, dno) values ('Asyout University Hospital', 3);
insert into HospitalHasDep (hname, dno) values ('Badran Hospital', 3);
insert into HospitalHasDep (hname, dno) values ('Maddi Hospital', 2);
insert into HospitalHasDep (hname, dno) values ('Zed Cairo General Hospital', 2);
insert into HospitalHasDep (hname, dno) values ('Cairo general Center', 7);
insert into HospitalHasDep (hname, dno) values ('Cairo Medical Center', 1);
insert into HospitalHasDep (hname, dno) values ('Cleopatra Hospital', 2);
insert into HospitalHasDep (hname, dno) values ('Coptic Hospital', 10);
insert into HospitalHasDep (hname, dno) values ('Dar El Fouad Hospital', 8);
insert into HospitalHasDep (hname, dno) values ('Dar el Hekma Hospital', 5);
insert into HospitalHasDep (hname, dno) values ('Dar el Salam General Hospital', 2);
insert into HospitalHasDep (hname, dno) values ('Dar el Oyoun Hospital', 3);
insert into HospitalHasDep (hname, dno) values ('Dar El Teb medical Center', 2);



 

/* Insert data for Patient Table */
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (187, 'Asyout University Hospital', 'AB+', 'Vilma', 'Crump', 11, 'Asyout', 'Asyout', '12/5/2020', 'IN', 'Female',  19 , 13, 13, 50);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (100, 'Dar el Oyoun Hospital', 'A+', 'Melamie', 'Glyn', 27, 'New Salhia', 'Sharqia', '10/1/2020', 'OUT', 'Female',  9 , 24, 24, 17);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values ( 65, 'Dar El Teb medical Center', 'A-', 'Carmita', 'Gibby', 68, 'Tahta', 'Sohag', '6/16/2020', 'OUT', 'Female',  18 , 50, 50, 25);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values ( 106, 'Dar el Hekma Hospital', 'O+', 'Garold', 'Comport', 16, 'Dishna', 'Qena', '10/27/2020', 'IN', 'Female', 25, 97, 97, 80);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values ( 143, 'Badran Hospital', 'AB-', 'Huey', 'Kitt', 136, 'Luxor', 'Luxor', '7/28/2020', 'OUT', 'Female',  3 , 14, 14, 19);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  188, 'Dar el Salam General Hospital', 'A-', 'Loralyn', 'Gorton', 96, 'hurgada', 'Red Sea', '7/10/2020', 'IN', 'Male',  22 , 48, 48, 15);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values ( 107, 'El Salam International Hospital ', 'A+', 'Clerc', 'Phillott', 135, 'New Faiyum', 'Faiyum', '10/19/2020', 'IN', 'Female',  2 , 84, 84, 74);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  197, 'Dar el Salam General Hospital', 'O+', 'Pietro', 'McGuffie', 67, 'hurgada', 'Red Sea', '8/2/2020', 'OUT', 'Female',  23 , 73, 73, 98);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  106, 'Coptic Hospital', 'AB+', 'Kippar', 'Alner', 16, 'Port Fuad', 'Port Said', '7/27/2020', 'OUT', 'Male',  10 , 20, 20, 60);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (153, 'Cairo Medical Center', 'AB-', 'Brigitta', 'McCloughlin', 133, 'Downtown', 'cairo', '6/26/2020', 'IN', 'Female',  22 , 43, 43, 61);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  144, 'Dar el Oyoun Hospital', 'AB+', 'Aubert', 'Maceur', 38, 'New Salhia', 'Sharqia', '6/23/2020', 'IN', 'Male',  4 , 49, 49, 57);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values ( 181, 'Adam International Hospital', 'B+', 'Dewain', 'Skinley', 122, 'el shellal', 'Aswan', '4/18/2021', 'OUT', 'Female',  4 , 52, 52, 61);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  162, 'Zamalek Hospital', 'B+', 'Alic', 'Zimek', 103, 'el Mohandseen', 'Giza', '9/26/2020', 'IN', 'Female',  17 , 61, 61, 91);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  148, 'El Demerdash', 'O-', 'Carleen', 'Haslam', 70, 'Damanhour', 'Beheira', '3/10/2021', 'OUT', 'Female',  2 , 79, 79, 74);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  172, 'Badran Hospital', 'AB-', 'Liana', 'Caley', 13, 'Luxor', 'Luxor', '1/21/2021', 'IN', 'Female',  24 , 39, 39, 61);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (   80, 'El Salam Hospital', 'O+', 'Geneva', 'Tourne', 125, 'Maadi', 'cairo', '3/4/2021', 'OUT', 'Male',  10 , 81, 81, 26);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  144, 'Agooza Hospital', 'B+', 'Mikkel', 'Warmington', 12, 'Agooza', 'Giza', '10/29/2020', 'OUT', 'Male',  15 , 5, 5, 91);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (   95, 'al montazah Hospital', 'B+', 'Cherrita', 'Muzzillo', 65, 'al montazah', 'Alexandria', '6/13/2021', 'OUT', 'Female',  14 , 1, 1, 67);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  153, 'Amoun Hospital', 'O+', 'Hannis', 'Palphreyman', 130, 'El Mahalla El Kubra', 'Gharbia', '2/7/2021', 'IN', 'Female',  22 , 10, 10, 22);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  175, 'Dar El Teb medical Center', 'A+', 'Paige', 'Mayell', 3, 'Sohag', 'Sohag', '12/14/2020', 'OUT', 'Female',  24 , 75, 75, 70);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (   89, 'Zed Cairo General Hospital', 'A+', 'Tiler', 'Kither', 38, 'Zamalek', 'cairo', '12/26/2020', 'IN', 'Male',  3 , 41, 41, 11);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values ( 188, 'El Salam International Hospital ', 'O+', 'Mei', 'January 1st', 44, 'New Faiyum', 'Faiyum', '3/3/2021', 'OUT', 'Male',  21 , 9, 9, 73);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  150, 'Maddi Hospital',  'O+' , 'Melanie', 'Sharland', 52, 'El Alamein', 'Matrouh', '11/29/2020', 'IN', 'Female',  21 , 65, 65, 33);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (  161, 'Cairo general Center', 'A-', 'Alexandre', 'Bellas', 81, 'Heliopolis', 'cairo',  '1/31/2021', 'IN', 'Male',  1 , 67, 67, 9);
insert into Patient (height, HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values (   72, 'Elexandria Psychiatric centre', 'B+', 'Gwenny', 'Day', 110, 'Moharam Bek', 'Alexandria', '8/4/2020', 'IN', 'Female', 25, 82, 82, 40);




/* Insert data for Patient_PhoneNo Table  */
insert into Patient_PhoneNo (phoneno, patientid) values ( 1234554321 ,25);
insert into Patient_PhoneNo (phoneno, patientid) values ( 352490267 ,  1 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 449522697 ,  2 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 823214257 ,  3 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 467881482 ,  4 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 302212287 ,  5 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 889114426 ,  6 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 579819704 ,  7 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 101825556 ,  8 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 133178866 ,  9 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 755264535 ,  10 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 614640863 ,  11 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 346166322 ,  12 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 815467867 ,  13 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 186270071 ,  14 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 819111909 ,  15 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 430825309 ,  16 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 991633063 ,  17 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 871723944 ,  18 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 552990802 ,  19 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 940753400 ,  20 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 826842656 ,  21 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 637819983 ,  22 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 601716486 ,  23 );
insert into Patient_PhoneNo (phoneno, patientid) values ( 880747323 ,  24 );




/* Insert data for Patient_treatment Table  */
insert into Patient_treatment (treatment, price, patientid) values ('Warfarin', 628, 25);
insert into Patient_treatment (treatment, price, patientid) values ('Atenolol', 911,  1 );
insert into Patient_treatment (treatment, price, patientid) values ('Captopril', 121,  2 );
insert into Patient_treatment (treatment, price, patientid) values ('Methotrexate', 739,  3 );
insert into Patient_treatment (treatment, price, patientid) values ('Calcium', 790,  4 );
insert into Patient_treatment (treatment, price, patientid) values ('Dobutamine', 415,  5 );
insert into Patient_treatment (treatment, price, patientid) values ('Ranitidine', 151,  6 );
insert into Patient_treatment (treatment, price, patientid) values ('Ruxolitinib', 769,  7 );
insert into Patient_treatment (treatment, price, patientid) values ('Lamivudine', 786,  8 );
insert into Patient_treatment (treatment, price, patientid) values ('Abacavir', 293,  9 );
insert into Patient_treatment (treatment, price, patientid) values ('Magnesium', 940,  10 );
insert into Patient_treatment (treatment, price, patientid) values ('Hydrocodone with acetaminophen', 715,  11 );
insert into Patient_treatment (treatment, price, patientid) values ('Mitotane', 780,  12 );
insert into Patient_treatment (treatment, price, patientid) values ('Factor IX concentrate', 291,  13 );
insert into Patient_treatment (treatment, price, patientid) values ('Imipenem / cilastatin', 132,  14 );
insert into Patient_treatment (treatment, price, patientid) values ('Hydroxyurea', 810,  15 );
insert into Patient_treatment (treatment, price, patientid) values ('Zidovudine', 385,  16 );
insert into Patient_treatment (treatment, price, patientid) values ('Daunorubicin', 433,  17 );
insert into Patient_treatment (treatment, price, patientid) values ('Cladribine', 809,  18 );
insert into Patient_treatment (treatment, price, patientid) values ('Granisetron', 653,  19 );
insert into Patient_treatment (treatment, price, patientid) values ('Interferon alfa2a and alfa2b', 782,  20 );
insert into Patient_treatment (treatment, price, patientid) values ('Allopurinol', 198,  21 );
insert into Patient_treatment (treatment, price, patientid) values ('Cephalexin', 652,  22 );
insert into Patient_treatment (treatment, price, patientid) values ('Imatinib', 989,  23 );
insert into Patient_treatment (treatment, price, patientid) values ('Bleomycin', 401,  24 );




/* Insert data for Patient_Disease Table  */
insert into Patient_Disease (disease, patientid) values ('Arthritis', 25);
insert into Patient_Disease (disease, patientid) values ('Norwalk Virus',  1 );
insert into Patient_Disease (disease, patientid) values ('Helicobacter Pylori',  2 );
insert into Patient_Disease (disease, patientid) values ('Depression',  3 );
insert into Patient_Disease (disease, patientid) values ('Cancer  Uterus',  4 );
insert into Patient_Disease (disease, patientid) values ('Rubella',  5 );
insert into Patient_Disease (disease, patientid) values ('Flu',  6 );
insert into Patient_Disease (disease, patientid) values ('Pneumococcal Disease',  7 );
insert into Patient_Disease (disease, patientid) values ('CreutzfeldtJakob Disease',  8 );
insert into Patient_Disease (disease, patientid) values ('Salmonella',  9 );
insert into Patient_Disease (disease, patientid) values ('AIDS (HIV/AIDS)',  10 );
insert into Patient_Disease (disease, patientid) values ('Clostridium Difficile',  11 );
insert into Patient_Disease (disease, patientid) values ('Sarcoidosis',  12 );
insert into Patient_Disease (disease, patientid) values ('Conjunctivitis' ,  13 );
insert into Patient_Disease (disease, patientid) values ('Sexually Transmitted Diseases (STDs)',  14 );
insert into Patient_Disease (disease, patientid) values ('Cyclospora',  15 );
insert into Patient_Disease (disease, patientid) values ('CreutzfeldtJakob Disease',  16 );
insert into Patient_Disease (disease, patientid) values ('Cancer  Multiple Myeloma',  17 );
insert into Patient_Disease (disease, patientid) values ('Lymphogranuloma Venereum (LGV)',  18 );
insert into Patient_Disease (disease, patientid) values ('Parkinson Disease',  19 );
insert into Patient_Disease (disease, patientid) values ('Cancer  Leukemia',  20 );
insert into Patient_Disease (disease, patientid) values ('Cancer  Multiple Myeloma',  21 );
insert into Patient_Disease (disease, patientid) values ('SARS',  22 );
insert into Patient_Disease (disease, patientid) values ('Cancer  Oral',  23 );
insert into Patient_Disease (disease, patientid) values ('Fibromyalgia',  24 );




/* Insert data for Bill Table */
insert into Bill ( bill_price, patientid) values ( 9225, 25);
insert into Bill ( bill_price, patientid) values ( 19902,  1 );
insert into Bill ( bill_price, patientid) values ( 19422,  2 );
insert into Bill ( bill_price, patientid) values ( 14140,  3 );
insert into Bill ( bill_price, patientid) values ( 15070,  4 );
insert into Bill ( bill_price, patientid) values ( 13643,  5 );
insert into Bill ( bill_price, patientid) values (  2972,  6 );
insert into Bill ( bill_price, patientid) values (  6089,  7 );
insert into Bill ( bill_price, patientid) values (13658,  8 );
insert into Bill ( bill_price, patientid) values (  6743,  9 );
insert into Bill ( bill_price, patientid) values (  4192,  10 );
insert into Bill ( bill_price, patientid) values (  6266,  11 );
insert into Bill ( bill_price, patientid) values ( 18202,  12 );
insert into Bill ( bill_price, patientid) values ( 6508,  13 );
insert into Bill ( bill_price, patientid) values (  4059,  14 );
insert into Bill ( bill_price, patientid) values ( 12062,  15 );
insert into Bill ( bill_price, patientid) values ( 15946,  16 );
insert into Bill ( bill_price, patientid) values ( 10463,  17 );
insert into Bill ( bill_price, patientid) values ( 18885,  18 );
insert into Bill ( bill_price, patientid) values ( 17800,  19 );
insert into Bill ( bill_price, patientid) values (  4748,  20 );
insert into Bill ( bill_price, patientid) values ( 14374,  21 );
insert into Bill ( bill_price, patientid) values ( 19654,  22 );
insert into Bill ( bill_price, patientid) values ( 13937,  23 );
insert into Bill ( bill_price, patientid) values ( 12711,  24 );










--select bill_id, bill_price
--From Bill
--Where PatientID =24;



--select hname, city, area
--from Hospital
--where PatientID in 
--	(
--		Select city, area
--		from Patient
--		where PatientID = 0
--	);



--select BedID, roomno from Bed

--select * from Hospital
--select * from HospitalHasRoom
--select * from Room
--select * from Bed
--select * from Department
--select * from Doctor
--select * from DocIsInDep
/*
create table Patient_treatment
(
    Treatment varchar(50),
    price int,
    PatientID int,
    primary key(Treatment,PatientID)
);*/
--select Sum(price) from Patient_treatment where PatientID=5
--select count(*) from Patient where RoomNo=107
--select count(BedID) from Bed where RoomNo=107
--select * from Patient
--select * from DocIsInDep

--Select PatientID from Patient WHERE CAST(PatientID as CHAR) LIKE '%1%'
--if not exists (select 1 from Department where Department.Dname='name')
--insert into Department(Dname) values('name')

--Select hname from Hospital where area='6th of october' and exists( Select roomno from HospitalHasRoom where HospitalHasRoom.hname=Hospital.hname and exists(Select RoomNo from Room where (select count(*) from Patient where RoomNo=Room.RoomNo)< (select count(BedID) from Bed where RoomNo=Room.RoomNo) and HospitalHasRoom.RoomNo = Room.RoomNo));
--Select roomno from HospitalHasRoom where HospitalHasRoom.hname='test hos' and exists(Select RoomNo from Room where (select count(*) from Patient where RoomNo=Room.RoomNo)< (select count(BedID) from Bed where RoomNo=Room.RoomNo) and HospitalHasRoom.RoomNo = Room.RoomNo);



