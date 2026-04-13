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
        txtIdAlat = New TextBox()
        txtNamaAlat = New TextBox()
        txtMerk = New TextBox()
        txtStok = New TextBox()
        txtHarga = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        txtCari = New TextBox()
        dgvAlat = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' txtMerk
        ' 
        txtMerk.Location = New Point(117, 105)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(175, 27)
        txtMerk.TabIndex = 2
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(117, 138)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(175, 27)
        txtStok.TabIndex = 3
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(117, 171)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(175, 27)
        txtHarga.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSimpan.Location = New Point(190, 400)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnUbah.Location = New Point(290, 400)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnHapus.Location = New Point(391, 400)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = SystemColors.ControlDarkDark
        btnBatal.Location = New Point(491, 400)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 8
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(77, 42)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(314, 27)
        txtCari.TabIndex = 9
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 11
        Label1.Text = "ID"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 13
        Label3.Text = "Merk"
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 15
        Label5.Text = "Harga"
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
        GroupBox1.Location = New Point(29, 167)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(318, 227)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Data Alat Musik"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(dgvAlat)
        GroupBox2.Controls.Add(txtCari)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(365, 167)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(423, 227)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Inventaris"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(208, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(332, 38)
        Label7.TabIndex = 19
        Label7.Text = "Music Inventory System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(281, 71)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(135, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = My.Resources.Resources.logo2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
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
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdAlat As TextBox
    Friend WithEvents txtNamaAlat As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvAlat As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
