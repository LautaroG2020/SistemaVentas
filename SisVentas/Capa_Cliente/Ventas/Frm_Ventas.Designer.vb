<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ventas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDVenta = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cbo_Campo = New System.Windows.Forms.ComboBox()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_NumeroDocumento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_IDCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Seleccionar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Informacion = New System.Windows.Forms.Label()
        Me.cb_TipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.Txt_NombreCliente = New System.Windows.Forms.TextBox()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txt_IDVenta.Location = New System.Drawing.Point(130, 29)
        Me.txt_IDVenta.Name = "txt_IDVenta"
        Me.txt_IDVenta.Size = New System.Drawing.Size(217, 20)
        Me.txt_IDVenta.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(149, 287)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 11
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(230, 287)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 12
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Editar
        '
        Me.Btn_Editar.Location = New System.Drawing.Point(149, 287)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Editar.TabIndex = 12
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = True
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Location = New System.Drawing.Point(67, 287)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nuevo.TabIndex = 1
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
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
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(161, 20)
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(248, 20)
        Me.Txt_Buscar.TabIndex = 8
        '
        'Cbo_Campo
        '
        Me.Cbo_Campo.FormattingEnabled = True
        Me.Cbo_Campo.Items.AddRange(New Object() {"Num_Documento", "Dni"})
        Me.Cbo_Campo.Location = New System.Drawing.Point(15, 19)
        Me.Cbo_Campo.Name = "Cbo_Campo"
        Me.Cbo_Campo.Size = New System.Drawing.Size(132, 21)
        Me.Cbo_Campo.TabIndex = 7
        Me.Cbo_Campo.Text = "Num_Documento"
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataListado.Location = New System.Drawing.Point(12, 50)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(526, 217)
        Me.DataListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero de documento:"
        '
        'Txt_NumeroDocumento
        '
        Me.Txt_NumeroDocumento.Location = New System.Drawing.Point(130, 193)
        Me.Txt_NumeroDocumento.MaxLength = 12
        Me.Txt_NumeroDocumento.Name = "Txt_NumeroDocumento"
        Me.Txt_NumeroDocumento.Size = New System.Drawing.Size(217, 20)
        Me.Txt_NumeroDocumento.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo de documento:"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Cliente:"
        '
        'Txt_IDCliente
        '
        Me.Txt_IDCliente.Location = New System.Drawing.Point(130, 76)
        Me.Txt_IDCliente.Name = "Txt_IDCliente"
        Me.Txt_IDCliente.Size = New System.Drawing.Size(48, 20)
        Me.Txt_IDCliente.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Seleccionar)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox2.Controls.Add(Me.Cbo_Campo)
        Me.GroupBox2.Controls.Add(Me.DataListado)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 316)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de ventas realizadas"
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Location = New System.Drawing.Point(15, 287)
        Me.btn_Seleccionar.Name = "btn_Seleccionar"
        Me.btn_Seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Seleccionar.TabIndex = 22
        Me.btn_Seleccionar.Text = "Seleccionar"
        Me.btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Informacion)
        Me.GroupBox1.Controls.Add(Me.cb_TipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Txt_Fecha)
        Me.GroupBox1.Controls.Add(Me.Btn_BuscarCliente)
        Me.GroupBox1.Controls.Add(Me.Txt_NombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_IDVenta)
        Me.GroupBox1.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.Btn_Editar)
        Me.GroupBox1.Controls.Add(Me.Btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_NumeroDocumento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_IDCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 317)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'lbl_Informacion
        '
        Me.lbl_Informacion.AutoSize = True
        Me.lbl_Informacion.Location = New System.Drawing.Point(132, 50)
        Me.lbl_Informacion.Name = "lbl_Informacion"
        Me.lbl_Informacion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Informacion.TabIndex = 21
        '
        'cb_TipoDocumento
        '
        Me.cb_TipoDocumento.FormattingEnabled = True
        Me.cb_TipoDocumento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cb_TipoDocumento.Location = New System.Drawing.Point(130, 152)
        Me.cb_TipoDocumento.Name = "cb_TipoDocumento"
        Me.cb_TipoDocumento.Size = New System.Drawing.Size(213, 21)
        Me.cb_TipoDocumento.TabIndex = 20
        Me.cb_TipoDocumento.Text = "Factura"
        '
        'Txt_Fecha
        '
        Me.Txt_Fecha.Location = New System.Drawing.Point(130, 118)
        Me.Txt_Fecha.Name = "Txt_Fecha"
        Me.Txt_Fecha.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Fecha.TabIndex = 19
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(317, 73)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(30, 23)
        Me.Btn_BuscarCliente.TabIndex = 18
        Me.Btn_BuscarCliente.Text = "..."
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'Txt_NombreCliente
        '
        Me.Txt_NombreCliente.Location = New System.Drawing.Point(184, 76)
        Me.Txt_NombreCliente.Name = "Txt_NombreCliente"
        Me.Txt_NombreCliente.Size = New System.Drawing.Size(127, 20)
        Me.Txt_NombreCliente.TabIndex = 17
        '
        'Frm_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 357)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de ventas"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IDVenta As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cbo_Campo As ComboBox
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_NumeroDocumento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_IDCliente As TextBox
    Friend WithEvents cb_TipoDocumento As ComboBox
    Friend WithEvents Txt_Fecha As DateTimePicker
    Friend WithEvents Btn_BuscarCliente As Button
    Friend WithEvents Txt_NombreCliente As TextBox
    Friend WithEvents lbl_Informacion As Label
    Friend WithEvents btn_Seleccionar As Button
End Class
