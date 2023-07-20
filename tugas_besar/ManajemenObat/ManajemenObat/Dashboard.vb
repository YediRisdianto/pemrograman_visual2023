Public Class Dashboard
    Private Sub btnObat_Click(sender As Object, e As EventArgs) Handles btnObat.Click
        Me.Hide()
        Dim obat = New Obat
        obat.Show()
    End Sub

    Private Sub btnPegawai_Click(sender As Object, e As EventArgs) Handles btnPegawai.Click
        Me.Hide()
        Dim pegawai = New Pegawai
        pegawai.Show()
    End Sub

    Private Sub btnPembeli_Click(sender As Object, e As EventArgs) Handles btnPembeli.Click
        Me.Hide()
        Dim pembeli = New Pembeli
        pembeli.Show()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Me.Hide()
        Dim transaksi = New Transaksi
        transaksi.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim login = New Login
        login.Show()
    End Sub



End Class