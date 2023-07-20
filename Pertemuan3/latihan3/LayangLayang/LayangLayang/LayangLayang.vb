Public Class LayangLayang
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim sisiA, sisiB, sisiC, sisiD, d1, d2, luas, keliling As Integer

        sisiA = Val(txtSisiA.Text)
        sisiB = Val(txtSisiB.Text)
        sisiC = Val(txtSisiC.Text)
        sisiD = Val(txtSisiD.Text)
        d1 = Val(txtDiagonal1.Text)
        d2 = Val(txtDiagonal2.Text)

        luas = 0.5 * d1 * d2
        keliling = sisiA + sisiB + sisiC + sisiD

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)


    End Sub
End Class
