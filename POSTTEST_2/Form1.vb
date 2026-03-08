Public Class Form1
    ' Procedure dengan argumen ByVal
    Sub Tampil(ByVal m As String)
        ListBox1.Items.Clear()
        For i = 0 To n - 1
            ListBox1.Items.Add(buku(i) & " [" & genre(i) & "]") ' Gabung judul & genre
        Next
        If m <> "" Then MsgBox(m)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtTambah.Text = "" Or txtGenre.Text = "" Then Exit Sub
        buku(n) = txtTambah.Text : genre(n) = txtGenre.Text : n += 1 ' Simpan ke kedua array
        Tampil("Tambah Berhasil") : txtTambah.Clear() : txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim p = Cari(txtHapus.Text) ' Cari berdasarkan judul
        If p <> -1 Then
            ' Geser kedua array agar data tetap sinkron
            For i = p To n - 2
                buku(i) = buku(i + 1) : genre(i) = genre(i + 1)
            Next
            n -= 1 : Tampil("Hapus Berhasil") : txtHapus.Clear()
        Else : MsgBox("Tidak ada") : End If
    End Sub


End Class