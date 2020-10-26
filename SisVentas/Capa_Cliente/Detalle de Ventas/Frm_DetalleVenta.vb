Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio


Public Class Frm_DetalleVenta
    Private dt As New DataTable ' Para guardar los datos de la tabla en memoria

    Public Property Lista_Detalle As List(Of Cls_Detalle_Venta)

    Private Sub Frm_DetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        Txt_IDProducto.Enabled = False
        Txt_NombreProducto.Enabled = False
        Txt_Cantidad.Enabled = False
        Txt_Stock.Enabled = False
        Txt_PrecioUnitario.Enabled = False
        Btn_BuscarProducto.Enabled = False
        Btn_Guardar.Enabled = False
    End Sub




    Private Sub Mostrar()
        Try
            Dim func As New Cls_Detalle_Venta
            dt = func.Mostrar()
            DataListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                DataListado.ColumnHeadersVisible = True
                LinkLabel1.Visible = False
            Else
                DataListado.DataSource = Nothing
                DataListado.ColumnHeadersVisible = False
                LinkLabel1.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Btn_Nuevo.Visible = True

        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim ds As New DataSet       'Se encarga de copiar todos los registros que tiene el datatable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            'Se filtran los datos elegidos por el combobox
            dv.RowFilter = "IDVenta = '" & txt_IDVenta.Text & "'"

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
        DataListado.Columns(3).Visible = False
    End Sub

    Public Sub Limpiar()
        Btn_Guardar.Visible = True
        Txt_IDProducto.Text = ""
        Txt_NombreProducto.Text = ""
        Txt_PrecioUnitario.Text = ""
        Txt_Cantidad.Text = 0
        Txt_Stock.Text = 1

    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Limpiar()
        Mostrar()
        Habilitar()
        Btn_Guardar.Enabled = True

    End Sub
    Private Sub Habilitar()
        Txt_IDProducto.Enabled = True
        Txt_NombreProducto.Enabled = True
        Txt_Cantidad.Enabled = True
        Txt_Stock.Enabled = True
        Txt_PrecioUnitario.Enabled = True
        Btn_BuscarProducto.Enabled = True
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If Me.ValidateChildren = True And Txt_IDProducto.Text <> "" And Txt_Cantidad.Text <> "" And Txt_PrecioUnitario.Text <> "" Then
            If Txt_Cantidad.Value > 0 Then
                Try
                    Dim dts As New Cls_Detalle_Venta
                    dts.IDVenta = txt_IDVenta.Text
                    dts.IDProducto = Txt_IDProducto.Text
                    dts.Cantidad = Txt_Cantidad.Text
                    dts.Precio_Unitario = Txt_PrecioUnitario.Text



                    If dts.Insertar(dts) Then
                        If dts.Disminuir_Stock(dts) Then

                        End If
                        MessageBox.Show("Productos registrados satisfactoriamente.", "Guardando Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                        Txt_IDProducto.Enabled = False
                        Txt_NombreProducto.Enabled = False
                        Txt_Cantidad.Enabled = False
                        Txt_Stock.Enabled = False
                        Txt_PrecioUnitario.Enabled = False
                        Btn_BuscarProducto.Enabled = False
                        Btn_Guardar.Enabled = False
                    Else
                        MessageBox.Show("Los productos no fueron agregados correctamente, intente de nuevo.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar()
                        Limpiar()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("Debe ingresar la cantidad del producto seleccionado para agregar a la venta.", "Error al ingresar items de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Faltan ingresar algunos datos de la venta.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub




    Private Sub cb_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Eliminar.CheckedChanged
        If cb_Eliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs)
        Buscar()
    End Sub
    Private Sub Actualizar_cb()
        cb_Eliminar.CheckState = CheckState.Unchecked
        Btn_BorrarArticulos.Enabled = False

    End Sub

    Private Sub Btn_BorrarArticulos_Click(sender As Object, e As EventArgs) Handles Btn_BorrarArticulos.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente quiere eliminar los articulos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDDetalle_venta").Value)
                        Dim vdb As New Cls_Detalle_Venta
                        vdb.IDDetalle_venta = onekey

                        vdb.IDProducto = DataListado.SelectedCells.Item(3).Value
                        vdb.IDVenta = DataListado.SelectedCells.Item(2).Value
                        vdb.Cantidad = DataListado.SelectedCells.Item(5).Value

                        If vdb.Eliminar(vdb) Then
                            If vdb.Aumentar_Stock(vdb) Then
                                Actualizar_cb()
                            End If
                        Else
                            result = MessageBox.Show("El articulo no pudo ser eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub Btn_BuscarProducto_Click(sender As Object, e As EventArgs) Handles Btn_BuscarProducto.Click
        Frm_Productos.txt_flag.Text = "1"
        Frm_Productos.ShowDialog()
    End Sub

    Private Sub Txt_Cantidad_ValueChanged(sender As Object, e As EventArgs) Handles Txt_Cantidad.ValueChanged
        Dim cantidad As Double
        cantidad = Txt_Cantidad.Value
        If Txt_Cantidad.Value > Txt_Stock.Value Then
            MessageBox.Show("La cantidad que intenta vender supera el stock disponible", "Error de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_Guardar.Visible = 0
            Txt_Cantidad.Value = Txt_Stock.Value
        Else
            Btn_Guardar.Visible = 1
        End If
        If Txt_Cantidad.Value = 0 Then
            Btn_Guardar.Visible = 0
        Else
            Btn_Guardar.Visible = 1
        End If
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Frm_Reporte_Comprobante.Txt_IDVenta.Text = Me.txt_IDVenta.Text
        Frm_Reporte_Comprobante.ShowDialog()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        If DataListado.Rows.Count = 0 Then
            Dim res As New DialogResult
            res = MessageBox.Show("No ha añadido ningun producto a la venta, añada uno para poder finalizar con la venta.", "Finalizando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If res = DialogResult.OK Then
                Me.Show()
            End If
        End If
        If DataListado.Rows.Count > 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataListado.Rows.Count = 0 Then
            Dim res As New DialogResult
            res = MessageBox.Show("Antes de salir debe terminar con la venta.", "Finalizando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If res = DialogResult.OK Then
                Me.Show()
            End If
        End If
        If DataListado.Rows.Count > 0 Then
            Me.Close()
        End If
    End Sub
End Class