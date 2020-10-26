Public Class Frm_Reporte_Comprobante
    Private Sub Frm_Reporte_Comprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet.Generar_Comprobante' Puede moverla o quitarla según sea necesario.
        Try
            Me.Generar_ComprobanteTableAdapter.Fill(Me.dbventasDataSet.Generar_Comprobante, IDVenta:=Txt_IDVenta.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try

    End Sub


End Class