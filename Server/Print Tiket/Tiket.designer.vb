Partial Public Class Tiket
    Private components As System.ComponentModel.IContainer = Nothing
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form "

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tiket))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.tsbText = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.tsbNomor = New System.Windows.Forms.ToolStripButton()
        Me.tsbNomorSisa = New System.Windows.Forms.ToolStripButton()
        Me.tsbService = New System.Windows.Forms.ToolStripButton()
        Me.tsbLogo = New System.Windows.Forms.ToolStripButton()
        Me.tspBarcode = New System.Windows.Forms.ToolStripButton()
        Me.tspQRBarcode = New System.Windows.Forms.ToolStripButton()
        Me.tsbClock = New System.Windows.Forms.ToolStripButton()
        Me.tsbDate = New System.Windows.Forms.ToolStripButton()
        Me.tspDateClock = New System.Windows.Forms.ToolStripButton()
        Me.tsbLine = New System.Windows.Forms.ToolStripButton()
        Me.tsbLines = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrinters = New System.Windows.Forms.ToolStripButton()
        Me.tmPos = New System.Windows.Forms.Timer(Me.components)
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.prtDoc = New System.Drawing.Printing.PrintDocument()
        Me.previewdlg = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnControls = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BringToFrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToFrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmite = New System.Windows.Forms.Button()
        Me.numDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSettingPrinter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudPrint = New System.Windows.Forms.NumericUpDown()
        Me.tspLayanan = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.AutoSize = False
        Me.toolStrip1.CanOverflow = False
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbOpen, Me.tsbSave, Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripButton5, Me.tsbText, Me.ToolStripButton4, Me.ToolStripButton3, Me.tsbNomor, Me.tsbNomorSisa, Me.tsbService, Me.tspLayanan, Me.tsbLogo, Me.tspBarcode, Me.tspQRBarcode, Me.tsbClock, Me.tsbDate, Me.tspDateClock, Me.tsbLine, Me.tsbLines, Me.ToolStripButton6, Me.tsbPrint, Me.tsbPrinters})
        Me.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(167, 646)
        Me.toolStrip1.TabIndex = 8
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tsbNew
        '
        Me.tsbNew.Image = My.Resources.Resources.clipboard_b
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(80, 20)
        Me.tsbNew.Text = "New Tiket"
        Me.tsbNew.ToolTipText = "New"
        '
        'tsbOpen
        '
        Me.tsbOpen.Image = My.Resources.Resources.folder
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(56, 20)
        Me.tsbOpen.Text = "Open"
        Me.tsbOpen.ToolTipText = "Open"
        '
        'tsbSave
        '
        Me.tsbSave.Image = Global.My.Resources.Resources.disquette
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(51, 20)
        Me.tsbSave.Text = "Save"
        Me.tsbSave.ToolTipText = "Save"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.My.Resources.Resources.disquette
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(67, 20)
        Me.ToolStripButton2.Text = "Save As"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.My.Resources.Resources.text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripButton1.Text = "Add Text Header Center"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(138, 20)
        Me.ToolStripButton5.Text = "Add Text Header Left"
        '
        'tsbText
        '
        Me.tsbText.Image = Global.My.Resources.Resources.text
        Me.tsbText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbText.Name = "tsbText"
        Me.tsbText.Size = New System.Drawing.Size(105, 20)
        Me.tsbText.Text = "Add Text Right"
        Me.tsbText.ToolTipText = "Label Text"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(112, 20)
        Me.ToolStripButton4.Text = "Add Text Center"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(97, 20)
        Me.ToolStripButton3.Text = "Add Text Left"
        '
        'tsbNomor
        '
        Me.tsbNomor.Image = Global.My.Resources.Resources.text
        Me.tsbNomor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNomor.Name = "tsbNomor"
        Me.tsbNomor.Size = New System.Drawing.Size(128, 20)
        Me.tsbNomor.Text = "Add Nomor Antian"
        '
        'tsbNomorSisa
        '
        Me.tsbNomorSisa.Image = Global.My.Resources.Resources.text
        Me.tsbNomorSisa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNomorSisa.Name = "tsbNomorSisa"
        Me.tsbNomorSisa.Size = New System.Drawing.Size(88, 20)
        Me.tsbNomorSisa.Text = "Nomor Sisa"
        '
        'tsbService
        '
        Me.tsbService.Image = Global.My.Resources.Resources.text
        Me.tsbService.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbService.Name = "tsbService"
        Me.tsbService.Size = New System.Drawing.Size(124, 20)
        Me.tsbService.Text = "Add Service Name"
        '
        'tsbLogo
        '
        Me.tsbLogo.Image = Global.My.Resources.Resources.pictures
        Me.tsbLogo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogo.Name = "tsbLogo"
        Me.tsbLogo.Size = New System.Drawing.Size(79, 20)
        Me.tsbLogo.Text = "Add Logo"
        Me.tsbLogo.ToolTipText = "Add Picture"
        '
        'tspBarcode
        '
        Me.tspBarcode.Image = Global.My.Resources.Resources.barcode
        Me.tspBarcode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBarcode.Name = "tspBarcode"
        Me.tspBarcode.Size = New System.Drawing.Size(70, 20)
        Me.tspBarcode.Text = "Barcode"
        '
        'tspQRBarcode
        '
        Me.tspQRBarcode.Image = Global.My.Resources.Resources.barcode
        Me.tspQRBarcode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspQRBarcode.Name = "tspQRBarcode"
        Me.tspQRBarcode.Size = New System.Drawing.Size(86, 20)
        Me.tspQRBarcode.Text = "QRBarcode"
        '
        'tsbClock
        '
        Me.tsbClock.Image = Global.My.Resources.Resources.clock
        Me.tsbClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbClock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClock.Name = "tsbClock"
        Me.tsbClock.Size = New System.Drawing.Size(82, 20)
        Me.tsbClock.Text = "Add Clock"
        '
        'tsbDate
        '
        Me.tsbDate.Image = Global.My.Resources.Resources.calender_month
        Me.tsbDate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDate.Name = "tsbDate"
        Me.tsbDate.Size = New System.Drawing.Size(76, 20)
        Me.tsbDate.Text = "Add Date"
        '
        'tspDateClock
        '
        Me.tspDateClock.Image = Global.My.Resources.Resources.calender_day
        Me.tspDateClock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspDateClock.Name = "tspDateClock"
        Me.tspDateClock.Size = New System.Drawing.Size(109, 20)
        Me.tspDateClock.Text = "Add Date Clock"
        '
        'tsbLine
        '
        Me.tsbLine.Image = Global.My.Resources.Resources.applications
        Me.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLine.Name = "tsbLine"
        Me.tsbLine.Size = New System.Drawing.Size(101, 20)
        Me.tsbLine.Text = "Add Line Strip"
        '
        'tsbLines
        '
        Me.tsbLines.Image = Global.My.Resources.Resources.apps
        Me.tsbLines.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLines.Name = "tsbLines"
        Me.tsbLines.Size = New System.Drawing.Size(74, 20)
        Me.tsbLines.Text = "Add Line"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.My.Resources.Resources.apps
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(108, 20)
        Me.ToolStripButton6.Text = "Add Line Dobel"
        Me.ToolStripButton6.ToolTipText = "Add Line Dobel"
        '
        'tsbPrint
        '
        Me.tsbPrint.Image = Global.My.Resources.Resources.printer
        Me.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrint.Name = "tsbPrint"
        Me.tsbPrint.Size = New System.Drawing.Size(77, 20)
        Me.tsbPrint.Text = "Test Print"
        Me.tsbPrint.ToolTipText = "Print"
        '
        'tsbPrinters
        '
        Me.tsbPrinters.Image = Global.My.Resources.Resources.printer
        Me.tsbPrinters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrinters.Name = "tsbPrinters"
        Me.tsbPrinters.Size = New System.Drawing.Size(102, 20)
        Me.tsbPrinters.Text = "Printer Setting"
        Me.tsbPrinters.ToolTipText = "Printer Setting"
        '
        'tmPos
        '
        Me.tmPos.Enabled = True
        Me.tmPos.Interval = 1000
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right
        Me.propertyGrid1.Location = New System.Drawing.Point(455, 0)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(387, 646)
        Me.propertyGrid1.TabIndex = 10
        '
        'prtDoc
        '
        '
        'previewdlg
        '
        Me.previewdlg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.previewdlg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.previewdlg.ClientSize = New System.Drawing.Size(400, 300)
        Me.previewdlg.Enabled = True
        Me.previewdlg.Icon = CType(resources.GetObject("previewdlg.Icon"), System.Drawing.Icon)
        Me.previewdlg.Name = "previewdlg"
        Me.previewdlg.Visible = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlMain.Controls.Add(Me.pnControls)
        Me.pnlMain.Location = New System.Drawing.Point(170, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(282, 646)
        Me.pnlMain.TabIndex = 11
        '
        'pnControls
        '
        Me.pnControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnControls.BackColor = System.Drawing.Color.White
        Me.pnControls.ContextMenuStrip = Me.ContextMenuStrip1
        Me.pnControls.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnControls.Location = New System.Drawing.Point(3, 3)
        Me.pnControls.Name = "pnControls"
        Me.pnControls.Size = New System.Drawing.Size(276, 447)
        Me.pnControls.TabIndex = 17
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BringToFrontToolStripMenuItem, Me.SendToFrontToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 136)
        '
        'BringToFrontToolStripMenuItem
        '
        Me.BringToFrontToolStripMenuItem.Image = Global.My.Resources.Resources.bringtofront
        Me.BringToFrontToolStripMenuItem.Name = "BringToFrontToolStripMenuItem"
        Me.BringToFrontToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BringToFrontToolStripMenuItem.Text = "Bring To Front"
        '
        'SendToFrontToolStripMenuItem
        '
        Me.SendToFrontToolStripMenuItem.Image = Global.My.Resources.Resources.sendtoback
        Me.SendToFrontToolStripMenuItem.Name = "SendToFrontToolStripMenuItem"
        Me.SendToFrontToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SendToFrontToolStripMenuItem.Text = "Send To Back"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Enabled = False
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnSubmite)
        Me.GroupBox1.Controls.Add(Me.numDelay)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnSettingPrinter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nudPrint)
        Me.GroupBox1.Location = New System.Drawing.Point(455, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 155)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting Printer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Using Tiket"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(83, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox1.TabIndex = 53
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(239, 57)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 42)
        Me.btnClose.TabIndex = 52
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmite
        '
        Me.btnSubmite.Location = New System.Drawing.Point(239, 102)
        Me.btnSubmite.Name = "btnSubmite"
        Me.btnSubmite.Size = New System.Drawing.Size(136, 42)
        Me.btnSubmite.TabIndex = 51
        Me.btnSubmite.Text = "Submite"
        Me.btnSubmite.UseVisualStyleBackColor = True
        '
        'numDelay
        '
        Me.numDelay.Location = New System.Drawing.Point(85, 59)
        Me.numDelay.Name = "numDelay"
        Me.numDelay.Size = New System.Drawing.Size(53, 20)
        Me.numDelay.TabIndex = 50
        Me.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDelay.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Delay Tombol"
        '
        'btnSettingPrinter
        '
        Me.btnSettingPrinter.Location = New System.Drawing.Point(239, 12)
        Me.btnSettingPrinter.Name = "btnSettingPrinter"
        Me.btnSettingPrinter.Size = New System.Drawing.Size(136, 42)
        Me.btnSettingPrinter.TabIndex = 48
        Me.btnSettingPrinter.Text = "&Setting Printer"
        Me.btnSettingPrinter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Print Copies"
        '
        'nudPrint
        '
        Me.nudPrint.Location = New System.Drawing.Point(83, 25)
        Me.nudPrint.Name = "nudPrint"
        Me.nudPrint.Size = New System.Drawing.Size(53, 20)
        Me.nudPrint.TabIndex = 47
        Me.nudPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPrint.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tspLayanan
        '
        Me.tspLayanan.Image = Global.My.Resources.Resources.label
        Me.tspLayanan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspLayanan.Name = "tspLayanan"
        Me.tspLayanan.Size = New System.Drawing.Size(143, 20)
        Me.tspLayanan.Text = "Layanan OPEN CLOSE"
        '
        'Tiket
        '
        Me.ClientSize = New System.Drawing.Size(842, 646)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "Tiket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Tiket"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private toolStrip1 As ToolStrip
    Private WithEvents tsbText As ToolStripButton
    Private WithEvents tsbLogo As ToolStripButton
    Private WithEvents tsbLine As ToolStripButton
    Private WithEvents tmPos As Timer
    Private propertyGrid1 As PropertyGrid
    Private WithEvents tsbPrint As ToolStripButton
    Private WithEvents prtDoc As System.Drawing.Printing.PrintDocument
    Private previewdlg As PrintPreviewDialog
    Private WithEvents tsbSave As ToolStripButton
    Private WithEvents tsbOpen As ToolStripButton
    Private WithEvents tsbNew As ToolStripButton
    Private pnlMain As Panel
    Private WithEvents pnControls As Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbLines As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbClock As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNomor As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNomorSisa As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbService As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrinters As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmite As System.Windows.Forms.Button
    Friend WithEvents numDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSettingPrinter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudPrint As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents BringToFrontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendToFrontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspDateClock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspBarcode As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspQRBarcode As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspLayanan As System.Windows.Forms.ToolStripButton
End Class


