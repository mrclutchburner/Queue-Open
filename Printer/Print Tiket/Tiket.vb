Imports System.ComponentModel
Imports System.Text
Imports System.Xml
Imports System.IO
Imports System.Drawing.Text
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Drawing.Printing
Imports ThoughtWorks.QRCode.Codec

Partial Public Class Tiket
    Inherits Form
    Public Shared PrintName As String = ""
    Private initialPixcelWidth As Double = 384
    Private initialPixcelHeight As Double = 288
    Private dpiX As Double = 96
    Private dpiY As Double = 96
    Public selectedUnitType As String = "Pixel"
    Public newPixcelWidth As Double = 384
    Public newPixcelHeight As Double = 288
    Dim TmpPath As String = System.AppDomain.CurrentDomain.BaseDirectory()
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
    Public filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\Tikets\Default.xml"
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
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim ctrl As New Label()
        tmPos.Start()
        '  pnControls.Controls.Clear()
        '' loadXMLFILES(filePath)
        GroupBox1.Hide()
        Dim strPath As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Tikets"
        Dim dirInfo As New IO.DirectoryInfo(strPath)
        For Each file As FileInfo In dirInfo.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
            ComboBox1.Items.Add(file.Name)
        Next
    End Sub
#Region "Functions"
    Private Function FontToString(ByVal font_Renamed As Font) As String
        Return font_Renamed.FontFamily.Name & ":" & font_Renamed.Size & ":" & CInt(Fix(font_Renamed.Style))
    End Function
    Private Function StringToFont(ByVal font As String) As Font
        Dim parts() As String = font.Split(":"c)
        If parts.Length <> 3 Then
            Throw New ArgumentException("Not a valid font string", "font")
        End If

        Dim loadedFont As New Font(parts(0), Single.Parse(parts(1)), CType(Integer.Parse(parts(2)), FontStyle))
        Return loadedFont
    End Function
    Private Sub loadXMLFILE()
        If xmlFileName = "" Then
            Return
        End If
        Dim xml As New XmlDocument()
        xml.Load(xmlFileName)
        Dim xnList As XmlNode = xml.SelectSingleNode("ShanuDrawingToolsList")
        Dim i As Integer = 0
        For Each xn As XmlNode In xnList
            If i = 0 Then
                Dim panelWidth As String = xn("panelWidth").InnerText
                Dim panelHeight As String = xn("panelHeight").InnerText
                i = i + 1
                If panelWidth = "" Then
                    pnControls.Width = 384
                Else
                    pnControls.Width = Convert.ToInt32(panelWidth)
                End If
                If panelHeight = "" Then
                    pnControls.Height = 288
                Else
                    pnControls.Height = Convert.ToInt32(panelHeight)
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
            loadShanuLabelDesign()
        Next xn

    End Sub
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
                    pnControls.Width = 384
                Else
                    pnControls.Width = Convert.ToInt32(panelWidth)
                End If
                If panelHeight = "" Then
                    pnControls.Height = 288
                Else
                    pnControls.Height = Convert.ToInt32(panelHeight)
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
            loadShanuLabelDesign()
        Next xn

    End Sub
    Private Sub TiketLabelDesign()
        Try
            Select Case gParam(0)
                Case "System.Windows.Forms.PictureBox"
                    Dim myBackColor As New Color()
                    myBackColor = ColorTranslator.FromHtml(gParam(8))
                    Dim ctrl As New PictureBox()
                    ctrl.BackColor = myBackColor
                    ctrl.Name = gParam(10)
                    ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage
                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))

                    If gParam(7) <> "" Then
                        Dim bmp1 As New Bitmap(New MemoryStream(Convert.FromBase64String(gParam(7))))
                        ctrl.Image = bmp1
                    End If
                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                    pnControls.Controls.Add(ctrl)

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
                    If ctrl.Name = "Lbl_638" Then
                        ctrl.Text = "Coba"
                    ElseIf ctrl.Name = "Clock" Then
                        ctrl.Text = Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
                    Else
                        ctrl.Text = gParam(5)
                    End If
                    ctrl.Font = f
                    ctrl.BackColor = myBackColor
                    ctrl.ForeColor = myForeColorColor
                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))
                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                    pnControls.Controls.Add(ctrl)
                Case "Line"
                    Dim myBackColor As New Color()
                    myBackColor = ColorTranslator.FromHtml(gParam(8))
                    Dim ctrl As New Line()
                    ctrl.Name = gParam(10)
                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))
                    ctrl.BackColor = myBackColor
                    ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                    ctrl.Orientation = LineOrientation.Horizontal

                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                    pnControls.Controls.Add(ctrl)
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub loadShanuLabelDesign()
        Try
            Select Case gParam(0)
                Case "System.Windows.Forms.PictureBox"
                    Dim myBackColor As New Color()
                    myBackColor = ColorTranslator.FromHtml(gParam(8))
                    Dim ctrl As New PictureBox()
                    ctrl.BackColor = myBackColor
                    ctrl.Name = gParam(10)
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

                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                    pnControls.Controls.Add(ctrl)

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
                                ElseIf strArr(0) = "HeaderLeft" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = gParam(5)
                                ElseIf strArr(0) = "TextRight" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleRight
                                    ctrl.Text = gParam(5)
                                ElseIf strArr(0) = "TextMidle" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleCenter
                                    ctrl.Text = gParam(5)
                                ElseIf strArr(0) = "TextLeft" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = gParam(5)
                                ElseIf strArr(0) = "NomorAntrian" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = Convert.ToChar(&H40 + 1).ToString() & " " & String.Format("{0:000}", 45)
                                ElseIf strArr(0) = "DateClock" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = Date.Now.ToString("dddd, d-MM-yyyy", CultureInfo.CreateSpecificCulture("id-ID")) & " , " & Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
                                ElseIf strArr(0) = "Date" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = Date.Now.ToString("dddd, d-MM-yyyy", CultureInfo.CreateSpecificCulture("id-ID"))
                                ElseIf strArr(0) = "Clock" Then
                                    ctrl.TextAlign = ContentAlignment.MiddleLeft
                                    ctrl.Text = Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
                                Else
                                    ctrl.TextAlign = ContentAlignment.MiddleCenter
                                    ctrl.Text = gParam(5)
                                End If
                            Catch ex As Exception

                            End Try

                        Next
                    Catch ex As Exception

                    End Try

                    ctrl.Text = gParam(5)
                    ctrl.Font = f
                    ctrl.BackColor = myBackColor
                    ctrl.ForeColor = myForeColorColor
                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))

                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                    pnControls.Controls.Add(ctrl)
                Case "Printer.Line"
                    Dim myBackColor As New Color()
                    myBackColor = ColorTranslator.FromHtml(gParam(8))
                    Dim ctrl As New Line()
                    ctrl.Name = gParam(10)
                    ctrl.Size = New Size(Convert.ToInt32(gParam(3)), Convert.ToInt32(gParam(4)))
                    ctrl.BackColor = myBackColor
                    ctrl.Location = New Point(Convert.ToInt32(gParam(1)), Convert.ToInt32(gParam(2)))
                    ctrl.Orientation = LineOrientation.Horizontal

                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                    pnControls.Controls.Add(ctrl)
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub createNewLabelDesign()
        pnControls.Invalidate()
        pnControls.Controls.Clear()
        CutToolStripMenuItem.Enabled = False
        CopyToolStripMenuItem.Enabled = False
        PasteToolStripMenuItem.Enabled = False
    End Sub
    Private Sub control_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        tmPos.Stop()
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub control_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        Cursor = Cursors.Default
        tmPos.Start()
    End Sub
    Private Sub control_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            pnControls.Invalidate()
            SelectedControl = CType(sender, Control)
            Dim control_Renamed As Control = CType(sender, Control)
            mouseX = -e.X
            mouseY = -e.Y
            control_Renamed.Invalidate()
            DrawControlBorder(sender)
            propertyGrid1.SelectedObject = SelectedControl
        End If
    End Sub
    Private Sub control_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim control_Renamed As Control = CType(sender, Control)
            Dim nextPosition As New Point()
            nextPosition = pnControls.PointToClient(MousePosition)
            nextPosition.Offset(mouseX, mouseY)
            control_Renamed.Location = nextPosition
            Invalidate()
        End If
    End Sub
    Private Sub control_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim control_Renamed As Control = CType(sender, Control)
            Cursor.Clip = Rectangle.Empty
            control_Renamed.Invalidate()
            DrawControlBorder(control_Renamed)
        End If
    End Sub
    Private Sub DrawControlBorder(ByVal sender As Object)
        Dim control_Renamed As Control = CType(sender, Control)
        Dim Border As New Rectangle(New Point(control_Renamed.Location.X - DRAG_HANDLE_SIZE \ 2, control_Renamed.Location.Y - DRAG_HANDLE_SIZE \ 2), New Size(control_Renamed.Size.Width + DRAG_HANDLE_SIZE, control_Renamed.Size.Height + DRAG_HANDLE_SIZE))
        Dim NW As New Rectangle(New Point(control_Renamed.Location.X - DRAG_HANDLE_SIZE, control_Renamed.Location.Y - DRAG_HANDLE_SIZE), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim N As New Rectangle(New Point(control_Renamed.Location.X + control_Renamed.Width \ 2 - DRAG_HANDLE_SIZE \ 2, control_Renamed.Location.Y - DRAG_HANDLE_SIZE), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim NE As New Rectangle(New Point(control_Renamed.Location.X + control_Renamed.Width, control_Renamed.Location.Y - DRAG_HANDLE_SIZE), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim W As New Rectangle(New Point(control_Renamed.Location.X - DRAG_HANDLE_SIZE, control_Renamed.Location.Y + control_Renamed.Height \ 2 - DRAG_HANDLE_SIZE \ 2), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim E As New Rectangle(New Point(control_Renamed.Location.X + control_Renamed.Width, control_Renamed.Location.Y + control_Renamed.Height \ 2 - DRAG_HANDLE_SIZE \ 2), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim SW As New Rectangle(New Point(control_Renamed.Location.X - DRAG_HANDLE_SIZE, control_Renamed.Location.Y + control_Renamed.Height), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim S As New Rectangle(New Point(control_Renamed.Location.X + control_Renamed.Width \ 2 - DRAG_HANDLE_SIZE \ 2, control_Renamed.Location.Y + control_Renamed.Height), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim SE As New Rectangle(New Point(control_Renamed.Location.X + control_Renamed.Width, control_Renamed.Location.Y + control_Renamed.Height), New Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE))
        Dim g As Graphics = pnControls.CreateGraphics()

        ControlPaint.DrawBorder(g, Border, Color.Gray, ButtonBorderStyle.Dotted)
        ControlPaint.DrawGrabHandle(g, NW, True, True)
        ControlPaint.DrawGrabHandle(g, N, True, True)
        ControlPaint.DrawGrabHandle(g, NE, True, True)
        ControlPaint.DrawGrabHandle(g, W, True, True)
        ControlPaint.DrawGrabHandle(g, E, True, True)
        ControlPaint.DrawGrabHandle(g, SW, True, True)
        ControlPaint.DrawGrabHandle(g, S, True, True)
        ControlPaint.DrawGrabHandle(g, SE, True, True)
        g.Dispose()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

    End Sub

    Private Function imageToByteArray(ByVal bmp As Bitmap) As Byte()
        Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(Bitmap))
        Return CType(converter.ConvertTo(bmp, GetType(Byte())), Byte())
    End Function

    Dim workingFileName As String
    Private Sub Save()
        Dim xmlDoc As New XmlDocument()

        ' Write down the XML declaration
        Dim xmlDeclaration_Renamed As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", Nothing)

        ' Create the root element
        Dim rootNode As XmlElement = xmlDoc.CreateElement("ShanuDrawingToolsList")
        xmlDoc.InsertBefore(xmlDeclaration_Renamed, xmlDoc.DocumentElement)
        xmlDoc.AppendChild(rootNode)

        For Each p As Control In pnControls.Controls
            Dim ControlNames As String = p.Name
            Dim types As String = p.GetType().ToString()
            Dim locX As String = p.Location.X.ToString()
            Dim locY As String = p.Location.Y.ToString()
            Dim sizeWidth As String = p.Width.ToString()
            Dim sizeHegiht As String = p.Height.ToString()
            Dim Texts As String = p.Text.ToString()
            'Dim PostPanel As String = Zorder

            Dim backColors = p.BackColor.Name
            Dim forecolors = p.ForeColor.Name

            Dim pic As PictureBox = TryCast(p, PictureBox)
            Dim bytes() As Byte = Nothing
            Dim PicBitMapImages As String = ""
            If pic IsNot Nothing Then
                If pic.Image IsNot Nothing Then
                    Dim img As New Bitmap(pic.Image)
                    bytes = imageToByteArray(img)
                    PicBitMapImages = Convert.ToBase64String(bytes)
                End If
            End If
            Dim fonts As String = FontToString(p.Font)

            ' Create a new <Category> element and add it to the root node
            Dim parentNode As XmlElement = xmlDoc.CreateElement("Controls")

            ' Set attribute name and value!
            parentNode.SetAttribute("ID", p.GetType().ToString())

            xmlDoc.DocumentElement.PrependChild(parentNode)

            ' Create the required nodes
            Dim CntrlType As XmlElement = xmlDoc.CreateElement("ControlsType")
            Dim locNodeX As XmlElement = xmlDoc.CreateElement("LocationX")
            Dim locNodeY As XmlElement = xmlDoc.CreateElement("LocationY")
            Dim SizeWidth_Renamed As XmlElement = xmlDoc.CreateElement("SizeWidth")
            Dim SizeHegith As XmlElement = xmlDoc.CreateElement("SizeHeight")
            Dim cntText As XmlElement = xmlDoc.CreateElement("Text")
            Dim cntFonts As XmlElement = xmlDoc.CreateElement("Fonts")
            Dim CntrlPictureImage As XmlElement = xmlDoc.CreateElement("picImage")
            Dim CntrlBackColor As XmlElement = xmlDoc.CreateElement("BackColor")
            Dim CntrlForeColor As XmlElement = xmlDoc.CreateElement("ForeColor")
            Dim nodeCntrlName As XmlElement = xmlDoc.CreateElement("CntrlsName")

            Dim nodePanelWidth As XmlElement = xmlDoc.CreateElement("panelWidth")
            Dim nodePanelHeight As XmlElement = xmlDoc.CreateElement("panelHeight")
            ' retrieve the text 
            Dim cntrlKind As XmlText = xmlDoc.CreateTextNode(p.GetType().ToString())

            Dim cntrlLocX As XmlText = xmlDoc.CreateTextNode(locX)
            Dim cntrlLocY As XmlText = xmlDoc.CreateTextNode(locY)

            Dim cntrlWidth As XmlText = xmlDoc.CreateTextNode(sizeWidth)
            Dim cntrlHeight As XmlText = xmlDoc.CreateTextNode(sizeHegiht)

            Dim cntrlText As XmlText = xmlDoc.CreateTextNode(Texts)
            Dim cntrlFont As XmlText = xmlDoc.CreateTextNode(fonts)
            Dim cntrlPicImg As XmlText = xmlDoc.CreateTextNode(PicBitMapImages)
            Dim cntrlBckColor As XmlText = xmlDoc.CreateTextNode(backColors)
            Dim cntrlFrColor As XmlText = xmlDoc.CreateTextNode(forecolors)
            Dim txtCntrlsNames As XmlText = xmlDoc.CreateTextNode(ControlNames)

            Dim txtPanelWidth As XmlText = xmlDoc.CreateTextNode(pnControls.Width.ToString())
            Dim txtPanelHeight As XmlText = xmlDoc.CreateTextNode(pnControls.Height.ToString())
            ' append the nodes to the parentNode without the value
            parentNode.AppendChild(CntrlType)
            parentNode.AppendChild(locNodeX)
            parentNode.AppendChild(locNodeY)
            parentNode.AppendChild(SizeWidth_Renamed)
            parentNode.AppendChild(SizeHegith)
            parentNode.AppendChild(cntText)
            parentNode.AppendChild(cntFonts)
            parentNode.AppendChild(CntrlPictureImage)
            parentNode.AppendChild(CntrlBackColor)
            parentNode.AppendChild(CntrlForeColor)
            parentNode.AppendChild(nodeCntrlName)
            parentNode.AppendChild(nodePanelWidth)
            parentNode.AppendChild(nodePanelHeight)

            ' save the value of the fields into the nodes
            CntrlType.AppendChild(cntrlKind)
            locNodeX.AppendChild(cntrlLocX)
            locNodeY.AppendChild(cntrlLocY)

            SizeWidth_Renamed.AppendChild(cntrlWidth)
            SizeHegith.AppendChild(cntrlHeight)

            cntText.AppendChild(cntrlText)
            cntFonts.AppendChild(cntrlFont)
            CntrlPictureImage.AppendChild(cntrlPicImg)
            CntrlBackColor.AppendChild(cntrlBckColor)
            CntrlForeColor.AppendChild(cntrlFrColor)
            nodeCntrlName.AppendChild(txtCntrlsNames)
            nodePanelWidth.AppendChild(txtPanelWidth)
            nodePanelHeight.AppendChild(txtPanelHeight)
        Next p
        Try
            Dim dlg As New SaveFileDialog()
            dlg.Filter = "XML Files (*.xml)|*.xml"
            xmlDoc.Save(xmlFileName)
            MessageBox.Show("Save berhasil", "OK", MessageBoxButtons.OK)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub SaveAs()
        Dim xmlDoc As New XmlDocument()

        ' Write down the XML declaration
        Dim xmlDeclaration_Renamed As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", Nothing)

        ' Create the root element
        Dim rootNode As XmlElement = xmlDoc.CreateElement("ShanuDrawingToolsList")
        xmlDoc.InsertBefore(xmlDeclaration_Renamed, xmlDoc.DocumentElement)
        xmlDoc.AppendChild(rootNode)

        For Each p As Control In pnControls.Controls
            Dim ControlNames As String = p.Name
            Dim types As String = p.GetType().ToString()
            Dim locX As String = p.Location.X.ToString()
            Dim locY As String = p.Location.Y.ToString()
            Dim sizeWidth As String = p.Width.ToString()
            Dim sizeHegiht As String = p.Height.ToString()
            Dim Texts As String = p.Text.ToString()
            '  Dim PostPanel As String = 

            Dim backColors = p.BackColor.Name
            Dim forecolors = p.ForeColor.Name

            Dim pic As PictureBox = TryCast(p, PictureBox)
            Dim bytes() As Byte = Nothing
            Dim PicBitMapImages As String = ""
            If pic IsNot Nothing Then
                If pic.Image IsNot Nothing Then
                    Dim img As New Bitmap(pic.Image)
                    bytes = imageToByteArray(img)
                    PicBitMapImages = Convert.ToBase64String(bytes)
                End If
            End If
            Dim fonts As String = FontToString(p.Font)

            ' Create a new <Category> element and add it to the root node
            Dim parentNode As XmlElement = xmlDoc.CreateElement("Controls")

            ' Set attribute name and value!
            parentNode.SetAttribute("ID", p.GetType().ToString())

            xmlDoc.DocumentElement.PrependChild(parentNode)

            ' Create the required nodes
            Dim CntrlType As XmlElement = xmlDoc.CreateElement("ControlsType")
            Dim locNodeX As XmlElement = xmlDoc.CreateElement("LocationX")
            Dim locNodeY As XmlElement = xmlDoc.CreateElement("LocationY")
            Dim SizeWidth_Renamed As XmlElement = xmlDoc.CreateElement("SizeWidth")
            Dim SizeHegith As XmlElement = xmlDoc.CreateElement("SizeHeight")
            Dim cntText As XmlElement = xmlDoc.CreateElement("Text")
            Dim cntFonts As XmlElement = xmlDoc.CreateElement("Fonts")
            Dim CntrlPictureImage As XmlElement = xmlDoc.CreateElement("picImage")
            Dim CntrlBackColor As XmlElement = xmlDoc.CreateElement("BackColor")
            Dim CntrlForeColor As XmlElement = xmlDoc.CreateElement("ForeColor")
            Dim nodeCntrlName As XmlElement = xmlDoc.CreateElement("CntrlsName")

            Dim nodePanelWidth As XmlElement = xmlDoc.CreateElement("panelWidth")
            Dim nodePanelHeight As XmlElement = xmlDoc.CreateElement("panelHeight")
            ' retrieve the text 
            Dim cntrlKind As XmlText = xmlDoc.CreateTextNode(p.GetType().ToString())

            Dim cntrlLocX As XmlText = xmlDoc.CreateTextNode(locX)
            Dim cntrlLocY As XmlText = xmlDoc.CreateTextNode(locY)

            Dim cntrlWidth As XmlText = xmlDoc.CreateTextNode(sizeWidth)
            Dim cntrlHeight As XmlText = xmlDoc.CreateTextNode(sizeHegiht)

            Dim cntrlText As XmlText = xmlDoc.CreateTextNode(Texts)
            Dim cntrlFont As XmlText = xmlDoc.CreateTextNode(fonts)
            Dim cntrlPicImg As XmlText = xmlDoc.CreateTextNode(PicBitMapImages)
            Dim cntrlBckColor As XmlText = xmlDoc.CreateTextNode(backColors)
            Dim cntrlFrColor As XmlText = xmlDoc.CreateTextNode(forecolors)
            Dim txtCntrlsNames As XmlText = xmlDoc.CreateTextNode(ControlNames)

            Dim txtPanelWidth As XmlText = xmlDoc.CreateTextNode(pnControls.Width.ToString())
            Dim txtPanelHeight As XmlText = xmlDoc.CreateTextNode(pnControls.Height.ToString())
            ' append the nodes to the parentNode without the value
            parentNode.AppendChild(CntrlType)
            parentNode.AppendChild(locNodeX)
            parentNode.AppendChild(locNodeY)
            parentNode.AppendChild(SizeWidth_Renamed)
            parentNode.AppendChild(SizeHegith)
            parentNode.AppendChild(cntText)
            parentNode.AppendChild(cntFonts)
            parentNode.AppendChild(CntrlPictureImage)
            parentNode.AppendChild(CntrlBackColor)
            parentNode.AppendChild(CntrlForeColor)
            parentNode.AppendChild(nodeCntrlName)
            parentNode.AppendChild(nodePanelWidth)
            parentNode.AppendChild(nodePanelHeight)

            ' save the value of the fields into the nodes
            CntrlType.AppendChild(cntrlKind)
            locNodeX.AppendChild(cntrlLocX)
            locNodeY.AppendChild(cntrlLocY)

            SizeWidth_Renamed.AppendChild(cntrlWidth)
            SizeHegith.AppendChild(cntrlHeight)

            cntText.AppendChild(cntrlText)
            cntFonts.AppendChild(cntrlFont)
            CntrlPictureImage.AppendChild(cntrlPicImg)
            CntrlBackColor.AppendChild(cntrlBckColor)
            CntrlForeColor.AppendChild(cntrlFrColor)
            nodeCntrlName.AppendChild(txtCntrlsNames)
            nodePanelWidth.AppendChild(txtPanelWidth)
            nodePanelHeight.AppendChild(txtPanelHeight)
        Next p
        Try
            Dim dlg As New SaveFileDialog()
            dlg.Filter = "XML Files (*.xml)|*.xml"
            If dlg.ShowDialog() = DialogResult.OK Then
                xmlDoc.Save(dlg.FileName)
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub SavetoXML()
        Dim xmlDoc As New XmlDocument()

        ' Write down the XML declaration
        Dim xmlDeclaration_Renamed As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", Nothing)

        ' Create the root element
        Dim rootNode As XmlElement = xmlDoc.CreateElement("ShanuDrawingToolsList")
        xmlDoc.InsertBefore(xmlDeclaration_Renamed, xmlDoc.DocumentElement)
        xmlDoc.AppendChild(rootNode)

        For Each p As Control In pnControls.Controls
            Dim ControlNames As String = p.Name
            Dim types As String = p.GetType().ToString()
            Dim locX As String = p.Location.X.ToString()
            Dim locY As String = p.Location.Y.ToString()
            Dim sizeWidth As String = p.Width.ToString()
            Dim sizeHegiht As String = p.Height.ToString()
            Dim Texts As String = p.Text.ToString()
            '  Dim PostPanel As String = 

            Dim backColors = p.BackColor.Name
            Dim forecolors = p.ForeColor.Name

            Dim pic As PictureBox = TryCast(p, PictureBox)
            Dim bytes() As Byte = Nothing
            Dim PicBitMapImages As String = ""
            If pic IsNot Nothing Then
                If pic.Image IsNot Nothing Then
                    Dim img As New Bitmap(pic.Image)
                    bytes = imageToByteArray(img)
                    PicBitMapImages = Convert.ToBase64String(bytes)
                End If
            End If
            Dim fonts As String = FontToString(p.Font)

            ' Create a new <Category> element and add it to the root node
            Dim parentNode As XmlElement = xmlDoc.CreateElement("Controls")

            ' Set attribute name and value!
            parentNode.SetAttribute("ID", p.GetType().ToString())

            xmlDoc.DocumentElement.PrependChild(parentNode)

            ' Create the required nodes
            Dim CntrlType As XmlElement = xmlDoc.CreateElement("ControlsType")
            Dim locNodeX As XmlElement = xmlDoc.CreateElement("LocationX")
            Dim locNodeY As XmlElement = xmlDoc.CreateElement("LocationY")
            Dim SizeWidth_Renamed As XmlElement = xmlDoc.CreateElement("SizeWidth")
            Dim SizeHegith As XmlElement = xmlDoc.CreateElement("SizeHeight")
            Dim cntText As XmlElement = xmlDoc.CreateElement("Text")
            Dim cntFonts As XmlElement = xmlDoc.CreateElement("Fonts")
            Dim CntrlPictureImage As XmlElement = xmlDoc.CreateElement("picImage")
            Dim CntrlBackColor As XmlElement = xmlDoc.CreateElement("BackColor")
            Dim CntrlForeColor As XmlElement = xmlDoc.CreateElement("ForeColor")
            Dim nodeCntrlName As XmlElement = xmlDoc.CreateElement("CntrlsName")

            Dim nodePanelWidth As XmlElement = xmlDoc.CreateElement("panelWidth")
            Dim nodePanelHeight As XmlElement = xmlDoc.CreateElement("panelHeight")
            ' retrieve the text 
            Dim cntrlKind As XmlText = xmlDoc.CreateTextNode(p.GetType().ToString())

            Dim cntrlLocX As XmlText = xmlDoc.CreateTextNode(locX)
            Dim cntrlLocY As XmlText = xmlDoc.CreateTextNode(locY)

            Dim cntrlWidth As XmlText = xmlDoc.CreateTextNode(sizeWidth)
            Dim cntrlHeight As XmlText = xmlDoc.CreateTextNode(sizeHegiht)

            Dim cntrlText As XmlText = xmlDoc.CreateTextNode(Texts)
            Dim cntrlFont As XmlText = xmlDoc.CreateTextNode(fonts)
            Dim cntrlPicImg As XmlText = xmlDoc.CreateTextNode(PicBitMapImages)
            Dim cntrlBckColor As XmlText = xmlDoc.CreateTextNode(backColors)
            Dim cntrlFrColor As XmlText = xmlDoc.CreateTextNode(forecolors)
            Dim txtCntrlsNames As XmlText = xmlDoc.CreateTextNode(ControlNames)

            Dim txtPanelWidth As XmlText = xmlDoc.CreateTextNode(pnControls.Width.ToString())
            Dim txtPanelHeight As XmlText = xmlDoc.CreateTextNode(pnControls.Height.ToString())
            ' append the nodes to the parentNode without the value
            parentNode.AppendChild(CntrlType)
            parentNode.AppendChild(locNodeX)
            parentNode.AppendChild(locNodeY)
            parentNode.AppendChild(SizeWidth_Renamed)
            parentNode.AppendChild(SizeHegith)
            parentNode.AppendChild(cntText)
            parentNode.AppendChild(cntFonts)
            parentNode.AppendChild(CntrlPictureImage)
            parentNode.AppendChild(CntrlBackColor)
            parentNode.AppendChild(CntrlForeColor)
            parentNode.AppendChild(nodeCntrlName)
            parentNode.AppendChild(nodePanelWidth)
            parentNode.AppendChild(nodePanelHeight)

            ' save the value of the fields into the nodes
            CntrlType.AppendChild(cntrlKind)
            locNodeX.AppendChild(cntrlLocX)
            locNodeY.AppendChild(cntrlLocY)

            SizeWidth_Renamed.AppendChild(cntrlWidth)
            SizeHegith.AppendChild(cntrlHeight)

            cntText.AppendChild(cntrlText)
            cntFonts.AppendChild(cntrlFont)
            CntrlPictureImage.AppendChild(cntrlPicImg)
            CntrlBackColor.AppendChild(cntrlBckColor)
            CntrlForeColor.AppendChild(cntrlFrColor)
            nodeCntrlName.AppendChild(txtCntrlsNames)
            nodePanelWidth.AppendChild(txtPanelWidth)
            nodePanelHeight.AppendChild(txtPanelHeight)
        Next p


        ' If dlg.ShowDialog() = DialogResult.OK Then
        Try
            Dim dlg As New SaveFileDialog()
            dlg.Filter = "XML Files (*.xml)|*.xml"
            xmlDoc.Save(xmlFileName)
            MessageBox.Show("Save berhasil", "OK", MessageBoxButtons.OK)
        Catch ex As Exception

        End Try

        ' xmlDoc.Save(dlg.FileName)
        'End If
    End Sub

#End Region

#Region "For Panel Print Testing"
    Public Sub GetPrintArea(ByVal pnl As Panel)
        MemoryImage = New Bitmap(pnl.Width, pnl.Height)
        Dim rect As New Rectangle(0, 0, pnl.Width, pnl.Height)
        pnl.DrawToBitmap(MemoryImage, New Rectangle(0, 0, pnl.Width, pnl.Height))
        pnl.Invalidate()
    End Sub
    Public Sub Print(ByVal pnl As Panel, ByVal CopyPrint As Short)
        Dim panel As Panel = pnl
        GetPrintArea(pnl)
        pnControls.Invalidate()
        prtDoc.PrinterSettings.PrinterName = PrintName
        prtDoc.PrinterSettings.Copies = CopyPrint
        Dim controller As PrintController = New StandardPrintController()
        prtDoc.PrintController = controller
        ' previewdlg.Document = prtDoc
        ' previewdlg.ShowDialog()
        prtDoc.Print()

        'Dim panel As Panel = pnl
        'GetPrintArea(pnl)
        ''previewdlg.Document = printDocument1;
        ''previewdlg.ShowDialog();
        'printDialog1.Document = printDocument1

        '' printDialog1.AllowPrintToFile = true;
        'printDialog1.AllowSelection = True
        'printDialog1.AllowSomePages = True
        '' printDialog1.PrintToFile = true;
        'If printDialog1.ShowDialog() = DialogResult.OK Then
        '    ' printDocument1.Print();

        '    previewdlg.Document = printDocument1
        '    previewdlg.ShowDialog()
        'End If
        'pnControls.Invalidate()
    End Sub
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prtDoc.PrintPage
        Dim pagearea As Rectangle = e.PageBounds
        e.Graphics.DrawImage(MemoryImage, 4, 4)
    End Sub
    Public Shared PrintCopy As New Short
    Private Sub tsbPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbPrint.Click
        tmPos.Stop()
        Try
            Dim pd As New PrintDialog()
            PrintName = Interaction.GetSetting("AntPrinter", "Printer", "Printername")
            PrintCopy = Convert.ToInt16(Interaction.GetSetting("AntPrinter", "Printer", "CopyPrint"))
            If PrintName = "" Then
                pd.PrinterSettings = New PrinterSettings()
                If DialogResult.OK = pd.ShowDialog(Me) Then
                    PrintName = pd.PrinterSettings.PrinterName
                    Interaction.SaveSetting("AntPrinter", "Printer", "Printername", PrintName)
                End If
            End If

            Dim printVal As Integer = 0
            For Each p As Control In pnControls.Controls
                p.Invalidate()
                printVal = printVal + 1
            Next p
            If printVal > 0 Then
                Print(Me.pnControls, PrintCopy)
            Else
                MessageBox.Show("No Data to Print")
            End If
        Catch ex As Exception

        End Try

        tmPos.Start()

    End Sub
#End Region

#Region "Tool Strip"

    Private Sub pnControls_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnControls.MouseMove
        If SelectedControl IsNot Nothing AndAlso e.Button = MouseButtons.Left Then
            tmPos.Stop()
            Invalidate()

            If SelectedControl.Height < 20 Then
                SelectedControl.Height = 20
                direction_Renamed = Direction.None
                Cursor = Cursors.Default
                Return
            ElseIf SelectedControl.Width < 20 Then
                SelectedControl.Width = 20
                direction_Renamed = Direction.None
                Cursor = Cursors.Default
                Return
            End If

            'get the current mouse position relative the the app
            Dim pos As Point = pnControls.PointToClient(MousePosition)

            '				#Region "resize the control in 8 directions"
            If direction_Renamed = Direction.NW Then
                'north west, location and width, height change
                newLocation = New Point(pos.X, pos.Y)
                newSize = New Size(SelectedControl.Size.Width - (newLocation.X - SelectedControl.Location.X), SelectedControl.Size.Height - (newLocation.Y - SelectedControl.Location.Y))
                SelectedControl.Location = newLocation
                SelectedControl.Size = newSize
            ElseIf direction_Renamed = Direction.SE Then
                'south east, width and height change
                newLocation = New Point(pos.X, pos.Y)
                newSize = New Size(SelectedControl.Size.Width + (newLocation.X - SelectedControl.Size.Width - SelectedControl.Location.X), SelectedControl.Height + (newLocation.Y - SelectedControl.Height - SelectedControl.Location.Y))
                SelectedControl.Size = newSize
            ElseIf direction_Renamed = Direction.N Then
                'north, location and height change
                newLocation = New Point(SelectedControl.Location.X, pos.Y)
                newSize = New Size(SelectedControl.Width, SelectedControl.Height - (pos.Y - SelectedControl.Location.Y))
                SelectedControl.Location = newLocation
                SelectedControl.Size = newSize
            ElseIf direction_Renamed = Direction.S Then
                'south, only the height changes
                newLocation = New Point(pos.X, pos.Y)
                newSize = New Size(SelectedControl.Width, pos.Y - SelectedControl.Location.Y)
                SelectedControl.Size = newSize
            ElseIf direction_Renamed = Direction.W Then
                'west, location and width will change
                newLocation = New Point(pos.X, SelectedControl.Location.Y)
                newSize = New Size(SelectedControl.Width - (pos.X - SelectedControl.Location.X), SelectedControl.Height)
                SelectedControl.Location = newLocation
                SelectedControl.Size = newSize
            ElseIf direction_Renamed = Direction.E Then
                'east, only width changes
                newLocation = New Point(pos.X, pos.Y)
                newSize = New Size(pos.X - SelectedControl.Location.X, SelectedControl.Height)
                SelectedControl.Size = newSize
            ElseIf direction_Renamed = Direction.SW Then
                'south west, location, width and height change
                newLocation = New Point(pos.X, SelectedControl.Location.Y)
                newSize = New Size(SelectedControl.Width - (pos.X - SelectedControl.Location.X), pos.Y - SelectedControl.Location.Y)
                SelectedControl.Location = newLocation
                SelectedControl.Size = newSize
            ElseIf direction_Renamed = Direction.NE Then
                'north east, location, width and height change
                newLocation = New Point(SelectedControl.Location.X, pos.Y)
                newSize = New Size(pos.X - SelectedControl.Location.X, SelectedControl.Height - (pos.Y - SelectedControl.Location.Y))
                SelectedControl.Location = newLocation
                SelectedControl.Size = newSize
            End If
            '				#End Region
        End If
    End Sub

    Private Sub pnControls_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnControls.MouseDown
        If SelectedControl IsNot Nothing Then
            DrawControlBorder(SelectedControl)
        End If
        tmPos.Start()
    End Sub

    Private Sub PasteNewControl()
        Try

            Dim rnd As New Random()
            Dim randNumber As Integer = rnd.Next(1, 1000)
            Dim newControlsName As String = copiedControl.Name & "_" & randNumber

            Select Case copiedControl.GetType().ToString()

                Case "System.Windows.Forms.PictureBox"
                    Try
                        Dim pic As PictureBox = TryCast(copiedControl, PictureBox)
                        Dim ctrl As New PictureBox()
                        ctrl.Name = newControlsName
                        ctrl.BackColor = copiedControl.BackColor
                        ctrl.ForeColor = copiedControl.ForeColor
                        ctrl.Image = pic.Image
                        ctrl.Location = New Point(copiedControl.Location.X + 4, copiedControl.Location.Y + 2) 'new Point(System.Convert.ToInt32(gParam[1]), System.Convert.ToInt32(gParam[2]));
                        ctrl.SizeMode = PictureBoxSizeMode.StretchImage
                        ctrl.Size = copiedControl.Size 'new System.Drawing.Size(System.Convert.ToInt32(gParam[3]), System.Convert.ToInt32(gParam[4]));
                        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                        pnControls.Controls.Add(ctrl)

                    Catch ex As Exception
                    End Try

                Case "System.Windows.Forms.Label" '현재화면 사용가능여부 조회
                    Dim ctrl As New Label()
                    ctrl.Name = newControlsName
                    ctrl.Location = New Point(copiedControl.Location.X + 4, copiedControl.Location.Y + 2) 'new Point(System.Convert.ToInt32(gParam[1]), System.Convert.ToInt32(gParam[2]));
                    ctrl.Text = copiedControl.Text

                    ctrl.Font = copiedControl.Font
                    ctrl.BackColor = copiedControl.BackColor
                    ctrl.ForeColor = copiedControl.ForeColor
                    ctrl.Size = copiedControl.Size 'new System.Drawing.Size(System.Convert.ToInt32(gParam[3]), System.Convert.ToInt32(gParam[4]));
                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp
                    pnControls.Controls.Add(ctrl)
                Case "Printer.Line"
                    Dim ctrl As New Line()
                    ctrl.Name = newControlsName
                    ctrl.Size = copiedControl.Size 'new System.Drawing.Size(System.Convert.ToInt32(gParam[3]), System.Convert.ToInt32(gParam[4]));
                    ctrl.BackColor = copiedControl.BackColor
                    ctrl.Location = New Point(copiedControl.Location.X + 4, copiedControl.Location.Y + 6) 'new Point(System.Convert.ToInt32(gParam[1]), System.Convert.ToInt32(gParam[2]));
                    ctrl.Orientation = LineOrientation.Horizontal
                    AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
                    AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
                    AddHandler ctrl.MouseDown, AddressOf control_MouseDown
                    AddHandler ctrl.MouseMove, AddressOf control_MouseMove
                    AddHandler ctrl.MouseUp, AddressOf control_MouseUp

                    pnControls.Controls.Add(ctrl)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbText.Click

        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "TextRight_" & randNumber

        Dim ctrl As New Label()
        ctrl.Location = New Point(50, 365)
        ctrl.Name = LableName
        ctrl.Font = New Font("DotMatrix", 8, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Try
            Dim TextBox As New TextBox()
            If TextBox.ShowDialog() = DialogResult.OK Then
                ctrl.Text = TextBox.YourText.Text
            End If

        Catch ex As Exception

        End Try
        ctrl.AutoSize = True
        ctrl.TextAlign = ContentAlignment.BottomRight
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "TextMidle_" & randNumber

        Dim ctrl As New Label()
        ctrl.Location = New Point(50, 365)
        ctrl.Name = LableName
        ctrl.Font = New Font("DotMatrix", 8, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Try
            Dim TextBox As New TextBox()
            If TextBox.ShowDialog() = DialogResult.OK Then
                ctrl.Text = TextBox.YourText.Text
            End If
            'ctrl.Text = "HEADER"

        Catch ex As Exception

        End Try
        ctrl.AutoSize = True
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "TextLeft_" & randNumber

        Dim ctrl As New Label()
        ctrl.Location = New Point(50, 365)
        ctrl.Name = LableName
        ctrl.Font = New Font("DotMatrix", 8, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Try
            Dim TextBox As New TextBox()
            If TextBox.ShowDialog() = DialogResult.OK Then
                ctrl.Text = TextBox.YourText.Text
            End If

        Catch ex As Exception

        End Try
        ctrl.AutoSize = True
        ctrl.TextAlign = ContentAlignment.BottomLeft
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "HeaderMidle_" & randNumber
        Dim ctrl As New Label()
        ctrl.Location = New Point(50, 365)
        ctrl.Name = LableName
        ctrl.Font = New Font("DotMatrix", 12, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Try
            Dim TextBox As New TextBox()
            If TextBox.ShowDialog() = DialogResult.OK Then
                ctrl.Text = TextBox.YourText.Text
            End If
        Catch ex As Exception

        End Try
        ctrl.AutoSize = True
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "HeaderLeft_" & randNumber

        Dim ctrl As New Label()
        ctrl.Location = New Point(50, 365)
        ctrl.Name = LableName
        ctrl.Font = New Font("DotMatrix", 12, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Try
            Dim TextBox As New TextBox()
            If TextBox.ShowDialog() = DialogResult.OK Then
                ctrl.Text = TextBox.YourText.Text
            End If

        Catch ex As Exception

        End Try
        ctrl.AutoSize = True
        ctrl.TextAlign = ContentAlignment.BottomLeft
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbLogo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbLogo.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim PictuerBoxName As String = "Logo_" & randNumber

        Dim ctrl As New PictureBox()
        ctrl.Image = My.Resources.Resources.Logo
        ctrl.Name = PictuerBoxName
        ctrl.BackColor = Color.Black
        ctrl.Location = New Point(0, 365)
        ctrl.Size = New Size(258, 54)
        ' ctrl.AutoSize = True
        ctrl.SizeMode = PictureBoxSizeMode.StretchImage
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbLine_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbLine.Click

        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LineName As String = "Line_" & randNumber
        Dim ctrl As New Line()
        ctrl.Name = LineName
        ctrl.Size = New Size(270, 1)
        ctrl.BackColor = Color.Black
        ctrl.Location = New Point(3, 365)
        ctrl.Orientation = LineOrientation.Horizontal

        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp

        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub tsbDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If SelectedControl IsNot Nothing Then
            pnControls.Controls.Remove(SelectedControl)
            propertyGrid1.SelectedObject = Nothing
            pnControls.Invalidate()
        End If
    End Sub

    Private Sub tsbSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbSave.Click
        Dim SaveVal As Integer = 0
        For Each p As Control In pnControls.Controls
            SaveVal = SaveVal + 1
        Next p
        If SaveVal > 0 Then
            'SavetoXML()
            Save()
        Else
            MessageBox.Show("No Data to Save")
        End If
    End Sub

    Private Sub tsbOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbOpen.Click
        Try

            Dim OpenFileDialog1 As New OpenFileDialog()
            OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) & "\Tikets"
            OpenFileDialog1.Filter = " XML Files|*.xml"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                xmlFileName = OpenFileDialog1.FileName.ToString()
                pnControls.Controls.Clear()
                loadXMLFILE()
                ' MessageBox.Show();
            Else
                Return
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbNew.Click
        xmlFileName = ""

        createNewLabelDesign()

        Dim dpiX As Double
        Dim dpiY As Double
        Dim g As Graphics = Me.CreateGraphics()
        dpiX = g.DpiX
        dpiY = g.DpiY
        Dim newWidth As Double = pnControls.Width '384;
        Dim newHeight As Double = pnControls.Height '288;

        'pnControls.Width = Convert.ToInt32(newWidth);
        'pnControls.Height = Convert.ToInt32(newHeight);

        Dim objfrm As New frmNew(pnControls.Width, pnControls.Height, dpiX, dpiY)
        If objfrm.ShowDialog() = DialogResult.OK Then
            Select Case objfrm.selectedUnitType
                Case "Cm"
                    newWidth = Convert.ToDouble(objfrm.newPixcelWidth * dpiX / 2.54)
                    newHeight = Convert.ToDouble(objfrm.newPixcelHeight * dpiY / 2.54R)
                    'rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smCentimetres;
                    'hrulerControl.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smCentimetres;
                Case "Inch"
                    newWidth = Convert.ToDouble(objfrm.newPixcelWidth * dpiX)
                    newHeight = Convert.ToDouble(objfrm.newPixcelHeight * dpiY)
                    'rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smInches;
                    'hrulerControl.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smInches;
                Case "Mm"
                    newWidth = Convert.ToDouble((objfrm.newPixcelWidth * dpiX) / 25.4R)
                    newHeight = Convert.ToDouble((objfrm.newPixcelHeight * dpiY) / 25.4R)
                    'rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smMillimetres;
                    'hrulerControl.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smMillimetres;
                Case "Pixel"
                    newWidth = Convert.ToDouble(objfrm.newPixcelWidth)
                    newHeight = Convert.ToDouble(objfrm.newPixcelHeight)
                    'rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPixels;
                    'hrulerControl.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPixels;
            End Select

            pnControls.Width = Convert.ToInt32(newWidth)
            pnControls.Height = Convert.ToInt32(newHeight)
            If Convert.ToInt32(newWidth) > pnlMain.Width OrElse Convert.ToInt32(newHeight) > pnlMain.Height Then
                'pnControls.Location = new Point(4, 4);
            Else
                ' pnControls.Location = new Point(60, 50);
            End If
        End If
        'rulerControl2.Width = 30
        'rulerControl2.Height = pnControls.Height
        'hrulerControl.Width = pnControls.Width
        'hrulerControl.Height = 21
    End Sub

    Private Sub tsbCopy_Click(ByVal sender As Object, ByVal e As EventArgs)
        If SelectedControl IsNot Nothing Then
            copiedControl = SelectedControl
            If copiedControl IsNot Nothing Then
                cutCheck = False
                copyCheck = True
                PasteToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub tsbPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
        If copiedControl IsNot Nothing Then
            PasteNewControl()
            If copyCheck = True Then
                PasteToolStripMenuItem.Enabled = True
            End If
            If cutCheck = True Then
                PasteToolStripMenuItem.Enabled = False
                cutCheck = False
            End If

        End If
    End Sub

    Private Sub tsbCut_Click(ByVal sender As Object, ByVal e As EventArgs)

        If SelectedControl IsNot Nothing Then
            copiedControl = SelectedControl
            cutCheck = True
            PasteToolStripMenuItem.Enabled = True
        End If

        If SelectedControl IsNot Nothing Then
            pnControls.Controls.Remove(SelectedControl)
            propertyGrid1.SelectedObject = Nothing
            pnControls.Invalidate()
        End If

    End Sub

    Private Sub tsbBTF_Click(ByVal sender As Object, ByVal e As EventArgs)
        If SelectedControl IsNot Nothing Then
            SelectedControl.BringToFront()
        End If
    End Sub

    Private Sub tsbSTF_Click(ByVal sender As Object, ByVal e As EventArgs)
        If SelectedControl IsNot Nothing Then
            SelectedControl.SendToBack()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If SelectedControl IsNot Nothing Then
            pnControls.Controls.Remove(SelectedControl)
            propertyGrid1.SelectedObject = Nothing
            pnControls.Invalidate()
        End If
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmPos.Tick
        '			#Region "Get the direction and display correct cursor"
        If SelectedControl IsNot Nothing Then
            Dim pos As Point = pnControls.PointToClient(MousePosition)
            'check if the mouse cursor is within the drag handle
            If (pos.X >= SelectedControl.Location.X - DRAG_HANDLE_SIZE AndAlso pos.X <= SelectedControl.Location.X) AndAlso (pos.Y >= SelectedControl.Location.Y - DRAG_HANDLE_SIZE AndAlso pos.Y <= SelectedControl.Location.Y) Then
                direction_Renamed = Direction.NW
                Cursor = Cursors.SizeNWSE
            ElseIf (pos.X >= SelectedControl.Location.X + SelectedControl.Width AndAlso pos.X <= SelectedControl.Location.X + SelectedControl.Width + DRAG_HANDLE_SIZE AndAlso pos.Y >= SelectedControl.Location.Y + SelectedControl.Height AndAlso pos.Y <= SelectedControl.Location.Y + SelectedControl.Height + DRAG_HANDLE_SIZE) Then
                direction_Renamed = Direction.SE
                Cursor = Cursors.SizeNWSE
            ElseIf (pos.X >= SelectedControl.Location.X + SelectedControl.Width \ 2 - DRAG_HANDLE_SIZE \ 2) AndAlso pos.X <= SelectedControl.Location.X + SelectedControl.Width \ 2 + DRAG_HANDLE_SIZE \ 2 AndAlso pos.Y >= SelectedControl.Location.Y - DRAG_HANDLE_SIZE AndAlso pos.Y <= SelectedControl.Location.Y Then
                direction_Renamed = Direction.N
                Cursor = Cursors.SizeNS
            ElseIf (pos.X >= SelectedControl.Location.X + SelectedControl.Width \ 2 - DRAG_HANDLE_SIZE \ 2) AndAlso pos.X <= SelectedControl.Location.X + SelectedControl.Width \ 2 + DRAG_HANDLE_SIZE \ 2 AndAlso pos.Y >= SelectedControl.Location.Y + SelectedControl.Height AndAlso pos.Y <= SelectedControl.Location.Y + SelectedControl.Height + DRAG_HANDLE_SIZE Then
                direction_Renamed = Direction.S
                Cursor = Cursors.SizeNS
            ElseIf (pos.X >= SelectedControl.Location.X - DRAG_HANDLE_SIZE AndAlso pos.X <= SelectedControl.Location.X AndAlso pos.Y >= SelectedControl.Location.Y + SelectedControl.Height \ 2 - DRAG_HANDLE_SIZE \ 2 AndAlso pos.Y <= SelectedControl.Location.Y + SelectedControl.Height \ 2 + DRAG_HANDLE_SIZE \ 2) Then
                direction_Renamed = Direction.W
                Cursor = Cursors.SizeWE
            ElseIf (pos.X >= SelectedControl.Location.X + SelectedControl.Width AndAlso pos.X <= SelectedControl.Location.X + SelectedControl.Width + DRAG_HANDLE_SIZE AndAlso pos.Y >= SelectedControl.Location.Y + SelectedControl.Height \ 2 - DRAG_HANDLE_SIZE \ 2 AndAlso pos.Y <= SelectedControl.Location.Y + SelectedControl.Height \ 2 + DRAG_HANDLE_SIZE \ 2) Then
                direction_Renamed = Direction.E
                Cursor = Cursors.SizeWE
            ElseIf (pos.X >= SelectedControl.Location.X + SelectedControl.Width AndAlso pos.X <= SelectedControl.Location.X + SelectedControl.Width + DRAG_HANDLE_SIZE) AndAlso (pos.Y >= SelectedControl.Location.Y - DRAG_HANDLE_SIZE AndAlso pos.Y <= SelectedControl.Location.Y) Then
                direction_Renamed = Direction.NE
                Cursor = Cursors.SizeNESW
            ElseIf (pos.X >= SelectedControl.Location.X - DRAG_HANDLE_SIZE AndAlso pos.X <= SelectedControl.Location.X + DRAG_HANDLE_SIZE) AndAlso (pos.Y >= SelectedControl.Location.Y + SelectedControl.Height - DRAG_HANDLE_SIZE AndAlso pos.Y <= SelectedControl.Location.Y + SelectedControl.Height + DRAG_HANDLE_SIZE) Then
                direction_Renamed = Direction.SW
                Cursor = Cursors.SizeNESW
            Else
                Cursor = Cursors.Default
                direction_Renamed = Direction.None
            End If
        Else
            direction_Renamed = Direction.None
            Cursor = Cursors.Default
        End If
        '			#End Region
    End Sub

    Private Sub tsbLines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLines.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "Line" & randNumber

        Dim ctrl As New Label()
        ctrl.Location = New Point(2, 366)
        ctrl.Name = LableName
        ctrl.AutoSize = True
        ctrl.Font = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        ctrl.Text = "------------------------------------------------------------------"
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "Line" & randNumber
        Dim ctrl As New Label()
        ctrl.Location = New Point(2, 366)
        ctrl.Name = LableName
        ctrl.AutoSize = True
        ctrl.Font = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        ctrl.Text = "============================================"
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbClock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClock.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 10)
        Dim LableName As String = "Clock" '& randNumber
        Dim ctrl As New Label()
        ctrl.Location = New Point(2, 366)
        ctrl.Width = 65
        ctrl.Height = 14
        ctrl.Name = LableName
        ctrl.Font = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        ctrl.Text = "Clock:" & " " & Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDate.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 10)
        Dim LableName As String = "Date"
        Dim ctrl As New Label()
        ctrl.Location = New Point(2, 366)
        ctrl.Width = 145
        ctrl.Height = 16
        ctrl.Name = LableName
        ctrl.Font = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        ctrl.Text = Date.Now.ToString("dddd, d-MM-yyyy", CultureInfo.CreateSpecificCulture("id-ID"))
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbNomor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNomor.Click

        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "NomorAntrian"
        Dim ctrl As New Label()
        ctrl.Location = New Point(5, 365)
        ctrl.Name = LableName
        ctrl.AutoSize = True
        ctrl.Font = New Font("DotMatrix", 50, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        ctrl.Text = "A 001"
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbNomorSisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNomorSisa.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "SisaNomor"
        Dim ctrl As New Label()
        ctrl.Location = New Point(50, 365)
        ctrl.Name = LableName
        ctrl.AutoSize = True
        ctrl.Font = New Font("DotMatrix", 9, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.TextAlign = ContentAlignment.MiddleLeft
        ctrl.Text = "02"
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbService.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 1000)
        Dim LableName As String = "ServiceName"

        Dim ctrl As New Label()
        ctrl.Location = New Point(50, 365)
        ctrl.Name = LableName
        ctrl.AutoSize = True
        ctrl.Font = New Font("DotMatrix", 9, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.TextAlign = ContentAlignment.MiddleLeft
        ctrl.Text = "Pelayanan Teller"

        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub tsbPrinters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrinters.Click
        propertyGrid1.Hide()
        GroupBox1.Show()
        Try
            nudPrint.Value = CInt(Int(Interaction.GetSetting("AntPrinter", "Printer", "CopyPrint")))
            If nudPrint.Value = 0 Then
                nudPrint.Value = 1
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSettingPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingPrinter.Click
        Dim pd As New PrintDialog()
        pd.PrinterSettings = New PrinterSettings()
        If DialogResult.OK = pd.ShowDialog() Then
            Tiket.PrintName = pd.PrinterSettings.PrinterName
            Interaction.SaveSetting("AntPrinter", "Printer", "Printername", Tiket.PrintName)
        End If
    End Sub

    Private Sub btnSubmite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmite.Click
        Interaction.SaveSetting("AntPrinter", "Printer", "CopyPrint", nudPrint.Value)
        Interaction.SaveSetting("AntPrinter", "Printer", "DelayPrint", numDelay.Value.ToString)
        Me.DialogResult = DialogResult.OK
        GroupBox1.Hide()
        propertyGrid1.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        GroupBox1.Hide()
        propertyGrid1.Show()
    End Sub

    Private Sub BringToFrontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BringToFrontToolStripMenuItem.Click
        If SelectedControl IsNot Nothing Then
            SelectedControl.BringToFront()
        End If
    End Sub

    Private Sub SendToFrontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToFrontToolStripMenuItem.Click
        If SelectedControl IsNot Nothing Then
            SelectedControl.SendToBack()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        If SelectedControl IsNot Nothing Then
            copiedControl = SelectedControl
            If copiedControl IsNot Nothing Then
                cutCheck = False
                copyCheck = True
                PasteToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        If SelectedControl IsNot Nothing Then
            copiedControl = SelectedControl
            cutCheck = True
            PasteToolStripMenuItem.Enabled = True
        End If

        If SelectedControl IsNot Nothing Then
            pnControls.Controls.Remove(SelectedControl)
            propertyGrid1.SelectedObject = Nothing
            pnControls.Invalidate()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        If copiedControl IsNot Nothing Then
            PasteNewControl()
            If copyCheck = True Then
                PasteToolStripMenuItem.Enabled = True
            End If
            If cutCheck = True Then
                PasteToolStripMenuItem.Enabled = False
                cutCheck = False
            End If

        End If
    End Sub

    Private Sub tspDateClock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspDateClock.Click
        Dim rnd As New Random()
        Dim randNumber As Integer = rnd.Next(1, 10)
        Dim LableName As String = "DateClock"
        Dim ctrl As New Label()
        ctrl.Location = New Point(2, 366)
        ctrl.Width = 203
        ctrl.Height = 16
        ctrl.Name = LableName
        ctrl.Font = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        ctrl.Text = Date.Now.ToString("dddd, d-MM-yyyy", CultureInfo.CreateSpecificCulture("id-ID")) & " , " & Date.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID"))
        ctrl.TextAlign = ContentAlignment.MiddleCenter
        AddHandler ctrl.MouseEnter, AddressOf control_MouseEnter
        AddHandler ctrl.MouseLeave, AddressOf control_MouseLeave
        AddHandler ctrl.MouseDown, AddressOf control_MouseDown
        AddHandler ctrl.MouseMove, AddressOf control_MouseMove
        AddHandler ctrl.MouseUp, AddressOf control_MouseUp
        pnControls.Controls.Add(ctrl)

        If CutToolStripMenuItem.Enabled = False Then
            CutToolStripMenuItem.Enabled = True
        End If

        If CopyToolStripMenuItem.Enabled = False Then
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim SaveVal As Integer = 0
        For Each p As Control In pnControls.Controls
            SaveVal = SaveVal + 1
        Next p
        If SaveVal > 0 Then
            SaveAs()
        Else
            MessageBox.Show("No Data to Save")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        pnControls.Controls.Clear()
        loadXMLFILES(filePath)
    End Sub

#End Region



End Class

Public Enum LineOrientation
    Horizontal
    Vertical
End Enum
Public Class Line
    Inherits Panel
    Private _orientation As LineOrientation = LineOrientation.Horizontal
    Private _oldOrientation As LineOrientation = LineOrientation.Vertical

    Public Property Orientation() As LineOrientation
        Get
            Return _orientation
        End Get
        Set(ByVal value As LineOrientation)
            _orientation = value
            ApplyOrientation(value)
            _oldOrientation = _orientation
        End Set
    End Property
    Private Sub ApplyOrientation(ByVal value As LineOrientation)
        If value = LineOrientation.Horizontal AndAlso _oldOrientation = LineOrientation.Vertical Then
        End If
        If value = LineOrientation.Vertical AndAlso _oldOrientation = LineOrientation.Vertical Then
        End If
    End Sub
    Public Class ScrollingBoxText
        Inherits Panel
        Private text_Renamed As String
        Public Sub New(ByVal Text As String)
            MyBase.New()
            Me.text_Renamed = Text
        End Sub
        Public Property Text() As String
            Get
                Return text_Renamed
            End Get
            Set(ByVal value As String)
                text_Renamed = value
            End Set
        End Property
    End Class

End Class

