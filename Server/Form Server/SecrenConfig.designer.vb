<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecrenConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecrenConfig))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmite = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.cbIndex = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Screen Position :"
        '
        'btnSubmite
        '
        Me.btnSubmite.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSubmite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnSubmite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnSubmite.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSubmite.Location = New System.Drawing.Point(10, 65)
        Me.btnSubmite.Name = "btnSubmite"
        Me.btnSubmite.Size = New System.Drawing.Size(192, 44)
        Me.btnSubmite.TabIndex = 4
        Me.btnSubmite.Text = "Submite"
        Me.btnSubmite.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Background Left :"
        '
        'txtLeft
        '
        Me.txtLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeft.Location = New System.Drawing.Point(102, 38)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtLeft.TabIndex = 3
        '
        'cbIndex
        '
        Me.cbIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbIndex.FormattingEnabled = True
        Me.cbIndex.Location = New System.Drawing.Point(102, 6)
        Me.cbIndex.Name = "cbIndex"
        Me.cbIndex.Size = New System.Drawing.Size(100, 21)
        Me.cbIndex.TabIndex = 2
        '
        'SecrenConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(216, 118)
        Me.Controls.Add(Me.cbIndex)
        Me.Controls.Add(Me.btnSubmite)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLeft)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SecrenConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screen Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSubmite As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents cbIndex As System.Windows.Forms.ComboBox
End Class
