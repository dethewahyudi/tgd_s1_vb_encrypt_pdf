Imports System.Data.OleDb
Public Class frmlogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            koneksi()
            cmd = New OleDbCommand("select * from login where username='" & TextBox1.Text & "' or email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If (rd.HasRows = False) Then
                rd.Close()
                con.Close()
                MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            TextBox3.Text = rd("username")
            TextBox4.Text = rd("email")
            TextBox5.Text = rd("iduser")
            rd.Close()
            con.Close()
            frmmenu.Show()
        Catch ex As Exception
            'MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmlogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.MaximizeBox = False
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Text = "FORM LOGIN"
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

   
End Class