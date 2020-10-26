Imports System.ComponentModel
Imports Capa_Conexion
Imports Capa_ReglasDeNegocio
Imports System.Data.SqlClient
Public Class Frm_ConsultarVenta

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        Try
            Dim cna = New SqlConnection("Server=192.168.56.1;Uid=sa;Pwd=sasa;Database=dbventas;")
            Dim daa = New SqlDataAdapter("Select * from Ventas where Fecha between '" + dtp_Fecha1.Value.ToString("yyyy-MM-dd") + "' and '" + dtp_Fecha2.Value.ToString("yyyy-MM-dd") + "'", cna)
            Dim dta = New DataTable
            daa.Fill(dta)
            Me.DataListado.DataSource = dta
            GroupBox2.Enabled = True
        Catch ex As Exception
            MsgBox("Error en la consulta de ventas: " + ex.Message)
        End Try


    End Sub

    Private Sub Frm_ConsultarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
        dtp_Fecha1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataListado.DataSource = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.Enabled = False
        dtp_Fecha1.Focus()
    End Sub
End Class