﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmuser
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
        Me.txtsandi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtinitial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtsandinew = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsandinew2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.passshow = New System.Windows.Forms.CheckBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtsandi
        '
        Me.txtsandi.Location = New System.Drawing.Point(234, 161)
        Me.txtsandi.Name = "txtsandi"
        Me.txtsandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsandi.Size = New System.Drawing.Size(237, 20)
        Me.txtsandi.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Password Lama"
        '
        'txtinitial
        '
        Me.txtinitial.Location = New System.Drawing.Point(234, 88)
        Me.txtinitial.Name = "txtinitial"
        Me.txtinitial.Size = New System.Drawing.Size(237, 20)
        Me.txtinitial.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama_Initial"
        '
        'btnsimpan
        '
        Me.btnsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnsimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Location = New System.Drawing.Point(235, 286)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(74, 33)
        Me.btnsimpan.TabIndex = 28
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtsandinew
        '
        Me.txtsandinew.Location = New System.Drawing.Point(235, 198)
        Me.txtsandinew.Name = "txtsandinew"
        Me.txtsandinew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsandinew.Size = New System.Drawing.Size(236, 20)
        Me.txtsandinew.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Password_Baru"
        '
        'txtsandinew2
        '
        Me.txtsandinew2.Location = New System.Drawing.Point(235, 234)
        Me.txtsandinew2.Name = "txtsandinew2"
        Me.txtsandinew2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsandinew2.Size = New System.Drawing.Size(237, 20)
        Me.txtsandinew2.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Ulang_Password"
        '
        'btnubah
        '
        Me.btnubah.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnubah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnubah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Location = New System.Drawing.Point(316, 286)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(74, 33)
        Me.btnubah.TabIndex = 33
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Location = New System.Drawing.Point(398, 286)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(74, 33)
        Me.btncancel.TabIndex = 34
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'passshow
        '
        Me.passshow.AutoSize = True
        Me.passshow.Location = New System.Drawing.Point(477, 201)
        Me.passshow.Name = "passshow"
        Me.passshow.Size = New System.Drawing.Size(53, 17)
        Me.passshow.TabIndex = 35
        Me.passshow.Text = "tampil"
        Me.passshow.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(234, 124)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(237, 20)
        Me.txtemail.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Email"
        '
        'frmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(581, 408)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.passshow)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.txtsandinew2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsandinew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtsandi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtinitial)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmuser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsandi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtinitial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtsandinew As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsandinew2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents passshow As System.Windows.Forms.CheckBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
