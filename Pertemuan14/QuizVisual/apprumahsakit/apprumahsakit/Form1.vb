
Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form1
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nip As String = txtNip.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJk.Text
        Dim spesialis As String = txtSpesialis.Text

        Dim postData As String = $"nip={nip}&nama={nama}&jk={jk}&spesialis={spesialis}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(dokter_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        getClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim nip As String = txtNip.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJk.Text
        Dim spesialis As String = txtSpesialis.Text

        Dim postData As String = $"nip={nip}&nama={nama}&jk={jk}&spesialis={spesialis}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(dokter_api & "?nip=" & txtNip.Text, "PUT", byteArray)

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
        Dim nip As String = txtNip.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJk.Text
        Dim spesialis As String = txtSpesialis.Text

        Dim postData As String = $"nip={nip}&nama={nama}&jk={jk}&spesialis={spesialis}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(dokter_api & "?nip=" & txtNip.Text, "DELETE", byteArray)

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
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(dokter_api & "?nip=" & txtNip.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        dokter_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        dokter_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (dokter_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of dokter) = JsonConvert.DeserializeObject(Of List(Of dokter))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As dokter In data
                            txtNip.Text = mydata.nip
                            txtNama.Text = mydata.nama
                            txtJk.Text = mydata.jk
                            txtSpesialis.Text = mydata.spesialis
                        Next
                    End If

                End Try

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(dokter_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of dokter) = JsonConvert.DeserializeObject(Of List(Of dokter))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (dokter_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub
    Private Sub GetClear()
        txtNip.Clear()
        txtNama.Clear()
        txtJk.Clear()
        txtSpesialis.Clear()
        Reloaded()
        txtNip.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (dokter_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub txtNip_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNip.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

End Class
