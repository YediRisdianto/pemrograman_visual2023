<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.txtTgs = New System.Windows.Forms.TextBox()
        Me.txtKehadiran = New System.Windows.Forms.TextBox()
        Me.txtUas = New System.Windows.Forms.TextBox()
        Me.txtUts = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtNilaiMutu = New System.Windows.Forms.TextBox()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Mutu Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prodi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kehadiran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 267)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tugas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 225)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "UTS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(235, 267)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "UAS"
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(116, 84)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(242, 27)
        Me.txtNim.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(116, 126)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(242, 27)
        Me.txtNama.TabIndex = 9
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(116, 168)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(242, 27)
        Me.txtProdi.TabIndex = 10
        '
        'txtTgs
        '
        Me.txtTgs.Location = New System.Drawing.Point(116, 263)
        Me.txtTgs.Name = "txtTgs"
        Me.txtTgs.Size = New System.Drawing.Size(75, 27)
        Me.txtTgs.TabIndex = 12
        '
        'txtKehadiran
        '
        Me.txtKehadiran.Location = New System.Drawing.Point(116, 222)
        Me.txtKehadiran.Name = "txtKehadiran"
        Me.txtKehadiran.Size = New System.Drawing.Size(75, 27)
        Me.txtKehadiran.TabIndex = 11
        '
        'txtUas
        '
        Me.txtUas.Location = New System.Drawing.Point(283, 263)
        Me.txtUas.Name = "txtUas"
        Me.txtUas.Size = New System.Drawing.Size(75, 27)
        Me.txtUas.TabIndex = 14
        '
        'txtUts
        '
        Me.txtUts.Location = New System.Drawing.Point(283, 222)
        Me.txtUts.Name = "txtUts"
        Me.txtUts.Size = New System.Drawing.Size(75, 27)
        Me.txtUts.TabIndex = 13
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(116, 313)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(242, 34)
        Me.btnHitung.TabIndex = 15
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtNilaiMutu
        '
        Me.txtNilaiMutu.Location = New System.Drawing.Point(283, 372)
        Me.txtNilaiMutu.Name = "txtNilaiMutu"
        Me.txtNilaiMutu.Size = New System.Drawing.Size(75, 27)
        Me.txtNilaiMutu.TabIndex = 19
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(116, 372)
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(75, 27)
        Me.txtNilaiAkhir.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(204, 376)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nilai Mutu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 376)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Nilai Akhir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 439)
        Me.Controls.Add(Me.txtNilaiMutu)
        Me.Controls.Add(Me.txtNilaiAkhir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtUas)
        Me.Controls.Add(Me.txtUts)
        Me.Controls.Add(Me.txtTgs)
        Me.Controls.Add(Me.txtKehadiran)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents txtTgs As TextBox
    Friend WithEvents txtKehadiran As TextBox
    Friend WithEvents txtUas As TextBox
    Friend WithEvents txtUts As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtNilaiMutu As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
