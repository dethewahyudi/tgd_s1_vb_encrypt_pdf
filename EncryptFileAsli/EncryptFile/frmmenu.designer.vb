﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnerima = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnkirim = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lblinitial = New System.Windows.Forms.Label()
        Me.lbljdl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Yellow
        Me.btnkeluar.FlatAppearance.BorderSize = 0
        Me.btnkeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(8, 406)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(181, 35)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "Logout"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btnerima
        '
        Me.btnerima.BackColor = System.Drawing.Color.Yellow
        Me.btnerima.FlatAppearance.BorderSize = 0
        Me.btnerima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnerima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnerima.Location = New System.Drawing.Point(8, 323)
        Me.btnerima.Name = "btnerima"
        Me.btnerima.Size = New System.Drawing.Size(181, 35)
        Me.btnerima.TabIndex = 4
        Me.btnerima.Text = "Terima Data"
        Me.btnerima.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnuser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnhome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnkirim)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnkeluar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnerima)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1137, 613)
        Me.SplitContainer1.SplitterDistance = 198
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 7
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.Color.Yellow
        Me.btnuser.FlatAppearance.BorderSize = 0
        Me.btnuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.Location = New System.Drawing.Point(8, 364)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(181, 35)
        Me.btnuser.TabIndex = 18
        Me.btnuser.Text = "User"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Yellow
        Me.btnhome.FlatAppearance.BorderSize = 0
        Me.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.Location = New System.Drawing.Point(8, 241)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(181, 35)
        Me.btnhome.TabIndex = 17
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnkirim
        '
        Me.btnkirim.BackColor = System.Drawing.Color.Yellow
        Me.btnkirim.FlatAppearance.BorderSize = 0
        Me.btnkirim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnkirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkirim.Location = New System.Drawing.Point(8, 282)
        Me.btnkirim.Name = "btnkirim"
        Me.btnkirim.Size = New System.Drawing.Size(181, 35)
        Me.btnkirim.TabIndex = 7
        Me.btnkirim.Text = "Kirim Data"
        Me.btnkirim.UseVisualStyleBackColor = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblemail)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblinitial)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbljdl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer2.Size = New System.Drawing.Size(938, 613)
        Me.SplitContainer2.SplitterDistance = 80
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 0
        '
        'lblinitial
        '
        Me.lblinitial.AutoSize = True
        Me.lblinitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinitial.ForeColor = System.Drawing.Color.White
        Me.lblinitial.Location = New System.Drawing.Point(500, 7)
        Me.lblinitial.Name = "lblinitial"
        Me.lblinitial.Size = New System.Drawing.Size(101, 31)
        Me.lblinitial.TabIndex = 1
        Me.lblinitial.Text = "Label2"
        '
        'lbljdl
        '
        Me.lbljdl.AutoSize = True
        Me.lbljdl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljdl.ForeColor = System.Drawing.Color.White
        Me.lbljdl.Location = New System.Drawing.Point(16, 23)
        Me.lbljdl.Name = "lbljdl"
        Me.lbljdl.Size = New System.Drawing.Size(101, 31)
        Me.lbljdl.TabIndex = 0
        Me.lbljdl.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 40)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Aplikasi Pengamanan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Mutasi PT.SSSS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.White
        Me.lblemail.Location = New System.Drawing.Point(500, 38)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(83, 26)
        Me.lblemail.TabIndex = 2
        Me.lblemail.Text = "Label2"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 613)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU UTAMA"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnerima As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnkirim As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbljdl As System.Windows.Forms.Label
    Friend WithEvents lblinitial As System.Windows.Forms.Label
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
End Class
