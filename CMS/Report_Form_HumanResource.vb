Imports System.Data.SqlClient
Public Class Report_Form_HumanResource

    Dim d As New Db
    Dim s As String = ""
    Dim type As String = ""

    Private Sub Report_Form_HumanResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If d.Query_select("select distinct(year(Date)) from Employee_Master order by (year(Date)) desc") Then
                ComboBox1.Items.Add("All")
                ComboBox1.Items.Add(d.dr(0))
                While d.dr.Read
                    ComboBox1.Items.Add(d.dr(0))
                End While
                ComboBox1.SelectedIndex = 0
            End If
            ComboBox2.SelectedIndex = 0
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cr As New CrystalReportHumanResource
            Dim str As String = "select * from Employee_Master e inner join Department_Master d  on e.Department = d.Dept_Id inner join Designation_Master deg on e.Designation = deg.Designation_Id where YEAR(e.Date) like '%" & s & "%' and d.Dept_Type like '%" & type & "%'"
            Dim ds As New DataSet
            d.Connection_close()
            d.Connection_open()
            d.da = New SqlDataAdapter(str, d.con)
            d.da.Fill(ds, "View2")
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If 0 = ComboBox1.SelectedIndex Then
                s = ""
            Else
                s = ComboBox1.Text
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            If 0 = ComboBox2.SelectedIndex Then
                type = ""
            ElseIf 1 = ComboBox2.SelectedIndex Then
                type = 1
            ElseIf 2 = ComboBox2.SelectedIndex Then
                type = 0
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
End Class