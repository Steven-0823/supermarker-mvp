use Supermarker 
create table Category 
(
category_Id int identity (100000,1) primary key,
category_Name nvarchar (50) not null, 
category_Observation nvarchar (50) not null,
)
go
insert into Category values('Leche', 'Lacteos')
insert into Category values('Jabon', 'Aseo')