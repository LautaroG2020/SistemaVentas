Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio
Imports System.Data.SqlClient
Public Class Frm_Categoria
    Private dt As New DataTable ' Para guardar los datos de la tabla en memoria

    Private Sub Frm_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        txt_IDCategoria.Enabled = False
        Txt_Nombre.Enabled = False
        lbl_Informacion.Text = ""
        Btn_Eliminar.Enabled = False
        Btn_Guardar.Enabled = False
        Btn_Editar.Enabled = False
        btn_Seleccionar.Visible = False


    End Sub
    Private Sub Mostrar()
        Try
            Dim func As New Cls_Categoria
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
        Btn_Guardar.Visible = False

        Buscar()
    End Sub


    Private Sub Buscar()
        Try
            Dim cna = New SqlConnection("Server=192.168.56.1;Uid=sa;Pwd=sasa;Database=dbventas;")
            Dim daa = New SqlDataAdapter("Select * from categoria where Nombre_Categoria like '" + Txt_Buscar.Text + "%'", cna)
            Dim dta = New DataTable
            daa.Fill(dta)
            Me.DataListado.DataSource = dta

            If DataListado.RowCount <> 0 Then
                LinkLabel1.Visible = False
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
        Txt_Nombre.Text = ""
        txt_IDCategoria.Text = ""
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Limpiar()
        Mostrar()
        Habilitar()
        Txt_Nombre.Focus()
        Btn_Nuevo.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Guardar.Visible = True
        GroupBox2.Enabled = False
        Btn_Editar.Enabled = False

    End Sub
    Private Sub Habilitar()
        Txt_Nombre.Enabled = True
        lbl_Informacion.Text = "Este campo es autonumérico."
        Btn_Editar.Enabled = True
        Btn_Nuevo.Enabled = True
        Btn_Nuevo.Visible = True
        GroupBox2.Enabled = True
    End Sub
    Private Sub Desabilitar()
        Btn_Nuevo.Enabled = True
        Btn_Nuevo.Visible = True
        Btn_Guardar.Enabled = False
        Btn_Guardar.Visible = False
        Txt_Nombre.Enabled = False
        btn_Seleccionar.Visible = False
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim C As New Cls_Categoria
        If Me.ValidateChildren = True And Txt_Nombre.Text <> "" Then
            If C.ValidarNombre(Txt_Nombre.Text) = False Then
                Try
                    Dim dts As New Cls_Categoria
                    dts.Nombre_Categoria = Txt_Nombre.Text


                    If dts.Insertar(dts) Then
                        MessageBox.Show("Categoria registrada satisfactoriamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                        GroupBox2.Enabled = True

                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("El nombre de la categoria ya existe, intente de nuevo.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Mostrar()
                Limpiar()
                Habilitar()

            End If

        Else
                MessageBox.Show("Faltan ingresar algunos datos de la categoria.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
    End Sub

    Private Sub Txt_IDCategoria_Validating(sender As Object, e As EventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El nombre de la categoria es obligatorio")
        End If
    End Sub

    Private Sub Txt_Nombre_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Nombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El nombre de la categoria es obligatorio")
        End If
    End Sub



    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        btn_Seleccionar.Visible = True

    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea editar los datos de la categoria?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And Txt_Nombre.Text <> "" Then
                Try
                    Dim dts As New Cls_Categoria
                    dts.IDCategoria = txt_IDCategoria.Text
                    dts.Nombre_Categoria = Txt_Nombre.Text

                    If dts.Editar(dts) Then
                        Mostrar()
                        Limpiar()
                        Desabilitar()

                    Else
                        MessageBox.Show("La categoria no fue registrada, intente de nuevo.", "Modificandoregistros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos de la categoria.", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub cb_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Eliminar.CheckedChanged
        If cb_Eliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
            Btn_Eliminar.Enabled = True
            Desabilitar()
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
            Btn_Eliminar.Enabled = False
            Desabilitar()
        End If

    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub Actualizar_cb()
        cb_Eliminar.CheckState = CheckState.Unchecked
        Btn_Eliminar.Enabled = False
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente quiere eliminar las categorias seleccionadas?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDCategoria").Value)
                        Dim vdb As New Cls_Categoria
                        vdb.IDCategoria = onekey

                        If vdb.Eliminar(vdb) Then

                        Else
                            result = MessageBox.Show("La categoria no pudo ser eliminada", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            Mostrar()
        End If
        Limpiar()
        Actualizar_cb()
        Btn_Nuevo.Enabled = True
        Btn_Nuevo.Visible = True
        Btn_Guardar.Enabled = False
        Btn_Guardar.Visible = False
        Txt_Nombre.Enabled = False
    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        If txt_Flag.Text = "1" Then
            Frm_Productos.Txt_IDCategoria.Text = DataListado.SelectedCells.Item(1).Value
            Frm_Productos.txt_Nombre_Categoria.Text = DataListado.SelectedCells.Item(2).Value
            Me.Close()
        End If

    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar.Click
        txt_IDCategoria.Text = DataListado.SelectedCells.Item(1).Value
        Txt_Nombre.Text = DataListado.SelectedCells.Item(2).Value
        Btn_Editar.Visible = True
        Btn_Guardar.Visible = False
        Btn_Guardar.Enabled = False
        Btn_Nuevo.Enabled = True
        Btn_Nuevo.Visible = True
        Habilitar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("No existen datos con los criterios de busqueda ingresados.", "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class