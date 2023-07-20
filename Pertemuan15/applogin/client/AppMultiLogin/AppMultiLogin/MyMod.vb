Module MyMod

    Public api_folder As String = "applogin"
    Public users_api As String = "http://localhost/" & api_folder & "/users_api.php"
    Public Dashboard As New Form1
    Public Admin1Form As New Admin1
    Public Admin2Form As New Admin2
    Public Dosen1Form As New Dosen1
    Public Dosen2Form As New Dosen2
    Public Mahasiswa1Form As New Mhs1
    Public Mahasiswa2Form As New Mhs2
    Public LoginForm As New Login
    Public admin_role As Boolean = False
    Public dosen_role As Boolean = False
    Public mahasiswa_role As Boolean = False
    Public login_valid As Boolean = False

End Module
