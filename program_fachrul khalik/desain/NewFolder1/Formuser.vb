Imports System.Text
Imports System.Data.OleDb
Public Class Formuser
    
    Sub TampilData()
        Using koneksi As New OleDbConnection(database)
            Using cmd As New OleDbCommand("select * from tbluser ", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    While Data.Read
                        txtinisial.Text = Data("inisialuser")
                        txtemail.Text = Data("namauser")
                        txtpass.Text = Data("katasandi")
                        txtulangpass.Text = Data("katasandi")
                    End While
                End Using
            End Using
        End Using
        txtpass.UseSystemPasswordChar = True
        txtulangpass.UseSystemPasswordChar = True
    End Sub
    Sub kunci()
        txtinisial.Enabled = False
        txtemail.Enabled = False
        txtpass.Enabled = False
        txtulangpass.Enabled = False

        btnsimpan.Visible = False
        btnbatal.Visible = False
    End Sub
    Sub bukakunci()
        txtinisial.Enabled = True
        txtemail.Enabled = True
        txtpass.Enabled = True
        txtulangpass.Enabled = True

        btnsimpan.Visible = True
        btnbatal.Visible = True
    End Sub
    Sub ubah()
        If txtemail.Text = "" Or txtinisial.Text = "" Or txtpass.Text = "" Or txtulangpass.Text = "" Then
            MsgBox("Data Belum lengkap")
        Else
            Try
                Using Koneksi As New OleDbConnection(database)
                    Using Cmd As New OleDbCommand("update tbluser set namauser ='" & txtemail.Text & _
                                                                          "', katasandi ='" & txtulangpass.Text & _
                                                                         "' where inisialuser ='" & txtinisial.Text & "'", Koneksi)
                        Koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()

                    End Using
                End Using
                MsgBox("Perubahan Data Berhasil")
                Call TampilData()
                Call kunci()
                btnubah.Visible = True

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

        End If

    End Sub

    Private Sub Formuser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
        Call kunci()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpass.UseSystemPasswordChar = False
            txtulangpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
            txtulangpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnubah_Click(sender As System.Object, e As System.EventArgs) Handles btnubah.Click
        btnubah.Visible = False
        Call bukakunci()
    End Sub

    Private Sub btnbatal_Click(sender As System.Object, e As System.EventArgs) Handles btnbatal.Click
        Call kunci()
        btnubah.Visible = True
        Call TampilData()
    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        Call ubah()
        btnubah.Visible = True
    End Sub

    
End Class