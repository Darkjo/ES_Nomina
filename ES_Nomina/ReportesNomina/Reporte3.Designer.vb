Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ESNominaDataSetReportes = New ES_Nomina.ESNominaDataSetReportes()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2TableAdapter = New ES_Nomina.ESNominaDataSetReportesTableAdapters.DataTable2TableAdapter()
        CType(Me.ESNominaDataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ES_Nomina.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(955, 647)
        Me.ReportViewer1.TabIndex = 0
        '
        'ESNominaDataSetReportes
        '
        Me.ESNominaDataSetReportes.DataSetName = "ESNominaDataSetReportes"
        Me.ESNominaDataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.ESNominaDataSetReportes
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'Reporte3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 649)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte3"
        Me.Text = "Reporte3"
        CType(Me.ESNominaDataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents ESNominaDataSetReportes As ESNominaDataSetReportes
    Friend WithEvents DataTable2TableAdapter As ESNominaDataSetReportesTableAdapters.DataTable2TableAdapter
End Class
