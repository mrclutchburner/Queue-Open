Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.Sockets
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Collections
Imports System.Globalization
Imports System.Configuration
Imports System.Xml
Imports System.IO
Imports System.Drawing.Printing
Imports Eneter.Messaging.MessagingSystems.MessagingSystemBase
Imports Eneter.Messaging.EndPoints.TypedMessages
Imports Eneter.Messaging.Infrastructure.ConnectionProvider
Imports Eneter.Messaging.MessagingSystems.SynchronousMessagingSystem
Imports Eneter.Messaging.MessagingSystems.TcpMessagingSystem
Imports Eneter.Messaging.Nodes.ChannelWrapper

Public Class MainPrinter
    Private scren As String
    Private screen_Renamed As Screen
    Public Shared tvTime As Integer
    Private counterVideo As Integer
    Private tmpVolumeVideo As Integer
    Public Shared strFileMedia As New List(Of String)()
    Private movieIndex As Integer = 0
    Public Shared BackGroundLeft, ScrenIndex As Integer
    Public Shared Reg As New RegAcces
    Public Delegate Sub RefreshPrinter()
#Region "Variable RText"
    Private tPos As Integer
    Private RunningText As String = "Coba"
    Private RtextArray() As String
    Public Shared rtextFont As New Font("Arial Rounded MT Bold ", 20, FontStyle.Bold)
    Public Shared rtextBrush As Brush = Brushes.Yellow
    Public Shared converterFont As TypeConverter = TypeDescriptor.GetConverter(GetType(Font))
    Public Shared converterBrush As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
    Public Shared rtextSpeed As Integer = 1
    Public Shared runningtextChange As Boolean = False
#End Region
#Region "Clock"
    Public Shared colorJam As Brush = Brushes.White
    Public Shared colorTanggal As Brush = Brushes.White
    Public Shared FontJam As New Font("Arial", 24, FontStyle.Bold)
    Public Shared FontTanggal As New Font("Arial", 10, FontStyle.Bold)
#End Region
#Region "TCPIP"
    Public Shared IPServer As String = "127.0.0.1"
    Public Shared PortServer As String = "8091"
    Public Shared SendData As IDuplexTypedMessageSender(Of DataOutput, DataInput)
    Public Shared PrintData As IDuplexTypedMessageSender(Of DataOutput, DataInput)
    Private myDuplexChannelWrapper As IDuplexChannelWrapper
    Public Shared anOutputChannel As IDuplexOutputChannel
    Public Shared anInternalMessaging As IMessagingSystemFactory = New SynchronousMessagingSystemFactory()
    Public Shared aChannelWrapperFactory As IChannelWrapperFactory = New ChannelWrapperFactory()
    Public Shared aConnectionProviderFactory As IConnectionProviderFactory = New ConnectionProviderFactory()
    Public Shared aTcpMessagingSystem As IMessagingSystemFactory = New TcpMessagingSystemFactory()
    Public Shared PrintName As String = ""
    Public Shared DelayTombol = 3
    Public Shared BatasAntrianBuka As String = "00:00:00"
    Public Shared BatasAntrianTutup As String = "00:23:00"
    Public PelayananTutup As Timer
#End Region
    Public Sub New()
        'If AlreadyRunning() Then
        '    MessageBox.Show( _
        '        "Printer is already running !!!", _
        '        "Printer !!!", _
        '        MessageBoxButtons.OK, _
        '        MessageBoxIcon.Exclamation)
        '    Me.Close()
        'End If
        IPServer = Interaction.GetSetting("AntPrinter", "Printer", "IPServer")
        ' BatasAntrianBuka = Interaction.GetSetting("AntPrinter", "Printer", "BatasBuka")
        'BatasAntrianTutup = Interaction.GetSetting("AntPrinter", "Printer", "BatasTutup")
        If IPServer = "" Then
            Dim IPSetting As New SettingPrinter()
            If IPSetting.ShowDialog() = DialogResult.OK Then
                IPServer = Interaction.GetSetting("AntPrinter", "Printer", "IPServer")
                BatasAntrianBuka = Interaction.GetSetting("AntPrinter", "Printer", "BatasBuka")
                BatasAntrianTutup = Interaction.GetSetting("AntPrinter", "Printer", "BatasTutup")
            End If
        End If
        ' This call is required by the designer.
        InitializeComponent()
        'AddHandler clientReceive.DataRecivedEvent, AddressOf OnDataReceive

        'Dim access As New DataAccess()
        '' If Not access.TableExist("tbUser") Then
        'access.CreateTableUser("tbUser")
        ' End If
        PrintSub()

        TransiveRecive()

    End Sub

    Private Sub MainPrinter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myDuplexChannelWrapper.DetachDuplexInputChannel()
    End Sub
    Private Sub MainPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartConect()
        tmPelayanan.Start()
    End Sub
#Region "Fungsi Pemanggil"
    Private Function AlreadyRunning() As Boolean
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName
        Me.Text = "[" & my_name & "]"
        Dim procs() As Process = Process.GetProcessesByName(my_name)
        If procs.Length = 1 Then Return False
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then Return True
        Next i
        Return False
    End Function
    Private Sub TextRunning()
        RunningText = Reg.ReadRegValue("AntPrinter", "Printer", "rText")
        If RunningText = "" Then
            Dim cf As New RunningText()
            If cf.ShowDialog() = DialogResult.OK Then
                If runningtextChange Then
                    RunningText = Reg.ReadRegValue("AntPrinter", "Printer", "rText")
                    runningtextChange = False
                End If
            End If
        End If
        Dim space As String = " "
        For sp As Integer = 0 To 49
            space &= " "
        Next sp
        RtextArray = RunningText.Split(New String() {vbCrLf}, StringSplitOptions.None)
        RunningText = ""
        Dim tj As Integer = RtextArray.Length
        Dim ti As Integer = 0
        For Each s As String In RtextArray
            RunningText &= s
            ti += 1
            If ti <> tj Then
                RunningText &= space
            End If
        Next s
    End Sub
    Public Sub PrintSub()
        tmDelay.Interval = 1000 * DelayTombol
        Dim tmpDelay As String = Interaction.GetSetting("AntPrinter", "Delay", "delayValue")
        If tmpDelay <> "" Then
            DelayTombol = Integer.Parse(tmpDelay)
        End If
        Try
            Dim pd As New PrintDialog()
            PrintName = Interaction.GetSetting("AntPrinter", "Printer", "Printername")
            If PrintName = "" Then
                pd.PrinterSettings = New PrinterSettings()
                If DialogResult.OK = pd.ShowDialog(Me) Then
                    PrintName = pd.PrinterSettings.PrinterName
                    Interaction.SaveSetting("AntPrinter", "Printer", "Printername", PrintName)
                End If
            End If
            Try
                '  Dim Logos As New UseLogo()
                ' Tikets.FileName = ra.ReadSubRegValue("AntPrinter", "Printer", "Tiket", "Logo")
                ' If Tikets.FileName = "" Then
                'Logos.Show()
                'End If
            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try

    End Sub
    Public Sub StartConect()
        anOutputChannel = aTcpMessagingSystem.CreateDuplexOutputChannel("tcp://" & IPServer & ":" & PortServer & "/")
        ''myDuplexChannelWrapper.AttachDuplexOutputChannel(anOutputChannel)
        AddHandler anOutputChannel.ConnectionOpened, AddressOf OnConnectionOpened
        AddHandler anOutputChannel.ConnectionClosed, AddressOf OnConnectionClosed
        Try
            ' Attach the output channel to the broker client to be able to send messages.
            myDuplexChannelWrapper.AttachDuplexOutputChannel(anOutputChannel)
        Catch
            'MessageBox.Show("Client Is Not Connect To Server " |  "", "Not Connected")
            MessageBox.Show("Server Not Active ! Cek Server", "PRINTER IS NOT CONNECT TO SERVER", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Public Sub TransiveRecive()
        myDuplexChannelWrapper = aChannelWrapperFactory.CreateDuplexChannelWrapper()
        ' To connect message senders and the wrapper with duplex channels we can use the following helper class.
        Dim aConnectionProvider As IConnectionProvider = aConnectionProviderFactory.CreateConnectionProvider(anInternalMessaging)
        ' Factory to create message senders.
        ' Sent messages will be serialized in Xml.
        Dim aCommandsFactory As IDuplexTypedMessagesFactory = New DuplexTypedMessagesFactory()
        ' Sender data
        SendData = aCommandsFactory.CreateDuplexTypedMessageSender(Of DataOutput, DataInput)()
        AddHandler SendData.ResponseReceived, AddressOf OnResultResponse
        aConnectionProvider.Connect(myDuplexChannelWrapper, SendData, "SendData")

        PrintData = aCommandsFactory.CreateDuplexTypedMessageSender(Of DataOutput, DataInput)()
        AddHandler PrintData.ResponseReceived, AddressOf OnResultResponse
        aConnectionProvider.Connect(myDuplexChannelWrapper, PrintData, "PrintData")

    End Sub
    Public Status As String
    Private Sub OnConnectionOpened(ByVal sender As Object, ByVal e As DuplexChannelEventArgs)
        DisplayConnectionStatus(True)
    End Sub
    ' Indicates the connection with the broker was closed.
    Private Sub OnConnectionClosed(ByVal sender As Object, ByVal e As DuplexChannelEventArgs)
        DisplayConnectionStatus(False)
    End Sub
    Private Sub DisplayConnectionStatus(ByVal isConnected As Boolean)
        Dim aStatus As String = ""
        If isConnected = True Then
            aStatus = "Connect"
            Status = aStatus
            tspConnect.Text = "Connect"
            tspConnect.ForeColor = Color.Blue
            Me.BeginInvoke(New RefreshPrinter(AddressOf StatusLabel))
            'pbConnect.BackgroundImage = My.Resources.ConectActive
        ElseIf isConnected = False Then
            aStatus = "Disconnect"
            Status = aStatus
            tspConnect.Text = "Disconnect"
            tspConnect.ForeColor = Color.Red
            Me.BeginInvoke(New RefreshPrinter(AddressOf StatusLabel))
            ' pbConnect.BackgroundImage = My.Resources.Conect
            MessageBox.Show("Server Not Active ! Cek Server", "Status Server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Me.BeginInvoke(New RefreshPbCounter(AddressOf InitLoginFormShow))
        End If
    End Sub
    Public Sub StatusLabel()
        tspConnect.Text = Status
    End Sub
    Public Sub SendRequestMessage(ByVal sender As IDuplexTypedMessageSender(Of DataOutput, DataInput), ByVal Client As String, ByVal Command As String, ByVal CounterName As String, ByVal Layanan As Integer, ByVal Counter As Integer, ByVal User As String, ByVal Password As String)
        Dim anInput As New DataInput()
        anInput.Command = Command
        anInput.Client = Client
        anInput.CounterName = CounterName
        anInput.Layanan = Layanan
        anInput.Counter = Counter
        anInput.User = User
        anInput.Password = Password
        sender.SendRequestMessage(anInput)
    End Sub
    Private Sub OnResultResponse(ByVal sender As Object, ByVal e As TypedResponseReceivedEventArgs(Of DataOutput))
        Dim NomorAntri As String
        Dim SisaNomor As String
        Dim Layanan As String
        Dim Pelayanan As String = "Setting Layanan"
        Dim Barcode As String
        Try
            If e.ResponseMessage.Admin Then
                If e.ResponseMessage.Command = "RequesNumber" Then
                    NomorAntri = e.ResponseMessage.Nomor
                    SisaNomor = e.ResponseMessage.SisaNomor
                    Layanan = e.ResponseMessage.Layanan
                    Pelayanan = e.ResponseMessage.LayananPrinter
                    Try
                        If Pelayanan Is Nothing Then
                            Pelayanan = "Setting Layanan"
                        Else
                            Pelayanan = e.ResponseMessage.LayananPrinter
                        End If
                    Catch ex As Exception

                    End Try

                    Barcode = e.ResponseMessage.DataBarcode
                    MessageBox.Show("Nomor : " & NomorAntri & "  " & "Sisa Nomor : " & SisaNomor & "  " & "Layanan : " & Layanan & "  " & "Barcode : " & Barcode & "  " & "Layanan Tujuan : " & Pelayanan, " Test ")
                    ' """" Print Tiket

                    'PrintTiket.NomorAntri = NomorAntri
                    'PrintTiket.Lay = Layanan - 1
                    'PrintTiket.Sisa = SisaNomor
                    'PrintTiket.Barcode = Barcode
                    'PrintTiket.PelayananAntri = Pelayanan
                    'PrintTiket.ShowDialog()
                End If
                StopTimer()
            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region
#Region "Fungsi Delay dan converting text"
    Private Sub delay_ms(ByVal d As Integer)
        Dim [end] As Date = Date.Now.AddMilliseconds(d)
        Do While Date.Now < [end]

        Loop
    End Sub
    Private Sub delay_us(ByVal d As Integer)
        Dim tempVar As Boolean = d > 0
        d -= 1
        Do While tempVar

            tempVar = d > 0
            d -= 1
        Loop
    End Sub
#End Region
    Private Sub ExitTSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTSM.Click
        Close()
    End Sub
    Private Sub SettingRunningTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If isAdmin Then
            Dim Running As New RunningText
            If Running.ShowDialog() = DialogResult.OK Then
                If runningtextChange Then
                    RunningText = Reg.ReadRegValue("AntPrinter", "Printer", "rText")
                    Dim space As String = " "
                    For sp As Integer = 0 To 49
                        space &= " "
                    Next sp
                    RtextArray = RunningText.Split(New String() {vbCrLf}, StringSplitOptions.None)
                    RunningText = ""
                    Dim tj As Integer = RtextArray.Length
                    Dim ti As Integer = 0
                    For Each s As String In RtextArray
                        RunningText &= s
                        ti += 1
                        If ti <> tj Then
                            RunningText &= space
                        End If
                    Next s
                    runningtextChange = False
                End If
            End If
        Else
            MessageBox.Show("Anda tidak memiliki otoritas" & vbCrLf & "untuk melakukan proses ini", "Information")
        End If

    End Sub
    Private Sub SettingTiketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingTiketToolStripMenuItem.Click
        If isAdmin Then
            Dim print As New Tiket()
            If print.ShowDialog() = DialogResult.OK Then
            End If
        Else
            MessageBox.Show("Anda tidak memiliki otoritas" & vbCrLf & "untuk melakukan proses ini", "Information")
        End If
    End Sub
    
    Private pbBtnAClik As Boolean
    Private pbBtnBClik As Boolean
    Private pbBtnCClik As Boolean
    Private pbBtnDClik As Boolean
    Private pbBtnEClik As Boolean
    Private pbBtnFClik As Boolean
    Private ctLayanan As Integer = 0
    Public Shared isLayananOk As Boolean = False
    Private Sub SettingSistemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingSistemToolStripMenuItem.Click
        If isAdmin Then
            Dim IPSeting As New Setting_Sistem()
            If IPSeting.ShowDialog() = DialogResult.OK Then
            End If
        Else
            MessageBox.Show("Anda tidak memiliki otoritas" & vbCrLf & "untuk melakukan proses ini", "Information")
        End If
    End Sub
    Private Sub SettingIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingIPToolStripMenuItem.Click
        ' If isAdmin Then
        Try
            Dim IPSeting As New SettingPrinter()
            If IPSeting.ShowDialog() = DialogResult.OK Then
            End If
        Catch ex As Exception

        End Try

        'Else
        ' MessageBox.Show("Anda tidak memiliki otoritas" & vbCrLf & "untuk melakukan proses ini", "Information")
        'End If
    End Sub
    Private Sub tmRespont_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmRespont.Tick
        tmRespont.Stop()
        MessageBox.Show("Please Check Connection", "")
    End Sub
    Friend Sub StopTimer()
        tmRespont.Stop()
    End Sub
    Private Sub RetrySendToServer()
        'clientSend = New Transceive(ServerIp, ServerPort)
        'clientReceive.Start()
        'tmRespont.Enabled = True
    End Sub
    Private Sub tmDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmDelay.Tick
        tmDelay.Stop()
    End Sub
    Public Shared timerValue As Integer = 1000
    Friend Sub SetTimer()
        tmDelay.Interval = timerValue
        tmRespont.Start()
        tmDelay.Start()
    End Sub
    Public isAdmin As Boolean
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        If Not isAdmin Then
            Dim login As New UserLogin()
            If login.ShowDialog() = DialogResult.OK Then
                isAdmin = True
                LoginToolStripMenuItem.Text = "Logout"
            Else
                isAdmin = False
            End If
        Else
            isAdmin = False
            LoginToolStripMenuItem.Text = "Login"
        End If
    End Sub

    Private Sub tspConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspConnect.Click
        Try
            StartConect()
        Catch ex As Exception
            ' MessageBox.Show("Server Not Active ! Cek Server", "Status Server")
        End Try
    End Sub
    Dim WaktuMenitHabis As Integer = 0
    Dim WaktuHoursHabis As Integer = 15
    Dim PopHide As Boolean = False
    Dim Notify As Boolean = False
    Dim hours, mins, seconds As Integer
    Dim setHours, setMins As Integer

    Private Sub tmPelayanan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmPelayanan.Tick
        tmPelayanan.Start()
        ShutdownAt()
    End Sub
    Private Sub ShutdownAt()
        Try
            Dim Times As String = Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
            WaktuMenitHabis = CInt(Interaction.GetSetting("AntPrinter", "Printer", "PelayananMinute"))
            WaktuHoursHabis = CInt(Interaction.GetSetting("AntPrinter", "Printer", "PelayananHours"))
            'special case of set min = 0 and one less is 59
            Dim HoursHabis As Integer
            Dim MinuteHabis As Integer
            Dim str As String
            Dim strArr() As String
            Dim count As Integer
            str = Times
            strArr = str.Split(":")
            For count = 0 To strArr.Length - 1
                HoursHabis = strArr(0)
                MinuteHabis = strArr(1)
                If WaktuHoursHabis <= HoursHabis Then
                    If WaktuMenitHabis < MinuteHabis Then
                        Dim warningTime As Integer
                        If MinuteHabis = 0 Then
                            warningTime = 59
                        Else
                            warningTime = MinuteHabis - 1
                        End If


                        If String.Compare(Now.Hour.ToString, HoursHabis) = 0 Then
                            If String.Compare(Now.Minute.ToString, warningTime.ToString) = 0 Then
                                Dim remain As Integer = 60 - Now.Second
                                If Notify = False Then
                                    Notify = True
                                End If
                            End If
                        End If

                        If String.Compare(Now.Hour.ToString, HoursHabis) = 0 Then
                            If String.Compare(Now.Minute.ToString, MinuteHabis) = 0 Then
                                Me.Show()
                                tmPelayanan.Stop()
                                Try
                                    

                                Catch ex As Exception

                                End Try
                            End If
                        End If
                    End If

                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            SendRequestMessage(SendData, "Printer", "RequesNumber", "Admin", 1, 1, "admin", "admin")
            SetTimer()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            SendRequestMessage(SendData, "Printer", "RequesNumber", "Admin", 2, 2, "admin", "admin")
            SetTimer()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            SendRequestMessage(SendData, "Printer", "RequesNumber", "Admin", 3, 3, "admin", "admin")
            SetTimer()
        Catch ex As Exception

        End Try
    End Sub
End Class