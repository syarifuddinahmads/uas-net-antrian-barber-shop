<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RekapAntrian
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
        Me.TanggalAntrian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorAntrian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTutupRekapAntrian = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.TanggalAntrian, Me.NomorAntrian, Me.JenisCustomer, Me.TotalBayar})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(544, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'TanggalAntrian
        '
        Me.TanggalAntrian.HeaderText = "Tanggal Antrian"
        Me.TanggalAntrian.Name = "TanggalAntrian"
        '
        'NomorAntrian
        '
        Me.NomorAntrian.HeaderText = "Nomor Antrian"
        Me.NomorAntrian.Name = "NomorAntrian"
        '
        'JenisCustomer
        '
        Me.JenisCustomer.HeaderText = "Jenis Customer"
        Me.JenisCustomer.Name = "JenisCustomer"
        '
        'TotalBayar
        '
        Me.TotalBayar.HeaderText = "Total Bayar"
        Me.TotalBayar.Name = "TotalBayar"
        '
        'btnTutupRekapAntrian
        '
        Me.btnTutupRekapAntrian.Location = New System.Drawing.Point(27, 357)
        Me.btnTutupRekapAntrian.Name = "btnTutupRekapAntrian"
        Me.btnTutupRekapAntrian.Size = New System.Drawing.Size(166, 39)
        Me.btnTutupRekapAntrian.TabIndex = 1
        Me.btnTutupRekapAntrian.Text = "Tutup Rekap Antrian"
        Me.btnTutupRekapAntrian.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Rekap Antrian"
        '
        'RekapAntrian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 430)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTutupRekapAntrian)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RekapAntrian"
        Me.Text = "RekapAntrian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents TanggalAntrian As DataGridViewTextBoxColumn
    Friend WithEvents NomorAntrian As DataGridViewTextBoxColumn
    Friend WithEvents JenisCustomer As DataGridViewTextBoxColumn
    Friend WithEvents TotalBayar As DataGridViewTextBoxColumn
    Friend WithEvents btnTutupRekapAntrian As Button
    Friend WithEvents Label1 As Label
End Class
