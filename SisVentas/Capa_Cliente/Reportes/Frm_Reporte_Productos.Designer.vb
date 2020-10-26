<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Productos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Productos))
        Me.Mostrar_productoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbventasDataSet = New Capa_Cliente.dbventasDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Mostrar_productoTableAdapter = New Capa_Cliente.dbventasDataSetTableAdapters.Mostrar_productoTableAdapter()
        CType(Me.Mostrar_productoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mostrar_productoBindingSource
        '
        Me.Mostrar_productoBindingSource.DataMember = "Mostrar_producto"
        Me.Mostrar_productoBindingSource.DataSource = Me.dbventasDataSet
        '
        'dbventasDataSet
        '
        Me.dbventasDataSet.DataSetName = "dbventasDataSet"
        Me.dbventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Mostrar_productoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Cliente.Rpt_Productos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(884, 522)
        Me.ReportViewer1.TabIndex = 0
        '
        'Mostrar_productoTableAdapter
        '
        Me.Mostrar_productoTableAdapter.ClearBeforeFill = True
        '
        'Frm_Reporte_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 522)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de productos"
        CType(Me.Mostrar_productoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Mostrar_productoBindingSource As BindingSource
    Friend WithEvents dbventasDataSet As dbventasDataSet
    Friend WithEvents Mostrar_productoTableAdapter As dbventasDataSetTableAdapters.Mostrar_productoTableAdapter
End Class
