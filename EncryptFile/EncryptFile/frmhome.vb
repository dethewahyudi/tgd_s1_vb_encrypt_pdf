Public Class frmhome

    Private Sub frmhome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = "SELAMAT DATANG DI APLIKASI " & vbCrLf &
                            "  PENGAMANAN DATA MUTASI" & vbCrLf &
                            " "
                      
        Label1.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
        Label1.ForeColor = Color.Red
    End Sub
End Class