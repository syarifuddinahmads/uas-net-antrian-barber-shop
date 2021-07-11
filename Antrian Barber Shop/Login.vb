Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username, password As String
        username = txtUsername.Text
        password = txtPassword.Text

        If username = "" And password = "" Then
            MessageBox.Show("Username & Password belum diisi...")
        ElseIf username = "" Then
            MessageBox.Show("Username belum diisi...")
        ElseIf password = "" Then
            MessageBox.Show("Password belum diisi...")
        Else
            Try
                Call koneksi()
                Dim str As String
                str = "select * from users where username = '" & username & "' and password = '" & password & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                If rd.HasRows Then
                    Home.Visible = True
                    Home.Enabled = True
                    Me.Visible = False

                Else
                    rd.Close()
                    MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Text = ""
                    txtUsername.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Login Gagal = " & ex.Message.ToString())
            End Try
        End If
    End Sub
End Class
