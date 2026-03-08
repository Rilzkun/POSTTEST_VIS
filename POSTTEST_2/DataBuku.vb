Module DataBuku
    Public buku(99) As String, genre(99) As String, n As Integer = 0 ' Tambah array genre

    Function Cari(ByVal j As String) As Integer ' Minimal 1 Function
        For i = 0 To n - 1
            If buku(i).ToLower() = j.ToLower() Then Return i
        Next
        Return -1
    End Function
End Module