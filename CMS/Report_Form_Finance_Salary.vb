Imports System.Data.SqlClient
Public Class Report_Form_Finance_Salary

    Dim d As New Db
    Dim emp_id As String = ""
    Dim dept_name As String = ""
    Dim yr As String = ""
    Dim mnth As String = ""
    Dim dept_type As String = ""

    Private Sub Report_Form_Finance_Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If d.Query_select("select  distinct(year(Salary_Date)) from Salary_Details order by Year(Salary_Date) desc") Then

                ComboBox1.Items.Add("All")
                ComboBox1.Items.Add(d.dr(0))
                While d.dr.Read

                    ComboBox1.Items.Add(d.dr(0))

                End While
                ComboBox1.SelectedIndex = 0

            End If
            ComboBox2.Items.Add("All")
            For i As Integer = 1 To 12
                ComboBox2.Items.Add(MonthName(i))
            Next
            ComboBox2.SelectedIndex = 0
            ComboBox3.SelectedIndex = 0
            ComboBox5.SelectedIndex = 0
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            If 1 = ComboBox3.SelectedIndex Then

                If d.Query_select("select  Dept_Name from Department_Master where Dept_Type =0 ") Then
                    ComboBox4.Items.Clear()
                    ComboBox4.Items.Add("All")
                    ComboBox4.Items.Add(d.dr(0))
                    While d.dr.Read
                        ComboBox4.Items.Add(d.dr(0))
                    End While
                    ComboBox4.SelectedIndex = 0
                End If
                dept_type = "0"

            ElseIf 2 = ComboBox3.SelectedIndex Then
                If d.Query_select("select  Dept_Name from Department_Master where Dept_Type =1") Then
                    ComboBox4.Items.Clear()
                    ComboBox4.Items.Add("All")
                    ComboBox4.Items.Add(d.dr(0))
                    While d.dr.Read
                        ComboBox4.Items.Add(d.dr(0))
                    End While
                    ComboBox4.SelectedIndex = 0
                End If
                dept_type = "1"


            ElseIf 0 = ComboBox3.SelectedIndex Then
                ComboBox4.Items.Clear()
                ComboBox4.Items.Add("All")
                ComboBox4.SelectedIndex = 0
                dept_type = ""

            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try
            If ComboBox5.SelectedIndex = 0 Then
                TextBox1.Enabled = False
                'Button2.Enabled = False
                ComboBox2.Enabled = True
                ComboBox3.Enabled = True
                ComboBox4.Enabled = True
                Button1.Enabled = True
                TextBox1.Clear()
            ElseIf ComboBox5.SelectedIndex = 1 Then
                TextBox1.Enabled = True
                ' Button2.Enabled = True
                ComboBox2.Enabled = False
                ComboBox3.Enabled = False
                ComboBox4.Enabled = False
                Button1.Enabled = False
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cr As New CrystalReportFinance_Salary
            Dim str As String = "select * from Employee_Master e inner join Salary_Details s on e.Emp_Id=s.Emp_Id inner join Designation_Master deg on e.Designation=deg.Designation_Id inner join Department_Master d on e.Department=d.Dept_Id where e.Emp_Id like '%" & TextBox1.Text & "%' and YEAR(s.Salary_Date) like '%" & yr & "%' and MONTH(Salary_Date) like '%" & mnth & "%' and d.Dept_Type LIKE '%" & dept_type & "%' and d.Dept_Name like '%" & dept_name & "%'"
            d.Connection_close()
            d.Connection_open()
            d.da = New SqlDataAdapter(str, d.con)
            Dim ds As New DataSet
            d.da.Fill(ds, "View_Salary")
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            cr.Refresh()
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If IsNumeric(TextBox1.Text) Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
                TextBox1.Clear()
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.SelectedIndex > 0 Then
                yr = ComboBox1.Text
            ElseIf ComboBox1.SelectedIndex = 0 Then
                yr = ""
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            If ComboBox2.SelectedIndex > 0 Then
                mnth = ComboBox2.SelectedIndex
            ElseIf ComboBox2.SelectedIndex = 0 Then
                mnth = ""
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            If ComboBox4.SelectedIndex = 0 Then
                dept_name = ""
            ElseIf ComboBox4.SelectedIndex > 0 Then
                dept_name = ComboBox4.Text
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
End Class