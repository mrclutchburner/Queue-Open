Partial Public Class frmNew
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.nudHeight = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.nudWidth = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cboUnit = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(15, 78)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 36)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'nudHeight
        '
        Me.nudHeight.DecimalPlaces = 4
        Me.nudHeight.Location = New System.Drawing.Point(230, 42)
        Me.nudHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudHeight.Name = "nudHeight"
        Me.nudHeight.Size = New System.Drawing.Size(96, 20)
        Me.nudHeight.TabIndex = 21
        Me.nudHeight.Value = New Decimal(New Integer() {288, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(179, 44)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 13)
        Me.label3.TabIndex = 20
        Me.label3.Text = "Height:"
        '
        'nudWidth
        '
        Me.nudWidth.DecimalPlaces = 4
        Me.nudWidth.Location = New System.Drawing.Point(64, 42)
        Me.nudWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.Size = New System.Drawing.Size(96, 20)
        Me.nudWidth.TabIndex = 19
        Me.nudWidth.Value = New Decimal(New Integer() {384, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 44)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Width:"
        '
        'cboUnit
        '
        Me.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Items.AddRange(New Object() {"Cm", "Inch", "Mm", "Pixel"})
        Me.cboUnit.Location = New System.Drawing.Point(53, 7)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(95, 21)
        Me.cboUnit.TabIndex = 17
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Unit:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(109, 78)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmNew
        '
        Me.ClientSize = New System.Drawing.Size(338, 127)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.nudHeight)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.nudWidth)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Design Page Size Setting"
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents btnOK As Button
    Private nudHeight As NumericUpDown
    Private label3 As Label
    Private nudWidth As NumericUpDown
    Private label2 As Label
    Private WithEvents cboUnit As ComboBox
    Private label1 As Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
