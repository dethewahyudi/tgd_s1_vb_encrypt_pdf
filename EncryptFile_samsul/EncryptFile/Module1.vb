Imports System.Data.OleDb

Module Module1
    Public con As OleDbConnection
    Public cmd As OleDbCommand
    Public adp As OleDbDataAdapter
    Public rd As OleDbDataReader
    Public ds As New DataSet
    Public user, email As String
    Public Perintah, Perintah1, Perintah2, Perintah3 As OleDbCommand
    Public Pembaca, Pembaca1, Pembaca2, Pembaca3 As OleDbDataReader
    Public SQL, SQL1, SQL2, SQL3 As String
    Sub koneksi()
        Try
            Dim database = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/database.accdb;"
            con = New OleDbConnection(database)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
