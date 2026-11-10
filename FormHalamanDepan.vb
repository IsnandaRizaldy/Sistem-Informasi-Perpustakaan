Imports MySql.Data.MySqlClient

Public Class FormHalamanDepan

    Private Sub FormHalamanDepan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelNamaDanRole.Visible = False
        LabelTanggalDanWaktu.Visible = False
        PictureBoxRole.Visible = False
        LabelNamaLengkap.Visible = False

    End Sub



    'TextBox Nama Pengguna Kalau di Klik akan hilang isinya dan warnana berubah
    Private Sub txtNamaPengguna_Enter(sender As Object, e As EventArgs) Handles txtNamaPengguna.Enter

        If txtNamaPengguna.Text = "Nama Pengguna" Then

            txtNamaPengguna.Text = ""
            txtNamaPengguna.ForeColor = SystemColors.ControlText

        End If

    End Sub

    Private Sub txtNamaPengguna_Leave(sender As Object, e As EventArgs) Handles txtNamaPengguna.Leave

        If txtNamaPengguna.Text.Trim() = "" Then

            txtNamaPengguna.Text = "Nama Pengguna"
            txtNamaPengguna.ForeColor = SystemColors.ScrollBar

        End If

    End Sub

    'TextBox Kata Sandi Kalau di Klik akan hilang isinya dan warnana berubah
    Private Sub txtKataSandi_Enter(sender As Object, e As EventArgs) Handles txtKataSandi.Enter

        If txtKataSandi.Text = "Kata Sandi" Then

            txtKataSandi.UseSystemPasswordChar = True
            txtKataSandi.Text = ""
            txtKataSandi.ForeColor = SystemColors.ControlText

        End If



    End Sub

    Private Sub txtKataSandi_Leave(sender As Object, e As EventArgs) Handles txtKataSandi.Leave

        If txtKataSandi.Text.Trim() = "" Then

            txtKataSandi.Text = "Kata Sandi"
            txtKataSandi.ForeColor = SystemColors.ScrollBar
            txtKataSandi.UseSystemPasswordChar = False

        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' 1. Mengambil input dari pengguna
        Dim username As String = txtNamaPengguna.Text.Trim()
        Dim password As String = txtKataSandi.Text

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
                            txtNamaPengguna.Focus()
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
                            txtKataSandi.Clear()
                            txtKataSandi.Focus()
                            Return

                        End If

                        'ModulGlobal.userLogin = username

                        ' 7. Menentukan dashboard berdasarkan role
                        'Dim dashboard As Form = Nothing

                        'Tergantung Rolenya, akan berbeda beberapa tampilan di beranda
                        Select Case role.ToLower()

                            Case "admin"

                                LabelNamaDanRole.Visible = True
                                LabelNamaDanRole.Text = "Selamat Datang " & role.ToUpper() & " " & nama & "!"

                                'LabelTanggalDanWaktu.Text = DateAndTime

                                PictureBoxRole.Visible = True
                                PictureBoxRole.Image = My.Resources.Logo_Admin_Putih

                                LabelNamaLengkap.Visible = True
                                LabelNamaLengkap.Text = nama

                            Case "petugas"

                                LabelNamaDanRole.Visible = True
                                LabelNamaDanRole.Text = "Selamat Datang " & role.ToUpper() & " " & nama & "!"

                                PictureBoxRole.Visible = True
                                PictureBoxRole.Image = My.Resources.Logo_Petugas_Putih

                                LabelNamaLengkap.Visible = True
                                LabelNamaLengkap.Text = nama

                        End Select


                        'If role = "admin" Then
                        'dashboard = New FormAdmin()
                        'ElseIf role = "petugas" Then
                        'dashboard = New FormAdmin()
                        'Else
                        'MessageBox.Show("Role akun tidak dikenali!")
                        'Return
                        'End If

                        MessageBox.Show(
                        "Login Berhasil",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        )

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

End Class