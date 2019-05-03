Imports System.Data.SqlClient
Public Class Report_Form_LibraryPendingBooks

    Dim d As New Db
    Dim Str As String

    Private Sub pb_rb_student_CheckedChanged(sender As Object, e As EventArgs) Handles pb_rb_student.CheckedChanged
        Try
            Dim cr As New CrystalReportPendingBook
            Str = "select * from Student_Master s inner join Library_Master l on s.Library_Id = l.Library_Id where l.Books_Taken !=0"
            d.Connection_close()
            d.Connection_open()
            d.da = New SqlDataAdapter(Str, d.con)
            Dim ds As New DataSet
            d.da.Fill(ds, "View_Student_Library")
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub pb_rb_emp_CheckedChanged(sender As Object, e As EventArgs) Handles pb_rb_emp.CheckedChanged
        Try
            Dim cr As New CrystalReportPndingBookEmployee
            Str = "select * from Employee_Master s inner join Library_Master l on s.Library_Id = l.Library_Id where l.Books_Taken !=0"
            d.Connection_close()
            d.Connection_open()
            d.da = New SqlDataAdapter(Str, d.con)
            Dim ds As New DataSet
            d.da.Fill(ds, "View_Employee_Library")
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
End Class