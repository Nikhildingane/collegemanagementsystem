Imports System.Text.RegularExpressions

Module common_variables
    Public dept_id As Integer = 0
    Public uname As String = ""
    Public department As String = ""
    Public Function string_validate(ByVal str As String)
        If Not Regex.Match(str, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then

            Return False
        Else

            Return True

        End If
    End Function
    Public Sub msg(ByVal ex As Exception)
        MessageBox.Show(ex.ToString)
    End Sub
End Module
