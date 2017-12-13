<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPuesto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ESNomina = New ES_Nomina.ESNomina()
        Me.PuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuestoTableAdapter = New ES_Nomina.ESNominaTableAdapters.PuestoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ESNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Añadir Puestos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Puesto:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(109, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 28)
        Me.TextBox1.TabIndex = 2
        '
        'ESNomina
        '
        Me.ESNomina.DataSetName = "ESNomina"
        Me.ESNomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PuestoBindingSource
        '
        Me.PuestoBindingSource.DataMember = "Puesto"
        Me.PuestoBindingSource.DataSource = Me.ESNomina
        '
        'PuestoTableAdapter
        '
        Me.PuestoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(109, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPuestoDataGridViewTextBoxColumn, Me.NombrePuestoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PuestoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(329, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'IdPuestoDataGridViewTextBoxColumn
        '
        Me.IdPuestoDataGridViewTextBoxColumn.DataPropertyName = "idPuesto"
        Me.IdPuestoDataGridViewTextBoxColumn.HeaderText = "idPuesto"
        Me.IdPuestoDataGridViewTextBoxColumn.Name = "IdPuestoDataGridViewTextBoxColumn"
        Me.IdPuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombrePuestoDataGridViewTextBoxColumn
        '
        Me.NombrePuestoDataGridViewTextBoxColumn.DataPropertyName = "NombrePuesto"
        Me.NombrePuestoDataGridViewTextBoxColumn.HeaderText = "NombrePuesto"
        Me.NombrePuestoDataGridViewTextBoxColumn.Name = "NombrePuestoDataGridViewTextBoxColumn"
        Me.NombrePuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmPuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 374)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puestos"
        CType(Me.ESNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ESNomina As ESNomina
    Friend WithEvents PuestoBindingSource As BindingSource
    Friend WithEvents PuestoTableAdapter As ESNominaTableAdapters.PuestoTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdPuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrePuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
