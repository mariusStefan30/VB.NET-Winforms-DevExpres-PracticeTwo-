Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddEmployee = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUpdateEmployee = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteEmployee = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbOne = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rbnOne = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbnTwo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.gridControlEmployees = New DevExpress.XtraGrid.GridControl()
        Me.gridViewEmployees = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.teLastName = New DevExpress.XtraEditors.TextEdit()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.tePhone = New DevExpress.XtraEditors.TextEdit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControlEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.btnAddEmployee, Me.btnExit, Me.btnUpdateEmployee, Me.btnDeleteEmployee, Me.btnRefresh, Me.BarButtonItem2})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 7
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbOne})
        Me.ribbonControl1.Size = New System.Drawing.Size(1463, 158)
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Caption = "Add Employee"
        Me.btnAddEmployee.Id = 1
        Me.btnAddEmployee.ImageOptions.Image = CType(resources.GetObject("btnAddEmployee.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddEmployee.ImageOptions.LargeImage = CType(resources.GetObject("btnAddEmployee.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnExit
        '
        Me.btnExit.Caption = "Exit"
        Me.btnExit.Id = 2
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.LargeImage = CType(resources.GetObject("btnExit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Caption = "Update Employee"
        Me.btnUpdateEmployee.Id = 3
        Me.btnUpdateEmployee.ImageOptions.Image = CType(resources.GetObject("btnUpdateEmployee.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdateEmployee.ImageOptions.LargeImage = CType(resources.GetObject("btnUpdateEmployee.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.Caption = "Delete Employee"
        Me.btnDeleteEmployee.Id = 4
        Me.btnDeleteEmployee.ImageOptions.Image = CType(resources.GetObject("btnDeleteEmployee.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteEmployee.ImageOptions.LargeImage = CType(resources.GetObject("btnDeleteEmployee.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 5
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.LargeImage = CType(resources.GetObject("btnRefresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Report"
        Me.BarButtonItem2.Id = 6
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'rbOne
        '
        Me.rbOne.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rbnOne, Me.rbnTwo})
        Me.rbOne.Name = "rbOne"
        Me.rbOne.Text = "Home"
        '
        'rbnOne
        '
        Me.rbnOne.ItemLinks.Add(Me.btnAddEmployee)
        Me.rbnOne.ItemLinks.Add(Me.btnUpdateEmployee)
        Me.rbnOne.ItemLinks.Add(Me.btnDeleteEmployee)
        Me.rbnOne.ItemLinks.Add(Me.btnRefresh)
        Me.rbnOne.ItemLinks.Add(Me.BarButtonItem2)
        Me.rbnOne.Name = "rbnOne"
        '
        'rbnTwo
        '
        Me.rbnTwo.ItemLinks.Add(Me.btnExit)
        Me.rbnTwo.Name = "rbnTwo"
        '
        'gridControlEmployees
        '
        Me.gridControlEmployees.Location = New System.Drawing.Point(12, 202)
        Me.gridControlEmployees.MainView = Me.gridViewEmployees
        Me.gridControlEmployees.MenuManager = Me.ribbonControl1
        Me.gridControlEmployees.Name = "gridControlEmployees"
        Me.gridControlEmployees.Size = New System.Drawing.Size(1439, 649)
        Me.gridControlEmployees.TabIndex = 1
        Me.gridControlEmployees.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewEmployees})
        '
        'gridViewEmployees
        '
        Me.gridViewEmployees.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName, Me.colLastName, Me.colEmail, Me.colPhone})
        Me.gridViewEmployees.GridControl = Me.gridControlEmployees
        Me.gridViewEmployees.Name = "gridViewEmployees"
        '
        'colFirstName
        '
        Me.colFirstName.Caption = "First Name"
        Me.colFirstName.FieldName = "FirstName"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.Visible = True
        Me.colFirstName.VisibleIndex = 0
        '
        'colLastName
        '
        Me.colLastName.Caption = "Last Name"
        Me.colLastName.FieldName = "LastName"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.Visible = True
        Me.colLastName.VisibleIndex = 1
        '
        'colEmail
        '
        Me.colEmail.Caption = "Email"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 2
        '
        'colPhone
        '
        Me.colPhone.Caption = "Phone"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 3
        '
        'teFirstName
        '
        Me.teFirstName.EditValue = "First Name"
        Me.teFirstName.Location = New System.Drawing.Point(12, 165)
        Me.teFirstName.MenuManager = Me.ribbonControl1
        Me.teFirstName.Name = "teFirstName"
        Me.teFirstName.Size = New System.Drawing.Size(188, 20)
        Me.teFirstName.TabIndex = 2
        '
        'teLastName
        '
        Me.teLastName.EditValue = "Last Name"
        Me.teLastName.Location = New System.Drawing.Point(217, 165)
        Me.teLastName.MenuManager = Me.ribbonControl1
        Me.teLastName.Name = "teLastName"
        Me.teLastName.Size = New System.Drawing.Size(253, 20)
        Me.teLastName.TabIndex = 3
        '
        'teEmail
        '
        Me.teEmail.EditValue = "Email"
        Me.teEmail.Location = New System.Drawing.Point(487, 164)
        Me.teEmail.MenuManager = Me.ribbonControl1
        Me.teEmail.Name = "teEmail"
        Me.teEmail.Size = New System.Drawing.Size(284, 20)
        Me.teEmail.TabIndex = 4
        '
        'tePhone
        '
        Me.tePhone.EditValue = "Phone"
        Me.tePhone.Location = New System.Drawing.Point(777, 165)
        Me.tePhone.MenuManager = Me.ribbonControl1
        Me.tePhone.Name = "tePhone"
        Me.tePhone.Size = New System.Drawing.Size(262, 20)
        Me.tePhone.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1463, 863)
        Me.Controls.Add(Me.tePhone)
        Me.Controls.Add(Me.teEmail)
        Me.Controls.Add(Me.teLastName)
        Me.Controls.Add(Me.teFirstName)
        Me.Controls.Add(Me.gridControlEmployees)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Employees"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControlEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents rbOne As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents rbnOne As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAddEmployee As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gridControlEmployees As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewEmployees As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents teFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbnTwo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnUpdateEmployee As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteEmployee As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
End Class
