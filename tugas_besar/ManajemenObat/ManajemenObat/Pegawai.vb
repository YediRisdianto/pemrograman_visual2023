Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Pegawai
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        Dim dashboard = New Dashboard
        dashboard.Show()
    End Sub

    Private Sub Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(pegawai_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of classPegawai) = JsonConvert.DeserializeObject(Of List(Of classPegawai))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data

    End Sub

    Private Sub txtKdPegawai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodePegawai.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(pegawai_api & "?kode_pegawai=" & txtKodePegawai.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        pegawai_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        pegawai_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (pegawai_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of classPegawai) = JsonConvert.DeserializeObject(Of List(Of classPegawai))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As classPegawai In data
                            txtKodePegawai.Text = mydata.kode_pegawai
                            txtNamaPegawai.Text = mydata.nama_pegawai
                            txtTelepon.Text = mydata.telepon
                            txtAlamat.Text = mydata.alamat
                            txtEmail.Text = mydata.email
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
        Dim kode_pegawai As String = txtKodePegawai.Text
        Dim nama_pegawai As String = txtNamaPegawai.Text
        Dim telepon As String = txtTelepon.Text
        Dim alamat As String = txtAlamat.Text
        Dim email As String = txtEmail.Text

        Dim postData As String = $"kode_pegawai={kode_pegawai}&nama_pegawai={nama_pegawai}&telepon={telepon}&alamat={alamat}&email={email}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pegawai_api, "POST", byteArray)

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
        txtKodePegawai.Clear()
        txtNamaPegawai.Clear()
        txtTelepon.Clear()
        txtAlamat.Clear()
        txtEmail.Clear()
        Reloaded()
        txtKodePegawai.Focus()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kode_pegawai As String = txtKodePegawai.Text
        Dim nama_pegawai As String = txtNamaPegawai.Text
        Dim telepon As String = txtTelepon.Text
        Dim alamat As String = txtAlamat.Text
        Dim email As String = txtEmail.Text

        Dim postData As String = $"kode_pegawai={kode_pegawai}&nama_pegawai={nama_pegawai}&telepon={telepon}&alamat={alamat}&email={email}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pegawai_api & "?kode_pegawai=" & txtKodePegawai.Text, "PUT", byteArray)

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
        If (pegawai_baru = False) Then
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
        Dim kode_pegawai As String = txtKodePegawai.Text
        Dim nama_pegawai As String = txtNamaPegawai.Text
        Dim telepon As String = txtTelepon.Text
        Dim alamat As String = txtAlamat.Text
        Dim email As String = txtEmail.Text

        Dim postData As String = $"kode_pegawai={kode_pegawai}&nama_pegawai={nama_pegawai}&telepon={telepon}&alamat={alamat}&email={email}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pegawai_api & "?kode_pegawai=" & txtKodePegawai.Text, "DELETE", byteArray)

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
        If (pegawai_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

End Class