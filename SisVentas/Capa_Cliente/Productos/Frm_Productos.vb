Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio
Public Class Frm_Productos
    Private dt As New DataTable ' Para guardar los datos de la tabla en memoria

    Private Sub Frm_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        Btn_Nuevo.Focus()
        txt_IDProducto.Enabled = False
        Btn_Editar.Enabled = False
        Btn_Guardar.Enabled = False
        btn_Buscar_Categoria.Enabled = False
        Btn_Eliminar.Enabled = False
        Txt_Producto.Enabled = False
        txt_Nombre_Categoria.Enabled = False
        Txt_IDCategoria.Enabled = False
        txt_Descipcion.Enabled = False
        Txt_Stock.Enabled = False
        Txt_Precio_compra.Enabled = False
        txt_Precio_Venta.Enabled = False
        txt_IDProducto.Enabled = False
        lbl_informacion.Text = ""
        btn_Seleccionar.Visible = False

    End Sub
    Private Sub Mostrar()
        Try
            Dim func As New Cls_Productos
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
        Txt_Producto.Text = ""
        Txt_IDCategoria.Text = ""
        txt_Nombre_Categoria.Text = ""
        txt_Descipcion.Text = ""
        Txt_Stock.Text = ""
        Txt_Precio_compra.Text = ""
        txt_Precio_Venta.Text = ""
        txt_IDProducto.Text = ""
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.trans
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Limpiar()
        Mostrar()
        Habilitar()

    End Sub
    Private Sub Habilitar()
        Btn_Guardar.Enabled = True
        Txt_Producto.Enabled = True
        Txt_IDCategoria.Enabled = True
        txt_Nombre_Categoria.Enabled = True
        txt_Descipcion.Enabled = True
        Txt_Stock.Enabled = True
        Txt_Precio_compra.Enabled = True
        txt_Precio_Venta.Enabled = True
        btn_Buscar_Categoria.Enabled = True
        Btn_Nuevo.Enabled = False
        lbl_informacion.Text = "Este campo es autonumérico."
    End Sub
    Private Sub Desabilitar()
        txt_IDProducto.Enabled = False
        Btn_Nuevo.Enabled = True
        Btn_Editar.Enabled = False
        Btn_Guardar.Enabled = False
        Btn_Eliminar.Enabled = False
        Txt_Producto.Enabled = False
        txt_Nombre_Categoria.Enabled = False
        Txt_IDCategoria.Enabled = False
        txt_Descipcion.Enabled = False
        Txt_Stock.Enabled = False
        Txt_Precio_compra.Enabled = False
        txt_Precio_Venta.Enabled = False
        txt_IDProducto.Enabled = False
        btn_Buscar_Categoria.Enabled = False
        btn_Seleccionar.Visible = False
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim P As New Cls_Productos
        If Me.ValidateChildren = True And Txt_Producto.Text <> "" And Txt_IDCategoria.Text <> "" And txt_Nombre_Categoria.Text <> "" And txt_Descipcion.Text <> "" And Txt_Stock.Text <> "" And Txt_Precio_compra.Text <> "" And txt_Precio_Venta.Text <> "" And txt_Fecha_Vencimiento.Text <> "" Then
            If P.ValidarNombre(Txt_Producto.Text) = False Then
                Try
                    Dim dts As New Cls_Productos
                    dts.Nombre = Txt_Producto.Text
                    dts.IDCategoria = Txt_IDCategoria.Text
                    dts.Descripcion = txt_Descipcion.Text
                    dts.Stock = Txt_Stock.Text
                    dts.Precio_Compra = Txt_Precio_compra.Text
                    dts.Precio_Venta = txt_Precio_Venta.Text
                    dts.Fecha_Vencimiento = txt_Fecha_Vencimiento.Text

                    Dim ms As New IO.MemoryStream() 'Crea una secuencia cuyo almacen de respaldo es la memoria

                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat) 'Obtiene la imagen guardada en el picturebox y la guarda en la variable ms
                    Else
                        imagen.Image = My.Resources.trans  'Guardo la imagen transparente que tengo en la carpeta resource llama "trans"
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    End If
                    dts.GImagen = ms.GetBuffer


                    If dts.Insertar(dts) Then
                        MessageBox.Show("Producto registrado satisfactoriamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("El nombre del producto ya existe en la base de datos, intente de nuevo.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Mostrar()
                Txt_Producto.Focus()

            End If


        Else
                MessageBox.Show("Faltan ingresar algunos datos del producto.", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        btn_Seleccionar.Visible = True

    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea editar los datos del producto?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And Txt_Producto.Text <> "" And Txt_IDCategoria.Text <> "" And txt_Descipcion.Text <> "" And Txt_Stock.Text <> "" And Txt_Precio_compra.Text <> "" And txt_IDProducto.Text <> "" Then
                Try
                    Dim dts As New Cls_Productos
                    dts.IDProducto = txt_IDProducto.Text
                    dts.Nombre = Txt_Producto.Text
                    dts.IDCategoria = Txt_IDCategoria.Text
                    dts.Descripcion = txt_Descipcion.Text
                    dts.Stock = Txt_Stock.Text
                    dts.Precio_Compra = Txt_Precio_compra.Text
                    dts.Precio_Venta = txt_Precio_Venta.Text
                    dts.Fecha_Vencimiento = txt_Fecha_Vencimiento.Text

                    Dim ms As New IO.MemoryStream() 'Crea una secuencia cuyo almacen de respaldo es la memoria

                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat) 'Obtiene la imagen guardada en el picturebox y la guarda en la variable ms
                    Else
                        imagen.Image = My.Resources.trans  'Guardo la imagen transparente que tengo en la carpeta resource llama "trans"
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    End If
                    dts.GImagen = ms.GetBuffer

                    If dts.Editar(dts) Then
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    Else
                        MessageBox.Show("El producto no fue registrado, intente de nuevo.", "Modificandoregistros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar()
                        Limpiar()
                        Desabilitar()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)

                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos del producto.", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub cb_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Eliminar.CheckedChanged
        If cb_Eliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
            Btn_Eliminar.Enabled = True
            'Desabilitar()
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
            Btn_Eliminar.Enabled = False
            'Desabilitar()
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
        result = MessageBox.Show("¿Realmente quiere eliminar los productos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDProducto").Value)
                        Dim vdb As New Cls_Productos
                        vdb.IDProducto = onekey

                        If vdb.Eliminar(vdb) Then
                        Else
                            result = MessageBox.Show("El producto no pudo ser eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Desabilitar()
                        End If
                    End If
                Next
                Call Mostrar()
                cb_Eliminar.CheckState = CheckState.Unchecked
                Btn_Eliminar.Enabled = False
                Desabilitar()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            Mostrar()
            Desabilitar()
        End If
        Limpiar()
    End Sub

    Private Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.trans
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

#Region "Validating"

    Private Sub Txt_Nombre_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Producto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El nombre del producto es obligatorio")
        End If
    End Sub

    Private Sub txt_Nombre_Categoria_Validating(sender As Object, e As CancelEventArgs) Handles txt_Nombre_Categoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El nombre de la categoria es obligatoria")
        End If
    End Sub

    Private Sub Txt_IDCategoria_Validating(sender As Object, e As CancelEventArgs) Handles Txt_IDCategoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El ID de la cateogira es obligatorio")
        End If
    End Sub
    Private Sub txt_Descipcion_Validating(sender As Object, e As CancelEventArgs) Handles txt_Descipcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "La descripcion del producto es obligatoria")
        End If
    End Sub
    Private Sub Txt_Stock_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Stock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El stock del producto obligatorio")
        End If
    End Sub
    Private Sub Txt_Precio_compra_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Precio_compra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El precio de compra del producto es obligatorio")
        End If
    End Sub
    Private Sub txt_Precio_Venta_Validating(sender As Object, e As CancelEventArgs) Handles txt_Precio_Venta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "El precio de venta del producto es obligatorio")
        End If
    End Sub

    Private Sub btn_Buscar_Categoria_Click(sender As Object, e As EventArgs) Handles btn_Buscar_Categoria.Click
        Frm_Categoria.txt_Flag.Text = "1"
        Frm_Categoria.ShowDialog()
    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        If txt_flag.Text = "1" Then
            Frm_DetalleVenta.Txt_IDProducto.Text = DataListado.SelectedCells.Item(1).Value
            Frm_DetalleVenta.Txt_NombreProducto.Text = DataListado.SelectedCells.Item(4).Value
            Frm_DetalleVenta.Txt_Stock.Text = DataListado.SelectedCells.Item(6).Value
            Frm_DetalleVenta.Txt_PrecioUnitario.Text = DataListado.SelectedCells.Item(8).Value
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub

    Private Sub btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar.Click
        txt_IDProducto.Text = DataListado.SelectedCells.Item(1).Value
        Txt_IDCategoria.Text = DataListado.SelectedCells.Item(2).Value
        txt_Nombre_Categoria.Text = DataListado.SelectedCells.Item(3).Value
        Txt_Producto.Text = DataListado.SelectedCells.Item(4).Value
        txt_Descipcion.Text = DataListado.SelectedCells.Item(5).Value
        Txt_Stock.Text = DataListado.SelectedCells.Item(6).Value
        Txt_Precio_compra.Text = DataListado.SelectedCells.Item(7).Value
        txt_Precio_Venta.Text = DataListado.SelectedCells.Item(8).Value
        txt_Fecha_Vencimiento.Text = DataListado.SelectedCells.Item(9).Value
        Btn_Editar.Enabled = True
        Btn_Nuevo.Enabled = True
        Txt_Producto.Enabled = True
        Txt_IDCategoria.Enabled = True
        txt_Nombre_Categoria.Enabled = True
        txt_Descipcion.Enabled = True
        Txt_Stock.Enabled = True
        Txt_Precio_compra.Enabled = True
        txt_Precio_Venta.Enabled = True
        btn_Buscar_Categoria.Enabled = True
        lbl_informacion.Text = "Este campo es autonumerico."

        imagen.BackgroundImage = Nothing
        Dim b() As Byte = DataListado.SelectedCells.Item(10).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        Btn_Editar.Visible = True
        Btn_Guardar.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("No existen datos con los criterios de busqueda ingresados.", "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub







#End Region



End Class