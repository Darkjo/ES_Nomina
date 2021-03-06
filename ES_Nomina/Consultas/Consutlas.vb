﻿Imports System.Data.SqlClient

Public Class Consutlas

    Dim CONN As New SqlConnection(My.Settings.ESNominaConnection)

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim DS As New DataSet()
        Dim DA As New SqlDataAdapter("SELECT Empleados.idEmpleados AS ID, Empleados.Username AS Usuario, Empleados.PassEmpleado AS Clave, Empleados.NombreEmpleado AS Nombre,
        Empleados.TelefonoEmpleado AS Telefono, Empleados.Sueldo AS Sueldo, Empleados.Estado AS Estado, Empleados.Marcado AS Marcados, Empleados.Catalogo As Catalogos,
        Empleados.Consulta AS Consultas, Empleados.Reporte AS Reportes, Empleados.Administrador As Administracion, Departamento.nombreDepartamento AS Departamento, 
        Puesto.NombrePuesto AS Puesto
        FROM ((Empleados
        INNER JOIN Departamento ON Empleados.idDepartamento = Departamento.idDepartamento)
        INNER JOIN Puesto ON Empleados.idPuesto = Puesto.idPuesto);", CONN)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim DS As New DataSet()
        Dim DA As New SqlDataAdapter("SELECT idDepartamento As ID, NombreDepartamento As Departamento FROM Departamento", CONN)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim DS As New DataSet()
        Dim DA As New SqlDataAdapter("SELECT idPuesto As ID, NombrePuesto As Puesto FROM Puesto", CONN)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim DS As New DataSet()
        Dim DA As New SqlDataAdapter("SELECT Marcado.idMarcado As ID, Marcado.HoraMarcado As Hora, Marcado.FechaMarcado As Fecha, CASE TipoMarcado WHEN 'True' THEN 'Entrada' ELSE 'Salida' END AS Tipo, Empleados.NombreEmpleado 
        FROM Marcado
        INNER JOIN Empleados ON Marcado.idEmpleados = Empleados.idEmpleados;", CONN)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            Dim DS As New DataSet()
            Dim DA As New SqlDataAdapter("SELECT Empleados.idEmpleados AS ID, Empleados.Username AS Usuario, Empleados.PassEmpleado AS Clave, Empleados.NombreEmpleado AS Nombre,
        Empleados.TelefonoEmpleado AS Telefono, Empleados.Sueldo AS Sueldo, Empleados.Estado AS Estado, Empleados.Marcado AS Marcados, Empleados.Catalogo As Catalogos,
        Empleados.Consulta AS Consultas, Empleados.Reporte AS Reportes, Empleados.Administrador As Administracion, Departamento.nombreDepartamento AS Departamento, 
        Puesto.NombrePuesto AS Puesto
        FROM ((Empleados
        INNER JOIN Departamento ON Empleados.idDepartamento = Departamento.idDepartamento)
        INNER JOIN Puesto ON Empleados.idPuesto = Puesto.idPuesto) 
        WHERE NombreEmpleado like '%" & TextBox1.Text & "%' ORDER BY NombreEmpleado DESC", CONN)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.DefaultCellStyle.BackColor = Color.White
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            DataGridView1.AutoResizeColumns()
        End If

        If RadioButton2.Checked = True Then
            Dim DS As New DataSet()
            Dim DA As New SqlDataAdapter("SELECT idDepartamento As ID, NombreDepartamento As Departamento FROM Departamento
            WHERE NombreDepartamento like '%" & TextBox1.Text & "%' ORDER BY NombreDepartamento DESC", CONN)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.DefaultCellStyle.BackColor = Color.White
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            DataGridView1.AutoResizeColumns()
        End If
        If RadioButton3.Checked = True Then
            Dim DS As New DataSet()
            Dim DA As New SqlDataAdapter("SELECT idPuesto As ID, NombrePuesto As Puesto FROM Puesto
            WHERE NombrePuesto like '%" & TextBox1.Text & "%' ORDER BY NombrePuesto DESC", CONN)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.DefaultCellStyle.BackColor = Color.White
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            DataGridView1.AutoResizeColumns()
        End If
        If RadioButton4.Checked = True Then
            Dim DS As New DataSet()
            Dim DA As New SqlDataAdapter("SELECT Marcado.idMarcado As ID, Marcado.HoraMarcado As Hora, Marcado.FechaMarcado As Fecha, CASE TipoMarcado WHEN 'True' THEN 'Entrada' ELSE 'Salida' END AS Tipo, Empleados.NombreEmpleado 
            FROM Marcado
            INNER JOIN Empleados ON Marcado.idEmpleados = Empleados.idEmpleados
            WHERE Empleados.idEmpleados like '%" & TextBox1.Text & "%' ORDER BY Empleados.idEmpleados DESC;", CONN)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.DefaultCellStyle.BackColor = Color.White
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            DataGridView1.AutoResizeColumns()
        End If
    End Sub

    Private Sub Consutlas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ESNomina.Marcado' table. You can move, or remove it, as needed.
        Me.MarcadoTableAdapter.Fill(Me.ESNomina.Marcado)
        'TODO: This line of code loads data into the 'ESNomina.Puesto' table. You can move, or remove it, as needed.
        Me.PuestoTableAdapter.Fill(Me.ESNomina.Puesto)
        'TODO: This line of code loads data into the 'ESNomina.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.ESNomina.Empleados)
        'TODO: This line of code loads data into the 'ESNomina.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.ESNomina.Departamento)

    End Sub
End Class