<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigServer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ServerTxt = New System.Windows.Forms.TextBox()
        Me.DbTxt = New System.Windows.Forms.TextBox()
        Me.UserTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Base :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password :"
        '
        'ServerTxt
        '
        Me.ServerTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServerTxt.Location = New System.Drawing.Point(88, 7)
        Me.ServerTxt.Name = "ServerTxt"
        Me.ServerTxt.Size = New System.Drawing.Size(144, 20)
        Me.ServerTxt.TabIndex = 4
        '
        'DbTxt
        '
        Me.DbTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DbTxt.Location = New System.Drawing.Point(88, 33)
        Me.DbTxt.Name = "DbTxt"
        Me.DbTxt.Size = New System.Drawing.Size(144, 20)
        Me.DbTxt.TabIndex = 5
        '
        'UserTxt
        '
        Me.UserTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserTxt.Location = New System.Drawing.Point(88, 59)
        Me.UserTxt.Name = "UserTxt"
        Me.UserTxt.Size = New System.Drawing.Size(144, 20)
        Me.UserTxt.TabIndex = 6
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTxt.Location = New System.Drawing.Point(88, 85)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxt.Size = New System.Drawing.Size(144, 20)
        Me.PasswordTxt.TabIndex = 7
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(88, 111)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 49)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "Save / Submite"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ConfigServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(238, 172)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.UserTxt)
        Me.Controls.Add(Me.DbTxt)
        Me.Controls.Add(Me.ServerTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ServerTxt As System.Windows.Forms.TextBox
    Friend WithEvents DbTxt As System.Windows.Forms.TextBox
    Friend WithEvents UserTxt As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
