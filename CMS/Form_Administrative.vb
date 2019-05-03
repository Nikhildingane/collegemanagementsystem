Public Class Form_Administrative

    Dim d As New Db
    Dim id As Integer

    Private Sub btn_hr_Click(sender As Object, e As EventArgs) Handles btn_hr.Click
        Try
            department = "Human Resource(admin)"
            uname = "admin"
            Form_HumanResource.Show()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_ad_Click(sender As Object, e As EventArgs) Handles btn_ad.Click
        Try
            department = "Admission(admin)"
            uname = "admin"
            Form_Admission.Show()
        Catch ex As Exception
            msg(ex)
        End Try
        
    End Sub

    Private Sub btn_fin_Click(sender As Object, e As EventArgs) Handles btn_fin.Click
        Try
            department = "Finance(admin)"
            uname = "admin"
            Form_Finance.Show()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_lib_Click(sender As Object, e As EventArgs) Handles btn_lib.Click
        Try
            department = "Library(admin)"
            uname = "admin"
            Form_Library.Show()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub rb_new_CheckedChanged(sender As Object, e As EventArgs) Handles rb_new.CheckedChanged
        Try
            btn_create.Enabled = True
            btn_delete.Enabled = False
            GroupBox1.Enabled = True
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub rb_delete_CheckedChanged(sender As Object, e As EventArgs) Handles rb_delete.CheckedChanged
        Try
            btn_create.Enabled = False
            btn_delete.Enabled = True
            GroupBox1.Enabled = True
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub Form_Administrative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lbusername.Text = uname
            If d.Fill_datagridview("select Dept_Name from Login_Dept") Then
                cb_department.DataSource = d.table
                cb_department.DisplayMember = "Dept_Name"
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_dept_Click(sender As Object, e As EventArgs) Handles btn_dept.Click
        Try
            dept.Visible = True
            create_del_user.Visible = False
            smallpaneldept.Visible = True
            smallpanelusers.Visible = False
            btn_dept.BackColor = Color.FromArgb(63, 63, 70)
            btn_users.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_users_Click(sender As Object, e As EventArgs) Handles btn_users.Click
        Try
            dept.Visible = False
            create_del_user.Visible = True
            smallpaneldept.Visible = False
            smallpanelusers.Visible = True
            btn_users.BackColor = Color.FromArgb(63, 63, 70)
            btn_dept.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            If tb_username.Text <> "" And tb_password.Text <> "" And tb_comfirm_password.Text <> "" Then
                If String.Equals(tb_password.Text, tb_comfirm_password.Text) Then
                    If d.Query_insert_update("insert into User_Master(UName,PWord,Dept_Name) values('" & tb_username.Text & "','" & tb_password.Text & "','" & cb_department.Text & "')") Then
                        MessageBox.Show("User Successfully Created")
                    Else
                        MessageBox.Show("Could't Create User")
                    End If
                Else
                    MessageBox.Show("Password did not match")
                End If
            Else
                MessageBox.Show("Please first Fill all the fields")
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub


End Class