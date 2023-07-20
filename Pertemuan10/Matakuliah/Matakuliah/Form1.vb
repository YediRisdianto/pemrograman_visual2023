Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMatakuliah.getAllData(DataGridView1)
    End Sub

    Private Sub txtKodeMK_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeMK.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMatakuliah.Carimahasiswa(txtKodeMK.Text)
            If (matakuliah_baru = False) Then
                TampilMatakuliah()
            Else
                MessageBox.Show("Data Not Found")
            End If
        End If
    End Sub

    Private Sub TampilMatakuliah()
        txtKodeMK.Text = oMatakuliah.kodemk
        txtNamaMK.Text = oMatakuliah.namamk
        txtSKS.Text = oMatakuliah.sks
        txtProdi.Text = oMatakuliah.prodi
    End Sub

    Private Sub SimpanDataMatakuliah()
        oMatakuliah.kodemk = txtKodeMK.Text
        oMatakuliah.namamk = txtNamaMK.Text
        oMatakuliah.sks = txtSKS.Text
        oMatakuliah.prodi = txtProdi.Text
        oMatakuliah.Simpan()
        Reload()
        If (oMatakuliah.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan")
        ElseIf (oMatakuliah.UpdateState) Then
            MessageBox.Show("Data Berhasil Diperbarui")
        Else
            MessageBox.Show("Data Gagal Tersimpan")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKodeMK.Text <> "" And txtNamaMK.Text <> "") Then
            SimpanDataMatakuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("kodemk dan namamk Tidak Boleh Kosong")
        End If
    End Sub


    Private Sub Hapus()
        If (matakuliah_baru = False And txtKodeMK.Text <> "") Then
            oMatakuliah.Hapus(txtKodeMK.Text)
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
        txtKodeMK.Clear()
        txtNamaMK.Clear()
        txtSKS.Clear()
        txtProdi.Clear()
        txtKodeMK.Focus()
    End Sub

End Class
