<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KursValas
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
        Me.txtNegara = New System.Windows.Forms.TextBox()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbFlag = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbFlag = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBeli = New System.Windows.Forms.TextBox()
        Me.txtJual = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblNegara = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Idlbl = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvValas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvValas
        '
        Me.dgvValas.AllowUserToAddRows = False
        Me.dgvValas.AllowUserToDeleteRows = False
        Me.dgvValas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValas.Location = New System.Drawing.Point(366, 25)
        Me.dgvValas.Name = "dgvValas"
        Me.dgvValas.ReadOnly = True
        Me.dgvValas.Size = New System.Drawing.Size(389, 205)
        Me.dgvValas.TabIndex = 9
        '
        'txtNegara
        '
        Me.txtNegara.Location = New System.Drawing.Point(100, 105)
        Me.txtNegara.Name = "txtNegara"
        Me.txtNegara.Size = New System.Drawing.Size(138, 20)
        Me.txtNegara.TabIndex = 12
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(100, 79)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(138, 20)
        Me.txtFlag.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nama Negara"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Kode Negara"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbFlag)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbFlag)
        Me.GroupBox1.Location = New System.Drawing.Point(245, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 157)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'pbFlag
        '
        Me.pbFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlag.Location = New System.Drawing.Point(8, 14)
        Me.pbFlag.Name = "pbFlag"
        Me.pbFlag.Size = New System.Drawing.Size(98, 107)
        Me.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFlag.TabIndex = 2
        Me.pbFlag.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Add Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbFlag
        '
        Me.cmbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFlag.FormattingEnabled = True
        Me.cmbFlag.Location = New System.Drawing.Point(22, 96)
        Me.cmbFlag.Name = "cmbFlag"
        Me.cmbFlag.Size = New System.Drawing.Size(59, 21)
        Me.cmbFlag.TabIndex = 1
        Me.cmbFlag.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Jual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Beli"
        '
        'txtBeli
        '
        Me.txtBeli.Location = New System.Drawing.Point(100, 52)
        Me.txtBeli.Name = "txtBeli"
        Me.txtBeli.Size = New System.Drawing.Size(138, 20)
        Me.txtBeli.TabIndex = 15
        '
        'txtJual
        '
        Me.txtJual.Location = New System.Drawing.Point(100, 25)
        Me.txtJual.Name = "txtJual"
        Me.txtJual.Size = New System.Drawing.Size(138, 20)
        Me.txtJual.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(170, 137)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 44)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Update"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(10, 137)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(67, 44)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblNegara
        '
        Me.lblNegara.AutoSize = True
        Me.lblNegara.Location = New System.Drawing.Point(13, 189)
        Me.lblNegara.Name = "lblNegara"
        Me.lblNegara.Size = New System.Drawing.Size(39, 13)
        Me.lblNegara.TabIndex = 21
        Me.lblNegara.Text = "Label5"
        Me.lblNegara.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Data Tabel Kurs Valas"
        '
        'Idlbl
        '
        Me.Idlbl.AutoSize = True
        Me.Idlbl.Location = New System.Drawing.Point(13, 206)
        Me.Idlbl.Name = "Idlbl"
        Me.Idlbl.Size = New System.Drawing.Size(39, 13)
        Me.Idlbl.TabIndex = 23
        Me.Idlbl.Text = "Label6"
        Me.Idlbl.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(90, 137)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(67, 44)
        Me.BtnDelete.TabIndex = 24
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'KursValas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 236)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Idlbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNegara)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvValas)
        Me.Controls.Add(Me.txtNegara)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBeli)
        Me.Controls.Add(Me.txtJual)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KursValas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KursValas"
        CType(Me.dgvValas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvValas As System.Windows.Forms.DataGridView
    Friend WithEvents txtNegara As System.Windows.Forms.TextBox
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents pbFlag As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbFlag As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBeli As System.Windows.Forms.TextBox
    Friend WithEvents txtJual As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblNegara As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Idlbl As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
End Class
