Public Class UseLogo
    Dim Reg As New RegAcces()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim openimage As New OpenFileDialog ' creating open file dialog (programatically)
        openimage.ShowDialog() 'this will pop up with open file dialog
        openimage.InitialDirectory = "C:\"
        openimage.Multiselect = True ' is multiselect = no
        openimage.Title = "Open Logo" ' Dialog title
        openimage.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"
        txtLogo.Text = openimage.FileName
        Reg.CreateSubReg("AntPrinter", "Printer", "Tiket", "Logo", txtLogo.Text)
        Close()
        Exit Sub
    End Sub
    'Private Sub UseLogo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Dim openimage As New OpenFileDialog ' creating open file dialog (programatically)
    '    openimage.ShowDialog() 'this will pop up with open file dialog
    '    openimage.InitialDirectory = "C:\"
    '    openimage.Multiselect = True  ' is multiselect = no
    '    openimage.Title = "Open Logo" ' Dialog title
    '    openimage.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"
    '    txtLogo.Text = openimage.FileName
    '    Reg.CreateSubReg("AntPrinter", "Printer", "Tiket", "Logo", txtLogo.Text)
    '    Exit Sub
    'End Sub
End Class