Module ValidationModule
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        ' Jika karakter yang ditekan adalah angka atau tombol kontrol (seperti Backspace)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False ' Biarkan karakter diproses
        Else
            e.Handled = True ' Tolak karakter (tidak akan muncul di TextBox)
        End If
    End Sub ' Pastikan ada spasi antara End dan Sub
End Module