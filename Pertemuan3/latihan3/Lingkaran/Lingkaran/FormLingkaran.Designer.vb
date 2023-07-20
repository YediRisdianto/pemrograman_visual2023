<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLingkaran
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
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.labelSisi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelOperasi
        '
        Me.labelOperasi.AutoSize = True
        Me.labelOperasi.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOperasi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelOperasi.Location = New System.Drawing.Point(88, 31)
        Me.labelOperasi.Name = "labelOperasi"
        Me.labelOperasi.Size = New System.Drawing.Size(211, 46)
        Me.labelOperasi.TabIndex = 15
        Me.labelOperasi.Text = "Operasi Hitung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luas dan Keliling Lingkaran"
        Me.labelOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKeliling
        '
        Me.txtKeliling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeliling.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeliling.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtKeliling.Location = New System.Drawing.Point(126, 244)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(155, 27)
        Me.txtKeliling.TabIndex = 14
        '
        'labelKeliling
        '
        Me.labelKeliling.AutoSize = True
        Me.labelKeliling.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKeliling.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelKeliling.Location = New System.Drawing.Point(52, 248)
        Me.labelKeliling.Name = "labelKeliling"
        Me.labelKeliling.Size = New System.Drawing.Size(61, 23)
        Me.labelKeliling.TabIndex = 13
        Me.labelKeliling.Text = "Keliling"
        '
        'txtLuas
        '
        Me.txtLuas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuas.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtLuas.Location = New System.Drawing.Point(126, 208)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(155, 27)
        Me.txtLuas.TabIndex = 12
        '
        'labelLuas
        '
        Me.labelLuas.AutoSize = True
        Me.labelLuas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLuas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelLuas.Location = New System.Drawing.Point(52, 212)
        Me.labelLuas.Name = "labelLuas"
        Me.labelLuas.Size = New System.Drawing.Size(41, 23)
        Me.labelLuas.TabIndex = 11
        Me.labelLuas.Text = "Luas"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.Window
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnHitung.Location = New System.Drawing.Point(126, 156)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(155, 28)
        Me.btnHitung.TabIndex = 10
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtJari
        '
        Me.txtJari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJari.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJari.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtJari.Location = New System.Drawing.Point(126, 111)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(155, 27)
        Me.txtJari.TabIndex = 9
        '
        'labelSisi
        '
        Me.labelSisi.AutoSize = True
        Me.labelSisi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSisi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelSisi.Location = New System.Drawing.Point(52, 115)
        Me.labelSisi.Name = "labelSisi"
        Me.labelSisi.Size = New System.Drawing.Size(68, 23)
        Me.labelSisi.TabIndex = 8
        Me.labelSisi.Text = "Jari-jari"
        '
        'FormLingkaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(349, 339)
        Me.Controls.Add(Me.labelOperasi)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.labelKeliling)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.labelLuas)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtJari)
        Me.Controls.Add(Me.labelSisi)
        Me.Name = "FormLingkaran"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelOperasi As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents labelKeliling As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents labelLuas As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtJari As TextBox
    Friend WithEvents labelSisi As Label
End Class
