Imports System.Data.SqlClient
Public Class Form_Admission

    Dim d As New Db
    Dim s As String
    Dim course_id As Integer
    Dim course_year As Integer = 1
    Dim course_fee As Integer = 0

    Private Sub Button_New_Admission_Click(sender As Object, e As EventArgs) Handles Button_New_Admission.Click
        Try
            AdmissionNewAdmission.Visible = True
            AdmissionUpdateStudent.Visible = False
            smallpanel_new_admission.Visible = True
            smallpanel_update.Visible = False
            Button_New_Admission.BackColor = Color.FromArgb(63, 63, 70)
            Button_Update_Student.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub Button_Update_Student_Click(sender As Object, e As EventArgs) Handles Button_Update_Student.Click
        Try
            AdmissionNewAdmission.Visible = False
            AdmissionUpdateStudent.Visible = True
            smallpanel_new_admission.Visible = False
            smallpanel_update.Visible = True
            Button_New_Admission.BackColor = side.BackColor
            Button_Update_Student.BackColor = Color.FromArgb(63, 63, 70)
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub Form_Admission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lbusername.Text = uname
            lbdepartment.Text = department
            clr()
            If Not IsDBNull(d.Auto_increment("select MAX(Id) from Student_Master")) Then
                ad_tb_stduent_id.Text = Integer.Parse(d.Auto_increment("select MAX(Id) from Student_Master")) + 1
            Else
                ad_tb_stduent_id.Text = 1
            End If
            ad_cb_department.Items.Clear()
            ad_cb_course.Items.Clear()
            If d.Query_select("select Dept_Name from Department_Master where Dept_Type = 0") Then
                ad_cb_department.Items.Add(d.dr(0))
                While d.dr.Read
                    ad_cb_department.Items.Add(d.dr(0))
                End While
            End If
        Catch ex As Exception
            msg(ex)
        End Try


    End Sub

    Private Sub ad_cb_department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ad_cb_department.SelectedIndexChanged
        Try
            If d.Query_select("select Course_Name from Course_Master where Dept_Id = (select Dept_Id from Department_Master where Dept_Name = '" & ad_cb_department.Text & "')") Then
                ad_cb_course.Items.Clear()
                ad_cb_course.Items.Add(d.dr(0))
                While d.dr.Read
                    ad_cb_course.Items.Add(d.dr(0))
                End While
            End If
        Catch ex As Exception
            msg(ex)
        End Try


    End Sub

    Private Sub ad_cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ad_cb_course.SelectedIndexChanged
        Try
            ad_cb_course_year.Text = ""
            If d.Query_select("select Years from Course_Master where Course_Name='" & ad_cb_course.Text & "'") Then
                ad_cb_course_year.Items.Clear()
                For i As Integer = 1 To d.dr(0)
                    ad_cb_course_year.Items.Add(i)
                Next
                ad_cb_course_year.SelectedIndex = 0
            End If
            If d.Query_select("select Course_Id from Course_Master where Course_Name='" & ad_cb_course.Text & "'") Then
                course_id = d.dr(0)
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            If ad_tb_application_no.Text <> "" And ad_tb_first_name.Text <> "" And ad_tb_middle_name.Text <> "" And ad_tb_last_name.Text <> "" And ad_tb_uin.Text <> "" And ad_cb_gender.Items.Contains(ad_cb_gender.Text) And ad_tb_nationality.Items.Contains(ad_tb_nationality.Text) And ad_cb_caste.Items.Contains(ad_cb_caste.Text) And ad_cb_department.Items.Contains(ad_cb_department.Text) And ad_cb_course.Items.Contains(ad_cb_course.Text) And IsNumeric(ad_tb_mob_no.Text) And IsNumeric(ad_tb_uin.Text) And IsNumeric(ad_tb_father_mob_no.Text) Then
                If d.Query_insert_update("INSERT Student_Master (Id,Application_Number,First_Name,Middle_Name,Surname,Gender,DOB,Nationality,Relegion,Cast_Name, Mob_No, Email, Address,UIN,Guardian_Name,Father_Name,Occupation,Father_Phone_Number,Relation,Course_Id,Course_Year,Admission_Date) VALUES (" & ad_tb_stduent_id.Text & " ," & ad_tb_application_no.Text & ", '" & ad_tb_first_name.Text & "', '" & ad_tb_middle_name.Text & "','" & ad_tb_last_name.Text & "', '" & ad_cb_gender.Text & "','" & ad_dtp_dob.Value.Date.ToString("yyyy-MM-dd") & "', '" & ad_tb_nationality.Text & "', '" & ad_cb_religion.Text & "', '" & ad_cb_caste.Text & "', " & ad_tb_mob_no.Text & ", '" & ad_tb_email_id.Text & "', '" & ad_tb_address.Text & "', " & ad_tb_uin.Text & ", '" & ad_tb_guardian_name.Text & "', '" & ad_tb_father_name.Text & "', '" & ad_cb_occupation.Text & "', '" & ad_tb_father_mob_no.Text & "','" & ad_tb_relationship.Text & "', " & course_id & ", " & ad_cb_course_year.Text & ",'" & Today.ToString("yyyy-MM-dd") & "')") And d.Query_insert_update("insert into Fee_Master(Stud_Id,Course_Year,Course_Fee,Paid_Fee,Remaining_Fee) values(" & ad_tb_stduent_id.Text & "," & ad_cb_course_year.Text & "," & ad_tb_course_fee.Text & ",0," & ad_tb_course_fee.Text & ")") Then
                    MessageBox.Show("Student Successfully Added")
                    ad_tb_stduent_id.Text = Integer.Parse(d.Auto_increment("select MAX(Id) from Student_Master")) + 1
                    btnclear.PerformClick()
                End If
            Else
                MessageBox.Show("Please enter valid values and select valid options!!")
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub ad_cb_course_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ad_cb_course_year.SelectedIndexChanged
        Try
            If d.Query_select("select Fee from Course_Master where Course_Name='" & ad_cb_course.Text & "'") Then
                ad_tb_course_fee.Text = d.dr(0)
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If IsNumeric(up_tb_stud_id.Text) Then
                If d.Query_select("select s.First_Name,s.Middle_Name,s.Surname,s.Mob_No,s.Guardian_Name,s.Father_Phone_Number,s.Address,s.Email,s.Course_Year,c.Course_Name from Student_Master s inner join Course_Master c on s.Course_Id=c.Course_Id where s.id=" & up_tb_stud_id.Text & "") Then
                    enable()
                    up_tb_first_name.Text = d.dr(0)
                    up_tb_middle_name.Text = d.dr(1)
                    up_tb_last_name.Text = d.dr(2)
                    up_tb_mob_no.Text = d.dr(3)
                    up_tb_guardian_name.Text = d.dr(4)
                    up_tb_guardian_mob_no.Text = d.dr(5)
                    up_tb_address.Text = d.dr(6)
                    up_tb_email_id.Text = d.dr(7)
                    up_cb_course_year.Text = d.dr(8)
                    course_year = d.dr(8)
                    up_tb_course.Text = d.dr(9)
                Else
                    MessageBox.Show("Not exist")
                End If
            Else
                MessageBox.Show("Please enter valid student ID!!")
                up_tb_stud_id.Clear()
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub up_tb_course_TextChanged(sender As Object, e As EventArgs) Handles up_tb_course.TextChanged
        Try
            If d.Query_select("select Years from Course_Master where Course_Name='" & up_tb_course.Text & "'") Then
                up_cb_course_year.Items.Clear()
                For i As Integer = course_year To d.dr(0)
                    up_cb_course_year.Items.Add(i)
                Next
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub up_btn_update_Click(sender As Object, e As EventArgs) Handles up_btn_update.Click
        Try
            If up_tb_first_name.Text <> "" And up_tb_middle_name.Text <> "" And up_tb_last_name.Text <> "" And up_tb_course.Text <> "" And up_tb_mob_no.Text <> "" And up_tb_address.Text <> "" And up_tb_guardian_mob_no.Text <> "" And up_tb_guardian_name.Text <> "" Then
                If course_year < up_cb_course_year.Text Then
                    If d.Query_insert_update("update Student_Master set First_Name='" & up_tb_first_name.Text & "',Middle_Name='" & up_tb_middle_name.Text & "',Surname='" & up_tb_last_name.Text & "',Mob_No=" & up_tb_mob_no.Text & ",Guardian_Name='" & up_tb_guardian_name.Text & "',Course_Year=" & up_cb_course_year.Text & ",Father_Phone_Number=" & up_tb_guardian_mob_no.Text & ",Email='" & up_tb_email_id.Text & "',Address='" & up_tb_address.Text & "' where Id=" & up_tb_stud_id.Text & "") And d.Query_insert_update("insert into Fee_Master(Stud_Id,Course_Year,Course_Fee,Paid_Fee,Remaining_Fee) values(" & up_tb_stud_id.Text & "," & up_cb_course_year.Text & "," & course_fee & ",0," & course_fee & ")") Then
                        MessageBox.Show("Updated")
                        up_btn_clear.PerformClick()
                    Else
                        MessageBox.Show("Could't Update")
                    End If
                ElseIf course_year = up_cb_course_year.Text Then
                    If d.Query_insert_update("update Student_Master set First_Name='" & up_tb_first_name.Text & "',Middle_Name='" & up_tb_middle_name.Text & "',Surname='" & up_tb_last_name.Text & "',Mob_No=" & up_tb_mob_no.Text & ",Guardian_Name='" & up_tb_guardian_name.Text & "',Course_Year=" & up_cb_course_year.Text & ",Father_Phone_Number=" & up_tb_guardian_mob_no.Text & ",Email='" & up_tb_email_id.Text & "',Address='" & up_tb_address.Text & "' where Id=" & up_tb_stud_id.Text & "") Then
                        MessageBox.Show("Updated")
                        up_btn_clear.PerformClick()
                    Else
                        MessageBox.Show("Could't Update")
                    End If
                End If
            Else
                MessageBox.Show("Please fill all fields!!")
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub



    Private Sub up_btn_delete_Click(sender As Object, e As EventArgs)
        Try
            If d.Query_insert_update("delete from Student_Master where Id=" & up_tb_stud_id.Text & "") Then
                MessageBox.Show("Deleted")
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Try
            Report_Form_Admission.Show()
        Catch ex As Exception
            msg(ex)
        End Try
    End Sub

    Private Sub ad_cb_religion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ad_cb_religion.SelectedIndexChanged
        Try
            If ad_cb_religion.SelectedIndex = 0 Then
                ad_cb_caste.SelectedIndex = 0
                ad_cb_caste.Enabled = True
                ad_cb_caste.SelectedIndex = 0
            Else
                ad_cb_caste.SelectedIndex = 0
                ad_cb_caste.Enabled = False
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            ad_tb_application_no.Clear()
            ad_tb_first_name.Clear()
            ad_tb_middle_name.Clear()
            ad_tb_last_name.Clear()
            ad_tb_father_mob_no.Clear()
            ad_tb_mob_no.Clear()
            ad_tb_uin.Clear()
            ad_tb_father_name.Clear()
            ad_tb_annual_income.Clear()
            ad_tb_guardian_name.Clear()
            ad_tb_relationship.Clear()
            ad_tb_course_fee.Clear()
            ad_tb_email_id.Clear()
            ad_cb_occupation.Text = "Select"
            ad_cb_blood_group.Text = "Select"
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub


    Private Sub up_btn_clear_Click(sender As Object, e As EventArgs) Handles up_btn_clear.Click
        up_tb_stud_id.Clear()
        clr()
    End Sub

    Private Sub up_tb_stud_id_TextChanged(sender As Object, e As EventArgs) Handles up_tb_stud_id.TextChanged
        clr()
    End Sub
    Private Sub enable()
        up_tb_first_name.Enabled = True
        up_tb_middle_name.Enabled = True
        up_tb_last_name.Enabled = True
        up_tb_address.Enabled = True
        up_tb_mob_no.Enabled = True
        up_tb_guardian_mob_no.Enabled = True
        up_tb_guardian_name.Enabled = True
        up_cb_course_year.Enabled = True
        up_tb_course.Enabled = True
        up_tb_email_id.Enabled = True
    End Sub
    Private Sub clr()
        up_tb_first_name.Clear()
        up_tb_middle_name.Clear()
        up_tb_last_name.Clear()
        up_tb_address.Clear()
        up_tb_mob_no.Clear()
        up_tb_guardian_mob_no.Clear()
        up_tb_guardian_name.Clear()
        up_tb_course.Clear()
        up_tb_email_id.Clear()
        up_cb_course_year.Items.Clear()
        up_tb_first_name.Enabled = False
        up_tb_middle_name.Enabled = False
        up_tb_last_name.Enabled = False
        up_tb_address.Enabled = False
        up_tb_mob_no.Enabled = False
        up_tb_guardian_mob_no.Enabled = False
        up_tb_guardian_name.Enabled = False
        up_cb_course_year.Enabled = False
        up_tb_course.Enabled = False
        up_tb_email_id.Enabled = False
    End Sub

    Private Sub up_cb_course_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles up_cb_course_year.SelectedIndexChanged
        Try
            If d.Query_select("select Fee from Course_Master where Course_Name='" & up_tb_course.Text & "'") Then
                course_fee = d.dr(0)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class