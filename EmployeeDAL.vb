Imports System.Data.SqlClient

Public Class EmployeeDAL
    Private connectionString As String = "Server=DESKTOP-590UT35\SQLEXPRESS;Initial Catalog=ERP_DB;Integrated Security=True;"

    Public Function GetAllEmployees() As DataTable
        Dim query As String = "Select * From Employees"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                Return dt
                conn.Close()
            End Using
        End Using

    End Function

    Public Sub AddEmployee(fistName As String, lastName As String, email As String, phone As String)
        Dim query As String = "Insert into Employees (FirstName, LastName, Email, Phone) Values (@FirstName, @LastName, @Email, @Phone)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FirstName", fistName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Phone", phone)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Public Sub UpdateEmployee(employeeId As Integer, fistName As String, lastName As String, email As String, phone As String)
        Dim query As String = "Update Employees Set FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone Where EmployeeID = @EmployeeID"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId)
                cmd.Parameters.AddWithValue("@FirstName", fistName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Phone", phone)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Public Sub DeleteEmployee(employeeId As Integer)
        Dim query As String = "Delete From Employees Where EmployeeID = @EmployeeID"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub
End Class
