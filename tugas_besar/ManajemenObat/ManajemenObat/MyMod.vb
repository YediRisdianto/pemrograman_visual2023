Module MyMod

    Public api_folder As String = "apotek"
    Public users_api As String = "http://f0833870.xsph.ru/" & api_folder & "/users_api.php"

    Public Admin As New Dashboard
    Public Login As New Login
    Public admin_role As Boolean = False
    Public login_valid As Boolean = False

    Public obat_api As String = "http://f0833870.xsph.ru/" & api_folder & "/obat_api.php"
    Public obat_baru As Boolean

    Public pegawai_api As String = "http://f0833870.xsph.ru/" & api_folder & "/pegawai_api.php"
    Public pegawai_baru As Boolean

    Public pembeli_api As String = "http://f0833870.xsph.ru/" & api_folder & "/pembeli_api.php"
    Public pembeli_baru As Boolean

    Public transaksi_api As String = "http://f0833870.xsph.ru/" & api_folder & "/transaksi_api.php"
    Public transaksi_baru As Boolean


End Module
