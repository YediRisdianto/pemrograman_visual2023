<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnObat = New System.Windows.Forms.PictureBox()
        Me.btnPegawai = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPembeli = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTransaksi = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnObat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPembeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 86)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(361, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DASHBOARD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(209, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistem Manajemen Penjualan Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Data Obat"
        '
        'btnObat
        '
        Me.btnObat.Image = CType(resources.GetObject("btnObat.Image"), System.Drawing.Image)
        Me.btnObat.Location = New System.Drawing.Point(94, 183)
        Me.btnObat.Name = "btnObat"
        Me.btnObat.Size = New System.Drawing.Size(108, 74)
        Me.btnObat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnObat.TabIndex = 5
        Me.btnObat.TabStop = False
        '
        'btnPegawai
        '
        Me.btnPegawai.Image = CType(resources.GetObject("btnPegawai.Image"), System.Drawing.Image)
        Me.btnPegawai.Location = New System.Drawing.Point(259, 183)
        Me.btnPegawai.Name = "btnPegawai"
        Me.btnPegawai.Size = New System.Drawing.Size(108, 74)
        Me.btnPegawai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPegawai.TabIndex = 7
        Me.btnPegawai.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data Pegawai"
        '
        'btnPembeli
        '
        Me.btnPembeli.Image = CType(resources.GetObject("btnPembeli.Image"), System.Drawing.Image)
        Me.btnPembeli.Location = New System.Drawing.Point(425, 183)
        Me.btnPembeli.Name = "btnPembeli"
        Me.btnPembeli.Size = New System.Drawing.Size(108, 74)
        Me.btnPembeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPembeli.TabIndex = 9
        Me.btnPembeli.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(414, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data Pembeli"
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Image = CType(resources.GetObject("btnTransaksi.Image"), System.Drawing.Image)
        Me.btnTransaksi.Location = New System.Drawing.Point(597, 183)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(108, 74)
        Me.btnTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnTransaksi.TabIndex = 11
        Me.btnTransaksi.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(584, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Data Transaksi"
        '
        'btnLogout
        '
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(365, 326)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(61, 43)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(361, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Logout"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 443)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnTransaksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPembeli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPegawai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnObat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnObat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPembeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnObat As PictureBox
    Friend WithEvents btnPegawai As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPembeli As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTransaksi As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogout As PictureBox
    Friend WithEvents Label7 As Label
End Class
