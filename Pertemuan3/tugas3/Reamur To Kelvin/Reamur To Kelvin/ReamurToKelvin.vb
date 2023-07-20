Public Class ReamurToKelvin
    Private Function convert(reamur As Integer) As Integer
        Dim konversi As Integer
        konversi = 5 / 4 * (reamur + 273)
        Return konversi
    End Function
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim reamur, kelvin As Integer

        reamur = Val(txtReamur.Text)

        kelvin = convert(reamur)

        txtKelvin.Text = Str(kelvin)

    End Sub

End Class
