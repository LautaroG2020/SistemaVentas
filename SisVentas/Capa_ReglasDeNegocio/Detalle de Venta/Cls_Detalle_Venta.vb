Imports System.Data.SqlClient
Imports Capa_Conexion
Public Class Cls_Detalle_Venta
    Inherits Cls_conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos

    Dim _iddetalle_venta, _idventa, _idproducto As Integer
    Dim _cantidad, _precio_unitario As Double

    Dim myListadoVenta = New List(Of Cls_Detalle_Venta)





#Region "Propiedades"

    Public Property IDDetalle_venta() As Integer
        Get
            Return _iddetalle_venta
        End Get
        Set(value As Integer)
            _iddetalle_venta = value
        End Set
    End Property

    Public Property IDVenta() As Integer
        Get
            Return _idventa
        End Get
        Set(value As Integer)
            _idventa = value
        End Set
    End Property

    Public Property IDProducto() As Integer
        Get
            Return _idproducto
        End Get
        Set(value As Integer)
            _idproducto = value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property Precio_Unitario() As Double
        Get
            Return _precio_unitario
        End Get
        Set(value As Double)
            _precio_unitario = value
        End Set
    End Property
#End Region

#Region "Contructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal _iddetalle_venta As Integer, ByVal _idventa As Integer, ByVal _idproducto As Integer, ByVal _cantidad As Double, ByVal _precio_unitario As Double)
        IDDetalle_Venta = _iddetalle_venta
        IDVenta = _idventa
        IDProducto = _idproducto
        Cantidad = _cantidad
        Precio_Unitario = _precio_unitario
    End Sub
#End Region

#Region "Metodos"

    Public Function Mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_detalleventa")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable 'permite crear una tabla en memoria con los registros de la tabla cliente
                Dim da As New SqlDataAdapter(cmd) 'adaptador para conectar con la base de datos y poder mostrarla en el sistema
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Sub Contenedor(ByVal dts As Cls_Detalle_Venta)
        myListadoVenta.Add(dts)
        'myListadoVenta.Add("@IDProducto", dts.IDProducto)
        'myListadoVenta.Add("@Cantidad", dts.Cantidad)
        'myListadoVenta.Add("@Precio_Unitario", dts.Precio_Unitario)
    End Sub

    Public Function Insertar(ByVal dts As Cls_Detalle_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar_detalleventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDVenta", dts.IDVenta)
            cmd.Parameters.AddWithValue("@IDProducto", dts.IDProducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts.Cantidad)
            cmd.Parameters.AddWithValue("@Precio_Unitario", dts.Precio_Unitario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function Editar(ByVal dts As Cls_Detalle_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_detalleventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDDetalle_venta", dts.IDVenta)
            cmd.Parameters.AddWithValue("@IDVenta", dts.IDVenta)
            cmd.Parameters.AddWithValue("@IDProducto", dts.IDProducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts.Cantidad)
            cmd.Parameters.AddWithValue("@Precio_Unitario", dts.Precio_Unitario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function Eliminar(ByVal dts As Cls_Detalle_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_detalleventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDDetalle_venta", SqlDbType.NVarChar, 50).Value = dts.IDDetalle_venta
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function Aumentar_Stock(ByVal dts As Cls_Detalle_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDProducto", dts.IDProducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts.Cantidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function Disminuir_Stock(ByVal dts As Cls_Detalle_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDProducto", dts.IDProducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts.Cantidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
#End Region
End Class
