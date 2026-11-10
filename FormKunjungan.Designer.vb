<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKunjungan
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
        Panel1 = New Panel()
        Panel5 = New Panel()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Panel4 = New Panel()
        Label10 = New Label()
        Label8 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(5, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 32)
        Label1.TabIndex = 0
        Label1.Text = "Catat Kunjungan"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(5, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(477, 41)
        Label2.TabIndex = 1
        Label2.Text = "Isi saat pengunjung masuk. Anggota dicari lewat nomor atau nama, sedangkan pengunjung umum cukup diisi namanya."
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 149)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(513, 535)
        Panel1.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ScrollBar
        Panel5.Controls.Add(RadioButton2)
        Panel5.Controls.Add(RadioButton1)
        Panel5.Location = New Point(12, 100)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(294, 59)
        Panel5.TabIndex = 14
        ' 
        ' RadioButton2
        ' 
        RadioButton2.Appearance = Appearance.Button
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(155, 15)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(110, 30)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.Appearance = Appearance.Button
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(14, 15)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(110, 30)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(5, 301)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(354, 120)
        Panel4.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 67)
        Label10.Name = "Label10"
        Label10.Size = New Size(95, 20)
        Label10.TabIndex = 2
        Label10.Text = "Dicatat Oleh:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 20)
        Label8.TabIndex = 0
        Label8.Text = "Waktu Masuk:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(3, 87)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 20)
        Label11.TabIndex = 3
        Label11.Text = "Nama Petugas"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(3, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 20)
        Label9.TabIndex = 1
        Label9.Text = "Kamis, 5 November 2026"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(418, 428)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 20)
        Label7.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(2, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 19)
        Label6.TabIndex = 9
        Label6.Text = "Anggota Terpilih"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 241)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(453, 37)
        DataGridView1.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(2, 184)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(341, 27)
        TextBox1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(2, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(172, 19)
        Label5.TabIndex = 6
        Label5.Text = "Nama atau ID Anggota"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(5, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 19)
        Label4.TabIndex = 3
        Label4.Text = "Jenis Kunjungan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(5, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 32)
        Label3.TabIndex = 2
        Label3.Text = "Data Kunjungan"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(513, 94)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label12)
        Panel3.Location = New Point(599, 149)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(314, 396)
        Panel3.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(3, 11)
        Label12.Name = "Label12"
        Label12.Size = New Size(264, 32)
        Label12.TabIndex = 14
        Label12.Text = "Kunjungan Terakhir"
        ' 
        ' FormKunjungan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(960, 734)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormKunjungan"
        Text = "FormKunjungan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
