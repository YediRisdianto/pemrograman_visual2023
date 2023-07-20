
Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Transaksi
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        Dim dashboard = New Dashboard
        dashboard.Show()
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(transaksi_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of classTransaksi) = JsonConvert.DeserializeObject(Of List(Of classTransaksi))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data

    End Sub

    Private Sub txtKodeTransaksi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeTransaksi.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(transaksi_api & "?kode_transaksi=" & txtKodeTransaksi.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        transaksi_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        transaksi_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (transaksi_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of classTransaksi) = JsonConvert.DeserializeObject(Of List(Of classTransaksi))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As classTransaksi In data
                            txtKodeTransaksi.Text = mydata.kode_transaksi
                            txtKodeObat.Text = mydata.kode_obat
                            txtKodePegawai.Text = mydata.kode_pegawai
                            txtKodePembeli.Text = mydata.kode_pembeli
                            txtJumlahObat.Text = mydata.jumlah_obat
                            txtHargaSatuan.Text = mydata.harga_satuan
                            txtTotalHarga.Text = mydata.total_harga
                        Next

                    End If

                End Try

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")
            End If
        End Using
    End Sub

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim kode_transaksi As String = txtKodeTransaksi.Text
        Dim kode_obat As String = txtKodeObat.Text
        Dim kode_pegawai As String = txtKodePegawai.Text
        Dim kode_pembeli As String = txtKodePembeli.Text
        Dim jumlah_obat As String = txtJumlahObat.Text
        Dim harga_satuan As String = txtHargaSatuan.Text
        Dim total_harga As String = txtTotalHarga.Text

        Dim postData As String = $"kode_transaksi={kode_transaksi}&kode_obat={kode_obat}&kode_pegawai={kode_pegawai}&kode_pembeli={kode_pembeli}&jumlah_obat={jumlah_obat}&harga_satuan={harga_satuan}&total_harga={total_harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(transaksi_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetClear()
        txtKodeTransaksi.Clear()
        txtKodeObat.Clear()
        txtKodePegawai.Clear()
        txtKodePembeli.Clear()
        txtJumlahObat.Clear()
        txtHargaSatuan.Clear()
        txtTotalHarga.Clear()
        Reloaded()
        txtKodeTransaksi.Focus()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kode_transaksi As String = txtKodeTransaksi.Text
        Dim kode_obat As String = txtKodeObat.Text
        Dim kode_pegawai As String = txtKodePegawai.Text
        Dim kode_pembeli As String = txtKodePembeli.Text
        Dim jumlah_obat As String = txtJumlahObat.Text
        Dim harga_satuan As String = txtHargaSatuan.Text
        Dim total_harga As String = txtTotalHarga.Text

        Dim postData As String = $"kode_transaksi={kode_transaksi}&kode_obat={kode_obat}&kode_pegawai={kode_pegawai}&kode_pembeli={kode_pembeli}&jumlah_obat={jumlah_obat}&harga_satuan={harga_satuan}&total_harga={total_harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(transaksi_api & "?kode_transaksi=" & txtKodeTransaksi.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (transaksi_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim kode_transaksi As String = txtKodeTransaksi.Text
        Dim kode_obat As String = txtKodeObat.Text
        Dim kode_pegawai As String = txtKodePegawai.Text
        Dim kode_pembeli As String = txtKodePembeli.Text
        Dim jumlah_obat As String = txtJumlahObat.Text
        Dim harga_satuan As String = txtHargaSatuan.Text
        Dim total_harga As String = txtTotalHarga.Text

        Dim postData As String = $"kode_transaksi={kode_transaksi}&kode_obat={kode_obat}&kode_pegawai={kode_pegawai}&kode_pembeli={kode_pembeli}&jumlah_obat={jumlah_obat}&harga_satuan={harga_satuan}&total_harga={total_harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(transaksi_api & "?kode_transaksi=" & txtKodeTransaksi.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (transaksi_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim jumlah_obat As Integer
        Dim harga_satuan As Integer

        If Integer.TryParse(txtJumlahObat.Text, jumlah_obat) AndAlso Integer.TryParse(txtHargaSatuan.Text, harga_satuan) Then

            Dim total_biaya As Integer = jumlah_obat * harga_satuan

            txtTotalHarga.Text = total_biaya.ToString()

        End If
    End Sub

End Class