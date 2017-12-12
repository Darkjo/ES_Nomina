Imports System.Data.SqlClient

Public Class FrmBackUp

    Dim cmd As SqlCommand
    Dim CONN As New SqlConnection(My.Settings.ESNominaConnection)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As String
        fecha = DateString
        cmd = New SqlCommand("backup database ESNomina to disk='D:\" & fecha & "-ESNomina.bak'", CONN)
        CONN.Open()
        cmd.ExecuteNonQuery()
        CONN.Close()

        MessageBox.Show("Respaldo efectuado correctamente", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub

    Private Sub FrmBackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class