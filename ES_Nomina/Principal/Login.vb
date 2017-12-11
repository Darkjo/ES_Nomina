Imports System.Data.SqlClient

Public Class Login

    Dim CONN As New SqlConnection(My.Settings.ESNominaConnection)

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmMenu.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        INICIAR()
    End Sub

    Private Sub INICIAR()
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

        Me.EmpleadosTableAdapter.LoginEmp(TextBox1.Text, TextBox2.Text)
        If EsNomina1.Empleados.Count() = 0 Then
            MessageBox.Show("Datos incorrectos. Intente nuevamente.", "ESNomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
            Exit Sub
        Else


            Try
                'CONEXION A LA BASE DE DATOS
                Dim DS As New DataSet
                Dim DA As New SqlDataAdapter("SELECT * FROM empleados Where Username='" & TextBox1.Text & "' AND PassEmpleado='" & TextBox2.Text & "' ", CONN)
                Dim DR As DataRow
                DA.Fill(DS)
                DR = DS.Tables(0).Rows(0)

                'VALIDACION DE CADA UNA DE LAS OPCIONES DEL MENU
                Dim validar As String

                validar = CStr(DR!Marcado)
                If validar = "True" Then
                    FrmMenu.menuMarcado.Enabled = True
                End If

                validar = CStr(DR!Catalogo)
                If validar = "True" Then
                    FrmMenu.menuCatalogos.Enabled = True
                End If

                validar = CStr(DR!Consulta)
                If validar = "True" Then
                    FrmMenu.menuConsultas.Enabled = True
                End If

                validar = CStr(DR!Reporte)
                If validar = "True" Then
                    FrmMenu.menuReportes.Enabled = True
                End If

                validar = CStr(DR!Administrador)
                If validar = "True" Then
                    FrmMenu.menuAdmin.Enabled = True
                End If

                'ACCESO AL SISTEMA
                Me.Close()

            Catch ex As Exception

                MessageBox.Show("Usuario o Contrtaseña incorrectas", "ESNomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox1.Focus()
                Exit Sub

            End Try

        End If

    End Sub

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EsNomina1)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EsNomina1.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.EsNomina1.Empleados)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            INICIAR()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            INICIAR()
        End If
    End Sub

End Class