<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingPrinter
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnSubmite = New System.Windows.Forms.Button()
        Me.numDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSettingPrinter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudPrint = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudHours1 = New System.Windows.Forms.NumericUpDown()
        Me.nudMinute1 = New System.Windows.Forms.NumericUpDown()
        Me.lblDelay = New System.Windows.Forms.Label()
        CType(Me.numDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHours1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinute1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Using Tiket"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(92, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox1.TabIndex = 62
        '
        'btnSubmite
        '
        Me.btnSubmite.Location = New System.Drawing.Point(120, 134)
        Me.btnSubmite.Name = "btnSubmite"
        Me.btnSubmite.Size = New System.Drawing.Size(94, 42)
        Me.btnSubmite.TabIndex = 60
        Me.btnSubmite.Text = "Submite"
        Me.btnSubmite.UseVisualStyleBackColor = True
        '
        'numDelay
        '
        Me.numDelay.Location = New System.Drawing.Point(92, 76)
        Me.numDelay.Name = "numDelay"
        Me.numDelay.Size = New System.Drawing.Size(53, 20)
        Me.numDelay.TabIndex = 59
        Me.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDelay.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Delay Tombol"
        '
        'btnSettingPrinter
        '
        Me.btnSettingPrinter.Location = New System.Drawing.Point(20, 134)
        Me.btnSettingPrinter.Name = "btnSettingPrinter"
        Me.btnSettingPrinter.Size = New System.Drawing.Size(94, 42)
        Me.btnSettingPrinter.TabIndex = 57
        Me.btnSettingPrinter.Text = "&Setting Printer"
        Me.btnSettingPrinter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Print Copies"
        '
        'nudPrint
        '
        Me.nudPrint.Location = New System.Drawing.Point(92, 50)
        Me.nudPrint.Name = "nudPrint"
        Me.nudPrint.Size = New System.Drawing.Size(53, 20)
        Me.nudPrint.TabIndex = 56
        Me.nudPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPrint.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "IP Server"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(92, 19)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(122, 20)
        Me.txtIP.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Waktu Antrian Tutup :"
        '
        'nudHours1
        '
        Me.nudHours1.Location = New System.Drawing.Point(360, 21)
        Me.nudHours1.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudHours1.Name = "nudHours1"
        Me.nudHours1.Size = New System.Drawing.Size(36, 20)
        Me.nudHours1.TabIndex = 66
        '
        'nudMinute1
        '
        Me.nudMinute1.Location = New System.Drawing.Point(402, 21)
        Me.nudMinute1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudMinute1.Name = "nudMinute1"
        Me.nudMinute1.Size = New System.Drawing.Size(35, 20)
        Me.nudMinute1.TabIndex = 66
        '
        'lblDelay
        '
        Me.lblDelay.AutoSize = True
        Me.lblDelay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDelay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelay.Location = New System.Drawing.Point(444, 24)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(67, 14)
        Me.lblDelay.TabIndex = 67
        Me.lblDelay.Text = " (HH : MM)"
        '
        'SettingPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(528, 188)
        Me.Controls.Add(Me.lblDelay)
        Me.Controls.Add(Me.nudMinute1)
        Me.Controls.Add(Me.nudHours1)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSubmite)
        Me.Controls.Add(Me.numDelay)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSettingPrinter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudPrint)
        Me.Name = "SettingPrinter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Printer"
        CType(Me.numDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHours1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinute1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmite As System.Windows.Forms.Button
    Friend WithEvents numDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSettingPrinter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudPrint As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudHours1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMinute1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDelay As System.Windows.Forms.Label
End Class
