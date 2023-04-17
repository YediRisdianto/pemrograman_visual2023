Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If (Val(txtTensi.Text) >= 125) Then
            txtKeterangan.Text = "Anda mengalami Hipertensi"

        ElseIf (txtTensi.Text >= 110) Then
            txtKeterangan.Text = "Tensi Darah Anda Normal"

        Else
            txtKeterangan.Text = "Anda mengalami Hipotensi"
        End If

    End Sub

End Class
