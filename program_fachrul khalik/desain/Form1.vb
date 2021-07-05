Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices

Public Class Form1
    Private corentbtn As IconButton
    Private leftbutton As Panel
    Private curentchilform As Form


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftbutton = New Panel()
        leftbutton.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftbutton)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    Private Sub activebutton(ByVal senderbtn As Object, ByVal customcolor As Color)
        If senderbtn IsNot Nothing Then

            disablebutton()


            corentbtn = CType(senderbtn, IconButton)
            corentbtn.BackColor = Color.FromArgb(37, 36, 83)
            corentbtn.ForeColor = customcolor
            corentbtn.IconColor = customcolor
            corentbtn.TextAlign = ContentAlignment.MiddleCenter
            corentbtn.ImageAlign = ContentAlignment.MiddleRight
            corentbtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftbutton.BackColor = customcolor
            leftbutton.Location = New Point(0, corentbtn.Location.Y)
            leftbutton.Visible = True
            leftbutton.BringToFront()

            icntitle.IconChar = corentbtn.IconChar
            icntitle.IconColor = customcolor

        End If
    End Sub
    Private Sub disablebutton()
        If corentbtn IsNot Nothing Then
            corentbtn.BackColor = Color.FromArgb(31, 30, 68)
            corentbtn.ForeColor = Color.Gainsboro
            corentbtn.IconColor = Color.Gainsboro
            corentbtn.TextAlign = ContentAlignment.MiddleLeft
            corentbtn.ImageAlign = ContentAlignment.MiddleLeft
            corentbtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If

    End Sub
    Private Sub openchildform(ByVal childForm As Form)
        If curentchilform IsNot Nothing Then
            curentchilform.Close()

        End If
        curentchilform = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Paneldekstop.Controls.Add(childForm)
        Paneldekstop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lbltitle.Text = childForm.Text
    End Sub

    Private Sub btntulis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntulis.Click
        activebutton(sender, rgbcolor.color1)
        openchildform(New Formkirim)
    End Sub

    Private Sub btninbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninbox.Click
        activebutton(sender, rgbcolor.color2)
        openchildform(New formterima)
    End Sub

    Private Sub btnendes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        activebutton(sender, rgbcolor.color3)
        openchildform(New formendes)
    End Sub

    Private Sub btnpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpass.Click
        activebutton(sender, rgbcolor.color4)
        openchildform(New Formuser)
    End Sub

    

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If curentchilform IsNot Nothing Then
            curentchilform.Close()

        End If
        reset()

    End Sub
    Private Sub reset()
        disablebutton()
        leftbutton.Visible = False
        icntitle.IconChar = IconChar.Home
        icntitle.IconColor = Color.MediumPurple
        lbltitle.Text = "Home"
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub IconButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconButton1.Click
        Application.Exit()
    End Sub

    Private Sub IconButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconButton2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            IconButton2.IconChar = IconChar.WindowRestore

        Else
            WindowState = FormWindowState.Normal
            IconButton2.IconChar = IconChar.WindowMaximize


        End If
    End Sub

    Private Sub IconButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconButton3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IconButton1.IconChar = IconChar.WindowClose

    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.None
        End If
    End Sub
    
    Private Sub IconButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconButton5.Click
        Application.Exit()
    End Sub
End Class