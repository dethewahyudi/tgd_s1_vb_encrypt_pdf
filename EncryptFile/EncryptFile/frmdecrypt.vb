Imports System.IO
Imports System.Security.Cryptography
Imports System.Net.Mail

Public Class frmdecrypt
    Dim strFileToEncrypt As String = ""
    Dim strFileToDecrypt As String = ""
    Dim strOutputEncrypt As String = ""
    Dim strOutputDecrypt As String = ""
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream
    Dim txtPassEncrypt As String = "tgd"
    Dim encrypt As String = "Encrypt"
    Dim decrypt As String = "Dencrypt"
    Dim namafile As String

    Dim txtDestinationEncrypt As String = ""
    Dim txtDestinationDecrypt As String = ""

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        Dim chrData() As Char = strPassword.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte

        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytKey(31) As Byte

        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey
    End Function

    Private Function CreateIV(ByVal strPassword As String) As Byte()

        Dim chrData() As Char = strPassword.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte

        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytIV(15) As Byte

        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV
    End Function

    Private Enum CryptoAction
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub frmdecrypt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.IO.Directory.CreateDirectory(Application.StartupPath & "\" & encrypt)
        System.IO.Directory.CreateDirectory(Application.StartupPath & "\" & decrypt)
        System.IO.Directory.CreateDirectory(Application.StartupPath & "\temp")
        'btnencrypt.Enabled = False
        btndecrypt.Enabled = False
        'txtFileToEncrypt.ReadOnly = True
        'txtFileToEncrypt.Text = "Click Browse to load file."
        txtFileToDecrypt.ReadOnly = True
        txtFileToDecrypt.Text = "Click Browse to load file."

        'ListView1.View = View.Details
        'ListView1.GridLines = True
        'ListView1.Columns.Add("No").Width = 30
        'ListView1.Columns.Add("Penerima").Width = 80
        'ListView1.Columns.Add("Email").Width = 200
        'ListView1.Columns.Add("Terkirim").Width = 80
        'ListView1.FullRowSelect = True
    End Sub

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, _
                                     ByVal strOutputFile As String, _
                                     ByVal bytKey() As Byte, _
                                     ByVal bytIV() As Byte, _
                                     ByVal Direction As CryptoAction)
        Try

            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, _
                                                FileAccess.Write)
            fsOutput.SetLength(0)

            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = fsInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim csCryptoStream As CryptoStream = Nothing

            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateEncryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateDecryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)
            End Select

            While lngBytesProcessed < lngFileLength
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
            End While

            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()

                For Each Dir As String In Directory.GetFiles(Application.StartupPath & "\temp")
                    Dim fileDelete As New FileInfo(Dir)
                    fileDelete.Delete()
                Next

                Dim tempfile As String = Application.StartupPath & "\temp\" & namafile
                My.Computer.FileSystem.CopyFile(txtDestinationDecrypt, Application.StartupPath & "\temp\" & namafile)
                WebBrowser2.Navigate(tempfile & "#toolbar=0&navpanes=0")

            End If

            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then

                'Dim myemail As String = "encrypt@tgd.my.id"
                'Dim mypass As String = "CX[k!?RoIyzp"

                'Dim mail As New MailMessage
                'Dim server As New SmtpClient("mail.tgd.my.id")
                'mail.From = New MailAddress("" & myemail & "")
                'mail.[To].Add("" & txttujuan.Text & "")
                'mail.Subject = Me.Text & " (" & namafile & ")"
                'mail.Body = "Hai, " & txtnama.Text & vbCrLf _
                '                & "  Berikut " & Me.Text.ToLower & " (" & namafile & ")"

                'Dim attac As System.Net.Mail.Attachment
                'attac = New System.Net.Mail.Attachment(txtDestinationEncrypt)
                'mail.Attachments.Add(attac)

                'server.Port = 26
                'server.Credentials = New System.Net.NetworkCredential("" & myemail & "", "" & mypass & "")
                'server.EnableSsl = True
                'server.Send(mail)
                'server.Dispose()

                'txttujuan.Text = ""
                'txtnama.Text = ""
                MsgBox("Berhasil di Encrypt dan terkirim", MsgBoxStyle.Information, "Success")
                'txtFileToEncrypt.Text = "Click Browse to load file."
            Else
                btndecrypt.Enabled = False
                MsgBox("Berhasil di Dencrypt", MsgBoxStyle.Information, "Success")
                'txtFileToDecrypt.Text = "Click Browse to load file."
            End If

        Catch When Err.Number = 53
            MsgBox("Please check to make sure the path and filename" + _
                    "are correct and if the file exists.", _
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt)
                fileDelete.Delete()

                MsgBox("Please check to make sure that you entered the correct" + _
                        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt)
                fileDelete.Delete()

                MsgBox("This file cannot be encrypted.", _
                        MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

    Private Sub fileopen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileopen2.Click
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to decrypt"
        OpenFileDialog.InitialDirectory = Application.StartupPath
        OpenFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt"
        txtDestinationDecrypt = ""
        namafile = ""
        WebBrowser2.Navigate("about:blank")

        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToDecrypt = OpenFileDialog.FileName
            txtFileToDecrypt.Text = strFileToDecrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            While strFileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
            Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
            S = Application.StartupPath & "\" & decrypt
            strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
            namafile = strOutputDecrypt.Replace("_"c, "."c)
            txtDestinationDecrypt = S & "\" & strOutputDecrypt.Replace("_"c, "."c)
            btndecrypt.Enabled = True

        End If
    End Sub

    Private Sub btndecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndecrypt.Click
        
        Dim bytKey As Byte()
        Dim bytIV As Byte()
        If (txtFileToDecrypt.Text = "Click Browse to load file.") Then
            MsgBox("File belum di pilih !", MsgBoxStyle.Critical, "Gagal kirim")
            Exit Sub
        End If
        bytKey = CreateKey(txtPassEncrypt)
        bytIV = CreateIV(txtPassEncrypt)
        EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt, _
                             bytKey, bytIV, CryptoAction.ActionDecrypt)
    End Sub
End Class