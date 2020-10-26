Imports System.Data.SqlClient
Imports Capa_Conexion
Public Class Cls_BackUps
    Inherits Cls_conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos

    Public Function Backup_base() As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Backup_base")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

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
End Class
