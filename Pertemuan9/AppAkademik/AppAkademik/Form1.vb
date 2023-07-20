Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMahasiswa.getAllData(DataGridView1)
    End Sub

    Private Sub txtNim_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNim.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMahasiswa.Carimahasiswa(txtNim.Text)
            If (mahasiswa_baru = False) Then
                TampilMahasiswa()
            Else
                MessageBox.Show("Data Not Found")
            End If
        End If
    End Sub

    Private Sub TampilMahasiswa()
        txtNim.Text = oMahasiswa.nim
        txtNama.Text = oMahasiswa.nama
        txtJk.Text = oMahasiswa.jk
        txtProdi.Text = oMahasiswa.prodi
    End Sub

    Private Sub SimpanDataMahasiswa()
        oMahasiswa.nim = txtNim.Text
        oMahasiswa.nama = txtNama.Text
        oMahasiswa.jk = txtJk.Text
        oMahasiswa.prodi = txtProdi.Text
        oMahasiswa.Simpan()
        Reload()
        If (oMahasiswa.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan")
        ElseIf (oMahasiswa.UpdateState) Then
            MessageBox.Show("Data Berhasil Diperbarui")
        Else
            MessageBox.Show("Data Gagal Tersimpan")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtNim.Text <> "" And txtNama.Text <> "") Then
            SimpanDataMahasiswa()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("NIM dan Nama Tidak Boleh Kosong")
        End If
    End Sub


    Private Sub Hapus()
        If (mahasiswa_baru = False And txtNim.Text <> "") Then
            oMahasiswa.Hapus(txtNim.Text)
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah data akan dihapus?", "confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data Batal Dihapus")
        End If
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtNim.Clear()
        txtNama.Clear()
        txtJk.Clear()
        txtProdi.Clear()
        txtNim.Focus()
    End Sub

End Class
