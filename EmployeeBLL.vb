

Public Class EmployeeBLL

    Private employeeDAL As New EmployeeDAL

    Public Function GetEmployees() As DataTable
        Return employeeDAL.GetAllEmployees()
    End Function

    Public Sub AddNewEmployee(firstName As String, lastName As String, email As String, phone As String)
        'simple validation
        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(phone) Then
            MessageBox.Show("All fields required.")
        End If
        employeeDAL.AddEmployee(firstName, lastName, email, phone)
    End Sub

    Public Sub UpdateEmployee(employeeID As Integer, firstName As String, lastName As String, email As String, phone As String)
        'simple validation
        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(phone) Then
            MessageBox.Show("All fields required.")
        End If
        employeeDAL.UpdateEmployee(employeeID, firstName, lastName, email, phone)
    End Sub

    Public Sub DeleteEmployee(employeeID As Integer)
        employeeDAL.DeleteEmployee(employeeID)
    End Sub


End Class
