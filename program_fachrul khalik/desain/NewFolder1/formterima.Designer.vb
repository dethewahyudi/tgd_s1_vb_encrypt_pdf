<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formterima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formterima))
        Me.txtnosurat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbocari = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblno = New System.Windows.Forms.Label()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.txttglsurat = New System.Windows.Forms.TextBox()
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnosurat
        '
        Me.txtnosurat.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnosurat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnosurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnosurat.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtnosurat.Location = New System.Drawing.Point(162, 95)
        Me.txtnosurat.Name = "txtnosurat"
        Me.txtnosurat.Size = New System.Drawing.Size(240, 19)
        Me.txtnosurat.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(38, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(38, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(265, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "ubah"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(289, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "upload file"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtcari
        '
        Me.txtcari.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtcari.Location = New System.Drawing.Point(137, 22)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(230, 19)
        Me.txtcari.TabIndex = 19
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 56)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(359, 95)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. Surat"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal Surat"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "nama"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tanggal diterima"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Lampiran"
        '
        'cbocari
        '
        Me.cbocari.FormattingEnabled = True
        Me.cbocari.Items.AddRange(New Object() {"no.surat", "tanggal surat", "tanggal diterima", "ket nama"})
        Me.cbocari.Location = New System.Drawing.Point(10, 20)
        Me.cbocari.Name = "cbocari"
        Me.cbocari.Size = New System.Drawing.Size(121, 21)
        Me.cbocari.TabIndex = 24
        Me.cbocari.Text = "no.surat"
        '
        'txtnama
        '
        Me.txtnama.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtnama.Location = New System.Drawing.Point(162, 120)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(240, 19)
        Me.txtnama.TabIndex = 25
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(496, 21)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(313, 421)
        Me.AxAcroPDF1.TabIndex = 27
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Black
        Me.lblno.Location = New System.Drawing.Point(718, 5)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(91, 13)
        Me.lblno.TabIndex = 29
        Me.lblno.Text = "123456789012"
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnhapus.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnhapus.Location = New System.Drawing.Point(38, 241)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(265, 23)
        Me.btnhapus.TabIndex = 30
        Me.btnhapus.Text = "hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'txttglsurat
        '
        Me.txttglsurat.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txttglsurat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttglsurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttglsurat.ForeColor = System.Drawing.Color.Gray
        Me.txttglsurat.Location = New System.Drawing.Point(162, 145)
        Me.txttglsurat.Name = "txttglsurat"
        Me.txttglsurat.Size = New System.Drawing.Size(90, 19)
        Me.txttglsurat.TabIndex = 31
        Me.txttglsurat.Text = "30/12/20"
        '
        'txtfile
        '
        Me.txtfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtfile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfile.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtfile.Location = New System.Drawing.Point(82, 15)
        Me.txtfile.Name = "txtfile"
        Me.txtfile.Size = New System.Drawing.Size(201, 19)
        Me.txtfile.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Pilih File"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfile)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 49)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(47, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Ket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(47, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "No.surat"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(320, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 78)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "cencel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Controls.Add(Me.txtcari)
        Me.GroupBox3.Controls.Add(Me.cbocari)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 170)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(47, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tanggal Surat"
        '
        'formterima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 454)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnosurat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txttglsurat)
        Me.Controls.Add(Me.lblno)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnhapus)
        Me.Name = "formterima"
        Me.Text = "Terima Dan Simpan Data"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnosurat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents cbocari As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents txttglsurat As System.Windows.Forms.TextBox
    Friend WithEvents txtfile As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
