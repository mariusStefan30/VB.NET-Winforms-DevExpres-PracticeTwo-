Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI
Public Class ReportForm
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.DesignerLoaded
        Dim report As New XtraReport
        report.DataSource = GetReportData()
        Dim docView As New DocumentViewer
        docView.DocumentSource = report
        report.CreateDocument()
    End Sub

    Private Function GEtReportData() As DataTable
        Dim employeeBLL As New EmployeeBLL
        Return employeeBLL.GetEmployees()
    End Function
End Class