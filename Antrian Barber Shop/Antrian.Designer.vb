<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Antrian
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
        Me.btnCetakAntrian = New System.Windows.Forms.Button()
        Me.rbDewasa = New System.Windows.Forms.RadioButton()
        Me.rbAnak = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalAntrian = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAntrian = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCetakAntrian
        '
        Me.btnCetakAntrian.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCetakAntrian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakAntrian.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCetakAntrian.Location = New System.Drawing.Point(388, 369)
        Me.btnCetakAntrian.Name = "btnCetakAntrian"
        Me.btnCetakAntrian.Size = New System.Drawing.Size(258, 85)
        Me.btnCetakAntrian.TabIndex = 0
        Me.btnCetakAntrian.Text = "CETAK NOMOR ANTRIAN"
        Me.btnCetakAntrian.UseVisualStyleBackColor = False
        '
        'rbDewasa
        '
        Me.rbDewasa.AutoSize = True
        Me.rbDewasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDewasa.Location = New System.Drawing.Point(71, 421)
        Me.rbDewasa.Name = "rbDewasa"
        Me.rbDewasa.Size = New System.Drawing.Size(121, 33)
        Me.rbDewasa.TabIndex = 1
        Me.rbDewasa.TabStop = True
        Me.rbDewasa.Text = "Dewasa"
        Me.rbDewasa.UseVisualStyleBackColor = True
        '
        'rbAnak
        '
        Me.rbAnak.AutoSize = True
        Me.rbAnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAnak.Location = New System.Drawing.Point(71, 369)
        Me.rbAnak.Name = "rbAnak"
        Me.rbAnak.Size = New System.Drawing.Size(146, 33)
        Me.rbAnak.TabIndex = 2
        Me.rbAnak.TabStop = True
        Me.rbAnak.Text = "Anak-anak"
        Me.rbAnak.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtTotalAntrian)
        Me.Panel2.Location = New System.Drawing.Point(388, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 276)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TOTAL ANTRIAN"
        '
        'txtTotalAntrian
        '
        Me.txtTotalAntrian.AutoSize = True
        Me.txtTotalAntrian.Font = New System.Drawing.Font("Microsoft Sans Serif", 97.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAntrian.Location = New System.Drawing.Point(49, 27)
        Me.txtTotalAntrian.Name = "txtTotalAntrian"
        Me.txtTotalAntrian.Size = New System.Drawing.Size(167, 184)
        Me.txtTotalAntrian.TabIndex = 3
        Me.txtTotalAntrian.Text = "0"
        Me.txtTotalAntrian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtAntrian)
        Me.Panel1.Location = New System.Drawing.Point(71, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 276)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ANTRIAN"
        '
        'txtAntrian
        '
        Me.txtAntrian.AutoSize = True
        Me.txtAntrian.Font = New System.Drawing.Font("Microsoft Sans Serif", 97.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntrian.Location = New System.Drawing.Point(42, 27)
        Me.txtAntrian.Name = "txtAntrian"
        Me.txtAntrian.Size = New System.Drawing.Size(167, 184)
        Me.txtAntrian.TabIndex = 3
        Me.txtAntrian.Text = "0"
        Me.txtAntrian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Antrian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 526)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.rbAnak)
        Me.Controls.Add(Me.rbDewasa)
        Me.Controls.Add(Me.btnCetakAntrian)
        Me.Name = "Antrian"
        Me.Text = "Antrian"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCetakAntrian As Button
    Friend WithEvents rbDewasa As RadioButton
    Friend WithEvents rbAnak As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTotalAntrian As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAntrian As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
