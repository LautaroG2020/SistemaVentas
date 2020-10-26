Imports System.Data.SqlClient
Imports Capa_Conexion
Imports System.Windows.Forms
Public Class Cls_Venta
    Inherits Cls_conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos


    Dim _idcliente, _idventa As Integer
    Dim _fecha, _fecha1, _fecha2 As Date
    Dim _tipo_documento, _num_documento As String


#Region "Propiedades"
    Public Property IDVenta() As Integer
        Get
            Return _idventa
        End Get
        Set(value As Integer)
            _idventa = value
        End Set
    End Property

    Public Property IDCliente() As Integer
        Get
            Return _idcliente
        End Get
        Set(value As Integer)
            _idcliente = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Fecha1() As Date
        Get
            Return _fecha1
        End Get
        Set(value As Date)
            _fecha1 = value
        End Set
    End Property
    Public Property Fecha2() As Date
        Get
            Return _fecha2
        End Get
        Set(value As Date)
            _fecha2 = value
        End Set
    End Property

    Public Property Tipo_Documento() As String
        Get
            Return _tipo_documento
        End Get
        Set(value As String)
            _tipo_documento = value
        End Set
    End Property

    Public Property Num_Documento() As String
        Get
            Return _num_documento
        End Get
        Set(value As String)
            _num_documento = value
        End Set
    End Property
#End Region

#Region "Contrusctores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal _idventa As Integer, ByVal _idcliente As Integer, ByVal _fecha As Date, ByVal _fecha1 As Date, ByVal _fecha2 As Date, ByVal _tipo_documento As String, ByVal _num_documento As String)
        IDVenta = _idventa
        IDCliente = _idcliente
        Fecha = _fecha
        Fecha1 = _fecha1
        Fecha2 = _fecha2
        Tipo_Documento = _tipo_documento
        Num_Documento = _num_documento
    End Sub

#End Region

#Region "Metodos"

    Public Function Mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_venta")
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

    Public Function MostrarConsultaVentas() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarConsulta_venta")
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


    Public Function Insertar(ByVal dts As Cls_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn



            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDCliente", dts.IDCliente)
            cmd.Parameters.AddWithValue("@Fecha", dts.Fecha)
            cmd.Parameters.AddWithValue("@Tipo_documento", dts.Tipo_Documento)
            cmd.Parameters.AddWithValue("@Num_Documento", dts.Num_Documento)

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

    Public Function Editar(ByVal dts As Cls_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDVenta", dts.IDVenta)
            cmd.Parameters.AddWithValue("@IDCliente", dts.IDCliente)
            cmd.Parameters.AddWithValue("@Fecha", dts.Fecha)
            cmd.Parameters.AddWithValue("@Tipo_documento", dts.Tipo_Documento)
            cmd.Parameters.AddWithValue("@Num_Documento", dts.Num_Documento)

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

    Public Function Eliminar(ByVal dts As Cls_Venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDVenta", SqlDbType.NVarChar, 50).Value = dts.IDVenta
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
    Public Function ValidarNombre(ByVal numero_documento As String) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim cnn = New SqlConnection("Server=192.168.56.1;Uid=sa;Pwd=sasa;Database=dbventas;")
            cnn.Open()
            Dim cmd = New SqlCommand("Select * from Ventas where Num_Documento = '" & numero_documento & "'", cnn)
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

    'Funcion para consultar las ventas realizadas entre 2 fechas
    Public Function Consultar_Ventas(ByVal dts As Cls_Venta) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("Consultar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@Fecha1", dts.Fecha1)
            cmd.Parameters.AddWithValue("@Fecha2", dts.Fecha2)

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
