create procedure Editar_cliente
@IDCliente integer,
@Nombre varchar (50),
@Apellido varchar (50),
@Direccion varchar (150),
@Telefono varchar (12),
@Dni varchar (8)
as 
update Cliente set Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono, Dni = @Dni
where IDCliente = @IDCliente
go


create procedure Eliminar_cliente
@IDCliente as integer
as
delete from Cliente where IDCliente = @IDCliente
go

---------------Mantenimiento de la tabla Categorias-------------

create procedure Mostrar_categoria
as
Select * from Categoria order by IDCategoria desc
go


create procedure Insertar_categoria
@Nombre_Categoria varchar (50)
as 
insert into Categoria (Nombre_categoria) values (@Nombre_Categoria)
go

create procedure Editar_categoria
@IDCategoria as integer, 
@nombre_Categoria varchar (50)
as
update Categoria set Nombre_categoria = @nombre_Categoria 
where IDCategoria = @IDCategoria
go

create procedure Eliminar_categoria
@IDCategoria as integer
as
delete from Categoria where IDCategoria = @IDCategoria
go

-------------- Mantenimiento de Productos ---------------------------
-- agregamos una nueva columna a la tabla
alter table Productos
add Imagen image
go

create procedure Mostrar_producto
as
select Productos.IDproducto, Productos.IDCategoria, Categoria.Nombre_categoria, Productos.Nombre, Productos.Descripcion, 
Productos.Stock, Productos.Precio_Compra, Productos.Precio_Venta, Productos.Fecha_Vencimiento, Productos.Imagen
from Productos inner join Categoria on Productos.IDCategoria = Categoria.IDCategoria
order by Productos.IDproducto desc
go


create procedure Insertar_producto
@IDCategoria as integer,
@Nombre as varchar(50),
@Descripcion as varchar (150),
@Stock as decimal(18,2),
@Precio_Compra as decimal (18,2),
@Precio_Venta as decimal (18,2),
@Fecha_Vencimiento as date,
@Imagen as image
as
insert into Productos(IDCategoria,Nombre,Descripcion,Stock,Precio_Compra,Precio_Venta,Fecha_Vencimiento,Imagen)
values (@IDCategoria, @Nombre,@Descripcion,@Stock,@Precio_Compra,@Precio_Venta,@Fecha_Vencimiento,@Imagen)
go


create procedure Editar_producto
@IDProducto as integer,
@IDCategoria as integer,
@Nombre as varchar(50),
@Descripcion as varchar (150),
@Stock as decimal(18,2),
@Precio_Compra as decimal (18,2),
@Precio_Venta as decimal (18,2),
@Fecha_Vencimiento as date,
@Imagen as image
as
update Productos set IDCategoria = @IDCategoria, Nombre = @Nombre, Descripcion = @Descripcion,
Stock = @Stock, Precio_Compra = @Precio_Compra, Precio_Venta = @Precio_Venta, Fecha_Vencimiento = @Fecha_Vencimiento,
Imagen = @Imagen
where IDproducto = @IDProducto
go


create procedure Eliminar_producto
@IDProducto as integer
as
delete from Productos where IDproducto = @IDProducto
go


------------------Matenimiento de la tabla venta -----------------------
create procedure Insertar_venta
@IDCliente as integer,
@Fecha as date,
@Tipo_Documento as varchar (50),
@Num_Documento as varchar (50)
as 
insert into Ventas (IDCliente, Fecha, Tipo_Documento, Num_Documento) 
values (@IDCliente, @Fecha, @Tipo_Documento, @Num_Documento)
go

create procedure Editar_venta
@IDVenta as integer,
@IDCliente as integer,
@Fecha as date,
@Tipo_Documento as varchar (50),
@Num_Documento as varchar (50)
as 
update Ventas set IDCliente = @IDCliente, Fecha = @Fecha, 
Tipo_Documento = @Tipo_Documento, Num_Documento = @Num_Documento
where IDCliente = @IDCliente
go

create procedure Eliminar_venta
@IDVenta as integer
as
delete from Ventas where IDVenta = @IDVenta
go

create procedure Mostrar_venta
as
SELECT     dbo.Cliente.Apellido, dbo.Cliente.Dni, dbo.Ventas.IDVenta, dbo.Ventas.IDCliente, dbo.Ventas.Fecha, dbo.Ventas.Tipo_Documento, dbo.Ventas.Num_Documento
FROM         dbo.Ventas INNER JOIN
                      dbo.Cliente ON dbo.Ventas.IDCliente = dbo.Cliente.IDCliente
go


-----------------------Mantenimiento de la tabla detalle de venta------------
create procedure Insertar_detalleventa
@IDVenta as integer,
@IDProducto as integer,
@Cantidad as decimal(18,2),
@Precio_Unitario as decimal (18,2)
as
insert into Detalle_Venta (IDVenta,	IDProducto, Cantidad,Precio_Unitario) 
values (@IDVenta, @IDProducto,@Cantidad,@Precio_Unitario)
go

create procedure Editar_detalleventa
@IDDetalle_venta as integer,
@IDVenta as integer,
@IDProducto as integer,
@Cantidad as decimal(18,2),
@Precio_Unitario as decimal (18,2)
as
update Detalle_Venta set IDVenta = @IDVenta,IDProducto = @IDProducto, 
Cantidad = @Cantidad,Precio_Unitario = @Precio_Unitario
where IDDetalle_venta = @IDDetalle_venta
go

create procedure Eliminar_detalleventa
@IDDetalle_venta as integer
as
delete from Detalle_Venta where IDDetalle_venta = @IDDetalle_venta
go

create procedure Mostrar_detalleventa
as
select * from Detalle_Venta order by IDDetalle_venta desc 
go

create procedure Aumentar_stock
@IDProducto as integer,
@Cantidad as decimal (18,2)
as 
update Productos set Stock = Stock + @Cantidad where IDproducto = @IDProducto
go

create procedure Disminuir_stock
@IDProducto as integer,
@Cantidad as decimal (18,2)
as 
update Productos set Stock = Stock - @Cantidad where IDproducto = @IDProducto
go
