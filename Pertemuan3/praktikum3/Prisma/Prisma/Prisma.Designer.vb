<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prisma
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
        Me.txtLuasAlas = New System.Windows.Forms.TextBox()
        Me.labelJari = New System.Windows.Forms.Label()
        Me.txtKelilingAlas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelOperasi
        '
        Me.labelOperasi.AutoSize = True
        Me.labelOperasi.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOperasi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelOperasi.Location = New System.Drawing.Point(83, 46)
        Me.labelOperasi.Name = "labelOperasi"
        Me.labelOperasi.Size = New System.Drawing.Size(282, 46)
        Me.labelOperasi.TabIndex = 41
        Me.labelOperasi.Text = "Operasi Hitung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volume dan Luas Permukaan Prisma"
        Me.labelOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLuasPermukaan
        '
        Me.txtLuasPermukaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasPermukaan.ForeColor = System.Drawing.Color.Maroon
        Me.txtLuasPermukaan.Location = New System.Drawing.Point(244, 278)
        Me.txtLuasPermukaan.Name = "txtLuasPermukaan"
        Me.txtLuasPermukaan.Size = New System.Drawing.Size(155, 27)
        Me.txtLuasPermukaan.TabIndex = 40
        '
        'labelLuasPermukaan
        '
        Me.labelLuasPermukaan.AutoSize = True
        Me.labelLuasPermukaan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLuasPermukaan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelLuasPermukaan.Location = New System.Drawing.Point(257, 253)
        Me.labelLuasPermukaan.Name = "labelLuasPermukaan"
        Me.labelLuasPermukaan.Size = New System.Drawing.Size(124, 23)
        Me.labelLuasPermukaan.TabIndex = 39
        Me.labelLuasPermukaan.Text = "Luas Permukaan"
        '
        'txtVolume
        '
        Me.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.ForeColor = System.Drawing.Color.Maroon
        Me.txtVolume.Location = New System.Drawing.Point(244, 211)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(155, 27)
        Me.txtVolume.TabIndex = 38
        '
        'labelVolume
        '
        Me.labelVolume.AutoSize = True
        Me.labelVolume.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVolume.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelVolume.Location = New System.Drawing.Point(289, 186)
        Me.labelVolume.Name = "labelVolume"
        Me.labelVolume.Size = New System.Drawing.Size(62, 23)
        Me.labelVolume.TabIndex = 37
        Me.labelVolume.Text = "Volume"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.Window
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.Maroon
        Me.btnHitung.Location = New System.Drawing.Point(41, 330)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(155, 28)
        Me.btnHitung.TabIndex = 36
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtLuasAlas
        '
        Me.txtLuasAlas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuasAlas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasAlas.ForeColor = System.Drawing.Color.Maroon
        Me.txtLuasAlas.Location = New System.Drawing.Point(41, 161)
        Me.txtLuasAlas.Name = "txtLuasAlas"
        Me.txtLuasAlas.Size = New System.Drawing.Size(155, 27)
        Me.txtLuasAlas.TabIndex = 35
        '
        'labelJari
        '
        Me.labelJari.AutoSize = True
        Me.labelJari.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJari.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelJari.Location = New System.Drawing.Point(38, 137)
        Me.labelJari.Name = "labelJari"
        Me.labelJari.Size = New System.Drawing.Size(74, 23)
        Me.labelJari.TabIndex = 34
        Me.labelJari.Text = "Luas Alas"
        '
        'txtKelilingAlas
        '
        Me.txtKelilingAlas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKelilingAlas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelilingAlas.ForeColor = System.Drawing.Color.Maroon
        Me.txtKelilingAlas.Location = New System.Drawing.Point(41, 225)
        Me.txtKelilingAlas.Name = "txtKelilingAlas"
        Me.txtKelilingAlas.Size = New System.Drawing.Size(155, 27)
        Me.txtKelilingAlas.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(39, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Keliling Alas"
        '
        'txtTinggi
        '
        Me.txtTinggi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTinggi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggi.ForeColor = System.Drawing.Color.Maroon
        Me.txtTinggi.Location = New System.Drawing.Point(41, 288)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(155, 27)
        Me.txtTinggi.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(40, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tinggi"
        '
        'Prisma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(450, 395)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKelilingAlas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelOperasi)
        Me.Controls.Add(Me.txtLuasPermukaan)
        Me.Controls.Add(Me.labelLuasPermukaan)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.labelVolume)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasAlas)
        Me.Controls.Add(Me.labelJari)
        Me.Name = "Prisma"
        Me.Text = "Prisma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelOperasi As Label
    Friend WithEvents txtLuasPermukaan As TextBox
    Friend WithEvents labelLuasPermukaan As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents labelVolume As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasAlas As TextBox
    Friend WithEvents labelJari As Label
    Friend WithEvents txtKelilingAlas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents Label2 As Label
End Class
