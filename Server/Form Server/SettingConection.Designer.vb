<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingConection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingConection))
        Me.btnTest = New System.Windows.Forms.Button()
        Me.ButttnConnect = New System.Windows.Forms.Button()
        Me.lblTimeout = New System.Windows.Forms.Label()
        Me.lblBaudRate = New System.Windows.Forms.Label()
        Me.cboTimeout = New System.Windows.Forms.ComboBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.cboPort = New System.Windows.Forms.ComboBox()
        Me.cboBaudRate = New System.Windows.Forms.ComboBox()
        Me.dgvLayanan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.numIndex = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.txtLayanan = New System.Windows.Forms.TextBox()
        Me.btnSubmite = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvLayanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(20, 130)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(102, 43)
        Me.btnTest.TabIndex = 15
        Me.btnTest.Text = "&Test Connection"
        '
        'ButttnConnect
        '
        Me.ButttnConnect.Location = New System.Drawing.Point(128, 130)
        Me.ButttnConnect.Name = "ButttnConnect"
        Me.ButttnConnect.Size = New System.Drawing.Size(102, 43)
        Me.ButttnConnect.TabIndex = 16
        Me.ButttnConnect.Text = "Connect"
        '
        'lblTimeout
        '
        Me.lblTimeout.AutoSize = True
        Me.lblTimeout.Location = New System.Drawing.Point(18, 86)
        Me.lblTimeout.Name = "lblTimeout"
        Me.lblTimeout.Size = New System.Drawing.Size(70, 13)
        Me.lblTimeout.TabIndex = 13
        Me.lblTimeout.Text = "Ti&meout (ms):"
        Me.lblTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.Location = New System.Drawing.Point(19, 56)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(56, 13)
        Me.lblBaudRate.TabIndex = 11
        Me.lblBaudRate.Text = "&Baud rate:"
        Me.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTimeout
        '
        Me.cboTimeout.Items.AddRange(New Object() {"150", "300", "600", "900", "1200", "1500", "1800", "2000"})
        Me.cboTimeout.Location = New System.Drawing.Point(128, 85)
        Me.cboTimeout.Name = "cboTimeout"
        Me.cboTimeout.Size = New System.Drawing.Size(104, 21)
        Me.cboTimeout.TabIndex = 14
        Me.cboTimeout.Text = "300"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(19, 26)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(58, 13)
        Me.lblPort.TabIndex = 9
        Me.lblPort.Text = "&Port name:"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPort
        '
        Me.cboPort.Location = New System.Drawing.Point(128, 23)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(104, 21)
        Me.cboPort.TabIndex = 10
        '
        'cboBaudRate
        '
        Me.cboBaudRate.Items.AddRange(New Object() {"110", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"})
        Me.cboBaudRate.Location = New System.Drawing.Point(128, 54)
        Me.cboBaudRate.Name = "cboBaudRate"
        Me.cboBaudRate.Size = New System.Drawing.Size(104, 21)
        Me.cboBaudRate.TabIndex = 12
        Me.cboBaudRate.Text = "115200"
        '
        'dgvLayanan
        '
        Me.dgvLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLayanan.Location = New System.Drawing.Point(199, 26)
        Me.dgvLayanan.Name = "dgvLayanan"
        Me.dgvLayanan.Size = New System.Drawing.Size(264, 147)
        Me.dgvLayanan.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPort)
        Me.GroupBox1.Controls.Add(Me.cboBaudRate)
        Me.GroupBox1.Controls.Add(Me.btnTest)
        Me.GroupBox1.Controls.Add(Me.cboPort)
        Me.GroupBox1.Controls.Add(Me.ButttnConnect)
        Me.GroupBox1.Controls.Add(Me.cboTimeout)
        Me.GroupBox1.Controls.Add(Me.lblTimeout)
        Me.GroupBox1.Controls.Add(Me.lblBaudRate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 216)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONNECTION"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblFormat)
        Me.GroupBox2.Controls.Add(Me.numIndex)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFormat)
        Me.GroupBox2.Controls.Add(Me.txtLayanan)
        Me.GroupBox2.Controls.Add(Me.dgvLayanan)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 216)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SMS LAYANAN"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(9, 165)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(78, 36)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(103, 122)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(78, 36)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(103, 164)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 36)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(9, 122)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 36)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(196, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "TABEL FORMAT SMS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.ForeColor = System.Drawing.Color.Red
        Me.lblFormat.Location = New System.Drawing.Point(196, 188)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(78, 13)
        Me.lblFormat.TabIndex = 23
        Me.lblFormat.Text = "FORMAT SMS"
        Me.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numIndex
        '
        Me.numIndex.Location = New System.Drawing.Point(87, 56)
        Me.numIndex.Name = "numIndex"
        Me.numIndex.Size = New System.Drawing.Size(94, 20)
        Me.numIndex.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "FORMAT SMS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Index Layanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Layanan"
        '
        'txtFormat
        '
        Me.txtFormat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFormat.Location = New System.Drawing.Point(87, 86)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(94, 20)
        Me.txtFormat.TabIndex = 19
        Me.txtFormat.Text = "ANTRIAN"
        '
        'txtLayanan
        '
        Me.txtLayanan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLayanan.Location = New System.Drawing.Point(87, 26)
        Me.txtLayanan.Name = "txtLayanan"
        Me.txtLayanan.Size = New System.Drawing.Size(94, 20)
        Me.txtLayanan.TabIndex = 19
        '
        'btnSubmite
        '
        Me.btnSubmite.Location = New System.Drawing.Point(660, 234)
        Me.btnSubmite.Name = "btnSubmite"
        Me.btnSubmite.Size = New System.Drawing.Size(95, 39)
        Me.btnSubmite.TabIndex = 21
        Me.btnSubmite.Text = "SUBMITE"
        Me.btnSubmite.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(423, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "*TEKAN KOLOM TABEL UTUK MENGETAHUI FORMAT SMS"
        '
        'SettingConection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 285)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSubmite)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingConection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conection SMS"
        CType(Me.dgvLayanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnTest As System.Windows.Forms.Button
    Private WithEvents ButttnConnect As System.Windows.Forms.Button
    Private WithEvents lblTimeout As System.Windows.Forms.Label
    Private WithEvents lblBaudRate As System.Windows.Forms.Label
    Private WithEvents cboTimeout As System.Windows.Forms.ComboBox
    Private WithEvents lblPort As System.Windows.Forms.Label
    Private WithEvents cboPort As System.Windows.Forms.ComboBox
    Private WithEvents cboBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents dgvLayanan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents numIndex As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFormat As System.Windows.Forms.TextBox
    Friend WithEvents txtLayanan As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSubmite As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
