Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim buka As New OpenFileDialog
        buka.Filter = "File Gambar|*.jpg;*.png;*.jpeg"

        If buka.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(buka.FileName)
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        'VALIDASI TEXTBOX
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then
            MsgBox("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'VALIDASI FOTO
        If picFoto.Image Is Nothing Then
            MsgBox("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'VALIDASI RADIO BUTTON
        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MsgBox("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'VALIDASI CHECKBOX
        If Not (cbMusik.Checked Or cbGame.Checked Or cbMembaca.Checked Or cbOlahraga.Checked _
        Or cbTravel.Checked Or cbFotografi.Checked Or cbMemasak.Checked Or cbMenulis.Checked _
        Or cbFilm.Checked Or cbNgoding.Checked) Then

            MsgBox("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'BUAT FORM HASIL
        Dim hasil As New Form2

        hasil.lblNama.Text = txtNama.Text
        hasil.lblUmur.Text = txtUmur.Text
        hasil.lblTelepon.Text = txtTelepon.Text
        hasil.lblAlamat.Text = txtAlamat.Text
        hasil.lblTanggal.Text = dtpTanggal.Value.ToShortDateString

        'JENIS KELAMIN
        If rbLaki.Checked Then
            hasil.lblJK.Text = "Laki - Laki"
        Else
            hasil.lblJK.Text = "Perempuan"
        End If

        'HOBBY
        Dim hobby As String = ""

        If cbMusik.Checked Then hobby &= "Musik, "
        If cbGame.Checked Then hobby &= "Game, "
        If cbMembaca.Checked Then hobby &= "Membaca, "
        If cbOlahraga.Checked Then hobby &= "Olahraga, "
        If cbTravel.Checked Then hobby &= "Travel, "
        If cbFotografi.Checked Then hobby &= "Fotografi, "
        If cbMemasak.Checked Then hobby &= "Memasak, "
        If cbMenulis.Checked Then hobby &= "Menulis, "
        If cbFilm.Checked Then hobby &= "Film, "
        If cbNgoding.Checked Then hobby &= "Ngoding, "

        hasil.lblHobby.Text = hobby

        'KIRIM FOTO
        hasil.picHasil.Image = picFoto.Image

        hasil.Show()

    End Sub

    Private Sub cbTravel_CheckedChanged(sender As Object, e As EventArgs) Handles cbTravel.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub
End Class