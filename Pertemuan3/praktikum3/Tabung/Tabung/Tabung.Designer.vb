<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabung
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
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.labelJari = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.labelTinggi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelOperasi
        '
        Me.labelOperasi.AutoSize = True
        Me.labelOperasi.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOperasi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelOperasi.Location = New System.Drawing.Point(84, 44)
        Me.labelOperasi.Name = "labelOperasi"
        Me.labelOperasi.Size = New System.Drawing.Size(286, 46)
        Me.labelOperasi.TabIndex = 23
        Me.labelOperasi.Text = "Operasi Hitung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volume dan Luas Permukaan Tabung"
        Me.labelOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLuasPermukaan
        '
        Me.txtLuasPermukaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasPermukaan.ForeColor = System.Drawing.Color.Maroon
        Me.txtLuasPermukaan.Location = New System.Drawing.Point(247, 239)
        Me.txtLuasPermukaan.Name = "txtLuasPermukaan"
        Me.txtLuasPermukaan.Size = New System.Drawing.Size(155, 27)
        Me.txtLuasPermukaan.TabIndex = 22
        '
        'labelLuasPermukaan
        '
        Me.labelLuasPermukaan.AutoSize = True
        Me.labelLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLuasPermukaan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelLuasPermukaan.Location = New System.Drawing.Point(260, 214)
        Me.labelLuasPermukaan.Name = "labelLuasPermukaan"
        Me.labelLuasPermukaan.Size = New System.Drawing.Size(124, 23)
        Me.labelLuasPermukaan.TabIndex = 21
        Me.labelLuasPermukaan.Text = "Luas Permukaan"
        '
        'txtVolume
        '
        Me.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.ForeColor = System.Drawing.Color.Maroon
        Me.txtVolume.Location = New System.Drawing.Point(247, 172)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(155, 27)
        Me.txtVolume.TabIndex = 20
        '
        'labelVolume
        '
        Me.labelVolume.AutoSize = True
        Me.labelVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVolume.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelVolume.Location = New System.Drawing.Point(292, 147)
        Me.labelVolume.Name = "labelVolume"
        Me.labelVolume.Size = New System.Drawing.Size(62, 23)
        Me.labelVolume.TabIndex = 19
        Me.labelVolume.Text = "Volume"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.Window
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.Maroon
        Me.btnHitung.Location = New System.Drawing.Point(49, 258)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(155, 28)
        Me.btnHitung.TabIndex = 18
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtJari
        '
        Me.txtJari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJari.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJari.ForeColor = System.Drawing.Color.Maroon
        Me.txtJari.Location = New System.Drawing.Point(49, 155)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(155, 27)
        Me.txtJari.TabIndex = 17
        '
        'labelJari
        '
        Me.labelJari.AutoSize = True
        Me.labelJari.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJari.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelJari.Location = New System.Drawing.Point(48, 131)
        Me.labelJari.Name = "labelJari"
        Me.labelJari.Size = New System.Drawing.Size(68, 23)
        Me.labelJari.TabIndex = 16
        Me.labelJari.Text = "Jari-jari"
        '
        'txtTinggi
        '
        Me.txtTinggi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTinggi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggi.ForeColor = System.Drawing.Color.Maroon
        Me.txtTinggi.Location = New System.Drawing.Point(49, 215)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(155, 27)
        Me.txtTinggi.TabIndex = 25
        '
        'labelTinggi
        '
        Me.labelTinggi.AutoSize = True
        Me.labelTinggi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTinggi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelTinggi.Location = New System.Drawing.Point(48, 191)
        Me.labelTinggi.Name = "labelTinggi"
        Me.labelTinggi.Size = New System.Drawing.Size(53, 23)
        Me.labelTinggi.TabIndex = 24
        Me.labelTinggi.Text = "Tinggi"
        '
        'Tabung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(445, 347)
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
        Me.Name = "Tabung"
        Me.Text = "Tabung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelOperasi As Label
    Friend WithEvents txtLuasPermukaan As TextBox
    Friend WithEvents labelLuasPermukaan As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents labelVolume As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtJari As TextBox
    Friend WithEvents labelJari As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents labelTinggi As Label
End Class
