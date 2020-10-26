<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Comprobante
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
        Me.Generar_ComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbventasDataSet = New Capa_Cliente.dbventasDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_ComprobanteTableAdapter = New Capa_Cliente.dbventasDataSetTableAdapters.Generar_ComprobanteTableAdapter()
        Me.Txt_IDVenta = New System.Windows.Forms.TextBox()
        CType(Me.Generar_ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_ComprobanteBindingSource
        '
        Me.Generar_ComprobanteBindingSource.DataMember = "Generar_Comprobante"
        Me.Generar_ComprobanteBindingSource.DataSource = Me.dbventasDataSet
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
        ReportDataSource1.Value = Me.Generar_ComprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Cliente.Rpt_Comprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 492)
        Me.ReportViewer1.TabIndex = 0
        '
        'Generar_ComprobanteTableAdapter
        '
        Me.Generar_ComprobanteTableAdapter.ClearBeforeFill = True
        '
        'Txt_IDVenta
        '
        Me.Txt_IDVenta.Location = New System.Drawing.Point(12, 35)
        Me.Txt_IDVenta.Name = "Txt_IDVenta"
        Me.Txt_IDVenta.Size = New System.Drawing.Size(71, 20)
        Me.Txt_IDVenta.TabIndex = 1
        Me.Txt_IDVenta.Visible = False
        '
        'Frm_Reporte_Comprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 492)
        Me.Controls.Add(Me.Txt_IDVenta)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frm_Reporte_Comprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante de venta"
        CType(Me.Generar_ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_ComprobanteBindingSource As BindingSource
    Friend WithEvents dbventasDataSet As dbventasDataSet
    Friend WithEvents Generar_ComprobanteTableAdapter As dbventasDataSetTableAdapters.Generar_ComprobanteTableAdapter
    Friend WithEvents Txt_IDVenta As TextBox
End Class
