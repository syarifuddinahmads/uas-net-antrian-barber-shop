<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RekapPembayaran
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal_Antrian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorAntrian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jenis_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPembayaran = New System.Windows.Forms.Button()
        Me.btnTutupRekapPembayaran = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Tanggal_Antrian, Me.NomorAntrian, Me.Jenis_Customer, Me.TotalBayar})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(569, 308)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'Tanggal_Antrian
        '
        Me.Tanggal_Antrian.HeaderText = "Tanggal"
        Me.Tanggal_Antrian.Name = "Tanggal_Antrian"
        '
        'NomorAntrian
        '
        Me.NomorAntrian.HeaderText = "Nomor Antrian"
        Me.NomorAntrian.Name = "NomorAntrian"
        '
        'Jenis_Customer
        '
        Me.Jenis_Customer.HeaderText = "Jenis Customer"
        Me.Jenis_Customer.Name = "Jenis_Customer"
        '
        'TotalBayar
        '
        Me.TotalBayar.HeaderText = "Total Bayar"
        Me.TotalBayar.Name = "TotalBayar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Rekap Pembayaran"
        '
        'btnPembayaran
        '
        Me.btnPembayaran.Location = New System.Drawing.Point(487, 42)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(109, 37)
        Me.btnPembayaran.TabIndex = 2
        Me.btnPembayaran.Text = "Pembayaran"
        Me.btnPembayaran.UseVisualStyleBackColor = True
        '
        'btnTutupRekapPembayaran
        '
        Me.btnTutupRekapPembayaran.Location = New System.Drawing.Point(27, 443)
        Me.btnTutupRekapPembayaran.Name = "btnTutupRekapPembayaran"
        Me.btnTutupRekapPembayaran.Size = New System.Drawing.Size(192, 38)
        Me.btnTutupRekapPembayaran.TabIndex = 3
        Me.btnTutupRekapPembayaran.Text = "Tutup Rekap Pembayaran"
        Me.btnTutupRekapPembayaran.UseVisualStyleBackColor = True
        '
        'RekapPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 508)
        Me.Controls.Add(Me.btnTutupRekapPembayaran)
        Me.Controls.Add(Me.btnPembayaran)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RekapPembayaran"
        Me.Text = "RekapPembayaran"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal_Antrian As DataGridViewTextBoxColumn
    Friend WithEvents NomorAntrian As DataGridViewTextBoxColumn
    Friend WithEvents Jenis_Customer As DataGridViewTextBoxColumn
    Friend WithEvents TotalBayar As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents btnTutupRekapPembayaran As Button
End Class
