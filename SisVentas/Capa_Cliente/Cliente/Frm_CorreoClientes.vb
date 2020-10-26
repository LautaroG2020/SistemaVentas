Public Class Frm_CorreoClientes
    Public Sub Limpiar()
        txtEmisor.Clear()
        txtPassword.Clear()
        txtMensaje.Clear()
        txtAsunto.Clear()
        txtDestinatario.Clear()
        txtRutaArchivo.Clear()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                txtRutaArchivo.Text = Me.OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el archivo: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click
        If txtEmisor.Text <> "" And txtPassword.Text <> "" And txtDestinatario.Text <> "" Then
            If txtMensaje.Text = "" Then
                Dim res As New DialogResult
                res = MessageBox.Show("El E-Mail que esta por enviar tiene el mensaje vacio, ¿Desea continuar?", "Mensaje vacio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If res = DialogResult.OK Then
                    Try
                        enviarCorreo(txtEmisor.Text, txtPassword.Text, txtMensaje.Text, txtAsunto.Text, txtDestinatario.Text, txtRutaArchivo.Text)
                        Limpiar()
                    Catch ex As Exception
                    End Try
                Else
                    Me.Show()
                    txtMensaje.Focus()
                End If
            End If

        Else
            MessageBox.Show("Faltar completar datos del correo, intentelo de nuevo.", "Error al enviar correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As New FontDialog
        f.ShowDialog()
        Me.txtMensaje.SelectionFont = f.Font
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim C As New ColorDialog
        C.ShowDialog()
        Me.txtMensaje.SelectionColor = C.Color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txtMensaje.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.txtMensaje.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.txtMensaje.SelectionAlignment = HorizontalAlignment.Right
    End Sub
End Class