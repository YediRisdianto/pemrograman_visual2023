Public Class FormSegitiga
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim sisiA, sisiB, sisiC, alas, tinggi, luas, keliling As Integer

        sisiA = Val(txtSisiA.Text)
        sisiB = Val(txtSisiB.Text)
        sisiC = Val(txtSisiC.Text)
        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)

        luas = 0.5 * alas * tinggi
        keliling = sisiA + sisiB + sisiC

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)


    End Sub
End Class
