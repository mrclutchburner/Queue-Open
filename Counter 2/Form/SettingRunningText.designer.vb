
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingRunningText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingRunningText))
        Me.SubmiteBtn = New System.Windows.Forms.Button()
        Me.BtnCencel = New System.Windows.Forms.Button()
        Me.BtnSave1 = New System.Windows.Forms.Button()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.BtnFont = New System.Windows.Forms.Button()
        Me.NuSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRunning = New System.Windows.Forms.TextBox()
        CType(Me.NuSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubmiteBtn
        '
        Me.SubmiteBtn.Location = New System.Drawing.Point(4, 210)
        Me.SubmiteBtn.Name = "SubmiteBtn"
        Me.SubmiteBtn.Size = New System.Drawing.Size(234, 41)
        Me.SubmiteBtn.TabIndex = 1
        Me.SubmiteBtn.Text = "Submite"
        Me.SubmiteBtn.UseVisualStyleBackColor = True
        '
        'BtnCencel
        '
        Me.BtnCencel.Location = New System.Drawing.Point(124, 165)
        Me.BtnCencel.Name = "BtnCencel"
        Me.BtnCencel.Size = New System.Drawing.Size(114, 39)
        Me.BtnCencel.TabIndex = 3
        Me.BtnCencel.Text = "&Cencel"
        Me.BtnCencel.UseVisualStyleBackColor = True
        '
        'BtnSave1
        '
        Me.BtnSave1.Location = New System.Drawing.Point(4, 165)
        Me.BtnSave1.Name = "BtnSave1"
        Me.BtnSave1.Size = New System.Drawing.Size(114, 39)
        Me.BtnSave1.TabIndex = 3
        Me.BtnSave1.Text = "&Save"
        Me.BtnSave1.UseVisualStyleBackColor = True
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(124, 120)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(114, 39)
        Me.BtnColor.TabIndex = 3
        Me.BtnColor.Text = "&Color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'BtnFont
        '
        Me.BtnFont.Location = New System.Drawing.Point(4, 120)
        Me.BtnFont.Name = "BtnFont"
        Me.BtnFont.Size = New System.Drawing.Size(114, 39)
        Me.BtnFont.TabIndex = 3
        Me.BtnFont.Text = "&Font"
        Me.BtnFont.UseVisualStyleBackColor = True
        '
        'NuSpeed
        '
        Me.NuSpeed.Location = New System.Drawing.Point(112, 94)
        Me.NuSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NuSpeed.Name = "NuSpeed"
        Me.NuSpeed.Size = New System.Drawing.Size(53, 20)
        Me.NuSpeed.TabIndex = 2
        Me.NuSpeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Speed Running Text"
        '
        'TxtRunning
        '
        Me.TxtRunning.Location = New System.Drawing.Point(4, 3)
        Me.TxtRunning.Multiline = True
        Me.TxtRunning.Name = "TxtRunning"
        Me.TxtRunning.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtRunning.Size = New System.Drawing.Size(234, 87)
        Me.TxtRunning.TabIndex = 0
        '
        'SettingRunningText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(242, 258)
        Me.Controls.Add(Me.BtnCencel)
        Me.Controls.Add(Me.SubmiteBtn)
        Me.Controls.Add(Me.BtnSave1)
        Me.Controls.Add(Me.BtnColor)
        Me.Controls.Add(Me.TxtRunning)
        Me.Controls.Add(Me.BtnFont)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NuSpeed)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingRunningText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Media Player"
        CType(Me.NuSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubmiteBtn As System.Windows.Forms.Button
    Friend WithEvents BtnCencel As System.Windows.Forms.Button
    Friend WithEvents BtnSave1 As System.Windows.Forms.Button
    Friend WithEvents BtnColor As System.Windows.Forms.Button
    Friend WithEvents BtnFont As System.Windows.Forms.Button
    Friend WithEvents NuSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtRunning As System.Windows.Forms.TextBox
End Class

