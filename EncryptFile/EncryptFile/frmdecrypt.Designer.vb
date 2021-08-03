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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btndecrypt
        '
        Me.btndecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btndecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btndecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndecrypt.Location = New System.Drawing.Point(39, 70)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
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
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(405, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(373, 416)
        Me.WebBrowser1.TabIndex = 15
        '
        'frmdecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 584)
        Me.Controls.Add(Me.WebBrowser1)
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

    End Sub
    Friend WithEvents btndecrypt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fileopen2 As System.Windows.Forms.Button
    Friend WithEvents txtFileToDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
