Imports MySql.Data.MySqlClient
Imports Mysqlx.Data.MysqlCLient

Public Class FormLogin

    Private Sub btnTesKoneksi_Click(sender As Object, e As EventArgs)

        Try
            Using conn = GetConnection()

                conn.Open()

                MessageBox.Show(
                "Koneksi database berhasil!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            End Using

        Catch ex As Exception

            MessageBox.Show(
            "Koneksi database gagal." &
            Environment.NewLine &
            ex.Message,
            "Kesalahan",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' 1. Mengambil input dari pengguna
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' 2. Preventif kalau inputnya kosong
        If username = "" OrElse password = "" Then
            MessageBox.Show(
            "Username dan password tidak boleh kosong!",
            "Peringatan",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()

                conn.Open()

                ' 3. Mencari akun berdasarkan username
                Dim sql As String =
                "SELECT nama_lengkap, role, password_hash " &
                "FROM users " &
                "WHERE username = @username " &
                "AND status = 'aktif' LIMIT 1"

                Dim jumlahBuku As String =
                "SELECT COUNT(id_buku) FROM buku"

                Using cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.Add(
                    "@username", MySqlDbType.VarChar, 50
                ).Value = username

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        ' 4. Memeriksa apakah akun ditemukan
                        If Not reader.Read() Then
                            MessageBox.Show(
                            "Username tidak ditemukan atau akun tidak aktif!",
                            "Login Gagal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                            txtUsername.Focus()
                            Return

                        End If

                        ' 5. Mengambil data akun dari database
                        Dim nama As String = reader("nama_lengkap").ToString()
                        Dim role As String = reader("role").ToString()
                        Dim passwordDatabase As String =
                        reader("password_hash").ToString()

                        ' 6. Membandingkan password
                        If password <> passwordDatabase Then
                            MessageBox.Show(
                            "Password salah!",
                            "Login Gagal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                            txtPassword.Clear()
                            txtPassword.Focus()
                            Return
                        End If

                        ModulGlobal.userLogin = username

                        ' 7. Menentukan dashboard berdasarkan role
                        Dim dashboard As Form = Nothing

                        If role = "admin" Then
                            dashboard = New FormAdmin()
                        ElseIf role = "petugas" Then
                            dashboard = New FormPetugas()
                        Else
                            MessageBox.Show("Role akun tidak dikenali!")
                            Return
                        End If

                        MessageBox.Show(
                        "Login berhasil. Selamat datang, " & nama & "!",
                        "Login Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                        AddHandler dashboard.FormClosed,
                        Sub(sender2, e2)
                            Me.Close()
                        End Sub

                        dashboard.Show()
                        Me.Hide()

                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show(
            "Gagal mengakses database: " & ex.Message,
            "Kesalahan Database",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
