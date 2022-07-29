Imports Counters
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports System.IO

Public Class ConfigClient
    '  Dim Reg As New RegAcces
    Private Function Huruf(ByVal _Huruf As Integer) As String
        Return (Convert.ToChar(&H40 + _Huruf).ToString())
    End Function
    Private Sub ConfigClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CCounter, CCounter2, CCounter3 As New CounterComponent()
        Dim tmpNamaPort As String = Interaction.GetSetting("AntServer\Client", "Part", "SerialPort")
        Me.CbPort.Text = tmpNamaPort
        '  Dim Ceck As String = Interaction.GetSetting("AntServer\Client", "Part", "Component")
        'If Ceck <> "" Then
        ' Dim tmp() As String = Ceck.Split(New String() {vbCrLf}, StringSplitOptions.None)
        IpTxt.Text = Client.IPServer
        NameTxt.Text = CCounter.Nama
        NomorTxt.Text = CStr(CCounter.Counter)
        If Client.NamaLayanan IsNot Nothing Then
            CbLayanan.Items.AddRange(Client.NamaLayanan)
        End If
        Dim KoneksiPort() As String = SerialPort.GetPortNames()
        If KoneksiPort.Length > 0 Then
            CbPort.Items.AddRange(KoneksiPort)
        End If
        'End If
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim CCounter, CCounter2, CCounter3 As New CounterComponent()
        If ((Not IpTxt.Text.Equals(""))) AndAlso ((Not NameTxt.Text.Equals(""))) AndAlso ((Not NomorTxt.Text.Equals(""))) Then
            CCounter.IP = "127.0.0.1" 'IpTxt.Text.Trim()
            CCounter.Nama = NameTxt.Text.Trim()
            Try
                If CbLayanan.SelectedIndex >= 0 Then
                    CCounter.Service = CbLayanan.SelectedIndex + 1
                Else
                    CCounter.Service = 1
                End If

            Catch
                CCounter.Service = 1
            End Try
            Client.Layanan = CCounter.Service
            CCounter.Counter = Integer.Parse(NomorTxt.Text)
            Dim KomponenLoket As String = CCounter.IP & vbCrLf & CCounter.Nama & vbCrLf & CCounter.Counter.ToString() & vbCrLf & CCounter.Service.ToString()
            Interaction.SaveSetting("AntServer\Client", "Part", "Component", KomponenLoket)
            If CbPort.Text <> "" Then
                Client.NamaPort = CbPort.Text
            End If
            Interaction.SaveSetting("AntServer\Client", "Part", "SerialPort", Client.NamaPort)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub NameTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NameTxt.KeyPress
        'If Not Client.AllowToEdit Then
        '    e.KeyChar = CChar(ChrW(Keys.None))
        'End If
    End Sub

    Private Sub IpTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IpTxt.KeyPress
        'If Not Client.AllowToEdit Then
        '   e.KeyChar = CChar(ChrW(Keys.None))
        'End If
    End Sub

    Private Sub NomorTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomorTxt.KeyPress
        'Dim tombol As Integer = Asc(e.KeyChar)
        'If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
        '    e.Handled = True
        'End If
        'If Not Client.AllowToEdit Then
        '    Dim tombol As Integer = Asc(e.KeyChar)
        '    If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
        '        e.Handled = True
        '    End If
        'End If
    End Sub
    Private Sub IpTxt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IpTxt.LostFocus
        Dim rx As New Regex("^(?:(?:25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)(?(?=\.?\d)\.)){4}$")
        If Not rx.IsMatch(IpTxt.Text) Then
            IpTxt.SelectAll()
            MessageBox.Show("Format IP tidak sesuai, contoh IP 192.168.88.99", "Information")
        End If
    End Sub

End Class