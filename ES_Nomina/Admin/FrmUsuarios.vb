Imports System.Data.SqlClient

Public Class FrmUsuarios

    Dim CONN As New SqlConnection(My.Settings.ESNominaConnection)

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ESNomina.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ESNomina.Empleados)
    End Sub

    Private Sub LIMPIAR()
        'DATAREFRESH()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LIMPIAR()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value()
        CheckBox1.Checked = DataGridView1.Rows(e.RowIndex).Cells(5).Value()
        CheckBox2.Checked = DataGridView1.Rows(e.RowIndex).Cells(6).Value()
        CheckBox3.Checked = DataGridView1.Rows(e.RowIndex).Cells(7).Value()
        CheckBox4.Checked = DataGridView1.Rows(e.RowIndex).Cells(8).Value()
        CheckBox5.Checked = DataGridView1.Rows(e.RowIndex).Cells(9).Value()
        CheckBox6.Checked = DataGridView1.Rows(e.RowIndex).Cells(10).Value()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value()
        CheckBox1.Checked = DataGridView1.Rows(e.RowIndex).Cells(5).Value()
        CheckBox2.Checked = DataGridView1.Rows(e.RowIndex).Cells(6).Value()
        CheckBox3.Checked = DataGridView1.Rows(e.RowIndex).Cells(7).Value()
        CheckBox4.Checked = DataGridView1.Rows(e.RowIndex).Cells(8).Value()
        CheckBox5.Checked = DataGridView1.Rows(e.RowIndex).Cells(9).Value()
        CheckBox6.Checked = DataGridView1.Rows(e.RowIndex).Cells(10).Value()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Focus()
            TextBox1.BackColor = Color.Yellow
            Exit Sub
        End If

        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox2.Text) Then
            TextBox2.Focus()
            TextBox2.BackColor = Color.Yellow
            Exit Sub
        End If

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

        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox5.Text) Then
            TextBox5.Focus()
            TextBox5.BackColor = Color.Yellow
            Exit Sub
        End If

        'verificar si usuario existe
        Me.EmpleadosTableAdapter.ConsultaExistencia(ESNomina.Empleados, TextBox1.Text)
        'Si(existe)
        If ESNomina.Empleados.Count() = 0 Then
            Me.EmpleadosTableAdapter.AGREGAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, CheckBox1.Checked, CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked, CheckBox5.Checked, CheckBox6.Checked)
        Else
            Me.EmpleadosTableAdapter.EDITAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, CheckBox1.Checked, CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked, CheckBox5.Checked, CheckBox6.Checked)
        End If


        MessageBox.Show("Datos guardados correctamente.", "Biblioteca Online", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        LIMPIAR()

    End Sub

    Private Sub DATAREFRESH()
        Dim DS As New DataSet()
        Dim DA As New SqlDataAdapter("SELECT Username AS Usuario, PassEmpleado AS Contraseña, NombreEmpleado AS Nombre, TelefonoEmpleado AS Telefono, Sueldo AS Sueldo, Estado AS Estado, Marcado AS Marcado, Catalogo AS Catálogo, Consulta AS Consulta, Reporte AS Reporte, Administrador AS Administración FROM Empleados", CONN)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkBlue
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'VALIDAR CAJA DE TEXTO VACIA
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Focus()
            TextBox1.BackColor = Color.Yellow
            Exit Sub
        End If

        Me.EmpleadosTableAdapter.ELIMINAR(TextBox1.Text)
        MessageBox.Show("Datos eliminados correctamente.", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        LIMPIAR()
    End Sub

End Class