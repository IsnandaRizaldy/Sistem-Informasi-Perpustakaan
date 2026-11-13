<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        lblJudul = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.Transparent
        lblJudul.Font = New Font("Bernard MT Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(308, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(580, 52)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Sistem Informasi Perpustakaan"
        lblJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(204, 182)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(106, 28)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        lblUsername.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(204, 227)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(101, 28)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        lblPassword.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.2F)
        txtUsername.Location = New Point(345, 180)
        txtUsername.Margin = New Padding(3, 3, 10, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(497, 30)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.2F)
        txtPassword.Location = New Point(345, 225)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(497, 30)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(550, 431)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(107, 54)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(201, -20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1067, 557)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblJudul)
        Controls.Add(PictureBox1)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Perpustakaan"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents flpInformasiLogin As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox

End Class
