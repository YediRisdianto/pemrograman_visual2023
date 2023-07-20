Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim nim, nama, prodi, nilai_kehadiran, nilai_tugas, nilai_uts, nilai_uas, nilai_akhir, nilai_mutu As Integer

        nim = Val(txtNim.Text)
        nama = Val(txtNama.Text)
        prodi = Val(txtProdi.Text)
        nilai_kehadiran = Val(txtKehadiran.Text)
        nilai_tugas = Val(txtTgs.Text)
        nilai_uts = Val(txtUts.Text)
        nilai_uas = Val(txtUas.Text)
        nilai_akhir = Val(txtNilaiAkhir.Text)
        nilai_mutu = Val(txtNilaiMutu.Text)

        nilai_akhir = (0.2 * nilai_kehadiran) + (0.35 * nilai_tugas) + (0.2 * nilai_uts) + (0.2 * nilai_uas)
        txtNilaiAkhir.Text = (nilai_akhir)

        If (Val(txtNilaiAkhir.Text) >= 85) Then
            txtNilaiMutu.Text = "A"
        ElseIf (Val(txtNilaiAkhir.Text) >= 75) Then
            txtNilaiMutu.Text = "B"
        ElseIf (Val(txtNilaiAkhir.Text) >= 55) Then
            txtNilaiMutu.Text = "C"
        ElseIf (Val(txtNilaiAkhir.Text) >= 30) Then
            txtNilaiMutu.Text = "D"
        ElseIf (Val(txtNilaiAkhir.Text) >= 0) Then
            txtNilaiMutu.Text = "E"
        Else
            txtNilaiMutu.Text = "Coba Ulang"
        End If

    End Sub

End Class
