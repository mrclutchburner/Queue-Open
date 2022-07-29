Imports System.ComponentModel
Imports System.Text

Partial Public Class frmNew
    Inherits Form
    Private initialPixcelWidth As Double = 384
    Private initialPixcelHeight As Double = 288
    Private dpiX As Double = 96
    Private dpiY As Double = 96
    Public selectedUnitType As String = "Pixel"

    Public newPixcelWidth As Double = 384
    Public newPixcelHeight As Double = 288
    Public Sub New(ByVal Panelwidth As Double, ByVal panelHeight As Double, ByVal dpix As Double, ByVal dpiy As Double)
        InitializeComponent()
        initialPixcelWidth = Panelwidth ' 384;
        initialPixcelHeight = panelHeight ' 288;
        Me.dpiX = dpix
        Me.dpiY = dpiy
    End Sub

    Private Sub cboUnit_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboUnit.SelectedIndexChanged
        Select Case cboUnit.SelectedItem.ToString()
            Case "Cm"
                nudWidth.Value = Convert.ToDecimal(initialPixcelWidth * 2.54 / dpiX)
                nudHeight.Value = Convert.ToDecimal(initialPixcelHeight * 2.54 / dpiY)
            Case "Inch"
                nudWidth.Value = Convert.ToDecimal(initialPixcelWidth / dpiX)
                nudHeight.Value = Convert.ToDecimal(initialPixcelHeight / dpiY)
            Case "Mm"
                nudWidth.Value = Convert.ToDecimal((initialPixcelWidth * 25.4) / dpiX)
                nudHeight.Value = Convert.ToDecimal((initialPixcelHeight * 25.4) / dpiY)
            Case "Pixel"
                nudWidth.Value = Convert.ToDecimal(initialPixcelWidth)
                nudHeight.Value = Convert.ToDecimal(initialPixcelHeight)
        End Select
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        selectedUnitType = cboUnit.SelectedItem.ToString()
        newPixcelWidth = Convert.ToDouble(nudWidth.Value)
        newPixcelHeight = Convert.ToDouble(nudHeight.Value)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub frmNew_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cboUnit.SelectedIndex = 3
    End Sub

  
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class

