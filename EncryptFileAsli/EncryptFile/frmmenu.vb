Imports System.Data.OleDb

Public Class frmmenu   

    Private Sub btnkirim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkirim.Click

        btnhome.BackColor = Color.Yellow
        btnkirim.BackColor = Color.Orange
        btnerima.BackColor = Color.Yellow
        btnuser.BackColor = Color.Yellow

        lbljdl.Text = "Kirim Data"
        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmencrypt
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhome.Click
        btnhome.BackColor = Color.Orange
        btnkirim.BackColor = Color.Yellow
        btnerima.BackColor = Color.Yellow
        btnuser.BackColor = Color.Yellow

        lbljdl.Text = "Home"

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmhome
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub frmmenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnhome.BackColor = Color.Orange
        btnkirim.BackColor = Color.Yellow
        btnerima.BackColor = Color.Yellow
        btnuser.BackColor = Color.Yellow

        frmencrypt.WebBrowser1.Navigate("about:blank")
        frmdecrypt.WebBrowser2.Navigate("about:blank")

        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.IsSplitterFixed = True

        lbljdl.Text = "Home"

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmhome
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    
    Private Sub btnerima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnerima.Click

        btnhome.BackColor = Color.Yellow
        btnkirim.BackColor = Color.Yellow
        btnerima.BackColor = Color.Orange
        btnuser.BackColor = Color.Yellow

        frmencrypt.WebBrowser1.Navigate("about:blank")
        frmdecrypt.WebBrowser2.Navigate("about:blank")

        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.IsSplitterFixed = True

        lbljdl.Text = "Terima Data"

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmdecrypt
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub btnuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuser.Click
        btnhome.BackColor = Color.Yellow
        btnkirim.BackColor = Color.Yellow
        btnerima.BackColor = Color.Yellow
        btnuser.BackColor = Color.Orange

        frmencrypt.WebBrowser1.Navigate("about:blank")
        frmdecrypt.WebBrowser2.Navigate("about:blank")

        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.IsSplitterFixed = True

        lbljdl.Text = "User"

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmuser
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub
End Class