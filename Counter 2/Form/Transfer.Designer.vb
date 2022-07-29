<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfer))
        Me.cbLayanan = New System.Windows.Forms.ComboBox()
        Me.txtSubmit = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbLayanan
        '
        Me.cbLayanan.FormattingEnabled = True
        Me.cbLayanan.Location = New System.Drawing.Point(76, 6)
        Me.cbLayanan.Name = "cbLayanan"
        Me.cbLayanan.Size = New System.Drawing.Size(89, 21)
        Me.cbLayanan.TabIndex = 10
        '
        'txtSubmit
        '
        Me.txtSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubmit.Location = New System.Drawing.Point(15, 72)
        Me.txtSubmit.Name = "txtSubmit"
        Me.txtSubmit.Size = New System.Drawing.Size(150, 29)
        Me.txtSubmit.TabIndex = 9
        Me.txtSubmit.Text = "Submit"
        Me.txtSubmit.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 44)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Nomor"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Layanan"
        '
        'txtNomor
        '
        Me.txtNomor.Enabled = False
        Me.txtNomor.Location = New System.Drawing.Point(76, 41)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(89, 20)
        Me.txtNomor.TabIndex = 6
        '
        'Transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 110)
        Me.Controls.Add(Me.cbLayanan)
        Me.Controls.Add(Me.txtSubmit)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtNomor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cbLayanan As System.Windows.Forms.ComboBox
    Private WithEvents txtSubmit As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtNomor As System.Windows.Forms.TextBox
End Class
