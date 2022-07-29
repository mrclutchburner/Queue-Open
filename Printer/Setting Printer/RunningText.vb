Public Class RunningText
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
        If Reg.ReadRegValue("AntPrinter", "Printer", "rText") <> "" Then
            Dim rText As String = Reg.ReadRegValue("AntPrinter", "Printer", "rText")
            Dim kntr As String = Reg.ReadRegValue("AntPrinter", "Printer", "KantorCabang")
            MediaArray = rText.Split(New String() {vbCrLf}, StringSplitOptions.None)
            NuSpeed.Value = CDec(MainPrinter.rtextSpeed)
            TxtRunning.Lines = MediaArray
        End If
    End Sub

    Private Sub BtnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFont.Click
        fontDlg.Font = MainPrinter.rtextFont
        fontDlg.ShowColor = False
        fontDlg.ShowApply = True
        fontDlg.ShowEffects = True
        fontDlg.ShowHelp = True
        fontDlg.MaxSize = 72
        fontDlg.MinSize = 12
        If fontDlg.ShowDialog() = DialogResult.OK Then
            MainPrinter.rtextFont = fontDlg.Font
        End If
    End Sub


    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            MainPrinter.rtextBrush = New SolidBrush(cdlg.Color)
        End If
    End Sub

    Private Sub BtnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave1.Click
        If CInt(Fix(NuSpeed.Value)) <= 0 Then
            NuSpeed.Value = 1
        End If
        MainPrinter.rtextSpeed = CInt(Fix(NuSpeed.Value))
        Reg.CreateReg("AntPrinter", "Printer", "Speed", NuSpeed.Value.ToString())
        Reg.CreateReg("AntPrinter", "Printer", "rText", TxtRunning.Text)
        Reg.CreateReg("AntPrinter", "Printer", "rtextFont", MainPrinter.converterFont.ConvertToString(MainPrinter.rtextFont))
        Reg.CreateReg("AntPrinter", "Printer", "rtextFontColor", MainPrinter.converterBrush.ConvertToString(New Pen(MainPrinter.rtextBrush).Color))
        MainPrinter.runningtextChange = True
    End Sub

    Private Sub BtnCencel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCencel.Click
        MainPrinter.runningtextChange = False
        Close()
    End Sub
#End Region

    Private Sub SubmiteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmiteBtn.Click
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub
End Class