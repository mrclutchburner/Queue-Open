Imports System.Drawing.Printing
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Xml
Imports System.Globalization
Imports ThoughtWorks.QRCode.Codec

Public Class TiketPrint
#Region "Attribute"
    Private Const DRAG_HANDLE_SIZE As Integer = 7
    Private mouseX, mouseY As Integer
    Private SelectedControl As Control
    Private copiedControl As Control
    Private direction_Renamed As Direction
    Private newLocation As Point
    Private newSize As Size
    Public Shared gParam() As String = Nothing
    Private MemoryImage As Bitmap
    Private xmlFileName As String = ""
    Private cutCheck As Boolean = False
    Private copyCheck As Boolean = False
    Public Shared filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\Tikets" & "\"
    <DllImport("gdi32.dll", ExactSpelling:=True)>
    Private Shared Function AddFontMemResourceEx(ByVal pbFont() As Byte, ByVal cbFont As Integer, ByVal pdv As IntPtr, <System.Runtime.InteropServices.Out()> ByRef pcFonts As UInteger) As IntPtr
    End Function
    <DllImport("gdi32.dll", ExactSpelling:=True)>
    Friend Shared Function RemoveFontMemResourceEx(ByVal fh As IntPtr) As Boolean
    End Function
    Private Shared m_fh As IntPtr = IntPtr.Zero
    Private Shared m_pfc As PrivateFontCollection = Nothing
    Private Enum Direction
        NW
        N
        NE
        W
        E
        SW
        S
        SE
        None
    End Enum

#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Try
            Dim TmUseTiket As String = filePath & Interaction.GetSetting("AntServer", "Server", "UseTiket")
            If TmUseTiket <> "" Then
                UseTikets = TmUseTiket
            End If
        Catch ex As Exception

        End Try

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region "For Panel Print Testing"
    Public Shared NomorAntri As Integer
    Public Shared Lay As Integer
    Public Shared PelayananAntri As String
    Public Shared Sisa As Integer
    Public Shared Barcode As String
    Public Shared PrintCopy As New Short
    Public Shared PrintName As String = ""
    Public Shared UseTikets As String = ""
    Private Function FontToString(ByVal font_Renamed As Font) As String
        Return font_Renamed.FontFamily.Name & ":" & font_Renamed.Size & ":" & CInt(font_Renamed.Style)
    End Function

    Private Function StringToFont(ByVal font As String) As Font
        Dim parts() As String = font.Split(":"c)
        If parts.Length <> 3 Then
            Throw New ArgumentException("Not a valid font string", "font")
        End If

        Dim loadedFont As New Font(parts(0), Single.Parse(parts(1)), CType(Integer.Parse(parts(2)), FontStyle))
        Return loadedFont
    End Function

    Private Sub loadXMLFILES(ByVal FileTemplate As String)
        If FileTemplate = "" Then
            Return
        End If
        Dim xml As New XmlDocument()
        xml.Load(FileTemplate)
        Dim xnList As XmlNode = xml.SelectSingleNode("ShanuDrawingToolsList")
        Dim i As Integer = 0
        For Each xn As XmlNode In xnList
            If i = 0 Then
                Dim panelWidth As String = xn("panelWidth").InnerText
                Dim panelHeight As String = xn("panelHeight").InnerText
                i = i + 1
                If panelWidth = "" Then
                    PnTiket.Width = 384
                Else
                    PnTiket.Width = Convert.ToInt32(panelWidth)
                End If
                If panelHeight = "" Then
                    PnTiket.Height = 288
                Else
                    PnTiket.Height = Convert.ToInt32(panelHeight)
                End If
            End If
            Dim CntrlType As String = xn("ControlsType").InnerText
            Dim LOCX As String = xn("LocationX").InnerText
            Dim LOCY As String = xn("LocationY").InnerText
            Dim CNTLWidth As String = xn("SizeWidth").InnerText
            Dim CNTLHeight As String = xn("SizeHeight").InnerText
            Dim CntrlText As String = xn("Text").InnerText
            Dim fonts As String = xn("Fonts").InnerText
            Dim PictuerImg As String = xn("picImage").InnerText
            Dim bckColor As String = xn("BackColor").InnerText
            Dim foreColor As String = xn("ForeColor").InnerText
            Dim CntrlsName As String = xn("CntrlsName").InnerText
            gParam = New String() {CntrlType, LOCX, LOCY, CNTLWidth, CNTLHeight, CntrlText, fonts, PictuerImg, bckColor, foreColor, CntrlsName}
            Try
                Dim UsBarcode As String = Barcode
                WriteTiket(NomorAntri, Lay + 1, PelayananAntri, Sisa, UsBarcode)
            Catch ex As Exception

            End Try


        Next xn

    End Sub
    Public Sub WriteTiket(ByVal Nomor As Integer, ByVal Layanan As Integer, ByVal Pelayanan As String, ByVal SisaNomor As Integer, ByVal tmpBarcode As String)
        Try
            Select Case gParam(0)
                Case "System.Windows.Forms.PictureBox"
                    Dim myBackColor As New Color()
                    myBackColor = ColorTranslator.FromHtml(gParam(8))
                    Dim ctrl As New PictureBox()
                    ctrl.BackColor = myBackColor
                    ctrl.Name = gParam(10)
                    'ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                    'ctrl.SizeMode = PictureBoxSizeMode.StretchImage
                    'ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))
                    'ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                    Try
                        Dim str As String
                        Dim strArr() As String
                        Dim count As Integer
                        str = ctrl.Name
                        strArr = str.Split("_")
                        For count = 0 To strArr.Length - 1
                            Try
                                If strArr(0) = "Logo" Then
                                    ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage
                                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))
                                    If gParam(7) <> "" Then
                                        Dim bmp1 As New Bitmap(New MemoryStream(Convert.FromBase64String(gParam(7))))
                                        ctrl.Image = bmp1
                                    End If
                                End If
                            Catch ex As Exception

                            End Try

                        Next
                    Catch ex As Exception

                    End Try
                    PnTiket.Controls.Add(ctrl)

                Case "System.Windows.Forms.Label"
                    Dim cvt = New FontConverter()
                    Dim f As Font = StringToFont(gParam(6))
                    Dim myBackColor As New Color()
                    myBackColor = ColorTranslator.FromHtml(gParam(8))
                    Dim myForeColorColor As New Color()
                    myForeColorColor = ColorTranslator.FromHtml(gParam(9))
                    Dim ctrl As New Label()
                    ctrl.Name = gParam(10)
                    ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                    Try
                        Dim str As String
                        Dim strArr() As String
                        Dim count As Integer
                        str = ctrl.Name
                        strArr = str.Split("_")
                        For count = 0 To strArr.Length - 1
                            Dim NameText As String = ""
                            Try
                                If strArr(0) = "HeaderMidle" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleCenter
                                    ctrl.Text = gParam(5)
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "HeaderLeft" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = gParam(5)
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "TextRight" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleRight
                                    ctrl.Text = gParam(5)
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "TextMidle" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleCenter
                                    ctrl.Text = gParam(5)
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "TextLeft" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = gParam(5)
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "NomorAntrian" Then
                                    ctrl.TextAlign = ContentAlignment.BottomLeft
                                    If Nomor < 1000 Then
                                        ctrl.Text = Convert.ToChar(&H40 + Layanan).ToString() & " " & String.Format("{0:000}", Nomor)
                                        'MessageBox.Show(ctrl.Text)
                                    ElseIf Nomor >= 10000 Then
                                        ctrl.Text = Convert.ToChar(&H40 + Layanan).ToString() & " " & String.Format("{0:0000}", Nomor)
                                    End If
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "ServiceName" Then
                                    ctrl.Text = Pelayanan
                                    ctrl.AutoSize = True
                                    ctrl.TextAlign = ContentAlignment.MiddleCenter
                                ElseIf strArr(0) = "SisaNomor" Then
                                    ctrl.Text = String.Format("{0:00}", SisaNomor) & "  NOMOR"
                                    ctrl.TextAlign = ContentAlignment.BottomLeft
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "DateClock" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = Date.Now.ToString("dddd, d-MM-yyyy", CultureInfo.CreateSpecificCulture("id-ID")) & " , " & Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "Date" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = Date.Now.ToString("dddd, d-MM-yyyy", CultureInfo.CreateSpecificCulture("id-ID"))
                                    ctrl.AutoSize = True
                                ElseIf strArr(0) = "Clock" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
                                    ctrl.AutoSize = True
                                Else
                                    ctrl.TextAlign = ContentAlignment.MiddleCenter
                                    ctrl.Text = gParam(5)
                                End If
                            Catch ex As Exception

                            End Try

                        Next
                    Catch ex As Exception

                    End Try
                    'ctrl.Text = gParam(5)
                    ctrl.Font = f
                    ctrl.BackColor = myBackColor
                    ctrl.ForeColor = myForeColorColor
                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))
                    PnTiket.Controls.Add(ctrl)
                Case "Line"
                    Dim myBackColor As New Color()
                    myBackColor = ColorTranslator.FromHtml(gParam(8))
                    Dim ctrl As New Line()
                    ctrl.Name = gParam(10)
                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))
                    ctrl.BackColor = myBackColor
                    ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                    ctrl.Orientation = LineOrientation.Horizontal
                    PnTiket.Controls.Add(ctrl)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetPrintArea(ByVal pnl As Panel)
        MemoryImage = New Bitmap(pnl.Width, pnl.Height)
        Dim rect As New Rectangle(0, 0, pnl.Width, pnl.Height)
        pnl.DrawToBitmap(MemoryImage, New Rectangle(0, 0, pnl.Width, pnl.Height))
        pnl.Invalidate()
    End Sub

    Public Sub Print(ByVal pnl As Panel, ByVal CopyPrint As Short)
        Dim panel As Panel = pnl
        GetPrintArea(pnl)
        PnTiket.Invalidate()
        PrntTiket.PrinterSettings.PrinterName = PrintName
        PrntTiket.PrinterSettings.Copies = CopyPrint
        Dim controller As PrintController = New StandardPrintController()
        PrntTiket.PrintController = controller
        PrntTiket.Print()
        'MessageBox.Show("Nomor : " & NomorAntri & "  " & "Sisa Nomor : " & Sisa & "  " & "Layanan : " & Lay & "  " & "Barcode : " & Barcode & "  " & "Layanan Tujuan : " & PelayananAntri, " Test ")
    End Sub

    Private Sub PrntTiket_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrntTiket.PrintPage
        Dim pagearea As Rectangle = e.PageBounds
        e.Graphics.DrawImage(MemoryImage, 4, 4)
    End Sub

    Public Sub PrintTiket()
        PnTiket.Controls.Clear()
        loadXMLFILES(UseTikets)
        Dim pd As New PrintDialog()
        PrintName = Interaction.GetSetting("AntServer", "Server", "Printername")
        PrintCopy = Convert.ToInt16(Interaction.GetSetting("AntServer", "Server", "CopyPrint"))
        If PrintName = "" Then
            pd.PrinterSettings = New PrinterSettings()
            If DialogResult.OK = pd.ShowDialog(Me) Then
                PrintName = pd.PrinterSettings.PrinterName
                Interaction.SaveSetting("AntServer", "Server", "Printername", PrintName)
            End If
        End If
        ' tmPos.Stop()
        Dim printVal As Integer = 0
        For Each p As Control In PnTiket.Controls
            p.Invalidate()
            printVal = printVal + 1
        Next p
        If printVal > 0 Then
            Print(Me.PnTiket, PrintCopy)
        Else
            MessageBox.Show("No Data to Print")
        End If
        ' tmPos.Start()

    End Sub
#End Region

    Private Sub PrintTiket_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        PrintTiket()
        Me.Close()
    End Sub

    Private Sub PrintTiket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = -1000
        Me.Top = 0
    End Sub
End Class