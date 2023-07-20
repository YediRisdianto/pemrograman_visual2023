Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Select Case txtKendaraan.Text
            Case "PSW" : txtKeterangan.Text = "Pesawat"

            Case "KPL" : txtKeterangan.Text = "Kapal"

            Case "MBL" : txtKeterangan.Text = "Mobil"

            Case "MTR" : txtKeterangan.Text = "Motor"

            Case Else : txtKeterangan.Text = "Sepeda"
        End Select

    End Sub
End Class
