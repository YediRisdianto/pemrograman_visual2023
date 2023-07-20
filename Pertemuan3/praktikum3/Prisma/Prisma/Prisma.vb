Public Class Prisma
    Private Function HitungVol(luasAlas As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = luasAlas * tinggi
        Return volume
    End Function

    Private Function HitungLP(tinggi As Integer, kelilingAlas As Integer, luasAlas As Integer) As Integer
        Dim luasPermukaan As Integer
        luasPermukaan = (tinggi * kelilingAlas) + (2 * luasAlas)
        Return luasPermukaan
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim luasAlas, kelilingAlas, tinggi, volume, luasPermukaan As Integer

        luasAlas = Val(txtLuasAlas.Text)
        kelilingAlas = Val(txtKelilingAlas.Text)
        tinggi = Val(txtTinggi.Text)

        volume = HitungVol(luasAlas, tinggi)
        luasPermukaan = HitungLP(tinggi, kelilingAlas, luasAlas)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luasPermukaan)

    End Sub

End Class
