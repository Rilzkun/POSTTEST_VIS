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
        btnTambah = New Button()
        btnHapus = New Button()
        ListBox1 = New ListBox()
        txtTambah = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtHapus = New TextBox()
        txtGenre = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Chartreuse
        btnTambah.Location = New Point(89, 123)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Location = New Point(89, 90)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 1
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(378, 114)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(330, 304)
        ListBox1.TabIndex = 2
        ' 
        ' txtTambah
        ' 
        txtTambah.Location = New Point(112, 44)
        txtTambah.Name = "txtTambah"
        txtTambah.Size = New Size(125, 27)
        txtTambah.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 4
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 5
        Label2.Text = "Judul Buku"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(112, 50)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(125, 27)
        txtHapus.TabIndex = 6
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(112, 79)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 8
        Label3.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(101, -1)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 86)
        Label4.TabIndex = 9
        Label4.Text = "E-BOOK" & vbCrLf & "UNMUL" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logob
        PictureBox1.Location = New Point(3, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonShadow
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtTambah)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Location = New Point(12, 114)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(295, 168)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonShadow
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtHapus)
        GroupBox2.Location = New Point(12, 288)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(295, 136)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtTambah As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
