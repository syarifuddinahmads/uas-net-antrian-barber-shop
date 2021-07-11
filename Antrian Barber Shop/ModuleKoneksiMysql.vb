Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Module ModuleKoneksiMysql

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub koneksi()
        Try
            Dim str As String = "server=127.0.0.1;user=root;password=;database=antrian_barber_shop"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
