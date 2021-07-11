Public Class RekapPembayaran
    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        Pembayaran.Visible = True
        Pembayaran.Enabled = True
    End Sub

    Private Sub btnTutupRekapPembayaran_Click(sender As Object, e As EventArgs) Handles btnTutupRekapPembayaran.Click
        Me.Visible = False
        Me.Enabled = False
    End Sub
End Class