Public Class Kubus

    Private Function HitungVol(sisi As Integer) As Integer
        Dim volume As Integer
        volume = sisi * sisi * sisi
        Return volume
    End Function

    Private Function HitungLP(sisi As Integer) As Integer
        Dim luasPermukaan As Integer
        luasPermukaan = 6 * sisi * sisi
        Return luasPermukaan
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, volume, luasPermukaan As Integer

        sisi = Val(txtSisi.Text)

        volume = HitungVol(sisi)
        luasPermukaan = HitungLP(sisi)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luasPermukaan)

    End Sub

End Class
