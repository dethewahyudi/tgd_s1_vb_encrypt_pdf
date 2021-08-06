Imports System.Data.OleDb

Public Class frmmenu   


    Private Sub btnkirim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkirim.Click
        Label2.Text = "Kirim Data"
        Label2.Visible = True
        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmencrypt
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhome.Click
        Label2.Text = "User"
        Label2.Visible = True

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmUser
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub frmmenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label2.Visible = False
        lblinitial.Text = frmlogin.TextBox4.Text
        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.IsSplitterFixed = True

        lbljdl.Text = "Nama Initial : " & frmlogin.TextBox3.Text

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmhome
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    
    Private Sub btnerima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnerima.Click
        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.IsSplitterFixed = True

        Label2.Text = "Terima Data"
        Label2.Visible = True

        SplitContainer2.Panel2.Controls.Clear()
        Dim frm As New frmdecrypt
        frm.TopLevel = False

        SplitContainer2.Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class