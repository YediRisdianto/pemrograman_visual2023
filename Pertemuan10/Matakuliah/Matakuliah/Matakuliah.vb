Public Class Matakuliah
    Dim strsql As String
    Dim info As String
    Private _idmk As Integer
    Private _kodemk As String
    Private _namamk As String
    Private _sks As String
    Private _prodi As String
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False
    Public Property kodemk()
        Get
            Return _kodemk
        End Get
        Set(ByVal value)
            _kodemk = value
        End Set
    End Property
    Public Property namamk()
        Get
            Return _namamk
        End Get
        Set(ByVal value)
            _namamk = value
        End Set
    End Property
    Public Property sks()
        Get
            Return _sks
        End Get
        Set(ByVal value)
            _sks = value
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
            strsql = "SELECT * FROM matakuliah limit 100"
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

    Public Sub Carimahasiswa(ByVal skodemk As String)
        DBConnect()
        strsql = "SELECT * FROM matakuliah WHERE kodemk='" & skodemk & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            matakuliah_baru = False
            DR.Read()
            kodemk = Convert.ToString((DR("kodemk")))
            namamk = Convert.ToString((DR("namamk")))
            sks = Convert.ToString((DR("sks")))
            prodi = Convert.ToString((DR("prodi")))
        Else
            MessageBox.Show("Data Not Found")
            matakuliah_baru = True
        End If
        DBDisconnect()
    End Sub

    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (matakuliah_baru = True) Then
            strsql = "INSERT INTO matakuliah(kodemk,namamk,sks,prodi) values ('" & _kodemk & "','" & _namamk & "','" & _sks & "','" & _prodi & "')"
            info = "INSERT"
        Else
            strsql = "UPDATE matakuliah SET kodemk='" & _kodemk & "', namamk='" & _namamk & "', sks='" & _sks & "', prodi='" & _prodi & "' where kodemk='" & _kodemk & "'"
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

    Public Sub Hapus(ByVal skodemk As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM matakuliah WHERE kodemk='" & _kodemk & "'"
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
