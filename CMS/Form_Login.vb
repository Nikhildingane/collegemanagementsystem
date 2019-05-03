Imports System.Data.SqlClient
Public Class Form_Login
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As New Db
        If d.Fill_datagridview("select Dept_Name from Login_Dept") Then
            ComboBoxLoginAs.DataSource = d.table
            ComboBoxLoginAs.DisplayMember = "Dept_Name"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New Db
        If d.Query_select("select * from User_Master where UName='" & TextBoxUsername.Text & "' and PWord='" & TextBoxPassword.Text & "' and Dept_Name='" & ComboBoxLoginAs.Text & "'") Then
            MessageBox.Show("Login Successfull")
            uname = TextBoxUsername.Text
            department = ComboBoxLoginAs.Text
            If ComboBoxLoginAs.Text = "Human Resource" Then
                Form_HumanResource.Show()
            ElseIf ComboBoxLoginAs.Text = "Admission" Then
                Form_Admission.Show()
            ElseIf ComboBoxLoginAs.Text = "Finance" Then
                Form_Finance.Show()
            ElseIf ComboBoxLoginAs.Text = "Library" Then
                Form_Library.Show()
            ElseIf ComboBoxLoginAs.Text = "Administrative" Then
                Form_Administrative.Show()
            End If
        Else
            MessageBox.Show("Login Unsuccessfull")
        End If
    End Sub
End Class