Imports System.Data.SqlClient
Imports Capa_Conexion

Public Class Cls_Categoria
    Inherits Cls_conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos

    Dim _idcategoria As Integer
    Dim _nombrecategoria As String




#Region "Propiedades"
    Public Property IDCategoria() As Integer
        Get
            Return _idcategoria
        End Get
        Set(value As Integer)
            _idcategoria = value
        End Set
    End Property

    Public Property Nombre_Categoria() As String
        Get
            Return _nombrecategoria
        End Get
        Set(value As String)
            _nombrecategoria = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal _idcategoria As Integer, ByVal _nombrecategoria As String)
        IDCategoria = _idcategoria
        Nombre_Categoria = _nombrecategoria
    End Sub
#End Region

#Region "Metodos"
    Public Function Mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_categoria")
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

    Public Function Insertar(ByVal dts As Cls_Categoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@Nombre_Categoria", dts.Nombre_Categoria)

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

    Public Function Editar(ByVal dts As Cls_Categoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Enviar todos los valores que se reciben
            cmd.Parameters.AddWithValue("@IDCategoria", dts.IDCategoria)
            cmd.Parameters.AddWithValue("@Nombre_Categoria", dts.Nombre_Categoria)

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

    Public Function Eliminar(ByVal dts As Cls_Categoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDCategoria", SqlDbType.NVarChar, 50).Value = dts.IDCategoria
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
            Dim cmd = New SqlCommand("Select * from Categoria where Nombre_Categoria = '" & nombre & "'", cnn)
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
