<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHalamanDepan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelHeader = New Panel()
        txtKataSandi = New TextBox()
        txtNamaPengguna = New TextBox()
        LabelNamaLengkap = New Label()
        PictureBoxRole = New PictureBox()
        btnLogin = New Button()
        LabelTanggalDanWaktu = New Label()
        LabelNamaDanRole = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PanelSidebar = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        PanelKonten = New Panel()
        DataGridView1 = New DataGridView()
        PanelPintasanGridView = New Panel()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label12 = New Label()
        Label7 = New Label()
        PanelInformasiAnggota = New Panel()
        Label5 = New Label()
        PanelInformasiBukuDipinjam = New Panel()
        Label4 = New Label()
        PanelInformasiTotalBuku = New Panel()
        Label3 = New Label()
        PanelHeader.SuspendLayout()
        CType(PictureBoxRole, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelSidebar.SuspendLayout()
        PanelKonten.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelPintasanGridView.SuspendLayout()
        PanelInformasiAnggota.SuspendLayout()
        PanelInformasiBukuDipinjam.SuspendLayout()
        PanelInformasiTotalBuku.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(13), CByte(49), CByte(95))
        PanelHeader.Controls.Add(txtKataSandi)
        PanelHeader.Controls.Add(txtNamaPengguna)
        PanelHeader.Controls.Add(LabelNamaLengkap)
        PanelHeader.Controls.Add(PictureBoxRole)
        PanelHeader.Controls.Add(btnLogin)
        PanelHeader.Controls.Add(LabelTanggalDanWaktu)
        PanelHeader.Controls.Add(LabelNamaDanRole)
        PanelHeader.Controls.Add(Label1)
        PanelHeader.Controls.Add(PictureBox2)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1902, 125)
        PanelHeader.TabIndex = 0
        ' 
        ' txtKataSandi
        ' 
        txtKataSandi.ForeColor = SystemColors.ScrollBar
        txtKataSandi.Location = New Point(958, 47)
        txtKataSandi.Name = "txtKataSandi"
        txtKataSandi.Size = New Size(207, 27)
        txtKataSandi.TabIndex = 8
        txtKataSandi.Text = "Kata Sandi"
        ' 
        ' txtNamaPengguna
        ' 
        txtNamaPengguna.ForeColor = SystemColors.ScrollBar
        txtNamaPengguna.Location = New Point(731, 47)
        txtNamaPengguna.Name = "txtNamaPengguna"
        txtNamaPengguna.Size = New Size(207, 27)
        txtNamaPengguna.TabIndex = 8
        txtNamaPengguna.Text = "Nama Pengguna"
        ' 
        ' LabelNamaLengkap
        ' 
        LabelNamaLengkap.AutoSize = True
        LabelNamaLengkap.Location = New Point(1641, 50)
        LabelNamaLengkap.Name = "LabelNamaLengkap"
        LabelNamaLengkap.Size = New Size(82, 20)
        LabelNamaLengkap.TabIndex = 7
        LabelNamaLengkap.Text = "Nama User"
        ' 
        ' PictureBoxRole
        ' 
        PictureBoxRole.Location = New Point(1490, 31)
        PictureBoxRole.Name = "PictureBoxRole"
        PictureBoxRole.Size = New Size(125, 62)
        PictureBoxRole.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxRole.TabIndex = 6
        PictureBoxRole.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(1185, 46)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' LabelTanggalDanWaktu
        ' 
        LabelTanggalDanWaktu.AutoSize = True
        LabelTanggalDanWaktu.Location = New Point(272, 82)
        LabelTanggalDanWaktu.Name = "LabelTanggalDanWaktu"
        LabelTanggalDanWaktu.Size = New Size(135, 20)
        LabelTanggalDanWaktu.TabIndex = 4
        LabelTanggalDanWaktu.Text = "Tanggal dan Waktu"
        ' 
        ' LabelNamaDanRole
        ' 
        LabelNamaDanRole.AutoSize = True
        LabelNamaDanRole.Location = New Point(272, 46)
        LabelNamaDanRole.Name = "LabelNamaDanRole"
        LabelNamaDanRole.Size = New Size(172, 20)
        LabelNamaDanRole.TabIndex = 3
        LabelNamaDanRole.Text = "Selamat Datang, (ROLE)!"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HighlightText
        Label1.Location = New Point(21, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 25)
        Label1.TabIndex = 2
        Label1.Text = "Perpustakaan Kita"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Logo_Perpus_Minimalis___Putih
        PictureBox2.Location = New Point(57, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 125)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.AutoScroll = True
        PanelSidebar.BackColor = Color.FromArgb(CByte(13), CByte(49), CByte(95))
        PanelSidebar.Controls.Add(Label11)
        PanelSidebar.Controls.Add(Label10)
        PanelSidebar.Controls.Add(Label9)
        PanelSidebar.Controls.Add(Label8)
        PanelSidebar.Controls.Add(Label6)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(247, 908)
        PanelSidebar.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.HighlightText
        Label11.Location = New Point(59, 435)
        Label11.Name = "Label11"
        Label11.Size = New Size(125, 23)
        Label11.TabIndex = 2
        Label11.Text = "Katalog Buku"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.HighlightText
        Label10.Location = New Point(43, 341)
        Label10.Name = "Label10"
        Label10.Size = New Size(162, 23)
        Label10.TabIndex = 2
        Label10.Text = "Daftar Kunjungan"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.HighlightText
        Label9.Location = New Point(66, 246)
        Label9.Name = "Label9"
        Label9.Size = New Size(109, 23)
        Label9.TabIndex = 2
        Label9.Text = "Siklus Buku"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.HighlightText
        Label8.Location = New Point(57, 141)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 23)
        Label8.TabIndex = 2
        Label8.Text = "Keanggotaan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.HighlightText
        Label6.Location = New Point(78, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 23)
        Label6.TabIndex = 2
        Label6.Text = "Beranda"
        ' 
        ' PanelKonten
        ' 
        PanelKonten.BackColor = SystemColors.GradientActiveCaption
        PanelKonten.Controls.Add(DataGridView1)
        PanelKonten.Controls.Add(PanelPintasanGridView)
        PanelKonten.Controls.Add(PanelInformasiAnggota)
        PanelKonten.Controls.Add(PanelInformasiBukuDipinjam)
        PanelKonten.Controls.Add(PanelInformasiTotalBuku)
        PanelKonten.Controls.Add(PanelSidebar)
        PanelKonten.Dock = DockStyle.Fill
        PanelKonten.Location = New Point(0, 125)
        PanelKonten.Name = "PanelKonten"
        PanelKonten.Size = New Size(1902, 908)
        PanelKonten.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(469, 328)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1080, 549)
        DataGridView1.TabIndex = 7
        ' 
        ' PanelPintasanGridView
        ' 
        PanelPintasanGridView.Controls.Add(Button2)
        PanelPintasanGridView.Controls.Add(TextBox1)
        PanelPintasanGridView.Controls.Add(Label12)
        PanelPintasanGridView.Controls.Add(Label7)
        PanelPintasanGridView.Location = New Point(619, 196)
        PanelPintasanGridView.Name = "PanelPintasanGridView"
        PanelPintasanGridView.Size = New Size(753, 59)
        PanelPintasanGridView.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(694, 16)
        Button2.Name = "Button2"
        Button2.Size = New Size(52, 29)
        Button2.TabIndex = 7
        Button2.Text = "Cari"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.ForeColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(303, 17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(385, 27)
        TextBox1.TabIndex = 6
        TextBox1.Text = "Cari"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(168, 20)
        Label12.Name = "Label12"
        Label12.Size = New Size(118, 20)
        Label12.TabIndex = 5
        Label12.Text = "Histori Pinjaman"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 20)
        Label7.TabIndex = 5
        Label7.Text = "Kunjungan Terakhir"
        ' 
        ' PanelInformasiAnggota
        ' 
        PanelInformasiAnggota.Controls.Add(Label5)
        PanelInformasiAnggota.Location = New Point(536, 39)
        PanelInformasiAnggota.Name = "PanelInformasiAnggota"
        PanelInformasiAnggota.Size = New Size(250, 125)
        PanelInformasiAnggota.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(71, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 20)
        Label5.TabIndex = 0
        Label5.Text = "Total Anggota"
        ' 
        ' PanelInformasiBukuDipinjam
        ' 
        PanelInformasiBukuDipinjam.Controls.Add(Label4)
        PanelInformasiBukuDipinjam.Location = New Point(1252, 38)
        PanelInformasiBukuDipinjam.Name = "PanelInformasiBukuDipinjam"
        PanelInformasiBukuDipinjam.Size = New Size(250, 125)
        PanelInformasiBukuDipinjam.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(71, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 20)
        Label4.TabIndex = 0
        Label4.Text = "Buku Dipinjam"
        ' 
        ' PanelInformasiTotalBuku
        ' 
        PanelInformasiTotalBuku.Controls.Add(Label3)
        PanelInformasiTotalBuku.Location = New Point(894, 39)
        PanelInformasiTotalBuku.Name = "PanelInformasiTotalBuku"
        PanelInformasiTotalBuku.Size = New Size(250, 125)
        PanelInformasiTotalBuku.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(89, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 0
        Label3.Text = "Total Buku"
        ' 
        ' FormHalamanDepan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(PanelKonten)
        Controls.Add(PanelHeader)
        Name = "FormHalamanDepan"
        Text = "Halaman Depan"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        CType(PictureBoxRole, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelSidebar.ResumeLayout(False)
        PanelSidebar.PerformLayout()
        PanelKonten.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelPintasanGridView.ResumeLayout(False)
        PanelPintasanGridView.PerformLayout()
        PanelInformasiAnggota.ResumeLayout(False)
        PanelInformasiAnggota.PerformLayout()
        PanelInformasiBukuDipinjam.ResumeLayout(False)
        PanelInformasiBukuDipinjam.PerformLayout()
        PanelInformasiTotalBuku.ResumeLayout(False)
        PanelInformasiTotalBuku.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents LabelNamaDanRole As Label
    Friend WithEvents PanelInformasiTotalBuku As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelInformasiAnggota As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelInformasiBukuDipinjam As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelPintasanGridView As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelNamaLengkap As Label
    Friend WithEvents PictureBoxRole As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents LabelTanggalDanWaktu As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtNamaPengguna As TextBox
    Friend WithEvents txtKataSandi As TextBox
End Class
