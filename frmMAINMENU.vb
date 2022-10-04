Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmMAINMENU
    Dim dtable As New DataTable
    Dim conn As New MySqlConnection(“server=localhost; user=root; password=enjoyyourachievements; database=police_clearance_db;”)
    Private Sub frmMAINMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim adptr As New MySqlDataAdapter("select *from user", conn)
        adptr.Fill(dtable)
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim rprtr As New ReportDataSource("Data", dtable)
        ReportViewer1.LocalReport.DataSources.Add(rprtr)
        ReportViewer1.RefreshReport()
    End Sub
End Class
