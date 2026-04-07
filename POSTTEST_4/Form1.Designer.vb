<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        msNavigasiUtama = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NavigasiToolStripMenuItem = New ToolStripMenuItem()
        lblJudulApp = New Label()
        pbLogoKomunitas = New PictureBox()
        tcInputData = New TabControl()
        tabPage3 = New TabPage()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cbPilihanDivisi = New ComboBox()
        rbGenderP = New RadioButton()
        rbGenderL = New RadioButton()
        dtpTglLahir = New DateTimePicker()
        txtInputID = New TextBox()
        txtInputNama = New TextBox()
        TabPage2 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtInputAlamat = New TextBox()
        txtInputEmail = New TextBox()
        mtbNoTelp = New MaskedTextBox()
        TabPage1 = New TabPage()
        chkNonton = New CheckBox()
        chkTravel = New CheckBox()
        chkMakan = New CheckBox()
        chkSport = New CheckBox()
        chkMusik = New CheckBox()
        gbRoleAnggota = New GroupBox()
        rbRoleAdmin = New RadioButton()
        rbRoleAnggota = New RadioButton()
        rbRoleKetua = New RadioButton()
        chkGame = New CheckBox()
        chkCoding = New CheckBox()
        chkBaca = New CheckBox()
        btnCariFoto = New Button()
        pbPreviewFoto = New PictureBox()
        ofdOpenFoto = New OpenFileDialog()
        sfdSaveData = New SaveFileDialog()
        btnSimpanCetak = New Button()
        msNavigasiUtama.SuspendLayout()
        CType(pbLogoKomunitas, ComponentModel.ISupportInitialize).BeginInit()
        tcInputData.SuspendLayout()
        tabPage3.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        gbRoleAnggota.SuspendLayout()
        CType(pbPreviewFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' msNavigasiUtama
        ' 
        msNavigasiUtama.ImageScalingSize = New Size(20, 20)
        msNavigasiUtama.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, NavigasiToolStripMenuItem})
        msNavigasiUtama.Location = New Point(0, 0)
        msNavigasiUtama.Name = "msNavigasiUtama"
        msNavigasiUtama.Size = New Size(800, 28)
        msNavigasiUtama.TabIndex = 0
        msNavigasiUtama.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NavigasiToolStripMenuItem
        ' 
        NavigasiToolStripMenuItem.Name = "NavigasiToolStripMenuItem"
        NavigasiToolStripMenuItem.Size = New Size(80, 24)
        NavigasiToolStripMenuItem.Text = "Navigasi"
        ' 
        ' lblJudulApp
        ' 
        lblJudulApp.AutoSize = True
        lblJudulApp.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblJudulApp.Location = New Point(112, 38)
        lblJudulApp.Name = "lblJudulApp"
        lblJudulApp.Size = New Size(159, 87)
        lblJudulApp.TabIndex = 1
        lblJudulApp.Text = "KOMUNITAS " + vbCrLf + "BELAJAR " + vbCrLf + "ID"
        ' 
        ' pbLogoKomunitas
        ' 
        pbLogoKomunitas.Image = My.Resources.Resources.images
        pbLogoKomunitas.Location = New Point(12, 41)
        pbLogoKomunitas.Name = "pbLogoKomunitas"
        pbLogoKomunitas.Size = New Size(94, 85)
        pbLogoKomunitas.SizeMode = PictureBoxSizeMode.Zoom
        pbLogoKomunitas.TabIndex = 2
        pbLogoKomunitas.TabStop = False
        ' 
        ' tcInputData
        ' 
        tcInputData.Controls.Add(tabPage3)
        tcInputData.Controls.Add(TabPage2)
        tcInputData.Controls.Add(TabPage1)
        tcInputData.Location = New Point(214, 128)
        tcInputData.Name = "tcInputData"
        tcInputData.SelectedIndex = 0
        tcInputData.Size = New Size(423, 272)
        tcInputData.TabIndex = 3
        ' 
        ' tabPage3
        ' 
        tabPage3.Controls.Add(Label5)
        tabPage3.Controls.Add(Label4)
        tabPage3.Controls.Add(Label3)
        tabPage3.Controls.Add(Label2)
        tabPage3.Controls.Add(Label1)
        tabPage3.Controls.Add(cbPilihanDivisi)
        tabPage3.Controls.Add(rbGenderP)
        tabPage3.Controls.Add(rbGenderL)
        tabPage3.Controls.Add(dtpTglLahir)
        tabPage3.Controls.Add(txtInputID)
        tabPage3.Controls.Add(txtInputNama)
        tabPage3.Location = New Point(4, 29)
        tabPage3.Name = "tabPage3"
        tabPage3.Padding = New Padding(3)
        tabPage3.Size = New Size(415, 239)
        tabPage3.TabIndex = 0
        tabPage3.Text = "Data Diri"
        tabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 10
        Label5.Text = "DIvisi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 20)
        Label4.TabIndex = 9
        Label4.Text = "JK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 8
        Label3.Text = "Tgl Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 20)
        Label2.TabIndex = 7
        Label2.Text = "ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 6
        Label1.Text = "Nama"
        ' 
        ' cbPilihanDivisi
        ' 
        cbPilihanDivisi.FormattingEnabled = True
        cbPilihanDivisi.Items.AddRange(New Object() {"Kurikulum & Materi", "Riset & Teknologi", "Minat & Bakat", "Humas & Publikasi"})
        cbPilihanDivisi.Location = New Point(98, 165)
        cbPilihanDivisi.Name = "cbPilihanDivisi"
        cbPilihanDivisi.Size = New Size(151, 28)
        cbPilihanDivisi.TabIndex = 5
        ' 
        ' rbGenderP
        ' 
        rbGenderP.AutoSize = True
        rbGenderP.Location = New Point(189, 135)
        rbGenderP.Name = "rbGenderP"
        rbGenderP.Size = New Size(104, 24)
        rbGenderP.TabIndex = 4
        rbGenderP.TabStop = True
        rbGenderP.Text = "Perempuan"
        rbGenderP.UseVisualStyleBackColor = True
        ' 
        ' rbGenderL
        ' 
        rbGenderL.AutoSize = True
        rbGenderL.Location = New Point(98, 135)
        rbGenderL.Name = "rbGenderL"
        rbGenderL.Size = New Size(85, 24)
        rbGenderL.TabIndex = 3
        rbGenderL.TabStop = True
        rbGenderL.Text = "Laki-laki"
        rbGenderL.UseVisualStyleBackColor = True
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Location = New Point(98, 100)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(250, 27)
        dtpTglLahir.TabIndex = 2
        ' 
        ' txtInputID
        ' 
        txtInputID.Location = New Point(98, 60)
        txtInputID.Name = "txtInputID"
        txtInputID.Size = New Size(125, 27)
        txtInputID.TabIndex = 1
        ' 
        ' txtInputNama
        ' 
        txtInputNama.Location = New Point(98, 23)
        txtInputNama.Name = "txtInputNama"
        txtInputNama.Size = New Size(125, 27)
        txtInputNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(txtInputAlamat)
        TabPage2.Controls.Add(txtInputEmail)
        TabPage2.Controls.Add(mtbNoTelp)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(415, 239)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Alamat"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(84, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 20)
        Label8.TabIndex = 5
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(84, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 4
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(84, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 3
        Label6.Text = "No. Telp"
        ' 
        ' txtInputAlamat
        ' 
        txtInputAlamat.Location = New Point(192, 148)
        txtInputAlamat.Name = "txtInputAlamat"
        txtInputAlamat.Size = New Size(125, 27)
        txtInputAlamat.TabIndex = 2
        ' 
        ' txtInputEmail
        ' 
        txtInputEmail.Location = New Point(192, 104)
        txtInputEmail.Name = "txtInputEmail"
        txtInputEmail.Size = New Size(125, 27)
        txtInputEmail.TabIndex = 1
        ' 
        ' mtbNoTelp
        ' 
        mtbNoTelp.Location = New Point(192, 62)
        mtbNoTelp.Name = "mtbNoTelp"
        mtbNoTelp.Size = New Size(125, 27)
        mtbNoTelp.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(chkNonton)
        TabPage1.Controls.Add(chkTravel)
        TabPage1.Controls.Add(chkMakan)
        TabPage1.Controls.Add(chkSport)
        TabPage1.Controls.Add(chkMusik)
        TabPage1.Controls.Add(gbRoleAnggota)
        TabPage1.Controls.Add(chkGame)
        TabPage1.Controls.Add(chkCoding)
        TabPage1.Controls.Add(chkBaca)
        TabPage1.Controls.Add(btnCariFoto)
        TabPage1.Controls.Add(pbPreviewFoto)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(415, 239)
        TabPage1.TabIndex = 2
        TabPage1.Text = "Profil & Minat"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' chkNonton
        ' 
        chkNonton.AutoSize = True
        chkNonton.Location = New Point(274, 215)
        chkNonton.Name = "chkNonton"
        chkNonton.Size = New Size(81, 24)
        chkNonton.TabIndex = 10
        chkNonton.Text = "Nonton"
        chkNonton.UseVisualStyleBackColor = True
        ' 
        ' chkTravel
        ' 
        chkTravel.AutoSize = True
        chkTravel.Location = New Point(274, 189)
        chkTravel.Name = "chkTravel"
        chkTravel.Size = New Size(91, 24)
        chkTravel.TabIndex = 9
        chkTravel.Text = "Traveling"
        chkTravel.UseVisualStyleBackColor = True
        ' 
        ' chkMakan
        ' 
        chkMakan.AutoSize = True
        chkMakan.Location = New Point(274, 163)
        chkMakan.Name = "chkMakan"
        chkMakan.Size = New Size(75, 24)
        chkMakan.TabIndex = 8
        chkMakan.Text = "Makan"
        chkMakan.UseVisualStyleBackColor = True
        ' 
        ' chkSport
        ' 
        chkSport.AutoSize = True
        chkSport.Location = New Point(274, 133)
        chkSport.Name = "chkSport"
        chkSport.Size = New Size(92, 24)
        chkSport.TabIndex = 7
        chkSport.Text = "Olahraga"
        chkSport.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.Location = New Point(152, 215)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(69, 24)
        chkMusik.TabIndex = 6
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' gbRoleAnggota
        ' 
        gbRoleAnggota.Controls.Add(rbRoleAdmin)
        gbRoleAnggota.Controls.Add(rbRoleAnggota)
        gbRoleAnggota.Controls.Add(rbRoleKetua)
        gbRoleAnggota.Location = New Point(155, 12)
        gbRoleAnggota.Name = "gbRoleAnggota"
        gbRoleAnggota.Size = New Size(172, 115)
        gbRoleAnggota.TabIndex = 2
        gbRoleAnggota.TabStop = False
        gbRoleAnggota.Text = "Jabatan"
        ' 
        ' rbRoleAdmin
        ' 
        rbRoleAdmin.AutoSize = True
        rbRoleAdmin.Location = New Point(7, 80)
        rbRoleAdmin.Name = "rbRoleAdmin"
        rbRoleAdmin.Size = New Size(74, 24)
        rbRoleAdmin.TabIndex = 2
        rbRoleAdmin.TabStop = True
        rbRoleAdmin.Text = "Admin"
        rbRoleAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbRoleAnggota
        ' 
        rbRoleAnggota.AutoSize = True
        rbRoleAnggota.Location = New Point(7, 50)
        rbRoleAnggota.Name = "rbRoleAnggota"
        rbRoleAnggota.Size = New Size(88, 24)
        rbRoleAnggota.TabIndex = 1
        rbRoleAnggota.TabStop = True
        rbRoleAnggota.Text = "Anggota"
        rbRoleAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbRoleKetua
        ' 
        rbRoleKetua.AutoSize = True
        rbRoleKetua.Location = New Point(7, 20)
        rbRoleKetua.Name = "rbRoleKetua"
        rbRoleKetua.Size = New Size(68, 24)
        rbRoleKetua.TabIndex = 0
        rbRoleKetua.TabStop = True
        rbRoleKetua.Text = "Ketua"
        rbRoleKetua.UseVisualStyleBackColor = True
        ' 
        ' chkGame
        ' 
        chkGame.AutoSize = True
        chkGame.Location = New Point(152, 189)
        chkGame.Name = "chkGame"
        chkGame.Size = New Size(83, 24)
        chkGame.TabIndex = 5
        chkGame.Text = "Gaming"
        chkGame.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(152, 159)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(79, 24)
        chkCoding.TabIndex = 4
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkBaca
        ' 
        chkBaca.AutoSize = True
        chkBaca.Location = New Point(152, 133)
        chkBaca.Name = "chkBaca"
        chkBaca.Size = New Size(97, 24)
        chkBaca.TabIndex = 3
        chkBaca.Text = "Membaca"
        chkBaca.UseVisualStyleBackColor = True
        ' 
        ' btnCariFoto
        ' 
        btnCariFoto.Location = New Point(21, 184)
        btnCariFoto.Name = "btnCariFoto"
        btnCariFoto.Size = New Size(109, 29)
        btnCariFoto.TabIndex = 1
        btnCariFoto.Text = "Cari Foto"
        btnCariFoto.UseVisualStyleBackColor = True
        ' 
        ' pbPreviewFoto
        ' 
        pbPreviewFoto.Location = New Point(21, 12)
        pbPreviewFoto.Name = "pbPreviewFoto"
        pbPreviewFoto.Size = New Size(109, 166)
        pbPreviewFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbPreviewFoto.TabIndex = 0
        pbPreviewFoto.TabStop = False
        ' 
        ' ofdOpenFoto
        ' 
        ofdOpenFoto.FileName = "OpenFileDialog1"
        ofdOpenFoto.Filter = "Format Gambar|*.jpg;*.jpeg;*.png"
        ' 
        ' sfdSaveData
        ' 
        sfdSaveData.Filter = "Text File|*.txt"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(357, 399)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(94, 29)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "Simpan"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSimpanCetak)
        Controls.Add(tcInputData)
        Controls.Add(pbLogoKomunitas)
        Controls.Add(lblJudulApp)
        Controls.Add(msNavigasiUtama)
        MainMenuStrip = msNavigasiUtama
        Name = "Form1"
        Text = "Manajemen Komunitas"
        msNavigasiUtama.ResumeLayout(False)
        msNavigasiUtama.PerformLayout()
        CType(pbLogoKomunitas, ComponentModel.ISupportInitialize).EndInit()
        tcInputData.ResumeLayout(False)
        tabPage3.ResumeLayout(False)
        tabPage3.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        gbRoleAnggota.ResumeLayout(False)
        gbRoleAnggota.PerformLayout()
        CType(pbPreviewFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents msNavigasiUtama As MenuStrip
    Friend WithEvents lblJudulApp As Label
    Friend WithEvents pbLogoKomunitas As PictureBox
    Friend WithEvents tcInputData As TabControl
    Friend WithEvents tabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents txtInputID As TextBox
    Friend WithEvents txtInputNama As TextBox
    Friend WithEvents cbPilihanDivisi As ComboBox
    Friend WithEvents rbGenderP As RadioButton
    Friend WithEvents rbGenderL As RadioButton
    Friend WithEvents txtInputAlamat As TextBox
    Friend WithEvents txtInputEmail As TextBox
    Friend WithEvents mtbNoTelp As MaskedTextBox
    Friend WithEvents pbPreviewFoto As PictureBox
    Friend WithEvents gbRoleAnggota As GroupBox
    Friend WithEvents rbRoleAdmin As RadioButton
    Friend WithEvents rbRoleAnggota As RadioButton
    Friend WithEvents rbRoleKetua As RadioButton
    Friend WithEvents btnCariFoto As Button

    ' Friend WithEvents untuk Checkbox yang sudah diubah namanya
    Friend WithEvents chkBaca As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkGame As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkSport As CheckBox
    Friend WithEvents chkMakan As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents chkNonton As CheckBox
    Friend WithEvents ofdOpenFoto As OpenFileDialog
    Friend WithEvents sfdSaveData As SaveFileDialog
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label

End Class