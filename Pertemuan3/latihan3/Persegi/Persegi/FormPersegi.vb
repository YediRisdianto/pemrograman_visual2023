Public Class FormPersegi
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim sisi, luas, keliling As Integer

        sisi = Val(txtSisi.Text)

        luas = sisi * sisi
        keliling = 4 * sisi

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub

End Class
