Imports System.Data.SqlClient
Public Class Report_Form_Admission

    Dim d As New Db
    Dim dept_id As String = ""
    Dim course_name As String = ""
    Dim course_year As String = ""
    Dim ad_date As String = ""

    Private Sub Report_Form_Admission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If d.Query_select("select distinct(year(Admission_Date)) from Student_Master order by year(Admission_Date) desc") Then

                ComboBox1.Items.Add("All")
                ComboBox1.Items.Add(d.dr(0))
                While d.dr.Read
                    ComboBox1.Items.Add(d.dr(0))

                End While
                ComboBox1.SelectedIndex = 0
            End If
            If d.Query_select("select  Dept_Name from Department_Master where Dept_Type = 0") Then
                ComboBox2.Items.Add("All")
                ComboBox2.Items.Add(d.dr(0))
                While d.dr.Read
                    ComboBox2.Items.Add(d.dr(0))

                End While
                ComboBox2.SelectedIndex = 0
                dept_id = ""
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            If 0 < ComboBox2.SelectedIndex Then
                If d.Query_select("select Course_Name from Course_Master where Dept_Id=(select Dept_Id from Department_Master where Dept_Name='" & ComboBox2.Text & "')") Then
                    ComboBox3.Items.Clear()
                    ComboBox3.Items.Add("All")
                    ComboBox3.Items.Add(d.dr(0))
                    While d.dr.Read
                        ComboBox3.Items.Add(d.dr(0))
                    End While
                    ComboBox3.SelectedIndex = 0
                    If d.Query_select("select Dept_Id from Department_Master where Dept_Name='" & ComboBox2.Text & "'") Then
                        dept_id = d.dr(0)
                    End If
                End If
            ElseIf 0 = ComboBox2.SelectedIndex Then
                ComboBox3.Items.Clear()
                ComboBox3.Items.Add("All")
                ComboBox3.SelectedIndex = 0
                dept_id = ""
            End If
        Catch ex As Exception
            msg(ex)
        End Try


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            If 0 = ComboBox3.SelectedIndex Then
                ComboBox4.Items.Clear()
                ComboBox4.Items.Add("All")
                ComboBox4.SelectedIndex = 0
                course_name = ""
            ElseIf 0 < ComboBox3.SelectedIndex Then
                If d.Query_select("select Years from Course_Master where Course_Name='" & ComboBox3.Text & "'") Then
                    ComboBox4.Items.Clear()
                    ComboBox4.Items.Add("All")
                    For i As Integer = 1 To d.dr(0)
                        ComboBox4.Items.Add(i)
                    Next
                    ComboBox4.SelectedIndex = 0
                    course_name = ComboBox3.Text
                End If
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cr As New CrystalReportAdmission
            Dim str = "select s.*,c.*,d.* from Student_Master s inner join Course_Master c on s.Course_Id=c.Course_Id inner join Department_Master d on c.Dept_Id = d.Dept_Id where YEAR(s.Admission_Date) like '%" & ad_date & "%' and c.Course_Name like '%" & course_name & "%' and s.Course_Year like '%" & course_year & "%' and c.Dept_Id like '%" & dept_id & "%'"
            d.Connection_close()
            d.Connection_open()
            d.da = New SqlDataAdapter(str, d.con)
            Dim ds As New DataSet
            d.da.Fill(ds, "View_Student")
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            cr.Refresh()
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If 0 = ComboBox1.SelectedIndex Then
                ad_date = ""
            ElseIf 0 < ComboBox1.SelectedIndex Then
                ad_date = ComboBox1.Text
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            If 0 = ComboBox4.SelectedIndex Then
                course_year = ""
            ElseIf 0 < ComboBox4.SelectedIndex Then
                course_year = ComboBox4.SelectedIndex
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
End Class