Public Class Form_Library

    Dim d As New Db
    Dim bt As Integer = 0

    Private Sub nm_rb_student_CheckedChanged(sender As Object, e As EventArgs) Handles nm_rb_student.CheckedChanged
        Try
            nm_lb_id.Text = "Student ID :"
            nm_tb_id.Focus()
            nm_tb_id.Enabled = True
        Catch ex As Exception
            msg(ex)
        End Try


    End Sub

    Private Sub nm_rb_employee_CheckedChanged(sender As Object, e As EventArgs) Handles nm_rb_employee.CheckedChanged
        Try
            nm_lb_id.Text = "Employee ID :"
            nm_tb_id.Focus()
            nm_tb_id.Enabled = True
        Catch ex As Exception
            msg(ex)
        End Try


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub


    Private Sub Form_Library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lbusername.Text = uname
            lbdepartment.Text = department
            auto_incre()
            auto_incre_book__id()
            If d.Fill_datagridview("select Book_Id from Book_Master") Then
                irb_cb_book_id.DataSource = d.table
                irb_cb_book_id.DisplayMember = "Book_Id"
                irb_cb_book_id.Text = "Select"
            End If
            d.Fill_datagridview("select * from Book_Master")
            nb_dg.DataSource = d.table
            d.da.Update(d.table)
        Catch ex As Exception
            msg(ex)
        End Try
        irb_dtp_last_date.Value = irb_dtp_issue_date.Value.Date.AddDays(7)

    End Sub

    Private Sub nm_btn_search_Click(sender As Object, e As EventArgs) Handles nm_btn_search.Click
        Try
            If nm_rb_student.Checked And IsNumeric(nm_tb_id.Text) Then

                If d.Query_select("select First_Name,Middle_Name,Surname,Mob_No,Email,Address,Library_Id from Student_Master where Id=" & nm_tb_id.Text & "") Then
                    If IsDBNull(d.dr(6)) Then
                        MessageBox.Show("found")
                        nm_tb_fn.Text = d.dr(0)
                        nm_tb_mn.Text = d.dr(1)
                        nm_tb_ln.Text = d.dr(2)
                        nm_tb_phone.Text = d.dr(3)
                        nm_tb_email.Text = d.dr(4)
                        nm_tb_address.Text = d.dr(5)
                        nm_btn_add.Enabled = True
                    Else
                        MessageBox.Show("Already Membar")
                    End If
                Else
                    MessageBox.Show("Not Found")
                End If

            ElseIf nm_rb_employee.Checked Then
                If d.Query_select("select First_Name,Middle_Name,Surname,Phone,Email,Adderss,Library_Id from Employee_Master where Emp_Id =" & nm_tb_id.Text & "") Then
                    If IsDBNull(d.dr(6)) Then

                        MessageBox.Show("found")
                        nm_tb_fn.Text = d.dr(0)
                        nm_tb_mn.Text = d.dr(1)
                        nm_tb_ln.Text = d.dr(2)
                        nm_tb_phone.Text = d.dr(3)
                        nm_tb_email.Text = d.dr(4)
                        nm_tb_address.Text = d.dr(5)
                        nm_btn_add.Enabled = True
                    Else
                        MessageBox.Show("Already Membar")
                    End If
                Else
                    MessageBox.Show("Not Found")
                End If

            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub nm_btn_add_Click(sender As Object, e As EventArgs) Handles nm_btn_add.Click
        Try
            If nm_rb_student.Checked Then
                If d.Query_insert_update("insert into Library_Master values(" & nm_tb_lib_id.Text & ",'" & nm_rb_student.Text & "',0,'" & Date.Today.ToString("yyyy-MM-dd") & "')") And d.Query_insert_update("update Student_Master set Library_Id =" & nm_tb_lib_id.Text & " where Id = " & nm_tb_id.Text & "") Then
                    MessageBox.Show("Membar Added")
                    auto_incre()
                    nmclear()
                Else
                    MessageBox.Show("Unbale to add")
                End If
            ElseIf nm_rb_employee.Checked Then
                If d.Query_insert_update("insert into Library_Master values(" & nm_tb_lib_id.Text & ",'" & nm_rb_employee.Text & "',0,'" & Date.Today.ToString("yyyy-MM-dd") & "')") And d.Query_insert_update("update Employee_Master set Library_Id = " & nm_tb_lib_id.Text & " where Emp_Id = " & nm_tb_id.Text & "") Then
                    MessageBox.Show("Membar Added")
                    auto_incre()
                    nmclear()
                Else
                    MessageBox.Show("Unbale to add")
                End If
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub auto_incre()
        Try
            If d.Query_select("select max(Library_Id) from Library_Master") Then
                If IsDBNull(d.dr(0)) Then
                    nm_tb_lib_id.Text = 1
                Else
                    nm_tb_lib_id.Text = Double.Parse(d.dr(0)) + 1
                End If
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub nb_rb_new_CheckedChanged(sender As Object, e As EventArgs) Handles nb_rb_new.CheckedChanged
        Try
            nb_tb_book_id.Enabled = False
            nb_btn_save.Enabled = True
            nb_btn_update.Enabled = False
            'nb_btn_delete.Enabled = False
            nb_btn_search.Enabled = False
            nb_tb_book_title.Enabled = True
            nb_tb_author.Enabled = True
            nb_tb_edition.Enabled = True
            nb_tb_quantity.Enabled = True
            nb_tb_book_title.Clear()
            nb_tb_author.Clear()
            nb_tb_edition.Clear()
            auto_incre_book__id()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub nb_rb_update_CheckedChanged(sender As Object, e As EventArgs) Handles nb_rb_update.CheckedChanged
        Try
            nb_tb_book_id.Enabled = True
            nb_btn_save.Enabled = False
            nb_btn_update.Enabled = True
            'nb_btn_delete.Enabled = True
            nb_btn_search.Enabled = True
            nb_tb_book_title.Enabled = False
            nb_tb_author.Enabled = False
            nb_tb_edition.Enabled = False
            nb_tb_quantity.Enabled = True
            nb_tb_book_id.Clear()
            nb_tb_quantity.Clear()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub nb_btn_search_Click(sender As Object, e As EventArgs) Handles nb_btn_search.Click
        Try
            If IsNumeric(nb_tb_book_id.Text) Then
                If d.Query_select("select * from Book_Master where Book_Id=" & nb_tb_book_id.Text & "") Then
                    nb_tb_book_title.Text = d.dr(1)
                    nb_tb_author.Text = d.dr(2)
                    nb_tb_edition.Text = d.dr(3)
                    nb_tb_quantity.Text = d.dr(4)
                Else
                    MessageBox.Show("Book not found")
                End If
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub nb_btn_save_Click(sender As Object, e As EventArgs) Handles nb_btn_save.Click
        Try

            If nb_tb_book_title.Text <> "" And nb_tb_author.Text <> "" And nb_tb_book_title.Text <> "" And nb_tb_quantity.Text <> "" And IsNumeric(nb_tb_quantity.Text) Then
                If d.Query_insert_update("insert into Book_Master values(" & nb_tb_book_id.Text & ",'" & nb_tb_book_title.Text & "','" & nb_tb_author.Text & "','" & nb_tb_edition.Text & "'," & nb_tb_quantity.Text & ",'" & Date.Today.ToString("yyyy-MM-dd") & "')") Then
                    MessageBox.Show("Book Added")
                    auto_incre_book__id()
                    d.Fill_datagridview("select * From Book_Master")
                    nb_dg.DataSource = d.table
                    d.da.Update(d.table)
                    nb_tb_book_title.Clear()
                    nb_tb_edition.Clear()
                    nb_tb_quantity.Clear()
                    nb_tb_author.Clear()
                Else
                    MessageBox.Show("Couldn't Add Book")
                End If
            Else
                MessageBox.Show("Please fill all valid fields!!")
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
    Private Sub auto_incre_book__id()
        Try
            If d.Query_select("select max(Book_Id) from Book_Master") Then

                If IsDBNull(d.dr(0)) Then
                    nb_tb_book_id.Text = 1
                Else
                    nb_tb_book_id.Text = Double.Parse(d.dr(0)) + 1
                End If

            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub nb_btn_update_Click(sender As Object, e As EventArgs) Handles nb_btn_update.Click
        Try
            If IsNumeric(nb_tb_book_id.Text) And nb_tb_book_title.Text <> "" And nb_tb_author.Text <> "" And nb_tb_book_title.Text <> "" And nb_tb_quantity.Text <> "" And IsNumeric(nb_tb_quantity.Text) Then
                If d.Query_insert_update("update Book_Master set Quantity=" & nb_tb_quantity.Text & " where Book_Id=" & nb_tb_book_id.Text & "") Then
                    MessageBox.Show("Updated")
                Else
                    MessageBox.Show("Couldn't Update")
                End If
            Else
                MessageBox.Show("Please fill all valid fields!!")
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub


    Private Sub nm_btn_lib_id_search_Click(sender As Object, e As EventArgs)
        Try
            If IsNumeric(nm_tb_lib_id.Text) Then
                If d.Query_select("select Entry from Library_Master where Library_Id=" & nm_tb_lib_id.Text & "") Then

                    If d.dr(0) = "Student" Then
                        If d.Query_select("select First_Name,Middle_Name,Surname,Mob_No,Email,Address,Id from Student_Master where Library_Id = " & nm_tb_lib_id.Text & " ") Then
                            MessageBox.Show("exist")
                            nm_tb_fn.Text = d.dr(0)
                            nm_tb_mn.Text = d.dr(1)
                            nm_tb_ln.Text = d.dr(2)
                            nm_tb_phone.Text = d.dr(3)
                            nm_tb_email.Text = d.dr(4)
                            nm_tb_address.Text = d.dr(5)
                            nm_tb_id.Text = d.dr(6)
                            'nm_btn_delete.Enabled = True
                        Else
                            MessageBox.Show("This student is not a membar of Library")
                            'nm_btn_delete.Enabled = False
                        End If
                    ElseIf d.dr(0) = "Employee" Then
                        If d.Query_select("select First_Name,Middle_Name,Surname,Phone,Email,Adderss,Emp_Id from Employee_Master where Library_Id = " & nm_tb_lib_id.Text & " ") Then
                            MessageBox.Show("exist")
                            nm_tb_fn.Text = d.dr(0)
                            nm_tb_mn.Text = d.dr(1)
                            nm_tb_ln.Text = d.dr(2)
                            nm_tb_phone.Text = d.dr(3)
                            nm_tb_email.Text = d.dr(4)
                            nm_tb_address.Text = d.dr(5)
                            nm_tb_id.Text = d.dr(6)
                            'nm_btn_delete.Enabled = True
                        Else
                            MessageBox.Show("This Employee is not a membar of Library")
                            'nm_btn_delete.Enabled = False
                        End If
                    End If
                Else
                    MessageBox.Show("Membar not found")
                End If
            End If


        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub nm_btn_delete_Click(sender As Object, e As EventArgs)
        Try
            If nm_rb_student.Checked Then
                If d.Query_insert_update("delete from Library_Master where Library_Id=" & nm_tb_lib_id.Text & "") And d.Query_insert_update("delete from Library_Master where Library_Id=" & nm_tb_lib_id.Text & "") And d.Query_insert_update("update Student_Master set Library_Id=NULL where Library_Id=" & nm_tb_lib_id.Text & "") Then
                    MessageBox.Show("Successfully Deleted")
                Else
                    MessageBox.Show("Can't Be Delete")
                End If
            ElseIf nm_rb_employee.Checked Then
                If d.Query_insert_update("delete from Library_Master where Library_Id=" & nm_tb_lib_id.Text & "") And d.Query_insert_update("update Employee_Master set Library_Id=NULL where Library_Id=" & nm_tb_lib_id.Text & "") Then
                    MessageBox.Show("Successfully Deleted")
                Else
                    MessageBox.Show("Can't Be Delete")
                End If
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
    Private Sub mem_reset()

    End Sub
    Private Sub mem_clear()
        Try
            nm_tb_id.Clear()
            nm_tb_lib_id.Clear()
            nm_tb_fn.Clear()
            nm_tb_mn.Clear()
            nm_tb_ln.Clear()
            nm_tb_phone.Clear()
            nm_tb_email.Clear()
            nm_tb_address.Clear()
            nm_btn_add.Enabled = False
            'nm_btn_delete.Enabled = False
            nm_gp_membarship_for.Enabled = False
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles irb_btn_search.Click
        Try
            If IsNumeric(irb_tb_lib_id.Text) Then
                If d.Query_select("select * from Library_Master where Library_Id=" & irb_tb_lib_id.Text & "") Then

                    'irb_books_taken.Text = d.dr(2)
                    If d.dr(1).ToString = "Student" Then
                        If d.Query_select("select First_Name,Middle_Name,Surname from Student_Master where Library_Id=" & irb_tb_lib_id.Text & "") Then
                            irb_tb_name.Text = d.dr(0) + " " + d.dr(1) + " " + d.dr(2)
                        End If
                    ElseIf d.dr(1).ToString = "Employee" Then
                        If d.Query_select("select First_Name,Middle_Name,Surname from Employee_Master where Library_Id=" & irb_tb_lib_id.Text & "") Then
                            irb_tb_name.Text = d.dr(0) + " " + d.dr(1) + " " + d.dr(2)
                        End If
                    End If

                    fill_dg()
                    'irb_btn_clear.Enabled = True
                    irb_btn_issue.Enabled = True
                    irb_btn_renew.Enabled = True
                    irb_btn_return.Enabled = True
                    book_taken()
                    If d.Query_select("select Book_Id from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                        irb_cb_renew_book_id.Items.Clear()
                        irb_cb_renew_book_id.Items.Add(d.dr(0))
                        While d.dr.Read
                            irb_cb_renew_book_id.Items.Add(d.dr(0))
                        End While
                    End If
                    enable_disable()
                Else
                    MessageBox.Show("not exist")
                End If
            Else
                MessageBox.Show("Please enter valid Library ID")
                'irb_btn_clear.Enabled = False
                irb_btn_issue.Enabled = False
                irb_btn_renew.Enabled = False
                irb_btn_return.Enabled = False
            End If

        Catch ex As Exception
            msg(ex)
        End Try



    End Sub

    Private Sub irb_book_search_Click(sender As Object, e As EventArgs) Handles irb_book_search.Click
        Try
            If d.Query_select("select * from Book_Master where Book_Id=" & irb_cb_book_id.Text & "") Then

                irb_tb_book_title.Text = d.dr(1)
                irb_tb_remaining_books.Text = d.dr("Quantity")

            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub irb_btn_issue_Click(sender As Object, e As EventArgs) Handles irb_btn_issue.Click
        Try
            If bt = 2 Then
                If Not String.IsNullOrEmpty(irb_tb_lib_id.Text) And Not String.IsNullOrEmpty(irb_cb_renew_book_id.Text) Then
                    If d.Query_select("select Book_Id from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                        If d.dr(0) = irb_cb_book_id.Text Then
                            irb_btn_issue.Enabled = False
                            MessageBox.Show("Book already taken")
                            Return
                        Else

                            If IsDBNull(d.dr(0)) Then
                                d.dr.Read()
                                If d.dr(0) = irb_cb_book_id.Text Then
                                    irb_btn_issue.Enabled = False
                                    MessageBox.Show("Book already taken")
                                    Return
                                Else
                                    irb_btn_issue.Enabled = True
                                End If
                            End If
                        End If

                    End If
                End If
            ElseIf bt = 1 Then

                If Not String.IsNullOrEmpty(irb_tb_lib_id.Text) And Not String.IsNullOrEmpty(irb_cb_renew_book_id.Text) Then
                    If d.Query_select("select Book_Id from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                        If d.dr(0) = irb_cb_book_id.Text Then
                            irb_btn_issue.Enabled = False
                            MessageBox.Show("Book already taken")
                            Return
                        Else
                            irb_btn_issue.Enabled = True
                        End If

                    End If
                End If
            End If
            If d.Query_insert_update("insert into Library_Details(Library_Id,Book_Id,Issued_Date,Recieving_Date,Returned_Date) values(" & irb_tb_lib_id.Text & "," & irb_cb_book_id.Text & ",'" & irb_dtp_issue_date.Value.Date.ToString("yyyy-MM-dd") & "','" & irb_dtp_last_date.Value.Date.ToString("yyyy-MM-dd") & "',NULL)") And d.Query_insert_update("update Library_Master set Books_Taken=(select COUNT(*) from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null) where Library_Id=" & irb_tb_lib_id.Text & "") And d.Query_insert_update("update Book_Master set Quantity=(Quantity-1) where Book_Id=" & irb_cb_book_id.Text & "") Then
                MessageBox.Show("Book Issued")
                d.Query_select("select Quantity from Book_Master where Book_Id=" & irb_cb_book_id.Text & "")
                irb_tb_remaining_books.Text = d.dr(0)
                book_taken()
                fill_dg()
                If d.Query_select("select Book_Id from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                    irb_cb_renew_book_id.Items.Clear()
                    irb_cb_renew_book_id.Items.Add(d.dr(0))
                    While d.dr.Read
                        irb_cb_renew_book_id.Items.Add(d.dr(0))
                    End While
                End If
                enable_disable()
            Else
                MessageBox.Show("Can't Issue")
            End If
        Catch ex As Exception
            msg(ex)
        End Try



    End Sub

    Private Sub irb_cb_book_id_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        Try
            irb_book_search.PerformClick()
        Catch ex As Exception
            msg(ex)
        End Try
    End Sub

    Private Sub irb_btn_renew_book_search_Click(sender As Object, e As EventArgs)
        Try
            If d.Query_select("select * from Book_Master where Book_Id=" & irb_cb_renew_book_id.Text & "") Then

                irb_tb_renew_book_name.Text = d.dr(1)
                irb_tb_renew_book_name.Text = d.dr(2)

            End If
        Catch ex As Exception
            msg(ex)
        End Try


    End Sub

    Private Sub irb_btn_renew_Click(sender As Object, e As EventArgs) Handles irb_btn_renew.Click
        Try
            If d.Query_insert_update("update Library_Details set Recieving_Date='" & irb_dtp_new_recieving_date.Value.Date.ToString("yyyy-MM-dd") & "'") Then
                MessageBox.Show("Book Renewed")
                fill_dg()
            Else
                MessageBox.Show("Couldn't Renew")
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub irb_btn_return_Click(sender As Object, e As EventArgs) Handles irb_btn_return.Click

        If d.Query_insert_update("update Library_Details set Returned_Date = '" & Date.Today.ToString("yyyy-MM-dd") & "' where Library_Id = " & irb_tb_lib_id.Text & " and Book_Id = " & irb_cb_renew_book_id.Text & " and Returned_Date is null") And d.Query_insert_update("update Library_Master set Books_Taken=(select COUNT(*) from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null) where Library_Id=" & irb_tb_lib_id.Text & "") And d.Query_insert_update("update Book_Master set Quantity=(Quantity+1) where Book_Id=" & irb_cb_book_id.Text & "") Then
            MessageBox.Show("Book Returned")
            book_taken()
            If d.Query_select("select Book_Id from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                irb_cb_renew_book_id.Items.Clear()
                irb_cb_renew_book_id.Items.Add(d.dr(0))
                While d.dr.Read
                    irb_cb_renew_book_id.Items.Add(d.dr(0))
                End While
            End If
            fill_dg()
            enable_disable()
        Else
            MessageBox.Show("Couldn't Return")
            End If


    End Sub

    Private Sub book_taken()
        Try
            If d.Query_select("select Books_Taken from Library_Master where Library_Id=" & irb_tb_lib_id.Text & "") Then
                irb_books_taken.Clear()
                irb_books_taken.Text = d.dr(0)
                bt = Integer.Parse(d.dr(0).ToString)
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub fill_dg()
        Try
            If d.Fill_datagridview("select l.Book_Id as 'Book ID',b.Book_Title as 'Book Title',l.Issued_Date as 'Issued Date',l.Recieving_Date as 'Recieving Date' from Library_Details l inner join Book_Master b on l.Book_Id=b.Book_Id where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                irb_DataGridView.DataSource = d.table
                d.da.Update(d.table)
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub pb_rb_student_CheckedChanged(sender As Object, e As EventArgs) Handles pb_rb_student.CheckedChanged
        Try
            d.Fill_datagridview("select l.Library_Id,e.First_Name as 'First Name',e.Middle_Name as 'Middle Name',e.Surname as 'Surname',e.Mob_No as 'Mob No.',e.Email,e.Address,l.Books_Taken as 'Books Taken' from Student_Master e inner join Library_Master l on e.Library_Id=l.Library_Id where l.Books_Taken != 0")
            pb_dg.DataSource = d.table
            d.da.Update(d.table)
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub pb_rb_emp_CheckedChanged(sender As Object, e As EventArgs) Handles pb_rb_emp.CheckedChanged
        Try
            d.Fill_datagridview("select l.Library_Id,e.First_Name as 'First Name',e.Middle_Name as 'Middle Name',e.Surname as 'Surname',e.Phone,e.Email,e.Adderss,l.Books_Taken as 'Books Taken' from Employee_Master e inner join Library_Master l on e.Library_Id=l.Library_Id where l.Books_Taken!=0")
            pb_dg.DataSource = d.table
            d.da.Update(d.table)
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub irb_books_taken_TextChanged(sender As Object, e As EventArgs) Handles irb_books_taken.TextChanged
        Try
            books_taken_validate()

        Catch ex As Exception
            msg(ex)
        End Try
    End Sub

    Private Sub irb_cb_book_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles irb_cb_book_id.SelectedIndexChanged
        Try
            If bt = 2 Then
                If Not String.IsNullOrEmpty(irb_tb_lib_id.Text) And Not String.IsNullOrEmpty(irb_cb_renew_book_id.Text) Then
                    If d.Query_select("select Book_Id from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                        If d.dr(0) = irb_cb_book_id.Text Then
                            irb_btn_issue.Enabled = False
                            MessageBox.Show("Book already taken")
                        Else

                            If IsDBNull(d.dr(0)) Then
                                d.dr.Read()
                                If d.dr(0) = irb_cb_book_id.Text Then
                                    irb_btn_issue.Enabled = False
                                    MessageBox.Show("Book already taken")

                                Else
                                    irb_btn_issue.Enabled = True
                                End If
                            End If
                        End If

                    End If
                End If
            ElseIf bt = 1 Then

                If Not String.IsNullOrEmpty(irb_tb_lib_id.Text) And Not String.IsNullOrEmpty(irb_cb_renew_book_id.Text) Then
                    If d.Query_select("select Book_Id from Library_Details where Library_Id=" & irb_tb_lib_id.Text & " and Returned_Date is null") Then
                        If d.dr(0) = irb_cb_book_id.Text Then
                            irb_btn_issue.Enabled = False
                            MessageBox.Show("Book already taken")
                        Else
                            irb_btn_issue.Enabled = True
                        End If

                    End If
                End If
            End If

        Catch ex As Exception
            msg(ex)
        End Try

    End Sub
    Private Sub books_taken_validate()
        Try
            If d.Query_select("select Books_Taken from Library_Master where Library_Id=" & irb_tb_lib_id.Text & "") Then
                If d.dr(0) < 2 Then
                    irb_btn_issue.Enabled = True
                Else
                    irb_btn_issue.Enabled = False
                End If
            End If
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_new_book_Click(sender As Object, e As EventArgs) Handles btn_new_book.Click
        Try
            LibraryNewBook.Visible = True
            LibraryIssueRenewBook.Visible = False
            LibraryNewMembarship.Visible = False
            LibraryPendingBooks.Visible = False

            smallpanel1.Visible = True
            smallpanel2.Visible = False
            smallpanel3.Visible = False
            smallpanel4.Visible = False

            btn_new_book.BackColor = Color.FromArgb(63, 63, 70)
            btn_issue_book.BackColor = side.BackColor
            btn_membar.BackColor = side.BackColor
            btn_pending_books.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_issue_book_Click(sender As Object, e As EventArgs) Handles btn_issue_book.Click
        Try
            LibraryNewBook.Visible = False
            LibraryIssueRenewBook.Visible = True
            LibraryNewMembarship.Visible = False
            LibraryPendingBooks.Visible = False

            smallpanel1.Visible = False
            smallpanel2.Visible = True
            smallpanel3.Visible = False
            smallpanel4.Visible = False

            btn_new_book.BackColor = side.BackColor
            btn_issue_book.BackColor = Color.FromArgb(63, 63, 70)
            btn_membar.BackColor = side.BackColor
            btn_pending_books.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_membar_Click(sender As Object, e As EventArgs) Handles btn_membar.Click
        Try
            LibraryNewBook.Visible = False
            LibraryIssueRenewBook.Visible = False
            LibraryNewMembarship.Visible = True
            LibraryPendingBooks.Visible = False

            smallpanel1.Visible = False
            smallpanel2.Visible = False
            smallpanel3.Visible = True
            smallpanel4.Visible = False

            btn_new_book.BackColor = side.BackColor
            btn_issue_book.BackColor = side.BackColor
            btn_membar.BackColor = Color.FromArgb(63, 63, 70)
            btn_pending_books.BackColor = side.BackColor
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_pending_books_Click(sender As Object, e As EventArgs) Handles btn_pending_books.Click
        Try
            LibraryNewBook.Visible = False
            LibraryIssueRenewBook.Visible = False
            LibraryNewMembarship.Visible = False
            LibraryPendingBooks.Visible = True

            smallpanel1.Visible = False
            smallpanel2.Visible = False
            smallpanel3.Visible = False
            smallpanel4.Visible = True

            btn_new_book.BackColor = side.BackColor
            btn_issue_book.BackColor = side.BackColor
            btn_membar.BackColor = side.BackColor
            btn_pending_books.BackColor = Color.FromArgb(63, 63, 70)
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_book_report_Click(sender As Object, e As EventArgs) Handles btn_book_report.Click
        Try
            Report_Form_LibraryBooks.Show()

        Catch ex As Exception
            msg(ex)
        End Try
    End Sub

    Private Sub btn_pending_report_Click(sender As Object, e As EventArgs) Handles btn_pending_report.Click
        Try
            Report_Form_LibraryPendingBooks.Show()
        Catch ex As Exception
            msg(ex)
        End Try

    End Sub

    Private Sub btn_membar_report_Click(sender As Object, e As EventArgs) Handles btn_membar_report.Click
        Try
            Report_Form_LibraryMembar.Show()
        Catch ex As Exception
            msg(ex)
        End Try
    End Sub

    Private Sub nb_btn_clear_Click(sender As Object, e As EventArgs) Handles nb_btn_clear.Click
        nb_tb_book_title.Clear()
        nb_tb_edition.Clear()
        nb_tb_quantity.Clear()
        nb_tb_author.Clear()
        nb_tb_book_id.Clear()
    End Sub

    Private Sub nmclear()
        nm_btn_add.Enabled = False
        nm_tb_fn.Clear()
        nm_tb_mn.Clear()
        nm_tb_ln.Clear()
        nm_tb_email.Clear()
        nm_tb_address.Clear()
        nm_tb_phone.Clear()

    End Sub

    Private Sub nm_tb_id_TextChanged(sender As Object, e As EventArgs) Handles nm_tb_id.TextChanged
        If Not IsNumeric(nm_tb_id.Text) Then
            nmclear()
        End If
    End Sub

    Private Sub irb_cb_renew_book_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles irb_cb_renew_book_id.SelectedIndexChanged
        If d.Query_select("select Book_Title from Book_Master where Book_Id=" & irb_cb_renew_book_id.SelectedItem.ToString & "") Then
            irb_tb_renew_book_name.Text = d.dr(0)
        End If
        If d.Query_select("select l.Issued_Date,l.Recieving_Date from Library_Details l inner join Book_Master b on l.Book_Id=b.Book_Id where Library_Id=" & irb_tb_lib_id.Text & " and l.Book_Id=" & irb_cb_renew_book_id.Text & " and Returned_Date is null") Then
            irb_dtp_issued_date.Value = Date.Parse(d.dr(0))
            irb_dtp_old_recieving_date.Value = Date.Parse(d.dr(1))
            irb_dtp_new_recieving_date.Value = irb_dtp_old_recieving_date.Value.Date.AddDays(7)
        End If
    End Sub

    Private Sub irb_btn_clear_Click(sender As Object, e As EventArgs) Handles irb_btn_clear.Click
        irb_btn_issue.Enabled = False
        irb_btn_renew.Enabled = False
        irb_btn_return.Enabled = False
        irb_tb_name.Clear()
        irb_books_taken.Clear()
        irb_cb_renew_book_id.Items.Clear()
        irb_cb_renew_book_id.Text = ""
        irb_tb_book_title.Clear()
        irb_tb_remaining_books.Clear()
        irb_tb_renew_book_name.Clear()
        d.table.Clear()
    End Sub

    Private Sub irb_tb_lib_id_TextChanged(sender As Object, e As EventArgs) Handles irb_tb_lib_id.TextChanged
        'irb_btn_clear.PerformClick()
    End Sub
    Private Sub enable_disable()
        If irb_books_taken.Text = 0 Then
            '.Text = "No Books"
            irb_btn_renew.Enabled = False
            irb_btn_return.Enabled = False
        ElseIf irb_books_taken.Text <= 2 Then
            'irb_cb_renew_book_id.Text = "Select"
            irb_btn_renew.Enabled = True
            irb_btn_return.Enabled = True
        ElseIf irb_books_taken.Text = 2 Then
            ' irb_cb_renew_book_id.Text = "Select"
            irb_btn_issue.Enabled = False
            irb_btn_renew.Enabled = True
            irb_btn_return.Enabled = True
        End If
    End Sub
End Class