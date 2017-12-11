Public NotInheritable Class SplashScreen

    Public CONTADOR As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CONTADOR < 100 Then
            ProgressBar1.Value = CONTADOR
            CONTADOR = CONTADOR + 1
        Else
            Timer1.Enabled = False
            Me.Hide()
            FrmMenu.Show()
        End If
    End Sub
End Class
