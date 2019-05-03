Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class Db
    Public con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=cmsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public table As DataTable

    Public Sub Connection_open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub Connection_close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Function Query_insert_update(ByVal qr As String) As Boolean

        Dim i As Integer
            cmd.Connection = con
            Connection_close()
            Connection_open()
            cmd.CommandText = qr
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                Return True
            Else
                Return False
            End If
            Connection_close()
    End Function
    Public Function Auto_increment(ByVal qry As String)
        Connection_close()
        Connection_open()
        cmd = New SqlCommand(qry, con)
        Return cmd.ExecuteScalar
    End Function

    Public Function Fill_datagridview(ByVal s As String)

        Connection_close()
            Connection_open()
            cmd.Connection = con
            cmd = New SqlCommand(s, con)
            da = New SqlDataAdapter(cmd)
            table = New DataTable
            da.Fill(table)
            Connection_close()
            Return True

    End Function

    Public Function Query_select(ByVal query As String)
        
            Connection_close()
            Connection_open()
            cmd = New SqlCommand(query, con)
            Connection_open()
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Return True
            Else
                Return False
            End If
    End Function

End Class
