Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Collections
Imports System.ComponentModel
Imports Eneter.Messaging.EndPoints.TypedMessages
Imports Eneter.Messaging.Infrastructure.ConnectionProvider
Imports Eneter.Messaging.MessagingSystems.MessagingSystemBase
Imports Eneter.Messaging.MessagingSystems.SynchronousMessagingSystem
Imports Eneter.Messaging.MessagingSystems.TcpMessagingSystem
Imports Eneter.Messaging.Nodes.ChannelWrapper
Public Class Client
    Private Gap As Integer = 3
    Public Shared LayananTransfer As Integer = 6
    Private counterService As Integer
    Private ctLayanan As Integer = 0
    Private sudahReset As Boolean = False
    Public Shared NamaPort As String = "COM1"
    Private NewTotal As Boolean = False
    Public Shared AllowToEdit As Boolean = False
    Private WarnaTq As Brush = Brushes.White
    Private ResScren As String = "1024x768"
    Private Scren As Screen
    Public Shared PrunningtextChange As Boolean = False
    Private PtPos As Integer
    Private PrText As String = "Terus kanlah"
    Private PRtextArray() As String
    Public Shared PrtextFont As New Font("Segoe WP N", 8, FontStyle.Regular)
    Public Shared PrtextBrush As Brush = Brushes.Yellow
    Public Shared PconverterFont As TypeConverter = TypeDescriptor.GetConverter(GetType(Font))
    Public Shared PconverterBrush As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
    Public Shared PrtextSpeed As Integer = 1
#Region "GlobalVariable"
    ' Private ra As New RegAcces()
    Private btAtas, btBawah As String
    Private btsBawah, btsAtas As Integer
    Public Shared NamaLayanan() As String
    Public Shared SubLayanan() As String
    Private Delegate Sub IsicbHold(ByVal item() As String)
    Private Delegate Sub GantiLabel(ByVal s As String)
    Public Delegate Sub RefreshPbUser()
#End Region
#Region "Variable Geser Form"
    Private IsMouseDown As Boolean
    Private LastCursorPosition As Point
    Private sudahFinish As Boolean = True
    Private sudahTransfer As Boolean = False
    Private sudahPending As Boolean = False
    Private sudahAdvance As Boolean = False
    Private sudahPass As Boolean = False
#End Region
#Region "TCPIP"
    Public Shared IPServer As String = "127.0.0.1"
    Public Shared CounterName As String = "Teller 1"
    Public Shared isAdvance As Boolean = False
    Public Shared Counter As Integer = 1
    Public Shared IsConnect As Boolean = False
    Public Shared isLayananOk As Boolean = False
    Public Shared PortServer As String = "8091"
    Public Shared SendData As IDuplexTypedMessageSender(Of DataOutput, DataInput)
    Private myDuplexChannelWrapper As IDuplexChannelWrapper
    Public Shared anOutputChannel As IDuplexOutputChannel
    Public Shared anInternalMessaging As IMessagingSystemFactory = New SynchronousMessagingSystemFactory()
    Public Shared aChannelWrapperFactory As IChannelWrapperFactory = New ChannelWrapperFactory()
    Public Shared aConnectionProviderFactory As IConnectionProviderFactory = New ConnectionProviderFactory()
    Public Shared aTcpMessagingSystem As IMessagingSystemFactory = New TcpMessagingSystemFactory()
#End Region
#Region "DisplayAntrian"
    Public Shared TotalQueue As Integer ', TotalQueue1, TotalQueue2, dispLayanan, TotalHoldNumber As Integer
    Public Shared TotalHoldNumber As Integer
    Public Shared dispLayanan As Integer
    Public Shared CurrentDisplay As Integer
    Public Shared JumlahKedip As Integer = 0
    Public Shared Layanan As Integer = 1 ', Layanan1 As Integer = 1, Layanan2 As Integer = 2, Layanan3 As Integer = 3
    Public Delegate Sub RefreshPbCounter()
    Public Delegate Sub RefreshDisplay()
#End Region
#Region "Tombol"
    Private TombolAktif As Boolean = False
#End Region
    Public Sub New()
        Try
            InitializeComponent()
            InitNomorAntrian()
            InitTotalNumber()
            InitPendingQueue()
            InitPending()
            InitCall()
            InitCallPending()
            InitFinish()
            InitStart()
            InitRecall()
            InitTransfer()
            InitClock()
            InitClose()
            InitLogin()
            InitLogout()
            InitConfig()
            InitUser()
            TransiveRecive()
            InitConnect()
            InitLoginForm()
            lblServing.Top = 27
            lblServing.Left = 36
            lblServing.ForeColor = Color.Red
            lblServing.Text = "No Proses"
            lblLogin.Top = lblServing.Top - 15
            lblLogin.Left = 36
            lblLogin.AutoSize = True
            lblLogin.ForeColor = Color.BlueViolet
            lblLogin.Text = "No Acces"
            Dim ttLogin As New ToolTip()
            ttLogin.SetToolTip(pbLoginbtn, "Login")
            Dim ttLogOut As New ToolTip()
            ttLogOut.SetToolTip(pbLogoutbtn, "Logout")
            Dim ttConfig As New ToolTip()
            ttConfig.SetToolTip(pbConfigbtn, "Config")
            Dim ttClose As New ToolTip()
            ttConfig.SetToolTip(pbClosebtn, "Close")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Client_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myDuplexChannelWrapper.DetachDuplexInputChannel()
    End Sub
    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CekResolusion()
        StartConect()
        tmClock.Start()
        TotalQueue = 0
        CurrentDisplay = 0
        TotalHoldNumber = 0
        dispLayanan = 1
        SendRequestMessage(SendData, "RequesLayanan", CounterName, Layanan, Counter, LoginConfig.User, "")
        Try
            'Dim TmpComponent As String = Interaction.GetSetting("AntServer\Client", "Part", "Component")
            ' If TmpComponent = "" Then
            Dim cfg As New ConfigClient()
            AllowToEdit = True

            If cfg.ShowDialog() = DialogResult.OK Then
                Dim cc As New CounterComponent()
                'IPServer = cc.IP
                CounterName = cc.Nama
                Counter = cc.Counter
                delay_ms(100)
            End If
            AllowToEdit = False
            
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Dim tmpNamaPort As String = Interaction.GetSetting("AntServer\Client", "Part", "SerialPort")
        Try
            If tmpNamaPort <> "" Then
                NamaPort = tmpNamaPort
            End If
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
            End If
            SerialPort1.PortName = NamaPort
        Catch
        End Try
        Dim tmpLayananTransfer As String = Interaction.GetSetting("AntServer/Client", "Transfer", "List")
        If tmpLayananTransfer <> "" Then
            LayananTransfer = Integer.Parse(tmpLayananTransfer)
        Else
            Interaction.SaveSetting("AntServer\Client", "Transfer", "List", LayananTransfer.ToString())
        End If
        LayananTransfer = 100
    End Sub
    Public Sub StartConect()
        anOutputChannel = aTcpMessagingSystem.CreateDuplexOutputChannel("tcp://127.0.0.1" & ":" & PortServer & "/")
        ''myDuplexChannelWrapper.AttachDuplexOutputChannel(anOutputChannel)
        AddHandler anOutputChannel.ConnectionOpened, AddressOf OnConnectionOpened
        AddHandler anOutputChannel.ConnectionClosed, AddressOf OnConnectionClosed
        Try
            ' Attach the output channel to the broker client to be able to send messages.
            myDuplexChannelWrapper.AttachDuplexOutputChannel(anOutputChannel)
        Catch
            'MessageBox.Show("Client Is Not Connect To Server " |  "", "Not Connected")
            MessageBox.Show("Server Not Active ! Cek Server", "CLIENT IS NOT CONNECT TO SERVER", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            statuslbl.ForeColor = Color.Blue
            Me.BeginInvoke(New RefreshPbCounter(AddressOf StatusLabel))
            pbConnect.BackgroundImage = My.Resources.ConectActive
        ElseIf isConnected = False Then
            aStatus = "Disconnect"
            Status = aStatus
            statuslbl.ForeColor = Color.Red
            Me.BeginInvoke(New RefreshPbCounter(AddressOf StatusLabel))
            pbConnect.BackgroundImage = My.Resources.Conect
            MessageBox.Show("Server Not Active ! Cek Server", "Status Server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.BeginInvoke(New RefreshPbCounter(AddressOf InitLoginFormShow))
        End If
    End Sub
    Public Sub StatusLabel()
        Me.Text = Status
        statuslbl.Text = Status
    End Sub
    Private Sub CekResolusion()
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Scren = Screen.PrimaryScreen
        Me.StartPosition = FormStartPosition.Manual
        ResScren = Scren.Bounds.Width.ToString() & "x" & Scren.Bounds.Height.ToString()
        If ResScren = "1360x768" Or ResScren = "1366x768" Then
            Me.BackgroundImage = My.Resources.Background
            Me.WindowState = FormWindowState.Normal
            Me.Width = 400
            Me.Height = 234
            Dim tmpTop As String = Interaction.GetSetting("AntServer\Client", "Pos", "Top")
            If tmpTop <> "" Then
                Me.Top = Integer.Parse(tmpTop)
            End If
            Dim tmpLeft As String = Interaction.GetSetting("AntServer\Client", "Pos", "Left")
            If tmpLeft <> "" Then
                Me.Left = Integer.Parse(tmpLeft)
            End If
        ElseIf ResScren = "1280x768" Then
            Me.BackgroundImage = My.Resources.Background
            Me.WindowState = FormWindowState.Normal
            Me.Width = 175
            Me.Height = 300
            Dim tmpTop As String = Interaction.GetSetting("AntServer\Client", "Pos", "Top")
            If tmpTop <> "" Then
                Me.Top = Integer.Parse(tmpTop)
            End If
            Dim tmpLeft As String = Interaction.GetSetting("AntServer\Client", "Pos", "Left")
            If tmpLeft <> "" Then
                Me.Left = Integer.Parse(tmpLeft)
            End If
        ElseIf ResScren = "1280x720" Then
            Me.BackgroundImage = My.Resources.Background
            Me.WindowState = FormWindowState.Normal
            Me.Width = 175
            Me.Height = 300
            Dim tmpTop As String = Interaction.GetSetting("AntServer\Client", "Pos", "Top")
            If tmpTop <> "" Then
                Me.Top = Integer.Parse(tmpTop)
            End If
            Dim tmpLeft As String = Interaction.GetSetting("AntServer\Client", "Pos", "Left")
            If tmpLeft <> "" Then
                Me.Left = Integer.Parse(tmpLeft)
            End If
        ElseIf ResScren = "1024x768" Then
            Me.BackgroundImage = My.Resources.Background
            Me.WindowState = FormWindowState.Normal
            Me.Width = 175
            Me.Height = 300
            Dim tmpTop As String = Interaction.GetSetting("AntServer\Client", "Pos", "Top")
            If tmpTop <> "" Then
                Me.Top = Integer.Parse(tmpTop)
            End If
            Dim tmpLeft As String = Interaction.GetSetting("AntServer\Client", "Pos", "Left")
            If tmpLeft <> "" Then
                Me.Left = Integer.Parse(tmpLeft)
            End If
        End If
    End Sub
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
    Private Sub delay_ms(ByVal t As Integer)
        Dim [end] As Date = Date.Now.AddMilliseconds(t)
        Do While Date.Now < [end]
        Loop
    End Sub
    Private Sub InvalidateCQ()
        pbNomorAntrian.Invalidate()
    End Sub
    Private Sub InvalidateHQ()
        If NewTotal Then
            WarnaTq = Brushes.Black
            Me.TopMost = True
            tmStart.Start()
        End If
        pbHoldNumber.Invalidate()
    End Sub
    Private Sub InvalidateTQ()
        If NewTotal Then
            WarnaTq = Brushes.Black
            Me.TopMost = True
            tmStart.Start()
        End If
        pbTotalNumber.Invalidate()
    End Sub
    Private Sub InvalidateUser()
        pbUser.BackgroundImage = My.Resources.User
        pbUser.Invalidate()
    End Sub
    Private Sub InvalidateLogUser()
        pbUser.BackgroundImage = My.Resources.UserLog
        pbUser.Invalidate()
    End Sub
    Private Sub UbahLogin(ByVal s As String)
        lblLogin.Text = s
        lblLogin.AutoSize = True
    End Sub
    Private Sub UbahLogout(ByVal s As String)
        lblLogin.Text = s
    End Sub
    Private Sub InitCbSub(ByVal s As String)
        cbSub.Text = s.Trim()
    End Sub
    Private Sub ClearcbHold()
        cbPending.Items.Clear()
        cbPending.Text = "" & "Number list Pending"
        Listnumber.Items.Clear()
        Listnumber.Text = "" & "Number list Pending"
    End Sub
    Private Sub SetcbHold(ByVal isi() As String)
        cbPending.Items.AddRange(isi)
        Listnumber.Items.AddRange(isi)
    End Sub
    Private Sub SetcbSub(ByVal isi() As String)
        ListSubLayanan.Items.AddRange(isi)
    End Sub
    Private Sub ClearcbSub()
        cbSub.Items.Clear()
        cbSub.Text = ""
        ListSubLayanan.Items.Clear()
        ListSubLayanan.Text = ""
    End Sub
    Private Function ConvertNomor(ByVal _Layanan As Integer, ByVal _Nomor As Integer) As String
        Dim Strip As String = " "
        Return (Convert.ToChar(&H40 + _Layanan).ToString() & Strip & String.Format("{0:000}", _Nomor))
    End Function
    Public Function ConvertJamToInt(ByVal var As String) As Integer
        Dim result As Integer = 0
        Try
            var = var.Replace(" ", "")
            Dim tmpAngka() As String = var.Split(New String() {":"}, StringSplitOptions.None)
            result = (Integer.Parse(tmpAngka(0)) * 3600) + (Integer.Parse(tmpAngka(1)) * 60) + Integer.Parse(tmpAngka(2))
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        Return result
    End Function
    Public Sub SendRequestMessage(ByVal sender As IDuplexTypedMessageSender(Of DataOutput, DataInput), ByVal Command As String, ByVal CounterName As String, ByVal Layanan As Integer, ByVal Counter As Integer, ByVal User As String, ByVal Password As String)
        Dim anInput As New DataInput()
        anInput.Command = Command
        anInput.CounterName = CounterName
        anInput.Layanan = Layanan
        anInput.Counter = Counter
        anInput.User = User
        anInput.Password = Password
        sender.SendRequestMessage(anInput)
    End Sub
    Public Sub SendRequestMessage(ByVal sender As IDuplexTypedMessageSender(Of DataOutput, DataInput), ByVal Command As String, ByVal CounterName As String, ByVal Layanan As Integer, ByVal Counter As Integer, ByVal User As String, ByVal Password As String, ByVal Nomor As Integer, ByVal LayananTujuan As Integer)
        Dim anInput As New DataInput()
        anInput.Command = Command
        anInput.CounterName = CounterName
        anInput.Layanan = Layanan
        anInput.Counter = Counter
        anInput.User = User
        anInput.Password = Password
        anInput.Nomor = Nomor
        anInput.LayananTujuan = LayananTujuan
        sender.SendRequestMessage(anInput)
    End Sub
    Public Sub SendRequestMessage(ByVal sender As IDuplexTypedMessageSender(Of DataOutput, DataInput), ByVal Command As String, ByVal CounterName As String, ByVal Layanan As Integer, ByVal Counter As Integer, ByVal User As String, ByVal Password As String, ByVal Nomor As Integer, ByVal LayananTujuan As Integer, ByVal StarService As String)
        Dim anInput As New DataInput()
        anInput.Command = Command
        anInput.CounterName = CounterName
        anInput.Layanan = Layanan
        anInput.Counter = Counter
        anInput.User = User
        anInput.Password = Password
        anInput.Nomor = Nomor
        anInput.LayananTujuan = LayananTujuan
        anInput.StarService = StarService
        sender.SendRequestMessage(anInput)
    End Sub
    Private Sub OnResultResponse(ByVal sender As Object, ByVal e As TypedResponseReceivedEventArgs(Of DataOutput))

        If e.ResponseMessage.Admin Then
            If e.ResponseMessage.Command = "Login" Then
                If e.ResponseMessage.Confrim = "OK" Then
                    Dim cc As New CounterComponent()
                    Dim gl As New GantiLabel(AddressOf UbahLogin)
                    Me.Invoke(gl, New Object() {cc.Nama})
                    IsConnect = True
                    Me.BeginInvoke(New RefreshPbUser(AddressOf InvalidateUser))
                    MessageBox.Show("Counter Connect ke Server")
                    Me.BeginInvoke(New RefreshPbCounter(AddressOf InitLoginFormHide))
                    ' Dim tmpSVC As Integer = e.ResponseMessage.Layanan
                    'If tmpSVC = Layanan Then
                    TotalQueue = e.ResponseMessage.SisaNomor
                    ' End If
                    'MessageBox.Show(tmpSVC, "Batas")
                    ' Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateTQ))
                    Try
                        Me.BeginInvoke(New RefreshPbCounter(AddressOf ClearcbSub))
                        NamaLayanan = e.ResponseMessage.NamaLayanan.ToArray()
                        SubLayanan = e.ResponseMessage.SubLayanan.ToArray()
                        If SubLayanan IsNot Nothing Then
                            Dim test As New IsicbHold(AddressOf SetcbSub)
                            Me.Invoke(test, New Object() {e.ResponseMessage.SubLayanan.ToArray()})
                            ' Dim test As New IsicbHold(AddressOf SetcbSub)
                            'Me.Invoke(test, SubLayanan(Layanan - 1).Split(New String() {vbCrLf}, StringSplitOptions.RemoveEmptyEntries))

                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString())

                    End Try
                    Me.BeginInvoke(New RefreshPbCounter(AddressOf ClearcbHold))
                    If e.ResponseMessage.Hold IsNot Nothing Then
                        Try
                            Dim tmpSVC As Integer = e.ResponseMessage.Counter
                            If tmpSVC = cc.Counter Then
                                Dim test As New IsicbHold(AddressOf SetcbHold)
                                Me.Invoke(test, New Object() {e.ResponseMessage.Hold.ToArray()})
                                TotalHoldNumber = e.ResponseMessage.Hold.Count
                                Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateHQ))
                            End If
                            'Dim test As New IsicbHold(AddressOf SetcbHold)
                            'Me.Invoke(test, New Object() {e.ResponseMessage.Hold.ToArray()})
                            'TotalHoldNumber = e.ResponseMessage.Hold.Count
                            'Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateHQ))
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString())
                        End Try
                    Else
                        TotalHoldNumber = 0
                        Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateHQ))
                    End If
                    If Layanan = LayananTransfer Then
                        'Me.BeginInvoke(New RefreshPbCounter(AddressOf ClearcbTransfer))
                        'If e.ResponseMessage.Skip IsNot Nothing Then
                        '    Try
                        '        Dim test As New IsicbHold(AddressOf SetcbTransfer)
                        '        Me.Invoke(test, New Object() {e.ResponseMessage.Skip.ToArray()})

                        '    Catch ex As Exception
                        '        MessageBox.Show(ex.ToString())
                        '    End Try
                        'End If
                    End If
                    Try
                        btBawah = e.ResponseMessage.BatasBawah
                        btAtas = e.ResponseMessage.BatasAtas
                        '  btsBawah = ConvertJamToInt(e.ResponseMessage.BatasBawah)
                        '   btsAtas = ConvertJamToInt(e.ResponseMessage.BatasAtas)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString(), "Batas")
                    End Try

                Else
                    MessageBox.Show(e.ResponseMessage.Confrim, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.BeginInvoke(New RefreshPbCounter(AddressOf InitLoginFormShow))
                End If
            ElseIf e.ResponseMessage.Command = "Logout" Then
                IsConnect = False
                Dim gl As New GantiLabel(AddressOf UbahLogout)
                Me.BeginInvoke(New RefreshPbUser(AddressOf InvalidateLogUser))
                Me.Invoke(gl, New Object() {"Logout"})
                Me.BeginInvoke(New RefreshPbCounter(AddressOf InitFlag))
                Me.BeginInvoke(New RefreshPbCounter(AddressOf AllEnable))
                MessageBox.Show("Server Closed")
            ElseIf e.ResponseMessage.Command = "RequesLayanan" Then
                Try
                    NamaLayanan = e.ResponseMessage.NamaLayanan.ToArray()
                    isLayananOk = True
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Else
                If e.ResponseMessage.Command = "Call" Then
                    If e.ResponseMessage.Nomor > 0 Then
                        dispLayanan = e.ResponseMessage.Layanan
                        CurrentDisplay = e.ResponseMessage.Nomor
                        Try
                            btBawah = e.ResponseMessage.BatasBawah
                            btAtas = e.ResponseMessage.BatasAtas
                            ' btsBawah = ConvertJamToInt(e.ResponseMessage.BatasBawah)
                            ' btsAtas = ConvertJamToInt(e.ResponseMessage.BatasAtas)
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString())
                        End Try
                    End If
                    Me.BeginInvoke(New RefreshPbCounter(AddressOf SetKedip))
                    Me.BeginInvoke(New RefreshPbCounter(AddressOf SendDataToDisplay))
                    If e.ResponseMessage.StarService IsNot Nothing Then
                        Dim gl As New GantiLabel(AddressOf InitCbSub)
                        Me.Invoke(gl, New Object() {e.ResponseMessage.StarService.Trim()})
                    End If
                    delay_ms(10000)
                    Me.BeginInvoke(New RefreshPbCounter(AddressOf AllEnable))
                ElseIf e.ResponseMessage.Command = "Total" Then
                    Dim tmpSVC As Integer = e.ResponseMessage.Layanan
                    If tmpSVC = Layanan Then
                        TotalQueue = e.ResponseMessage.SisaNomor
                        Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateTQ))
                        '   MessageBox.Show(Layanan, "layanan")
                        'ElseIf tmpSVC = Layanan2 Then
                        '    TotalQueue1 = e.ResponseMessage.SisaNomor
                        'ElseIf tmpSVC = Layanan3 Then
                        '    TotalQueue2 = e.ResponseMessage.SisaNomor
                    End If
                    ' TotalQueue = e.ResponseMessage.SisaNomor

                    NewTotal = True

                    If Layanan = LayananTransfer Then
                        'Me.BeginInvoke(New RefreshPbCounter(AddressOf ClearcbTransfer))
                        'If e.ResponseMessage.Hold IsNot Nothing Then
                        '    Try
                        '        Dim test As New IsicbHold(AddressOf SetcbTransfer)
                        '        Me.Invoke(test, New Object() {e.ResponseMessage.Hold.ToArray()})

                        '    Catch ex As Exception
                        '        MessageBox.Show(ex.ToString())
                        '    End Try
                        'End If
                    End If
                ElseIf e.ResponseMessage.Command = "Store" OrElse e.ResponseMessage.Command = "Hold" OrElse e.ResponseMessage.Command = "CallStore" OrElse e.ResponseMessage.Command = "CallHold" Then
                    Me.BeginInvoke(New RefreshPbCounter(AddressOf ClearcbHold))
                    If e.ResponseMessage.Hold IsNot Nothing Then
                        Dim cc As New CounterComponent()
                        Dim test As New IsicbHold(AddressOf SetcbHold)
                        Me.Invoke(test, New Object() {e.ResponseMessage.Hold.ToArray()})
                        Dim tmpSVC As Integer = e.ResponseMessage.Counter
                        If tmpSVC = cc.Counter Then
                            TotalHoldNumber = e.ResponseMessage.Hold.Count
                            Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateHQ))
                        End If

                    Else
                        TotalHoldNumber = 0
                        Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateHQ))
                    End If
                ElseIf e.ResponseMessage.Command = "RequesNum" Then
                    Dim tmpSVC As Integer = e.ResponseMessage.Layanan
                    If tmpSVC = Layanan Then
                        TotalQueue = e.ResponseMessage.SisaNomor
                        Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateTQ))
                    End If

                    '  MessageBox.Show("Nomor Bertambah" & vbLf & (CChar(ChrW(&H40 + CInt(Fix(data_Renamed.HashData("Layanan")))))).ToString() & " " & (CInt(Fix(data_Renamed.HashData("Nomor")))).ToString(), "Info")
                Else
                    If e.ResponseMessage.Confrim = "Transfer" OrElse e.ResponseMessage.Confrim = "Store" OrElse e.ResponseMessage.Confrim = "Empty" Then
                        If e.ResponseMessage.Confrim = "Empty" Then
                            Dim tmpSVC As Integer = e.ResponseMessage.Layanan
                            If tmpSVC = Layanan Then
                                TotalQueue = e.ResponseMessage.SisaNomor
                                Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateTQ))
                            End If

                        End If
                        TombolAktif = False
                        Me.BeginInvoke(New RefreshPbCounter(AddressOf InitFlag))
                    End If
                End If
            End If
        End If
    End Sub
    Private CallClick As Boolean
    Private RecallClick As Boolean
    Private CallPendingClick As Boolean
    Private TransferClick As Boolean
    Private PendingClicked As Boolean
    Private Sub AllDisable()
        pbCallbtn.Enabled = False
        pbCallPendingbtn.Enabled = False
        pbTransferbtn.Enabled = False
        pbPendingbtn.Enabled = False
        pbStartbtn.Enabled = False
        pbRecallbtn.Enabled = False
        pbLoginbtn.Enabled = False
        pbLogoutbtn.Enabled = False
        pbFinishbtn.Enabled = False
        cbSub.Enabled = False
        cbPending.Enabled = False
    End Sub
    Private Sub AllDisableStar()
        pbCallbtn.Enabled = False
        pbCallPendingbtn.Enabled = False
        pbTransferbtn.Enabled = False
        pbPendingbtn.Enabled = False
        pbStartbtn.Enabled = False
        pbRecallbtn.Enabled = False
        pbLoginbtn.Enabled = False
        pbLogoutbtn.Enabled = False
        cbSub.Enabled = False
        cbPending.Enabled = False
    End Sub
    Private Sub AllEnable()
        pbCallbtn.Enabled = True
        pbCallPendingbtn.Enabled = True
        pbTransferbtn.Enabled = True
        pbPendingbtn.Enabled = True
        pbStartbtn.Enabled = True
        pbRecallbtn.Enabled = True
        pbLoginbtn.Enabled = True
        pbLogoutbtn.Enabled = True
        pbFinishbtn.Enabled = True
        cbSub.Enabled = True
        cbPending.Enabled = True
        InitStart()
    End Sub
    Public Sub Panggilpb()
        InitCall()
        InitPending()
        InitCallPending()
        InitRecall()
        InitTransfer()
        InitLogin()
        InitLogout()
        InitConfig()
        InitStart()
        InitFinish()
        InitTotalNumber()
        InitPendingQueue()
        InitClock()
        InitNomorAntrian()
        'cbSub.Hide()
        InitClose()
        cbPending.Left = 164
        cbPending.Top = 340
        cbPending.Width = 162
        cbSub.Left = 12
        cbSub.Top = 278
        cbSub.Width = 323

    End Sub
    Public Sub InitFlag()
        TombolAktif = False
        CallClick = False
        CallPendingClick = False
        TransferClick = False
        RecallClick = False
        InitRecall()
        InitCallPending()
        InitTransfer()
        InitCall()
        sudahReset = True
    End Sub
    Private Sub InitLoginForm()
        pbBtnLogin.BackgroundImage = My.Resources.BtnLogin
        pbBtnLogin.Width = pbBtnLogin.BackgroundImage.Width
        pbBtnLogin.Height = pbBtnLogin.BackgroundImage.Height
        pbBtnLogin.Left = 188
        pbBtnLogin.Top = 158
        pbLoginClose.BackgroundImage = My.Resources.BtnLoginClose
        pbLoginClose.Width = pbLoginClose.BackgroundImage.Width
        pbLoginClose.Height = pbLoginClose.BackgroundImage.Height
        pbLoginClose.Left = 279
        pbLoginClose.Top = 158
        pbLogin.BackgroundImage = My.Resources.LoginForm
        pbLogin.Width = pbLogin.BackgroundImage.Width
        pbLogin.Height = pbLogin.BackgroundImage.Height
        pbLogin.Left = 1
        pbLogin.Top = 49
        txtPassword.BackColor = Color.Azure
        txtPassword.Font = New Font("Times New Roman", 13, FontStyle.Bold)
        txtPassword.Width = 215
        txtPassword.Left = 141
        txtPassword.Top = 118
        txtUser.BackColor = Color.Azure
        txtUser.Font = New Font("Times New Roman", 13, FontStyle.Bold)
        txtUser.Width = 215
        txtUser.Left = 141
        txtUser.Top = 78
    End Sub
    Private Sub InitLoginFormHide()
        pbBtnLogin.Hide()
        pbLoginClose.Hide()
        pbLogin.Hide()
        txtPassword.Hide()
        txtUser.Hide()
    End Sub
    Private Sub InitLoginFormShow()
        pbBtnLogin.Show()
        pbLoginClose.Show()
        pbLogin.Show()
        txtPassword.Show()
        txtUser.Show()
    End Sub
    Public Shared User, Password As String
    Private Sub pbBtnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbBtnLogin.Click
        If (txtPassword.Text <> "") AndAlso (txtUser.Text <> "") Then
            User = txtUser.Text.Trim()
            Password = txtPassword.Text.Trim()
            Try
                If Layanan = 0 Then
                    Layanan = 1
                End If
                SendRequestMessage(SendData, "Login", CounterName, Layanan, Counter, User, Password)
                Try
                    'InitLoginFormHide()
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try

        Else
            MessageBox.Show("Place Username and Password data content")
        End If
        txtPassword.Clear()
        txtUser.Clear()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(13) Then
            If (txtPassword.Text <> "") AndAlso (txtUser.Text <> "") Then
                User = txtUser.Text.Trim()
                Password = txtPassword.Text.Trim()
                Me.DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show("Place Username and Password data content")
            End If
            txtPassword.Clear()
            txtUser.Clear()
        End If
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = ChrW(13) Then
            If (txtPassword.Text <> "") AndAlso (txtUser.Text <> "") Then
                User = txtUser.Text.Trim()
                Password = txtPassword.Text.Trim()
                Me.DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show("Place Username and Password data content")
            End If
            txtPassword.Clear()
            txtUser.Clear()
        End If
    End Sub

    Private Sub pbBtnLogin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbBtnLogin.MouseHover
        pbBtnLogin.BackgroundImage = My.Resources.BtnLoginActive
    End Sub

    Private Sub pbBtnLogin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbBtnLogin.MouseLeave
        pbBtnLogin.BackgroundImage = My.Resources.BtnLogin
    End Sub

    Private Sub pbLoginClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbLoginClose.Click
        If IsConnect Then
            Try
                SendRequestMessage(SendData, "Logout", CounterName, Layanan, Counter, LoginConfig.User, "")
                IsConnect = False
                InitFlag()
                AllEnable()
            Catch
            End Try
        End If
        Close()
    End Sub

    Private Sub pbLoginClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbLoginClose.MouseHover
        pbLoginClose.BackgroundImage = My.Resources.BtnLoginCloseActive
    End Sub

    Private Sub pbLoginClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbLoginClose.MouseLeave
        pbLoginClose.BackgroundImage = My.Resources.BtnLoginClose
    End Sub
    Private Sub InitConnect()
        pbConnect.Left = 371
        pbConnect.Top = 206
        pbConnect.Width = 25
        pbConnect.Height = 25
        pbConnect.BackgroundImage = My.Resources.Conect
        statuslbl.Left = 295
        statuslbl.Top = 215
        statuslbl.ForeColor = Color.Red
    End Sub
    Private Sub pbConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbConnect.Click
        Try
            StartConect()
        Catch ex As Exception
            ' MessageBox.Show("Server Not Active ! Cek Server", "Status Server")
        End Try
    End Sub
    Private Sub InitCall()
        pbCallbtn.Left = 206
        pbCallbtn.Top = 49
        pbCallbtn.Width = 96
        pbCallbtn.Height = 36
        pbCallbtn.BackgroundImage = My.Resources._Call
    End Sub
    Private Sub pbCallbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCallbtn.Click
        If IsConnect AndAlso ((Not TombolAktif)) Then
            Try
                lblServing.Text = "Calling"
                CallClick = True
                Dim cc As New CounterComponent()
                'IPServer = cc.IP
                CounterName = cc.Nama
                Counter = cc.Counter
                SendRequestMessage(SendData, "Call", CounterName, Layanan, Counter, "", "")
                TombolAktif = True
                sudahTransfer = False
                sudahPending = False
                sudahPass = False
                sudahAdvance = False
                AllDisable()
            Catch
                InitFlag()
                TombolAktif = False
                sudahTransfer = False
                sudahPending = False
                sudahPass = False
                sudahAdvance = False
            End Try
        End If
    End Sub
    Private Sub pbCallbtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCallbtn.MouseHover
        pbCallbtn.BackgroundImage = My.Resources.CallActive
    End Sub
    Private Sub pbCallbtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCallbtn.MouseLeave
        If Not CallClick Then
            InitCall()
        End If
    End Sub
    Private Sub InitRecall()
        pbRecallbtn.Left = 206
        pbRecallbtn.Top = 86
        pbRecallbtn.Width = 96
        pbRecallbtn.Height = 36
        pbRecallbtn.BackgroundImage = My.Resources.Recall
    End Sub
    Private Sub pbRecallbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbRecallbtn.Click
        If IsConnect AndAlso ((Not TombolAktif)) AndAlso ((Not sudahAdvance)) AndAlso ((Not sudahPass)) Then
            Try
                lblServing.Text = "Recall"
                RecallClick = True
                Dim cc As New CounterComponent()
                'IPServer = cc.IP
                CounterName = cc.Nama
                Counter = cc.Counter
                SendRequestMessage(SendData, "Recall", CounterName, Layanan, Counter, "", "")
                TombolAktif = True
                AllDisable()
            Catch
                InitFlag()
                TombolAktif = False
            End Try
        End If
    End Sub
    Private Sub pbRecallbtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbRecallbtn.MouseHover
        pbRecallbtn.BackgroundImage = My.Resources.RecallActive
    End Sub
    Private Sub pbRecallbtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbRecallbtn.MouseLeave
        If Not RecallClick Then
            InitRecall()
        End If
    End Sub
    Private Sub InitCallPending()
        pbCallPendingbtn.Left = 206
        pbCallPendingbtn.Top = 160
        pbCallPendingbtn.Width = 96
        pbCallPendingbtn.Height = 36
        pbCallPendingbtn.BackgroundImage = My.Resources.CallPending
    End Sub
    Private Sub pbCallPendingbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCallPendingbtn.Click
        If IsConnect AndAlso ((Not TombolAktif)) Then
            If IsConnect Then
                InitListPending()
            End If
        End If
    End Sub
    Private Sub pbCallPendingbtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCallPendingbtn.MouseHover
        pbCallPendingbtn.BackgroundImage = My.Resources.CallPendingActive
    End Sub
    Private Sub pbCallPendingbtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCallPendingbtn.MouseLeave
        pbCallPendingbtn.BackgroundImage = My.Resources.CallPending
        'If Not CallPendingClick Then
        '    InitCallPending()
        'End If
    End Sub
    Private Sub InitPending()
        pbPendingbtn.Left = 206
        pbPendingbtn.Top = 123
        pbPendingbtn.Width = 96
        pbPendingbtn.Height = 36
        pbPendingbtn.BackgroundImage = My.Resources.Pending
    End Sub
    Private Sub pbPendingbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbPendingbtn.Click
        If (IsConnect) AndAlso ((Not sudahTransfer)) AndAlso ((Not sudahPending)) AndAlso ((Not sudahPass)) AndAlso ((Not sudahAdvance)) Then
            Try
                lblServing.Text = "Pending Number"
                sudahPending = True
                Dim cc As New CounterComponent()
                'IPServer = cc.IP
                CounterName = cc.Nama
                Counter = cc.Counter
                SendRequestMessage(SendData, "Hold", CounterName, Layanan, Counter, "", "")
            Catch
                InitFlag()
            End Try
        End If
    End Sub
    Private Sub pbPendingbtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPendingbtn.MouseHover
        pbPendingbtn.BackgroundImage = My.Resources.PendingActive
    End Sub
    Private Sub pbPendingbtn_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbPendingbtn.MouseLeave
        InitPending()
    End Sub
    Private Sub InitTransfer()
        pbTransferbtn.Left = 303
        pbTransferbtn.Top = 49
        pbTransferbtn.Width = 96
        pbTransferbtn.Height = 36
        pbTransferbtn.BackgroundImage = My.Resources.Transfer
    End Sub
    Private Sub pbTransferbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbTransferbtn.Click
        If IsConnect AndAlso ((Not TombolAktif)) AndAlso ((Not sudahTransfer)) AndAlso ((Not sudahPass)) AndAlso ((Not sudahAdvance)) Then
            Try
                Dim rtc As New Transfer()
                If rtc.ShowDialog() = DialogResult.OK Then
                    Try
                        lblServing.Text = "Transfer"
                        TransferClick = True
                        Dim rndtr As New RandomTransferValue()
                        Dim cc As New CounterComponent()
                        'IPServer = cc.IP
                        CounterName = cc.Nama
                        Counter = cc.Counter
                        SendRequestMessage(SendData, "Transfer", CounterName, Layanan, Counter, "", "", rndtr.Nomor, rndtr.Service)
                        TombolAktif = True
                        sudahTransfer = True
                    Catch
                        InitFlag()
                        TombolAktif = False
                        sudahPending = False
                        sudahAdvance = False
                        sudahPass = False
                        sudahTransfer = False
                    End Try
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub pbTransferbtn_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pbTransferbtn.MouseHover
        pbTransferbtn.BackgroundImage = My.Resources.TransferActive
    End Sub
    Private Sub pbTransfer_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbTransferbtn.MouseLeave
        If Not TransferClick Then
            InitTransfer()
        End If
    End Sub
    Private Sub InitStart()
        pbStartbtn.Left = 303
        pbStartbtn.Top = 86
        pbStartbtn.Width = 96
        pbStartbtn.Height = 36
        pbStartbtn.BackgroundImage = My.Resources.Start
    End Sub
    Private Sub pbStartbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbStartbtn.Click
        If (IsConnect) AndAlso ((Not sudahTransfer)) AndAlso ((Not sudahPending)) AndAlso ((Not sudahPass)) Then
            InitListLayanan()
        End If
    End Sub
    Private Sub pbStartbtn_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pbStartbtn.MouseHover
        pbStartbtn.BackgroundImage = My.Resources.StartActive
    End Sub
    Private Sub pbStart_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbStartbtn.MouseLeave
        pbStartbtn.BackgroundImage = My.Resources.Start
    End Sub
    Private Sub InitFinish()
        pbFinishbtn.Left = 303
        pbFinishbtn.Top = 123
        pbFinishbtn.Width = 96
        pbFinishbtn.Height = 36
        pbFinishbtn.BackgroundImage = My.Resources.Finish
    End Sub
    Private Sub pbFinishbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbFinishbtn.Click
        If IsConnect AndAlso ((Not sudahFinish)) Then
            lblServing.Text = "Finish Report"
            Dim cc As New CounterComponent()
            'IPServer = cc.IP
            CounterName = cc.Nama
            Counter = cc.Counter
            SendRequestMessage(SendData, "Finish", CounterName, Layanan, Counter, "", "")
            AllEnable()
            tmService.Stop()
        End If
    End Sub
    Private Sub pbFinishbtn_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pbFinishbtn.MouseHover
        pbFinishbtn.BackgroundImage = My.Resources.FinishActive
    End Sub
    Private Sub pbFinishbtn_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbFinishbtn.MouseLeave
        InitFinish()
    End Sub
    Private Sub InitLogin()
        pbLoginbtn.Left = 280
        pbLoginbtn.Top = 4
        pbLoginbtn.Width = 25
        pbLoginbtn.Height = 25
        pbLoginbtn.BackgroundImage = My.Resources.Login
    End Sub
    Private Sub pbLoginbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbLoginbtn.Click
        InitLoginFormShow()
        'If Not IsConnect Then
        '    Dim UL As New LoginConfig()
        '    If UL.ShowDialog() = DialogResult.OK Then
        '        If Layanan = 0 Then
        '            Layanan = 1
        '        End If
        '        SendRequestMessage(SendData, "Login", CounterName, Layanan, Counter, LoginConfig.User, LoginConfig.Password)
        '    End If
        'End If
    End Sub
    Private Sub pbLoginbtn_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pbLoginbtn.MouseHover
        pbLoginbtn.BackgroundImage = My.Resources.LoginActive
    End Sub
    Private Sub pbLoginbtn_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbLoginbtn.MouseLeave
        InitLogin()
    End Sub
    Private Sub InitLogout()
        pbLogoutbtn.Left = 311
        pbLogoutbtn.Top = 4
        pbLogoutbtn.Width = 25
        pbLogoutbtn.Height = 25
        pbLogoutbtn.BackgroundImage = My.Resources.Logout
    End Sub
    Private Sub pbLogoutbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbLogoutbtn.Click
        If IsConnect Then
            Try
                lblLogin.Text = "No Acces"
                lblServing.Text = "No Acces"
                Me.BeginInvoke(New RefreshPbUser(AddressOf InvalidateLogUser))
                Dim cc As New CounterComponent()
                'IPServer = cc.IP
                CounterName = cc.Nama
                Counter = cc.Counter
                SendRequestMessage(SendData, "Logout", CounterName, Layanan, Counter, LoginConfig.User, "")
                IsConnect = False
                InitFlag()
                AllEnable()
            Catch
            End Try
            InitLoginFormShow()
        End If
    End Sub
    Private Sub pbLogoutbtn_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pbLogoutbtn.MouseHover
        pbLogoutbtn.BackgroundImage = My.Resources.LogoutActive
    End Sub
    Private Sub pbStop_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbLogoutbtn.MouseLeave
        InitLogout()
    End Sub
    Public Sub InitClose()
        pbClosebtn.Left = 371
        pbClosebtn.Top = 4
        pbClosebtn.Width = 25
        pbClosebtn.Height = 25
        pbClosebtn.BackgroundImage = My.Resources.Close
    End Sub
    Private Sub pbClosebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbClosebtn.Click
        If IsConnect Then
            Try
                lblLogin.Text = "Logout"
                Dim cc As New CounterComponent()
                'IPServer = cc.IP
                CounterName = cc.Nama
                Counter = cc.Counter
                SendRequestMessage(SendData, "Logout", CounterName, Layanan, Counter, LoginConfig.User, "")
                IsConnect = False
                InitFlag()
                AllEnable()
            Catch
            End Try
        End If
        myDuplexChannelWrapper.DetachDuplexInputChannel()
        Close()
    End Sub
    Private Sub pbClosebtn_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pbClosebtn.MouseHover
        pbClosebtn.BackgroundImage = My.Resources.CloseActive
    End Sub
    Private Sub pbClosebtn_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbClosebtn.MouseLeave
        InitClose()
    End Sub
    Private Sub InitConfig()
        pbConfigbtn.Left = 341
        pbConfigbtn.Top = 4
        pbConfigbtn.Width = 25
        pbConfigbtn.Height = 25
        pbConfigbtn.BackgroundImage = My.Resources.Config
    End Sub
    Private Sub StartLayanan()
        tmLayanan.Start()
    End Sub
    Private Sub pbConfigbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbConfigbtn.Click
        Dim cc As New CounterComponent()
        'IPServer = cc.IP
        CounterName = cc.Nama
        Counter = cc.Counter
        If Not IsConnect Then

            SendRequestMessage(SendData, "RequesLayanan", CounterName, Layanan, Counter, LoginConfig.User, "")
            ctLayanan = 0
            Dim x As Integer = 18
            Do While x > 0
                delay_ms(500)
                If isLayananOk Then
                    x = 1
                End If
                x -= 1
            Loop
            If Not isLayananOk Then
                MessageBox.Show("Koneksi Ke Server Gagal", "Info")
            End If
        End If
        Dim cfg As New ConfigClient()
        If cfg.ShowDialog() = DialogResult.OK Then
            If IsConnect Then
                lblLogin.Text = "Logout"
                lblServing.Text = "Start"
                Me.BeginInvoke(New RefreshPbCounter(AddressOf InitFlag))
                Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateCQ))
                SendRequestMessage(SendData, "Logout", CounterName, Layanan, Counter, LoginConfig.User, LoginConfig.Password)
                IsConnect = False
                InitLoginFormShow()
            End If
            IPServer = cc.IP
            CounterName = cc.Nama
            Layanan = cc.Service
            Counter = cc.Counter
            delay_ms(100)
            Try
                If SerialPort1.IsOpen Then
                    SerialPort1.Close()
                End If
                SerialPort1.PortName = NamaPort
            Catch
            End Try
        End If
        tmLayanan.Stop()
    End Sub
    Private Sub pbConfig_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pbConfigbtn.MouseHover
        pbConfigbtn.BackgroundImage = My.Resources.ConfigActive
    End Sub
    Private Sub pbConfig_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbConfigbtn.MouseLeave
        InitConfig()
    End Sub
    Public Sub InitClock()
        pbClock.BackColor = Color.Transparent
        pbClock.Top = 277
        pbClock.Left = 120
        pbClock.Height = 21
        pbClock.Width = 56
    End Sub
    Private Sub pbClock_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbClock.Paint
        e.Graphics.FillRectangle(Brushes.Transparent, 0, 0, pbClock.Width, pbClock.Height)
        Dim Warna As Brush = New SolidBrush(Color.White)
        Dim Jam As String = Date.Now.ToString("HH:mm", CultureInfo.CreateSpecificCulture("id-ID"))
        Dim Tanggal As String = Date.Now.ToString("ddd, d MMM yy", CultureInfo.CreateSpecificCulture("id-ID"))
        Dim sh As Single = e.Graphics.MeasureString(Jam, New Font("Arial Rounded MT Bold", 8, FontStyle.Bold)).Height
        Dim sw As Single = e.Graphics.MeasureString(Jam, New Font("Arial Rounded MT Bold", 8, FontStyle.Bold)).Width
        e.Graphics.DrawString(Jam, New Font("Arial Rounded MT Bold", 8, FontStyle.Bold), Warna, ((pbClock.Width - sw) / 2) - 3, 7 + ((pbClock.Height \ 2) - sh) / 2)
    End Sub

    Public Sub InitTotalNumber()
        pbTotalNumber.BackColor = Color.Transparent
        pbTotalNumber.Height = 22
        pbTotalNumber.Width = 65
        pbTotalNumber.Top = 137
        pbTotalNumber.Left = 140
    End Sub
    Private Sub TotalNumber_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbTotalNumber.Paint
        Try
            Dim Widts As Integer = BackgroundImage.Width
            Dim Heighs As Integer = BackgroundImage.Height
            Dim format1 As New StringFormat(StringFormatFlags.NoClip)
            ' format1.LineAlignment = StringAlignment.Center
            'format1.Alignment = StringAlignment.Center

            Dim rectNomor As New RectangleF(0, 0, Widts, Heighs)
            Dim tmpCurrent As String = (CChar(ChrW(&H40 + Layanan))).ToString() & " " & (String.Format("{0:000}", TotalQueue))
            e.Graphics.DrawString(tmpCurrent, New Font("Segoe WP N", 15, FontStyle.Bold), WarnaTq, rectNomor, format1)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub InitPendingQueue()
        pbHoldNumber.BackColor = Color.Transparent
        pbHoldNumber.Height = 22
        pbHoldNumber.Width = 65
        pbHoldNumber.Top = 174
        pbHoldNumber.Left = 140
    End Sub
    Private Sub pbHoldNumber_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbHoldNumber.Paint
        Try
            Dim Widts As Integer = BackgroundImage.Width
            Dim Heighs As Integer = BackgroundImage.Height
            Dim format1 As New StringFormat(StringFormatFlags.NoClip)
            'format1.LineAlignment = StringAlignment.Center
            ' format1.Alignment = StringAlignment.Center

            Dim rectNomor As New RectangleF(21, 0, Widts, Heighs)
            Dim tmpCurrent As String = String.Format("{0:000}", TotalHoldNumber)
            e.Graphics.DrawString(tmpCurrent, New Font("Segoe WP N", 15, FontStyle.Bold), WarnaTq, rectNomor, format1)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub InitNomorAntrian()
        pbNomorAntrian.BackColor = Color.Transparent
        pbNomorAntrian.Top = 49
        pbNomorAntrian.Left = 1
        pbNomorAntrian.Height = 73
        pbNomorAntrian.Width = 204
    End Sub
    Private Sub pbNomorAntrian_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbNomorAntrian.Paint

        Try
            Dim Widts As Integer = BackgroundImage.Width
            Dim Heighs As Integer = BackgroundImage.Height
            Dim tmpCurrent As String = "-" & (" ") & ("----")
            'Dim tmpCurrent As String = "A" & (" ") & ("0002")
            Dim warna1 = New SolidBrush(Color.White)
            Dim warna2 = New SolidBrush(Color.Yellow)
            If JumlahKedip Mod 2 = 0 Then
                warna1 = New SolidBrush(Color.Snow)
                warna2 = New SolidBrush(Color.Yellow)
            Else
                warna1 = New SolidBrush(Color.Black)
                warna2 = New SolidBrush(Color.Black)
            End If
            If CurrentDisplay > 0 Then
                tmpCurrent = ConvertNomor(dispLayanan, CurrentDisplay)
            End If
            Dim format1 As New StringFormat(StringFormatFlags.NoClip)
            'format1.LineAlignment = StringAlignment.Center
            format1.Alignment = StringAlignment.Center
            Dim rectNomor As New RectangleF(0, 10, Widts \ 2, Heighs \ 2)
            e.Graphics.DrawString(tmpCurrent, New Font("Segoe WP N", 40, FontStyle.Bold), warna1, rectNomor, format1)

        Catch ex As Exception

        End Try


    End Sub
    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        If IsConnect Then
            Try
                Dim cc As New CounterComponent()
                'IPServer = cc.IP
                CounterName = cc.Nama
                Counter = cc.Counter
                SendRequestMessage(SendData, "Logout", CounterName, Layanan, Counter, LoginConfig.User, "")
                IsConnect = False
                InitFlag()
                AllEnable()
            Catch
            End Try
        End If
        Close()
    End Sub
    Private Sub PrintNomorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNomorToolStripMenuItem.Click
        Dim Print As New PrintNomor()
        Print.Show()
    End Sub
    Private Sub Client_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.IsMouseDown = True
        Me.LastCursorPosition = New Point(e.X, e.Y)
    End Sub
    Private Sub Client_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Me.IsMouseDown = True Then
            Me.Location = New Point(Me.Left - (Me.LastCursorPosition.X - e.X), Me.Top - (Me.LastCursorPosition.Y - e.Y))
            Interaction.SaveSetting("AntServer\Client", "Pos", "Top", Me.Top.ToString())
            Interaction.SaveSetting("AntServer\Client", "Pos", "Left", Me.Left.ToString())
        End If
    End Sub
    Private Sub Client_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.IsMouseDown = False
    End Sub
    Private Sub tmLayanan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmLayanan.Tick
        Dim tempVar As Boolean = ctLayanan = 100
        ctLayanan += 1
        If tempVar Then
            tmLayanan.Stop()
            MessageBox.Show("Tekan Lagi Tombol Config", "Info")
            isLayananOk = True
            ctLayanan = 0
        End If
    End Sub
    Private Sub tmClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmClock.Tick
        pbClock.Invalidate()
    End Sub
    Private Sub tmDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmDisplay.Tick
        JumlahKedip += 1
        If JumlahKedip > 10 Then
            JumlahKedip = 0
            tmDisplay.Stop()
            TombolAktif = False
            Me.BeginInvoke(New RefreshPbCounter(AddressOf InitFlag))
        End If
        Me.BeginInvoke(New RefreshPbCounter(AddressOf InvalidateCQ))
    End Sub
    Private Sub tmService_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmService.Tick
        counterService += 1
        If counterService = btsBawah Then
        ElseIf counterService = btsAtas Then
        End If
    End Sub
    Private Sub tmStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmStart.Tick
        tmStart.Stop()
        WarnaTq = Brushes.White
        NewTotal = False
        Me.TopMost = False
        InvalidateTQ()
        InvalidateHQ()
    End Sub
    Private Sub SetKedip()
        tmDisplay.Start()
    End Sub
    Private Sub SendDataToDisplay()
        Dim DataSend(12) As Byte
        DataSend(0) = &HFA
        DataSend(11) = &HFB
        DataSend(2) = &HD9
        DataSend(1) = DataSend(2)
        DataSend(4) = CByte(dispLayanan - 1)
        DataSend(3) = DataSend(4)
        DataSend(6) = CByte(Counter - 1)
        DataSend(5) = DataSend(6)
        DataSend(8) = CByte(Int2BCD.PS(CurrentDisplay))
        DataSend(7) = DataSend(8)
        DataSend(10) = CByte(Int2BCD.RR(CurrentDisplay))
        DataSend(9) = DataSend(10)
        Try
            If Not SerialPort1.IsOpen Then
                SerialPort1.Open()
            End If
            SerialPort1.Write(DataSend, 0, 12)
            SerialPort1.Close()
        Catch
        End Try
    End Sub
    Public Shared NomorAntri As String
    Public Shared SisaNomor As String
    Public Shared LayananCounter As String
    Public Shared LayananTujuan As String
    Public Shared LayananName As String
    Private Sub flagEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flagEditorToolStripMenuItem.Click
        Dim Pembanding As String = Interaction.InputBox("Kode Aktifasi/Deaktifasi", "Client", "")
        If Pembanding = "AntServer" Then
            If Not AllowToEdit Then
                AllowToEdit = True
            Else
                AllowToEdit = False
            End If
        End If
    End Sub
    Public Sub InitUser()
        pbUser.BackgroundImage = My.Resources.UserLog
        pbUser.BackColor = Color.Transparent
        pbUser.Height = 30
        pbUser.Width = 29
        pbUser.Top = 12
        pbUser.Left = 4
    End Sub
    Public Sub InitListPending()
        pbListPending.Visible = True
        pbOK.Visible = True
        pbClose.Visible = True
        Listnumber.Visible = True
        pbListPending.BackgroundImage = My.Resources.PendingList
        pbListPending.Height = pbListPending.BackgroundImage.Height
        pbListPending.Width = pbListPending.BackgroundImage.Width
        pbListPending.Top = 49
        pbListPending.Left = 205
        Listnumber.Width = pbListPending.BackgroundImage.Width - 2
        Listnumber.Height = 119
        Listnumber.Top = 76
        Listnumber.Left = 206
        pbOK.BackgroundImage = My.Resources.btnOK
        pbOK.Height = pbOK.BackgroundImage.Height
        pbOK.Width = pbOK.BackgroundImage.Width
        pbOK.Top = 53
        pbOK.Left = 209
        pbClose.BackgroundImage = My.Resources.btnClose
        pbClose.Height = pbClose.BackgroundImage.Height
        pbClose.Width = pbClose.BackgroundImage.Width
        pbClose.Top = 53
        pbClose.Left = 250
    End Sub
    Public Sub InitListLayanan()
        pbSublayanan.Visible = True
        pbOKSub.Visible = True
        pbCloseSub.Visible = True
        ListSubLayanan.Visible = True
        pbSublayanan.BackgroundImage = My.Resources.SubLayanan
        pbSublayanan.Height = pbSublayanan.BackgroundImage.Height
        pbSublayanan.Width = pbSublayanan.BackgroundImage.Width
        pbSublayanan.Top = 49
        pbSublayanan.Left = 205
        ListSubLayanan.Width = pbSublayanan.BackgroundImage.Width - 2
        ListSubLayanan.Height = 119
        ListSubLayanan.Top = 76
        ListSubLayanan.Left = 206
        pbOKSub.BackgroundImage = My.Resources.btnOK
        pbOKSub.Height = pbOKSub.BackgroundImage.Height
        pbOKSub.Width = pbOKSub.BackgroundImage.Width
        pbOKSub.Top = 53
        pbOKSub.Left = 209
        pbCloseSub.BackgroundImage = My.Resources.btnClose
        pbCloseSub.Height = pbCloseSub.BackgroundImage.Height
        pbCloseSub.Width = pbCloseSub.BackgroundImage.Width
        pbCloseSub.Top = 53
        pbCloseSub.Left = 250
    End Sub
    Private Sub pbClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbClose.Click
        pbListPending.Visible = False
        pbOK.Visible = False
        pbClose.Visible = False
        Listnumber.Visible = False
    End Sub
    Private Sub pbClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbClose.MouseHover
        pbClose.BackgroundImage = My.Resources.btnCloseActive
    End Sub
    Private Sub pbClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbClose.MouseLeave
        pbClose.BackgroundImage = My.Resources.btnClose
    End Sub
    Private Sub pbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbOK.Click
        Dim cc As New CounterComponent()
        'IPServer = cc.IP
        CounterName = cc.Nama
        Counter = cc.Counter
        If IsConnect AndAlso ((Not TombolAktif)) Then
            If IsConnect Then
                If Listnumber.Text <> "" Then
                    Try
                        lblServing.Text = "Call Pending Nomor"
                        CallPendingClick = True
                        sudahPending = False
                        sudahAdvance = False
                        sudahPass = False
                        sudahTransfer = False
                        Dim hNomor As Integer = 0
                        Dim hLayanan As Integer = 0
                        Dim tmp As String = Listnumber.SelectedItem.ToString()
                        tmp = tmp.Replace(" ", "")
                        tmp = tmp.Replace("_", "")
                        Dim digits() As String = Regex.Split(tmp, "\D+")
                        For Each value As String In digits
                            Integer.TryParse(value, hNomor)
                        Next value
                        tmp = Regex.Replace(tmp, "\d", "")
                        hLayanan = Convert.ToInt32(Convert.ToChar(tmp)) - &H40
                        SendRequestMessage(SendData, "CallHold", CounterName, hLayanan, Counter, "", "", hNomor, 0)
                        TombolAktif = True
                        AllDisable()
                        pbListPending.Visible = False
                        pbOK.Visible = False
                        pbClose.Visible = False
                        Listnumber.Visible = False
                    Catch
                        TombolAktif = False
                        sudahPending = False
                        sudahAdvance = False
                        sudahPass = False
                        sudahTransfer = False
                        InitFlag()
                    End Try
                Else
                    MessageBox.Show("Pilih nomor untuk di recall", "Info")
                End If
            End If
        End If
    End Sub
    Private Sub pbOK_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbOK.MouseHover
        pbOK.BackgroundImage = My.Resources.btnOKActive
    End Sub
    Private Sub pbOK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbOK.MouseLeave
        '''If Not CallPendingClick Then
        '''    InitCallPending()
        '''End If
        pbOK.BackgroundImage = My.Resources.btnOK
    End Sub
    Private Sub pbOKSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbOKSub.Click
        Dim cc As New CounterComponent()
        'IPServer = cc.IP
        CounterName = cc.Nama
        Counter = cc.Counter
        If (IsConnect) AndAlso ((Not sudahTransfer)) AndAlso ((Not sudahPending)) AndAlso ((Not sudahPass)) Then
            If ListSubLayanan.Text <> "" Then
                Try
                    Dim tmpLay As String = NamaLayanan(Layanan - 1)
                    If ListSubLayanan.Text <> "" Then
                        tmpLay = cbSub.Text
                    End If
                    lblServing.Text = "Start Report"
                    SendRequestMessage(SendData, "Start", CounterName, Layanan, Counter, "", "", 0, 0, cbSub.Text)
                    AllDisableStar()
                    counterService = 0
                    tmService.Start()
                    sudahFinish = False
                    pbSublayanan.Visible = False
                    pbOKSub.Visible = False
                    pbCloseSub.Visible = False
                    ListSubLayanan.Visible = False
                Catch
                    InitFlag()
                End Try
            Else
                MessageBox.Show("Pilih Jenis Transaksi", "Info")
            End If
        End If
    End Sub
    Private Sub pbOKSub_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbOKSub.MouseHover
        pbOKSub.BackgroundImage = My.Resources.btnOKActive
    End Sub
    Private Sub pbOKSub_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbOKSub.MouseLeave
        pbOKSub.BackgroundImage = My.Resources.btnOK
    End Sub
    Private Sub pbCloseSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCloseSub.Click
        pbSublayanan.Visible = False
        pbOKSub.Visible = False
        pbCloseSub.Visible = False
        ListSubLayanan.Visible = False
    End Sub
    Private Sub pbCloseSub_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCloseSub.MouseHover
        pbCloseSub.BackgroundImage = My.Resources.btnCloseActive
    End Sub
    Private Sub pbCloseSub_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCloseSub.MouseLeave
        pbCloseSub.BackgroundImage = My.Resources.btnClose
    End Sub
#Region "Pengaturan Running Text"
    Private Sub AturPosisiRtext()
        ' pbRT.BackgroundImage = My.Resources.RunningText
        pbRT.Width = 118
        pbRT.Height = 21
        pbRT.Top = 277
        pbRT.Left = 2
    End Sub
    Private Sub tmRunningText_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmRunningText.Tick
        pbRT.Invalidate()
    End Sub

    Private Sub pbRT_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbRT.Paint
        Dim wdt As Integer = pbRT.Width
        Dim hgt As Integer = pbRT.Height
        Dim sh As Single = e.Graphics.MeasureString("TEST", PrtextFont).Height
        e.Graphics.DrawString(PrText, PrtextFont, PrtextBrush, PtPos, ((hgt - sh) / 2))
        Dim bt As Single = e.Graphics.MeasureString(PrText, PrtextFont).Width
        If (PtPos < 0) AndAlso (Math.Abs(PtPos) >= bt) Then
            PtPos = wdt
        End If
        PtPos -= 1 * PrtextSpeed
    End Sub
#End Region
    Private Sub RunningTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunningTextToolStripMenuItem.Click
        Dim RuningText As New SettingRunningText
        RuningText.Show()
    End Sub

 
End Class