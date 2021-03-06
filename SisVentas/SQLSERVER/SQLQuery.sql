USE [dbventas]
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_venta]    Script Date: 03/09/2020 10:02:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Mostrar_venta]
as
SELECT      dbo.Ventas.IDVenta, dbo.Ventas.IDCliente, dbo.Cliente.Apellido, dbo.Cliente.Dni, dbo.Ventas.Fecha, dbo.Ventas.Tipo_Documento, dbo.Ventas.Num_Documento
FROM         dbo.Ventas INNER JOIN
                      dbo.Cliente ON dbo.Ventas.IDCliente = dbo.Cliente.IDCliente
                      order by dbo.Ventas.IDVenta desc
