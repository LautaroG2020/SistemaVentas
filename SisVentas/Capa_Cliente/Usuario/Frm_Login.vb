Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio
Public Class Frm_Login


    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub Btn_Ingresar_Click_1(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        Try
            Dim dts As New Cls_Usuario

            dts.Login = txt_Login.Text
            dts.Password = Txt_Password.Text

            If dts.Validar_Usuario(dts) = True Then
                Frm_Inicio.Txt_flag.Text = "1"
                If Frm_Inicio.Txt_flag.Text = "1" Then
                    Frm_Inicio.Tss_lbl_Estado.Text = "Conectado"
                End If
                Frm_Inicio.Show()
                Me.Hide()

            Else
                MsgBox("Verifique que haya colocado bien sus datos e intente nuevamente.", MsgBoxStyle.Information, "Acceso denegado al sistema")
                ' comentado por correccion de Leo.
                'txt_Login.Clear()
                'Txt_Password.Clear()
                txt_Login.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_Salir_Click_1(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Contacta a un tecnico representante del sistema para continuar con el cambio de contraseña.", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class