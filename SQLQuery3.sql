use Supermarker
create table Productos 
(
Producto_id int identity (100000,1) primary key, 
Producto_name nvarchar (50) not null,
Producto_precio int ,
Producto_stock int ,
Producto_category nvarchar (50) not null,
)
go 
insert into Productos values ('Leche','150','10','Lacteos')