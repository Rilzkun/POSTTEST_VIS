Imports MySqlConnector 'Atau Imports MySql.Data.MySqlClient tergantung library yang kamu pakai

Module DataModule
    ' Fungsi untuk mengambil semua data atau mencari data berdasarkan keyword
    Public Function GetAlatMusik(Optional keyword As String = "") As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim query As String
            If keyword = "" Then
                query = "SELECT id_alat AS 'ID', nama_alat AS 'Nama Alat', merk AS 'Merk', stok AS 'Stok' FROM tb_alat_musik"
            Else
                ' Fitur Search sesuai instruksi Posttest-5
                query = "SELECT id_alat AS 'ID', nama_alat AS 'Nama Alat', merk AS 'Merk', stok AS 'Stok' " &
                        "FROM tb_alat_musik WHERE nama_alat LIKE @key OR merk LIKE @key"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            If keyword <> "" Then
                cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    ' Fungsi untuk eksekusi query (Simpan, Ubah, Hapus) agar kode di Form lebih pendek
    Public Function ExecuteQuery(query As String, params As MySqlParameter()) As Integer
        Dim rowsAffected As Integer = 0
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            If params IsNot Nothing Then
                cmd.Parameters.AddRange(params)
            End If
            rowsAffected = cmd.ExecuteNonQuery()
        End Using
        Return rowsAffected
    End Function
End Module