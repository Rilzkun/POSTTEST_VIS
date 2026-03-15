<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        picHasil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblAlamat = New Label()
        lblTanggal = New Label()
        lblJk = New Label()
        lblHobby = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label1.Location = New Point(-8, -7)
        Label1.Name = "Label1"
        Label1.Size = New Size(822, 75)
        Label1.TabIndex = 0
        Label1.Text = "DEPARTEMENT OF INVESTIGATIONS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Seal_of_the_Federal_Bureau_of_Investigation_svg
        PictureBox1.Location = New Point(12, 62)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(235, 203)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Impact", 130.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label2.Location = New Point(198, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(379, 264)
        Label2.TabIndex = 2
        Label2.Text = "FBI"
        ' 
        ' picHasil
        ' 
        picHasil.Location = New Point(533, 71)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(229, 260)
        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.TabIndex = 3
        picHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblNama.Location = New Point(200, 305)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(73, 31)
        lblNama.TabIndex = 4
        lblNama.Text = "nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUmur.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblUmur.Location = New Point(89, 340)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(47, 20)
        lblUmur.TabIndex = 5
        lblUmur.Text = "umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTelepon.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblTelepon.Location = New Point(88, 400)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(54, 20)
        lblTelepon.TabIndex = 6
        lblTelepon.Text = "notelp"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAlamat.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblAlamat.Location = New Point(88, 370)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "alamat"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTanggal.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblTanggal.Location = New Point(344, 339)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(62, 20)
        lblTanggal.TabIndex = 8
        lblTanggal.Text = "tanggal"
        ' 
        ' lblJk
        ' 
        lblJk.AutoSize = True
        lblJk.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJk.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblJk.Location = New Point(345, 370)
        lblJk.Name = "lblJk"
        lblJk.Size = New Size(21, 20)
        lblJk.TabIndex = 9
        lblJk.Text = "jk"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblHobby.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblHobby.Location = New Point(345, 400)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(53, 20)
        lblHobby.TabIndex = 10
        lblHobby.Text = "hobby"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label4.Location = New Point(11, 339)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 12
        Label4.Text = "Umur     :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label5.Location = New Point(11, 400)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 20)
        Label5.TabIndex = 13
        Label5.Text = "No Telp :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label6.Location = New Point(11, 370)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 14
        Label6.Text = "Alamat  :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label7.Location = New Point(234, 339)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 20)
        Label7.TabIndex = 15
        Label7.Text = "Tanggal Lahir :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label8.Location = New Point(234, 400)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 20)
        Label8.TabIndex = 16
        Label8.Text = "Hobby            :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label9.Location = New Point(234, 370)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 20)
        Label9.TabIndex = 17
        Label9.Text = "Jenis Kelamin :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label10.Location = New Point(12, 279)
        Label10.Name = "Label10"
        Label10.Size = New Size(422, 20)
        Label10.TabIndex = 18
        Label10.Text = "THIS CERTIFIES THAT THE SIGNATURE AND PHOTOGRAPH"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label11.Location = New Point(11, 305)
        Label11.Name = "Label11"
        Label11.Size = New Size(183, 31)
        Label11.TabIndex = 19
        Label11.Text = "SPECIAL AGENT"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label12.Location = New Point(11, 430)
        Label12.Name = "Label12"
        Label12.Size = New Size(618, 20)
        Label12.TabIndex = 20
        Label12.Text = "OF FEDERAL BERUAU OF JUSTICE, UNITED STATES DEPARTEMENT OF INVESTIGATION"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(lblHobby)
        Controls.Add(lblJk)
        Controls.Add(lblTanggal)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picHasil)
        Controls.Add(Label2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJk As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
