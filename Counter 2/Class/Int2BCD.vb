Imports System.Text

Friend Class Int2BCD
    Public Shared Function PS(ByVal val As Integer) As Integer
        Dim a, b As Integer
        a = val Mod 10
        b = (val Mod 100) \ 10
        b = b << 4
        Return (a Or b)
    End Function
    Public Shared Function RR(ByVal val As Integer) As Integer
        Dim a, b As Integer
        a = (val Mod 1000) \ 100
        b = val \ 1000
        b = b << 4
        Return (a Or b)
    End Function
End Class
