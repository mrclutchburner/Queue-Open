Imports System.ComponentModel
Imports System.Text
Imports System.Drawing

Partial Public Class SettingWarnaDisplay
    Inherits Form
    Private ra As New RegAcces()
    Public Shared RegrisName As String = "DleuxAntrian"
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnMainLoket_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMainLoket.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.MainLoket = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "MainLoket", Server.ConverterBrush.ConvertToString(New Pen(Server.MainLoket).Color))
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnMainService_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMainService.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.MainService = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "MainService", Server.ConverterBrush.ConvertToString(New Pen(Server.MainService).Color))
        End If
    End Sub

    Private Sub btnMainNumber_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMainNumber.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.MainNumber = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "MainNumber", Server.ConverterBrush.ConvertToString(New Pen(Server.MainNumber).Color))
        End If
    End Sub

    Private Sub btnCounterNama_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCounterNama.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.CounterLoket = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "CounterLoket", Server.ConverterBrush.ConvertToString(New Pen(Server.CounterLoket).Color))
        End If
    End Sub

    Private Sub btnCounterService_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCounterService.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.CounterService = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "CounterService", Server.ConverterBrush.ConvertToString(New Pen(Server.CounterService).Color))
        End If
    End Sub

    Private Sub btnCounterNomor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCounterNomor.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.CounterNumber = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "CounterNumber", Server.ConverterBrush.ConvertToString(New Pen(Server.CounterNumber).Color))
        End If
    End Sub

    Private Sub btnGaris_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGaris.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.CounterBatas = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "CounterBatas", Server.ConverterBrush.ConvertToString(New Pen(Server.CounterBatas).Color))
        End If
    End Sub

    Private Sub btnJam_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJam.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.ColorJam = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "ColorJam", Server.ConverterBrush.ConvertToString(New Pen(Server.ColorJam).Color))
        End If
    End Sub

    Private Sub btnTanggal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTanggal.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.ColorTanggal = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "ColorTanggal", Server.ConverterBrush.ConvertToString(New Pen(Server.ColorTanggal).Color))
        End If
    End Sub

    Private Sub btnTextSisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextSisa.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.SisaLayananName = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "SisaLayananName", Server.ConverterBrush.ConvertToString(New Pen(Server.SisaLayananName).Color))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cdlg As New ColorDialog()
        cdlg.AllowFullOpen = True
        cdlg.AnyColor = True
        cdlg.FullOpen = True
        cdlg.SolidColorOnly = False
        If cdlg.ShowDialog() = DialogResult.OK Then
            Server.SisaNomorName = New SolidBrush(cdlg.Color)
            ra.CreateReg("AntServer", RegrisName, "Color", "SisaNomorName", Server.ConverterBrush.ConvertToString(New Pen(Server.SisaNomorName).Color))
        End If
    End Sub

    Private Sub btnFont1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont1.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontLayanan
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 10
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontLayanan = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontLayanan", Server.ConverterFont.ConvertToString(Server.FontLayanan))
            End If
        Catch
        End Try
    End Sub

    Private Sub btnFont3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont3.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontMainNomor
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 10
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontMainNomor = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontMainNomor", Server.ConverterFont.ConvertToString(Server.FontMainNomor))
            End If
        Catch
        End Try
    End Sub

    Private Sub btnFont4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont4.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontNomorSisa
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 10
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontNomorSisa = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontNomorSisa", Server.ConverterFont.ConvertToString(Server.FontNomorSisa))
            End If
        Catch
        End Try
    End Sub

    Private Sub btnFont2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont2.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontLayananSisa
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 10
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontLayananSisa = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontLayananSisa", Server.ConverterFont.ConvertToString(Server.FontLayananSisa))
            End If
        Catch
        End Try
    End Sub


    Private Sub btnFont11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont11.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontTextSisa
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 10
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontTextSisa = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontTextSisa", Server.ConverterFont.ConvertToString(Server.FontTextSisa))
            End If
        Catch
        End Try
    End Sub

    Private Sub btnFont5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont5.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontPelayanan
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 10
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontPelayanan = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontPelayanan", Server.ConverterFont.ConvertToString(Server.FontPelayanan))
            End If
        Catch
        End Try
    End Sub

    Private Sub btnFont7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont7.Click
        'FontAntrian
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontAntrian
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 10
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontAntrian = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontAntrian", Server.ConverterFont.ConvertToString(Server.FontAntrian))
            End If
        Catch
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontJam
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 8
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontJam = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontJam", Server.ConverterFont.ConvertToString(Server.FontJam))
            End If
        Catch
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim FontDlg As New FontDialog()
            FontDlg.Font = Server.FontTanggal
            FontDlg.ShowColor = False
            FontDlg.ShowApply = True
            FontDlg.ShowEffects = True
            FontDlg.ShowHelp = True
            FontDlg.MaxSize = 210
            FontDlg.MinSize = 8
            If FontDlg.ShowDialog() = DialogResult.OK Then
                Server.FontTanggal = FontDlg.Font
                ra.CreateReg("AntServer", RegrisName, "Font", "FontTanggal", Server.ConverterFont.ConvertToString(Server.FontTanggal))
            End If
        Catch
        End Try
    End Sub

   
End Class
