Imports MySql.Data.MySqlClient

Module koneksi

    Public Function GetConnection() As MySqlConnection

        Dim connectionString As String =
           "Server=localhost;" &
           "Port=3306;" &
           "Database=perpustakaan_kampus;" &
           "Uid=root;" &
           "Pwd=;"

        Return New MySqlConnection(connectionString)

    End Function

End Module
