Imports System.Data.Odbc

Public Class JenisCustomer
    Private Sub JenisCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTutupJenisCustomer_Click(sender As Object, e As EventArgs) Handles btnTutupJenisCustomer.Click
        Me.Visible = False
        Me.Enabled = False
    End Sub
End Class