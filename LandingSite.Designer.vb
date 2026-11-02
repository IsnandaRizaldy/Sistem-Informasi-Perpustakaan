<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingSite
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
        MenuStrip1 = New MenuStrip()
        StripMenuLogin = New ToolStripMenuItem()
        BukuToolStripMenuItem = New ToolStripMenuItem()
        LihatSemuaBukuToolStripMenuItem = New ToolStripMenuItem()
        LihatKategoriToolStripMenuItem = New ToolStripMenuItem()
        DaftarAnggotaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(27), CByte(73), CByte(101))
        MenuStrip1.Font = New Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {StripMenuLogin, BukuToolStripMenuItem, DaftarAnggotaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(530, 30, 0, 30)
        MenuStrip1.Size = New Size(1902, 103)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' StripMenuLogin
        ' 
        StripMenuLogin.BackColor = Color.FromArgb(CByte(27), CByte(73), CByte(101))
        StripMenuLogin.ForeColor = SystemColors.ControlLight
        StripMenuLogin.Margin = New Padding(50, 0, 50, 0)
        StripMenuLogin.Name = "StripMenuLogin"
        StripMenuLogin.Size = New Size(128, 43)
        StripMenuLogin.Text = "Login"
        ' 
        ' BukuToolStripMenuItem
        ' 
        BukuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LihatSemuaBukuToolStripMenuItem, LihatKategoriToolStripMenuItem})
        BukuToolStripMenuItem.ForeColor = SystemColors.ControlLight
        BukuToolStripMenuItem.Margin = New Padding(50, 0, 50, 0)
        BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        BukuToolStripMenuItem.Size = New Size(126, 43)
        BukuToolStripMenuItem.Text = "Buku"
        ' 
        ' LihatSemuaBukuToolStripMenuItem
        ' 
        LihatSemuaBukuToolStripMenuItem.Name = "LihatSemuaBukuToolStripMenuItem"
        LihatSemuaBukuToolStripMenuItem.Size = New Size(428, 44)
        LihatSemuaBukuToolStripMenuItem.Text = "Lihat Semua Buku"
        ' 
        ' LihatKategoriToolStripMenuItem
        ' 
        LihatKategoriToolStripMenuItem.Name = "LihatKategoriToolStripMenuItem"
        LihatKategoriToolStripMenuItem.Size = New Size(428, 44)
        LihatKategoriToolStripMenuItem.Text = "Lihat Kategori"
        ' 
        ' DaftarAnggotaToolStripMenuItem
        ' 
        DaftarAnggotaToolStripMenuItem.ForeColor = SystemColors.ControlLight
        DaftarAnggotaToolStripMenuItem.Margin = New Padding(50, 0, 50, 0)
        DaftarAnggotaToolStripMenuItem.Name = "DaftarAnggotaToolStripMenuItem"
        DaftarAnggotaToolStripMenuItem.Size = New Size(299, 43)
        DaftarAnggotaToolStripMenuItem.Text = "Daftar Anggota"
        ' 
        ' LandingSite
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(95), CByte(168), CByte(211))
        BackgroundImage = My.Resources.Resources.Warna_Warni_Ilustrasi_Ceria_Perpustakaan_Spanduk
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(800, 300)
        Name = "LandingSite"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Informasi Perpustakaan"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StripMenuLogin As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatSemuaBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarAnggotaToolStripMenuItem As ToolStripMenuItem
End Class
