Public Class Bola
    Private Function HitungVol(jari As Integer) As Integer
        Dim volume As Integer
        volume = 4 / 3 * 3.14 * jari * jari * jari
        Return volume
    End Function

    Private Function HitungLP(jari As Integer) As Integer
        Dim luasPermukaan As Integer
        luasPermukaan = 4 * 3.14 * jari * jari
        Return luasPermukaan
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, volume, luasPermukaan As Integer

        jari = Val(txtJari.Text)

        volume = HitungVol(jari)
        luasPermukaan = HitungLP(jari)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luasPermukaan)

    End Sub

End Class
