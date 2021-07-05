Imports System.Text
Imports System.Data.OleDb
Module Module1
    Public Cn As New OleDbConnection
    Public objCommand As OleDb.OleDbCommand
    Public reader As OleDbDataReader
    Public database As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbmutasi.accdb"

    Public Cetak As String
    Public NmUser As String
    Public STRPTCR As String
    Public strSQL As String
    Public conect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbmutasi.accdb")
    Public Function open() As OleDb.OleDbConnection
        Dim conect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbmutasi.accdb")
        conect.Open()
        Return conect
    End Function

    Sub BukaKoneksi()
        Cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & _
        Application.StartupPath & "\dbmutasi.accdb"
        Cn.Open()

    End Sub
    
    Public Function rc4(ByVal psn As String, ByVal katakunci As String) As String

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim hasil As New StringBuilder
        Dim hasilchiper As String = String.Empty

        Dim sbox As Integer() = New Integer(256) {}
        Dim kunci As Integer() = New Integer(256) {}

        Dim intpanjang As Integer = katakunci.Length

        Dim a As Integer = 0
        While a <= 255
            Dim ctmp As Char = (katakunci.Substring((a Mod intpanjang), 1).ToCharArray()(0))

            kunci(a) = Microsoft.VisualBasic.Strings.Asc(ctmp)
            sbox(a) = a
            System.Math.Max(System.Threading.Interlocked.Increment(a), a - 1)


        End While
        Dim x As Integer = 0
        Dim b As Integer = 0
        While b <= 255
            x = (x + sbox(b) + kunci(b)) Mod 256
            Dim tempswap As Integer = sbox(b)
            sbox(b) = sbox(x)
            sbox(x) = tempswap
            System.Math.Max(System.Threading.Interlocked.Increment(b), b - 1)

        End While
        a = 1
        While a <= psn.Length
            Dim itmp As Integer = 0
            i = (i + 1) Mod 256
            j = (j + sbox(i)) Mod 256
            itmp = sbox(i)
            sbox(i) = sbox(j)
            sbox(j) = itmp

            Dim k As Integer = sbox((sbox(i) + sbox(j)) Mod 256)
            Dim ctmp As Char = psn.Substring(a - 1, 1).ToCharArray()(0)
            itmp = Asc(ctmp)
            Dim chiperdgn As Integer = itmp Xor k
            hasil.Append(Chr(chiperdgn))
            System.Math.Max(System.Threading.Interlocked.Increment(a), a - 1)

        End While
        hasilchiper = hasil.ToString
        hasil.Length = 0
        Return hasilchiper
    End Function
End Module

