Imports System.ComponentModel
Imports System.Text
Imports System.IO
Imports System.IO.Ports
Partial Public Class Config
    Inherits Form
    Private ra As New RegAcces()
    Public Shared RegrisName As String = "DleuxAntrian"
    Public Sub New()
        ' Me.Icon = My.Resources.Logo
        InitializeComponent()
    End Sub

    Private Sub Config_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim PortName() As String = SerialPort.GetPortNames()
        Dim index As Integer = 0
        For Each c As String In PortName
            cbSerialPort.Items.Insert(index, c)
            index += 1
        Next c
        If PortName.Length > 0 Then
            If Server.NamaPort <> "" Then
                cbSerialPort.Text = Server.NamaPort
            Else
                cbSerialPort.Text = PortName(0)
            End If
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ra.CreateReg("AntServer", RegrisName, "Port", cbSerialPort.Text.Trim())
        'ra.CreateReg("RuangObat", "rText", tbRT.Text);
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class

