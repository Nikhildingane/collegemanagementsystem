Public Class Form_Finance
    Dim d As New Db
    Dim fee_id As Double
    Dim sal_per_day As Double
    Dim sal_for_days As Integer
    Dim dept, course, course_year, ayear As String
    Private Sub Form_Finance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lbusername.Text = uname
            lbdepartment.Text = department
            fc_tb_fee_date.Text = Today
            es_tb_salary_date.Text = Date.Today
            If Month(Date.Today) > 1 Then
                es_tb_salary_month.Text = MonthName(Month(Date.Today) - 1)
            ElseIf Month(Date.Today) = 1 Then
                es_tb_salary_month.Text = MonthName(12)
            End If
            If d.Query_select("select distinct(Year(Admission_Date)) from Student_Master") Then
                pf_cb_year.Items.Add("All")
                pf_cb_year.Items.Add(d.dr(0))
                While d.dr.Read()
                    pf_cb_year.Items.Add(d.dr(0))
                End While

            End If
            If pf_cb_year.Items.Count > 0 Then
                pf_cb_year.SelectedIndex = 0
            End If
            If d.Query_select("select Dept_Name from Department_Master where Dept_Type=0") Then
                pf_cb_dept.Items.Add("All")
                pf_cb_dept.Items.Add(d.dr("Dept_Name").ToString)
                While d.dr.Read()
                    pf_cb_dept.Items.Add(d.dr("Dept_Name").ToString)
                End While
                pf_cb_dept.SelectedIndex = 0
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub


    Private Sub fin_btn_fc_Click(sender As Object, e As EventArgs) Handles fin_btn_fc.Click
        Try
            FinanceFeeCollection.Visible = True
            FinanceViewStudentFees.Visible = False
            FinanceEmployeeFacultySalaryPayment.Visible = False

            sp_fc.Visible = True
            sp_vsf.Visible = False
            sp_esp.Visible = False

            fin_btn_fc.BackColor = Color.FromArgb(63, 63, 70)
            fin_btn_vsf.BackColor = side.BackColor
            fin_btn_esp.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub fin_btn_vsf_Click(sender As Object, e As EventArgs) Handles fin_btn_vsf.Click
        Try
            FinanceFeeCollection.Visible = False
            FinanceViewStudentFees.Visible = True
            FinanceEmployeeFacultySalaryPayment.Visible = False

            sp_fc.Visible = False
            sp_vsf.Visible = True
            sp_esp.Visible = False

            fin_btn_fc.BackColor = side.BackColor
            fin_btn_vsf.BackColor = Color.FromArgb(63, 63, 70)
            fin_btn_esp.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub fin_btn_esp_Click(sender As Object, e As EventArgs) Handles fin_btn_esp.Click
        Try
            FinanceFeeCollection.Visible = False
            FinanceViewStudentFees.Visible = False
            FinanceEmployeeFacultySalaryPayment.Visible = True

            sp_fc.Visible = False
            sp_vsf.Visible = False
            sp_esp.Visible = True

            fin_btn_fc.BackColor = side.BackColor
            fin_btn_vsf.BackColor = side.BackColor
            fin_btn_esp.BackColor = Color.FromArgb(63, 63, 70)
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub



    Private Sub fc_btn_search_Click(sender As Object, e As EventArgs) Handles fc_btn_search.Click
        Try
            If IsNumeric(fc_tb_student_id.Text) Then
                If d.Query_select("select s.First_Name,s.Middle_Name,s.Surname,c.Course_Name,c.Fee,s.Course_Year,f.Paid_Fee,f.Remaining_Fee,c.Dept_Id,f.Fee_Id from Student_Master s inner join Course_Master c on s.Course_Id=c.Course_Id inner join Fee_Master f on s.Id=f.Stud_Id where f.Fee_Id=(select max(Fee_Id) from Fee_Master where Stud_Id=" & fc_tb_student_id.Text & ") and s.Id=" & fc_tb_student_id.Text & "") Then

                    fc_tb_student_name.Text = d.dr(0)
                    fc_tb_student_mn.Text = d.dr(1)
                    fc_tb_student_ln.Text = d.dr(2)
                    fc_tb_student_course.Text = d.dr(3)
                    fc_tb_course_fee.Text = d.dr(4)
                    fc_tb_student_course_year.Text = d.dr(5)
                    fc_tb_paid_fee.Text = d.dr(6)
                    fc_tb_remaining_fee.Text = d.dr(7)
                    Dim dept_id As Integer = d.dr(8)
                    fee_id = d.dr(9)
                    fc_tb_fee_to_pay.Text = fc_tb_remaining_fee.Text
                    If d.dr(7) <> 0 Then
                        fc_tb_fee_to_pay.Enabled = True
                        fc_tb_fee_to_pay.Focus()
                        fc_btn_collect.Enabled = True
                    ElseIf d.dr(7) = 0 Then
                        MessageBox.Show("Fee was already paid")
                        fc_tb_fee_to_pay.Enabled = False
                        fc_tb_fee_to_pay.Clear()
                        fc_btn_collect.Enabled = False
                    End If
                    d.Query_select("select Dept_Name from Department_Master where Dept_Id=" & dept_id & "")
                    fc_tb_student_dept.Text = d.dr(0)
                Else
                    MessageBox.Show("Student ID not Found!!")
                End If
            Else
                MessageBox.Show("Please enter valid student ID!!")
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub fc_btn_collect_Click(sender As Object, e As EventArgs) Handles fc_btn_collect.Click
        Try
            If IsNumeric(fc_tb_fee_to_pay.Text) And fc_tb_fee_to_pay.Text <= fc_tb_remaining_fee.Text And fc_tb_fee_to_pay.Text > 0 Then
                If d.Query_insert_update("insert into Fee_Details(Fee_Id,Ammount,Date) values(" & fee_id & "," & fc_tb_fee_to_pay.Text & ",'" & Date.Today.ToString("yyyy-MM-dd") & "')") And d.Query_insert_update("update Fee_Master set Paid_Fee=(Paid_Fee+" & fc_tb_fee_to_pay.Text & "),Remaining_Fee=(Remaining_Fee-" & fc_tb_fee_to_pay.Text & ") where Fee_Id =" & fee_id & "") Then
                    MessageBox.Show("collected")
                    fc_tb_student_id.Clear()
                    fc_btn_clear.PerformClick()
                    fc_btn_collect.Enabled = False
                Else
                    MessageBox.Show("Unabled to collect")
                End If
            Else
                MessageBox.Show("Please enter valid fee ammount!!")
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub es_btn_search_Click(sender As Object, e As EventArgs) Handles es_btn_search.Click
        Try
            If IsNumeric(es_tb_emp_id.Text) Then
                If d.Query_select("select e.First_Name,e.Middle_Name,e.Surname,e.Phone,p.Salary_Per_Day from Employee_Master e inner join Pay_Scale_Master p on e.Pay_Scale=p.Pay_Scale where e.Emp_Id=" & es_tb_emp_id.Text & "") Then
                    MessageBox.Show("Found")
                    es_tb_emp_name.Text = d.dr(0)
                    es_tb_emp_mn.Text = d.dr(1)
                    es_tb_emp_ln.Text = d.dr(2)
                    es_tb_emp_phone.Text = d.dr(3)
                    sal_per_day = d.dr(4)
                    cal_sal()
                    es_tb_leaves.Text = 0
                    es_tb_leaves.Focus()
                Else
                    MessageBox.Show("Not Found")
                End If
            Else
                MessageBox.Show("Please enter valid employee ID!!")
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub es_tb_leaves_TextChanged(sender As Object, e As EventArgs) Handles es_tb_leaves.TextChanged
        Try
            If Not IsNumeric(es_tb_leaves.Text) Then
                MessageBox.Show("Invalid Leaves Days")
                es_tb_leaves.Text = 0
                es_tb_leaves.Select()
                es_tb_leaves.Focus()
                cal_sal()
            ElseIf es_tb_leaves.Text = 0 Then
                cal_sal()
            Else
                es_tb_salary.Text = es_tb_salary.Text - (sal_per_day * es_tb_leaves.Text)
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
    Private Sub cal_sal()
        Try
            If (Month(Date.Today)) > 1 Then
                es_tb_salary.Text = Date.DaysInMonth(Year(Date.Today), Month(Date.Today) - 1) * sal_per_day
            ElseIf (Month(Date.Today)) = 1 Then
                es_tb_salary.Text = Date.DaysInMonth(Year(Date.Today) - 1, 12) * sal_per_day
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub es_btn_pay_Click(sender As Object, e As EventArgs) Handles es_btn_pay.Click
        Try
            If d.Query_select("select Salary_Month,Salary_Date from Salary_Details where Salary_Id=(select MAX(Salary_Id) from Salary_Details where Emp_Id = " & es_tb_emp_id.Text & ")") Then
                If d.dr(0) = es_tb_salary_month.Text And Year(d.dr(1)) = Year(Date.Today) Then
                    MessageBox.Show("Salary Already Paid")
                    es_btn_reset.PerformClick()
                Else
                    If d.Query_insert_update("insert into Salary_Details(Emp_Id,Salary_Month,leaves,Sal_For_Days,Salary,Salary_Date) values(" & es_tb_emp_id.Text & ",'" & es_tb_salary_month.Text & "'," & es_tb_leaves.Text & "," & sal_for_days & "," & es_tb_salary.Text & ",'" & Date.Today.ToString("yyyy-MM-dd") & "')") Then
                        MessageBox.Show("Salary Paid")
                        es_btn_reset.PerformClick()
                    Else
                        MessageBox.Show("Unbale to pay")
                    End If
                End If
            Else
                If d.Query_insert_update("insert into Salary_Details(Emp_Id,Salary_Month,leaves,Sal_For_Days,Salary,Salary_Date) values(" & es_tb_emp_id.Text & ",'" & es_tb_salary_month.Text & "'," & es_tb_leaves.Text & "," & sal_for_days & "," & es_tb_salary.Text & ",'" & Date.Today.ToString("yyyy-MM-dd") & "')") Then
                    MessageBox.Show("Salary Paid")
                    es_btn_reset.PerformClick()
                Else
                    MessageBox.Show("Unbale to pay")
                End If
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub pf_cb_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pf_cb_year.SelectedIndexChanged
        Try
            If pf_cb_year.SelectedIndex = 0 Then
                ayear = ""
            Else
                ayear = pf_cb_year.Text
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub pf_cb_course_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pf_cb_course_year.SelectedIndexChanged
        Try
            If pf_cb_course_year.SelectedIndex = 0 Then
                course_year = ""
            Else
                course_year = pf_cb_course_year.Text
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_report_fees_Click(sender As Object, e As EventArgs) Handles btn_report_fees.Click
        Report_Form_Finance_Fees.Show()
    End Sub

    Private Sub btn_report_salary_Click(sender As Object, e As EventArgs) Handles btn_report_salary.Click
        Report_Form_Finance_Salary.Show()
    End Sub

    Private Sub fc_btn_clear_Click(sender As Object, e As EventArgs) Handles fc_btn_clear.Click
        fc_tb_student_name.Clear()
        fc_tb_student_mn.Clear()
        fc_tb_student_ln.Clear()
        fc_tb_student_dept.Clear()
        fc_tb_student_course.Clear()
        fc_tb_course_fee.Clear()
        fc_tb_student_course_year.Clear()
        fc_tb_paid_fee.Clear()
        fc_tb_remaining_fee.Clear()
        fc_tb_fee_to_pay.Clear()
        fc_btn_collect.Enabled = False
    End Sub

    Private Sub es_btn_reset_Click(sender As Object, e As EventArgs) Handles es_btn_reset.Click
        es_tb_emp_ln.Clear()
        es_tb_emp_mn.Clear()
        es_tb_emp_name.Clear()
        es_tb_emp_phone.Clear()
        es_tb_leaves.Text = 0
        es_tb_salary.Clear()
        es_tb_salary.Enabled = False

    End Sub

    Private Sub es_tb_emp_id_TextChanged(sender As Object, e As EventArgs) Handles es_tb_emp_id.TextChanged
        es_btn_reset.PerformClick()
    End Sub

    Private Sub pf_btn_search_Click(sender As Object, e As EventArgs) Handles pf_btn_search.Click
        Try
            d.Fill_datagridview("select * from Student_Master s inner join Course_Master c on s.Course_Id=c.Course_Id inner join Fee_Master f on s.Id=f.Stud_Id where c.Course_Name like '%" & course & "%' and s.Course_Year like '%" & course_year & "%' and c.Dept_Id like '%" & dept & "%' and f.Remaining_Fee!=0 and YEAR(s.Admission_Date) like '%" & ayear & "%'")
            pf_dg.DataSource = d.table
            d.da.Update(d.table)
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub pf_cb_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pf_cb_dept.SelectedIndexChanged
        Try
            If pf_cb_dept.SelectedIndex <> 0 Then

                If d.Query_select("select Course_Name from Course_Master where Dept_Id=(select Dept_Id from Department_Master where Dept_Name='" & pf_cb_dept.Text & "')") Then
                    pf_cb_course.Items.Clear()
                    pf_cb_course.Items.Add("All")
                    pf_cb_course.Items.Add(d.dr(0))
                    While d.dr.Read()
                        pf_cb_course.Items.Add(d.dr(0))
                    End While
                    pf_cb_course.SelectedIndex = 0
                    If d.Query_select("select Dept_Id from Department_Master where Dept_Name='" & pf_cb_dept.Text & "'") Then
                        dept = d.dr(0)
                    End If
                End If
            ElseIf pf_cb_dept.SelectedIndex = 0 Then
                pf_cb_course.Items.Clear()
                pf_cb_course.Items.Add("All")
                pf_cb_course.SelectedIndex = 0
                dept = ""
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub pf_cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pf_cb_course.SelectedIndexChanged
        Try
            If pf_cb_course.SelectedIndex = 0 Then
                pf_cb_course_year.Items.Clear()
                pf_cb_course_year.Items.Add("All")
                pf_cb_course_year.SelectedIndex = 0
                course = ""
            Else
                pf_cb_course_year.Items.Clear()
                pf_cb_course_year.Items.Add("All")
                If d.Query_select("select Years from Course_Master where Course_Name='" & pf_cb_course.Text & "'") Then
                    For i As Integer = 1 To d.dr(0)
                        pf_cb_course_year.Items.Add(i)
                    Next
                    pf_cb_course_year.SelectedIndex = 0
                End If
                course = pf_cb_course.Text
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
End Class