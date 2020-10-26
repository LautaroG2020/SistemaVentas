Imports System.Data.SqlClient
Imports Capa_Conexion
Public Class Cls_Productos
    Inherits Cls_conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos

    Dim _idproducto, _idcategoria As Integer
    Dim _nombre, _descripcion As String
    Dim _stock, _precio_compra, _precio_venta As Double
    Dim _fecha_vencimiento As Date
    Dim imagen() As Byte


#Region "Propiedades"
    Public Property IDProducto() As Integer
        Get
            Return _idproducto
        End Get
        Set(value As Integer)
            _idproducto = value
        End Set
    End Property

    Public Property IDCategoria() As Integer
        Get
            Return _idcategoria
        End Get
        Set(value As Integer)
            _idcategoria = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
    Public Property Stock() As Double
        Get
            Return _stock
        End Get
        Set(value As Double)
            _stock = value
        End Set
    End Property

    Public Property Precio_Compra() As Double
        Get
            Return _precio_compra
        End Get
        Set(value As Double)
            _precio_compra = value
        End Set
    End Property

    Public Property Precio_Venta() As Double
        Get
            Return _precio_venta
        End Get
        Set(value As Double)
            _precio_venta = value
        End Set
    End Property
    Public Property Fecha_Vencimiento() As Date
        Get
            Return _fecha_vencimiento
        End Get
        Set(value As Date)
            _fecha_vencimiento = value
        End Set
    End Property

    Public Property GImagen
        Get
            Return imagen
        End Get
        Set(value)
            imagen = value
        End Set
    End Property
#End Region

#Region "constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal _idproducto As Integer, ByVal _idcategoria As Integer, ByVal _nombre As String, ByVal _descripcion As String,
                   ByVal _stock As Double, ByVal _precio_compra As Double, ByVal _precio_venta As Double, ByVal _fecha_vencimiento As Date, ByVal imagen() As Byte)
        IDProducto = _idproducto
        IDCategoria = _idcategoria
        Nombre = _nombre
        Descripcion = _descripcion
        Stock = _stock
        Precio_Compra = _precio_compra
        Precio_Venta = _precio_venta
        Fecha_Vencimiento = _fecha_vencimiento
        GImagen = imagen
    End Sub

#End Region

#Region "Metodos"

    Public Function Mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_producto")
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

    Public Function Insertar(ByVal dts As Cls_Productos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn



            'Insertamos los datos.
            '--------------------------------------------------------------------------
            cmd.Parameters.AddWithValue("@IDCategoria", dts.IDCategoria)
            cmd.Parameters.AddWithValue("@Nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@Descripcion", dts.Descripcion)
            cmd.Parameters.AddWithValue("@Stock", dts.Stock)
            cmd.Parameters.AddWithValue("@Precio_Compra", dts.Precio_Compra)
            cmd.Parameters.AddWithValue("@Precio_venta", dts.Precio_Venta)
            cmd.Parameters.AddWithValue("@Fecha_Vencimiento", dts.Fecha_Vencimiento)
            cmd.Parameters.AddWithValue("@Imagen", dts.GImagen)
            '-------------------------------------------------------------------------
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

    Public Function Editar(ByVal dts As Cls_Productos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDProducto", dts.IDProducto)
            cmd.Parameters.AddWithValue("@IDCategoria", dts.IDCategoria)
            cmd.Parameters.AddWithValue("@Nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@Descripcion", dts.Descripcion)
            cmd.Parameters.AddWithValue("@Stock", dts.Stock)
            cmd.Parameters.AddWithValue("@Precio_Compra", dts.Precio_Compra)
            cmd.Parameters.AddWithValue("@Precio_venta", dts.Precio_Venta)
            cmd.Parameters.AddWithValue("@Fecha_Vencimiento", dts.Fecha_Vencimiento)
            cmd.Parameters.AddWithValue("@Imagen", dts.GImagen)

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

    Public Function Eliminar(ByVal dts As Cls_Productos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDProducto", SqlDbType.NVarChar, 50).Value = dts.IDProducto
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

    'Retorna true o false si el registro existe o no en la tabla
    Public Function ValidarNombre(ByVal nombre As String) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim cnn = New SqlConnection("Server=192.168.56.1;Uid=sa;Pwd=sasa;Database=dbventas;")
            cnn.Open()
            Dim cmd = New SqlCommand("Select * from Productos where Nombre= '" & nombre & "'", cnn)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error en el procedimiento: " & ex.Message)
        End Try
        Return resultado
    End Function

#End Region

End Class
