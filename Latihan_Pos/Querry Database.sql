create database DataSales;
use DataSales;

create table Things(
	ID int(10) primary key,
    _Code varchar(20),
    _Name varchar(100),
    _FirstSUM int(10),
    _HPPPrice decimal(16,2),
    _SalePrice decimal(16,2),
    Born datetime,
    Mutated datetime
);
create table Staff(
	ID int(10) primary key,
    _Code varchar(20),
    _Name varchar(100),
    _Address varchar(10),
    Born datetime,
    Mutated datetime
);
create table Supplier(
	ID int(10) primary key,
    _Code varchar(20),
    _Name varchar(100),
    _Address varchar(10),
    Born datetime,
    Mutated datetime
);
create table Trans_Log(
	ID_Log int(10) primary key,
    ID_Things int(10),
    Code_Things varchar(20),
    Name_Things varchar(100),
    _Status varchar(4),
    _Quantity int(10),
    _TotalPrice decimal(16,2),
    _Time datetime
);
alter table Trans_Log add column _Status varchar(4);