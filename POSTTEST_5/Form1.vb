Imports MySqlConnector

Public Class Form1
    ' Prosedur pendukung untuk efisiensi kode
    Sub TampilData()
        dgvAlat.DataSource = GetAlatMusik()
    End Sub

    Sub KosongkanForm()
        txtIdAlat.Clear()
        txtNamaAlat.Clear()
        txtMerk.Clear()
        txtStok.Clear()
        txtIdAlat.Focus()
    End Sub

    ' Event saat form pertama kali terbuka
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    ' Fitur Simpan (Create)
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIdAlat.Text = "" Or txtNamaAlat.Text = "" Then
            MessageBox.Show("ID dan Nama Alat wajib diisi!", "Peringatan")
            Exit Sub
        End If

        Dim query As String = "INSERT INTO tb_alat_musik VALUES (@id, @nama, @merk, @stok)"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@id", txtIdAlat.Text),
            New MySqlParameter("@nama", txtNamaAlat.Text),
            New MySqlParameter("@merk", txtMerk.Text),
            New MySqlParameter("@stok", txtStok.Text)
        }

        If ExecuteQuery(query, params) > 0 Then
            MessageBox.Show("Data Berhasil Disimpan", "Informasi")
            TampilData()
            KosongkanForm()
        End If
    End Sub

    ' Fitur Ubah (Update)
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim query As String = "UPDATE tb_alat_musik SET nama_alat=@nama, merk=@merk, stok=@stok WHERE id_alat=@id"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@id", txtIdAlat.Text),
            New MySqlParameter("@nama", txtNamaAlat.Text),
            New MySqlParameter("@merk", txtMerk.Text),
            New MySqlParameter("@stok", txtStok.Text)
        }

        If ExecuteQuery(query, params) > 0 Then
            MessageBox.Show("Data Berhasil Diperbarui", "Informasi")
            TampilData()
            KosongkanForm()
        End If
    End Sub

    ' Fitur Hapus (Delete)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdAlat.Text <> "" Then
            Dim respon = MessageBox.Show("Hapus data " & txtNamaAlat.Text & "?", "Konfirmasi", MessageBoxButtons.YesNo)
            If respon = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tb_alat_musik WHERE id_alat=@id"
                Dim params As MySqlParameter() = {New MySqlParameter("@id", txtIdAlat.Text)}
                ExecuteQuery(query, params)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    ' Fitur Batal
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
    End Sub

    ' Fitur Cari (Search) - Sesuai syarat Posttest-5
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        dgvAlat.DataSource = GetAlatMusik(txtCari.Text)
    End Sub

    ' Event saat baris tabel diklik
    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvAlat.Rows(e.RowIndex)
                txtIdAlat.Text = row.Cells(0).Value.ToString()
                txtNamaAlat.Text = row.Cells(1).Value.ToString()
                txtMerk.Text = row.Cells(2).Value.ToString()
                txtStok.Text = row.Cells(3).Value.ToString()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' Validasi input stok (Hanya Angka)
    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class