Public Class FrmMarcado
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = DateTime.Now.ToString("dd") + "/" + Format(Now, "MMMM") + "/" + DateTime.Now.ToString("yy")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class