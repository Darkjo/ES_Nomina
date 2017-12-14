Public Class Reporte2
    Private Sub Reporte2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ESNominaDataSetReportes.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.ESNominaDataSetReportes.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class