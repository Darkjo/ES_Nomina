Imports System.Data.SqlClient

Public Class FrmDepartamento

    Dim CONN As New SqlConnection(My.Settings.ESNominaConnection)

    Private Sub FrmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DATAREFRESH()
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
        LIMPIAR()
    End Sub

    Private Sub DATAREFRESH()
        Dim DS As New DataSet()
        Dim DA As New SqlDataAdapter("SELECT NombreDepartamento FROM Departamento", CONN)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub LIMPIAR()
        DATAREFRESH()
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class