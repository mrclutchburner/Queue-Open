<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPrinter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPrinter))
        Me.tspPhone = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tspConnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingSistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.TmRText = New System.Windows.Forms.Timer(Me.components)
        Me.TmClock = New System.Windows.Forms.Timer(Me.components)
        Me.tmDelay = New System.Windows.Forms.Timer(Me.components)
        Me.tmRespont = New System.Windows.Forms.Timer(Me.components)
        Me.tmPelayanan = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tspPhone.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspPhone
        '
        Me.tspPhone.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspConnect, Me.LoginToolStripMenuItem, Me.SettingSistemToolStripMenuItem, Me.SettingIPToolStripMenuItem, Me.SettingTiketToolStripMenuItem, Me.ExitTSM})
        Me.tspPhone.Name = "contextMenuStrip1"
        Me.tspPhone.Size = New System.Drawing.Size(150, 136)
        '
        'tspConnect
        '
        Me.tspConnect.Name = "tspConnect"
        Me.tspConnect.Size = New System.Drawing.Size(149, 22)
        Me.tspConnect.Text = "Dissconect"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SettingSistemToolStripMenuItem
        '
        Me.SettingSistemToolStripMenuItem.Name = "SettingSistemToolStripMenuItem"
        Me.SettingSistemToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SettingSistemToolStripMenuItem.Text = "Setting User"
        '
        'SettingIPToolStripMenuItem
        '
        Me.SettingIPToolStripMenuItem.Name = "SettingIPToolStripMenuItem"
        Me.SettingIPToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SettingIPToolStripMenuItem.Text = "Setting Printer"
        '
        'SettingTiketToolStripMenuItem
        '
        Me.SettingTiketToolStripMenuItem.Name = "SettingTiketToolStripMenuItem"
        Me.SettingTiketToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SettingTiketToolStripMenuItem.Text = "Setting Tiket"
        '
        'ExitTSM
        '
        Me.ExitTSM.Name = "ExitTSM"
        Me.ExitTSM.Size = New System.Drawing.Size(149, 22)
        Me.ExitTSM.Text = "Exit"
        '
        'TmRText
        '
        Me.TmRText.Interval = 25
        '
        'TmClock
        '
        Me.TmClock.Interval = 300
        '
        'tmDelay
        '
        Me.tmDelay.Interval = 2000
        '
        'tmRespont
        '
        Me.tmRespont.Interval = 9500
        '
        'tmPelayanan
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(15, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 105)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Layanan 1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(15, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 105)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Layanan 3"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(276, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 105)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Layanan 2"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MainPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(529, 267)
        Me.ContextMenuStrip = Me.tspPhone
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainPrinter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Printer"
        Me.tspPhone.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tspPhone As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ExitTSM As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents TmRText As System.Windows.Forms.Timer
    Private WithEvents TmClock As System.Windows.Forms.Timer
    Friend WithEvents tmDelay As System.Windows.Forms.Timer
    Friend WithEvents SettingTiketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingSistemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tmRespont As System.Windows.Forms.Timer
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspConnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmPelayanan As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
