Public Class FrmVistaPrevia
    Private Sub FrmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBRH_ds.JobEmployee' Puede moverla o quitarla según sea necesario.
        Me.JobEmployeeTableAdapter.Fill(Me.DBRH_ds.JobEmployee)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class