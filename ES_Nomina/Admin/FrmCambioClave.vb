Public Class FrmCambioClave
    Private Sub FrmCambioClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ESNomina.Empleados)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox3.Text) Then
            TextBox3.Focus()
            TextBox3.BackColor = Color.Yellow
            Exit Sub
        End If

        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox4.Text) Then
            TextBox4.Focus()
            TextBox4.BackColor = Color.Yellow
            Exit Sub
        End If

        'VALIDACION CONTRASEÑAS IGUALES
        If TextBox4.Text = TextBox3.Text Then
            Try

                Me.EmpleadosTableAdapter.CambioPass(TextBox3.Text, TextBox1.Text)
                MessageBox.Show("El cambio de clave se ha efectuado correctamente.", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()

            Catch ex As Exception

                MessageBox.Show("Falló la conexió con la base de datos, consulte con el administrador del sistema.", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox1.Focus()
                Exit Sub

            End Try
        Else
            TextBox4.Focus()
            TextBox4.BackColor = Color.Yellow
            Exit Sub
        End If
    End Sub
End Class