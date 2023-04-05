Public Class CelciusToFahrenheit

    Private Function convert(celcius As Integer) As Integer
        Dim konversi As Integer
        konversi = (9 / 5 * celcius) + 32
        Return konversi
    End Function
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim celcius, fahrenheit As Integer

        celcius = Val(txtCelcius.Text)

        fahrenheit = convert(celcius)

        txtFahrenheit.Text = Str(fahrenheit)

    End Sub

End Class
