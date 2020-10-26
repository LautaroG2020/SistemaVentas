Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio
Public Class Frm_Backup_Base
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim func As New Cls_BackUps

            If func.Backup_base() Then
                MessageBox.Show("El BackUp de la base de datos del sistema ha sido generado satisfactoriamente.", "BackUp del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El BackUp de la base de datos del sistema no pudo ser generado.", "BackUp del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class