Imports MySqlConnector

Public Class Form1
    Dim idKatTerpilih As String = ""

    Sub TampilData()
        dgvAlat.DataSource = GetAlatMusik()
        dgvKategori.DataSource = GetKategori()
    End Sub

    Sub LoadComboBox()
        cmbKategori.DataSource = GetKategori()
        cmbKategori.DisplayMember = "nama_kategori"
        cmbKategori.ValueMember = "id_kategori"
    End Sub

    Sub KosongkanForm()
        txtIdAlat.Clear()
        txtNamaAlat.Clear()
        txtMerk.Clear()
        txtStok.Clear()
        txtNamaKategori.Clear()
        idKatTerpilih = ""
        txtIdAlat.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        LoadComboBox()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIdAlat.Text = "" Or txtNamaAlat.Text = "" Then
            MessageBox.Show("ID dan Nama Alat wajib diisi!", "Peringatan")
            Exit Sub
        End If

        Dim query As String = "INSERT INTO tb_alat_musik (id_alat, nama_alat, merk, id_kategori, stok) VALUES (@id, @nama, @merk, @idkat, @stok)"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@id", txtIdAlat.Text),
            New MySqlParameter("@nama", txtNamaAlat.Text),
            New MySqlParameter("@merk", txtMerk.Text),
            New MySqlParameter("@idkat", cmbKategori.SelectedValue),
            New MySqlParameter("@stok", txtStok.Text)
        }

        If ExecuteQuery(query, params) > 0 Then
            MessageBox.Show("Data Berhasil Disimpan", "Informasi")
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim query As String = "UPDATE tb_alat_musik SET nama_alat=@nama, merk=@merk, id_kategori=@idkat, stok=@stok WHERE id_alat=@id"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@id", txtIdAlat.Text),
            New MySqlParameter("@nama", txtNamaAlat.Text),
            New MySqlParameter("@merk", txtMerk.Text),
            New MySqlParameter("@idkat", cmbKategori.SelectedValue),
            New MySqlParameter("@stok", txtStok.Text)
        }

        If ExecuteQuery(query, params) > 0 Then
            MessageBox.Show("Data Berhasil Diperbarui", "Informasi")
            TampilData()
            KosongkanForm()
        End If
    End Sub

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

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        dgvAlat.DataSource = GetAlatMusik(txtCari.Text)
    End Sub

    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvAlat.Rows(e.RowIndex)
                txtIdAlat.Text = row.Cells(0).Value.ToString()
                txtNamaAlat.Text = row.Cells(1).Value.ToString()
                txtMerk.Text = row.Cells(2).Value.ToString()
                cmbKategori.Text = row.Cells(3).Value.ToString()
                txtStok.Text = row.Cells(4).Value.ToString()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnTambahKategori_Click(sender As Object, e As EventArgs) Handles btnTambahKategori.Click
        If txtNamaKategori.Text = "" Then
            MessageBox.Show("Nama Kategori tidak boleh kosong!")
            Return
        End If

        Dim query As String = "INSERT INTO tb_kategori (nama_kategori) VALUES (@nama)"
        Dim params As MySqlParameter() = {
        New MySqlParameter("@nama", txtNamaKategori.Text)
    }

        If ExecuteQuery(query, params) > 0 Then
            MessageBox.Show("Kategori Baru Berhasil Ditambahkan!")
            TampilData()
            LoadComboBox()
            txtNamaKategori.Clear()
        End If
    End Sub

    Private Sub btnUbahKategori_Click(sender As Object, e As EventArgs) Handles btnUbahKategori.Click
        If idKatTerpilih = "" Then Return
        Dim query As String = "UPDATE tb_kategori SET nama_kategori=@nama WHERE id_kategori=@id"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@nama", txtNamaKategori.Text),
            New MySqlParameter("@id", idKatTerpilih)
        }
        If ExecuteQuery(query, params) > 0 Then
            MessageBox.Show("Kategori Berhasil Diubah")
            TampilData()
            LoadComboBox()
        End If
    End Sub

    Private Sub btnHapusKategori_Click(sender As Object, e As EventArgs) Handles btnHapusKategori.Click
        If idKatTerpilih = "" Then Return
        Dim res = MessageBox.Show("Hapus kategori ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If res = DialogResult.Yes Then
            Dim query As String = "DELETE FROM tb_kategori WHERE id_kategori=@id"
            Dim params As MySqlParameter() = {New MySqlParameter("@id", idKatTerpilih)}
            ExecuteQuery(query, params)
            TampilData()
            LoadComboBox()
            txtNamaKategori.Clear()
        End If
    End Sub

    Private Sub dgvKategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKategori.CellClick
        If e.RowIndex >= 0 Then
            idKatTerpilih = dgvKategori.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamaKategori.Text = dgvKategori.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub

    Private Sub txtNamaKategori_TextChanged(sender As Object, e As EventArgs) Handles txtNamaKategori.TextChanged

    End Sub
End Class
