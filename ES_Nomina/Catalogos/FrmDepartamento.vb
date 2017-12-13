Public Class FrmDepartamento
    Private Sub FrmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.ESNomina.Departamento)

    End Sub
End Class