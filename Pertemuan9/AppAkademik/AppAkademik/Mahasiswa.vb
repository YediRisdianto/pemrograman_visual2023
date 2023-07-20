Public Class Mahasiswa
    Dim strsql As String
    Dim info As String
    Private _id As Integer
    Private _nim As String
    Private _nama As String
    Private _jk As String
    Private _prodi As String
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False
    Public Property nim()
        Get
            Return _nim
        End Get
        Set(ByVal value)
            _nim = value
        End Set
    End Property
    Public Property nama()
        Get
            Return _nama
        End Get
        Set(ByVal value)
            _nama = value
        End Set
    End Property
    Public Property jk()
        Get
            Return _jk
        End Get
        Set(ByVal value)
            _jk = value
        End Set
    End Property
    Public Property prodi()
        Get
            Return _prodi
        End Get
        Set(ByVal value)
            _prodi = value
        End Set
    End Property

    Public Sub getAllData(ByVal dg As DataGridView)
        Try
            DBConnect()
            strsql = "SELECT * FROM mahasiswa limit 100"
            myCommand.Connection = conn
            myCommand.CommandText = strsql
            myData.Clear()
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With dg
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DBDisconnect()
        End Try
    End Sub

    Public Sub Carimahasiswa(ByVal snim As String)
        DBConnect()
        strsql = "SELECT * FROM mahasiswa WHERE nim='" & snim & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            mahasiswa_baru = False
            DR.Read()
            nim = Convert.ToString((DR("nim")))
            nama = Convert.ToString((DR("nama")))
            jk = Convert.ToString((DR("jk")))
            prodi = Convert.ToString((DR("prodi")))
        Else
            MessageBox.Show("Data Not Found")
            mahasiswa_baru = True
        End If
        DBDisconnect()
    End Sub

    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (mahasiswa_baru = True) Then
            strsql = "INSERT INTO mahasiswa(nim,nama,jk,prodi) values ('" & _nim & "','" & _nama & "','" & _jk & "','" & _prodi & "')"
            info = "INSERT"
        Else
            strsql = "UPDATE mahasiswa SET nim='" & _nim & "', nama='" & _nama & "', jk='" & _jk & "', prodi='" & _prodi & "' where nim='" & _nim & "'"
            info = "UPDATE"
        End If
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            If (info = "INSERT") Then
                InsertState = False
            ElseIf (info = "UPDATE") Then
                UpdateState = False
            Else
            End If
        Finally
            If (info = "INSERT") Then
                InsertState = True
            ElseIf (info = "UPDATE") Then
                UpdateState = True
            Else
            End If
        End Try
        DBDisconnect()
    End Sub

    Public Sub Hapus(ByVal snim As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM mahasiswa WHERE nim='" & _nim & "'"
        info = "DELETE"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        Try
            myCommand.ExecuteNonQuery()
            DeleteState = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        DBDisconnect()
    End Sub


End Class
