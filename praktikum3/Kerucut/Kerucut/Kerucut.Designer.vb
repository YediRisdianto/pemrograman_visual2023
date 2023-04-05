<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kerucut
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
        Me.txtGarisPelukis = New System.Windows.Forms.TextBox()
        Me.labelGarisPelukis = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.labelTinggi = New System.Windows.Forms.Label()
        Me.labelOperasi = New System.Windows.Forms.Label()
        Me.txtLuasPermukaan = New System.Windows.Forms.TextBox()
        Me.labelLuasPermukaan = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.labelVolume = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.labelJari = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGarisPelukis
        '
        Me.txtGarisPelukis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGarisPelukis.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGarisPelukis.ForeColor = System.Drawing.Color.Maroon
        Me.txtGarisPelukis.Location = New System.Drawing.Point(45, 256)
        Me.txtGarisPelukis.Name = "txtGarisPelukis"
        Me.txtGarisPelukis.Size = New System.Drawing.Size(155, 27)
        Me.txtGarisPelukis.TabIndex = 57
        '
        'labelGarisPelukis
        '
        Me.labelGarisPelukis.AutoSize = True
        Me.labelGarisPelukis.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGarisPelukis.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelGarisPelukis.Location = New System.Drawing.Point(44, 233)
        Me.labelGarisPelukis.Name = "labelGarisPelukis"
        Me.labelGarisPelukis.Size = New System.Drawing.Size(119, 23)
        Me.labelGarisPelukis.TabIndex = 56
        Me.labelGarisPelukis.Text = "Garis Pelukis (s)"
        '
        'txtTinggi
        '
        Me.txtTinggi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTinggi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggi.ForeColor = System.Drawing.Color.Maroon
        Me.txtTinggi.Location = New System.Drawing.Point(45, 192)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(155, 27)
        Me.txtTinggi.TabIndex = 55
        '
        'labelTinggi
        '
        Me.labelTinggi.AutoSize = True
        Me.labelTinggi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTinggi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelTinggi.Location = New System.Drawing.Point(43, 167)
        Me.labelTinggi.Name = "labelTinggi"
        Me.labelTinggi.Size = New System.Drawing.Size(53, 23)
        Me.labelTinggi.TabIndex = 54
        Me.labelTinggi.Text = "Tinggi"
        '
        'labelOperasi
        '
        Me.labelOperasi.AutoSize = True
        Me.labelOperasi.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOperasi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelOperasi.Location = New System.Drawing.Point(89, 28)
        Me.labelOperasi.Name = "labelOperasi"
        Me.labelOperasi.Size = New System.Drawing.Size(287, 46)
        Me.labelOperasi.TabIndex = 53
        Me.labelOperasi.Text = "Operasi Hitung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volume dan Luas Permukaan Kerucut"
        Me.labelOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLuasPermukaan
        '
        Me.txtLuasPermukaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasPermukaan.ForeColor = System.Drawing.Color.Maroon
        Me.txtLuasPermukaan.Location = New System.Drawing.Point(248, 245)
        Me.txtLuasPermukaan.Name = "txtLuasPermukaan"
        Me.txtLuasPermukaan.Size = New System.Drawing.Size(155, 27)
        Me.txtLuasPermukaan.TabIndex = 52
        '
        'labelLuasPermukaan
        '
        Me.labelLuasPermukaan.AutoSize = True
        Me.labelLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLuasPermukaan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelLuasPermukaan.Location = New System.Drawing.Point(261, 220)
        Me.labelLuasPermukaan.Name = "labelLuasPermukaan"
        Me.labelLuasPermukaan.Size = New System.Drawing.Size(124, 23)
        Me.labelLuasPermukaan.TabIndex = 51
        Me.labelLuasPermukaan.Text = "Luas Permukaan"
        '
        'txtVolume
        '
        Me.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.ForeColor = System.Drawing.Color.Maroon
        Me.txtVolume.Location = New System.Drawing.Point(248, 178)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(155, 27)
        Me.txtVolume.TabIndex = 50
        '
        'labelVolume
        '
        Me.labelVolume.AutoSize = True
        Me.labelVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVolume.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelVolume.Location = New System.Drawing.Point(293, 153)
        Me.labelVolume.Name = "labelVolume"
        Me.labelVolume.Size = New System.Drawing.Size(62, 23)
        Me.labelVolume.TabIndex = 49
        Me.labelVolume.Text = "Volume"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.Window
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.Maroon
        Me.btnHitung.Location = New System.Drawing.Point(45, 301)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(155, 28)
        Me.btnHitung.TabIndex = 48
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtJari
        '
        Me.txtJari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJari.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJari.ForeColor = System.Drawing.Color.Maroon
        Me.txtJari.Location = New System.Drawing.Point(45, 128)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(155, 27)
        Me.txtJari.TabIndex = 47
        '
        'labelJari
        '
        Me.labelJari.AutoSize = True
        Me.labelJari.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJari.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelJari.Location = New System.Drawing.Point(42, 104)
        Me.labelJari.Name = "labelJari"
        Me.labelJari.Size = New System.Drawing.Size(68, 23)
        Me.labelJari.TabIndex = 46
        Me.labelJari.Text = "Jari-jari"
        '
        'Kerucut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(445, 378)
        Me.Controls.Add(Me.txtGarisPelukis)
        Me.Controls.Add(Me.labelGarisPelukis)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.labelTinggi)
        Me.Controls.Add(Me.labelOperasi)
        Me.Controls.Add(Me.txtLuasPermukaan)
        Me.Controls.Add(Me.labelLuasPermukaan)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.labelVolume)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtJari)
        Me.Controls.Add(Me.labelJari)
        Me.Name = "Kerucut"
        Me.Text = "Kerucut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGarisPelukis As TextBox
    Friend WithEvents labelGarisPelukis As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents labelTinggi As Label
    Friend WithEvents labelOperasi As Label
    Friend WithEvents txtLuasPermukaan As TextBox
    Friend WithEvents labelLuasPermukaan As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents labelVolume As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtJari As TextBox
    Friend WithEvents labelJari As Label
End Class
