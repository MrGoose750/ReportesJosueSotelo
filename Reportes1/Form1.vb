Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form1

    Dim tblEmp As New DBRH_ds.JobEmployeeDataTable
    Dim rptEmpleados As New DBRH_dsTableAdapters.JobEmployeeTableAdapter
    Dim tbl As New DataTable

    Sub llenarGrid()
        rptEmpleados.Fill(tblEmp)
        DgvRegistros.DataSource = tblEmp
        DgvRegistros.Refresh()
        GroupBox2.Text = "Registros guardados: " & tblEmp.Rows.Count
    End Sub


    Private Function CrearTabla(query) As DataTable
        Dim tbl As New DataTable
        tbl = New DataTable("tblEmp")

        tbl.Columns.Add("job_title")
        tbl.Columns.Add("first_name")
        tbl.Columns.Add("last_name")
        tbl.Columns.Add("email")
        tbl.Columns.Add("phone_number")
        tbl.Columns.Add("hire_date")
        tbl.Columns.Add("salary")

        Dim fila As DataRow
        For Each emp In query
            fila = tbl.NewRow
            fila("job_title") = emp.job_title
            fila("first_name") = emp.first_name
            fila("last_name") = emp.last_name
            fila("email") = emp.email
            fila("phone_number") = emp.phone_number
            fila("hire_date") = emp.hire_date
            fila("salary") = emp.salary
            tbl.Rows.Add(fila)
        Next
        Return tbl
    End Function

    Private Sub RealizarBusqueda()
        Dim dato As String = TxtDato.Text & "*"
        Dim campo As String = "emp.job_title"
        Dim query = From emp In tblEmp Select emp.job_title, emp.first_name, emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary

        Select Case CmbCampo.SelectedIndex
            Case -1 Or 0
                query = From emp In tblEmp Where emp.job_title Like dato Select emp.job_title, emp.first_name,
                        emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary
            Case 1
                query = From emp In tblEmp Where emp.first_name Like dato Select emp.job_title, emp.first_name,
                        emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary
        End Select

        tbl = CrearTabla(query)

        DgvRegistros.DataSource = tbl
        DgvRegistros.Refresh()
        GroupBox2.Text = "Registros encontrados: " & tbl.Rows.Count

    End Sub

    Sub verReportes(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVistaPrevia.ReportViewer1.LocalReport.ReportPath = nombreRpt
            FrmVistaPrevia.ReportViewer1.Refresh()
            FrmVistaPrevia.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar reporte")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        RealizarBusqueda()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        verReportes(tbl, "DsReportes", "Reportes\rptEmpleadoTrabajo.rdlc")
    End Sub
End Class
