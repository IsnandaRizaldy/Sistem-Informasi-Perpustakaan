<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Navbar = New MenuStrip()
        LogoPerpustakaanToolStripMenuItem = New ToolStripMenuItem()
        TambahUserToolStripMenuItem = New ToolStripMenuItem()
        TambahToolStripMenuItem = New ToolStripMenuItem()
        SemuaBukuToolStripMenuItem = New ToolStripMenuItem()
        BukuDipinjamToolStripMenuItem = New ToolStripMenuItem()
        LihatKatalogToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        PeminjamanToolStripMenuItem = New ToolStripMenuItem()
        HistoriPeminjamanToolStripMenuItem = New ToolStripMenuItem()
        BukuTamuToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        lblUserLogin = New Label()
        pnlNavbar = New Panel()
        pnlScroll = New Panel()
        pnlKonten = New Panel()
        pnlHero = New Panel()
        Button1 = New Button()
        lblHero3 = New Label()
        lblHero2 = New Label()
        lblHero1 = New Label()
        Panel1 = New Panel()
        pnlKoleksi = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Navbar.SuspendLayout()
        pnlNavbar.SuspendLayout()
        pnlScroll.SuspendLayout()
        pnlKonten.SuspendLayout()
        pnlHero.SuspendLayout()
        SuspendLayout()
        ' 
        ' Navbar
        ' 
        resources.ApplyResources(Navbar, "Navbar")
        Navbar.BackColor = Color.FromArgb(CByte(27), CByte(73), CByte(101))
        Navbar.ImageScalingSize = New Size(150, 150)
        Navbar.Items.AddRange(New ToolStripItem() {LogoPerpustakaanToolStripMenuItem, TambahUserToolStripMenuItem, TambahToolStripMenuItem, TransaksiToolStripMenuItem, AdminToolStripMenuItem})
        Navbar.Name = "Navbar"
        ' 
        ' LogoPerpustakaanToolStripMenuItem
        ' 
        resources.ApplyResources(LogoPerpustakaanToolStripMenuItem, "LogoPerpustakaanToolStripMenuItem")
        LogoPerpustakaanToolStripMenuItem.ForeColor = SystemColors.ControlLight
        LogoPerpustakaanToolStripMenuItem.Image = My.Resources.Resources.Logo_Perpus_Minimalis___Putih
        LogoPerpustakaanToolStripMenuItem.Name = "LogoPerpustakaanToolStripMenuItem"
        LogoPerpustakaanToolStripMenuItem.Padding = New Padding(5, 0, 5, 30)
        ' 
        ' TambahUserToolStripMenuItem
        ' 
        resources.ApplyResources(TambahUserToolStripMenuItem, "TambahUserToolStripMenuItem")
        TambahUserToolStripMenuItem.ForeColor = SystemColors.ControlLight
        TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        ' 
        ' TambahToolStripMenuItem
        ' 
        TambahToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SemuaBukuToolStripMenuItem, BukuDipinjamToolStripMenuItem, LihatKatalogToolStripMenuItem})
        resources.ApplyResources(TambahToolStripMenuItem, "TambahToolStripMenuItem")
        TambahToolStripMenuItem.ForeColor = SystemColors.ControlLight
        TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        ' 
        ' SemuaBukuToolStripMenuItem
        ' 
        SemuaBukuToolStripMenuItem.Name = "SemuaBukuToolStripMenuItem"
        resources.ApplyResources(SemuaBukuToolStripMenuItem, "SemuaBukuToolStripMenuItem")
        ' 
        ' BukuDipinjamToolStripMenuItem
        ' 
        BukuDipinjamToolStripMenuItem.Name = "BukuDipinjamToolStripMenuItem"
        resources.ApplyResources(BukuDipinjamToolStripMenuItem, "BukuDipinjamToolStripMenuItem")
        ' 
        ' LihatKatalogToolStripMenuItem
        ' 
        LihatKatalogToolStripMenuItem.Name = "LihatKatalogToolStripMenuItem"
        resources.ApplyResources(LihatKatalogToolStripMenuItem, "LihatKatalogToolStripMenuItem")
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PeminjamanToolStripMenuItem, HistoriPeminjamanToolStripMenuItem, BukuTamuToolStripMenuItem})
        resources.ApplyResources(TransaksiToolStripMenuItem, "TransaksiToolStripMenuItem")
        TransaksiToolStripMenuItem.ForeColor = SystemColors.ControlLight
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        ' 
        ' PeminjamanToolStripMenuItem
        ' 
        PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        resources.ApplyResources(PeminjamanToolStripMenuItem, "PeminjamanToolStripMenuItem")
        ' 
        ' HistoriPeminjamanToolStripMenuItem
        ' 
        HistoriPeminjamanToolStripMenuItem.Name = "HistoriPeminjamanToolStripMenuItem"
        resources.ApplyResources(HistoriPeminjamanToolStripMenuItem, "HistoriPeminjamanToolStripMenuItem")
        ' 
        ' BukuTamuToolStripMenuItem
        ' 
        BukuTamuToolStripMenuItem.Name = "BukuTamuToolStripMenuItem"
        resources.ApplyResources(BukuTamuToolStripMenuItem, "BukuTamuToolStripMenuItem")
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        resources.ApplyResources(AdminToolStripMenuItem, "AdminToolStripMenuItem")
        AdminToolStripMenuItem.ForeColor = SystemColors.ControlLight
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        ' 
        ' lblUserLogin
        ' 
        resources.ApplyResources(lblUserLogin, "lblUserLogin")
        lblUserLogin.Name = "lblUserLogin"
        ' 
        ' pnlNavbar
        ' 
        pnlNavbar.BackColor = Color.FromArgb(CByte(27), CByte(73), CByte(101))
        pnlNavbar.Controls.Add(Navbar)
        resources.ApplyResources(pnlNavbar, "pnlNavbar")
        pnlNavbar.Name = "pnlNavbar"
        ' 
        ' pnlScroll
        ' 
        resources.ApplyResources(pnlScroll, "pnlScroll")
        pnlScroll.Controls.Add(pnlKonten)
        pnlScroll.Name = "pnlScroll"
        ' 
        ' pnlKonten
        ' 
        pnlKonten.Controls.Add(pnlHero)
        resources.ApplyResources(pnlKonten, "pnlKonten")
        pnlKonten.Name = "pnlKonten"
        ' 
        ' pnlHero
        ' 
        pnlHero.BackColor = Color.FromArgb(CByte(202), CByte(233), CByte(255))
        pnlHero.Controls.Add(Button1)
        pnlHero.Controls.Add(lblHero3)
        pnlHero.Controls.Add(lblHero2)
        pnlHero.Controls.Add(lblHero1)
        pnlHero.Controls.Add(Panel1)
        pnlHero.Controls.Add(pnlKoleksi)
        resources.ApplyResources(pnlHero, "pnlHero")
        pnlHero.Name = "pnlHero"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        resources.ApplyResources(Button1, "Button1")
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblHero3
        ' 
        resources.ApplyResources(lblHero3, "lblHero3")
        lblHero3.ForeColor = SystemColors.ControlLightLight
        lblHero3.Name = "lblHero3"
        ' 
        ' lblHero2
        ' 
        resources.ApplyResources(lblHero2, "lblHero2")
        lblHero2.ForeColor = SystemColors.ControlLightLight
        lblHero2.Name = "lblHero2"
        ' 
        ' lblHero1
        ' 
        resources.ApplyResources(lblHero1, "lblHero1")
        lblHero1.ForeColor = Color.DarkOrange
        lblHero1.Name = "lblHero1"
        ' 
        ' Panel1
        ' 
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' pnlKoleksi
        ' 
        pnlKoleksi.BackColor = Color.Gray
        resources.ApplyResources(pnlKoleksi, "pnlKoleksi")
        pnlKoleksi.Name = "pnlKoleksi"
        ' 
        ' FormAdmin
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlScroll)
        Controls.Add(pnlNavbar)
        Controls.Add(lblUserLogin)
        MainMenuStrip = Navbar
        Name = "FormAdmin"
        WindowState = FormWindowState.Maximized
        Navbar.ResumeLayout(False)
        Navbar.PerformLayout()
        pnlNavbar.ResumeLayout(False)
        pnlScroll.ResumeLayout(False)
        pnlKonten.ResumeLayout(False)
        pnlHero.ResumeLayout(False)
        pnlHero.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Navbar As MenuStrip
    Friend WithEvents TambahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents pnlNavbar As Panel
    Friend WithEvents pnlScroll As Panel
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriPeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuTamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoPerpustakaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemuaBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuDipinjamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents pnlHero As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlKoleksi As Panel
    Friend WithEvents lblHero2 As Label
    Friend WithEvents lblHero1 As Label
    Friend WithEvents lblHero3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LihatKatalogToolStripMenuItem As ToolStripMenuItem
End Class
