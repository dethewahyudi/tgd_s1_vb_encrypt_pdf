Imports System.Data.OleDb
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices

Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IconButton1.IconChar = IconChar.WindowClose
        BukaKoneksi()
        txtuser.Text = "dethewahyudi@gmail.com"
        txtpass.Text = "Dethe7foldaa"
    End Sub
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtuser.Text = "admin" And txtuser.Text = "admin" Then
            formendes.Show()
            txtuser.Text = ""
            txtpass.Text = ""
        Else
            Dim sql As String = "Select * from tbluser where namauser='" & txtuser.Text & _
            "' and katasandi='" & txtpass.Text & "'"
            Dim dr As OleDbDataReader = New OleDbCommand(sql, Cn).ExecuteReader
            progres.txtuser.Text = txtuser.Text
            If dr.HasRows Then

                progres.Show()
                'Me.Close()
                Me.Hide()
            Else
                MsgBox("password dan username tidak sesuai", MsgBoxStyle.Critical, "Login gagal")

                txtpass.Text = ""
                txtuser.Focus()
            End If
            dr.Close()
        End If
    End Sub
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Titlebar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Titlebar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub login_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub custemizecomponen()
        txtuser.AutoSize = False
        txtuser.Size = New Size(301, 25)

        txtpass.AutoSize = False
        txtpass.Size = New Size(301, 25)
        txtpass.UseSystemPasswordChar = True
    End Sub
    Private Sub btnlogin_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btnlogin.Paint
        Dim buttonpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myractangle As Rectangle = btnlogin.ClientRectangle
        myractangle.Inflate(0, 30)
        buttonpath.AddEllipse(myractangle)
        btnlogin.Region = New Region(buttonpath)
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        custemizecomponen()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub IconButton1_Click(sender As System.Object, e As System.EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

End Class