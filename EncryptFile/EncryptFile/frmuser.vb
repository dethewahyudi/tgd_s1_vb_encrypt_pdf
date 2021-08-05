Imports System.Data.OleDb
Public Class frmuser

    Private Sub frmuser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        awal()
    End Sub

    Public Sub awal()
        txtinitial.Text = frmlogin.TextBox1.Text
        txtsandi.Text = frmlogin.TextBox2.Text
        txtsandi.PasswordChar = ""
        txtsandinew.Text = ""
        txtsandinew2.Text = ""

        txtinitial.ReadOnly = True
        txtsandi.ReadOnly = True
        txtsandinew.ReadOnly = True
        txtsandinew2.ReadOnly = True

        btnsimpan.Visible = False
        btncancel.Visible = False
        btnubah.Visible = True
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        txtinitial.ReadOnly = False
        txtsandi.ReadOnly = True
        txtsandinew.ReadOnly = False
        txtsandinew2.ReadOnly = False

        btnsimpan.Visible = True
        btncancel.Visible = True
        btnubah.Visible = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancel.Click
        awal()
    End Sub

    Private Sub passshow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles passshow.CheckedChanged
        If passshow.Checked = False Then
            txtsandinew.PasswordChar = "*"
            txtsandinew2.PasswordChar = "*"
        Else
            txtsandinew.PasswordChar = ""
            txtsandinew2.PasswordChar = ""
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Try
            If Not txtsandinew.Text = txtsandinew2.Text Then
                MsgBox("Ulang Password tidak sesuai", MsgBoxStyle.Critical, "Gagal simpan")
                Exit Sub
            End If
            koneksi()
            cmd = New OleDbCommand("update login set `username`='" & txtinitial.Text & "', `password`='" & txtsandinew.Text & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Berhasil di simpan", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class