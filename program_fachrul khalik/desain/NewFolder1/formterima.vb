Imports System.Data.OleDb
Public Class formterima
    Sub TampilData()
        
        Using koneksi As New OleDbConnection(database)
            Using cmd As New OleDbCommand("select * from tblterima", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(rc4(Data("nosurat"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(rc4(Data("tglsurat"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(rc4(Data("namakan"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(Data("tglditerima"))
                        ListView1.Items(x).SubItems.Add(rc4(Data("lampiranterima"), Form1.lbluser.Text))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub
    Sub bersihdata()
        txtnosurat.Clear()
        txtnama.Clear()
        txtfile.Clear()
        txttglsurat.Text = "30/12/20"
        txttglsurat.ForeColor = Color.Gray
        Me.AxAcroPDF1.src = ""
    End Sub
    'Sub lihat()
    '    'Kill("d:\dm\tes\*.*")

    '    lblno.Text = "123456789012"
    '    Dim filein, filename As String
    '    Dim file As System.IO.FileStream        
    '    file = System.IO.File.Create("D:\dm\dek\" & lblno.Text & ".pdf")
    '    filename = ("D:\dm\dek\" & lblno.Text & ".pdf")
    '    file.Close()

    '    FileOpen(1, txtfile.Text, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
    '    filein = Space(LOF(1))
    '    FileGet(1, filein)
    '    FileClose(1)

    '    Dim key As String
    '    key = rc4(Form1.lbluser.Text, Form1.lbluser.Text)
    '    FileOpen(1, filename, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
    '    FilePut(1, rc4(filein, key))
    '    FileClose(1)
    '    Me.AxAcroPDF1().src = filename
    'End Sub

    Sub lihat()
        'Kill("d:\dm\dek\*.*")
        'lblno.Text = "123456789012"
        'Dim filein, filename As String
        'Dim file As System.IO.FileStream
        'file = System.IO.File.Create("D:\dm\dek" & lblno.Text & ".pdf")
        'filename = ("D:\dm\dek" & lblno.Text & ".pdf")
        'file.Close()

        'FileOpen(1, txtfile.Text, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        'filein = Space(LOF(1))
        'FileGet(1, filein)
        'FileClose(1)

        Dim key As String
        key = rc4("dethe", "dethe")
        'FileOpen(1, filename, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        'FilePut(1, rc4(filein, key))
        FileClose(1)
        'MsgBox("crypted")
        'Me.AxAcroPDF1().src = filename
    End Sub

    Sub urutan()
        Dim acak As String
        acak = (Format(Now, "dd")) + (Format(Now, "MM")) + (Format(Now, "yy")) + (Format(Now, "HH")) + (Format(Now, "mm")) + (Format(Now, "ss"))
        '  lblno.Text = acak
    End Sub
    Sub simpan()

        If txtnosurat.Text = "" Or txtnama.Text = "" Then
            MsgBox("Data Belum Lengkap")
        Else
            Try
                Using koneksi As New OleDbConnection(database)
                    Using Cmd As New OleDbCommand("insert into tblterima values('" & _
                                                  rc4(txtnosurat.Text, Form1.lbluser.Text) & "','" & _
                                                  rc4(txtnama.Text, Form1.lbluser.Text) & "','" & _
                                                  rc4(txttglsurat.Text, Form1.lbluser.Text) & "','" & _
                                                  Format(Now, "dd/MM/yy") & "','" & _
                                                 rc4("D:\dm\" & lblno.Text & ".pdf", Form1.lbluser.Text) & "')", koneksi)
                        koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()

                        MsgBox("Data Berhasil Disimpan")



                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

            Call TampilData()
            Call bersihdata()

        End If

    End Sub
    Sub ubah()
        
        If txtnama.Text = "" Or txtnosurat.Text = "" Or txttglsurat.Text = "" Then
            MsgBox("Data Belum Dipilih dari Listview")
        Else
            Try
                Using Koneksi As New OleDbConnection(database)
                    Using Cmd As New OleDbCommand("update tblterima set nosurat='" & rc4(txtnosurat.Text, Form1.lbluser.Text) & _
                                                                          "',namakan='" & rc4(txtnama.Text, Form1.lbluser.Text) & _
                                                                          "',tglsurat='" & rc4(txttglsurat.Text, Form1.lbluser.Text) & _
                                                                         "' where lampiranterima='" & rc4(txtfile.Text, Form1.lbluser.Text) & "'", Koneksi)
                        Koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()

                    End Using
                End Using
                MsgBox("Perubahan Data Berhasil")

                Call TampilData()
                Call bersihdata()

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

        End If

    End Sub
    Sub hapus()
        
        If txtnama.Text = "" Or txtnosurat.Text = "" Or txttglsurat.Text = "" Then
            MsgBox("Data Belum Dipilih dari Listview")
        Else
            Dim konfirmasi As String
            konfirmasi = MsgBox("Anda Yakin Ingin Menghapus Data dengan no " & txtnosurat.Text & " ...?", vbYesNo, "Konfirmasi")
            If konfirmasi = vbYes Then
                Try
                    Using Koneksi As New OleDbConnection(database)
                        Using Cmd As New OleDbCommand("delete * from tblterima where nosurat='" & rc4(txtnosurat.Text, Form1.lbluser.Text) & "'", Koneksi)
                            Koneksi.Open()
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    Kill("" & txtfile.Text & "")
                    Call TampilData()

                    Call bersihdata()
                    MsgBox("data berhasil dihapus")
                Catch ex As Exception
                    MsgBox(ex.Message())
                End Try

            Else
                bersihdata()

            End If


        End If

    End Sub
    Sub copy()
        Dim FileToCopy As String
        Dim NewCopy As String

        FileToCopy = txtfile.Text
        NewCopy = "D:\dm\" & lblno.Text & ".pdf"


        System.IO.File.Copy(FileToCopy, NewCopy)
    End Sub


    Private Sub formterima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call TampilData()
        'Call urutan()
        lihat()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call copy()
        Call simpan()
        Call urutan()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim openf As New OpenFileDialog
        If openf.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtfile.Text = openf.FileName
        Else : Exit Sub

        End If
        Call lihat()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        txtnosurat.Text = ListView1.SelectedItems(0).Text.ToString
        txttglsurat.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        txtnama.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        txtfile.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString
        txttglsurat.ForeColor = Color.LightGray
        Call lihat()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        
        Using koneksi As New OleDbConnection(database)
            Dim a As String
            If cbocari.Text = "tanggal surat" Then
                a = "tglsurat"
            ElseIf cbocari.Text = "tanggal terima" Then
                a = "tglditerima"
            ElseIf cbocari.Text = "ket nama" Then
                a = "namakan"
            Else : a = "nosurat"
            End If
            Dim s As String
            s = rc4(txtcari.Text, Form1.lbluser.Text)
            Using cmd As New OleDbCommand("select * from tblterima where " & a & " like '%" & s & "%'", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(rc4(Data("nosurat"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(rc4(Data("tglsurat"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(rc4(Data("namakan"), Form1.lbluser.Text))
                        ListView1.Items(x).SubItems.Add(Data("tglditerima"))
                        ListView1.Items(x).SubItems.Add(rc4(Data("lampiranterima"), Form1.lbluser.Text))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub txttglsurat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttglsurat.Click
        txttglsurat.Text = ""
        txttglsurat.ForeColor = Color.LightGray
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call ubah()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Call hapus()
    End Sub

    
End Class