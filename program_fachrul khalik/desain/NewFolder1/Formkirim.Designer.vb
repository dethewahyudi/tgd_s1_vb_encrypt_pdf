<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formkirim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formkirim))
        Me.lblinisial = New System.Windows.Forms.Label()
        Me.txtinisial = New System.Windows.Forms.TextBox()
        Me.cbocari = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnkirim = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.lblacak = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblinisial
        '
        Me.lblinisial.AutoSize = True
        Me.lblinisial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinisial.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblinisial.Location = New System.Drawing.Point(38, 90)
        Me.lblinisial.Name = "lblinisial"
        Me.lblinisial.Size = New System.Drawing.Size(120, 20)
        Me.lblinisial.TabIndex = 56
        Me.lblinisial.Text = "Inisial Penerima"
        '
        'txtinisial
        '
        Me.txtinisial.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtinisial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtinisial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinisial.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtinisial.Location = New System.Drawing.Point(198, 92)
        Me.txtinisial.Name = "txtinisial"
        Me.txtinisial.Size = New System.Drawing.Size(226, 19)
        Me.txtinisial.TabIndex = 55
        '
        'cbocari
        '
        Me.cbocari.FormattingEnabled = True
        Me.cbocari.Items.AddRange(New Object() {"email tujuan", "tanggal surat", "inisial penerima"})
        Me.cbocari.Location = New System.Drawing.Point(39, 177)
        Me.cbocari.Name = "cbocari"
        Me.cbocari.Size = New System.Drawing.Size(121, 21)
        Me.cbocari.TabIndex = 54
        Me.cbocari.Text = "inisial penerima"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(37, 209)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(387, 239)
        Me.ListView1.TabIndex = 53
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Email Tujuan"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal kirim"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Inisial Penerima"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "lampiran"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'txtcari
        '
        Me.txtcari.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtcari.Location = New System.Drawing.Point(166, 179)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(258, 19)
        Me.txtcari.TabIndex = 52
        '
        'btnupload
        '
        Me.btnupload.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnupload.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnupload.Location = New System.Drawing.Point(309, 12)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(64, 23)
        Me.btnupload.TabIndex = 50
        Me.btnupload.Text = "upload file"
        Me.btnupload.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(610, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "dekripsi"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnkirim
        '
        Me.btnkirim.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnkirim.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnkirim.Location = New System.Drawing.Point(40, 124)
        Me.btnkirim.Name = "btnkirim"
        Me.btnkirim.Size = New System.Drawing.Size(385, 23)
        Me.btnkirim.TabIndex = 47
        Me.btnkirim.Text = "kirim"
        Me.btnkirim.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(38, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Alamat Email Tujuan"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtto
        '
        Me.txtto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtto.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtto.Location = New System.Drawing.Point(198, 62)
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(226, 19)
        Me.txtto.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(39, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Cari"
        '
        'txtfile
        '
        Me.txtfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtfile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfile.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtfile.Location = New System.Drawing.Point(99, 15)
        Me.txtfile.Name = "txtfile"
        Me.txtfile.Size = New System.Drawing.Size(191, 19)
        Me.txtfile.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(18, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Pilih File"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(479, 27)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(313, 421)
        Me.AxAcroPDF1.TabIndex = 63
        '
        'lblacak
        '
        Me.lblacak.AutoSize = True
        Me.lblacak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacak.ForeColor = System.Drawing.Color.Black
        Me.lblacak.Location = New System.Drawing.Point(701, 11)
        Me.lblacak.Name = "lblacak"
        Me.lblacak.Size = New System.Drawing.Size(91, 13)
        Me.lblacak.TabIndex = 64
        Me.lblacak.Text = "123456789012"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(479, 11)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(206, 10)
        Me.ProgressBar1.TabIndex = 65
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfile)
        Me.GroupBox1.Controls.Add(Me.btnupload)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 48)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'Formkirim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblacak)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblinisial)
        Me.Controls.Add(Me.txtinisial)
        Me.Controls.Add(Me.cbocari)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnkirim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtto)
        Me.Name = "Formkirim"
        Me.Text = "Kirim Data"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinisial As System.Windows.Forms.Label
    Friend WithEvents txtinisial As System.Windows.Forms.TextBox
    Friend WithEvents cbocari As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btnupload As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnkirim As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents lblacak As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
