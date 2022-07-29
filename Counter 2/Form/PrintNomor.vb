Imports System.IO
Imports System.Collections

Public Class PrintNomor
    Public Shared delayTombol As Integer = 3
    Public Shared SisaNomor As String
    Public Shared NomorAntri As String
    Public Shared LayananNomor As String
    Public Shared LayananService As String
    Public Shared NamaLayanan() As String

    Private Sub btnPrintA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintA.Click
        If Client.IsConnect Then
            Client.SendRequestMessage(Client.SendData, "RequesNumber", Client.CounterName, 1, Client.Counter, LoginConfig.User, "")
        End If
    End Sub
    Public Shadows SkinThm As String = Path.GetDirectoryName(Application.ExecutablePath) & "\Themes.ssk"
    Private Sub PrintNomor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbNomor.Text = "- ---"
        lbNomor.Font = New Font("Digital-7 Mono", 40)
    End Sub
    Private Sub btnPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintB.Click
        If Client.IsConnect Then
            Client.SendRequestMessage(Client.SendData, "RequesNumber", Client.CounterName, 2, Client.Counter, LoginConfig.User, "")

        End If
    End Sub
    Private Sub btnPrintC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintC.Click
        If Client.IsConnect Then
            Client.SendRequestMessage(Client.SendData, "RequesNumber", Client.CounterName, 3, Client.Counter, LoginConfig.User, "")
        End If
    End Sub
    Private Sub btnPrintD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintD.Click
        If Client.IsConnect Then
            Client.SendRequestMessage(Client.SendData, "RequesNumber", Client.CounterName, 4, Client.Counter, LoginConfig.User, "")
        End If
    End Sub
    Private Sub btnPrintE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintE.Click
        If Client.IsConnect Then
            Client.SendRequestMessage(Client.SendData, "RequesNumber", Client.CounterName, 5, Client.Counter, LoginConfig.User, "")
        End If
    End Sub
    Private Sub btnPrintF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintF.Click
        If Client.IsConnect Then
            Client.SendRequestMessage(Client.SendData, "RequesNumber", Client.CounterName, 6, Client.Counter, LoginConfig.User, "")
        End If
    End Sub
    Public Shared Function CommandPrint(ByVal ly As Integer, ByVal nomor As Integer, ByVal sis As Integer) As String
        SisaNomor = sis.ToString() & " Nomor"
        LayananNomor = Convert.ToChar(CInt(&H40 + ly)).ToString() & " "
        'LayananService = NamaLayanan(ly - 1)
        NomorAntri = String.Format("{0:000}", nomor)
        Return SisaNomor
    End Function
End Class
