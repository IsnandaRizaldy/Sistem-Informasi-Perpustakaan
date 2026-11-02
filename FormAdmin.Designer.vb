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
        MenuStrip1 = New MenuStrip()
        TambahUserToolStripMenuItem = New ToolStripMenuItem()
        IadjaiToolStripMenuItem = New ToolStripMenuItem()
        PetugasToolStripMenuItem = New ToolStripMenuItem()
        TambahToolStripMenuItem = New ToolStripMenuItem()
        SemuaBukuToolStripMenuItem = New ToolStripMenuItem()
        BukuDipinjamToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        LihatTransaksiToolStripMenuItem = New ToolStripMenuItem()
        lblUserLogin = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TambahUserToolStripMenuItem, TambahToolStripMenuItem, TransaksiToolStripMenuItem, LihatTransaksiToolStripMenuItem})
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.Name = "MenuStrip1"
        ' 
        ' TambahUserToolStripMenuItem
        ' 
        TambahUserToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IadjaiToolStripMenuItem, PetugasToolStripMenuItem})
        resources.ApplyResources(TambahUserToolStripMenuItem, "TambahUserToolStripMenuItem")
        TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        ' 
        ' IadjaiToolStripMenuItem
        ' 
        IadjaiToolStripMenuItem.Name = "IadjaiToolStripMenuItem"
        resources.ApplyResources(IadjaiToolStripMenuItem, "IadjaiToolStripMenuItem")
        ' 
        ' PetugasToolStripMenuItem
        ' 
        PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        resources.ApplyResources(PetugasToolStripMenuItem, "PetugasToolStripMenuItem")
        ' 
        ' TambahToolStripMenuItem
        ' 
        TambahToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SemuaBukuToolStripMenuItem, BukuDipinjamToolStripMenuItem})
        resources.ApplyResources(TambahToolStripMenuItem, "TambahToolStripMenuItem")
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
        ' TransaksiToolStripMenuItem
        ' 
        resources.ApplyResources(TransaksiToolStripMenuItem, "TransaksiToolStripMenuItem")
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        ' 
        ' LihatTransaksiToolStripMenuItem
        ' 
        resources.ApplyResources(LihatTransaksiToolStripMenuItem, "LihatTransaksiToolStripMenuItem")
        LihatTransaksiToolStripMenuItem.Name = "LihatTransaksiToolStripMenuItem"
        ' 
        ' lblUserLogin
        ' 
        resources.ApplyResources(lblUserLogin, "lblUserLogin")
        lblUserLogin.Name = "lblUserLogin"
        ' 
        ' FormAdmin
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblUserLogin)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormAdmin"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TambahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IadjaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemuaBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuDipinjamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUserLogin As Label
End Class
