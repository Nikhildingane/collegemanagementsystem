Imports System.Data
Public Class Form_Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Form_Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
