Public Class FrmPuesto
    Private Sub FrmPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Puesto' Puede moverla o quitarla según sea necesario.
        Me.PuestoTableAdapter.Fill(Me.ESNomina.Puesto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Focus()
            TextBox1.BackColor = Color.Yellow
            Exit Sub
        End If

        Me.PuestoTableAdapter.AGREGAR(TextBox1.Text)
        MessageBox.Show("Datos guardados correctamente.", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class