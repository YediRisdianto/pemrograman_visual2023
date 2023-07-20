<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdminBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Admin1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Admin2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDosenBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dosen1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dosen2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMahasiswaBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mahasiswa1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mahasiswa2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuAdminBar, Me.MenuDosenBar, Me.MenuMahasiswaBar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(694, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginBar, Me.LogoutBar, Me.ExitBar})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginBar
        '
        Me.LoginBar.Name = "LoginBar"
        Me.LoginBar.Size = New System.Drawing.Size(152, 22)
        Me.LoginBar.Text = "Login"
        '
        'LogoutBar
        '
        Me.LogoutBar.Name = "LogoutBar"
        Me.LogoutBar.Size = New System.Drawing.Size(152, 22)
        Me.LogoutBar.Text = "Logout"
        '
        'ExitBar
        '
        Me.ExitBar.Name = "ExitBar"
        Me.ExitBar.Size = New System.Drawing.Size(152, 22)
        Me.ExitBar.Text = "Exit"
        '
        'MenuAdminBar
        '
        Me.MenuAdminBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Admin1ToolStripMenuItem, Me.Admin2ToolStripMenuItem})
        Me.MenuAdminBar.Name = "MenuAdminBar"
        Me.MenuAdminBar.Size = New System.Drawing.Size(89, 20)
        Me.MenuAdminBar.Text = "Menu Admin"
        '
        'Admin1ToolStripMenuItem
        '
        Me.Admin1ToolStripMenuItem.Name = "Admin1ToolStripMenuItem"
        Me.Admin1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Admin1ToolStripMenuItem.Text = "Admin-1"
        '
        'Admin2ToolStripMenuItem
        '
        Me.Admin2ToolStripMenuItem.Name = "Admin2ToolStripMenuItem"
        Me.Admin2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Admin2ToolStripMenuItem.Text = "Admin-2"
        '
        'MenuDosenBar
        '
        Me.MenuDosenBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Dosen1ToolStripMenuItem, Me.Dosen2ToolStripMenuItem})
        Me.MenuDosenBar.Name = "MenuDosenBar"
        Me.MenuDosenBar.Size = New System.Drawing.Size(86, 20)
        Me.MenuDosenBar.Text = "Menu Dosen"
        '
        'Dosen1ToolStripMenuItem
        '
        Me.Dosen1ToolStripMenuItem.Name = "Dosen1ToolStripMenuItem"
        Me.Dosen1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Dosen1ToolStripMenuItem.Text = "Dosen-1"
        '
        'Dosen2ToolStripMenuItem
        '
        Me.Dosen2ToolStripMenuItem.Name = "Dosen2ToolStripMenuItem"
        Me.Dosen2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Dosen2ToolStripMenuItem.Text = "Dosen-2"
        '
        'MenuMahasiswaBar
        '
        Me.MenuMahasiswaBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mahasiswa1ToolStripMenuItem, Me.Mahasiswa2ToolStripMenuItem})
        Me.MenuMahasiswaBar.Name = "MenuMahasiswaBar"
        Me.MenuMahasiswaBar.Size = New System.Drawing.Size(111, 20)
        Me.MenuMahasiswaBar.Text = "Menu Mahasiswa"
        '
        'Mahasiswa1ToolStripMenuItem
        '
        Me.Mahasiswa1ToolStripMenuItem.Name = "Mahasiswa1ToolStripMenuItem"
        Me.Mahasiswa1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Mahasiswa1ToolStripMenuItem.Text = "Mahasiswa-1"
        '
        'Mahasiswa2ToolStripMenuItem
        '
        Me.Mahasiswa2ToolStripMenuItem.Name = "Mahasiswa2ToolStripMenuItem"
        Me.Mahasiswa2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Mahasiswa2ToolStripMenuItem.Text = "Mahasiswa-2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 448)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginBar As ToolStripMenuItem
    Friend WithEvents LogoutBar As ToolStripMenuItem
    Friend WithEvents MenuAdminBar As ToolStripMenuItem
    Friend WithEvents Admin1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Admin2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuDosenBar As ToolStripMenuItem
    Friend WithEvents Dosen1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Dosen2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuMahasiswaBar As ToolStripMenuItem
    Friend WithEvents Mahasiswa1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mahasiswa2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitBar As ToolStripMenuItem
End Class
