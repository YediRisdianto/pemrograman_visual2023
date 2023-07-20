Public Class Form3
    Private Sub btnForm1_Click(sender As Object, e As EventArgs) Handles btnForm1.Click
        Dim F1 As New Form1
        F1.ShowDialog()
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Dim F2 As New Form2
        F2.ShowDialog()
    End Sub

End Class