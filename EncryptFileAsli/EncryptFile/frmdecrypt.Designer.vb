<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdecrypt
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
        Me.btndecrypt = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fileopen2 = New System.Windows.Forms.Button()
        Me.txtFileToDecrypt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtnosurat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttglsurat = New System.Windows.Forms.DateTimePicker()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btndecrypt
        '
        Me.btndecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btndecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btndecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndecrypt.Location = New System.Drawing.Point(448, 395)
        Me.btndecrypt.Name = "btndecrypt"
        Me.btndecrypt.Size = New System.Drawing.Size(295, 33)
        Me.btndecrypt.TabIndex = 12
        Me.btndecrypt.Text = "Decrypt File"
        Me.btndecrypt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fileopen2)
        Me.GroupBox2.Controls.Add(Me.txtFileToDecrypt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 52)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'fileopen2
        '
        Me.fileopen2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.fileopen2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fileopen2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.fileopen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileopen2.Location = New System.Drawing.Point(283, 18)
        Me.fileopen2.Name = "fileopen2"
        Me.fileopen2.Size = New System.Drawing.Size(75, 25)
        Me.fileopen2.TabIndex = 2
        Me.fileopen2.Text = "Browse"
        Me.fileopen2.UseVisualStyleBackColor = True
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(75, 21)
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(202, 20)
        Me.txtFileToDecrypt.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Pilih File"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(405, 87)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(373, 290)
        Me.WebBrowser2.TabIndex = 15
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(16, 157)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(372, 271)
        Me.ListView1.TabIndex = 23
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(54, 131)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(334, 20)
        Me.txtcari.TabIndex = 22
        '
        'txtnosurat
        '
        Me.txtnosurat.Location = New System.Drawing.Point(111, 32)
        Me.txtnosurat.Name = "txtnosurat"
        Me.txtnosurat.Size = New System.Drawing.Size(277, 20)
        Me.txtnosurat.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "No. Surat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tgl. Surat"
        '
        'txttglsurat
        '
        Me.txttglsurat.Location = New System.Drawing.Point(111, 61)
        Me.txttglsurat.Name = "txttglsurat"
        Me.txttglsurat.Size = New System.Drawing.Size(114, 20)
        Me.txttglsurat.TabIndex = 26
        '
        'btnsimpan
        '
        Me.btnsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnsimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Location = New System.Drawing.Point(28, 89)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(100, 33)
        Me.btnsimpan.TabIndex = 27
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnubah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnubah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Location = New System.Drawing.Point(154, 89)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(100, 33)
        Me.btnubah.TabIndex = 28
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnhapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Location = New System.Drawing.Point(274, 89)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(100, 33)
        Me.btnhapus.TabIndex = 29
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cari"
        '
        'frmdecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 584)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txttglsurat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtnosurat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.btndecrypt)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdecrypt"
        Me.Text = "frmdecrypt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndecrypt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fileopen2 As System.Windows.Forms.Button
    Friend WithEvents txtFileToDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents txtnosurat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttglsurat As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
