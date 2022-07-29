<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiketPrint
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
        Me.PnTiket = New System.Windows.Forms.Panel()
        Me.PrntTiket = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'PnTiket
        '
        Me.PnTiket.BackColor = System.Drawing.Color.White
        Me.PnTiket.Location = New System.Drawing.Point(3, 3)
        Me.PnTiket.Name = "PnTiket"
        Me.PnTiket.Size = New System.Drawing.Size(276, 367)
        Me.PnTiket.TabIndex = 0
        '
        'PrntTiket
        '
        '
        'PrintTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 457)
        Me.Controls.Add(Me.PnTiket)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrintTiket"
        Me.Text = "PrintTiket"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnTiket As System.Windows.Forms.Panel
    Friend WithEvents PrntTiket As System.Drawing.Printing.PrintDocument
End Class
