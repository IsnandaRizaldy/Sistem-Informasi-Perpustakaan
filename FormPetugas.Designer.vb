<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPetugas
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
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        TambahBukuToolStripMenuItem = New ToolStripMenuItem()
        lblUserLogin = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TransaksiToolStripMenuItem, TambahBukuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 31)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(97, 27)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' TambahBukuToolStripMenuItem
        ' 
        TambahBukuToolStripMenuItem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TambahBukuToolStripMenuItem.Name = "TambahBukuToolStripMenuItem"
        TambahBukuToolStripMenuItem.Size = New Size(134, 27)
        TambahBukuToolStripMenuItem.Text = "Tambah Buku"
        ' 
        ' lblUserLogin
        ' 
        lblUserLogin.AutoSize = True
        lblUserLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUserLogin.Location = New Point(556, 416)
        lblUserLogin.Margin = New Padding(3, 0, 150, 5)
        lblUserLogin.Name = "lblUserLogin"
        lblUserLogin.Size = New Size(85, 20)
        lblUserLogin.TabIndex = 2
        lblUserLogin.Text = "User Login"
        lblUserLogin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormPetugas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblUserLogin)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormPetugas"
        Text = "Form Petugas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUserLogin As Label
End Class
