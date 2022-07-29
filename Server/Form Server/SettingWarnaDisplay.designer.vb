Partial Public Class SettingWarnaDisplay
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingWarnaDisplay))
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.btnTextSisa = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMainNumber = New System.Windows.Forms.Button()
        Me.btnMainLoket = New System.Windows.Forms.Button()
        Me.btnMainService = New System.Windows.Forms.Button()
        Me.gbCounter = New System.Windows.Forms.GroupBox()
        Me.btnGaris = New System.Windows.Forms.Button()
        Me.btnCounterNomor = New System.Windows.Forms.Button()
        Me.btnCounterNama = New System.Windows.Forms.Button()
        Me.btnCounterService = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbTanggal = New System.Windows.Forms.GroupBox()
        Me.btnTanggal = New System.Windows.Forms.Button()
        Me.btnJam = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnFont7 = New System.Windows.Forms.Button()
        Me.btnFont5 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFont11 = New System.Windows.Forms.Button()
        Me.btnFont4 = New System.Windows.Forms.Button()
        Me.btnFont2 = New System.Windows.Forms.Button()
        Me.btnFont3 = New System.Windows.Forms.Button()
        Me.btnFont1 = New System.Windows.Forms.Button()
        Me.gbMain.SuspendLayout()
        Me.gbCounter.SuspendLayout()
        Me.gbTanggal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.btnTextSisa)
        Me.gbMain.Controls.Add(Me.Button1)
        Me.gbMain.Controls.Add(Me.btnMainNumber)
        Me.gbMain.Controls.Add(Me.btnMainLoket)
        Me.gbMain.Controls.Add(Me.btnMainService)
        Me.gbMain.Location = New System.Drawing.Point(7, 19)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(248, 214)
        Me.gbMain.TabIndex = 0
        Me.gbMain.TabStop = False
        Me.gbMain.Text = "Main Display"
        '
        'btnTextSisa
        '
        Me.btnTextSisa.Location = New System.Drawing.Point(126, 118)
        Me.btnTextSisa.Name = "btnTextSisa"
        Me.btnTextSisa.Size = New System.Drawing.Size(112, 45)
        Me.btnTextSisa.TabIndex = 4
        Me.btnTextSisa.Text = "Warna Layanan Sisa"
        Me.btnTextSisa.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Warna Sisa Antrian"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMainNumber
        '
        Me.btnMainNumber.Location = New System.Drawing.Point(9, 67)
        Me.btnMainNumber.Name = "btnMainNumber"
        Me.btnMainNumber.Size = New System.Drawing.Size(112, 46)
        Me.btnMainNumber.TabIndex = 2
        Me.btnMainNumber.Text = "Warna Nomor Antrian"
        Me.btnMainNumber.UseVisualStyleBackColor = True
        '
        'btnMainLoket
        '
        Me.btnMainLoket.Location = New System.Drawing.Point(127, 19)
        Me.btnMainLoket.Name = "btnMainLoket"
        Me.btnMainLoket.Size = New System.Drawing.Size(112, 46)
        Me.btnMainLoket.TabIndex = 0
        Me.btnMainLoket.Text = "Warna Nama Sisa"
        Me.btnMainLoket.UseVisualStyleBackColor = True
        '
        'btnMainService
        '
        Me.btnMainService.Location = New System.Drawing.Point(9, 19)
        Me.btnMainService.Name = "btnMainService"
        Me.btnMainService.Size = New System.Drawing.Size(112, 46)
        Me.btnMainService.TabIndex = 1
        Me.btnMainService.Text = "Warna Abjad Layanan"
        Me.btnMainService.UseVisualStyleBackColor = True
        '
        'gbCounter
        '
        Me.gbCounter.Controls.Add(Me.btnGaris)
        Me.gbCounter.Controls.Add(Me.btnCounterNomor)
        Me.gbCounter.Controls.Add(Me.btnCounterNama)
        Me.gbCounter.Controls.Add(Me.btnCounterService)
        Me.gbCounter.Location = New System.Drawing.Point(260, 19)
        Me.gbCounter.Name = "gbCounter"
        Me.gbCounter.Size = New System.Drawing.Size(248, 127)
        Me.gbCounter.TabIndex = 1
        Me.gbCounter.TabStop = False
        Me.gbCounter.Text = "Counter Display"
        '
        'btnGaris
        '
        Me.btnGaris.Location = New System.Drawing.Point(126, 71)
        Me.btnGaris.Name = "btnGaris"
        Me.btnGaris.Size = New System.Drawing.Size(112, 46)
        Me.btnGaris.TabIndex = 6
        Me.btnGaris.Text = "Warna Garis Batas"
        Me.btnGaris.UseVisualStyleBackColor = True
        '
        'btnCounterNomor
        '
        Me.btnCounterNomor.Location = New System.Drawing.Point(126, 19)
        Me.btnCounterNomor.Name = "btnCounterNomor"
        Me.btnCounterNomor.Size = New System.Drawing.Size(112, 46)
        Me.btnCounterNomor.TabIndex = 5
        Me.btnCounterNomor.Text = "Warna Nomor Antrian"
        Me.btnCounterNomor.UseVisualStyleBackColor = True
        '
        'btnCounterNama
        '
        Me.btnCounterNama.Location = New System.Drawing.Point(6, 19)
        Me.btnCounterNama.Name = "btnCounterNama"
        Me.btnCounterNama.Size = New System.Drawing.Size(112, 46)
        Me.btnCounterNama.TabIndex = 3
        Me.btnCounterNama.Text = "Warna Nama Loket"
        Me.btnCounterNama.UseVisualStyleBackColor = True
        '
        'btnCounterService
        '
        Me.btnCounterService.Location = New System.Drawing.Point(6, 71)
        Me.btnCounterService.Name = "btnCounterService"
        Me.btnCounterService.Size = New System.Drawing.Size(112, 46)
        Me.btnCounterService.TabIndex = 4
        Me.btnCounterService.Text = "Warna Abjad Layanan"
        Me.btnCounterService.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(951, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 39)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Submite"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbTanggal
        '
        Me.gbTanggal.Controls.Add(Me.btnTanggal)
        Me.gbTanggal.Controls.Add(Me.btnJam)
        Me.gbTanggal.Location = New System.Drawing.Point(260, 152)
        Me.gbTanggal.Name = "gbTanggal"
        Me.gbTanggal.Size = New System.Drawing.Size(248, 81)
        Me.gbTanggal.TabIndex = 3
        Me.gbTanggal.TabStop = False
        Me.gbTanggal.Text = "Jam/Tanggal"
        '
        'btnTanggal
        '
        Me.btnTanggal.Location = New System.Drawing.Point(127, 19)
        Me.btnTanggal.Name = "btnTanggal"
        Me.btnTanggal.Size = New System.Drawing.Size(112, 46)
        Me.btnTanggal.TabIndex = 4
        Me.btnTanggal.Text = "Warna Tanggal"
        Me.btnTanggal.UseVisualStyleBackColor = True
        '
        'btnJam
        '
        Me.btnJam.Location = New System.Drawing.Point(6, 19)
        Me.btnJam.Name = "btnJam"
        Me.btnJam.Size = New System.Drawing.Size(112, 46)
        Me.btnJam.TabIndex = 3
        Me.btnJam.Text = "Warna Jam"
        Me.btnJam.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbMain)
        Me.GroupBox1.Controls.Add(Me.gbTanggal)
        Me.GroupBox1.Controls.Add(Me.gbCounter)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 248)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Warna"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(534, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 248)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnFont7)
        Me.GroupBox4.Controls.Add(Me.btnFont5)
        Me.GroupBox4.Location = New System.Drawing.Point(260, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 127)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Counter Display"
        '
        'btnFont7
        '
        Me.btnFont7.Location = New System.Drawing.Point(127, 19)
        Me.btnFont7.Name = "btnFont7"
        Me.btnFont7.Size = New System.Drawing.Size(112, 46)
        Me.btnFont7.TabIndex = 6
        Me.btnFont7.Text = "Font Warna Nomor Antrian"
        Me.btnFont7.UseVisualStyleBackColor = True
        '
        'btnFont5
        '
        Me.btnFont5.Location = New System.Drawing.Point(9, 19)
        Me.btnFont5.Name = "btnFont5"
        Me.btnFont5.Size = New System.Drawing.Size(112, 46)
        Me.btnFont5.TabIndex = 6
        Me.btnFont5.Text = "Font Nama Loket"
        Me.btnFont5.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Controls.Add(Me.Button13)
        Me.GroupBox5.Location = New System.Drawing.Point(260, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(248, 81)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Jam / Tanggal"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(127, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(112, 46)
        Me.Button11.TabIndex = 6
        Me.Button11.Text = "Font Tanggal"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(9, 19)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(112, 46)
        Me.Button13.TabIndex = 6
        Me.Button13.Text = "Font Jam"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnFont11)
        Me.GroupBox3.Controls.Add(Me.btnFont4)
        Me.GroupBox3.Controls.Add(Me.btnFont2)
        Me.GroupBox3.Controls.Add(Me.btnFont3)
        Me.GroupBox3.Controls.Add(Me.btnFont1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 214)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Main Display"
        '
        'btnFont11
        '
        Me.btnFont11.Location = New System.Drawing.Point(127, 133)
        Me.btnFont11.Name = "btnFont11"
        Me.btnFont11.Size = New System.Drawing.Size(112, 46)
        Me.btnFont11.TabIndex = 7
        Me.btnFont11.Text = "Font Text Sisa"
        Me.btnFont11.UseVisualStyleBackColor = True
        '
        'btnFont4
        '
        Me.btnFont4.Location = New System.Drawing.Point(127, 75)
        Me.btnFont4.Name = "btnFont4"
        Me.btnFont4.Size = New System.Drawing.Size(112, 46)
        Me.btnFont4.TabIndex = 6
        Me.btnFont4.Text = "Font Warna Sisa Antrian"
        Me.btnFont4.UseVisualStyleBackColor = True
        '
        'btnFont2
        '
        Me.btnFont2.Location = New System.Drawing.Point(127, 19)
        Me.btnFont2.Name = "btnFont2"
        Me.btnFont2.Size = New System.Drawing.Size(112, 46)
        Me.btnFont2.TabIndex = 6
        Me.btnFont2.Text = "Font Layanan Sisa"
        Me.btnFont2.UseVisualStyleBackColor = True
        '
        'btnFont3
        '
        Me.btnFont3.Location = New System.Drawing.Point(9, 75)
        Me.btnFont3.Name = "btnFont3"
        Me.btnFont3.Size = New System.Drawing.Size(112, 46)
        Me.btnFont3.TabIndex = 6
        Me.btnFont3.Text = "Font Nomor Antrian"
        Me.btnFont3.UseVisualStyleBackColor = True
        '
        'btnFont1
        '
        Me.btnFont1.Location = New System.Drawing.Point(9, 19)
        Me.btnFont1.Name = "btnFont1"
        Me.btnFont1.Size = New System.Drawing.Size(112, 46)
        Me.btnFont1.TabIndex = 6
        Me.btnFont1.Text = "Font Layanan"
        Me.btnFont1.UseVisualStyleBackColor = True
        '
        'SettingWarnaDisplay
        '
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1061, 315)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingWarnaDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Warna Display"
        Me.gbMain.ResumeLayout(False)
        Me.gbCounter.ResumeLayout(False)
        Me.gbTanggal.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private gbMain As GroupBox
    Private gbCounter As GroupBox
    Private WithEvents btnMainLoket As Button
    Private WithEvents btnMainNumber As Button
    Private WithEvents btnMainService As Button
    Private WithEvents btnGaris As Button
    Private WithEvents btnCounterNomor As Button
    Private WithEvents btnCounterService As Button
    Private WithEvents btnCounterNama As Button
    Private WithEvents btnSave As Button
    Private gbTanggal As GroupBox
    Private WithEvents btnTanggal As Button
    Private WithEvents btnJam As Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFont7 As System.Windows.Forms.Button
    Friend WithEvents btnFont5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFont4 As System.Windows.Forms.Button
    Friend WithEvents btnFont2 As System.Windows.Forms.Button
    Friend WithEvents btnFont3 As System.Windows.Forms.Button
    Friend WithEvents btnFont1 As System.Windows.Forms.Button
    Friend WithEvents btnTextSisa As System.Windows.Forms.Button
    Friend WithEvents btnFont11 As System.Windows.Forms.Button
End Class