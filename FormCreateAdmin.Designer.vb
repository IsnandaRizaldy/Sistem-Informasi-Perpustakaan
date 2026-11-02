<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateAdmin
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(27), CByte(73), CByte(101))
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 28)
        Label1.TabIndex = 0
        Label1.Text = "MANAJEMEN AKSES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(98), CByte(182), CByte(203))
        Label2.Location = New Point(12, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(364, 34)
        Label2.TabIndex = 1
        Label2.Text = "Buat Akun Admin / Petugas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(12, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(453, 20)
        Label3.TabIndex = 2
        Label3.Text = "Tambahkan pengguna yang dapat mengakses sistem perpustakaan."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 23)
        Label4.TabIndex = 3
        Label4.Text = "Nama Lengkap"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Schoolbook", 12F)
        Label5.Location = New Point(20, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 23)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Schoolbook", 12F)
        Label6.Location = New Point(20, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 23)
        Label6.TabIndex = 5
        Label6.Text = "Kata Sandi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Schoolbook", 12F)
        Label7.Location = New Point(244, 157)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 23)
        Label7.TabIndex = 6
        Label7.Text = "Username"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Schoolbook", 12F)
        Label8.Location = New Point(244, 237)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 23)
        Label8.TabIndex = 7
        Label8.Text = "Peran"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(20, 188)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(244, 188)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 27)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(20, 264)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 27)
        TextBox3.TabIndex = 10
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(244, 263)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(20, 334)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(445, 27)
        TextBox4.TabIndex = 12
        ' 
        ' FormCreateAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Perpustakaan_Pusat_Ilmu_Presentasi__2_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(929, 487)
        Controls.Add(TextBox4)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormCreateAdmin"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
End Class
