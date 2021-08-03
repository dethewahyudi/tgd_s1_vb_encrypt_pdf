Public Class frmhome

    Private Sub frmhome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = "   Sistem Pakar Untuk Mendiagnosa Penyakit Osteosarcoma" & vbCrLf &
                            "(Tumor TUlang) Menggunakan Metode Theorema Bayes Pada " & vbCrLf &
                            "                           RSUP H.Adam Malik Medan"
                      
        Label1.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
        Label1.ForeColor = Color.Red
    End Sub
End Class