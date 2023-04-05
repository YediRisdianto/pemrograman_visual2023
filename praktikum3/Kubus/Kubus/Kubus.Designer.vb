<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kubus
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
        Me.labelOperasi = New System.Windows.Forms.Label()
        Me.txtLuasPermukaan = New System.Windows.Forms.TextBox()
        Me.labelLuasPermukaan = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.labelVolume = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.labelSisi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelOperasi
        '
        Me.labelOperasi.AutoSize = True
        Me.labelOperasi.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOperasi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelOperasi.Location = New System.Drawing.Point(86, 45)
        Me.labelOperasi.Name = "labelOperasi"
        Me.labelOperasi.Size = New System.Drawing.Size(275, 46)
        Me.labelOperasi.TabIndex = 15
        Me.labelOperasi.Text = "Operasi Hitung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volume dan Luas Permukaan Kubus"
        Me.labelOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLuasPermukaan
        '
        Me.txtLuasPermukaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasPermukaan.ForeColor = System.Drawing.Color.Maroon
        Me.txtLuasPermukaan.Location = New System.Drawing.Point(243, 229)
        Me.txtLuasPermukaan.Name = "txtLuasPermukaan"
        Me.txtLuasPermukaan.Size = New System.Drawing.Size(155, 27)
        Me.txtLuasPermukaan.TabIndex = 14
        '
        'labelLuasPermukaan
        '
        Me.labelLuasPermukaan.AutoSize = True
        Me.labelLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLuasPermukaan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelLuasPermukaan.Location = New System.Drawing.Point(260, 203)
        Me.labelLuasPermukaan.Name = "labelLuasPermukaan"
        Me.labelLuasPermukaan.Size = New System.Drawing.Size(124, 23)
        Me.labelLuasPermukaan.TabIndex = 13
        Me.labelLuasPermukaan.Text = "Luas Permukaan"
        '
        'txtVolume
        '
        Me.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.ForeColor = System.Drawing.Color.Maroon
        Me.txtVolume.Location = New System.Drawing.Point(243, 152)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(155, 27)
        Me.txtVolume.TabIndex = 12
        '
        'labelVolume
        '
        Me.labelVolume.AutoSize = True
        Me.labelVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVolume.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelVolume.Location = New System.Drawing.Point(289, 127)
        Me.labelVolume.Name = "labelVolume"
        Me.labelVolume.Size = New System.Drawing.Size(62, 23)
        Me.labelVolume.TabIndex = 11
        Me.labelVolume.Text = "Volume"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.Window
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.Maroon
        Me.btnHitung.Location = New System.Drawing.Point(44, 214)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(155, 28)
        Me.btnHitung.TabIndex = 10
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtSisi
        '
        Me.txtSisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSisi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisi.ForeColor = System.Drawing.Color.Maroon
        Me.txtSisi.Location = New System.Drawing.Point(44, 166)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(155, 27)
        Me.txtSisi.TabIndex = 9
        '
        'labelSisi
        '
        Me.labelSisi.AutoSize = True
        Me.labelSisi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSisi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelSisi.Location = New System.Drawing.Point(106, 140)
        Me.labelSisi.Name = "labelSisi"
        Me.labelSisi.Size = New System.Drawing.Size(33, 23)
        Me.labelSisi.TabIndex = 8
        Me.labelSisi.Text = "Sisi"
        '
        'Kubus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(438, 314)
        Me.Controls.Add(Me.labelOperasi)
        Me.Controls.Add(Me.txtLuasPermukaan)
        Me.Controls.Add(Me.labelLuasPermukaan)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.labelVolume)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtSisi)
        Me.Controls.Add(Me.labelSisi)
        Me.Name = "Kubus"
        Me.Text = "Kubus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelOperasi As Label
    Friend WithEvents txtLuasPermukaan As TextBox
    Friend WithEvents labelLuasPermukaan As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents labelVolume As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents labelSisi As Label
End Class
