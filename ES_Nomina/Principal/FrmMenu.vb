﻿Public Class FrmMenu
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
End Class
