Imports System.Data.OleDb
Public Class frmlogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            koneksi()
            cmd = New OleDbCommand("select * from login where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", con)
            rd = cmd.ExecuteReader
            If (rd.HasRows = False) Then
                rd.Close()
                con.Close()
                MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            rd.Close()
            con.Close()
            frmmenu.Show()
        Catch ex As Exception
            'MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmlogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.MaximizeBox = False
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Text = "FORM LOGIN"
        Label1.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
End Class