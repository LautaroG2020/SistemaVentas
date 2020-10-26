Public Class Frm_Reporte_Cliente
    Private Sub Frm_Reporte_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.dbventasDataSet.Cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class