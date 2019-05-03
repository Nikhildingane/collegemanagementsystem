Imports System.Data.SqlClient
Public Class Report_Form_LibraryBooks

    Dim d As New Db

    Private Sub Report_Form_LibraryBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cr As New CrystalReportLibraryBooks
            Dim Str As String = "select * from Book_Master"
            d.Connection_close()
            d.Connection_open()
            d.da = New SqlDataAdapter(Str, d.con)
            Dim ds As New DataSet
            d.da.Fill(ds, "View_Book")
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            msg(ex)
        End Try


    End Sub
End Class