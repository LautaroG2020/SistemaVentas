Imports System.Data.SqlClient
Imports Capa_Conexion
Public Class Cls_Cliente
    Inherits Cls_conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos

    Dim _idcliente As Integer
    Dim _nombre, _apellido, _direccion, _telefono, _dni As String
#Region "Propiedades"
    Public Property IDCliente() As Integer
        Get
            Return _idcliente
        End Get
        Set(value As Integer)
            _idcliente = value
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

    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property


#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal _idcliente As Integer, ByVal _nombre As String, ByVal _apellido As String, ByVal _direccion As String, ByVal _telefono As String, ByVal _dni As String)
        IDCliente = _idcliente
        Nombre = _nombre
        Apellido = _apellido
        Direccion = _direccion
        Telefono = _telefono
        Dni = _dni
    End Sub
#End Region

#Region "Metodos"
    Public Function Mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_cliente")
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

    Public Function Insertar(ByVal dts As Cls_Cliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@Nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@Apellido", dts.Apellido)
            cmd.Parameters.AddWithValue("@Direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@Telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@Dni", dts.Dni)

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

    Public Function Editar(ByVal dts As Cls_Cliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDCliente", dts.IDCliente)
            cmd.Parameters.AddWithValue("@Nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@Apellido", dts.Apellido)
            cmd.Parameters.AddWithValue("@Direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@Telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@Dni", dts.Dni)

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

    Public Function Eliminar(ByVal dts As Cls_Cliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDCliente", SqlDbType.NVarChar, 50).Value = dts.IDCliente
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
    Public Function ValidarNombre(ByVal nombre As String, ByVal apellido As String) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim cnn = New SqlConnection("Server=192.168.56.1;Uid=sa;Pwd=sasa;Database=dbventas;")
            cnn.Open()
            Dim cmd = New SqlCommand("Select * from Cliente where Nombre= '" & nombre & "' and Apellido = '" & apellido & "'", cnn)
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
