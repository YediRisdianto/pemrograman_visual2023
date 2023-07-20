<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSegitiga
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
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.labelKeliling = New System.Windows.Forms.Label()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.labelLuas = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtSisiA = New System.Windows.Forms.TextBox()
        Me.labelSisi = New System.Windows.Forms.Label()
        Me.txtSisiB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSisiC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelOperasi
        '
        Me.labelOperasi.AutoSize = True
        Me.labelOperasi.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOperasi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelOperasi.Location = New System.Drawing.Point(153, 36)
        Me.labelOperasi.Name = "labelOperasi"
        Me.labelOperasi.Size = New System.Drawing.Size(200, 46)
        Me.labelOperasi.TabIndex = 23
        Me.labelOperasi.Text = "Operasi Hitung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luas dan Keliling Segitiga"
        Me.labelOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKeliling
        '
        Me.txtKeliling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeliling.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeliling.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtKeliling.Location = New System.Drawing.Point(307, 232)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(155, 27)
        Me.txtKeliling.TabIndex = 22
        '
        'labelKeliling
        '
        Me.labelKeliling.AutoSize = True
        Me.labelKeliling.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKeliling.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelKeliling.Location = New System.Drawing.Point(303, 207)
        Me.labelKeliling.Name = "labelKeliling"
        Me.labelKeliling.Size = New System.Drawing.Size(61, 23)
        Me.labelKeliling.TabIndex = 21
        Me.labelKeliling.Text = "Keliling"
        '
        'txtLuas
        '
        Me.txtLuas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuas.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtLuas.Location = New System.Drawing.Point(307, 166)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(155, 27)
        Me.txtLuas.TabIndex = 20
        '
        'labelLuas
        '
        Me.labelLuas.AutoSize = True
        Me.labelLuas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLuas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelLuas.Location = New System.Drawing.Point(304, 141)
        Me.labelLuas.Name = "labelLuas"
        Me.labelLuas.Size = New System.Drawing.Size(41, 23)
        Me.labelLuas.TabIndex = 19
        Me.labelLuas.Text = "Luas"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.Window
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnHitung.Location = New System.Drawing.Point(112, 292)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(155, 28)
        Me.btnHitung.TabIndex = 18
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtSisiA
        '
        Me.txtSisiA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSisiA.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisiA.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtSisiA.Location = New System.Drawing.Point(112, 118)
        Me.txtSisiA.Name = "txtSisiA"
        Me.txtSisiA.Size = New System.Drawing.Size(155, 27)
        Me.txtSisiA.TabIndex = 17
        '
        'labelSisi
        '
        Me.labelSisi.AutoSize = True
        Me.labelSisi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSisi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelSisi.Location = New System.Drawing.Point(38, 122)
        Me.labelSisi.Name = "labelSisi"
        Me.labelSisi.Size = New System.Drawing.Size(46, 23)
        Me.labelSisi.TabIndex = 16
        Me.labelSisi.Text = "Sisi A"
        '
        'txtSisiB
        '
        Me.txtSisiB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSisiB.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisiB.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtSisiB.Location = New System.Drawing.Point(112, 151)
        Me.txtSisiB.Name = "txtSisiB"
        Me.txtSisiB.Size = New System.Drawing.Size(155, 27)
        Me.txtSisiB.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(38, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Sisi B"
        '
        'txtSisiC
        '
        Me.txtSisiC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSisiC.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisiC.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtSisiC.Location = New System.Drawing.Point(112, 184)
        Me.txtSisiC.Name = "txtSisiC"
        Me.txtSisiC.Size = New System.Drawing.Size(155, 27)
        Me.txtSisiC.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(38, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Sisi C"
        '
        'txtAlas
        '
        Me.txtAlas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlas.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtAlas.Location = New System.Drawing.Point(112, 217)
        Me.txtAlas.Name = "txtAlas"
        Me.txtAlas.Size = New System.Drawing.Size(155, 27)
        Me.txtAlas.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(38, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Alas"
        '
        'txtTinggi
        '
        Me.txtTinggi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTinggi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggi.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtTinggi.Location = New System.Drawing.Point(112, 250)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(155, 27)
        Me.txtTinggi.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(38, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Tinggi"
        '
        'FormSegitiga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(497, 371)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAlas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSisiC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSisiB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelOperasi)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.labelKeliling)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.labelLuas)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtSisiA)
        Me.Controls.Add(Me.labelSisi)
        Me.Name = "FormSegitiga"
        Me.Text = "Segitiga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelOperasi As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents labelKeliling As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents labelLuas As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtSisiA As TextBox
    Friend WithEvents labelSisi As Label
    Friend WithEvents txtSisiB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSisiC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAlas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents Label4 As Label
End Class
