Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Select Case txtTitle.Text
            Case "RKT" : txtKeterangan.Text = "Rektor"

            Case "DSN" : txtKeterangan.Text = "Dosen"

            Case "MHS" : txtKeterangan.Text = "Mahasiswa"

            Case Else : txtKeterangan.Text = "Staff"
        End Select

    End Sub
End Class