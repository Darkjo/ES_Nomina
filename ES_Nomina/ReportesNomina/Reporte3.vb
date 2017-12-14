Public Class Reporte3
    Private Sub Reporte3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ESNominaDataSetReportes.DataTable2' table. You can move, or remove it, as needed.
        Me.DataTable2TableAdapter.Fill(Me.ESNominaDataSetReportes.DataTable2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class