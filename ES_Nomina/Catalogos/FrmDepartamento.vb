Public Class FrmDepartamento
    Private Sub FrmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.ESNomina.Departamento)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Focus()
            TextBox1.BackColor = Color.Yellow
            Exit Sub
        End If

        Me.DepartamentoTableAdapter.AGREGAR(TextBox1.Text)
        MessageBox.Show("Datos guardados correctamente.", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class