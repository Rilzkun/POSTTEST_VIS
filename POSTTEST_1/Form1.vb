Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrWhiteSpace(txtIPSemester.Text) Then
            MsgBox("Silakan isi IP Semester terlebih dahulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim ipInput As Double = Val(txtIPSemester.Text.Replace(",", "."))

        totalIP += ipInput
        jumlahSemester += 1

        Dim ipk As Double = totalIP / jumlahSemester
        txtIPKumulatif.Text = Format(ipk, "0.00")

        If ipk >= 3.01 Then
            lblStatus.Text = "Sangat Memuaskan"
        ElseIf ipk >= 2.76 Then
            lblStatus.Text = "Memuaskan"
        ElseIf ipk >= 2.0 Then
            lblStatus.Text = "Cukup"
        Else
            lblStatus.Text = "Di bawah standar"
        End If

        txtIPSemester.Clear()
        txtIPSemester.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0

        txtIPSemester.Clear()
        txtIPKumulatif.Clear()
        lblStatus.Text = "Status"

        txtIPSemester.Focus()
    End Sub
End Class