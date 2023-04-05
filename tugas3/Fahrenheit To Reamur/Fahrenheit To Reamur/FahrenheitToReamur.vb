Public Class FahrenheitToReamur
    Private Function convert(fahrenheit As Integer) As Integer
        Dim konversi As Integer
        konversi = 4 / 9 * (fahrenheit - 32)
        Return konversi
    End Function
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim fahrenheit, reamur As Integer

        fahrenheit = Val(txtFahrenheit.Text)

        reamur = convert(fahrenheit)

        txtReamur.Text = Str(reamur)

    End Sub

End Class
