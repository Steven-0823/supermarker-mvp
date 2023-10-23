use Supermarker 
create table Providers 
(
providers_Id int identity (100000,1) primary key,
providers_Name nvarchar (50) not null, 
providers_Observation nvarchar (50) not null,
)
go
insert into Providers values('Colombina', 'Dulces')
insert into Providers values('Genfar', 'Pastas')