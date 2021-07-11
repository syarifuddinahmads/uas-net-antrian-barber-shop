Public Class Home
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        '' Untuk logout
        Login.Visible = True
        Login.Enabled = True
        Me.Visible = False
        ''Untuk menutup cetak nomor antrian
        Antrian.Visible = False
        Antrian.Enabled = False
        btnAntrian.Text = "Buka Antrian"
    End Sub

    Private Sub btnAntrian_Click(sender As Object, e As EventArgs) Handles btnAntrian.Click
        '' cek apakah antrian belum dibuka
        If btnAntrian.Text = "Buka Antrian" Then
            Try
                Dim str As String
                Dim date_now As DateTime
                Call koneksi()

                str = "INSERT INTO antrian(nomor_akhir,nomor_diproses,status)VALUES('0','0','1')"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Antrian.Visible = True
                Antrian.Enabled = True
                btnAntrian.Text = "Tutup Antrian"

            Catch ex As Exception
                MessageBox.Show("Buka Antrian Gagal = " & ex.Message.ToString())
            End Try
        Else
            '' untuk menutup antrian jika sudah waktunya tutup
            Try
                Dim str As String
                Call koneksi()
                str = "update antrian set status = 0"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Antrian.Visible = False
                Antrian.Enabled = False
                btnAntrian.Text = "Buka Antrian"

            Catch ex As Exception
                MessageBox.Show("Tutup Antrian Gagal = " & ex.Message.ToString())
            End Try

        End If


    End Sub

    Private Sub btnJenisCustomer_Click(sender As Object, e As EventArgs) Handles btnJenisCustomer.Click
        JenisCustomer.Visible = True
        JenisCustomer.Enabled = True
    End Sub

    Private Sub btnRekapAntrian_Click(sender As Object, e As EventArgs) Handles btnRekapAntrian.Click
        RekapAntrian.Visible = True
        RekapAntrian.Enabled = True
    End Sub

    Private Sub btnRekapPembayaran_Click(sender As Object, e As EventArgs) Handles btnRekapPembayaran.Click
        RekapPembayaran.Visible = True
        RekapPembayaran.Enabled = True
    End Sub
End Class