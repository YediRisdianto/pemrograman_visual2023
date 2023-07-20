Public Class Form2
    Private Sub btnForm1_Click(sender As Object, e As EventArgs) Handles btnForm1.Click
        Dim F1 As New Form1
        F1.ShowDialog()
    End Sub

    Private Sub btnForm3_Click(sender As Object, e As EventArgs) Handles btnForm3.Click
        Dim F3 As New Form3
        F3.ShowDialog()
    End Sub

End Class