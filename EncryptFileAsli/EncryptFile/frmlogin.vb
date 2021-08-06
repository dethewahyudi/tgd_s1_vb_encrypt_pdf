Imports System.Data.OleDb
Public Class frmlogin

  

    Private Sub frmlogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.MaximizeBox = False
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Text = "FORM LOGIN"
        Label1.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub btnlogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            koneksi()
            cmd = New OleDbCommand("select * from login where initial='" & txtuser.Text & "' or email='" & txtuser.Text & "' and password='" & txtpass.Text & "'", con)
            rd = cmd.ExecuteReader
            If (rd.HasRows = False) Then
                rd.Close()
                con.Close()
                MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            rd.Read()
            frmmenu.lblinitial.Text = "Initial : " & rd("initial").ToString
            frmmenu.lblemail.Text = "Email : " & rd("email").ToString
            rd.Close()
            con.Close()
            frmmenu.Show()
        Catch ex As Exception
            'MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class