Imports VidGrab

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Server))
        Me.pbMainNomor = New System.Windows.Forms.Panel()
        Me.tmRuningText = New System.Windows.Forms.Timer(Me.components)
        Me.tmVideo = New System.Windows.Forms.Timer(Me.components)
        Me.tmClock = New System.Windows.Forms.Timer(Me.components)
        Me.tmMainDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.tmCounter = New System.Windows.Forms.Timer(Me.components)
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREATPRINTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenereteDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingSistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetingUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingValasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KursValasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingMediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingWarnaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesainTiketToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanTVChanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesainTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmQueue = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Print1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print4ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrntTiket = New System.Drawing.Printing.PrintDocument()
        Me.tmDeposito = New System.Windows.Forms.Timer(Me.components)
        Me.tmSisaAntrian = New System.Windows.Forms.Timer(Me.components)
        Me.tmOpenLayanan = New System.Windows.Forms.Timer(Me.components)
        Me.tmCloseLayanan = New System.Windows.Forms.Timer(Me.components)
        Me.tmWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.pbSisaAntrian = New System.Windows.Forms.PictureBox()
        Me.pbCounter = New System.Windows.Forms.PictureBox()
        Me.pbMainLayanan = New System.Windows.Forms.PictureBox()
        Me.pbRText = New System.Windows.Forms.PictureBox()
        Me.pbJam = New System.Windows.Forms.PictureBox()
        Me.vgrb = New VidGrab.VideoGrabber()
        Me.cmsMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbSisaAntrian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMainLayanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbMainNomor
        '
        Me.pbMainNomor.BackColor = System.Drawing.Color.Transparent
        Me.pbMainNomor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbMainNomor.Location = New System.Drawing.Point(12, 146)
        Me.pbMainNomor.Name = "pbMainNomor"
        Me.pbMainNomor.Size = New System.Drawing.Size(467, 183)
        Me.pbMainNomor.TabIndex = 22
        '
        'tmRuningText
        '
        Me.tmRuningText.Interval = 25
        '
        'tmVideo
        '
        Me.tmVideo.Interval = 6000
        '
        'tmClock
        '
        Me.tmClock.Interval = 300
        '
        'tmMainDisplay
        '
        Me.tmMainDisplay.Interval = 750
        '
        'tmCounter
        '
        Me.tmCounter.Interval = 2500
        '
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.CreateClientToolStripMenuItem, Me.CREATPRINTERToolStripMenuItem, Me.GenereteDataToolStripMenuItem, Me.SettingSistemToolStripMenuItem, Me.SetingUserToolStripMenuItem, Me.SettingValasToolStripMenuItem, Me.SettingMediaToolStripMenuItem, Me.SettingWarnaToolStripMenuItem, Me.DesainTiketToolStripMenuItem1, Me.ScanTVChanelToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ResetToolStripMenuItem, Me.RollBackToolStripMenuItem, Me.DesainTiketToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(237, 378)
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'CreateClientToolStripMenuItem
        '
        Me.CreateClientToolStripMenuItem.Name = "CreateClientToolStripMenuItem"
        Me.CreateClientToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.CreateClientToolStripMenuItem.Text = "CREATE CLIENT ANTRIAN"
        '
        'CREATPRINTERToolStripMenuItem
        '
        Me.CREATPRINTERToolStripMenuItem.Name = "CREATPRINTERToolStripMenuItem"
        Me.CREATPRINTERToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.CREATPRINTERToolStripMenuItem.Text = "CREAT PRINTER"
        '
        'GenereteDataToolStripMenuItem
        '
        Me.GenereteDataToolStripMenuItem.Name = "GenereteDataToolStripMenuItem"
        Me.GenereteDataToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.GenereteDataToolStripMenuItem.Text = "GENERATE NOMOR ANTRIAN "
        '
        'SettingSistemToolStripMenuItem
        '
        Me.SettingSistemToolStripMenuItem.Name = "SettingSistemToolStripMenuItem"
        Me.SettingSistemToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SettingSistemToolStripMenuItem.Text = "Setting Sistem"
        Me.SettingSistemToolStripMenuItem.Visible = False
        '
        'SetingUserToolStripMenuItem
        '
        Me.SetingUserToolStripMenuItem.Name = "SetingUserToolStripMenuItem"
        Me.SetingUserToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SetingUserToolStripMenuItem.Text = "Setting User"
        '
        'SettingValasToolStripMenuItem
        '
        Me.SettingValasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KursValasToolStripMenuItem, Me.DepositoToolStripMenuItem, Me.GiroToolStripMenuItem, Me.KreditToolStripMenuItem})
        Me.SettingValasToolStripMenuItem.Name = "SettingValasToolStripMenuItem"
        Me.SettingValasToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SettingValasToolStripMenuItem.Text = "Setting Valas"
        '
        'KursValasToolStripMenuItem
        '
        Me.KursValasToolStripMenuItem.Name = "KursValasToolStripMenuItem"
        Me.KursValasToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.KursValasToolStripMenuItem.Text = "Kurs Valas"
        '
        'DepositoToolStripMenuItem
        '
        Me.DepositoToolStripMenuItem.Name = "DepositoToolStripMenuItem"
        Me.DepositoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DepositoToolStripMenuItem.Text = "Deposito"
        '
        'GiroToolStripMenuItem
        '
        Me.GiroToolStripMenuItem.Name = "GiroToolStripMenuItem"
        Me.GiroToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.GiroToolStripMenuItem.Text = "Giro"
        '
        'KreditToolStripMenuItem
        '
        Me.KreditToolStripMenuItem.Name = "KreditToolStripMenuItem"
        Me.KreditToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.KreditToolStripMenuItem.Text = "Kredit"
        '
        'SettingMediaToolStripMenuItem
        '
        Me.SettingMediaToolStripMenuItem.Name = "SettingMediaToolStripMenuItem"
        Me.SettingMediaToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SettingMediaToolStripMenuItem.Text = "Setting Media"
        '
        'SettingWarnaToolStripMenuItem
        '
        Me.SettingWarnaToolStripMenuItem.Name = "SettingWarnaToolStripMenuItem"
        Me.SettingWarnaToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SettingWarnaToolStripMenuItem.Text = "Setting Warna"
        '
        'DesainTiketToolStripMenuItem1
        '
        Me.DesainTiketToolStripMenuItem1.Name = "DesainTiketToolStripMenuItem1"
        Me.DesainTiketToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.DesainTiketToolStripMenuItem1.Text = "Desain Tiket Dan Contoh Tiket"
        '
        'ScanTVChanelToolStripMenuItem
        '
        Me.ScanTVChanelToolStripMenuItem.Name = "ScanTVChanelToolStripMenuItem"
        Me.ScanTVChanelToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ScanTVChanelToolStripMenuItem.Text = "Scan TV Chanel"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'RollBackToolStripMenuItem
        '
        Me.RollBackToolStripMenuItem.Name = "RollBackToolStripMenuItem"
        Me.RollBackToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RollBackToolStripMenuItem.Text = "RollBack"
        '
        'DesainTiketToolStripMenuItem
        '
        Me.DesainTiketToolStripMenuItem.Name = "DesainTiketToolStripMenuItem"
        Me.DesainTiketToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.DesainTiketToolStripMenuItem.Text = "About Us"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'tmQueue
        '
        Me.tmQueue.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Print1ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(994, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'Print1ToolStripMenuItem
        '
        Me.Print1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Print1ToolStripMenuItem1, Me.Print2ToolStripMenuItem, Me.Print3ToolStripMenuItem, Me.Print4ToolStripMenuItem, Me.Print4ToolStripMenuItem1, Me.Print6ToolStripMenuItem, Me.Print7ToolStripMenuItem, Me.Print8ToolStripMenuItem, Me.Print9ToolStripMenuItem, Me.Print10ToolStripMenuItem, Me.Print11ToolStripMenuItem, Me.Print12ToolStripMenuItem})
        Me.Print1ToolStripMenuItem.Name = "Print1ToolStripMenuItem"
        Me.Print1ToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.Print1ToolStripMenuItem.Text = "Pritnt Number"
        '
        'Print1ToolStripMenuItem1
        '
        Me.Print1ToolStripMenuItem1.Name = "Print1ToolStripMenuItem1"
        Me.Print1ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.Print1ToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.Print1ToolStripMenuItem1.Text = "Print 1"
        '
        'Print2ToolStripMenuItem
        '
        Me.Print2ToolStripMenuItem.Name = "Print2ToolStripMenuItem"
        Me.Print2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.Print2ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print2ToolStripMenuItem.Text = "Print 2"
        '
        'Print3ToolStripMenuItem
        '
        Me.Print3ToolStripMenuItem.Name = "Print3ToolStripMenuItem"
        Me.Print3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.Print3ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print3ToolStripMenuItem.Text = "Print 3"
        '
        'Print4ToolStripMenuItem
        '
        Me.Print4ToolStripMenuItem.Name = "Print4ToolStripMenuItem"
        Me.Print4ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.Print4ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print4ToolStripMenuItem.Text = "Print 4"
        '
        'Print4ToolStripMenuItem1
        '
        Me.Print4ToolStripMenuItem1.Name = "Print4ToolStripMenuItem1"
        Me.Print4ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.Print4ToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.Print4ToolStripMenuItem1.Text = "Print 5"
        '
        'Print6ToolStripMenuItem
        '
        Me.Print6ToolStripMenuItem.Name = "Print6ToolStripMenuItem"
        Me.Print6ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.Print6ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print6ToolStripMenuItem.Text = "Print 6"
        '
        'Print7ToolStripMenuItem
        '
        Me.Print7ToolStripMenuItem.Name = "Print7ToolStripMenuItem"
        Me.Print7ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.Print7ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print7ToolStripMenuItem.Text = "Print 7"
        '
        'Print8ToolStripMenuItem
        '
        Me.Print8ToolStripMenuItem.Name = "Print8ToolStripMenuItem"
        Me.Print8ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.Print8ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print8ToolStripMenuItem.Text = "Print 8"
        '
        'Print9ToolStripMenuItem
        '
        Me.Print9ToolStripMenuItem.Name = "Print9ToolStripMenuItem"
        Me.Print9ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print9ToolStripMenuItem.Text = "Print 9"
        '
        'Print10ToolStripMenuItem
        '
        Me.Print10ToolStripMenuItem.Name = "Print10ToolStripMenuItem"
        Me.Print10ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print10ToolStripMenuItem.Text = "Print 10"
        '
        'Print11ToolStripMenuItem
        '
        Me.Print11ToolStripMenuItem.Name = "Print11ToolStripMenuItem"
        Me.Print11ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print11ToolStripMenuItem.Text = "Print 11"
        '
        'Print12ToolStripMenuItem
        '
        Me.Print12ToolStripMenuItem.Name = "Print12ToolStripMenuItem"
        Me.Print12ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Print12ToolStripMenuItem.Text = "Print 12"
        '
        'tmDeposito
        '
        Me.tmDeposito.Interval = 2500
        '
        'tmSisaAntrian
        '
        Me.tmSisaAntrian.Interval = 2500
        '
        'tmOpenLayanan
        '
        Me.tmOpenLayanan.Interval = 1000
        '
        'tmCloseLayanan
        '
        Me.tmCloseLayanan.Interval = 1000
        '
        'tmWaktu
        '
        Me.tmWaktu.Interval = 1000
        '
        'pbSisaAntrian
        '
        Me.pbSisaAntrian.BackColor = System.Drawing.Color.Transparent
        Me.pbSisaAntrian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbSisaAntrian.Location = New System.Drawing.Point(485, 338)
        Me.pbSisaAntrian.Name = "pbSisaAntrian"
        Me.pbSisaAntrian.Size = New System.Drawing.Size(497, 129)
        Me.pbSisaAntrian.TabIndex = 35
        Me.pbSisaAntrian.TabStop = False
        '
        'pbCounter
        '
        Me.pbCounter.BackColor = System.Drawing.Color.Transparent
        Me.pbCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCounter.Location = New System.Drawing.Point(12, 338)
        Me.pbCounter.Name = "pbCounter"
        Me.pbCounter.Size = New System.Drawing.Size(467, 128)
        Me.pbCounter.TabIndex = 14
        Me.pbCounter.TabStop = False
        '
        'pbMainLayanan
        '
        Me.pbMainLayanan.BackColor = System.Drawing.Color.Transparent
        Me.pbMainLayanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbMainLayanan.Location = New System.Drawing.Point(12, 14)
        Me.pbMainLayanan.Name = "pbMainLayanan"
        Me.pbMainLayanan.Size = New System.Drawing.Size(467, 126)
        Me.pbMainLayanan.TabIndex = 13
        Me.pbMainLayanan.TabStop = False
        '
        'pbRText
        '
        Me.pbRText.BackColor = System.Drawing.Color.Black
        Me.pbRText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbRText.Location = New System.Drawing.Point(12, 475)
        Me.pbRText.Name = "pbRText"
        Me.pbRText.Size = New System.Drawing.Size(816, 44)
        Me.pbRText.TabIndex = 11
        Me.pbRText.TabStop = False
        '
        'pbJam
        '
        Me.pbJam.BackColor = System.Drawing.Color.Black
        Me.pbJam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJam.Location = New System.Drawing.Point(834, 475)
        Me.pbJam.Name = "pbJam"
        Me.pbJam.Size = New System.Drawing.Size(148, 44)
        Me.pbJam.TabIndex = 12
        Me.pbJam.TabStop = False
        '
        'vgrb
        '
        Me.vgrb.AdjustOverlayAspectRatio = True
        Me.vgrb.AdjustPixelAspectRatio = True
        Me.vgrb.Aero = VidGrab.TAero.ae_Default
        Me.vgrb.AnalogVideoStandard = -1
        Me.vgrb.ApplicationPriority = VidGrab.TApplicationPriority.ap_default
        Me.vgrb.ASFAudioBitRate = -1
        Me.vgrb.ASFAudioChannels = -1
        Me.vgrb.ASFBufferWindow = -1
        Me.vgrb.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced
        Me.vgrb.ASFDirectStreamingKeepClientsConnected = False
        Me.vgrb.ASFFixedFrameRate = True
        Me.vgrb.ASFMediaServerPublishingPoint = ""
        Me.vgrb.ASFMediaServerRemovePublishingPointAfterDisconnect = False
        Me.vgrb.ASFMediaServerTemplatePublishingPoint = ""
        Me.vgrb.ASFNetworkMaxUsers = 5
        Me.vgrb.ASFNetworkPort = 0
        Me.vgrb.ASFProfile = -1
        Me.vgrb.ASFProfileFromCustomFile = ""
        Me.vgrb.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8
        Me.vgrb.ASFVideoBitRate = -1
        Me.vgrb.ASFVideoFrameRate = 0.0R
        Me.vgrb.ASFVideoHeight = -1
        Me.vgrb.ASFVideoMaxKeyFrameSpacing = -1
        Me.vgrb.ASFVideoQuality = 80
        Me.vgrb.ASFVideoWidth = -1
        Me.vgrb.AspectRatioToUse = -1.0R
        Me.vgrb.AssociateAudioAndVideoDevices = False
        Me.vgrb.AudioBalance = 0
        Me.vgrb.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_Normal
        Me.vgrb.AudioCompressor = 0
        Me.vgrb.AudioDevice = -1
        Me.vgrb.AudioDeviceRendering = False
        Me.vgrb.AudioFormat = VidGrab.TAudioFormat.af_default
        Me.vgrb.AudioInput = -1
        Me.vgrb.AudioInputBalance = 0
        Me.vgrb.AudioInputLevel = 65535
        Me.vgrb.AudioInputMono = False
        Me.vgrb.AudioPeakEvent = False
        Me.vgrb.AudioRecording = False
        Me.vgrb.AudioRenderer = -1
        Me.vgrb.AudioSource = VidGrab.TAudioSource.as_Default
        Me.vgrb.AudioStreamNumber = -1
        Me.vgrb.AudioSyncAdjustment = 0
        Me.vgrb.AudioSyncAdjustmentEnabled = False
        Me.vgrb.AudioVolume = 32767
        Me.vgrb.AutoConnectRelatedPins = True
        Me.vgrb.AutoFileName = VidGrab.TAutoFileName.fn_Sequential
        Me.vgrb.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz"
        Me.vgrb.AutoFileNameMinDigits = 6
        Me.vgrb.AutoFilePrefix = "vg"
        Me.vgrb.AutoFileSuffix = ""
        Me.vgrb.AutoRefreshPreview = False
        Me.vgrb.AutoStartPlayer = True
        Me.vgrb.AVIDurationUpdated = True
        Me.vgrb.AVIFormatOpenDML = True
        Me.vgrb.AVIFormatOpenDMLCompatibilityIndex = True
        Me.vgrb.BackColor = System.Drawing.Color.DarkGray
        Me.vgrb.BackgroundColor = 0
        Me.vgrb.BufferCount = -1
        Me.vgrb.BurstCount = 3
        Me.vgrb.BurstInterval = 0
        Me.vgrb.BurstMode = False
        Me.vgrb.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap
        Me.vgrb.BusyCursor = VidGrab.TCursors.cr_HourGlass
        Me.vgrb.CameraControlSettings = True
        Me.vgrb.CaptureFileExt = ""
        Me.vgrb.ColorKey = 1048592
        Me.vgrb.ColorKeyEnabled = False
        Me.vgrb.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression
        Me.vgrb.CompressionType = VidGrab.TCompressionType.ct_Video
        Me.vgrb.Cropping_Enabled = False
        Me.vgrb.Cropping_Height = 120
        Me.vgrb.Cropping_Outbounds = True
        Me.vgrb.Cropping_Width = 160
        Me.vgrb.Cropping_X = 0
        Me.vgrb.Cropping_Y = 0
        Me.vgrb.Cropping_Zoom = 1.0R
        Me.vgrb.Display_Active = True
        Me.vgrb.Display_AlphaBlendEnabled = False
        Me.vgrb.Display_AlphaBlendValue = 180
        Me.vgrb.Display_AspectRatio = VidGrab.TAspectRatio.ar_Stretch
        Me.vgrb.Display_AutoSize = False
        Me.vgrb.Display_Embedded = True
        Me.vgrb.Display_FullScreen = False
        Me.vgrb.Display_Height = 240
        Me.vgrb.Display_Left = 10
        Me.vgrb.Display_Monitor = 0
        Me.vgrb.Display_MouseMovesWindow = True
        Me.vgrb.Display_PanScanRatio = 50
        Me.vgrb.Display_StayOnTop = False
        Me.vgrb.Display_Top = 10
        Me.vgrb.Display_TransparentColorEnabled = False
        Me.vgrb.Display_TransparentColorValue = 255
        Me.vgrb.Display_VideoPortEnabled = True
        Me.vgrb.Display_Visible = True
        Me.vgrb.Display_Width = 320
        Me.vgrb.DoubleBuffered = False
        Me.vgrb.DroppedFramesPollingInterval = -1
        Me.vgrb.DualDisplay_Active = False
        Me.vgrb.DualDisplay_AlphaBlendEnabled = False
        Me.vgrb.DualDisplay_AlphaBlendValue = 180
        Me.vgrb.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Stretch
        Me.vgrb.DualDisplay_AutoSize = False
        Me.vgrb.DualDisplay_Embedded = False
        Me.vgrb.DualDisplay_FullScreen = False
        Me.vgrb.DualDisplay_Height = 240
        Me.vgrb.DualDisplay_Left = 20
        Me.vgrb.DualDisplay_Monitor = 0
        Me.vgrb.DualDisplay_MouseMovesWindow = True
        Me.vgrb.DualDisplay_PanScanRatio = 50
        Me.vgrb.DualDisplay_StayOnTop = False
        Me.vgrb.DualDisplay_Top = 400
        Me.vgrb.DualDisplay_TransparentColorEnabled = False
        Me.vgrb.DualDisplay_TransparentColorValue = 255
        Me.vgrb.DualDisplay_VideoPortEnabled = False
        Me.vgrb.DualDisplay_Visible = True
        Me.vgrb.DualDisplay_Width = 320
        Me.vgrb.DVDateTimeEnabled = True
        Me.vgrb.DVDiscontinuityMinimumInterval = 3
        Me.vgrb.DVDTitle = 0
        Me.vgrb.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD
        Me.vgrb.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full
        Me.vgrb.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default
        Me.vgrb.DVRecordingInNativeFormatSeparatesStreams = False
        Me.vgrb.DVReduceFrameRate = False
        Me.vgrb.DVRgb219 = False
        Me.vgrb.DVTimeCodeEnabled = True
        Me.vgrb.EventNotificationSynchrone = True
        Me.vgrb.FixFlickerOrBlackCapture = False
        Me.vgrb.FrameCaptureHeight = -1
        Me.vgrb.FrameCaptureWidth = -1
        Me.vgrb.FrameCaptureWithoutOverlay = False
        Me.vgrb.FrameCaptureZoomSize = 100
        Me.vgrb.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams
        Me.vgrb.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default
        Me.vgrb.FrameNumberStartsFromZero = False
        Me.vgrb.FrameRate = 0.0R
        Me.vgrb.FrameRateDivider = 0
        Me.vgrb.HoldRecording = False
        Me.vgrb.ImageOverlay_AlphaBlend = False
        Me.vgrb.ImageOverlay_AlphaBlendValue = 180
        Me.vgrb.ImageOverlay_ChromaKey = False
        Me.vgrb.ImageOverlay_ChromaKeyLeewayPercent = 25
        Me.vgrb.ImageOverlay_ChromaKeyRGBColor = 0
        Me.vgrb.ImageOverlay_Height = -1
        Me.vgrb.ImageOverlay_LeftLocation = 10
        Me.vgrb.ImageOverlay_RotationAngle = 0.0R
        Me.vgrb.ImageOverlay_StretchToVideoSize = False
        Me.vgrb.ImageOverlay_TargetDisplay = -1
        Me.vgrb.ImageOverlay_TopLocation = 10
        Me.vgrb.ImageOverlay_Transparent = False
        Me.vgrb.ImageOverlay_TransparentColorValue = 0
        Me.vgrb.ImageOverlay_UseTransparentColor = False
        Me.vgrb.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop
        Me.vgrb.ImageOverlay_Width = -1
        Me.vgrb.ImageOverlayEnabled = False
        Me.vgrb.ImageOverlaySelector = 0
        Me.vgrb.IPCameraURL = ""
        Me.vgrb.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality
        Me.vgrb.JPEGProgressiveDisplay = False
        Me.vgrb.JPEGQuality = 100
        Me.vgrb.LicenseString = "N/A"
        Me.vgrb.Location = New System.Drawing.Point(485, 14)
        Me.vgrb.LogoDisplayed = False
        Me.vgrb.LogoLayout = VidGrab.TLogoLayout.lg_Stretched
        Me.vgrb.MixAudioSamples_CurrentSourceLevel = 100
        Me.vgrb.MixAudioSamples_ExternalSourceLevel = 100
        Me.vgrb.Mixer_MosaicColumns = 1
        Me.vgrb.Mixer_MosaicLines = 1
        Me.vgrb.MotionDetector_CompareBlue = True
        Me.vgrb.MotionDetector_CompareGreen = True
        Me.vgrb.MotionDetector_CompareRed = True
        Me.vgrb.MotionDetector_Enabled = False
        Me.vgrb.MotionDetector_GreyScale = False
        Me.vgrb.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" & _
            "555555 5555555555 5555555555"
        Me.vgrb.MotionDetector_MaxDetectionsPerSecond = 0.0R
        Me.vgrb.MotionDetector_ReduceCPULoad = 1
        Me.vgrb.MotionDetector_ReduceVideoNoise = False
        Me.vgrb.MotionDetector_Triggered = False
        Me.vgrb.MouseWheelEventEnabled = True
        Me.vgrb.MpegStreamType = VidGrab.TMpegStreamType.mpst_Default
        Me.vgrb.MultiplexedInputEmulation = True
        Me.vgrb.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed
        Me.vgrb.MultiplexedStabilizationDelay = 100
        Me.vgrb.MultiplexedSwitchDelay = 0
        Me.vgrb.Multiplexer = -1
        Me.vgrb.MuteAudioRendering = False
        Me.vgrb.Name = "vgrb"
        Me.vgrb.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled
        Me.vgrb.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming
        Me.vgrb.NormalCursor = VidGrab.TCursors.cr_Default
        Me.vgrb.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread
        Me.vgrb.NotificationPriority = VidGrab.TThreadPriority.tpNormal
        Me.vgrb.NotificationSleepTime = -1
        Me.vgrb.OnFrameBitmapEventSynchrone = False
        Me.vgrb.OpenURLAsync = True
        Me.vgrb.OverlayAfterTransform = False
        Me.vgrb.OwnerObject = Nothing
        Me.vgrb.PlayerAudioRendering = True
        Me.vgrb.PlayerDuration = CType(1, Long)
        Me.vgrb.PlayerDVSize = VidGrab.TDVSize.dv_Full
        Me.vgrb.PlayerFastSeekSpeedRatio = 4
        Me.vgrb.PlayerFileName = ""
        Me.vgrb.PlayerForcedCodec = ""
        Me.vgrb.PlayerFramePosition = CType(1, Long)
        Me.vgrb.PlayerRefreshPausedDisplay = False
        Me.vgrb.PlayerRefreshPausedDisplayFrameRate = 0.0R
        Me.vgrb.PlayerSpeedRatio = 1.0R
        Me.vgrb.PlayerTimePosition = CType(0, Long)
        Me.vgrb.PlayerTrackBarSynchrone = False
        Me.vgrb.PlaylistIndex = 0
        Me.vgrb.PreallocCapFileCopiedAfterRecording = True
        Me.vgrb.PreallocCapFileEnabled = False
        Me.vgrb.PreallocCapFileName = ""
        Me.vgrb.PreallocCapFileSizeInMB = 100
        Me.vgrb.PreviewZoomSize = 100
        Me.vgrb.QuickDeviceInitialization = False
        Me.vgrb.RawAudioSampleCapture = False
        Me.vgrb.RawCaptureAsyncEvent = True
        Me.vgrb.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat
        Me.vgrb.RawVideoSampleCapture = False
        Me.vgrb.RecordingAudioBitRate = -1
        Me.vgrb.RecordingBacktimedFramesCount = 0
        Me.vgrb.RecordingCanPause = False
        Me.vgrb.RecordingFileName = ""
        Me.vgrb.RecordingInNativeFormat = True
        Me.vgrb.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        Me.vgrb.RecordingOnMotion_Enabled = False
        Me.vgrb.RecordingOnMotion_MotionThreshold = 0.0R
        Me.vgrb.RecordingOnMotion_NoMotionPauseDelayMs = 5000
        Me.vgrb.RecordingPauseCreatesNewFile = False
        Me.vgrb.RecordingSize = VidGrab.TRecordingSize.rs_Default
        Me.vgrb.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled
        Me.vgrb.RecordingTimerInterval = 0
        Me.vgrb.RecordingVideoBitRate = -1
        Me.vgrb.Reencoding_IncludeAudioStream = True
        Me.vgrb.Reencoding_IncludeVideoStream = True
        Me.vgrb.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF
        Me.vgrb.Reencoding_NewVideoClip = ""
        Me.vgrb.Reencoding_SourceVideoClip = ""
        Me.vgrb.Reencoding_StartFrame = CType(-1, Long)
        Me.vgrb.Reencoding_StartTime = CType(-1, Long)
        Me.vgrb.Reencoding_StopFrame = CType(-1, Long)
        Me.vgrb.Reencoding_StopTime = CType(-1, Long)
        Me.vgrb.Reencoding_UseAudioCompressor = False
        Me.vgrb.Reencoding_UseFrameGrabber = True
        Me.vgrb.Reencoding_UseVideoCompressor = False
        Me.vgrb.Reencoding_WMVOutput = False
        Me.vgrb.ScreenRecordingLayeredWindows = False
        Me.vgrb.ScreenRecordingMonitor = 0
        Me.vgrb.ScreenRecordingNonVisibleWindows = False
        Me.vgrb.ScreenRecordingThroughClipboard = False
        Me.vgrb.ScreenRecordingWithCursor = True
        Me.vgrb.SendToDV_DeviceIndex = -1
        Me.vgrb.Size = New System.Drawing.Size(497, 315)
        Me.vgrb.SpeakerBalance = 0
        Me.vgrb.SpeakerControl = False
        Me.vgrb.SpeakerVolume = 65535
        Me.vgrb.StoragePath = "E:\Data Projek Jadi\Queue UDP SISTEM\Data Test Antrian\Queue Project"
        Me.vgrb.StoreDeviceSettingsInRegistry = True
        Me.vgrb.SyncCommands = True
        Me.vgrb.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master
        Me.vgrb.Synchronized = False
        Me.vgrb.SyncPreview = VidGrab.TSyncPreview.sp_Auto
        Me.vgrb.TabIndex = 36
        Me.vgrb.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left
        Me.vgrb.TextOverlay_BkColor = 16777215
        Me.vgrb.TextOverlay_Enabled = False
        'TODO: Code generation for 'Me.vgrb.TextOverlay_Font' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.vgrb.TextOverlay_FontColor = 16776960
        Me.vgrb.TextOverlay_FontSize = 12
        Me.vgrb.TextOverlay_GradientColor = 8388608
        Me.vgrb.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled
        Me.vgrb.TextOverlay_HighResFont = True
        Me.vgrb.TextOverlay_Left = 0
        Me.vgrb.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal
        Me.vgrb.TextOverlay_Right = -1
        Me.vgrb.TextOverlay_Scrolling = False
        Me.vgrb.TextOverlay_ScrollingSpeed = 1
        Me.vgrb.TextOverlay_Selector = 0
        Me.vgrb.TextOverlay_Shadow = True
        Me.vgrb.TextOverlay_ShadowColor = 0
        Me.vgrb.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_NorthWest
        Me.vgrb.TextOverlay_String = resources.GetString("vgrb.TextOverlay_String")
        Me.vgrb.TextOverlay_TargetDisplay = -1
        Me.vgrb.TextOverlay_Top = 0
        Me.vgrb.TextOverlay_Transparent = True
        Me.vgrb.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop
        Me.vgrb.ThirdPartyDeinterlacer = ""
        Me.vgrb.TranslateMouseCoordinates = True
        Me.vgrb.TunerFrequency = -1
        Me.vgrb.TunerMode = VidGrab.TTunerMode.tm_TVTuner
        Me.vgrb.TVChannel = 0
        Me.vgrb.TVCountryCode = 0
        Me.vgrb.TVTunerInputType = VidGrab.TTunerInputType.TunerInputCable
        Me.vgrb.TVUseFrequencyOverrides = False
        Me.vgrb.UseClock = True
        Me.vgrb.VCRHorizontalLocking = False
        Me.vgrb.Version = "v10.4.2.4 (build 160616) - Copyright ©2016 Datastead"
        Me.vgrb.VideoCompression_DataRate = -1
        Me.vgrb.VideoCompression_KeyFrameRate = 15
        Me.vgrb.VideoCompression_PFramesPerKeyFrame = 0
        Me.vgrb.VideoCompression_Quality = 1.0R
        Me.vgrb.VideoCompression_WindowSize = -1
        Me.vgrb.VideoCompressor = 0
        Me.vgrb.VideoControlSettings = True
        Me.vgrb.VideoCursor = VidGrab.TCursors.cr_Default
        Me.vgrb.VideoDelay = CType(0, Long)
        Me.vgrb.VideoDevice = -1
        Me.vgrb.VideoFormat = -1
        Me.vgrb.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc
        Me.vgrb.VideoFromImages_RepeatIndefinitely = False
        Me.vgrb.VideoFromImages_SourceDirectory = "E:\Data Projek Jadi\Queue UDP SISTEM\Data Test Antrian\Queue Project"
        Me.vgrb.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat"
        Me.vgrb.VideoInput = -1
        Me.vgrb.VideoProcessing_Brightness = 0
        Me.vgrb.VideoProcessing_Contrast = 0
        Me.vgrb.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled
        Me.vgrb.VideoProcessing_FlipHorizontal = False
        Me.vgrb.VideoProcessing_FlipVertical = False
        Me.vgrb.VideoProcessing_GrayScale = False
        Me.vgrb.VideoProcessing_Hue = 0
        Me.vgrb.VideoProcessing_InvertColors = False
        Me.vgrb.VideoProcessing_Pixellization = 1
        Me.vgrb.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg
        Me.vgrb.VideoProcessing_RotationCustomAngle = 45.5R
        Me.vgrb.VideoProcessing_Saturation = 0
        Me.vgrb.VideoQualitySettings = True
        Me.vgrb.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect
        Me.vgrb.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None
        Me.vgrb.VideoRendererExternalIndex = -1
        Me.vgrb.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto
        Me.vgrb.VideoSize = -1
        Me.vgrb.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice
        Me.vgrb.VideoSource_FileOrURL = ""
        Me.vgrb.VideoSource_FileOrURL_StartTime = CType(-1, Long)
        Me.vgrb.VideoSource_FileOrURL_StopTime = CType(-1, Long)
        Me.vgrb.VideoSubtype = -1
        Me.vgrb.VideoVisibleWhenStopped = False
        Me.vgrb.VirtualAudioStreamControl = -1
        Me.vgrb.VirtualVideoStreamControl = -1
        Me.vgrb.VuMeter = VidGrab.TVuMeter.vu_Disabled
        Me.vgrb.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled
        Me.vgrb.ZoomCoeff = 1000
        Me.vgrb.ZoomXCenter = 0
        Me.vgrb.ZoomYCenter = 0
        '
        'Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(994, 533)
        Me.ContextMenuStrip = Me.cmsMenu
        Me.Controls.Add(Me.vgrb)
        Me.Controls.Add(Me.pbSisaAntrian)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pbMainNomor)
        Me.Controls.Add(Me.pbCounter)
        Me.Controls.Add(Me.pbMainLayanan)
        Me.Controls.Add(Me.pbRText)
        Me.Controls.Add(Me.pbJam)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Server"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Server"
        Me.cmsMenu.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbSisaAntrian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMainLayanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pbCounter As System.Windows.Forms.PictureBox
    Private WithEvents pbMainLayanan As System.Windows.Forms.PictureBox
    Private WithEvents pbRText As System.Windows.Forms.PictureBox
    Private WithEvents pbJam As System.Windows.Forms.PictureBox
    Friend WithEvents pbMainNomor As System.Windows.Forms.Panel
    Friend WithEvents tmRuningText As System.Windows.Forms.Timer
    Friend WithEvents cmsMenu As System.Windows.Forms.ContextMenuStrip
    Private WithEvents tmVideo As System.Windows.Forms.Timer
    Private WithEvents tmClock As System.Windows.Forms.Timer
    Private WithEvents tmMainDisplay As System.Windows.Forms.Timer
    Private WithEvents tmCounter As System.Windows.Forms.Timer
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetingUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingMediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RollBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingWarnaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingSistemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tmQueue As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Print1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print1ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print4ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print11ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print12ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrntTiket As System.Drawing.Printing.PrintDocument
    Friend WithEvents SettingValasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tmDeposito As System.Windows.Forms.Timer
    Friend WithEvents ScanTVChanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KursValasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepositoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KreditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbSisaAntrian As System.Windows.Forms.PictureBox
    Friend WithEvents tmSisaAntrian As System.Windows.Forms.Timer
    Friend WithEvents tmOpenLayanan As System.Windows.Forms.Timer
    Friend WithEvents tmCloseLayanan As System.Windows.Forms.Timer
    Friend WithEvents tmWaktu As System.Windows.Forms.Timer
    Friend WithEvents DesainTiketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesainTiketToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenereteDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vgrb As VidGrab.VideoGrabber
    Friend WithEvents CREATPRINTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
