Module DataBuku
    Public daftarJudul(99) As String
    Public daftarGenre(99) As String
    Public totalBuku As Integer = 0

    Function CariUrutanBuku(ByVal judulYangDicari As String) As Integer
        For i As Integer = 0 To totalBuku - 1
            If daftarJudul(i).ToLower() = judulYangDicari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module