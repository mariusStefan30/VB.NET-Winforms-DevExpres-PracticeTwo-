Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraRichEdit.API.Native.Implementation

Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private employeeBLL As New EmployeeBLL
    'selected employee
    Private selectedEmployeeID As Integer
    'new repository item text edit
    Dim rite_firstName As New RepositoryItemTextEdit
    Dim rite_lastName As New RepositoryItemTextEdit
    Dim rite_Email As New RepositoryItemTextEdit
    Dim rite_Phone As New RepositoryItemTextEdit



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()

        'AddHandler gridViewEmployees.FocuseRowChanged, AddressOf FocusedRowChange
    End Sub

    Private Sub LoadEmployees()
        gridControlEmployees.DataSource = employeeBLL.GetEmployees()
    End Sub

    'Private Sub AssignRepToGridColumns()
    '    'Assign Repository text edit to grid column
    '    Dim fistNameCol As Columns.GridColumn = gridViewEmployees.Columns("colFirstName")
    '    fistNameCol.ColumnEdit = rite_firstName

    '    Dim lastNameCol As Columns.GridColumn = gridViewEmployees.Columns("colLastName")
    '    lastNameCol.ColumnEdit = rite_lastName

    '    Dim emailCol As Columns.GridColumn = gridViewEmployees.Columns("colEmail")
    '    emailCol.ColumnEdit = rite_Email

    '    Dim phoneCol As Columns.GridColumn = gridViewEmployees.Columns("colPhone")
    '    phoneCol.ColumnEdit = rite_Phone
    'End Sub

    Private Sub btnAddEmployee_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddEmployee.ItemClick
        'AssignRepToGridColumns() 'in progress

        Dim firstName As String = teFirstName.Text ' gridViewEmployees.Columns("colFirstName").ToString 
        Dim lastName As String = teLastName.Text
        Dim email As String = teEmail.Text
        Dim phone As String = tePhone.Text

        employeeBLL.AddNewEmployee(firstName, lastName, email, phone)
        LoadEmployees()
    End Sub

    Private Sub btnExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExit.ItemClick
        Me.Close()
    End Sub

    Private Sub btnUpdateEmployee_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUpdateEmployee.ItemClick
        Dim firstName As String = teFirstName.Text
        Dim lastName As String = teLastName.Text
        Dim email As String = teEmail.Text
        Dim phone As String = tePhone.Text

        employeeBLL.UpdateEmployee(selectedEmployeeID, firstName, lastName, email, phone)
        LoadEmployees()
    End Sub

    Private Sub btnDeleteEmployee_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteEmployee.ItemClick
        employeeBLL.DeleteEmployee(selectedEmployeeID)
        LoadEmployees()
    End Sub

    Private Sub gridViewEmployees_FocusedRowChanged(sender As Object, e As Views.Base.FocusedRowChangedEventArgs) Handles gridViewEmployees.FocusedRowChanged
        Dim gridView As GridView = CType(sender, GridView)
        If gridView.IsDataRow(e.FocusedRowHandle) Then
            Dim row As DataRow = gridView.GetDataRow(e.FocusedRowHandle)
            selectedEmployeeID = Convert.ToInt32(row("EmployeeID"))
            teFirstName.Text = row("FirstName").ToString
            teLastName.Text = row("LastName").ToString
            teEmail.Text = row("Email").ToString
            tePhone.Text = row("Phone").ToString
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        LoadEmployees()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim report As New ReportForm
        'report.ShowPreview()
        report.ShowPreviewDialog

    End Sub
End Class
