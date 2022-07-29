<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client))
        Me.lblServing = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.cbPending = New System.Windows.Forms.ComboBox()
        Me.cbSub = New System.Windows.Forms.ComboBox()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.flagEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingPrinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintNomorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunningTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmLayanan = New System.Windows.Forms.Timer(Me.components)
        Me.tmClock = New System.Windows.Forms.Timer(Me.components)
        Me.tmDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.tmService = New System.Windows.Forms.Timer(Me.components)
        Me.tmStart = New System.Windows.Forms.Timer(Me.components)
        Me.pbUser = New System.Windows.Forms.Panel()
        Me.pbListPending = New System.Windows.Forms.Panel()
        Me.Listnumber = New System.Windows.Forms.ListBox()
        Me.pbSublayanan = New System.Windows.Forms.Panel()
        Me.ListSubLayanan = New System.Windows.Forms.ListBox()
        Me.pbClose = New System.Windows.Forms.Panel()
        Me.pbOK = New System.Windows.Forms.Panel()
        Me.pbCloseSub = New System.Windows.Forms.Panel()
        Me.pbOKSub = New System.Windows.Forms.Panel()
        Me.tmRunningText = New System.Windows.Forms.Timer(Me.components)
        Me.pbRT = New System.Windows.Forms.Panel()
        Me.statuslbl = New System.Windows.Forms.Label()
        Me.pbLoginClose = New System.Windows.Forms.PictureBox()
        Me.pbBtnLogin = New System.Windows.Forms.PictureBox()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        Me.pbConnect = New System.Windows.Forms.PictureBox()
        Me.pbTotalNumber = New System.Windows.Forms.PictureBox()
        Me.pbHoldNumber = New System.Windows.Forms.PictureBox()
        Me.pbNomorAntrian = New System.Windows.Forms.PictureBox()
        Me.pbClock = New System.Windows.Forms.PictureBox()
        Me.pbClosebtn = New System.Windows.Forms.PictureBox()
        Me.pbConfigbtn = New System.Windows.Forms.PictureBox()
        Me.pbLogoutbtn = New System.Windows.Forms.PictureBox()
        Me.pbLoginbtn = New System.Windows.Forms.PictureBox()
        Me.pbStartbtn = New System.Windows.Forms.PictureBox()
        Me.pbFinishbtn = New System.Windows.Forms.PictureBox()
        Me.pbPendingbtn = New System.Windows.Forms.PictureBox()
        Me.pbCallPendingbtn = New System.Windows.Forms.PictureBox()
        Me.pbTransferbtn = New System.Windows.Forms.PictureBox()
        Me.pbRecallbtn = New System.Windows.Forms.PictureBox()
        Me.pbCallbtn = New System.Windows.Forms.PictureBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.contextMenuStrip1.SuspendLayout()
        CType(Me.pbLoginClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBtnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTotalNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHoldNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNomorAntrian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClosebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConfigbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogoutbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoginbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStartbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFinishbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPendingbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCallPendingbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTransferbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRecallbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCallbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblServing
        '
        Me.lblServing.AutoSize = True
        Me.lblServing.BackColor = System.Drawing.Color.Transparent
        Me.lblServing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServing.ForeColor = System.Drawing.Color.Red
        Me.lblServing.Location = New System.Drawing.Point(217, 12)
        Me.lblServing.Name = "lblServing"
        Me.lblServing.Size = New System.Drawing.Size(51, 15)
        Me.lblServing.TabIndex = 6
        Me.lblServing.Text = "Proses"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Red
        Me.lblLogin.Location = New System.Drawing.Point(274, 12)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(37, 15)
        Me.lblLogin.TabIndex = 5
        Me.lblLogin.Text = "User"
        '
        'cbPending
        '
        Me.cbPending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPending.FormattingEnabled = True
        Me.cbPending.Location = New System.Drawing.Point(12, 184)
        Me.cbPending.Name = "cbPending"
        Me.cbPending.Size = New System.Drawing.Size(121, 23)
        Me.cbPending.TabIndex = 7
        Me.cbPending.Visible = False
        '
        'cbSub
        '
        Me.cbSub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbSub.FormattingEnabled = True
        Me.cbSub.Location = New System.Drawing.Point(12, 213)
        Me.cbSub.Name = "cbSub"
        Me.cbSub.Size = New System.Drawing.Size(121, 21)
        Me.cbSub.TabIndex = 8
        Me.cbSub.Visible = False
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.flagEditorToolStripMenuItem, Me.SettingPrinterToolStripMenuItem, Me.PrintNomorToolStripMenuItem, Me.RunningTextToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(214, 136)
        '
        'flagEditorToolStripMenuItem
        '
        Me.flagEditorToolStripMenuItem.Name = "flagEditorToolStripMenuItem"
        Me.flagEditorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.flagEditorToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.flagEditorToolStripMenuItem.Text = "FlagEditor"
        Me.flagEditorToolStripMenuItem.Visible = False
        '
        'SettingPrinterToolStripMenuItem
        '
        Me.SettingPrinterToolStripMenuItem.Name = "SettingPrinterToolStripMenuItem"
        Me.SettingPrinterToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SettingPrinterToolStripMenuItem.Text = "Setting Printer"
        Me.SettingPrinterToolStripMenuItem.Visible = False
        '
        'PrintNomorToolStripMenuItem
        '
        Me.PrintNomorToolStripMenuItem.Name = "PrintNomorToolStripMenuItem"
        Me.PrintNomorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintNomorToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PrintNomorToolStripMenuItem.Text = "Print Nomor"
        Me.PrintNomorToolStripMenuItem.Visible = False
        '
        'RunningTextToolStripMenuItem
        '
        Me.RunningTextToolStripMenuItem.Name = "RunningTextToolStripMenuItem"
        Me.RunningTextToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.RunningTextToolStripMenuItem.Text = "Running Text"
        Me.RunningTextToolStripMenuItem.Visible = False
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'tmLayanan
        '
        '
        'tmClock
        '
        Me.tmClock.Interval = 250
        '
        'tmDisplay
        '
        Me.tmDisplay.Interval = 750
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 2400
        '
        'tmService
        '
        Me.tmService.Interval = 1000
        '
        'tmStart
        '
        Me.tmStart.Interval = 1000
        '
        'pbUser
        '
        Me.pbUser.Location = New System.Drawing.Point(81, 141)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(62, 37)
        Me.pbUser.TabIndex = 10
        '
        'pbListPending
        '
        Me.pbListPending.Location = New System.Drawing.Point(370, 12)
        Me.pbListPending.Name = "pbListPending"
        Me.pbListPending.Size = New System.Drawing.Size(100, 48)
        Me.pbListPending.TabIndex = 11
        Me.pbListPending.Visible = False
        '
        'Listnumber
        '
        Me.Listnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Listnumber.FormattingEnabled = True
        Me.Listnumber.Location = New System.Drawing.Point(483, 83)
        Me.Listnumber.Name = "Listnumber"
        Me.Listnumber.Size = New System.Drawing.Size(163, 65)
        Me.Listnumber.TabIndex = 26
        Me.Listnumber.Visible = False
        '
        'pbSublayanan
        '
        Me.pbSublayanan.Location = New System.Drawing.Point(370, 66)
        Me.pbSublayanan.Name = "pbSublayanan"
        Me.pbSublayanan.Size = New System.Drawing.Size(100, 48)
        Me.pbSublayanan.TabIndex = 11
        Me.pbSublayanan.Visible = False
        '
        'ListSubLayanan
        '
        Me.ListSubLayanan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListSubLayanan.FormattingEnabled = True
        Me.ListSubLayanan.Location = New System.Drawing.Point(484, 12)
        Me.ListSubLayanan.Name = "ListSubLayanan"
        Me.ListSubLayanan.Size = New System.Drawing.Size(163, 65)
        Me.ListSubLayanan.TabIndex = 26
        Me.ListSubLayanan.Visible = False
        '
        'pbClose
        '
        Me.pbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClose.Location = New System.Drawing.Point(370, 120)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(52, 43)
        Me.pbClose.TabIndex = 27
        Me.pbClose.Visible = False
        '
        'pbOK
        '
        Me.pbOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbOK.Location = New System.Drawing.Point(370, 169)
        Me.pbOK.Name = "pbOK"
        Me.pbOK.Size = New System.Drawing.Size(52, 43)
        Me.pbOK.TabIndex = 27
        Me.pbOK.Visible = False
        '
        'pbCloseSub
        '
        Me.pbCloseSub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseSub.Location = New System.Drawing.Point(425, 120)
        Me.pbCloseSub.Name = "pbCloseSub"
        Me.pbCloseSub.Size = New System.Drawing.Size(52, 43)
        Me.pbCloseSub.TabIndex = 27
        Me.pbCloseSub.Visible = False
        '
        'pbOKSub
        '
        Me.pbOKSub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbOKSub.Location = New System.Drawing.Point(425, 169)
        Me.pbOKSub.Name = "pbOKSub"
        Me.pbOKSub.Size = New System.Drawing.Size(52, 43)
        Me.pbOKSub.TabIndex = 27
        Me.pbOKSub.Visible = False
        '
        'tmRunningText
        '
        Me.tmRunningText.Interval = 25
        '
        'pbRT
        '
        Me.pbRT.Location = New System.Drawing.Point(139, 184)
        Me.pbRT.Name = "pbRT"
        Me.pbRT.Size = New System.Drawing.Size(161, 28)
        Me.pbRT.TabIndex = 28
        Me.pbRT.Visible = False
        '
        'statuslbl
        '
        Me.statuslbl.AutoSize = True
        Me.statuslbl.BackColor = System.Drawing.Color.Transparent
        Me.statuslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslbl.Location = New System.Drawing.Point(149, 219)
        Me.statuslbl.Name = "statuslbl"
        Me.statuslbl.Size = New System.Drawing.Size(70, 15)
        Me.statuslbl.TabIndex = 29
        Me.statuslbl.Text = "Disconect"
        '
        'pbLoginClose
        '
        Me.pbLoginClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLoginClose.Location = New System.Drawing.Point(484, 196)
        Me.pbLoginClose.Name = "pbLoginClose"
        Me.pbLoginClose.Size = New System.Drawing.Size(64, 36)
        Me.pbLoginClose.TabIndex = 33
        Me.pbLoginClose.TabStop = False
        '
        'pbBtnLogin
        '
        Me.pbBtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBtnLogin.Location = New System.Drawing.Point(589, 154)
        Me.pbBtnLogin.Name = "pbBtnLogin"
        Me.pbBtnLogin.Size = New System.Drawing.Size(57, 36)
        Me.pbBtnLogin.TabIndex = 32
        Me.pbBtnLogin.TabStop = False
        '
        'pbLogin
        '
        Me.pbLogin.Location = New System.Drawing.Point(484, 154)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(92, 36)
        Me.pbLogin.TabIndex = 31
        Me.pbLogin.TabStop = False
        '
        'pbConnect
        '
        Me.pbConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConnect.Location = New System.Drawing.Point(308, 28)
        Me.pbConnect.Name = "pbConnect"
        Me.pbConnect.Size = New System.Drawing.Size(56, 32)
        Me.pbConnect.TabIndex = 30
        Me.pbConnect.TabStop = False
        '
        'pbTotalNumber
        '
        Me.pbTotalNumber.Location = New System.Drawing.Point(216, 104)
        Me.pbTotalNumber.Name = "pbTotalNumber"
        Me.pbTotalNumber.Size = New System.Drawing.Size(84, 32)
        Me.pbTotalNumber.TabIndex = 9
        Me.pbTotalNumber.TabStop = False
        '
        'pbHoldNumber
        '
        Me.pbHoldNumber.Location = New System.Drawing.Point(217, 141)
        Me.pbHoldNumber.Name = "pbHoldNumber"
        Me.pbHoldNumber.Size = New System.Drawing.Size(84, 37)
        Me.pbHoldNumber.TabIndex = 9
        Me.pbHoldNumber.TabStop = False
        '
        'pbNomorAntrian
        '
        Me.pbNomorAntrian.Location = New System.Drawing.Point(217, 66)
        Me.pbNomorAntrian.Name = "pbNomorAntrian"
        Me.pbNomorAntrian.Size = New System.Drawing.Size(84, 32)
        Me.pbNomorAntrian.TabIndex = 9
        Me.pbNomorAntrian.TabStop = False
        '
        'pbClock
        '
        Me.pbClock.Location = New System.Drawing.Point(217, 28)
        Me.pbClock.Name = "pbClock"
        Me.pbClock.Size = New System.Drawing.Size(84, 32)
        Me.pbClock.TabIndex = 9
        Me.pbClock.TabStop = False
        '
        'pbClosebtn
        '
        Me.pbClosebtn.BackColor = System.Drawing.Color.Transparent
        Me.pbClosebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClosebtn.Location = New System.Drawing.Point(149, 141)
        Me.pbClosebtn.Name = "pbClosebtn"
        Me.pbClosebtn.Size = New System.Drawing.Size(62, 37)
        Me.pbClosebtn.TabIndex = 2
        Me.pbClosebtn.TabStop = False
        '
        'pbConfigbtn
        '
        Me.pbConfigbtn.BackColor = System.Drawing.Color.Transparent
        Me.pbConfigbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfigbtn.Location = New System.Drawing.Point(149, 98)
        Me.pbConfigbtn.Name = "pbConfigbtn"
        Me.pbConfigbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbConfigbtn.TabIndex = 2
        Me.pbConfigbtn.TabStop = False
        '
        'pbLogoutbtn
        '
        Me.pbLogoutbtn.BackColor = System.Drawing.Color.Transparent
        Me.pbLogoutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLogoutbtn.Location = New System.Drawing.Point(149, 55)
        Me.pbLogoutbtn.Name = "pbLogoutbtn"
        Me.pbLogoutbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbLogoutbtn.TabIndex = 2
        Me.pbLogoutbtn.TabStop = False
        '
        'pbLoginbtn
        '
        Me.pbLoginbtn.BackColor = System.Drawing.Color.Transparent
        Me.pbLoginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLoginbtn.Location = New System.Drawing.Point(149, 12)
        Me.pbLoginbtn.Name = "pbLoginbtn"
        Me.pbLoginbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbLoginbtn.TabIndex = 2
        Me.pbLoginbtn.TabStop = False
        '
        'pbStartbtn
        '
        Me.pbStartbtn.BackColor = System.Drawing.Color.Red
        Me.pbStartbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbStartbtn.Location = New System.Drawing.Point(81, 98)
        Me.pbStartbtn.Name = "pbStartbtn"
        Me.pbStartbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbStartbtn.TabIndex = 1
        Me.pbStartbtn.TabStop = False
        '
        'pbFinishbtn
        '
        Me.pbFinishbtn.BackColor = System.Drawing.Color.Red
        Me.pbFinishbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFinishbtn.Location = New System.Drawing.Point(81, 55)
        Me.pbFinishbtn.Name = "pbFinishbtn"
        Me.pbFinishbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbFinishbtn.TabIndex = 1
        Me.pbFinishbtn.TabStop = False
        '
        'pbPendingbtn
        '
        Me.pbPendingbtn.BackColor = System.Drawing.Color.Red
        Me.pbPendingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPendingbtn.Location = New System.Drawing.Point(81, 12)
        Me.pbPendingbtn.Name = "pbPendingbtn"
        Me.pbPendingbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbPendingbtn.TabIndex = 1
        Me.pbPendingbtn.TabStop = False
        '
        'pbCallPendingbtn
        '
        Me.pbCallPendingbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pbCallPendingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCallPendingbtn.Location = New System.Drawing.Point(12, 98)
        Me.pbCallPendingbtn.Name = "pbCallPendingbtn"
        Me.pbCallPendingbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbCallPendingbtn.TabIndex = 0
        Me.pbCallPendingbtn.TabStop = False
        '
        'pbTransferbtn
        '
        Me.pbTransferbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pbTransferbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTransferbtn.Location = New System.Drawing.Point(11, 141)
        Me.pbTransferbtn.Name = "pbTransferbtn"
        Me.pbTransferbtn.Size = New System.Drawing.Size(62, 22)
        Me.pbTransferbtn.TabIndex = 0
        Me.pbTransferbtn.TabStop = False
        '
        'pbRecallbtn
        '
        Me.pbRecallbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pbRecallbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRecallbtn.Location = New System.Drawing.Point(12, 55)
        Me.pbRecallbtn.Name = "pbRecallbtn"
        Me.pbRecallbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbRecallbtn.TabIndex = 0
        Me.pbRecallbtn.TabStop = False
        '
        'pbCallbtn
        '
        Me.pbCallbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pbCallbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCallbtn.Location = New System.Drawing.Point(12, 12)
        Me.pbCallbtn.Name = "pbCallbtn"
        Me.pbCallbtn.Size = New System.Drawing.Size(62, 37)
        Me.pbCallbtn.TabIndex = 0
        Me.pbCallbtn.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Location = New System.Drawing.Point(555, 197)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(85, 20)
        Me.txtUser.TabIndex = 35
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(554, 218)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(85, 20)
        Me.txtPassword.TabIndex = 36
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 252)
        Me.ContextMenuStrip = Me.contextMenuStrip1
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.pbLoginClose)
        Me.Controls.Add(Me.pbBtnLogin)
        Me.Controls.Add(Me.pbLogin)
        Me.Controls.Add(Me.pbConnect)
        Me.Controls.Add(Me.statuslbl)
        Me.Controls.Add(Me.pbOK)
        Me.Controls.Add(Me.pbRT)
        Me.Controls.Add(Me.pbOKSub)
        Me.Controls.Add(Me.ListSubLayanan)
        Me.Controls.Add(Me.pbClose)
        Me.Controls.Add(Me.pbCloseSub)
        Me.Controls.Add(Me.cbSub)
        Me.Controls.Add(Me.Listnumber)
        Me.Controls.Add(Me.pbUser)
        Me.Controls.Add(Me.pbTotalNumber)
        Me.Controls.Add(Me.pbHoldNumber)
        Me.Controls.Add(Me.pbNomorAntrian)
        Me.Controls.Add(Me.pbSublayanan)
        Me.Controls.Add(Me.pbListPending)
        Me.Controls.Add(Me.pbClock)
        Me.Controls.Add(Me.cbPending)
        Me.Controls.Add(Me.pbClosebtn)
        Me.Controls.Add(Me.pbConfigbtn)
        Me.Controls.Add(Me.pbLogoutbtn)
        Me.Controls.Add(Me.pbLoginbtn)
        Me.Controls.Add(Me.pbStartbtn)
        Me.Controls.Add(Me.pbFinishbtn)
        Me.Controls.Add(Me.pbPendingbtn)
        Me.Controls.Add(Me.pbCallPendingbtn)
        Me.Controls.Add(Me.pbTransferbtn)
        Me.Controls.Add(Me.pbRecallbtn)
        Me.Controls.Add(Me.pbCallbtn)
        Me.Controls.Add(Me.lblServing)
        Me.Controls.Add(Me.lblLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Client"
        Me.contextMenuStrip1.ResumeLayout(False)
        CType(Me.pbLoginClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBtnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTotalNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHoldNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNomorAntrian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClosebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConfigbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogoutbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoginbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStartbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFinishbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPendingbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCallPendingbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTransferbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRecallbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCallbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbCallbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbRecallbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbCallPendingbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbTransferbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbPendingbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbFinishbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbStartbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbLoginbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogoutbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbConfigbtn As System.Windows.Forms.PictureBox
    Friend WithEvents pbClosebtn As System.Windows.Forms.PictureBox
    Private WithEvents lblServing As System.Windows.Forms.Label
    Private WithEvents lblLogin As System.Windows.Forms.Label
    Private WithEvents cbPending As System.Windows.Forms.ComboBox
    Private WithEvents cbSub As System.Windows.Forms.ComboBox
    Friend WithEvents pbClock As System.Windows.Forms.PictureBox
    Friend WithEvents pbNomorAntrian As System.Windows.Forms.PictureBox
    Friend WithEvents pbTotalNumber As System.Windows.Forms.PictureBox
    Friend WithEvents pbHoldNumber As System.Windows.Forms.PictureBox
    Private WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents flagEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingPrinterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintNomorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunningTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tmLayanan As System.Windows.Forms.Timer
    Private WithEvents tmClock As System.Windows.Forms.Timer
    Private WithEvents tmDisplay As System.Windows.Forms.Timer
    Private WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Private WithEvents tmService As System.Windows.Forms.Timer
    Private WithEvents tmStart As System.Windows.Forms.Timer
    Friend WithEvents pbUser As System.Windows.Forms.Panel
    Friend WithEvents pbListPending As System.Windows.Forms.Panel
    Friend WithEvents Listnumber As System.Windows.Forms.ListBox
    Friend WithEvents pbSublayanan As System.Windows.Forms.Panel
    Friend WithEvents ListSubLayanan As System.Windows.Forms.ListBox
    Friend WithEvents pbClose As System.Windows.Forms.Panel
    Friend WithEvents pbOK As System.Windows.Forms.Panel
    Friend WithEvents pbCloseSub As System.Windows.Forms.Panel
    Friend WithEvents pbOKSub As System.Windows.Forms.Panel
    Friend WithEvents tmRunningText As System.Windows.Forms.Timer
    Friend WithEvents pbRT As System.Windows.Forms.Panel
    Friend WithEvents statuslbl As System.Windows.Forms.Label
    Friend WithEvents pbConnect As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogin As System.Windows.Forms.PictureBox
    Friend WithEvents pbBtnLogin As System.Windows.Forms.PictureBox
    Friend WithEvents pbLoginClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
End Class
