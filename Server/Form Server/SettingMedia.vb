Public Class SettingMedia
    Private FileName As New List(Of String)()
    Private MediaArray() As String
    Private Reg As New RegAcces()
    Public Shared RegrisName As String = "DleuxAntrian"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SettingMedia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If ra.ReadRegValue("AntServer", RegrisName, "MediaFile") <> "" Then
        '    Dim rText As String = ra.ReadRegValue("AntServer", RegrisName, "MediaFile")
        '    MediaArray = rText.Split(New String() {vbCrLf}, StringSplitOptions.None)
        '    MediaList.Items.AddRange(MediaArray)
        '    FileName.Clear()
        '    FileName = MediaArray.ToList()
        'End If
        'TrkVolume.Value = Server.VideoVolume
        MediaPlaylist()
        If Reg.ReadRegValue("AntServer", RegrisName, "rText") <> "" Then
            Dim rText As String = Reg.ReadRegValue("AntServer", RegrisName, "rText")
            MediaArray = rText.Split(New String() {vbCrLf}, StringSplitOptions.None)
            'strFileName = mediaArray.ToList();
            NuSpeed.Value = CDec(Server.RtextSpeed)
            TxtRunning.Lines = MediaArray
        End If
        numImage.Text = Server.imgTime.ToString
    End Sub

#Region "PlayList Media"
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim tmpMedia As String = ""

        Server.MediaFile.Clear()
        For x As Integer = 0 To MediaList.Items.Count - 1
            FileName.Add(MediaList.Items(x).ToString())
            tmpMedia &= MediaList.Items(x).ToString()
            If x < MediaList.Items.Count - 1 Then
                tmpMedia &= vbCrLf
            End If
        Next x
        Reg.CreateReg("AntServer", RegrisName, "MediaFile", tmpMedia)
        If CbDevice.Text <> "" Then
            Reg.CreateReg("AntServer", RegrisName, "selectedDevice", Server.SelectedDevice.ToString())
        Else
            Server.SelectedDevice = 100
            Reg.CreateReg("AntServer", RegrisName, "selectedDevice", Server.SelectedDevice.ToString())
        End If
        If CbInput.Text <> "" Then
            Reg.CreateReg("AntServer", RegrisName, "selectedInput", Server.SelectedInput.ToString())
        Else
            Reg.CreateReg("AntServer", RegrisName, "selectedInput", "0")
        End If
        Server.VideoChange = True
        'Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub TrkVolume_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrkVolume.Scroll
        Server.VideoVolume = TrkVolume.Value
        Reg.CreateReg("AntServer", RegrisName, "Volume", Server.VideoVolume.ToString())
        Server.VolumeChange = True
        AccessForm.SetVolume()
    End Sub

    Private Sub CbDevice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbDevice.SelectedIndexChanged
        Server.SelectedDevice = CbDevice.SelectedIndex
        Server.AssignListToComboBox(CbInput, Server.DevicesPart(Server.SelectedDevice), CbDevice.SelectedIndex)
    End Sub

    Private Sub CbInput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbInput.SelectedIndexChanged
        Server.SelectedInput = CbInput.SelectedIndex
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FileDialog As New OpenFileDialog()
        FileDialog.InitialDirectory = "C:\"
        FileDialog.Multiselect = True
        If FileDialog.ShowDialog() = DialogResult.OK Then
            MediaList.Items.Clear()
            For i As Integer = 0 To FileDialog.FileNames.Length - 1
                FileName.Add(FileDialog.FileNames.GetValue(i).ToString())
            Next i
            MediaList.Items.AddRange(FileName.ToArray())
        End If
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        If MediaList.SelectedIndex > -1 Then
            MediaList.Items.RemoveAt(MediaList.SelectedIndex)
            Dim tmpMedia As String = ""
            FileName.Clear()
            For x As Integer = 0 To MediaList.Items.Count - 1
                tmpMedia &= MediaList.Items(x).ToString()
                FileName.Add(MediaList.Items(x).ToString())
                If x < MediaList.Items.Count - 1 Then
                    tmpMedia &= vbCrLf
                End If
            Next x
            Server.MediaFile.Clear()
            Server.MediaFile = FileName
            Reg.CreateReg("AntServer", RegrisName, "MediaFile", tmpMedia)
        End If
    End Sub

    Private Sub BtnTV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTV.Click
        Dim Tv As String = ""
        Tv = "TVTimes" & numTv.Value
        If Tv <> "" Then
            MediaList.Items.Clear()
            FileName.Add(Tv)
            MediaList.Items.AddRange(FileName.ToArray())
        End If
    End Sub

    Public Sub MediaPlaylist()
        If Reg.ReadRegValue("AntServer", RegrisName, "MediaFile") <> "" Then
            Dim rText As String = Reg.ReadRegValue("AntServer", RegrisName, "MediaFile")
            MediaArray = rText.Split(New String() {vbCrLf}, StringSplitOptions.None)
            MediaList.Items.AddRange(MediaArray)
            FileName.Clear()
            FileName = MediaArray.ToList()
        End If
        Server.AssignListToComboBox(CbDevice, Server.VideoDevices, Server.VideoDevice)
        Server.AssignListToComboBox(CbInput, Server.VideoInputs, Server.VideoInput)
        TrkVolume.Value = Server.VideoVolume
        Try
            CbDevice.SelectedIndex = Server.SelectedDevice
            CbInput.SelectedIndex = Server.SelectedInput
        Catch
        End Try
    End Sub
#End Region

    Private Sub BtnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFont.Click
        Try
            Dim fontDlg As New FontDialog()
            fontDlg.Font = Server.RtextFont
            fontDlg.ShowColor = False
            fontDlg.ShowApply = True
            fontDlg.ShowEffects = True
            fontDlg.ShowHelp = True
            fontDlg.MaxSize = 40
            fontDlg.MinSize = 12
            If fontDlg.ShowDialog() = DialogResult.OK Then
                Server.RtextFont = fontDlg.Font
            End If
        Catch
        End Try
    End Sub

    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.RtextBrush = New SolidBrush(cdlg.Color)
        End If
    End Sub

    Private Sub BtnCencel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCencel.Click
        Server.RunningtextChange = False
    End Sub

    Private Sub BtnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave1.Click
        If CInt(NuSpeed.Value) <= 0 Then
            NuSpeed.Value = 1
        End If
        Server.RtextSpeed = CInt(NuSpeed.Value)
        Reg.CreateReg("AntServer", RegrisName, "Speed", NuSpeed.Value.ToString())
        Reg.CreateReg("AntServer", RegrisName, "rText", TxtRunning.Text)
        Reg.CreateReg("AntServer", RegrisName, "rtextFont", Server.ConverterFont.ConvertToString(Server.RtextFont))
        Reg.CreateReg("AntServer", RegrisName, "rtextFontColor", Server.ConverterBrush.ConvertToString(New Pen(Server.RtextBrush).Color))
        Server.RunningtextChange = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub numImage_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numImage.ValueChanged
        Reg.CreateReg("AntServer", RegrisName, "SpeedImage", NuSpeed.Value.ToString())
    End Sub
End Class