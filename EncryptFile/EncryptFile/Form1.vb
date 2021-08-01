Public Class Form1

   
    Private Sub fileopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileopen.Click
        Try         
            OpenFileDialog1.Filter = "Pdf|*.Pdf"
            OpenFileDialog1.Title = "Browse file *.Pdf"
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog(Me) Then
                If OpenFileDialog1.FileName = "" Then
                    Exit Sub
                End If
                txtbrowse.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
