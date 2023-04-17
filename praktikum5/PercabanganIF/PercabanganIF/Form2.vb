Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If (Val(txtNilai.Text) >= 80) Then
            txtKeterangan.Text = "Anda Berada di Kelas A"

        ElseIf (txtNilai.Text >= 60) Then
            txtKeterangan.Text = "Anda Berada di Kelas B"

        ElseIf (txtNilai.Text >= 40) Then
            txtKeterangan.Text = "Anda Berada di Kelas C"

        Else
            txtKeterangan.Text = "Anda Berada di Kelas D"
        End If

    End Sub
End Class