Imports System.Data.SqlClient

Public Class FrmMarcado

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("dd") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = Date.Now.ToLongTimeString
    End Sub

    Private Function Buscar(id As String) As DataRow

        If (String.IsNullOrEmpty(id)) Then
            Throw New ArgumentNullException("idEmpleados")
        End If

        ' Declaramos la variable que devolverá la función, que
        ' en principio indica que no existe ningún registro
        ' que coincida con el ID especificado.
        Dim returnValue As DataRow = Nothing

        ' Creamos la conexión con la base de SQL Server.
        Using cnn As New SqlConnection(My.Settings.ESNominaConnection)

            ' Creamos un objeto Command.
            Dim cmd As SqlCommand = cnn.CreateCommand()

            ' Indicamos la consulta SQL de selección que deseamos ejecutar
            cmd.CommandText = "SELECT Empleados.idEmpleados, Empleados.NombreEmpleado FROM Empleados WHERE idEmpleados=@idEmpleados"

            ' Añadimos el único parámetro de entrada existente en la consulta
            cmd.Parameters.AddWithValue("@idEmpleados", id)

            ' Creamos el adaptador de datos al que le pasamos el objeto Command.
            Dim da As New SqlDataAdapter(cmd)

            ' Intentamos rellenar un objeto DataTable como resultado
            ' de ejecutar la consulta SQL de selección especificada.
            '
            Using dt As New DataTable()

                da.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    ' Nos quedamos con la primera fila u objeto DataRow.
                    '
                    returnValue = dt.Rows(0)
                End If

            End Using

        End Using

        ' Devolvemos el objeto DataRow obtenido.
        '
        Return returnValue

    End Function

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ESNomina)

    End Sub

    Private Sub FrmMarcado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Marcado' Puede moverla o quitarla según sea necesario.
        Me.MarcadoTableAdapter.Fill(Me.ESNomina.Marcado)
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ESNomina.Empleados)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MostrarEmp.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ' Obtenemos un objeto DataRow correspondiente con
            ' el ID escrito en un control TextBox
            '
            Dim row As DataRow = Buscar(TextBox1.Text)

            If (row Is Nothing) Then
                MessageBox.Show("No hay registros que coincidan con el ID especificado.")
                ' Abandonamos el procedimiento
                Return
            End If

            ' Rellenamos los correspondientes controles TextBox
            ' con los datos existentes en el objeto DataRow
            ' obtenido.
            '
            TextBox2.Text = row("NombreEmpleado")

        Catch ex As Exception
            ' Se ha producido un error
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Focus()
            TextBox1.BackColor = Color.Yellow
            Exit Sub
        End If

        Dim fecha As Date
        fecha = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd")

        Dim hora As Date
        hora = Date.Now.ToLongTimeString


        Me.MarcadoTableAdapter.AGREGAR("08:30:12.0000000", fecha, RadioButton1.Checked, TextBox1.Text)
        MessageBox.Show("Marcado Ingresado corectamente", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub
End Class

