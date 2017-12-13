Public Class FrmPuesto
    Private Sub FrmPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Puesto' Puede moverla o quitarla según sea necesario.
        Me.PuestoTableAdapter.Fill(Me.ESNomina.Puesto)

    End Sub
End Class