Public Class Form1
    Private Sub Admin1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Admin1ToolStripMenuItem.Click
        Admin1Form.ShowDialog()
    End Sub

    Private Sub Admin2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Admin2ToolStripMenuItem.Click
        Admin2Form.ShowDialog()
    End Sub

    Private Sub Dosen1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Dosen1ToolStripMenuItem.Click
        Dosen1Form.ShowDialog()
    End Sub

    Private Sub Dosen2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Dosen2ToolStripMenuItem.Click
        Dosen2Form.ShowDialog()
    End Sub

    Private Sub Mahasiswa1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mahasiswa1ToolStripMenuItem.Click
        Mahasiswa1Form.ShowDialog()
    End Sub

    Private Sub Mahasiswa2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mahasiswa2ToolStripMenuItem.Click
        Mahasiswa2Form.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatikanSemuaMenu()

    End Sub

    Private Sub MatikanSemuaMenu()
        MenuAdminBar.Visible = False
        MenuDosenBar.Visible = False
        MenuMahasiswaBar.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        LoginForm.ShowDialog()

    End Sub

    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah Admin
        If (admin_role = True) Then
            MenuAdminBar.Visible = True
            MenuDosenBar.Visible = False
            MenuMahasiswaBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah Dosen
        If (dosen_role = True) Then
            MenuAdminBar.Visible = False
            MenuDosenBar.Visible = True
            MenuMahasiswaBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah mahasiswa
        If (mahasiswa_role = True) Then
            MenuAdminBar.Visible = False
            MenuDosenBar.Visible = False
            MenuMahasiswaBar.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If
    End Sub

    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub
End Class
