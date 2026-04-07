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
        pnlBackgroundKartu = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnTutupKartu = New Button()
        lblDispHobiList = New Label()
        lblDispKontak = New Label()
        lblDispDivisi = New Label()
        lblDispID = New Label()
        lblDispNama = New Label()
        pbFotoHasil = New PictureBox()
        Label6 = New Label()
        pnlBackgroundKartu.SuspendLayout()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlBackgroundKartu
        ' 
        pnlBackgroundKartu.BackColor = SystemColors.ActiveBorder
        pnlBackgroundKartu.Controls.Add(Label5)
        pnlBackgroundKartu.Controls.Add(Label4)
        pnlBackgroundKartu.Controls.Add(Label3)
        pnlBackgroundKartu.Controls.Add(Label2)
        pnlBackgroundKartu.Controls.Add(Label1)
        pnlBackgroundKartu.Controls.Add(btnTutupKartu)
        pnlBackgroundKartu.Controls.Add(lblDispHobiList)
        pnlBackgroundKartu.Controls.Add(lblDispKontak)
        pnlBackgroundKartu.Controls.Add(lblDispDivisi)
        pnlBackgroundKartu.Controls.Add(lblDispID)
        pnlBackgroundKartu.Controls.Add(lblDispNama)
        pnlBackgroundKartu.Controls.Add(pbFotoHasil)
        pnlBackgroundKartu.Location = New Point(104, 88)
        pnlBackgroundKartu.Name = "pnlBackgroundKartu"
        pnlBackgroundKartu.Size = New Size(616, 282)
        pnlBackgroundKartu.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(202, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 12
        Label5.Text = "Hobi :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(202, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 11
        Label4.Text = "Kontak :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(202, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 10
        Label3.Text = "Divisi :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 20)
        Label2.TabIndex = 9
        Label2.Text = "ID :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(202, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 8
        Label1.Text = "Nama :"
        ' 
        ' btnTutupKartu
        ' 
        btnTutupKartu.Location = New Point(345, 376)
        btnTutupKartu.Name = "btnTutupKartu"
        btnTutupKartu.Size = New Size(94, 29)
        btnTutupKartu.TabIndex = 7
        btnTutupKartu.Text = "Tutup"
        btnTutupKartu.UseVisualStyleBackColor = True
        ' 
        ' lblDispHobiList
        ' 
        lblDispHobiList.AutoSize = True
        lblDispHobiList.Location = New Point(282, 203)
        lblDispHobiList.Name = "lblDispHobiList"
        lblDispHobiList.Size = New Size(42, 20)
        lblDispHobiList.TabIndex = 6
        lblDispHobiList.Text = "Hobi"
        ' 
        ' lblDispKontak
        ' 
        lblDispKontak.AutoSize = True
        lblDispKontak.Location = New Point(282, 163)
        lblDispKontak.Name = "lblDispKontak"
        lblDispKontak.Size = New Size(55, 20)
        lblDispKontak.TabIndex = 5
        lblDispKontak.Text = "Kontak"
        ' 
        ' lblDispDivisi
        ' 
        lblDispDivisi.AutoSize = True
        lblDispDivisi.Location = New Point(282, 121)
        lblDispDivisi.Name = "lblDispDivisi"
        lblDispDivisi.Size = New Size(45, 20)
        lblDispDivisi.TabIndex = 4
        lblDispDivisi.Text = "Divisi"
        ' 
        ' lblDispID
        ' 
        lblDispID.AutoSize = True
        lblDispID.Location = New Point(282, 75)
        lblDispID.Name = "lblDispID"
        lblDispID.Size = New Size(24, 20)
        lblDispID.TabIndex = 3
        lblDispID.Text = "ID"
        ' 
        ' lblDispNama
        ' 
        lblDispNama.AutoSize = True
        lblDispNama.Location = New Point(282, 34)
        lblDispNama.Name = "lblDispNama"
        lblDispNama.Size = New Size(49, 20)
        lblDispNama.TabIndex = 2
        lblDispNama.Text = "Nama"
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.Location = New Point(24, 37)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(151, 198)
        pbFotoHasil.SizeMode = PictureBoxSizeMode.Zoom
        pbFotoHasil.TabIndex = 1
        pbFotoHasil.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(315, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(181, 21)
        Label6.TabIndex = 1
        Label6.Text = "KARTU KOMUNITAS"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(pnlBackgroundKartu)
        Name = "Form2"
        Text = "Form2"
        pnlBackgroundKartu.ResumeLayout(False)
        pnlBackgroundKartu.PerformLayout()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlBackgroundKartu As Panel
    Friend WithEvents btnTutupKartu As Button
    Friend WithEvents lblDispHobiList As Label
    Friend WithEvents lblDispKontak As Label
    Friend WithEvents lblDispDivisi As Label
    Friend WithEvents lblDispID As Label
    Friend WithEvents lblDispNama As Label
    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
