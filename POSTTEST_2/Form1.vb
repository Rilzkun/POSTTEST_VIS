Public Class Form1
    Sub SinkronkanTampilan(ByVal pesanInfo As String)
        ListBox1.Items.Clear()
        For i As Integer = 0 To totalBuku - 1
            ListBox1.Items.Add(daftarJudul(i) & " - (" & daftarGenre(i) & ")")
        Next
        If pesanInfo <> "" Then MsgBox(pesanInfo)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtTambah.Text = "" Or txtGenre.Text = "" Then
            MsgBox("Judul dan Genre harus diisi!")
            Exit Sub
        End If

        daftarJudul(totalBuku) = txtTambah.Text
        daftarGenre(totalBuku) = txtGenre.Text
        totalBuku += 1

        SinkronkanTampilan("Buku Berhasil Ditambahkan!")
        txtTambah.Clear() : txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim indexKetemu As Integer = CariUrutanBuku(txtHapus.Text)

        If indexKetemu <> -1 Then
            For i As Integer = indexKetemu To totalBuku - 2
                daftarJudul(i) = daftarJudul(i + 1)
                daftarGenre(i) = daftarGenre(i + 1)
            Next
            totalBuku -= 1
            SinkronkanTampilan("Buku Berhasil Dihapus!")
            txtHapus.Clear()
        Else
            MsgBox("Maaf, judul buku tidak ditemukan.")
        End If
    End Sub
End Class