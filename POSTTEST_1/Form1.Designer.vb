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
        btnReset = New Button()
        txtIPSemester = New TextBox()
        txtIPKumulatif = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(274, 148)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(374, 148)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 1
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(274, 115)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(194, 27)
        txtIPSemester.TabIndex = 2
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.Location = New Point(274, 193)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.Size = New Size(194, 27)
        txtIPKumulatif.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(177, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 4
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(177, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 5
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(339, 232)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(53, 20)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtIPKumulatif)
        Controls.Add(txtIPSemester)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents txtIPKumulatif As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label

End Class
