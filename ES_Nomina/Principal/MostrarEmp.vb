Public Class MostrarEmp
    Private Sub MostrarEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ESNomina.Empleados)

    End Sub
End Class