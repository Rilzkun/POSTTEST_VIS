Public Class Form1

    Private Sub txtInputNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInputNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Inputan Nama hanya boleh huruf!", "Validasi")
        End If
    End Sub

    Private Sub txtInputID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInputID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Inputan ID hanya boleh angka!", "Validasi")
        End If
    End Sub

    Private Sub btnCariFoto_Click(sender As Object, e As EventArgs) Handles btnCariFoto.Click
        Dim ofdOpenFoto As New OpenFileDialog

        If ofdOpenFoto.ShowDialog() = DialogResult.OK Then
            pbPreviewFoto.ImageLocation = ofdOpenFoto.FileName
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click

        If txtInputNama.Text = "" Or txtInputID.Text = "" Or cbPilihanDivisi.SelectedIndex = -1 Or pbPreviewFoto.ImageLocation = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim tanya As DialogResult = MessageBox.Show("Apakah data sudah benar?", "Cetak Kartu", MessageBoxButtons.YesNo)

        If tanya = DialogResult.Yes Then
            Dim kartu As New Form2()

            kartu.lblDispNama.Text = txtInputNama.Text
            kartu.lblDispID.Text = txtInputID.Text
            kartu.lblDispDivisi.Text = cbPilihanDivisi.Text
            kartu.lblDispKontak.Text = mtbNoTelp.Text & " | " & txtInputEmail.Text
            kartu.pbFotoHasil.Image = pbPreviewFoto.Image

            Dim hobi As String = ""
            If chkBaca.Checked Then hobi &= "Membaca, "
            If chkCoding.Checked Then hobi &= "Coding, "
            If chkGame.Checked Then hobi &= "Gaming, "
            If chkMusik.Checked Then hobi &= "Musik, "
            If chkSport.Checked Then hobi &= "Olahraga, "
            If chkMakan.Checked Then hobi &= "Kuliner, "
            If chkTravel.Checked Then hobi &= "Traveling, "
            If chkNonton.Checked Then hobi &= "Nonton, "

            kartu.lblDispHobiList.Text = hobi.TrimEnd(", ".ToCharArray())

            kartu.Show()
        End If
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim sfdSaveData As New SaveFileDialog

        If sfdSaveData.ShowDialog() = DialogResult.OK Then
            Dim konten As String = "KARTU KOMUNITAS" & vbCrLf &
                                   "Nama: " & txtInputNama.Text & vbCrLf &
                                   "ID: " & txtInputID.Text & vbCrLf &
                                   "Kontak: " & txtInputEmail.Text
            IO.File.WriteAllText(sfdSaveData.FileName, konten)
            MessageBox.Show("Data berhasil disimpan!", "Sukses")
        End If
    End Sub

    Private Sub NavigasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigasiToolStripMenuItem.Click
        Dim tutup As DialogResult = MessageBox.Show("Yakin ingin keluar aplikasi?", "Keluar", MessageBoxButtons.YesNo)
        If tutup = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub lblJudulApp_Click(sender As Object, e As EventArgs) Handles lblJudulApp.Click

    End Sub

    Private Sub rbRoleAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rbRoleAdmin.CheckedChanged

    End Sub

    Private Sub chkCoding_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoding.CheckedChanged

    End Sub

    Private Sub ofdOpenFoto_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdOpenFoto.FileOk

    End Sub
End Class