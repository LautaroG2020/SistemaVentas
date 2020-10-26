<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.lbl_Informacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDUsuario = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cbo_Campo = New System.Windows.Forms.ComboBox()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Direccion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Apellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Acceso = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Login = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Dni = New System.Windows.Forms.TextBox()
        Me.btn_Seleccionar = New System.Windows.Forms.Button()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(22, 289)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 15
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_Informacion
        '
        Me.lbl_Informacion.AutoSize = True
        Me.lbl_Informacion.Location = New System.Drawing.Point(120, 42)
        Me.lbl_Informacion.Name = "lbl_Informacion"
        Me.lbl_Informacion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Informacion.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id usuario:"
        '
        'txt_IDUsuario
        '
        Me.txt_IDUsuario.Location = New System.Drawing.Point(117, 19)
        Me.txt_IDUsuario.Name = "txt_IDUsuario"
        Me.txt_IDUsuario.Size = New System.Drawing.Size(217, 20)
        Me.txt_IDUsuario.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(167, 364)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 10
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(248, 364)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 11
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Editar
        '
        Me.Btn_Editar.Location = New System.Drawing.Point(167, 364)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Editar.TabIndex = 12
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = True
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Location = New System.Drawing.Point(85, 364)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nuevo.TabIndex = 16
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(155, 34)
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(248, 20)
        Me.Txt_Buscar.TabIndex = 13
        '
        'Cbo_Campo
        '
        Me.Cbo_Campo.FormattingEnabled = True
        Me.Cbo_Campo.Items.AddRange(New Object() {"Nombre", "Apellido", "Dni", "Telefono"})
        Me.Cbo_Campo.Location = New System.Drawing.Point(9, 33)
        Me.Cbo_Campo.Name = "Cbo_Campo"
        Me.Cbo_Campo.Size = New System.Drawing.Size(132, 21)
        Me.Cbo_Campo.TabIndex = 12
        Me.Cbo_Campo.Text = "Dni"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefono:"
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(117, 216)
        Me.Txt_Telefono.MaxLength = 12
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Telefono.TabIndex = 6
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Direccion:"
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.Location = New System.Drawing.Point(117, 176)
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Direccion.TabIndex = 5
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
        Me.GroupBox2.Location = New System.Drawing.Point(391, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 316)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuarios"
        '
        'cb_Eliminar
        '
        Me.cb_Eliminar.AutoSize = True
        Me.cb_Eliminar.Location = New System.Drawing.Point(9, 60)
        Me.cb_Eliminar.Name = "cb_Eliminar"
        Me.cb_Eliminar.Size = New System.Drawing.Size(102, 17)
        Me.cb_Eliminar.TabIndex = 14
        Me.cb_Eliminar.Text = "Eliminar Clientes"
        Me.cb_Eliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos:"
        '
        'Txt_Apellido
        '
        Me.Txt_Apellido.Location = New System.Drawing.Point(117, 102)
        Me.Txt_Apellido.Name = "Txt_Apellido"
        Me.Txt_Apellido.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Apellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(117, 67)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Nombre.TabIndex = 2
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Acceso)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_Contraseña)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_Login)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_Dni)
        Me.GroupBox1.Controls.Add(Me.lbl_Informacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_IDUsuario)
        Me.GroupBox1.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.Btn_Editar)
        Me.GroupBox1.Controls.Add(Me.Btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Telefono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_Direccion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Apellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 393)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txt_Acceso
        '
        Me.txt_Acceso.Location = New System.Drawing.Point(117, 326)
        Me.txt_Acceso.MaxLength = 12
        Me.txt_Acceso.Name = "txt_Acceso"
        Me.txt_Acceso.Size = New System.Drawing.Size(44, 20)
        Me.txt_Acceso.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Capa_Cliente.My.Resources.Resources.information_info_1565
        Me.PictureBox1.Location = New System.Drawing.Point(167, 328)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Acceso:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Contraseña:"
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(117, 292)
        Me.txt_Contraseña.MaxLength = 12
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.Size = New System.Drawing.Size(217, 20)
        Me.txt_Contraseña.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Nombre del usuario:"
        '
        'txt_Login
        '
        Me.txt_Login.Location = New System.Drawing.Point(117, 255)
        Me.txt_Login.MaxLength = 12
        Me.txt_Login.Name = "txt_Login"
        Me.txt_Login.Size = New System.Drawing.Size(217, 20)
        Me.txt_Login.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Dni: "
        '
        'Txt_Dni
        '
        Me.Txt_Dni.Location = New System.Drawing.Point(117, 139)
        Me.Txt_Dni.MaxLength = 8
        Me.Txt_Dni.Name = "Txt_Dni"
        Me.Txt_Dni.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Dni.TabIndex = 4
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Location = New System.Drawing.Point(103, 289)
        Me.btn_Seleccionar.Name = "btn_Seleccionar"
        Me.btn_Seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Seleccionar.TabIndex = 16
        Me.btn_Seleccionar.Text = "Seleccionar"
        Me.btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 462)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents lbl_Informacion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IDUsuario As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cbo_Campo As ComboBox
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Telefono As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Direccion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_Eliminar As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Apellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Contraseña As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Login As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Dni As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_Acceso As TextBox
    Friend WithEvents btn_Seleccionar As Button
End Class
