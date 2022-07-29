Imports System.Drawing.Printing
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.IO.Ports
Imports GsmComm.GsmCommunication

Public Class SettingPrinter
    Private portName As String
    Private baudRate As Integer
    Private timeout As Integer
    Public Shared RegrisName As String = "DleuxAntrian"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'Me.Icon = My.Resources.printer_1
        'Try
        '    'Display all available COM Ports"
        '    Dim ports() As String = SerialPort.GetPortNames()

        '    ' Add all port names to the combo box:
        '    For Each port As String In ports
        '        cboPort.Items.Add(port)
        '    Next port
        '    '			
        '    'Remove tab pages
        '    'Me.btnDisconnect.Enabled = False
        'Catch ex As Exception
        '    ErrorLog(ex.Message)
        'End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub SettingPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strPath As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Tikets"
        Dim dirInfo As New IO.DirectoryInfo(strPath)
        For Each file As FileInfo In dirInfo.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
            ComboBox1.Items.Add(file.Name)
        Next
        Try
            ComboBox1.Text = Interaction.GetSetting("AntServer", RegrisName, "UseTiket")
            ' txtIP.Text = Interaction.GetSetting("AntServer", RegrisName, "IPServer")
            numDelay.Value = CInt(Interaction.GetSetting("AntServer", RegrisName, "DelayPrint"))
            nudPrint.Value = CInt(Interaction.GetSetting("AntServer", RegrisName, "CopyPrint"))
            nudHours1.Value = CInt(Interaction.GetSetting("AntServer", RegrisName, "PelayananHours"))
            nudMinute1.Value = CInt(Interaction.GetSetting("AntServer", RegrisName, "PelayananMinute"))
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnSettingPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingPrinter.Click
        Dim pd As New PrintDialog()
        pd.PrinterSettings = New PrinterSettings()
        If DialogResult.OK = pd.ShowDialog() Then
            Tiket.PrintName = pd.PrinterSettings.PrinterName
            Interaction.SaveSetting("AntServer", RegrisName, "Printername", Tiket.PrintName)
        End If
    End Sub

    Private Sub btnSubmite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmite.Click
        If (nudPrint.Value.ToString <> "") AndAlso (numDelay.Value.ToString <> "") AndAlso (ComboBox1.Text.Trim <> "") Then
            Try
                Interaction.SaveSetting("AntServer", RegrisName, "CopyPrint", nudPrint.Value.ToString)
                Interaction.SaveSetting("AntServer", RegrisName, "DelayPrint", numDelay.Value.ToString)
                Interaction.SaveSetting("AntServer", RegrisName, "UseTiket", ComboBox1.Text.Trim)
                'Interaction.SaveSetting("AntServer", RegrisName, "IPServer", txtIP.Text)
                'Interaction.SaveSetting("AntServer", RegrisName, "PelayananHours", nudHours1.Value)
                'Interaction.SaveSetting("AntServer", RegrisName, "PelayananMinute", nudMinute1.Value)
                Me.DialogResult = DialogResult.OK
            Catch ex As Exception

            End Try

        Else
            MessageBox.Show("Isi Data Dengan Lengkap", "Info")
        End If

    End Sub

    Private Sub txtIP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIP.LostFocus
        Dim rx As New Regex("^(?:(?:25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)(?(?=\.?\d)\.)){4}$")
        If Not rx.IsMatch(txtIP.Text) Then
            txtIP.SelectAll()
            MessageBox.Show("Format IP tidak sesuai, contoh IP 192.168.88.99", "Information")
        End If
    End Sub

End Class