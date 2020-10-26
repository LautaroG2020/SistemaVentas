Imports System.Data.SqlClient
Imports Capa_Conexion
Public Class Cls_Usuario
    Inherits Cls_conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos

    Dim _id_usuario As Integer
    Dim _nombre, _apellido, _dni, _direccion, _telefono, _login, _password, _acceso As String

#Region "Propiedades"

    Public Property IDUsuario() As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
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
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
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

    Public Property Login() As String
        Get
            Return _login
        End Get
        Set(value As String)
            _login = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Property Acceso() As String
        Get
            Return _acceso
        End Get
        Set(value As String)
            _acceso = value
        End Set
    End Property
#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal _id_usuario As Integer, ByVal _nombre As String, ByVal _apellido As String, ByVal _dni As String, ByVal _direccion As String,
    ByVal _telefono As String, ByVal _login As String, ByVal _password As String, ByVal _acceso As String)
        IDUsuario = _id_usuario
        Nombre = _nombre
        Apellido = _apellido
        Dni = _dni
        Direccion = _direccion
        Telefono = _telefono
        Login = _login
        Password = _password
        Acceso = _acceso

    End Sub

#End Region

#Region "Metodos"
    Public Function Mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_usuario")
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

    Public Function Validar_Usuario(ByVal dts As Cls_Usuario)
        Try
            conectado()
            cmd = New SqlCommand("Validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Login", dts.Login)
            cmd.Parameters.AddWithValue("@Password", dts.Password)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
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
    Public Function Insertar(ByVal dts As Cls_Usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@Nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@Apellido", dts.Apellido)
            cmd.Parameters.AddWithValue("@Dni", dts.Dni)
            cmd.Parameters.AddWithValue("@Direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@Telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@Login", dts.Login)
            cmd.Parameters.AddWithValue("@Password", dts.Password)
            cmd.Parameters.AddWithValue("@Acceso", dts.Acceso)

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

    Public Function Editar(ByVal dts As Cls_Usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDUsuario", dts.IDUsuario)
            cmd.Parameters.AddWithValue("@Nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@Apellido", dts.Apellido)
            cmd.Parameters.AddWithValue("@Dni", dts.Dni)
            cmd.Parameters.AddWithValue("@Direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@Telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@Login", dts.Login)
            cmd.Parameters.AddWithValue("@Password", dts.Password)
            cmd.Parameters.AddWithValue("@Acceso", dts.Acceso)

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

    Public Function Eliminar(ByVal dts As Cls_Usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = dts.IDUsuario
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
#End Region
End Class
