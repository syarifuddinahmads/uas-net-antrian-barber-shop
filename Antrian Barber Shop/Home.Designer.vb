<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRekapAntrian = New System.Windows.Forms.Button()
        Me.btnRekapPembayaran = New System.Windows.Forms.Button()
        Me.btnJenisCustomer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nomor_Antrian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jenis_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAntrian = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRekapAntrian
        '
        Me.btnRekapAntrian.Location = New System.Drawing.Point(30, 71)
        Me.btnRekapAntrian.Name = "btnRekapAntrian"
        Me.btnRekapAntrian.Size = New System.Drawing.Size(191, 33)
        Me.btnRekapAntrian.TabIndex = 0
        Me.btnRekapAntrian.Text = "Rekap Antrian"
        Me.btnRekapAntrian.UseVisualStyleBackColor = True
        '
        'btnRekapPembayaran
        '
        Me.btnRekapPembayaran.Location = New System.Drawing.Point(30, 126)
        Me.btnRekapPembayaran.Name = "btnRekapPembayaran"
        Me.btnRekapPembayaran.Size = New System.Drawing.Size(191, 33)
        Me.btnRekapPembayaran.TabIndex = 1
        Me.btnRekapPembayaran.Text = "Rekap Pembayaran"
        Me.btnRekapPembayaran.UseVisualStyleBackColor = True
        '
        'btnJenisCustomer
        '
        Me.btnJenisCustomer.Location = New System.Drawing.Point(30, 183)
        Me.btnJenisCustomer.Name = "btnJenisCustomer"
        Me.btnJenisCustomer.Size = New System.Drawing.Size(191, 33)
        Me.btnJenisCustomer.TabIndex = 2
        Me.btnJenisCustomer.Text = "Jenis Customer"
        Me.btnJenisCustomer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnRekapPembayaran)
        Me.Panel1.Controls.Add(Me.btnJenisCustomer)
        Me.Panel1.Controls.Add(Me.btnRekapAntrian)
        Me.Panel1.Location = New System.Drawing.Point(24, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 359)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Nomor_Antrian, Me.Jenis_Customer})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(466, 202)
        Me.DataGridView1.TabIndex = 4
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'Nomor_Antrian
        '
        Me.Nomor_Antrian.HeaderText = "Nomor Antrian"
        Me.Nomor_Antrian.Name = "Nomor_Antrian"
        '
        'Jenis_Customer
        '
        Me.Jenis_Customer.HeaderText = "Jenis Customer"
        Me.Jenis_Customer.Name = "Jenis_Customer"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(306, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 359)
        Me.Panel2.TabIndex = 5
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(691, 29)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 32)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Keluar Aplikasi"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Home"
        '
        'btnAntrian
        '
        Me.btnAntrian.Location = New System.Drawing.Point(575, 29)
        Me.btnAntrian.Name = "btnAntrian"
        Me.btnAntrian.Size = New System.Drawing.Size(110, 32)
        Me.btnAntrian.TabIndex = 8
        Me.btnAntrian.Text = "Buka Antrian"
        Me.btnAntrian.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 551)
        Me.Controls.Add(Me.btnAntrian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRekapAntrian As Button
    Friend WithEvents btnRekapPembayaran As Button
    Friend WithEvents btnJenisCustomer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Nomor_Antrian As DataGridViewTextBoxColumn
    Friend WithEvents Jenis_Customer As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAntrian As Button
End Class
