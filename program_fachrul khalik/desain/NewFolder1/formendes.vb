Imports System.Data.OleDb
Public Class formendes
    Sub simpan()
        If txtemail.Text = "" Or txtinisial.Text = "" Or txtpass.Text = "" Or txtulangpass.Text = "" Then
            MsgBox("Data Belum Lengkap")
        ElseIf txtpass.Text = txtulangpass.Text Then
            Try
                Using koneksi As New OleDbConnection(database)
                    Using Cmd As New OleDbCommand("insert into tbluser values('" & txtinisial.Text & "','" & _
                                                  txtemail.Text & "','" & _
                                                   txtpass.Text & "')", koneksi)
                        koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()

                        MsgBox("Data Berhasil Disimpan")



                    End Using
                End Using
                Me.Hide()
                txtemail.Text = ""
                txtinisial.Text = ""
                txtpass.Text = ""
                txtulangpass.Text = ""
                login.Show()
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        Else : MsgBox("password tidak sama")



        End If

    End Sub
    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Call simpan()
        
    End Sub

    Private Sub formendes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpass.UseSystemPasswordChar = True
        txtulangpass.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpass.UseSystemPasswordChar = False
            txtulangpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
            txtulangpass.UseSystemPasswordChar = True
        End If
    End Sub

    
End Class