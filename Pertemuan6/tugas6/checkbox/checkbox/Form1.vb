Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim hargaBarang As Double
        Dim jumlahBarang As Integer
        Dim totalbyr As Double

        hargaBarang = CDbl(txtHarga.Text)
        jumlahBarang = CInt(txtJumlah.Text)
        totalbyr = hargaBarang * jumlahBarang
        If checkMember.Checked Then
            totalbyr *= 0.9 'diskon 10% untuk anggota
        End If

        txtTotal.Text = Format(totalbyr, "N0")
    End Sub

End Class
