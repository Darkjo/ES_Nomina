Public Class FrmMenu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = DateTime.Now.ToString("dd") + "/" + Format(Now, "MMMM") + "/" + DateTime.Now.ToString("yy")
    End Sub

    Private Sub InicioDeSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioDeSesiónToolStripMenuItem.Click

    End Sub

End Class
