Imports System.Data.OleDb
Imports System.Net.Mail
Public Class Formkirim
    Sub TampilData()
        Using koneksi As New OleDbConnection(database)
            Using cmd As New OleDbCommand("select * from tblkirim", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(rc4(Data("emailpenerima"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(Data("tglkirim"))
                        ListView1.Items(x).SubItems.Add(rc4(Data("inisialpenerima"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(rc4(Data("lampirankirim"), Form1.lbluser.Text))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub
    Sub simpan()
        
        If txtto.Text = "" Or txtinisial.Text = "" Then
            MsgBox("Data Belum Lengkap")
        Else
            Try

                Using koneksi As New OleDbConnection(database)
                    Using Cmd As New OleDbCommand("insert into tblkirim values('" & _
                                                rc4(txtto.Text, Form1.lbluser.Text) & "','" & _
                                                  Format(Now, "dd/MM/yy") & "','" & _
                                                   rc4(txtinisial.Text, Form1.lbluser.Text) & "','" & _
                                                 rc4("D:\dm\" & lblacak.Text & ".pdf", Form1.lbluser.Text) & "')", koneksi)
                        koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()

                        'MsgBox("Data" & txtto.Text & " Berhasil Disimpan")

                        ' Call bersihdata()

                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

            Call TampilData()

        End If

    End Sub
    Sub simpanfile()
        Dim filein, filename As String
        Dim file As System.IO.FileStream
        file = System.IO.File.Create("D:\dm\" & lblacak.Text & ".pdf")
        filename = ("D:\dm\" & lblacak.Text & ".pdf")
        file.Close()

        FileOpen(1, txtfile.Text, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        filein = Space(LOF(1))
        FileGet(1, filein)
        FileClose(1)

        Dim key As String
        key = rc4(txtinisial.Text, txtinisial.Text)
        FileOpen(1, filename, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        FilePut(1, rc4(filein, key))
        FileClose(1)
        'MsgBox("crypted")



    End Sub
    Sub kirim()
        Try

            Dim myemail As String = Form1.lblemail.Text
            Dim penerima As String = txtto.Text
            Dim mail As New MailMessage
            Dim server As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("" & myemail & "")
            mail.[To].Add("" & penerima & "")
            mail.Subject = "file" & lblacak.Text & ""
            mail.Body = ""

            Dim attac As System.Net.Mail.Attachment
            attac = New System.Net.Mail.Attachment("D:\dm\" & lblacak.Text & ".pdf")
            mail.Attachments.Add(attac)

            server.Port = 587
            server.Credentials = New System.Net.NetworkCredential("" & myemail & "", "" & Formuser.txtpass.Text & "")
            server.EnableSsl = True
            server.Send(mail)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtfile.Text = OpenFileDialog1.FileName
        Me.AxAcroPDF1().src = OpenFileDialog1.FileName
    End Sub


    Private Sub btnkirim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkirim.Click
        ProgressBar1.Value = 1
        Call simpanfile()
        Call kirim()
        Call simpan()
        Call urutan()
        ProgressBar1.Value = 100
        MsgBox("mail berhasil dikirim", MsgBoxStyle.Information, "informasi")
    End Sub

    Sub urutan()
        Dim acak As String
        acak = (Format(Now, "dd")) + (Format(Now, "MM")) + (Format(Now, "yy")) + (Format(Now, "HH")) + (Format(Now, "mm")) + (Format(Now, "ss"))
        lblacak.Text = acak
    End Sub
    Private Sub Formkirim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
        Call Formuser.TampilData()
        Call urutan()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

        txtto.Text = ListView1.SelectedItems(0).Text.ToString
        txtinisial.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        txtfile.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        Call lihat()
    End Sub

   
    
    Sub lihat()
        Kill("d:\dm\dek\*.*")
        Dim filein, filename As String
        Dim file As System.IO.FileStream
        file = System.IO.File.Create("D:\dm\dek" & lblacak.Text & ".pdf")
        filename = ("D:\dm\dek" & lblacak.Text & ".pdf")
        file.Close()

        FileOpen(1, txtfile.Text, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        filein = Space(LOF(1))
        FileGet(1, filein)
        FileClose(1)

        Dim key As String
        key = rc4(txtinisial.Text, txtinisial.Text)
        FileOpen(1, filename, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        FilePut(1, rc4(filein, key))
        FileClose(1)
        'MsgBox("crypted")
        Me.AxAcroPDF1().src = filename
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        Dim key As String
        key = rc4(Form1.lbluser.Text, Form1.lbluser.Text)
        Using koneksi As New OleDbConnection(database)
            Dim a As String
            If cbocari.Text = "tanggal surat" Then
                a = "tglsurat"
            ElseIf cbocari.Text = "email tujuan" Then
                a = "emailpenerima"
            Else : a = "inisialpenerima"
            End If
            Dim s As String
            s = rc4(txtcari.Text, Form1.lbluser.Text)
            Using cmd As New OleDbCommand("select * from tblkirim where " & a & " like '%" & s & "%'", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(rc4(Data("emailpenerima"), key))
                        ListView1.Items(x).SubItems.Add(rc4(Data("tglkirim"), key))
                        ListView1.Items(x).SubItems.Add(rc4(Data("inisialpenerima"), key))
                        ListView1.Items(x).SubItems.Add(rc4(Data("lampirankirim"), key))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    
End Class