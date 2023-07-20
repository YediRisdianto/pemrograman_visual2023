
Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form2
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nrp As String = txtNrp.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJk.Text
        Dim tgl_lahir As String = txtTanggal.Text
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api, "POST", byteArray)

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

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim nrp As String = txtNrp.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJk.Text
        Dim tgl_lahir = txtTanggal.Text
        tgl_lahir = Convert.ToDateTime(tgl_lahir).ToString("yyyy-MM-dd")
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nrp=" & txtNrp.Text, "PUT", byteArray)

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

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim nrp As String = txtNrp.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJk.Text
        Dim tgl_lahir As String = txtTanggal.Text
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nrp=" & txtNrp.Text, "DELETE", byteArray)

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

    Private Sub GetData()
        ' Create a new HttpClient instance
        Using client As New HttpClient()
            Try
                ' Send a GET request to the API endpoint
                Dim response As HttpResponseMessage = client.GetAsync(pasien_api & "?nrp=" & txtNrp.Text).Result

                ' Check if the request was successful
                If response.IsSuccessStatusCode Then
                    ' Read the response content as a string
                    Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                    Try
                        If (jsonString = "[]") Then
                            MessageBox.Show("Data Not Found")
                        Else
                            ' Deserialize the JSON into objects
                            Dim data As List(Of pasien) = JsonConvert.DeserializeObject(Of List(Of pasien))(jsonString)

                            For Each mydata As pasien In data
                                txtNrp.Text = mydata.nrp
                                txtNama.Text = mydata.nama
                                txtJk.Text = mydata.jk
                                txtTanggal.Text = mydata.tgl_lahir
                                txtAlamat.Text = mydata.alamat
                                txtKota.Text = mydata.kota
                            Next
                        End If
                    Catch ex As Exception
                        ' Handle any errors that occur during deserialization
                        MessageBox.Show("An error occurred during deserialization: " & ex.Message, "Error")
                    End Try
                Else
                    ' Request failed, handle the error
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")
                End If
            Catch ex As Exception
                ' Handle any errors that occur during the request
                MessageBox.Show("An error occurred: " & ex.Message, "Error")
            End Try
        End Using
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(pasien_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of pasien) = JsonConvert.DeserializeObject(Of List(Of pasien))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub
    Private Sub GetClear()
        txtNrp.Clear()
        txtNama.Clear()
        txtJk.Clear()
        txtTanggal.Clear()
        txtAlamat.Clear()
        txtKota.Clear()
        Reloaded()
        txtNrp.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If (pasien_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub txtNrp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNrp.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (pasien_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub
End Class