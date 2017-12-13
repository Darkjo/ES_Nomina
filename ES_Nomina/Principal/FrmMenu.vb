Public Class FrmMenu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = DateTime.Now.ToString("dd") + "/" + Format(Now, "MMMM") + "/" + DateTime.Now.ToString("yy")
    End Sub

    Private Sub SalirStripMenuItem1_Click(sender As Object, e As EventArgs) Handles opcionSalir.Click
        Me.Close()
    End Sub

    Private Sub cerrarSesion_Click(sender As Object, e As EventArgs) Handles cerrarSesion.Click

        menuMarcado.Enabled = False
        menuCatalogos.Enabled = False
        menuConsultas.Enabled = False
        menuReportes.Enabled = False
        menuAdmin.Enabled = False

        For Each form As Form In Me.MdiChildren
            form.Close()
        Next

        Dim Login As New Login()
        Login.MdiParent = Me
        Login.Show()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Login As New Login()
        Login.MdiParent = Me
        Login.Show()
    End Sub

    Private Sub menuMarcado_Click(sender As Object, e As EventArgs) Handles menuMarcado.Click
        Dim Marcado As New FrmMarcado()
        Marcado.MdiParent = Me
        Marcado.Show()
    End Sub

    Private Sub GestionDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuarioToolStripMenuItem.Click
        Dim Usuarios As New FrmUsuarios()
        Usuarios.MdiParent = Me
        Usuarios.Show()
    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioDeContraseñaToolStripMenuItem.Click
        Dim Cambio As New FrmCambioClave()
        Cambio.MdiParent = Me
        Cambio.Show()
    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        Dim BackUp As New FrmBackUp()
        BackUp.MdiParent = Me
        BackUp.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        Dim Dept As New FrmDepartamento()
        Dept.MdiParent = Me
        Dept.Show()
    End Sub

    Private Sub PuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestoToolStripMenuItem.Click
        Dim Puesto As New FrmPuesto()
        Puesto.MdiParent = Me
        Puesto.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim Puesto As New Form1()
        Puesto.MdiParent = Me
        Puesto.Show()
    End Sub

    Private Sub menuConsultas_Click(sender As Object, e As EventArgs) Handles menuConsultas.Click
        Dim Consult As New Consutlas()
        Consult.MdiParent = Me
        Consult.Show()
    End Sub
End Class
