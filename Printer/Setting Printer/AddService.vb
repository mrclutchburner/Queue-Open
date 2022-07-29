Imports System.Xml

Public Class AddService
    Dim Reg As New RegAcces
    Private Sub AddService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ServiceName()
    End Sub
    Public Sub ServiceName()
        Dim Cek As String = Reg.ReadSubRegValue("AntPrinter", "Printer", "Tiket", "ServiceName")
        If Cek <> "" Then
            Dim TmpCek() As String = Cek.Split(New String() {vbCrLf}, StringSplitOptions.None)
            txt1.Text = TmpCek(0)
            txt2.Text = TmpCek(1)
            txt3.Text = TmpCek(2)
            txt4.Text = TmpCek(3)
            txt5.Text = TmpCek(4)
            txt6.Text = TmpCek(5)
            txt7.Text = TmpCek(6)
            txt8.Text = TmpCek(7)
            txt9.Text = TmpCek(8)
            txt10.Text = TmpCek(9)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ServiceName As String = txt1.Text & vbCrLf & txt2.Text & vbCrLf & txt3.Text & vbCrLf & txt4.Text & vbCrLf & txt5.Text & vbCrLf & txt6.Text & vbCrLf & txt7.Text & vbCrLf & txt8.Text & vbCrLf & txt9.Text & vbCrLf & txt10.Text
        Reg.CreateSubReg("AntPrinter", "Printer", "Tiket", "ServiceName", ServiceName)
        Close()
    End Sub
End Class