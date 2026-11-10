Public Class KunjunganItem
    Private Sub KunjunganItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Isi(nama As String, meta As String, tanggal As String)
        lblNama.Text = nama
        lblMeta.Text = meta
        lblTanggal.Text = tanggal
    End Sub
End Class
