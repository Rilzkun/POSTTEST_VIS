Imports MySqlConnector

Module DataModule
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user=root;password=;database=db_inventaris")
    End Function

    Public Function GetAlatMusik(Optional keyword As String = "") As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT a.id_alat AS 'ID', a.nama_alat AS 'Nama Alat', a.merk AS 'Merk', " &
                                 "k.nama_kategori AS 'Kategori', a.stok AS 'Stok', a.harga AS 'Harga' " &
                                 "FROM tb_alat_musik a INNER JOIN tb_kategori k ON a.id_kategori = k.id_kategori"
            If keyword <> "" Then
                query &= " WHERE a.nama_alat LIKE @key OR a.merk LIKE @key OR k.nama_kategori LIKE @key"
            End If
            Dim cmd As New MySqlCommand(query, conn)
            If keyword <> "" Then cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetKategori() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT id_kategori, nama_kategori FROM tb_kategori"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function ExecuteQuery(query As String, params As MySqlParameter()) As Integer
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            If params IsNot Nothing Then cmd.Parameters.AddRange(params)
            Return cmd.ExecuteNonQuery()
        End Using
    End Function
End Module