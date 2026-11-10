<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KunjunganItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        lblNama = New Label()
        lblMeta = New Label()
        lblTanggal = New Label()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(0, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' lblMeta
        ' 
        lblMeta.AutoSize = True
        lblMeta.Location = New Point(0, 20)
        lblMeta.Name = "lblMeta"
        lblMeta.Size = New Size(43, 20)
        lblMeta.TabIndex = 1
        lblMeta.Text = "meta"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(108, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(60, 20)
        lblTanggal.TabIndex = 2
        lblTanggal.Text = "tanggal"
        ' 
        ' KunjunganItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblTanggal)
        Controls.Add(lblMeta)
        Controls.Add(lblNama)
        Name = "KunjunganItem"
        Size = New Size(232, 83)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblMeta As Label
    Friend WithEvents lblTanggal As Label

End Class
