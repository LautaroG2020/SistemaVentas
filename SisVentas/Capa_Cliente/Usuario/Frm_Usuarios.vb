Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio

Public Class Usuarios
    Private dt As New DataTable ' Para guardar los datos de la tabla en memoria

    Private Sub Cls_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        Desabilitar()
        btn_Seleccionar.Visible = False
    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New Cls_Usuario
            dt = func.Mostrar()
            DataListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                Txt_Buscar.Enabled = True
                DataListado.ColumnHeadersVisible = True
                LinkLabel1.Visible = False
            Else
                DataListado.DataSource = Nothing
                Txt_Buscar.Enabled = False
                DataListado.ColumnHeadersVisible = False
                LinkLabel1.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Btn_Nuevo.Visible = True
        Btn_Editar.Visible = False

        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim ds As New DataSet       'Se encarga de copiar todos los registros que tiene el datatable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            'Se filtran los datos elegidos por el combobox
            dv.RowFilter = Cbo_Campo.Text & " like '" & Txt_Buscar.Text & "%'"

            If dv.Count <> 0 Then
                LinkLabel1.Visible = False
                DataListado.DataSource = dv
                Ocultar_Columnas()
            Else
                LinkLabel1.Visible = True
                DataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        End Try
    End Sub

    Private Sub Ocultar_Columnas()
        DataListado.Columns(1).Visible = False
    End Sub

    Public Sub Limpiar()
        Btn_Guardar.Visible = True
        Btn_Editar.Visible = False
        Txt_Nombre.Text = ""
        Txt_Apellido.Text = ""
        Txt_Direccion.Text = ""
        Txt_Telefono.Text = ""
        Txt_Dni.Text = ""
        txt_IDUsuario.Text = ""
        txt_Login.Text = ""
        txt_Contraseña.Text = ""
        txt_Acceso.Text = 0
    End Sub
    Private Sub Habilitar()
        Txt_Nombre.Enabled = True
        Txt_Apellido.Enabled = True
        Txt_Direccion.Enabled = True
        Txt_Telefono.Enabled = True
        Txt_Dni.Enabled = True
        txt_Login.Enabled = True
        txt_Contraseña.Enabled = True
        txt_Acceso.Enabled = True
        lbl_Informacion.Text = "Este campo es autonumerico."
    End Sub
    Private Sub Desabilitar()
        txt_IDUsuario.Enabled = False
        Txt_Nombre.Enabled = False
        Txt_Apellido.Enabled = False
        Txt_Direccion.Enabled = False
        Txt_Telefono.Enabled = False
        Txt_Dni.Enabled = False
        txt_Login.Enabled = False
        txt_Contraseña.Enabled = False
        txt_Acceso.Enabled = False
        Btn_Guardar.Enabled = False
        Btn_Eliminar.Enabled = False
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Limpiar()
        Mostrar()
        Habilitar()
        Btn_Guardar.Enabled = True

    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If Me.ValidateChildren = True And Txt_Nombre.Text <> "" And Txt_Apellido.Text <> "" And Txt_Direccion.Text <> "" And Txt_Telefono.Text <> "" And Txt_Dni.Text <> "" Then
            Try
                Dim dts As New Cls_Usuario
                dts.Nombre = Txt_Nombre.Text
                dts.Apellido = Txt_Apellido.Text
                dts.Dni = Txt_Dni.Text
                dts.Direccion = Txt_Direccion.Text
                dts.Telefono = Txt_Telefono.Text
                dts.Login = txt_Login.Text
                dts.Password = txt_Contraseña.Text
                dts.Acceso = txt_Acceso.Text

                If dts.Insertar(dts) Then
                    MessageBox.Show("El usuario fue registrado satisfactoriamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                    Desabilitar()
                Else
                    MessageBox.Show("El usuario no fue registrado, intente de nuevo.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Mostrar()
                    Limpiar()
                    Desabilitar()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)

            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos del usuario.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        btn_Seleccionar.Visible = True

    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea editar los datos del usuario?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And Txt_Nombre.Text <> "" And Txt_Apellido.Text <> "" And Txt_Direccion.Text <> "" And Txt_Telefono.Text <> "" And Txt_Dni.Text <> "" And txt_IDUsuario.Text <> "" Then
                Try
                    Dim dts As New Cls_Usuario
                    dts.IDUsuario = txt_IDUsuario.Text
                    dts.Nombre = Txt_Nombre.Text
                    dts.Apellido = Txt_Apellido.Text
                    dts.Dni = Txt_Dni.Text
                    dts.Direccion = Txt_Direccion.Text
                    dts.Telefono = Txt_Telefono.Text
                    dts.Login = txt_Login.Text
                    dts.Password = txt_Contraseña.Text
                    dts.Acceso = txt_Acceso.Text


                    If dts.Editar(dts) Then
                        MessageBox.Show("Usuario modificado satisfactoriamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    Else
                        MessageBox.Show("El usuario no fue registrado, intente de nuevo.", "Modificandoregistros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos del usuario.", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub
    Private Sub Actualizar_cb()
        cb_Eliminar.CheckState = CheckState.Unchecked
        Btn_Eliminar.Enabled = False
    End Sub
    Private Sub cb_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Eliminar.CheckedChanged
        If cb_Eliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
            Btn_Eliminar.Enabled = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
            Btn_Eliminar.Enabled = False
        End If
    End Sub
    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub
    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente quiere eliminar los usuarios seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDUsuario").Value)
                        Dim vdb As New Cls_Usuario
                        vdb.IDUsuario = onekey

                        If vdb.Eliminar(vdb) Then
                            result = MessageBox.Show("El usuario fue eliminado correctamente.", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Actualizar_cb()
                            Desabilitar()
                        Else
                            result = MessageBox.Show("El usuario no pudo ser eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Desabilitar()
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            result = MessageBox.Show("Cancelando la eliminacion de registro", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mostrar()
        End If
        Limpiar()
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("En este campo solo se puede colocar 1 si tiene acceso al sistema o 0 si no lo tiene.", "Generando acceso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub txt_Acceso_TextChanged(sender As Object, e As EventArgs) Handles txt_Acceso.TextChanged
        If txt_Acceso.Text <> 0 And txt_Acceso.Text <> 1 Then
            Try
                Dim res As DialogResult
                res = MessageBox.Show("Caracter incorrecto, para mas informacion pulse en el boton de info.", "Generando acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If res = DialogResult.OK Then
                    txt_Acceso.Text = 0
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar.Click
        txt_IDUsuario.Text = DataListado.SelectedCells.Item(1).Value
        Txt_Nombre.Text = DataListado.SelectedCells.Item(2).Value
        Txt_Apellido.Text = DataListado.SelectedCells.Item(3).Value
        Txt_Dni.Text = DataListado.SelectedCells.Item(4).Value
        Txt_Direccion.Text = DataListado.SelectedCells.Item(5).Value
        Txt_Telefono.Text = DataListado.SelectedCells.Item(6).Value
        txt_Login.Text = DataListado.SelectedCells.Item(7).Value
        txt_Contraseña.Text = DataListado.SelectedCells.Item(8).Value
        txt_Acceso.Text = DataListado.SelectedCells.Item(9).Value
        Habilitar()
        Btn_Editar.Visible = True
        Btn_Guardar.Visible = False
    End Sub
End Class