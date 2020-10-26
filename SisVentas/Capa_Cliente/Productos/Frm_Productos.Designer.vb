<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Productos))
        Me.cb_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDProducto = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cbo_Campo = New System.Windows.Forms.ComboBox()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Txt_Precio_compra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Stock = New System.Windows.Forms.TextBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_Descipcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_IDCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Producto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.btn_Limpiar = New System.Windows.Forms.PictureBox()
        Me.btn_Cargar = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Fecha_Vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Precio_Venta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_Buscar_Categoria = New System.Windows.Forms.Button()
        Me.txt_Nombre_Categoria = New System.Windows.Forms.TextBox()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.txt_flag = New System.Windows.Forms.TextBox()
        Me.btn_Seleccionar = New System.Windows.Forms.Button()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_Limpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_Eliminar
        '
        Me.cb_Eliminar.AutoSize = True
        Me.cb_Eliminar.Location = New System.Drawing.Point(9, 60)
        Me.cb_Eliminar.Name = "cb_Eliminar"
        Me.cb_Eliminar.Size = New System.Drawing.Size(112, 17)
        Me.cb_Eliminar.TabIndex = 15
        Me.cb_Eliminar.Text = "Eliminar productos"
        Me.cb_Eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id Producto:"
        '
        'txt_IDProducto
        '
        Me.txt_IDProducto.Location = New System.Drawing.Point(126, 19)
        Me.txt_IDProducto.Name = "txt_IDProducto"
        Me.txt_IDProducto.Size = New System.Drawing.Size(214, 20)
        Me.txt_IDProducto.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(126, 486)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 12
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(207, 486)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 11
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Editar
        '
        Me.Btn_Editar.Location = New System.Drawing.Point(126, 486)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Editar.TabIndex = 12
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = True
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Location = New System.Drawing.Point(44, 486)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nuevo.TabIndex = 1
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio de compra: "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(246, 169)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Datos inexistentes"
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(155, 34)
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(248, 20)
        Me.Txt_Buscar.TabIndex = 15
        '
        'Cbo_Campo
        '
        Me.Cbo_Campo.FormattingEnabled = True
        Me.Cbo_Campo.Items.AddRange(New Object() {"Nombre", "Descripcion"})
        Me.Cbo_Campo.Location = New System.Drawing.Point(9, 33)
        Me.Cbo_Campo.Name = "Cbo_Campo"
        Me.Cbo_Campo.Size = New System.Drawing.Size(132, 21)
        Me.Cbo_Campo.TabIndex = 14
        Me.Cbo_Campo.Text = "Nombre"
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataListado.Location = New System.Drawing.Point(6, 82)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(526, 199)
        Me.DataListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Txt_Precio_compra
        '
        Me.Txt_Precio_compra.Location = New System.Drawing.Point(126, 236)
        Me.Txt_Precio_compra.MaxLength = 8
        Me.Txt_Precio_compra.Name = "Txt_Precio_compra"
        Me.Txt_Precio_compra.Size = New System.Drawing.Size(214, 20)
        Me.Txt_Precio_compra.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Stock:"
        '
        'Txt_Stock
        '
        Me.Txt_Stock.Location = New System.Drawing.Point(126, 200)
        Me.Txt_Stock.MaxLength = 12
        Me.Txt_Stock.Name = "Txt_Stock"
        Me.Txt_Stock.Size = New System.Drawing.Size(106, 20)
        Me.Txt_Stock.TabIndex = 7
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(22, 289)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 16
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripción:"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'txt_Descipcion
        '
        Me.txt_Descipcion.Location = New System.Drawing.Point(126, 137)
        Me.txt_Descipcion.Multiline = True
        Me.txt_Descipcion.Name = "txt_Descipcion"
        Me.txt_Descipcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Descipcion.Size = New System.Drawing.Size(214, 52)
        Me.txt_Descipcion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoría:"
        '
        'Txt_IDCategoria
        '
        Me.Txt_IDCategoria.Location = New System.Drawing.Point(126, 97)
        Me.Txt_IDCategoria.Name = "Txt_IDCategoria"
        Me.Txt_IDCategoria.Size = New System.Drawing.Size(40, 20)
        Me.Txt_IDCategoria.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Producto:"
        '
        'Txt_Producto
        '
        Me.Txt_Producto.Location = New System.Drawing.Point(126, 61)
        Me.Txt_Producto.Name = "Txt_Producto"
        Me.Txt_Producto.Size = New System.Drawing.Size(214, 20)
        Me.Txt_Producto.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Seleccionar)
        Me.GroupBox2.Controls.Add(Me.cb_Eliminar)
        Me.GroupBox2.Controls.Add(Me.Btn_Eliminar)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox2.Controls.Add(Me.Cbo_Campo)
        Me.GroupBox2.Controls.Add(Me.DataListado)
        Me.GroupBox2.Location = New System.Drawing.Point(393, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 316)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de productos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_informacion)
        Me.GroupBox1.Controls.Add(Me.btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.btn_Cargar)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha_Vencimiento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_Precio_Venta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar_Categoria)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre_Categoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_IDProducto)
        Me.GroupBox1.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.Btn_Editar)
        Me.GroupBox1.Controls.Add(Me.Btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_Precio_compra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Stock)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Descipcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_IDCategoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Producto)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 522)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'lbl_informacion
        '
        Me.lbl_informacion.AutoSize = True
        Me.lbl_informacion.Location = New System.Drawing.Point(123, 42)
        Me.lbl_informacion.Name = "lbl_informacion"
        Me.lbl_informacion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_informacion.TabIndex = 28
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackgroundImage = Global.Capa_Cliente.My.Resources.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361
        Me.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Limpiar.Location = New System.Drawing.Point(298, 417)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(42, 39)
        Me.btn_Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Limpiar.TabIndex = 27
        Me.btn_Limpiar.TabStop = False
        '
        'btn_Cargar
        '
        Me.btn_Cargar.BackgroundImage = Global.Capa_Cliente.My.Resources.Resources._1486505253_folder_folder_up_folder_upload_update_folder_upload_81427
        Me.btn_Cargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cargar.Location = New System.Drawing.Point(298, 360)
        Me.btn_Cargar.Name = "btn_Cargar"
        Me.btn_Cargar.Size = New System.Drawing.Size(42, 39)
        Me.btn_Cargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cargar.TabIndex = 26
        Me.btn_Cargar.TabStop = False
        '
        'imagen
        '
        Me.imagen.BackgroundImage = Global.Capa_Cliente.My.Resources.Resources.trans
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Location = New System.Drawing.Point(118, 360)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(164, 113)
        Me.imagen.TabIndex = 25
        Me.imagen.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 351)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Imagen producto:"
        '
        'txt_Fecha_Vencimiento
        '
        Me.txt_Fecha_Vencimiento.Location = New System.Drawing.Point(126, 317)
        Me.txt_Fecha_Vencimiento.Name = "txt_Fecha_Vencimiento"
        Me.txt_Fecha_Vencimiento.Size = New System.Drawing.Size(214, 20)
        Me.txt_Fecha_Vencimiento.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Fecha vencimiento:"
        '
        'txt_Precio_Venta
        '
        Me.txt_Precio_Venta.Location = New System.Drawing.Point(126, 278)
        Me.txt_Precio_Venta.MaxLength = 8
        Me.txt_Precio_Venta.Name = "txt_Precio_Venta"
        Me.txt_Precio_Venta.Size = New System.Drawing.Size(214, 20)
        Me.txt_Precio_Venta.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Precio de venta: "
        '
        'btn_Buscar_Categoria
        '
        Me.btn_Buscar_Categoria.Location = New System.Drawing.Point(298, 94)
        Me.btn_Buscar_Categoria.Name = "btn_Buscar_Categoria"
        Me.btn_Buscar_Categoria.Size = New System.Drawing.Size(42, 23)
        Me.btn_Buscar_Categoria.TabIndex = 5
        Me.btn_Buscar_Categoria.Text = "..."
        Me.btn_Buscar_Categoria.UseVisualStyleBackColor = True
        '
        'txt_Nombre_Categoria
        '
        Me.txt_Nombre_Categoria.Location = New System.Drawing.Point(172, 97)
        Me.txt_Nombre_Categoria.Name = "txt_Nombre_Categoria"
        Me.txt_Nombre_Categoria.Size = New System.Drawing.Size(120, 20)
        Me.txt_Nombre_Categoria.TabIndex = 4
        '
        'txt_flag
        '
        Me.txt_flag.Location = New System.Drawing.Point(338, -4)
        Me.txt_flag.Name = "txt_flag"
        Me.txt_flag.Size = New System.Drawing.Size(49, 20)
        Me.txt_flag.TabIndex = 4
        Me.txt_flag.Text = "0"
        Me.txt_flag.Visible = False
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Location = New System.Drawing.Point(103, 289)
        Me.btn_Seleccionar.Name = "btn_Seleccionar"
        Me.btn_Seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Seleccionar.TabIndex = 17
        Me.btn_Seleccionar.Text = "Seleccionar"
        Me.btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'Frm_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(954, 548)
        Me.Controls.Add(Me.txt_flag)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado del catalogo de productos"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btn_Limpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_Eliminar As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IDProducto As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cbo_Campo As ComboBox
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Txt_Precio_compra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Stock As TextBox
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Descipcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_IDCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Producto As TextBox
    Friend WithEvents btn_Buscar_Categoria As Button
    Friend WithEvents txt_Nombre_Categoria As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_Cargar As PictureBox
    Friend WithEvents imagen As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Fecha_Vencimiento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Precio_Venta As TextBox
    Friend WithEvents btn_Limpiar As PictureBox
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents txt_flag As TextBox
    Friend WithEvents lbl_informacion As Label
    Friend WithEvents btn_Seleccionar As Button
End Class
