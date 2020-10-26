create procedure Generar_Comprobante
@IDVenta int
as
SELECT     dbo.Ventas.IDVenta, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.Cliente.Dni, dbo.Ventas.Fecha, dbo.Ventas.Tipo_Documento, dbo.Ventas.Num_Documento, 
                      dbo.Productos.Nombre AS Descripcion, dbo.Detalle_Venta.Cantidad, dbo.Detalle_Venta.Precio_Unitario, 
                      dbo.Detalle_Venta.Cantidad * dbo.Detalle_Venta.Precio_Unitario AS Total_Parcial
FROM         dbo.Ventas INNER JOIN
                      dbo.Detalle_Venta ON dbo.Ventas.IDVenta = dbo.Detalle_Venta.IDVenta INNER JOIN
                      dbo.Productos ON dbo.Detalle_Venta.IDProducto = dbo.Productos.IDproducto INNER JOIN
                      dbo.Cliente ON dbo.Ventas.IDCliente = dbo.Cliente.IDCliente
                      
                      where dbo.Ventas.IDVenta = @IDVenta