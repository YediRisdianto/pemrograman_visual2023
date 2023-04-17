Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If (Val(txtNilaiAkhir.Text) >= 60) Then
            txtKeterangan.Text = "Selamat, Anda Lulus"
        Else
            txtKeterangan.Text = "Maaf, Anda tidak Lulus"
        End If

    End Sub

End Class