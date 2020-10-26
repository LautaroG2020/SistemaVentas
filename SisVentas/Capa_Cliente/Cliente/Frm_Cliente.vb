Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio
Public Class Frm_Cliente
    Private dt As New DataTable ' Para guardar los datos de la tabla en memoria

    Private Sub Frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        txt_IDCliente.Enabled = False
        Txt_Nombre.Enabled = False
        Txt_Apellido.Enabled = False
        Txt_Direccion.Enabled = False
        Txt_Telefono.Enabled = False
        Txt_Dni.Enabled = False
        Btn_Guardar.Enabled = False
        Btn_Eliminar.Enabled = False
        btn_Seleccionar.Visible = False
    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New Cls_Cliente
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
        txt_IDCliente.Text = ""
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        limpiar()
        Mostrar()
        Habilitar()
        Btn_Guardar.Enabled = True

    End Sub
    Private Sub Habilitar()
        Txt_Nombre.Enabled = True
        Txt_Apellido.Enabled = True
        Txt_Direccion.Enabled = True
        Txt_Telefono.Enabled = True
        Txt_Dni.Enabled = True
        lbl_Informacion.Text = "Este campo es autonumérico."
    End Sub
    Private Sub Desabilitar()
        txt_IDCliente.Enabled = False
        Txt_Nombre.Enabled = False
        Txt_Apellido.Enabled = False
        Txt_Direccion.Enabled = False
        Txt_Telefono.Enabled = False
        Txt_Dni.Enabled = False
        Btn_Guardar.Enabled = False
        Btn_Eliminar.Enabled = False
        btn_Seleccionar.Visible = False
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If Me.ValidateChildren = True And Txt_Nombre.Text <> "" And Txt_Apellido.Text <> "" And Txt_Direccion.Text <> "" And Txt_Telefono.Text <> "" And Txt_Dni.Text <> "" Then
            Dim C As New Cls_Cliente
            If C.ValidarNombre(Txt_Nombre.Text, Txt_Apellido.Text) = False Then
                Try
                    Dim dts As New Cls_Cliente
                    dts.Nombre = Txt_Nombre.Text
                    dts.Apellido = Txt_Apellido.Text
                    dts.Direccion = Txt_Direccion.Text
                    dts.Telefono = Txt_Telefono.Text
                    dts.Dni = Txt_Dni.Text

                    If dts.Insertar(dts) Then
                        MessageBox.Show("Cliente registrado satisfactoriamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                        Desabilitar()

                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("El nombre del cliente ya existe, intente nuevamente.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Mostrar()
            End If


        Else
            MessageBox.Show("Faltan ingresar algunos datos del cliente.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Txt_IdCliente_Validating(sender As Object, e As EventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El nombre del cliente es obligatorio")
        End If

    End Sub

    Private Sub Txt_Nombre_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Nombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El nombre del cliente es obligatorio")
        End If
    End Sub

    Private Sub Txt_Direccion_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Direccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "La direccion del cliente es obligatorio")
        End If
    End Sub

    Private Sub Txt_Telefono_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Telefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El telefono del cliente es obligatorio")
        End If
    End Sub
    Private Sub Txt_Dni_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Dni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El dni del cliente es obligatorio")
        End If
    End Sub

    Private Sub Txt_Apellido_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Apellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El apellido del cliente es obligatorio")
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        btn_Seleccionar.Visible = True
    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea editar los datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And Txt_Nombre.Text <> "" And Txt_Apellido.Text <> "" And Txt_Direccion.Text <> "" And Txt_Telefono.Text <> "" And Txt_Dni.Text <> "" And txt_IDCliente.Text <> "" Then
                Try
                    Dim dts As New Cls_Cliente
                    dts.IDCliente = txt_IDCliente.Text
                    dts.Nombre = Txt_Nombre.Text
                    dts.Apellido = Txt_Apellido.Text
                    dts.Direccion = Txt_Direccion.Text
                    dts.Telefono = Txt_Telefono.Text
                    dts.Dni = Txt_Dni.Text

                    If dts.Editar(dts) Then
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    Else
                        MessageBox.Show("El cliente no fue registrado, intente de nuevo.", "Modificandoregistros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos del cliente.", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        result = MessageBox.Show("¿Realmente quiere eliminar el/los clientes seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDCliente").Value)
                        Dim vdb As New Cls_Cliente
                        vdb.IDCliente = onekey

                        If vdb.Eliminar(vdb) Then

                        Else
                            result = MessageBox.Show("El cliente no pudo ser eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Desabilitar()
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try

            Actualizar_cb()
            Desabilitar()
        Else
            result = MessageBox.Show("Cancelando la eliminacion de registro", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mostrar()
        End If
        Limpiar()
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        If Txt_flag.Text = "1" Then
            Frm_Ventas.Txt_IDCliente.Text = DataListado.SelectedCells.Item(1).Value
            Frm_Ventas.Txt_NombreCliente.Text = DataListado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("No existen datos con los criterios de busqueda ingresados.", "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar.Click
        txt_IDCliente.Text = DataListado.SelectedCells.Item(1).Value
        Txt_Nombre.Text = DataListado.SelectedCells.Item(2).Value
        Txt_Apellido.Text = DataListado.SelectedCells.Item(3).Value
        Txt_Direccion.Text = DataListado.SelectedCells.Item(4).Value
        Txt_Telefono.Text = DataListado.SelectedCells.Item(5).Value
        Txt_Dni.Text = DataListado.SelectedCells.Item(6).Value
        Habilitar()
        Btn_Editar.Visible = True
        Btn_Guardar.Visible = False

    End Sub
End Class