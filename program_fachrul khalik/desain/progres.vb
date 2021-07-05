Imports System.Data.OleDb
Public Class progres
    Sub nmnisial()
        Using koneksi As New OleDbConnection(database)
            Using cmd As New OleDbCommand("select * from tbluser where namauser='" & login.txtuser.Text & "'", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    While Data.Read
                        txtuser.Text = "fahrul"
                        Form1.lbluser.Text = txtuser.Text
                        Form1.lblinisial2.Text = txtuser.Text
                        Form1.lblemail.Text = Data("namauser")

                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub progres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call nmnisial()
        Me.FormBorderStyle = 0

        Dim p As New Drawing2D.GraphicsPath()
        Dim Pojok As Integer

        Pojok = 250

        p.AddLine(0, 0, Me.Width - Pojok, 0)
        p.AddArc(New Rectangle(Me.Width - Pojok, 0, Pojok, Pojok), -90, 90)
        p.AddLine(Me.Width, Pojok, Me.Width, Me.Height)
        p.AddLine(Me.Width - Pojok, Me.Height, Pojok, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - Pojok, Pojok, Pojok), 90, 90)

        Me.Region = New Region(p)

        Dim n As New Drawing2D.GraphicsPath()
        n.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Region = New Region(n)

        Timer1.Start()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Close()
            'login.Close()

        End If
        'perintah untuk membuat loading info
        If ProgressBar1.Value = 20 Then
            Label4.ForeColor = Color.Aqua
            Label4.Text = "Mempersiapkan Data Pertama"
        ElseIf ProgressBar1.Value = 40 Then
            Label4.ForeColor = Color.CadetBlue
            Label4.Text = "Mempersiapkan Data Kedua"
        ElseIf ProgressBar1.Value = 50 Then
            Label4.ForeColor = Color.Green
            Label4.Text = "Mempersiapkan Data Ketiga"
        ElseIf ProgressBar1.Value = 60 Then
            Label4.ForeColor = Color.Gold
            Label4.Text = "Mempersiapkan Data Keempat"
        ElseIf ProgressBar1.Value = 70 Then
            Label4.ForeColor = Color.Red
            Label4.Text = "Mempersiapkan Data Kelima"
        ElseIf ProgressBar1.Value = 80 Then
            Label4.ForeColor = Color.Orange
            Label4.Text = "Mempersiapkan Data Ketujuh"
        ElseIf ProgressBar1.Value = 90 Then
            Label4.ForeColor = Color.Red
            Label4.Text = "Mempersiapkan Data Kedelapan"
        ElseIf ProgressBar1.Value = 100 Then
            Label4.ForeColor = Color.Maroon
            Label4.Text = "Mempersiapkan Data Kesembilan"
        End If
        Label5.Text = Math.Round((ProgressBar1.Value / 100) * 100, 2) & "%"
    End Sub

End Class