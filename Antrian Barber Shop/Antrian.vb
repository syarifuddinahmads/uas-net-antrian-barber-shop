Public Class Antrian

    Private Sub Antrian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call koneksi()
            Dim sql As String
            sql = "select * from antrian where status = 1 order by tanggal desc"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            rd = cmd.ExecuteReader
            While rd.Read()
                txtAntrian.Text = rd("nomor_diproses")
                txtTotalAntrian.Text = rd("nomor_akhir")
            End While

        Catch ex As Exception
            MessageBox.Show("Gagal Ambil Data Antrian = " & ex.Message.ToString())
        End Try
    End Sub
End Class