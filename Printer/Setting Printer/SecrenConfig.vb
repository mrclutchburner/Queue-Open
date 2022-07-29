Public Class SecrenConfig
    Dim Reg As New RegAcces
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim tmpScreen() As Screen = Screen.AllScreens
        For i As Integer = 0 To tmpScreen.Length - 1
            cbIndex.Items.Add(i)
        Next i
        cbIndex.SelectedIndex = MainPrinter.ScrenIndex
        txtLeft.Text = MainPrinter.BackGroundLeft.ToString()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub SecrenConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtLeft_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeft.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbIndex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIndex.SelectedIndexChanged
        MainPrinter.ScrenIndex = cbIndex.SelectedIndex
    End Sub

    Private Sub btnSubmite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmite.Click
        If cbIndex.Text <> "" AndAlso txtLeft.Text <> "" Then
            MainPrinter.BackGroundLeft = Integer.Parse(txtLeft.Text)
            Reg.CreateReg("AntPrinter", "Printer", "Left", txtLeft.Text)
            Reg.CreateReg("AntPrinter", "Printer", "Screen", MainPrinter.ScrenIndex.ToString())
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Isi Data Dengan Lengkap")
        End If

    End Sub
End Class