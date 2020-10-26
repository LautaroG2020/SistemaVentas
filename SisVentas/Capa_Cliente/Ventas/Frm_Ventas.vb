Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio
Imports System.Data.SqlClient

Public Class Frm_Ventas
    Private dt As New DataTable ' Para guardar los datos de la tabla en memoria
    Private Sub Frm_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        txt_IDVenta.Enabled = False
        Txt_IDCliente.Enabled = False
        Txt_NombreCliente.Enabled = False
        Txt_Fecha.Enabled = False
        cb_TipoDocumento.Enabled = False
        Txt_NumeroDocumento.Enabled = False
        Btn_Guardar.Enabled = False
        Btn_BuscarCliente.Enabled = False
        btn_Seleccionar.Visible = False
        Btn_Nuevo.Focus()


    End Sub


    Private Sub Mostrar()
        Try
            Dim func As New Cls_Venta
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
        DataListado.Columns(2).Visible = False
    End Sub

    Public Sub Limpiar()
        Btn_Guardar.Visible = True
        Btn_Editar.Visible = False
        Txt_IDCliente.Text = ""
        Txt_Fecha.Text = ""
        cb_TipoDocumento.Text = ""
        Txt_NumeroDocumento.Text = ""
        Txt_NombreCliente.Text = ""
        txt_IDVenta.Text = ""
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Limpiar()
        Mostrar()
        lbl_Informacion.Text = "Este campo es autonumérico."
        Habilitar()
        Btn_Guardar.Enabled = True
        Btn_BuscarCliente.Enabled = True

    End Sub

    Private Sub Habilitar()
        Txt_IDCliente.Enabled = True
        Txt_NombreCliente.Enabled = True
        Txt_Fecha.Enabled = True
        cb_TipoDocumento.Enabled = True
        Txt_NumeroDocumento.Enabled = True
        lbl_Informacion.Text = "Este campo es autonumérico."
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If Me.ValidateChildren = True And Txt_IDCliente.Text <> "" And Txt_NombreCliente.Text <> "" And Txt_NumeroDocumento.Text <> "" And Txt_NumeroDocumento.Text <> "" Then
            Dim V As New Cls_Venta
            If V.ValidarNombre(Txt_NumeroDocumento.Text) = False Then
                Try
                    Dim dts As New Cls_Venta
                    dts.IDCliente = Txt_IDCliente.Text
                    dts.Fecha = Txt_Fecha.Text
                    dts.Tipo_Documento = cb_TipoDocumento.Text
                    dts.Num_Documento = Txt_NumeroDocumento.Text

                    If dts.Insertar(dts) Then
                        MessageBox.Show("Venta registrada satisfactoriamente, ahora vamos a cargar el detalle de la venta", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                        Cargar_detalle()
                        txt_IDVenta.Enabled = False
                        Txt_IDCliente.Enabled = False
                        Txt_NombreCliente.Enabled = False
                        Txt_Fecha.Enabled = False
                        cb_TipoDocumento.Enabled = False
                        Txt_NumeroDocumento.Enabled = False
                        Btn_Guardar.Enabled = False
                        Btn_BuscarCliente.Enabled = False
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("El numero de documento de la venta ya existe, intente nuevamente.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Mostrar()
                Txt_NumeroDocumento.Focus()
            End If
        Else
            MessageBox.Show("Faltan ingresar algunos datos del cliente.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        btn_Seleccionar.Visible = True

    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea editar los datos de la venta?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And Txt_IDCliente.Text <> "" And Txt_NumeroDocumento.Text <> "" And txt_IDVenta.Text <> "" Then
                Try
                    Dim dts As New Cls_Venta
                    dts.IDVenta = txt_IDVenta.Text
                    dts.IDCliente = Txt_IDCliente.Text
                    dts.Fecha = Txt_Fecha.Text
                    dts.Tipo_Documento = cb_TipoDocumento.Text
                    dts.Num_Documento = Txt_NumeroDocumento.Text

                    If dts.Editar(dts) Then
                        Mostrar()
                        Limpiar()
                    Else
                        MessageBox.Show("La venta no fue registrada, intente de nuevo.", "Modificandoregistros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar()
                        Limpiar()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos de la venta.", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub

    Private Sub Cargar_detalle()
        Frm_DetalleVenta.txt_IDVenta.Text = DataListado.SelectedCells.Item(1).Value
        Frm_DetalleVenta.Txt_IDCliente.Text = DataListado.SelectedCells.Item(2).Value
        Frm_DetalleVenta.Txt_NombreCliente.Text = DataListado.SelectedCells.Item(3).Value
        Frm_DetalleVenta.Txt_Fecha.Text = DataListado.SelectedCells.Item(5).Value
        Frm_DetalleVenta.cb_TipoDocumento.Text = DataListado.SelectedCells.Item(6).Value
        Frm_DetalleVenta.Txt_NumeroDocumento.Text = DataListado.SelectedCells.Item(7).Value

        Frm_DetalleVenta.ShowDialog()
    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        Cargar_detalle()
    End Sub

    Private Sub Btn_BuscarCliente_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCliente.Click
        Frm_Cliente.Txt_flag.Text = "1"
        Frm_Cliente.ShowDialog()

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Si cierra esta ventana, no podra realizar la venta, ¿Esta seguro que desea salir?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDVenta").Value)
                        Dim vdb As New Cls_Venta
                        vdb.IDVenta = onekey

                        If vdb.Eliminar(vdb) Then
                            result = MessageBox.Show("El cliente fue eliminado correctamente.", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else
                            result = MessageBox.Show("El cliente no pudo ser eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar.Click
        txt_IDVenta.Text = DataListado.SelectedCells.Item(1).Value
        Txt_IDCliente.Text = DataListado.SelectedCells.Item(2).Value
        Txt_NombreCliente.Text = DataListado.SelectedCells.Item(3).Value
        Txt_Fecha.Text = DataListado.SelectedCells.Item(5).Value
        cb_TipoDocumento.Text = DataListado.SelectedCells.Item(6).Value
        Txt_NumeroDocumento.Text = DataListado.SelectedCells.Item(7).Value
        Habilitar()
        Btn_Editar.Visible = True
        Btn_Guardar.Visible = False
        Btn_Nuevo.Enabled = True
    End Sub

End Class