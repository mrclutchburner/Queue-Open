Public Class SettingRunningText
    Private strFileName As New List(Of String)()
    Private MediaArray() As String
    Private Reg As New RegAcces
    Dim fontDlg As New FontDialog()
    Dim cdlg As New ColorDialog()
    Private Sub MediaPlaylist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RunningText()
    End Sub

#Region "Runningtext"
    Private Sub RunningText()
        'Dim tmpRunningText As String = Interaction.GetSetting("AntServer\Client", "RunningText", "rtex")
        'If tmpLeft <> "" Then
        '    Me.Left = Integer.Parse(tmpLeft)
        'End If
        'If Reg.ReadRegValue("AntServer", "Client", "rText") <> "" Then
        '    Dim rText As String = Reg.ReadRegValue("AntServer", "Client", "rText")
        '    MediaArray = rText.Split(New String() {vbCrLf}, StringSplitOptions.None)
        '    NuSpeed.Value = CDec(Client.PrtextSpeed)
        '    TxtRunning.Lines = MediaArray
        'End If
        If Interaction.GetSetting("AntServer\Client", "RunningText", "rText") <> "" Then
            Dim tmpRunningText As String = Interaction.GetSetting("AntServer\Client", "RunningText", "rText")
            MediaArray = tmpRunningText.Split(New String() {vbCrLf}, StringSplitOptions.None)
            NuSpeed.Value = CDec(Client.PrtextSpeed)
            TxtRunning.Lines = MediaArray
        End If
    End Sub

    Private Sub BtnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFont.Click
        fontDlg.Font = Client.PrtextFont
        fontDlg.ShowColor = False
        fontDlg.ShowApply = True
        fontDlg.ShowEffects = True
        fontDlg.ShowHelp = True
        fontDlg.MaxSize = 16
        fontDlg.MinSize = 2
        If fontDlg.ShowDialog() = DialogResult.OK Then
            Client.PrtextFont = fontDlg.Font
        End If
    End Sub


    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Client.PrtextBrush = New SolidBrush(cdlg.Color)
        End If
    End Sub

    Private Sub BtnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave1.Click
        If CInt(Fix(NuSpeed.Value)) <= 0 Then
            NuSpeed.Value = 1
        End If
        Client.PrtextSpeed = CInt(Fix(NuSpeed.Value))
        Interaction.SaveSetting("AntServer\Client", "RunningText", "Speed", NuSpeed.Value.ToString())
        Interaction.SaveSetting("AntServer\Client", "RunningText", "rText", TxtRunning.Text)
        Interaction.SaveSetting("AntServer\Client", "RunningText", "rtextFont", Client.PconverterFont.ConvertToString(Client.PrtextFont))
        Interaction.SaveSetting("AntServer\Client", "RunningText", "rtextFontColor", Client.PconverterBrush.ConvertToString(New Pen(Client.PrtextBrush).Color))
        ' Reg.CreateReg("AntServer", "Client", "Speed", NuSpeed.Value.ToString())
        ' Reg.CreateReg("AntServer", "Client", "rText", TxtRunning.Text)
        ' Reg.CreateReg("AntServer", "Client", "rtextFont", Client.PconverterFont.ConvertToString(Client.PrtextFont))
        ' Reg.CreateReg("AntServer", "Client", "rtextFontColor", Client.PconverterBrush.ConvertToString(New Pen(Client.PrtextBrush).Color))
        Client.PrunningtextChange = True
    End Sub

    Private Sub BtnCencel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCencel.Click
        Client.PrunningtextChange = False
        Close()
    End Sub
#End Region

    Private Sub SubmiteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmiteBtn.Click
        Me.DialogResult = DialogResult.OK
        Client.PrunningtextChange = True
        Close()
    End Sub

End Class
