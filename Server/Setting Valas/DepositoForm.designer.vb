<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositoForm
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
        Me.dgvValas = New System.Windows.Forms.DataGridView()
        Me.txtIsi3 = New System.Windows.Forms.TextBox()
        Me.txtIsi2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIsi1 = New System.Windows.Forms.TextBox()
        Me.txtJangka = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ilbl = New System.Windows.Forms.Label()
        CType(Me.dgvValas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvValas
        '
        Me.dgvValas.AllowUserToAddRows = False
        Me.dgvValas.AllowUserToDeleteRows = False
        Me.dgvValas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValas.Location = New System.Drawing.Point(256, 19)
        Me.dgvValas.Name = "dgvValas"
        Me.dgvValas.ReadOnly = True
        Me.dgvValas.Size = New System.Drawing.Size(364, 154)
        Me.dgvValas.TabIndex = 6
        '
        'txtIsi3
        '
        Me.txtIsi3.Location = New System.Drawing.Point(102, 99)
        Me.txtIsi3.Name = "txtIsi3"
        Me.txtIsi3.Size = New System.Drawing.Size(138, 20)
        Me.txtIsi3.TabIndex = 20
        '
        'txtIsi2
        '
        Me.txtIsi2.Location = New System.Drawing.Point(102, 73)
        Me.txtIsi2.Name = "txtIsi2"
        Me.txtIsi2.Size = New System.Drawing.Size(138, 20)
        Me.txtIsi2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "> 1 Milyar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "100 Juta - 1M"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Jangka Waktu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "< 100 Juta"
        '
        'txtIsi1
        '
        Me.txtIsi1.Location = New System.Drawing.Point(102, 46)
        Me.txtIsi1.Name = "txtIsi1"
        Me.txtIsi1.Size = New System.Drawing.Size(138, 20)
        Me.txtIsi1.TabIndex = 23
        '
        'txtJangka
        '
        Me.txtJangka.Location = New System.Drawing.Point(102, 19)
        Me.txtJangka.Name = "txtJangka"
        Me.txtJangka.Size = New System.Drawing.Size(138, 20)
        Me.txtJangka.TabIndex = 24
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(18, 142)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(67, 34)
        Me.AddBtn.TabIndex = 27
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(92, 142)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(67, 34)
        Me.UpdateBtn.TabIndex = 27
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(166, 142)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(67, 34)
        Me.DeleteBtn.TabIndex = 27
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Data Tabel Deposito"
        '
        'Ilbl
        '
        Me.Ilbl.AutoSize = True
        Me.Ilbl.Location = New System.Drawing.Point(15, 117)
        Me.Ilbl.Name = "Ilbl"
        Me.Ilbl.Size = New System.Drawing.Size(39, 13)
        Me.Ilbl.TabIndex = 28
        Me.Ilbl.Text = "Label6"
        Me.Ilbl.Visible = False
        '
        'DepositoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 188)
        Me.Controls.Add(Me.Ilbl)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.txtIsi3)
        Me.Controls.Add(Me.txtIsi2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIsi1)
        Me.Controls.Add(Me.txtJangka)
        Me.Controls.Add(Me.dgvValas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DepositoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposito"
        CType(Me.dgvValas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgvValas As System.Windows.Forms.DataGridView
    Friend WithEvents txtIsi3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIsi2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIsi1 As System.Windows.Forms.TextBox
    Friend WithEvents txtJangka As System.Windows.Forms.TextBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ilbl As System.Windows.Forms.Label
End Class
