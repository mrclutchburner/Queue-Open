<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PrintNomor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintNomor))
        Me.btnPrintA = New System.Windows.Forms.Button()
        Me.lbNomor = New System.Windows.Forms.Label()
        Me.lblTetx = New System.Windows.Forms.TextBox()
        Me.btnPrintD = New System.Windows.Forms.Button()
        Me.btnPrintE = New System.Windows.Forms.Button()
        Me.btnPrintB = New System.Windows.Forms.Button()
        Me.btnPrintC = New System.Windows.Forms.Button()
        Me.btnPrintF = New System.Windows.Forms.Button()
        Me.tmDelay = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnPrintA
        '
        Me.btnPrintA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintA.Location = New System.Drawing.Point(13, 67)
        Me.btnPrintA.Name = "btnPrintA"
        Me.btnPrintA.Size = New System.Drawing.Size(166, 51)
        Me.btnPrintA.TabIndex = 0
        Me.btnPrintA.Text = "&Print Nomor"
        Me.btnPrintA.UseVisualStyleBackColor = True
        '
        'lbNomor
        '
        Me.lbNomor.AutoSize = True
        Me.lbNomor.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomor.Location = New System.Drawing.Point(201, 4)
        Me.lbNomor.Name = "lbNomor"
        Me.lbNomor.Size = New System.Drawing.Size(136, 55)
        Me.lbNomor.TabIndex = 1
        Me.lbNomor.Text = "-------"
        Me.lbNomor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTetx
        '
        Me.lblTetx.BackColor = System.Drawing.SystemColors.Control
        Me.lblTetx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblTetx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTetx.Location = New System.Drawing.Point(12, 181)
        Me.lblTetx.Multiline = True
        Me.lblTetx.Name = "lblTetx"
        Me.lblTetx.Size = New System.Drawing.Size(166, 28)
        Me.lblTetx.TabIndex = 2
        Me.lblTetx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrintD
        '
        Me.btnPrintD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintD.Location = New System.Drawing.Point(12, 124)
        Me.btnPrintD.Name = "btnPrintD"
        Me.btnPrintD.Size = New System.Drawing.Size(166, 51)
        Me.btnPrintD.TabIndex = 0
        Me.btnPrintD.Text = "&Print Nomor"
        Me.btnPrintD.UseVisualStyleBackColor = True
        '
        'btnPrintE
        '
        Me.btnPrintE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintE.Location = New System.Drawing.Point(198, 124)
        Me.btnPrintE.Name = "btnPrintE"
        Me.btnPrintE.Size = New System.Drawing.Size(166, 51)
        Me.btnPrintE.TabIndex = 0
        Me.btnPrintE.Text = "&Print Nomor"
        Me.btnPrintE.UseVisualStyleBackColor = True
        '
        'btnPrintB
        '
        Me.btnPrintB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintB.Location = New System.Drawing.Point(198, 67)
        Me.btnPrintB.Name = "btnPrintB"
        Me.btnPrintB.Size = New System.Drawing.Size(166, 51)
        Me.btnPrintB.TabIndex = 0
        Me.btnPrintB.Text = "&Print Nomor"
        Me.btnPrintB.UseVisualStyleBackColor = True
        '
        'btnPrintC
        '
        Me.btnPrintC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintC.Location = New System.Drawing.Point(370, 67)
        Me.btnPrintC.Name = "btnPrintC"
        Me.btnPrintC.Size = New System.Drawing.Size(166, 51)
        Me.btnPrintC.TabIndex = 0
        Me.btnPrintC.Text = "&Print Nomor"
        Me.btnPrintC.UseVisualStyleBackColor = True
        '
        'btnPrintF
        '
        Me.btnPrintF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintF.Location = New System.Drawing.Point(370, 124)
        Me.btnPrintF.Name = "btnPrintF"
        Me.btnPrintF.Size = New System.Drawing.Size(166, 51)
        Me.btnPrintF.TabIndex = 0
        Me.btnPrintF.Text = "&Print Nomor"
        Me.btnPrintF.UseVisualStyleBackColor = True
        '
        'PrintNomor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 217)
        Me.Controls.Add(Me.lblTetx)
        Me.Controls.Add(Me.btnPrintF)
        Me.Controls.Add(Me.btnPrintC)
        Me.Controls.Add(Me.btnPrintB)
        Me.Controls.Add(Me.btnPrintE)
        Me.Controls.Add(Me.btnPrintD)
        Me.Controls.Add(Me.btnPrintA)
        Me.Controls.Add(Me.lbNomor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintNomor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Nomor Antrian"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrintA As System.Windows.Forms.Button
    Friend WithEvents lbNomor As System.Windows.Forms.Label
    Friend WithEvents lblTetx As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintD As System.Windows.Forms.Button
    Friend WithEvents btnPrintE As System.Windows.Forms.Button
    Friend WithEvents btnPrintB As System.Windows.Forms.Button
    Friend WithEvents btnPrintC As System.Windows.Forms.Button
    Friend WithEvents btnPrintF As System.Windows.Forms.Button
    Friend WithEvents tmDelay As System.Windows.Forms.Timer
End Class
