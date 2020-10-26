<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_DetalleVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cb_TipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Txt_NombreCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDVenta = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_BorrarArticulos = New System.Windows.Forms.Button()
        Me.cb_Eliminar = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Txt_Stock = New System.Windows.Forms.NumericUpDown()
        Me.Txt_Cantidad = New System.Windows.Forms.NumericUpDown()
        Me.Txt_PrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_BuscarProducto = New System.Windows.Forms.Button()
        Me.Txt_NombreProducto = New System.Windows.Forms.TextBox()
        Me.Txt_IDProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_NumeroDocumento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_IDCliente = New System.Windows.Forms.TextBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Txt_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_TipoDocumento
        '
        Me.cb_TipoDocumento.Enabled = False
        Me.cb_TipoDocumento.FormattingEnabled = True
        Me.cb_TipoDocumento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cb_TipoDocumento.Location = New System.Drawing.Point(130, 138)
        Me.cb_TipoDocumento.Name = "cb_TipoDocumento"
        Me.cb_TipoDocumento.Size = New System.Drawing.Size(213, 21)
        Me.cb_TipoDocumento.TabIndex = 20
        Me.cb_TipoDocumento.Text = "Factura"
        '
        'Txt_Fecha
        '
        Me.Txt_Fecha.Enabled = False
        Me.Txt_Fecha.Location = New System.Drawing.Point(130, 104)
        Me.Txt_Fecha.Name = "Txt_Fecha"
        Me.Txt_Fecha.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Fecha.TabIndex = 19
        '
        'Txt_NombreCliente
        '
        Me.Txt_NombreCliente.Enabled = False
        Me.Txt_NombreCliente.Location = New System.Drawing.Point(184, 62)
        Me.Txt_NombreCliente.Name = "Txt_NombreCliente"
        Me.Txt_NombreCliente.Size = New System.Drawing.Size(127, 20)
        Me.Txt_NombreCliente.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id Venta: "
        '
        'txt_IDVenta
        '
        Me.txt_IDVenta.Enabled = False
        Me.txt_IDVenta.Location = New System.Drawing.Point(130, 29)
        Me.txt_IDVenta.Name = "txt_IDVenta"
        Me.txt_IDVenta.Size = New System.Drawing.Size(217, 20)
        Me.txt_IDVenta.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(145, 377)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(99, 23)
        Me.Btn_Guardar.TabIndex = 11
        Me.Btn_Guardar.Text = "Agregar artículos"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(250, 377)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(86, 23)
        Me.Btn_Cancelar.TabIndex = 12
        Me.Btn_Cancelar.Text = "Terminar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Location = New System.Drawing.Point(64, 377)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nuevo.TabIndex = 1
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_BorrarArticulos)
        Me.GroupBox2.Controls.Add(Me.cb_Eliminar)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.DataListado)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 370)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de items de artículos de la venta"
        '
        'Btn_BorrarArticulos
        '
        Me.Btn_BorrarArticulos.Location = New System.Drawing.Point(123, 22)
        Me.Btn_BorrarArticulos.Name = "Btn_BorrarArticulos"
        Me.Btn_BorrarArticulos.Size = New System.Drawing.Size(123, 23)
        Me.Btn_BorrarArticulos.TabIndex = 31
        Me.Btn_BorrarArticulos.Text = "Quitar Artículo"
        Me.Btn_BorrarArticulos.UseVisualStyleBackColor = True
        '
        'cb_Eliminar
        '
        Me.cb_Eliminar.AutoSize = True
        Me.cb_Eliminar.Location = New System.Drawing.Point(15, 26)
        Me.cb_Eliminar.Name = "cb_Eliminar"
        Me.cb_Eliminar.Size = New System.Drawing.Size(65, 17)
        Me.cb_Eliminar.TabIndex = 9
        Me.cb_Eliminar.Text = "Eliminar "
        Me.cb_Eliminar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(252, 155)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Datos inexistentes"
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataListado.Location = New System.Drawing.Point(12, 55)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(526, 272)
        Me.DataListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Imprimir)
        Me.GroupBox1.Controls.Add(Me.Txt_Stock)
        Me.GroupBox1.Controls.Add(Me.Txt_Cantidad)
        Me.GroupBox1.Controls.Add(Me.Txt_PrecioUnitario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Btn_BuscarProducto)
        Me.GroupBox1.Controls.Add(Me.Txt_NombreProducto)
        Me.GroupBox1.Controls.Add(Me.Txt_IDProducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cb_TipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Txt_Fecha)
        Me.GroupBox1.Controls.Add(Me.Txt_NombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_IDVenta)
        Me.GroupBox1.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.Btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_NumeroDocumento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_IDCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 406)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.BackgroundImage = Global.Capa_Cliente.My.Resources.Resources.Print_icon_icons1
        Me.Btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Imprimir.Location = New System.Drawing.Point(250, 293)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(86, 59)
        Me.Btn_Imprimir.TabIndex = 32
        Me.Btn_Imprimir.Text = "Comprobante"
        Me.Btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Txt_Stock
        '
        Me.Txt_Stock.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Stock.Location = New System.Drawing.Point(251, 247)
        Me.Txt_Stock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Txt_Stock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Txt_Stock.Name = "Txt_Stock"
        Me.Txt_Stock.Size = New System.Drawing.Size(52, 20)
        Me.Txt_Stock.TabIndex = 30
        Me.Txt_Stock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Txt_Cantidad
        '
        Me.Txt_Cantidad.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Cantidad.Location = New System.Drawing.Point(133, 247)
        Me.Txt_Cantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Txt_Cantidad.Name = "Txt_Cantidad"
        Me.Txt_Cantidad.Size = New System.Drawing.Size(52, 20)
        Me.Txt_Cantidad.TabIndex = 29
        '
        'Txt_PrecioUnitario
        '
        Me.Txt_PrecioUnitario.Location = New System.Drawing.Point(129, 276)
        Me.Txt_PrecioUnitario.Name = "Txt_PrecioUnitario"
        Me.Txt_PrecioUnitario.Size = New System.Drawing.Size(92, 20)
        Me.Txt_PrecioUnitario.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Precio unitario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Stock:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Cantidad:"
        '
        'Btn_BuscarProducto
        '
        Me.Btn_BuscarProducto.Location = New System.Drawing.Point(318, 212)
        Me.Btn_BuscarProducto.Name = "Btn_BuscarProducto"
        Me.Btn_BuscarProducto.Size = New System.Drawing.Size(30, 23)
        Me.Btn_BuscarProducto.TabIndex = 24
        Me.Btn_BuscarProducto.Text = "..."
        Me.Btn_BuscarProducto.UseVisualStyleBackColor = True
        '
        'Txt_NombreProducto
        '
        Me.Txt_NombreProducto.Location = New System.Drawing.Point(185, 215)
        Me.Txt_NombreProducto.Name = "Txt_NombreProducto"
        Me.Txt_NombreProducto.Size = New System.Drawing.Size(127, 20)
        Me.Txt_NombreProducto.TabIndex = 23
        '
        'Txt_IDProducto
        '
        Me.Txt_IDProducto.Location = New System.Drawing.Point(131, 215)
        Me.Txt_IDProducto.Name = "Txt_IDProducto"
        Me.Txt_IDProducto.Size = New System.Drawing.Size(48, 20)
        Me.Txt_IDProducto.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Id Producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Número de documento:"
        '
        'Txt_NumeroDocumento
        '
        Me.Txt_NumeroDocumento.Enabled = False
        Me.Txt_NumeroDocumento.Location = New System.Drawing.Point(130, 179)
        Me.Txt_NumeroDocumento.MaxLength = 12
        Me.Txt_NumeroDocumento.Name = "Txt_NumeroDocumento"
        Me.Txt_NumeroDocumento.Size = New System.Drawing.Size(217, 20)
        Me.Txt_NumeroDocumento.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo de documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Cliente:"
        '
        'Txt_IDCliente
        '
        Me.Txt_IDCliente.Enabled = False
        Me.Txt_IDCliente.Location = New System.Drawing.Point(130, 62)
        Me.Txt_IDCliente.Name = "Txt_IDCliente"
        Me.Txt_IDCliente.Size = New System.Drawing.Size(48, 20)
        Me.Txt_IDCliente.TabIndex = 2
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(837, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(948, 427)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_DetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de detalle de venta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Txt_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cb_TipoDocumento As ComboBox
    Friend WithEvents Txt_Fecha As DateTimePicker
    Friend WithEvents Txt_NombreCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IDVenta As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_Eliminar As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_NumeroDocumento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_IDCliente As TextBox
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents Txt_Stock As NumericUpDown
    Friend WithEvents Txt_Cantidad As NumericUpDown
    Friend WithEvents Txt_PrecioUnitario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_BuscarProducto As Button
    Friend WithEvents Txt_NombreProducto As TextBox
    Friend WithEvents Txt_IDProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_BorrarArticulos As Button
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Button1 As Button
End Class
