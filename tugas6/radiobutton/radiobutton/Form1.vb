Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim harga As Integer

        'Cek kategori tiket yang dipilih
        If radioAnak.Checked Then
            harga = 20000 'Harga tiket anak-anak
        ElseIf radioDewasa.Checked Then
            harga = 30000 'Harga tiket dewasa
        Else
            MessageBox.Show("Pilih kategori tiket terlebih dahulu")
            Exit Sub
        End If

        'Tampilkan harga tiket
        txtHargaTiket.Text = harga.ToString

    End Sub

End Class
