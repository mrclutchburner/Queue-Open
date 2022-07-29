Partial Public Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReportAll = New System.Windows.Forms.Button()
        Me.btnSOverall = New System.Windows.Forms.Button()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbtnUser = New System.Windows.Forms.RadioButton()
        Me.rbtnCounter = New System.Windows.Forms.RadioButton()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnDetailCounter = New System.Windows.Forms.Button()
        Me.cbCounter = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbUser = New System.Windows.Forms.RadioButton()
        Me.btnPerformance = New System.Windows.Forms.Button()
        Me.rbCounter = New System.Windows.Forms.RadioButton()
        Me.rbService = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnPeak = New System.Windows.Forms.Button()
        Me.rbDaily = New System.Windows.Forms.RadioButton()
        Me.rbHourly = New System.Windows.Forms.RadioButton()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbLayanan = New System.Windows.Forms.ComboBox()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.gbReport = New System.Windows.Forms.GroupBox()
        Me.lbLast = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lbPage = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.lblNomor = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pbFotoCustomer = New System.Windows.Forms.PictureBox()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        Me.groupBox8.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.gbReport.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbFotoCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = ""
        Me.dtpFrom.Location = New System.Drawing.Point(72, 19)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(178, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = ""
        Me.dtpTo.Location = New System.Drawing.Point(72, 50)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(178, 20)
        Me.dtpTo.TabIndex = 3
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.btnReportAll)
        Me.groupBox1.Controls.Add(Me.btnSOverall)
        Me.groupBox1.Controls.Add(Me.groupBox8)
        Me.groupBox1.Controls.Add(Me.groupBox6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.groupBox5)
        Me.groupBox1.Controls.Add(Me.groupBox4)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.dtpTo)
        Me.groupBox1.Controls.Add(Me.dtpFrom)
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(3, 7)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(258, 648)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Report Option"
        '
        'btnReportAll
        '
        Me.btnReportAll.Location = New System.Drawing.Point(139, 462)
        Me.btnReportAll.Name = "btnReportAll"
        Me.btnReportAll.Size = New System.Drawing.Size(111, 73)
        Me.btnReportAll.TabIndex = 13
        Me.btnReportAll.Text = "&Service Overall "
        Me.btnReportAll.UseVisualStyleBackColor = True
        '
        'btnSOverall
        '
        Me.btnSOverall.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnSOverall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSOverall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnSOverall.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSOverall.Location = New System.Drawing.Point(9, 462)
        Me.btnSOverall.Name = "btnSOverall"
        Me.btnSOverall.Size = New System.Drawing.Size(111, 73)
        Me.btnSOverall.TabIndex = 0
        Me.btnSOverall.Text = "&Service Overall Foto"
        Me.btnSOverall.UseVisualStyleBackColor = True
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.rbtnUser)
        Me.groupBox8.Controls.Add(Me.rbtnCounter)
        Me.groupBox8.Controls.Add(Me.label9)
        Me.groupBox8.Controls.Add(Me.btnDetailCounter)
        Me.groupBox8.Controls.Add(Me.cbCounter)
        Me.groupBox8.Controls.Add(Me.label8)
        Me.groupBox8.Controls.Add(Me.cbUser)
        Me.groupBox8.ForeColor = System.Drawing.Color.Black
        Me.groupBox8.Location = New System.Drawing.Point(9, 173)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(241, 115)
        Me.groupBox8.TabIndex = 11
        Me.groupBox8.TabStop = False
        Me.groupBox8.Text = "Detail Per Counter/User"
        '
        'rbtnUser
        '
        Me.rbtnUser.AutoSize = True
        Me.rbtnUser.Location = New System.Drawing.Point(76, 65)
        Me.rbtnUser.Name = "rbtnUser"
        Me.rbtnUser.Size = New System.Drawing.Size(47, 17)
        Me.rbtnUser.TabIndex = 7
        Me.rbtnUser.TabStop = True
        Me.rbtnUser.Text = "User"
        Me.rbtnUser.UseVisualStyleBackColor = True
        '
        'rbtnCounter
        '
        Me.rbtnCounter.AutoSize = True
        Me.rbtnCounter.Location = New System.Drawing.Point(76, 19)
        Me.rbtnCounter.Name = "rbtnCounter"
        Me.rbtnCounter.Size = New System.Drawing.Size(62, 17)
        Me.rbtnCounter.TabIndex = 6
        Me.rbtnCounter.TabStop = True
        Me.rbtnCounter.Text = "Counter"
        Me.rbtnCounter.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(6, 21)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(66, 13)
        Me.label9.TabIndex = 5
        Me.label9.Text = "Pilih Counter"
        '
        'btnDetailCounter
        '
        Me.btnDetailCounter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnDetailCounter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDetailCounter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnDetailCounter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDetailCounter.Location = New System.Drawing.Point(162, 16)
        Me.btnDetailCounter.Name = "btnDetailCounter"
        Me.btnDetailCounter.Size = New System.Drawing.Size(73, 91)
        Me.btnDetailCounter.TabIndex = 1
        Me.btnDetailCounter.Text = "Detail"
        Me.btnDetailCounter.UseVisualStyleBackColor = True
        '
        'cbCounter
        '
        Me.cbCounter.FormattingEnabled = True
        Me.cbCounter.Location = New System.Drawing.Point(9, 40)
        Me.cbCounter.Name = "cbCounter"
        Me.cbCounter.Size = New System.Drawing.Size(147, 21)
        Me.cbCounter.TabIndex = 4
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 67)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(51, 13)
        Me.label8.TabIndex = 3
        Me.label8.Text = "Pilih User"
        '
        'cbUser
        '
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(9, 86)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(147, 21)
        Me.cbUser.TabIndex = 2
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.rbUser)
        Me.groupBox6.Controls.Add(Me.btnPerformance)
        Me.groupBox6.Controls.Add(Me.rbCounter)
        Me.groupBox6.Controls.Add(Me.rbService)
        Me.groupBox6.ForeColor = System.Drawing.Color.Black
        Me.groupBox6.Location = New System.Drawing.Point(9, 292)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(241, 92)
        Me.groupBox6.TabIndex = 12
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "Service Performance Overall"
        '
        'rbUser
        '
        Me.rbUser.AutoSize = True
        Me.rbUser.Location = New System.Drawing.Point(9, 67)
        Me.rbUser.Name = "rbUser"
        Me.rbUser.Size = New System.Drawing.Size(78, 17)
        Me.rbUser.TabIndex = 3
        Me.rbUser.TabStop = True
        Me.rbUser.Text = "User Name"
        Me.rbUser.UseVisualStyleBackColor = True
        '
        'btnPerformance
        '
        Me.btnPerformance.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnPerformance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPerformance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPerformance.Location = New System.Drawing.Point(117, 19)
        Me.btnPerformance.Name = "btnPerformance"
        Me.btnPerformance.Size = New System.Drawing.Size(118, 62)
        Me.btnPerformance.TabIndex = 2
        Me.btnPerformance.Text = "Service Pervormance"
        Me.btnPerformance.UseVisualStyleBackColor = True
        '
        'rbCounter
        '
        Me.rbCounter.AutoSize = True
        Me.rbCounter.Location = New System.Drawing.Point(9, 42)
        Me.rbCounter.Name = "rbCounter"
        Me.rbCounter.Size = New System.Drawing.Size(102, 17)
        Me.rbCounter.TabIndex = 1
        Me.rbCounter.TabStop = True
        Me.rbCounter.Text = "Counter Number"
        Me.rbCounter.UseVisualStyleBackColor = True
        '
        'rbService
        '
        Me.rbService.AutoSize = True
        Me.rbService.Location = New System.Drawing.Point(9, 19)
        Me.rbService.Name = "rbService"
        Me.rbService.Size = New System.Drawing.Size(92, 17)
        Me.rbService.TabIndex = 0
        Me.rbService.TabStop = True
        Me.rbService.Text = "Service Name"
        Me.rbService.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 54)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Date To    :"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.btnPeak)
        Me.groupBox5.Controls.Add(Me.rbDaily)
        Me.groupBox5.Controls.Add(Me.rbHourly)
        Me.groupBox5.ForeColor = System.Drawing.Color.Black
        Me.groupBox5.Location = New System.Drawing.Point(9, 388)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(241, 68)
        Me.groupBox5.TabIndex = 11
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Peak Service Time"
        '
        'btnPeak
        '
        Me.btnPeak.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnPeak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPeak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnPeak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPeak.Location = New System.Drawing.Point(103, 19)
        Me.btnPeak.Name = "btnPeak"
        Me.btnPeak.Size = New System.Drawing.Size(132, 40)
        Me.btnPeak.TabIndex = 2
        Me.btnPeak.Text = "Peak Service Time"
        Me.btnPeak.UseVisualStyleBackColor = True
        '
        'rbDaily
        '
        Me.rbDaily.AutoSize = True
        Me.rbDaily.Location = New System.Drawing.Point(9, 42)
        Me.rbDaily.Name = "rbDaily"
        Me.rbDaily.Size = New System.Drawing.Size(75, 17)
        Me.rbDaily.TabIndex = 1
        Me.rbDaily.TabStop = True
        Me.rbDaily.Text = "Daily Base"
        Me.rbDaily.UseVisualStyleBackColor = True
        '
        'rbHourly
        '
        Me.rbHourly.AutoSize = True
        Me.rbHourly.Location = New System.Drawing.Point(9, 19)
        Me.rbHourly.Name = "rbHourly"
        Me.rbHourly.Size = New System.Drawing.Size(82, 17)
        Me.rbHourly.TabIndex = 0
        Me.rbHourly.TabStop = True
        Me.rbHourly.Text = "Hourly Base"
        Me.rbHourly.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.label7)
        Me.groupBox4.Controls.Add(Me.cbLayanan)
        Me.groupBox4.Controls.Add(Me.btnDetail)
        Me.groupBox4.ForeColor = System.Drawing.Color.Black
        Me.groupBox4.Location = New System.Drawing.Point(9, 74)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(241, 95)
        Me.groupBox4.TabIndex = 10
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Detail Per Service"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(6, 19)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(76, 13)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Pilih Layanan :"
        '
        'cbLayanan
        '
        Me.cbLayanan.FormattingEnabled = True
        Me.cbLayanan.Location = New System.Drawing.Point(86, 16)
        Me.cbLayanan.Name = "cbLayanan"
        Me.cbLayanan.Size = New System.Drawing.Size(149, 21)
        Me.cbLayanan.TabIndex = 2
        '
        'btnDetail
        '
        Me.btnDetail.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDetail.Location = New System.Drawing.Point(9, 43)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(226, 46)
        Me.btnDetail.TabIndex = 1
        Me.btnDetail.Text = "Detail"
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Date From :"
        '
        'gbReport
        '
        Me.gbReport.Controls.Add(Me.lbLast)
        Me.gbReport.Controls.Add(Me.btnFirst)
        Me.gbReport.Controls.Add(Me.label6)
        Me.gbReport.Controls.Add(Me.btnNext)
        Me.gbReport.Controls.Add(Me.lbPage)
        Me.gbReport.Controls.Add(Me.btnLast)
        Me.gbReport.Controls.Add(Me.label5)
        Me.gbReport.Controls.Add(Me.btnPrev)
        Me.gbReport.ForeColor = System.Drawing.Color.Black
        Me.gbReport.Location = New System.Drawing.Point(271, 7)
        Me.gbReport.Name = "gbReport"
        Me.gbReport.Size = New System.Drawing.Size(1060, 64)
        Me.gbReport.TabIndex = 13
        Me.gbReport.TabStop = False
        Me.gbReport.Text = "Report Navigator "
        '
        'lbLast
        '
        Me.lbLast.AutoSize = True
        Me.lbLast.ForeColor = System.Drawing.Color.Black
        Me.lbLast.Location = New System.Drawing.Point(939, 28)
        Me.lbLast.Name = "lbLast"
        Me.lbLast.Size = New System.Drawing.Size(13, 13)
        Me.lbLast.TabIndex = 20
        Me.lbLast.Text = "0"
        '
        'btnFirst
        '
        Me.btnFirst.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.Location = New System.Drawing.Point(12, 19)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 35)
        Me.btnFirst.TabIndex = 13
        Me.btnFirst.Text = "First Page"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(909, 28)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(30, 13)
        Me.label6.TabIndex = 19
        Me.label6.Text = "OF : "
        '
        'btnNext
        '
        Me.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(106, 19)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 35)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lbPage
        '
        Me.lbPage.AutoSize = True
        Me.lbPage.ForeColor = System.Drawing.Color.Black
        Me.lbPage.Location = New System.Drawing.Point(821, 28)
        Me.lbPage.Name = "lbPage"
        Me.lbPage.Size = New System.Drawing.Size(13, 13)
        Me.lbPage.TabIndex = 18
        Me.lbPage.Text = "0"
        '
        'btnLast
        '
        Me.btnLast.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.Location = New System.Drawing.Point(294, 19)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 35)
        Me.btnLast.TabIndex = 16
        Me.btnLast.Text = "Last Page"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(779, 28)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(46, 13)
        Me.label5.TabIndex = 17
        Me.label5.Text = "Pages : "
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrev.ForeColor = System.Drawing.Color.Black
        Me.btnPrev.Location = New System.Drawing.Point(200, 19)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 35)
        Me.btnPrev.TabIndex = 15
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(6, 29)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(153, 45)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Jenis Laporan            :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Durasi                         :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Waktu Pengambilan  " & _
            " :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCounter)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblJenis)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblWaktu)
        Me.GroupBox2.Controls.Add(Me.lblNomor)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.dgvReport)
        Me.GroupBox2.Controls.Add(Me.label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(271, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1060, 590)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(855, 102)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(122, 16)
        Me.lblCounter.TabIndex = 6
        Me.lblCounter.Text = "......................................"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(722, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Counter Pelayanan"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(855, 76)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(122, 16)
        Me.lblJenis.TabIndex = 6
        Me.lblJenis.Text = "......................................"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(722, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Jenis Pelayanan"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.Location = New System.Drawing.Point(855, 50)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(122, 16)
        Me.lblWaktu.TabIndex = 6
        Me.lblWaktu.Text = "......................................"
        '
        'lblNomor
        '
        Me.lblNomor.AutoSize = True
        Me.lblNomor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomor.Location = New System.Drawing.Point(855, 24)
        Me.lblNomor.Name = "lblNomor"
        Me.lblNomor.Size = New System.Drawing.Size(122, 16)
        Me.lblNomor.TabIndex = 6
        Me.lblNomor.Text = "......................................"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(722, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(722, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nomor Antrian"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pbFotoCustomer)
        Me.GroupBox3.Location = New System.Drawing.Point(565, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(151, 113)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'pbFotoCustomer
        '
        Me.pbFotoCustomer.BackColor = System.Drawing.Color.Black
        Me.pbFotoCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFotoCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFotoCustomer.Location = New System.Drawing.Point(6, 13)
        Me.pbFotoCustomer.Name = "pbFotoCustomer"
        Me.pbFotoCustomer.Size = New System.Drawing.Size(138, 96)
        Me.pbFotoCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFotoCustomer.TabIndex = 4
        Me.pbFotoCustomer.TabStop = False
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(7, 128)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.Size = New System.Drawing.Size(1047, 454)
        Me.dgvReport.TabIndex = 3
        '
        'Report
        '
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1335, 666)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbReport)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox8.ResumeLayout(False)
        Me.groupBox8.PerformLayout()
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.gbReport.ResumeLayout(False)
        Me.gbReport.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pbFotoCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dtpFrom As DateTimePicker
    Private dtpTo As DateTimePicker
    Private groupBox1 As GroupBox
    Private label3 As Label
    Private label1 As Label
    Private WithEvents btnSOverall As Button
    Private groupBox5 As GroupBox
    Private groupBox4 As GroupBox
    Private WithEvents btnPeak As Button
    Private rbDaily As RadioButton
    Private rbHourly As RadioButton
    Private groupBox6 As GroupBox
    Private rbUser As RadioButton
    Private WithEvents btnPerformance As Button
    Private rbCounter As RadioButton
    Private rbService As RadioButton
    Private label4 As Label
    Private gbReport As GroupBox
    Private lbLast As Label
    Private WithEvents btnFirst As Button
    Private label6 As Label
    Private WithEvents btnNext As Button
    Private lbPage As Label
    Private WithEvents btnPrev As Button
    Private label5 As Label
    Private WithEvents btnLast As Button
    'Private cellExport As Spire.DataExport.XLS.CellExport
    Private WithEvents btnDetail As Button
    Private label7 As Label
    Private cbLayanan As ComboBox
    Private groupBox8 As GroupBox
    Private label9 As Label
    Private cbCounter As ComboBox
    Private label8 As Label
    Private cbUser As ComboBox
    Private WithEvents btnDetailCounter As Button
    Private rbtnUser As RadioButton
    Private rbtnCounter As RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReportAll As System.Windows.Forms.Button
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents pbFotoCustomer As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents lblWaktu As System.Windows.Forms.Label
    Friend WithEvents lblNomor As System.Windows.Forms.Label
End Class