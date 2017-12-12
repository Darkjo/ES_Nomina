Imports System.Data.SqlClient

Public Class FrmUsuario

    Dim CONN As New SqlConnection(My.Settings.ESNominaConnection)

    Private Sub DATAREFRESH()
        Dim DS As New DataSet()
        Dim DA As New SqlDataAdapter("Select Username AS Usuario, PassEmpleado AS Clave,
        NombreEmpleado AS Nombre, TelefonoEmpleado AS Telefono, Sueldo AS Sueldo, Estado AS Estado, Marcado AS Marcado,
        Catalogo AS Catálogos, Consulta AS Consultas, Reporte AS Reportes, Administrador AS Administrador 
        FROM Empleados", CONN)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub LIMPIAR()
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


    Private Sub ConsultaExistenciaToolStripButton_Click_1(sender As Object, e As EventArgs) 
        Try
            Me.EmpleadosTableAdapter1.ConsultaExistencia(Me.ESNomina1.Empleados, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpleadosTableAdapter.Fill(Me.ESNomina.Empleados)
    End Sub
End Class