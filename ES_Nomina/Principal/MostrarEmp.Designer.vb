<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostrarEmp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESNomina = New ES_Nomina.ESNomina()
        Me.EmpleadosTableAdapter = New ES_Nomina.ESNominaTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New ES_Nomina.ESNominaTableAdapters.TableAdapterManager()
        Me.IdEmpleadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadosDataGridViewTextBoxColumn, Me.NombreEmpleadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpleadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(315, 330)
        Me.DataGridView1.TabIndex = 0
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ESNomina
        '
        'ESNomina
        '
        Me.ESNomina.DataSetName = "ESNomina"
        Me.ESNomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.PuestoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ES_Nomina.ESNominaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdEmpleadosDataGridViewTextBoxColumn
        '
        Me.IdEmpleadosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdEmpleadosDataGridViewTextBoxColumn.DataPropertyName = "idEmpleados"
        Me.IdEmpleadosDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdEmpleadosDataGridViewTextBoxColumn.Name = "IdEmpleadosDataGridViewTextBoxColumn"
        Me.IdEmpleadosDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpleadosDataGridViewTextBoxColumn.Width = 50
        '
        'NombreEmpleadoDataGridViewTextBoxColumn
        '
        Me.NombreEmpleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "Empleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.Name = "NombreEmpleadoDataGridViewTextBoxColumn"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MostrarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 354)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(1085, 265)
        Me.Name = "MostrarEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Empleados"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ESNomina As ESNomina
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ESNominaTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ESNominaTableAdapters.TableAdapterManager
    Friend WithEvents IdEmpleadosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
