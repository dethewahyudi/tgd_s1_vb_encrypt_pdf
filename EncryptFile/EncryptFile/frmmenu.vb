Imports System.Data.OleDb

Public Class frmmenu   

    'Private Sub btngejala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnerima.Click
    '    SplitContainer1.Panel2.Controls.Clear()
    '    Dim frm As New frmgejala
    '    frm.TopLevel = False

    '    SplitContainer1.Panel2.Controls.Add(frm)
    '    frm.Show()
    'End Sub

    'Private Sub btnkerusakan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    SplitContainer1.Panel2.Controls.Clear()
    '    Dim frm As New frmpenyakit
    '    frm.TopLevel = False

    '    SplitContainer1.Panel2.Controls.Add(frm)
    '    frm.Show()
    'End Sub

    'Private Sub btnkonsultasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    SplitContainer1.Panel2.Controls.Clear()
    '    Dim frm As New frmproses
    '    frm.TopLevel = False

    '    SplitContainer1.Panel2.Controls.Add(frm)
    '    frm.Show()
    'End Sub

    'Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
    '    Me.Close()
    '    frmlogin.Show()
    'End Sub

    'Private Sub btnhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkirim.Click
    '    SplitContainer1.Panel2.Controls.Clear()
    '    Dim frm As New frmhome
    '    frm.TopLevel = False

    '    SplitContainer1.Panel2.Controls.Add(frm)
    '    frm.Show()
    'End Sub

    'Private Sub btnbaserule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SplitContainer1.Panel2.Controls.Clear()
    '    Dim frm As New frmbaserule
    '    frm.TopLevel = False

    '    SplitContainer1.Panel2.Controls.Add(frm)
    '    frm.Show()
    'End Sub

    'Private Sub frmmenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    SplitContainer1.Panel2.Controls.Clear()
    '    Dim frm As New frmhome
    '    frm.TopLevel = False

    '    SplitContainer1.Panel2.Controls.Add(frm)
    '    frm.Show()
    'End Sub

    Private Sub btnkirim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkirim.Click
        lbljdl.Text = "Kirim Data"
        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmencrypt
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhome.Click
        lbljdl.Text = "Home"

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmhome
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub frmmenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.IsSplitterFixed = True

        lbljdl.Text = "Home"

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmencrypt
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    
    Private Sub btnerima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnerima.Click
        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.IsSplitterFixed = True

        lbljdl.Text = "Terima Data"

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmdecrypt
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub
End Class