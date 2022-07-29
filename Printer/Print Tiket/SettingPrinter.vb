Imports System.Drawing.Printing
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.IO.Ports
Imports GsmComm.GsmCommunication

Public Class SettingPrinter
    Private portName As String
    Private baudRate As Integer
    Private timeout As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Icon = My.Resources.printer_1
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
            ComboBox1.Text = Interaction.GetSetting("AntPrinter", "Printer", "UseTiket")
            txtIP.Text = Interaction.GetSetting("AntPrinter", "Printer", "IPServer")
            numDelay.Value = CInt(Interaction.GetSetting("AntPrinter", "Printer", "DelayPrint"))
            nudPrint.Value = CInt(Interaction.GetSetting("AntPrinter", "Printer", "CopyPrint"))
            nudHours1.Value = CInt(Interaction.GetSetting("AntPrinter", "Printer", "PelayananHours"))
            nudMinute1.Value = CInt(Interaction.GetSetting("AntPrinter", "Printer", "PelayananMinute"))
        Catch ex As Exception

        End Try
       
    End Sub
#Region " SMS GateWay"
    Public Sub ErrorLog(ByVal Message As String)
        Dim sw As StreamWriter = Nothing

        Try
            Dim sLogFormat As String = Date.Now.ToShortDateString().ToString() & " " & Date.Now.ToLongTimeString().ToString() & " ==> "
            'string sPathName = @"E:\"
            Dim sPathName As String = "SMSapplicationErrorLog_"

            Dim sYear As String = Date.Now.Year.ToString()
            Dim sMonth As String = Date.Now.Month.ToString()
            Dim sDay As String = Date.Now.Day.ToString()

            Dim sErrorTime As String = sDay & "-" & sMonth & "-" & sYear

            sw = New StreamWriter(sPathName & sErrorTime & ".txt", True)

            sw.WriteLine(sLogFormat & Message)
            sw.Flush()

        Catch ex As Exception
            'ErrorLog(ex.ToString());
        Finally
            If sw IsNot Nothing Then
                sw.Dispose()
                sw.Close()
            End If
        End Try

    End Sub

    Public Sub SetData(ByVal portName As String, ByVal baudRate As Integer, ByVal timeout As Integer)
        Me.portName = portName
        Me.baudRate = baudRate
        Me.timeout = timeout
    End Sub

    Public Sub GetData(<System.Runtime.InteropServices.Out()> ByRef portName As String, <System.Runtime.InteropServices.Out()> ByRef baudRate As Integer, <System.Runtime.InteropServices.Out()> ByRef timeout As Integer)
        portName = Me.portName
        baudRate = Me.baudRate
        timeout = Me.timeout
    End Sub

    Private Function EnterNewSettings() As Boolean
        'Dim newPortName As String
        'Dim newBaudRate As Integer
        'Dim newTimeout As Integer

        'Try
        '    If cboPort.Text.Length = 0 Then
        '        Throw New FormatException()
        '    End If
        '    newPortName = cboPort.Text
        'Catch e1 As Exception
        '    MessageBox.Show(Me, "Invalid port name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cboPort.Focus()
        '    Return False
        'End Try

        'Try
        '    newBaudRate = Integer.Parse(cboBaudRate.Text)
        'Catch e2 As Exception
        '    MessageBox.Show(Me, "Invalid baud rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cboBaudRate.Focus()
        '    Return False
        'End Try

        'Try
        '    newTimeout = Integer.Parse(cboTimeout.Text)
        'Catch e3 As Exception
        '    MessageBox.Show(Me, "Invalid timeout value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cboTimeout.Focus()
        '    Return False
        'End Try

        'Me.portName = newPortName
        'Me.baudRate = newBaudRate
        'Me.timeout = newTimeout

        'Return True
    End Function

    Private Sub ButttnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not EnterNewSettings() Then
            DialogResult = DialogResult.None
        End If
    End Sub
#End Region
    Private Sub btnSettingPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingPrinter.Click
        Dim pd As New PrintDialog()
        pd.PrinterSettings = New PrinterSettings()
        If DialogResult.OK = pd.ShowDialog() Then
            Tiket.PrintName = pd.PrinterSettings.PrinterName
            Interaction.SaveSetting("AntPrinter", "Printer", "Printername", Tiket.PrintName)
        End If
    End Sub

    Private Sub btnSubmite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmite.Click
        If (txtIP.Text <> "") AndAlso (nudPrint.Value.ToString <> "") AndAlso (numDelay.Value.ToString <> "") AndAlso (ComboBox1.Text.Trim <> "") Then
            Try
                Interaction.SaveSetting("AntPrinter", "Printer", "CopyPrint", nudPrint.Value.ToString)
                Interaction.SaveSetting("AntPrinter", "Printer", "DelayPrint", numDelay.Value.ToString)
                Interaction.SaveSetting("AntPrinter", "Printer", "UseTiket", ComboBox1.Text.Trim)
                Interaction.SaveSetting("AntPrinter", "Printer", "IPServer", txtIP.Text)
                Interaction.SaveSetting("AntPrinter", "Printer", "PelayananHours", nudHours1.Value)
                Interaction.SaveSetting("AntPrinter", "Printer", "PelayananMinute", nudMinute1.Value)
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