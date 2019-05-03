Imports System.Data
Imports System.Data.SqlClient
Public Class Form_HumanResource


    Dim Documentchk As String = "No"
    Dim Entry, Update_entry As String
    Dim Experiance As String = "Fresher"
    Dim Experiance_Year As Integer = 0
    Dim designation_id As Integer = 0
    Dim info_entry As Integer = 1
    Dim dept_id As Integer = 0
    Dim d As New Db


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_teaching.CheckedChanged
        Try
            Entry = rb_teaching.Text
            GroupBoxPersonalInfo.Enabled = True
            GroupBoxTechnicalinfo.Enabled = True
            btnsubmit.Enabled = True
            btnclear.Enabled = True
            'btnnew.Enabled = True
            If IsDBNull(d.Auto_increment("select MAX(Emp_Id) from Employee_Master")) Then
                tb_id.Text = 1
            Else
                tb_id.Text = Integer.Parse(d.Auto_increment("select MAX(Emp_Id) from Employee_Master")) + 1
            End If
            cb_department.Items.Clear()
            cb_designation.Items.Clear()
            d.Query_select("select Designation_Name from Designation_Master where Designation_Type=0")
            cb_designation.Items.Add(d.dr(0))
            While d.dr.Read
                cb_designation.Items.Add(d.dr(0))
            End While
            d.Query_select("select Dept_Name from Department_Master where Dept_Type=0")
            cb_department.Items.Add(d.dr(0))
            While d.dr.Read
                cb_department.Items.Add(d.dr(0))
            End While
            d.Query_select("select Name from Qualifications where Id>=8")
            cb_qualification.Items.Clear()
            cb_qualification.Items.Add("Other")
            cb_qualification.Items.Add(d.dr(0))
            While d.dr.Read
                cb_qualification.Items.Add(d.dr(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_non_teaching.CheckedChanged
        Try

            Entry = rb_non_teaching.Text
            GroupBoxPersonalInfo.Enabled = True
            GroupBoxTechnicalinfo.Enabled = True
            btnsubmit.Enabled = True
            btnclear.Enabled = True
            If IsDBNull(d.Auto_increment("select MAX(Emp_Id) from Employee_Master")) Then
                tb_id.Text = 1
            Else
                tb_id.Text = Integer.Parse(d.Auto_increment("select MAX(Emp_Id) from Employee_Master")) + 1
            End If
            cb_department.Items.Clear()
            cb_designation.Items.Clear()
            d.Query_select("select Designation_Name from Designation_Master where Designation_Type=1")
            cb_designation.Items.Add(d.dr(0))
            While d.dr.Read
                cb_designation.Items.Add(d.dr(0))
            End While
            d.Query_select("select Dept_Name from Department_Master where Dept_Type=1")
            cb_department.Items.Add(d.dr(0))
            While d.dr.Read
                cb_department.Items.Add(d.dr(0))
            End While
            d.Query_select("select Name from Qualifications")
            cb_qualification.Items.Clear()
            cb_qualification.Items.Add("Other")
            cb_qualification.Items.Add(d.dr(0))
            While d.dr.Read
                cb_qualification.Items.Add(d.dr(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            empreg.Visible = True
            empupdate.Visible = False
            empinfo.Visible = False
            smallpanelreg.Visible = True
            smallpanelupdate.Visible = False
            smallpanelinfo.Visible = False
            Button1.BackColor = Color.FromArgb(63, 63, 70)
            Button2.BackColor = side.BackColor
            Button3.BackColor = side.BackColor
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            empreg.Visible = False
            empupdate.Visible = True
            empinfo.Visible = False
            smallpanelreg.Visible = False
            smallpanelupdate.Visible = True
            smallpanelinfo.Visible = False
            Button1.BackColor = side.BackColor
            Button2.BackColor = Color.FromArgb(63, 63, 70)
            Button3.BackColor = side.BackColor
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            empinfo.Visible = True
            empreg.Visible = False
            empupdate.Visible = False
            smallpanelreg.Visible = False
            smallpanelupdate.Visible = False
            smallpanelinfo.Visible = True
            Button1.BackColor = side.BackColor
            Button2.BackColor = side.BackColor
            Button3.BackColor = Color.FromArgb(63, 63, 70)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Try
            empinfo.Visible = False
            empreg.Visible = False
            empupdate.Visible = False

            smallpanelreg.Visible = False
            smallpanelupdate.Visible = False
            smallpanelinfo.Visible = False

            Button1.BackColor = side.BackColor
            Button2.BackColor = side.BackColor
            Button3.BackColor = side.BackColor
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_yes.CheckedChanged
        Try
            Documentchk = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_no.CheckedChanged
        Try
            Documentchk = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub Form_HumanResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label_Date.Text = Date.Today
        lbusername.Text = uname
        lbdepartment.Text = department
        Try
            cb_payscale.Items.Clear()
            Update_cb_payscale.Items.Clear()
            d.Query_select("select * from Pay_Scale_Master")
            Update_cb_payscale.Items.Add(d.dr(0))
            cb_payscale.Items.Add(d.dr(0))
            While d.dr.Read
                cb_payscale.Items.Add(d.dr(0))
                Update_cb_payscale.Items.Add(d.dr(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles rb_fresher.CheckedChanged
        Experiance = "Fresher"
        cb_experiance.Enabled = False
        gbOriginalDocumentChecked.Enabled = False
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles rb_experianced.CheckedChanged
        Experiance = "Experianced"
        cb_experiance.Enabled = True
        gbOriginalDocumentChecked.Enabled = True
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            If tb_first_name.Text <> "" And tb_middle_name.Text <> "" And tb_last_name.Text <> "" And tb_uin.Text <> "" And tb_phone.Text <> "" And tb_address.Text <> "" And cb_gender.Items.Contains(cb_gender.Text) And cb_qualification.Items.Contains(cb_qualification.Text) And cb_department.Items.Contains(cb_department.Text) And cb_designation.Items.Contains(cb_designation.Text) And tb_salary.Text <> "" Then
                If d.Query_insert_update("insert into Employee_Master(Emp_Id,First_Name, Middle_Name, Surname, UIN, Gender, Phone, Qaulification, Email, Designation, Adderss, Experiance, Experiance_Year, Original_Document_Checked, Department, Pay_Scale,Date) values(" & tb_id.Text & ",'" & tb_first_name.Text & "','" & tb_middle_name.Text & "','" & tb_last_name.Text & "'," & tb_uin.Text & ",'" & cb_gender.Text & "','" & tb_phone.Text & "','" & cb_qualification.Text & "','" & tb_email.Text & "'," & designation_id & ",'" & tb_address.Text & "','" & Experiance & "','" & Experiance_Year & "','" & Documentchk & "'," & dept_id & "," & Double.Parse(cb_payscale.Text) & ",'" & Today.ToString("yyyy-MM-dd") & "')") Then
                    MessageBox.Show("Employee Added")
                    btnclear.PerformClick()
                    tb_id.Text = Double.Parse(d.Auto_increment("select max(Emp_Id) from Employee_Master")) + 1
                Else
                    MessageBox.Show("Unable to add employee")
                End If
            Else
                MessageBox.Show("Please fill all Mandotory fields and select proper values !!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub RadioButton_Search_Faculty_CheckedChanged()
        Throw New NotImplementedException()
    End Sub

    Private Sub RadioButton_Search_Employee_CheckedChanged()
        Throw New NotImplementedException()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        tb_first_name.Clear()
        tb_middle_name.Clear()
        tb_last_name.Clear()
        cb_qualification.Text = "Select"
        tb_uin.Clear()
        tb_phone.Clear()
        cb_gender.Text = "Select"
        tb_email.Clear()
        tb_address.Clear()
        cb_department.Text = "Select"
        cb_designation.Text = "Select"
        rb_fresher.Checked = True
        rb_experianced.Checked = False
        cb_experiance.Text = "Years"
        Documentchk = "No"
        rb_yes.Checked = False
        rb_no.Checked = True
        cb_payscale.Text = "Select"
        tb_salary.Clear()
    End Sub

    Private Sub Update_rb_emp_CheckedChanged(sender As Object, e As EventArgs)
        Update_tb_id.Clear()
        update_button_delete.Enabled = False

    End Sub

    Private Sub Button_Update_Search_Click(sender As Object, e As EventArgs) Handles Button_Update_Search.Click
        Try
            If IsNumeric(Update_tb_id.Text) Then
                If d.Query_select("select * from Employee_Master where Emp_Id=" & Update_tb_id.Text & "") Then
                    MessageBox.Show("found")
                    Update_tb_first_name.Text = d.dr("First_Name").ToString
                    Update_tb_middle_name.Text = d.dr("Middle_Name").ToString
                    Update_tb_last_name.Text = d.dr("Surname").ToString
                    Update_tb_phone.Text = d.dr("Phone").ToString
                    Update_tb_address.Text = d.dr("Adderss").ToString
                    Update_tb_email.Text = d.dr("Email").ToString
                    Update_tb_uin.Text = d.dr("UIN").ToString
                    Update_cb_payscale.Text = d.dr("Pay_Scale").ToString
                    If d.Query_select("select * from Pay_Scale_Master where Pay_Scale like '%" & Update_cb_payscale.Text & "%'") Then
                        Update_tb_salary.Text = Double.Parse(d.dr("Salary_Per_Day")) * 30
                    End If
                    update_enabled()
                    Button_Update.Enabled = True
                    update_button_delete.Enabled = True
                    update_button_reset.Enabled = True
                    'MessageBox.Show("not found")
                Else
                    MessageBox.Show("Employee Not Found")
                End If
            Else
                MessageBox.Show("Please fill valid Employee ID!!")
                Update_tb_id.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Update_rb_faculty_CheckedChanged(sender As Object, e As EventArgs)

        Update_tb_id.Clear()
        update_button_delete.Enabled = False
    End Sub

    Private Sub Update_tb_id_TextChanged(sender As Object, e As EventArgs) Handles Update_tb_id.TextChanged
        update_disabled()
        update_clear()
        Button_Update.Enabled = False
        update_button_delete.Enabled = False
        update_button_reset.Enabled = False
    End Sub

    Private Sub update_button_delete_Click(sender As Object, e As EventArgs) Handles update_button_delete.Click
        Try
            If Not d.Query_select("select Emp_Id from Salary_Details where Emp_Id=" & Update_tb_id.Text & "") Then

                If d.Query_insert_update("delete from Employee_Master where Emp_Id=" & Update_tb_id.Text & "") Then
                    MessageBox.Show("Employee Successfully deleted")
                    update_button_reset.PerformClick()
                Else
                    MessageBox.Show("Unable to delete employee")
                End If
            Else
                MessageBox.Show("Can't Delete Employee!!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub update_enabled()
        Update_tb_first_name.Enabled = True
        Update_tb_middle_name.Enabled = True
        Update_tb_last_name.Enabled = True
        Update_tb_address.Enabled = True
        Update_tb_uin.Enabled = True
        Update_tb_phone.Enabled = True
        Update_tb_email.Enabled = True
        Update_tb_salary.Enabled = True
        Update_cb_payscale.Enabled = True
    End Sub

    Private Sub cb_department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_department.SelectedIndexChanged
        Try
            If d.Query_select("select Dept_Id from Department_Master where Dept_Name='" & cb_department.Text & "'") Then
                dept_id = d.dr("Dept_Id")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub cb_designation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_designation.SelectedIndexChanged
        Try
            If d.Query_select("select Designation_Id from Designation_Master where Designation_Name='" & cb_designation.Text & "'") Then
                designation_id = d.dr("Designation_Id")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub cb_payscale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_payscale.SelectedIndexChanged
        Try
            If d.Query_select("select * from Pay_Scale_Master where Pay_Scale like '%" & cb_payscale.Text & "%'") Then
                tb_salary.Text = Double.Parse(d.dr("Salary_Per_Day")) * 30
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub RadioButton_Search_Employee_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Search_Employee.CheckedChanged
        Try
            info_entry = 1
            d.Fill_datagridview("select Emp_Id,First_Name,Surname,UIN,Gender,Phone,Email,Designation_Name,Dept_Name,Pay_Scale_Master.Pay_Scale from Employee_Master,Designation_Master,Department_Master,Pay_Scale_Master where Employee_Master.Designation=Designation_Master.Designation_Id and Employee_Master.Department=Department_Master.Dept_Id and Employee_Master.Pay_Scale=Pay_Scale_Master.Pay_Scale and Designation_Master.Designation_Type=" & info_entry & " and Department_Master.Dept_Type=" & info_entry & "")
            DataGridView1.DataSource = d.table
            d.da.Update(d.table)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub update_disabled()
        Update_tb_first_name.Enabled = False
        Update_tb_middle_name.Enabled = False
        Update_tb_last_name.Enabled = False
        Update_tb_address.Enabled = False
        Update_tb_uin.Enabled = False
        Update_tb_phone.Enabled = False
        Update_tb_email.Enabled = False
        Update_tb_salary.Enabled = False
        Update_cb_payscale.Enabled = False
    End Sub

    Private Sub RadioButton_Search_Faculty_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Search_Faculty.CheckedChanged
        Try
            info_entry = 0
            d.Fill_datagridview("select Emp_Id,First_Name,Surname,UIN,Gender,Phone,Email,Designation_Name,Dept_Name,Pay_Scale_Master.Pay_Scale from Employee_Master,Designation_Master,Department_Master,Pay_Scale_Master where Employee_Master.Designation=Designation_Master.Designation_Id and Employee_Master.Department=Department_Master.Dept_Id and Employee_Master.Pay_Scale=Pay_Scale_Master.Pay_Scale and Designation_Master.Designation_Type like " & info_entry & " and Department_Master.Dept_Type like " & info_entry & "")
            DataGridView1.DataSource = d.table
            d.da.Update(d.table)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If IsNumeric(TextBox_Info_Search.Text) Then
                d.Fill_datagridview("select Emp_Id,First_Name,Surname,UIN,Gender,Phone,Email,Designation_Name,Dept_Name,Pay_Scale_Master.Pay_Scale from Employee_Master,Designation_Master,Department_Master,Pay_Scale_Master where Employee_Master.Designation=Designation_Master.Designation_Id and Employee_Master.Department=Department_Master.Dept_Id and Employee_Master.Pay_Scale=Pay_Scale_Master.Pay_Scale and Designation_Master.Designation_Type=" & info_entry & " and Department_Master.Dept_Type=" & info_entry & " and Emp_Id=" & TextBox_Info_Search.Text & "")
                DataGridView1.DataSource = d.table
                d.da.Update(d.table)
            Else
                MessageBox.Show("Please enter valid employee ID!!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub tb_uin_TextChanged(sender As Object, e As EventArgs) Handles tb_uin.TextChanged
        Try
            If IsNumeric(tb_uin.Text) Or tb_uin.Text = "" Then
                btnsubmit.Enabled = True
            Else
                MessageBox.Show("Invalid UIN")
                tb_uin.Text = ""
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub tb_first_name_Leave(sender As Object, e As EventArgs) Handles tb_first_name.Leave
        Try
            If Not string_validate(tb_first_name.Text) Then
                MessageBox.Show("Please Enter Valid Name!!")
                tb_first_name.Clear()
                btnsubmit.Enabled = False
            Else
                btnsubmit.Enabled = True
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub tb_middle_name_Leave(sender As Object, e As EventArgs) Handles tb_middle_name.Leave
        Try
            If Not string_validate(tb_middle_name.Text) Then
                MessageBox.Show("Please Enter Valid Name!!")
                tb_middle_name.Clear()
                btnsubmit.Enabled = False
            Else
                btnsubmit.Enabled = True
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub tb_last_name_Leave(sender As Object, e As EventArgs) Handles tb_last_name.Leave
        Try
            If Not string_validate(tb_last_name.Text) Then
                MessageBox.Show("Please Enter Valid Name!!")
                tb_last_name.Clear()
                btnsubmit.Enabled = False
            Else
                btnsubmit.Enabled = True
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub


    Private Sub cb_gender_Leave(sender As Object, e As EventArgs) Handles cb_gender.Leave
        Try
            If Not cb_gender.Items.Contains(cb_gender.Text) Then
                MessageBox.Show("Please Select Valid Gender!!")
                cb_gender.SelectedIndex = 0
                cb_gender.Focus()
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub tb_phone_Leave(sender As Object, e As EventArgs) Handles tb_phone.Leave
        Try
            If Not IsNumeric(tb_phone.Text) Then
                tb_phone.Clear()
                tb_phone.Focus()
            End If
            If tb_phone.TextLength < 10 Then
                MessageBox.Show("Please enter valid Mobile number!!")
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub cb_qualification_Leave(sender As Object, e As EventArgs) Handles cb_qualification.Leave
        Try
            If Not cb_qualification.Items.Contains(cb_qualification.Text) Then
                MessageBox.Show("Please Select Valid Qualification!!")
                cb_qualification.SelectedIndex = 0
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub cb_department_Leave(sender As Object, e As EventArgs) Handles cb_department.Leave
        Try
            If Not cb_department.Items.Contains(cb_department.Text) Then
                MessageBox.Show("Please Select Valid Department!!")
                cb_department.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_designation_Leave(sender As Object, e As EventArgs) Handles cb_designation.Leave
        Try
            If Not cb_designation.Items.Contains(cb_designation.Text) Then
                MessageBox.Show("Please Select Valid Designation!!")
                cb_designation.SelectedIndex = 0
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub cb_experiance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_experiance.SelectedIndexChanged
        Try

        Catch ex As Exception
            msg(ex)
        End Try
        If Not cb_experiance.Items.Contains(cb_experiance.Text) Then
            MessageBox.Show("Please Select Valid Experiance!!")
            cb_experiance.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Report_Form_HumanResource.Show()
    End Sub

    Private Sub cb_payscale_Leave(sender As Object, e As EventArgs) Handles cb_payscale.Leave

    End Sub

    Private Sub tb_uin_Leave(sender As Object, e As EventArgs) Handles tb_uin.Leave
        If tb_uin.TextLength < 12 Then
            MessageBox.Show("Please enter valid UIN number!!")
        End If
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        Try
            If Update_tb_first_name.Text <> "" And Update_tb_middle_name.Text <> "" And Update_tb_last_name.Text <> "" And Update_tb_uin.Text <> "" And Update_tb_uin.Text <> "" And Update_tb_address.Text <> "" And Update_tb_phone.Text <> "" And Update_tb_salary.Text <> "" Then
                If d.Query_insert_update("update Employee_Master set First_Name='" & Update_tb_first_name.Text & "',Middle_Name='" & Update_tb_middle_name.Text & "',Surname='" & Update_tb_last_name.Text & "',UIN=" & Update_tb_uin.Text & ",Adderss='" & tb_address.Text & "',Phone=" & Update_tb_phone.Text & ",Email='" & Update_tb_first_name.Text & "',Pay_Scale=" & Update_cb_payscale.Text & " where Emp_Id=" & Update_tb_id.Text & "") Then
                    MessageBox.Show("Employee Successfully Updated")
                    update_button_reset.PerformClick()
                Else
                    MessageBox.Show("Could'nt Update Employee")
                End If
            Else
                MessageBox.Show("Please fill all mandotory fields")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub Update_tb_first_name_TextChanged(sender As Object, e As EventArgs) Handles Update_tb_first_name.TextChanged

    End Sub

    Private Sub Update_cb_payscale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Update_cb_payscale.SelectedIndexChanged
        Try
            If d.Query_select("select * from Pay_Scale_Master where Pay_Scale = '" & Update_cb_payscale.Text & "'") Then
                Update_tb_salary.Text = Double.Parse(d.dr("Salary_Per_Day")) * 30
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub update_button_reset_Click(sender As Object, e As EventArgs) Handles update_button_reset.Click
        update_clear()
        Update_tb_id.Clear()
        update_disabled()
    End Sub

    Private Sub update_clear()

        Update_tb_first_name.Clear()
        Update_tb_middle_name.Clear()
        Update_tb_last_name.Clear()
        Update_tb_address.Clear()
        Update_tb_uin.Clear()
        Update_tb_phone.Clear()
        Update_tb_email.Clear()
        Update_tb_salary.Clear()
        Update_cb_payscale.Text = "select"
    End Sub


End Class