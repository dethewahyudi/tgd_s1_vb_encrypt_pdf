Imports System.Data.OleDb
Public Class frmUser


    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TextBox6.Text = frmlogin.TextBox5.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TextBox6.Text = Val(frmlogin.TextBox5.Text + 1)
        SQL = "Insert Into login values (" & _
                    TextBox6.Text & ",'" & _
                    TextBox1.Text & "','" & _
                    TextBox5.Text & "','" & _
                    TextBox2.Text & "')"
        Perintah = New OleDbCommand(SQL, con)
        Dim pesan As MsgBoxResult
        pesan = MsgBox("Simpan data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Informasi")
        If pesan = MsgBoxResult.Yes Then
            SQL3 = "select username from login where username='" & TextBox1.Text & "'"
            Perintah3 = New OleDbCommand(SQL3, con)
            Pembaca3 = Perintah3.ExecuteReader
            If Pembaca3.Read = True Then
                MsgBox("Maaf Kode Sudah Ada")
                Perintah.Cancel()
            Else
                Perintah.ExecuteNonQuery()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = frmlogin.TextBox5.Text
                MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox6.Text = frmlogin.TextBox5.Text
        SQL = "Update login set username='" & TextBox1.Text & _
                        "', password='" & TextBox5.Text & _
                        "', email='" & TextBox2.Text & _
                        "' where iduser=" & Val(TextBox6.Text) & ""
        Perintah = New OleDbCommand(SQL, con)
        Dim pesan As MsgBoxResult
        pesan = MsgBox("Rubah data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Informasi")
        If pesan = MsgBoxResult.Yes Then
            Perintah.ExecuteNonQuery()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            'TextBox6.Text = frmlogin.TextBox5.Text
            MsgBox("Data Berhasil TerUpdate", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class