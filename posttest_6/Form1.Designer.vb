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
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        dgvAlat = New DataGridView()
        txtCari = New TextBox()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        cmbKategori = New ComboBox()
        txtIdAlat = New TextBox()
        txtNamaAlat = New TextBox()
        Label5 = New Label()
        txtMerk = New TextBox()
        Label4 = New Label()
        txtStok = New TextBox()
        Label3 = New Label()
        txtHarga = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        dgvKategori = New DataGridView()
        GroupBox3 = New GroupBox()
        btnHapusKategori = New Button()
        btnUbahKategori = New Button()
        btnTambahKategori = New Button()
        Label9 = New Label()
        txtNamaKategori = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvKategori, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(-17, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(91, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(332, 38)
        Label7.TabIndex = 27
        Label7.Text = "Music Inventory System"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(dgvAlat)
        GroupBox2.Controls.Add(txtCari)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(356, 72)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(423, 227)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Inventaris"
        ' 
        ' dgvAlat
        ' 
        dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(36, 86)
        dgvAlat.Name = "dgvAlat"
        dgvAlat.RowHeadersWidth = 51
        dgvAlat.Size = New Size(355, 112)
        dgvAlat.TabIndex = 10
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(77, 42)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(314, 27)
        txtCari.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(36, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 16
        Label6.Text = "Cari"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cmbKategori)
        GroupBox1.Controls.Add(txtIdAlat)
        GroupBox1.Controls.Add(txtNamaAlat)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtMerk)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtStok)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtHarga)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 72)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(314, 249)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Data Alat Musik"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 207)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 20)
        Label8.TabIndex = 29
        Label8.Text = "Kategori"
        ' 
        ' cmbKategori
        ' 
        cmbKategori.FormattingEnabled = True
        cmbKategori.Location = New Point(117, 204)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(175, 28)
        cmbKategori.TabIndex = 16
        ' 
        ' txtIdAlat
        ' 
        txtIdAlat.Location = New Point(117, 39)
        txtIdAlat.Name = "txtIdAlat"
        txtIdAlat.Size = New Size(175, 27)
        txtIdAlat.TabIndex = 0
        ' 
        ' txtNamaAlat
        ' 
        txtNamaAlat.Location = New Point(117, 72)
        txtNamaAlat.Name = "txtNamaAlat"
        txtNamaAlat.Size = New Size(175, 27)
        txtNamaAlat.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 15
        Label5.Text = "Harga"
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(117, 105)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(175, 27)
        txtMerk.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 20)
        Label4.TabIndex = 14
        Label4.Text = "Stok"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(117, 138)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(175, 27)
        txtStok.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 13
        Label3.Text = "Merk"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(117, 171)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(175, 27)
        txtHarga.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 12
        Label2.Text = "Nama Alat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 11
        Label1.Text = "ID"
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = SystemColors.ControlDarkDark
        btnBatal.Location = New Point(656, 305)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 24
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnHapus.Location = New Point(556, 305)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 23
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnUbah.Location = New Point(456, 305)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 22
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSimpan.Location = New Point(356, 305)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 21
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' dgvKategori
        ' 
        dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKategori.Location = New Point(264, 3)
        dgvKategori.Name = "dgvKategori"
        dgvKategori.RowHeadersWidth = 51
        dgvKategori.Size = New Size(300, 89)
        dgvKategori.TabIndex = 29
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnHapusKategori)
        GroupBox3.Controls.Add(btnUbahKategori)
        GroupBox3.Controls.Add(btnTambahKategori)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtNamaKategori)
        GroupBox3.Controls.Add(dgvKategori)
        GroupBox3.Location = New Point(12, 340)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(704, 98)
        GroupBox3.TabIndex = 29
        GroupBox3.TabStop = False
        GroupBox3.Text = "Kelola Kategori"
        ' 
        ' btnHapusKategori
        ' 
        btnHapusKategori.Location = New Point(596, 63)
        btnHapusKategori.Name = "btnHapusKategori"
        btnHapusKategori.Size = New Size(94, 29)
        btnHapusKategori.TabIndex = 34
        btnHapusKategori.Text = "Hapus"
        btnHapusKategori.UseVisualStyleBackColor = True
        ' 
        ' btnUbahKategori
        ' 
        btnUbahKategori.Location = New Point(596, 40)
        btnUbahKategori.Name = "btnUbahKategori"
        btnUbahKategori.Size = New Size(94, 29)
        btnUbahKategori.TabIndex = 33
        btnUbahKategori.Text = "Ubah"
        btnUbahKategori.UseVisualStyleBackColor = True
        ' 
        ' btnTambahKategori
        ' 
        btnTambahKategori.Location = New Point(596, 12)
        btnTambahKategori.Name = "btnTambahKategori"
        btnTambahKategori.Size = New Size(94, 29)
        btnTambahKategori.TabIndex = 32
        btnTambahKategori.Text = "Tambah"
        btnTambahKategori.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 44)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 20)
        Label9.TabIndex = 31
        Label9.Text = "Nama Kategori"
        ' 
        ' txtNamaKategori
        ' 
        txtNamaKategori.Location = New Point(133, 44)
        txtNamaKategori.Name = "txtNamaKategori"
        txtNamaKategori.Size = New Size(125, 27)
        txtNamaKategori.TabIndex = 30
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.logo2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox3)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvKategori, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvAlat As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdAlat As TextBox
    Friend WithEvents txtNamaAlat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dgvKategori As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnHapusKategori As Button
    Friend WithEvents btnUbahKategori As Button
    Friend WithEvents btnTambahKategori As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNamaKategori As TextBox

End Class
