Public Class Frm_Reporte_Productos
    Private Sub Frm_Reporte_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet.Mostrar_producto' Puede moverla o quitarla según sea necesario.
        Me.Mostrar_productoTableAdapter.Fill(Me.dbventasDataSet.Mostrar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class