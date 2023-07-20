
Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Pembeli
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        Dim dashboard = New Dashboard
        dashboard.Show()
    End Sub

    Private Sub Pembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(pembeli_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of classPembeli) = JsonConvert.DeserializeObject(Of List(Of classPembeli))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data

    End Sub

    Private Sub txtKodePembeli_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodePembeli.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(pembeli_api & "?kode_pembeli=" & txtKodePembeli.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        pembeli_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        pembeli_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (pembeli_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of classPembeli) = JsonConvert.DeserializeObject(Of List(Of classPembeli))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As classPembeli In data
                            txtKodePembeli.Text = mydata.kode_pembeli
                            txtNamaPembeli.Text = mydata.nama_pembeli
                            txtTelepon.Text = mydata.telepon
                            txtAlamat.Text = mydata.alamat
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
        Dim kode_pembeli As String = txtKodePembeli.Text
        Dim nama_pembeli As String = txtNamaPembeli.Text
        Dim telepon As String = txtTelepon.Text
        Dim alamat As String = txtAlamat.Text

        Dim postData As String = $"kode_pembeli={kode_pembeli}&nama_pembeli={nama_pembeli}&telepon={telepon}&alamat={alamat}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pembeli_api, "POST", byteArray)

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub GetClear()
        txtKodePembeli.Clear()
        txtNamaPembeli.Clear()
        txtTelepon.Clear()
        txtAlamat.Clear()
        Reloaded()
        txtKodePembeli.Focus()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kode_pembeli As String = txtKodePembeli.Text
        Dim nama_pembeli As String = txtNamaPembeli.Text
        Dim telepon As String = txtTelepon.Text
        Dim alamat As String = txtAlamat.Text

        Dim postData As String = $"kode_pembeli={kode_pembeli}&nama_pembeli={nama_pembeli}&telepon={telepon}&alamat={alamat}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pembeli_api & "?kode_pembeli=" & txtKodePembeli.Text, "PUT", byteArray)

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
        If (pembeli_baru = False) Then
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
        Dim kode_pembeli As String = txtKodePembeli.Text
        Dim nama_pembeli As String = txtNamaPembeli.Text
        Dim telepon As String = txtTelepon.Text
        Dim alamat As String = txtAlamat.Text

        Dim postData As String = $"kode_pembeli={kode_pembeli}&nama_pembeli={nama_pembeli}&telepon={telepon}&alamat={alamat}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pembeli_api & "?kode_pembeli=" & txtKodePembeli.Text, "DELETE", byteArray)

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
        If (pembeli_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

End Class