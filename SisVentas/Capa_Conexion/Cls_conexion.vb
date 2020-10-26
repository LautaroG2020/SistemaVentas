Imports System.Data.SqlClient

Public Class Cls_conexion
    Public cnn As New SqlConnection 'Variable para establecer una conexion con la base de datos
    Public idusuario As Integer

    Public Function conectado()
        Try
            cnn = New SqlConnection("Server=192.168.56.1;Uid=sa;Pwd=sasa;Database=dbventas;")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Class
