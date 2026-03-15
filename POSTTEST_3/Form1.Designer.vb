<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelepon = New TextBox()
        txtAlamat = New TextBox()
        GroupBox1 = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        GroupBox2 = New GroupBox()
        cbNgoding = New CheckBox()
        cbFilm = New CheckBox()
        cbMenulis = New CheckBox()
        cbMemasak = New CheckBox()
        cbFotografi = New CheckBox()
        cbTravel = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbGame = New CheckBox()
        cbMusik = New CheckBox()
        Label7 = New Label()
        dtpTanggal = New DateTimePicker()
        btnCetak = New Button()
        PictureBox1 = New PictureBox()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(25, 167)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(169, 197)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 14
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(56, 380)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 13
        btnBrowse.Text = "Browse"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(235, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 12
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(235, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 11
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(235, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 10
        Label3.Text = "Nomor Telepon"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(235, 164)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 9
        Label6.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Green
        txtNama.ForeColor = SystemColors.ButtonHighlight
        txtNama.Location = New Point(372, 57)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(372, 27)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.Green
        txtUmur.ForeColor = SystemColors.ButtonHighlight
        txtUmur.Location = New Point(372, 90)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(372, 27)
        txtUmur.TabIndex = 7
        ' 
        ' txtTelepon
        ' 
        txtTelepon.BackColor = Color.Green
        txtTelepon.ForeColor = SystemColors.ButtonHighlight
        txtTelepon.Location = New Point(372, 123)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(372, 27)
        txtTelepon.TabIndex = 6
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.Green
        txtAlamat.ForeColor = SystemColors.ButtonHighlight
        txtAlamat.Location = New Point(372, 157)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(372, 27)
        txtAlamat.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(rbLaki)
        GroupBox1.ForeColor = SystemColors.ButtonFace
        GroupBox1.Location = New Point(235, 251)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 139)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(47, 56)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 0
        rbPerempuan.Text = "Perempuan"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(47, 26)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 1
        rbLaki.Text = "Laki-Laki"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(cbNgoding)
        GroupBox2.Controls.Add(cbFilm)
        GroupBox2.Controls.Add(cbMenulis)
        GroupBox2.Controls.Add(cbMemasak)
        GroupBox2.Controls.Add(cbFotografi)
        GroupBox2.Controls.Add(cbTravel)
        GroupBox2.Controls.Add(cbOlahraga)
        GroupBox2.Controls.Add(cbMembaca)
        GroupBox2.Controls.Add(cbGame)
        GroupBox2.Controls.Add(cbMusik)
        GroupBox2.ForeColor = SystemColors.ButtonFace
        GroupBox2.Location = New Point(502, 251)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(274, 176)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' cbNgoding
        ' 
        cbNgoding.Location = New Point(154, 147)
        cbNgoding.Name = "cbNgoding"
        cbNgoding.Size = New Size(104, 24)
        cbNgoding.TabIndex = 0
        cbNgoding.Text = "Ngoding"
        ' 
        ' cbFilm
        ' 
        cbFilm.Location = New Point(154, 117)
        cbFilm.Name = "cbFilm"
        cbFilm.Size = New Size(104, 24)
        cbFilm.TabIndex = 1
        cbFilm.Text = "Film"
        ' 
        ' cbMenulis
        ' 
        cbMenulis.Location = New Point(154, 87)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(104, 24)
        cbMenulis.TabIndex = 2
        cbMenulis.Text = "Menulis"
        ' 
        ' cbMemasak
        ' 
        cbMemasak.Location = New Point(154, 59)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(104, 24)
        cbMemasak.TabIndex = 3
        cbMemasak.Text = "Memasak"
        ' 
        ' cbFotografi
        ' 
        cbFotografi.Location = New Point(154, 29)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(104, 24)
        cbFotografi.TabIndex = 4
        cbFotografi.Text = "Fotografi"
        ' 
        ' cbTravel
        ' 
        cbTravel.Location = New Point(15, 146)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(104, 24)
        cbTravel.TabIndex = 5
        cbTravel.Text = "Travel"
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.Location = New Point(15, 117)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(104, 24)
        cbOlahraga.TabIndex = 6
        cbOlahraga.Text = "Olahraga"
        ' 
        ' cbMembaca
        ' 
        cbMembaca.Location = New Point(15, 87)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(104, 24)
        cbMembaca.TabIndex = 7
        cbMembaca.Text = "Membaca"
        ' 
        ' cbGame
        ' 
        cbGame.Location = New Point(15, 57)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(104, 24)
        cbGame.TabIndex = 8
        cbGame.Text = "Game"
        ' 
        ' cbMusik
        ' 
        cbMusik.Location = New Point(15, 26)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(104, 24)
        cbMusik.TabIndex = 9
        cbMusik.Text = "Musik"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(235, 197)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 20)
        Label7.TabIndex = 2
        Label7.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CalendarTitleForeColor = SystemColors.ActiveCaption
        dtpTanggal.Location = New Point(372, 190)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(372, 27)
        dtpTanggal.TabIndex = 1
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(235, 398)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(250, 29)
        btnCetak.TabIndex = 0
        btnCetak.Text = "Cetak"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Seal_of_the_Federal_Bureau_of_Investigation1
        PictureBox1.Location = New Point(12, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(178, 118)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        BackgroundImage = My.Resources.Resources._5720f008b5301da33f1a2b818d3e2971
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnCetak)
        Controls.Add(dtpTanggal)
        Controls.Add(Label7)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Name = "Form1"
        Text = "Form Cetak Kartu"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents GroupBox2 As GroupBox

    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbFilm As CheckBox
    Friend WithEvents cbNgoding As CheckBox

    Friend WithEvents Label7 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents btnCetak As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class