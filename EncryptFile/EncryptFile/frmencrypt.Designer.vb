<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmencrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmencrypt))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnencrypt = New System.Windows.Forms.Button()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttujuan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fileopen = New System.Windows.Forms.Button()
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnkirim = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(405, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(373, 416)
        Me.WebBrowser1.TabIndex = 14
        '
        'btnencrypt
        '
        Me.btnencrypt.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnencrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnencrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnencrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnencrypt.Location = New System.Drawing.Point(446, 448)
        Me.btnencrypt.Name = "btnencrypt"
        Me.btnencrypt.Size = New System.Drawing.Size(295, 33)
        Me.btnencrypt.TabIndex = 9
        Me.btnencrypt.Text = "Encrypt File"
        Me.btnencrypt.UseVisualStyleBackColor = True
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(117, 111)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(253, 20)
        Me.txtnama.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Penerima"
        '
        'txttujuan
        '
        Me.txttujuan.Location = New System.Drawing.Point(117, 85)
        Me.txttujuan.Name = "txttujuan"
        Me.txttujuan.Size = New System.Drawing.Size(253, 20)
        Me.txttujuan.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email Tujuan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fileopen)
        Me.GroupBox1.Controls.Add(Me.txtFileToEncrypt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 52)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'fileopen
        '
        Me.fileopen.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.fileopen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fileopen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.fileopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileopen.Location = New System.Drawing.Point(283, 18)
        Me.fileopen.Name = "fileopen"
        Me.fileopen.Size = New System.Drawing.Size(75, 25)
        Me.fileopen.TabIndex = 2
        Me.fileopen.Text = "Browse"
        Me.fileopen.UseVisualStyleBackColor = True
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(75, 21)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(202, 20)
        Me.txtFileToEncrypt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih File"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(87, 210)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(253, 20)
        Me.txtcari.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cari"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 236)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(372, 190)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnkirim
        '
        Me.btnkirim.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnkirim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnkirim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnkirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkirim.Location = New System.Drawing.Point(57, 152)
        Me.btnkirim.Name = "btnkirim"
        Me.btnkirim.Size = New System.Drawing.Size(295, 33)
        Me.btnkirim.TabIndex = 18
        Me.btnkirim.Text = "Kirim"
        Me.btnkirim.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(372, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'frmencrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(838, 530)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnkirim)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnencrypt)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttujuan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmencrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmencrypt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnencrypt As System.Windows.Forms.Button
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttujuan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fileopen As System.Windows.Forms.Button
    Friend WithEvents txtFileToEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnkirim As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
