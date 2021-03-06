USE [dbventas]
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_detalleventa]    Script Date: 03/09/2020 12:23:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Mostrar_detalleventa]
as
SELECT     dbo.Detalle_Venta.IDDetalle_venta, dbo.Detalle_Venta.IDVenta, dbo.Detalle_Venta.IDProducto, dbo.Productos.Nombre, dbo.Detalle_Venta.Cantidad, 
                      dbo.Detalle_Venta.Precio_Unitario
FROM         dbo.Detalle_Venta INNER JOIN
                      dbo.Productos ON dbo.Detalle_Venta.IDProducto = dbo.Productos.IDproducto
                       order by dbo.Detalle_Venta.IDDetalle_venta desc 