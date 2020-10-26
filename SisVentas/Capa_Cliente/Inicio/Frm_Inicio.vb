Imports System.Windows.Forms

Public Class Frm_Inicio

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) 
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) 
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click

        Frm_Categoria.Show()
    End Sub


    Private Sub RegistroDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click

        Frm_Ventas.Show()
    End Sub

    Private Sub ReportesDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeProductosToolStripMenuItem.Click

        Frm_Reporte_Productos.Show()
    End Sub


    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        'Frm_Backup_Base.MdiParent = Me
        Frm_Backup_Base.Show()
    End Sub


    Private Sub Frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mayus As String             'Variable que toma la cadena de caracteres del usuario para convertir en mayuscula
        mayus = UCase(Frm_Login.txt_Login.Text)
        Tss_lbl_Login.Text = mayus


        Tss_lbl_Fecha.Text = Date.Today
        Tss_lbl_Hora.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Tss_lbl_Hora.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        'Frm_Productos.MdiParent = Me
        Frm_Productos.Show()
    End Sub

    Private Sub CerrarSeccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSeccionToolStripMenuItem.Click
        Me.Close()
        Frm_Login.Show()
        Frm_Login.txt_Login.Clear()
        Frm_Login.Txt_Password.Clear()
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim res As New DialogResult
        res = MessageBox.Show("Siempre es recomendable cerrar seccion antes de salir del sistema,¿Desea continuar?", "Salir del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If res = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If Frm_Login.txt_Login.Text = "ADMIN" Then
            Usuarios.Show()
        Else
            MessageBox.Show("Su perfil no tiene acceso a la informacion de los usuarios, contactese con el administrador del sistema.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolBarToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim res As New DialogResult
        res = MessageBox.Show("Siempre es recomendable cerrar seccion antes de salir del sistema,¿Desea continuar?", "Salir del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If res = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ConsultarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVentasToolStripMenuItem.Click
        Frm_ConsultarVenta.Show()
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        Frm_CorreoClientes.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Frm_Cliente.Show()
    End Sub

    Private Sub ReporteDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeClientesToolStripMenuItem.Click
        Frm_Reporte_Cliente.Show()
    End Sub
End Class
