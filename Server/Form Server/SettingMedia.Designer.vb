<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingMedia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingMedia))
        Me.numTv = New System.Windows.Forms.NumericUpDown()
        Me.BtnTV = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.CbInput = New System.Windows.Forms.ComboBox()
        Me.CbDevice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MediaList = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.numImage = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TrkVolume = New System.Windows.Forms.TrackBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnCencel = New System.Windows.Forms.Button()
        Me.BtnSave1 = New System.Windows.Forms.Button()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.BtnFont = New System.Windows.Forms.Button()
        Me.NuSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRunning = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.numTv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.numImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrkVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.NuSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numTv
        '
        Me.numTv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numTv.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numTv.Location = New System.Drawing.Point(80, 237)
        Me.numTv.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numTv.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numTv.Name = "numTv"
        Me.numTv.Size = New System.Drawing.Size(52, 20)
        Me.numTv.TabIndex = 32
        Me.numTv.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'BtnTV
        '
        Me.BtnTV.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnTV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnTV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnTV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnTV.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnTV.Location = New System.Drawing.Point(138, 215)
        Me.BtnTV.Name = "BtnTV"
        Me.BtnTV.Size = New System.Drawing.Size(78, 40)
        Me.BtnTV.TabIndex = 31
        Me.BtnTV.Text = "TV Time"
        Me.BtnTV.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSave.Location = New System.Drawing.Point(222, 93)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 40)
        Me.BtnSave.TabIndex = 28
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnClear.Location = New System.Drawing.Point(222, 50)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(112, 40)
        Me.BtnClear.TabIndex = 29
        Me.BtnClear.Text = "&Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAdd.Location = New System.Drawing.Point(222, 7)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(112, 40)
        Me.BtnAdd.TabIndex = 30
        Me.BtnAdd.Text = "&Add Video"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'CbInput
        '
        Me.CbInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbInput.FormattingEnabled = True
        Me.CbInput.Location = New System.Drawing.Point(80, 186)
        Me.CbInput.Name = "CbInput"
        Me.CbInput.Size = New System.Drawing.Size(136, 21)
        Me.CbInput.TabIndex = 27
        '
        'CbDevice
        '
        Me.CbDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbDevice.FormattingEnabled = True
        Me.CbDevice.Location = New System.Drawing.Point(80, 160)
        Me.CbDevice.Name = "CbDevice"
        Me.CbDevice.Size = New System.Drawing.Size(136, 21)
        Me.CbDevice.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Time TV :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Input :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Device :"
        '
        'MediaList
        '
        Me.MediaList.FormattingEnabled = True
        Me.MediaList.HorizontalScrollbar = True
        Me.MediaList.Location = New System.Drawing.Point(7, 6)
        Me.MediaList.Name = "MediaList"
        Me.MediaList.ScrollAlwaysVisible = True
        Me.MediaList.Size = New System.Drawing.Size(209, 134)
        Me.MediaList.TabIndex = 22
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(349, 295)
        Me.TabControl1.TabIndex = 33
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TabPage1.Controls.Add(Me.numImage)
        Me.TabPage1.Controls.Add(Me.MediaList)
        Me.TabPage1.Controls.Add(Me.BtnTV)
        Me.TabPage1.Controls.Add(Me.numTv)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BtnClear)
        Me.TabPage1.Controls.Add(Me.CbDevice)
        Me.TabPage1.Controls.Add(Me.BtnAdd)
        Me.TabPage1.Controls.Add(Me.CbInput)
        Me.TabPage1.Controls.Add(Me.TrkVolume)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(341, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Playlist Media"
        '
        'numImage
        '
        Me.numImage.Location = New System.Drawing.Point(80, 212)
        Me.numImage.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numImage.Name = "numImage"
        Me.numImage.Size = New System.Drawing.Size(52, 20)
        Me.numImage.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Image Time :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Volume :"
        '
        'TrkVolume
        '
        Me.TrkVolume.Location = New System.Drawing.Point(276, 139)
        Me.TrkVolume.Maximum = 100000
        Me.TrkVolume.Name = "TrkVolume"
        Me.TrkVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrkVolume.Size = New System.Drawing.Size(45, 124)
        Me.TrkVolume.TabIndex = 33
        Me.TrkVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrkVolume.Value = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TabPage2.Controls.Add(Me.BtnCencel)
        Me.TabPage2.Controls.Add(Me.BtnSave1)
        Me.TabPage2.Controls.Add(Me.BtnColor)
        Me.TabPage2.Controls.Add(Me.BtnFont)
        Me.TabPage2.Controls.Add(Me.NuSpeed)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtRunning)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(341, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Running Text"
        '
        'BtnCencel
        '
        Me.BtnCencel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCencel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnCencel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnCencel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnCencel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCencel.Location = New System.Drawing.Point(170, 213)
        Me.BtnCencel.Name = "BtnCencel"
        Me.BtnCencel.Size = New System.Drawing.Size(74, 47)
        Me.BtnCencel.TabIndex = 7
        Me.BtnCencel.Text = "&Cencel"
        Me.BtnCencel.UseVisualStyleBackColor = True
        '
        'BtnSave1
        '
        Me.BtnSave1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSave1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnSave1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnSave1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnSave1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSave1.Location = New System.Drawing.Point(250, 213)
        Me.BtnSave1.Name = "BtnSave1"
        Me.BtnSave1.Size = New System.Drawing.Size(74, 47)
        Me.BtnSave1.TabIndex = 8
        Me.BtnSave1.Text = "&Save"
        Me.BtnSave1.UseVisualStyleBackColor = True
        '
        'BtnColor
        '
        Me.BtnColor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnColor.Location = New System.Drawing.Point(10, 213)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(74, 47)
        Me.BtnColor.TabIndex = 9
        Me.BtnColor.Text = "&Color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'BtnFont
        '
        Me.BtnFont.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnFont.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.BtnFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnFont.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnFont.Location = New System.Drawing.Point(90, 213)
        Me.BtnFont.Name = "BtnFont"
        Me.BtnFont.Size = New System.Drawing.Size(74, 47)
        Me.BtnFont.TabIndex = 10
        Me.BtnFont.Text = "&Font"
        Me.BtnFont.UseVisualStyleBackColor = True
        '
        'NuSpeed
        '
        Me.NuSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NuSpeed.Location = New System.Drawing.Point(124, 189)
        Me.NuSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NuSpeed.Name = "NuSpeed"
        Me.NuSpeed.Size = New System.Drawing.Size(102, 20)
        Me.NuSpeed.TabIndex = 6
        Me.NuSpeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Speed Running Text"
        '
        'TxtRunning
        '
        Me.TxtRunning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRunning.Location = New System.Drawing.Point(7, 6)
        Me.TxtRunning.Multiline = True
        Me.TxtRunning.Name = "TxtRunning"
        Me.TxtRunning.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtRunning.Size = New System.Drawing.Size(328, 177)
        Me.TxtRunning.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(1, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 47)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Submite"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SettingMedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(353, 354)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingMedia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingMedia"
        CType(Me.numTv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.numImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrkVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NuSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents numTv As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnTV As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents CbInput As System.Windows.Forms.ComboBox
    Friend WithEvents CbDevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MediaList As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TrkVolume As System.Windows.Forms.TrackBar
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BtnCencel As System.Windows.Forms.Button
    Friend WithEvents BtnSave1 As System.Windows.Forms.Button
    Friend WithEvents BtnColor As System.Windows.Forms.Button
    Friend WithEvents BtnFont As System.Windows.Forms.Button
    Friend WithEvents NuSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtRunning As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents numImage As System.Windows.Forms.NumericUpDown
End Class
