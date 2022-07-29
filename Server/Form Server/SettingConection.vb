Imports System.IO.Ports
Imports GsmComm.GsmCommunication
Imports System.IO
Imports System.Data.SqlServerCe

Public Class SettingConection
    Private portName As String
    Private baudRate As Integer
    Private timeout As Integer
    Public Shared RegrisName As String = "DleuxAntrian"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Try
            'Display all available COM Ports"
            Dim ports() As String = SerialPort.GetPortNames()

            ' Add all port names to the combo box:
            For Each port As String In ports
                cboPort.Items.Add(port)
            Next port
            '			
            'Remove tab pages
            'Me.btnDisconnect.Enabled = False
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try
        'Dim tmpNamaPort As String = Interaction.GetSetting("AntServer\Client", "Part", "SerialPort")
        ' cboPort.Text = tmpNamaPort
        Dim Ceck As String = Interaction.GetSetting("AntServer\Server", "GSMS", "SMSComponent")
        If Ceck <> "" Then
            Dim tmp() As String = Ceck.Split(New String() {vbCrLf}, StringSplitOptions.None)
            cboPort.Text = tmp(0)
            cboBaudRate.Text = tmp(1)
            cboTimeout.Text = tmp(2)
        End If
        ' Add any initialization after the InitializeComponent() call.
        Try
            Dim SMSCeck As String = Interaction.GetSetting("AntServer\Server", "GSMS", "SMSFormat")
            If SMSCeck <> "" Then
                txtFormat.Text = SMSCeck
            End If
        Catch ex As Exception

        End Try
        ShowData()

    End Sub



#Region " SMS GateWay"
    Public Sub ErrorLog(ByVal Message As String)
        Dim sw As StreamWriter = Nothing

        Try
            Dim sLogFormat As String = Date.Now.ToShortDateString().ToString() & " " & Date.Now.ToLongTimeString().ToString() & " ==> "
            'string sPathName = @"E:\"
            Dim sPathName As String = "SMSapplicationErrorLog_"

            Dim sYear As String = Date.Now.Year.ToString()
            Dim sMonth As String = Date.Now.Month.ToString()
            Dim sDay As String = Date.Now.Day.ToString()

            Dim sErrorTime As String = sDay & "-" & sMonth & "-" & sYear

            sw = New StreamWriter(sPathName & sErrorTime & ".txt", True)

            sw.WriteLine(sLogFormat & Message)
            sw.Flush()

        Catch ex As Exception
            'ErrorLog(ex.ToString());
        Finally
            If sw IsNot Nothing Then
                sw.Dispose()
                sw.Close()
            End If
        End Try

    End Sub

    Public Sub SetData(ByVal portName As String, ByVal baudRate As Integer, ByVal timeout As Integer)
        portName = portName
        baudRate = baudRate
        timeout = timeout
    End Sub

    Public Sub GetData(<System.Runtime.InteropServices.Out()> ByRef portName As String, <System.Runtime.InteropServices.Out()> ByRef baudRate As Integer, <System.Runtime.InteropServices.Out()> ByRef timeout As Integer)
        portName = Me.portName
        baudRate = Me.baudRate
        timeout = Me.timeout
    End Sub

    Private Function EnterNewSettings() As Boolean
        Dim newPortName As String
        Dim newBaudRate As Integer
        Dim newTimeout As Integer

        Try
            If cboPort.Text.Length = 0 Then
                Throw New FormatException()
            End If
            newPortName = cboPort.Text
        Catch e1 As Exception
            MessageBox.Show(Me, "Invalid port name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboPort.Focus()
            Return False
        End Try

        Try
            newBaudRate = Integer.Parse(cboBaudRate.Text)
        Catch e2 As Exception
            MessageBox.Show(Me, "Invalid baud rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboBaudRate.Focus()
            Return False
        End Try

        Try
            newTimeout = Integer.Parse(cboTimeout.Text)
        Catch e3 As Exception
            MessageBox.Show(Me, "Invalid timeout value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboTimeout.Focus()
            Return False
        End Try

        portName = newPortName
        baudRate = newBaudRate
        timeout = newTimeout

        Return True
    End Function

#End Region

    Private Sub ButttnConnect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButttnConnect.Click
        Dim SMSCom As New SMSComponent()
        Try
            If ((Not cboPort.Text.Equals(""))) AndAlso ((Not cboBaudRate.Text.Equals(""))) AndAlso ((Not cboTimeout.Text.Equals(""))) Then
                SMSCom.PortName = cboPort.Text.Trim()
                SMSCom.BaudRate = CInt(cboBaudRate.Text.Trim())
                SMSCom.Timeout = CInt(cboTimeout.Text.Trim())
                Dim KomponenLoket As String = SMSCom.PortName & vbCrLf & SMSCom.BaudRate & vbCrLf & SMSCom.Timeout
                Interaction.SaveSetting("AntServer\Server", "GSMS", "SMSComponent", KomponenLoket)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Conn As SqlCeConnection
    Private da As SqlCeDataAdapter
    Private dset As New DataSet()
    Private ds As String = "Data Source=|DataDirectory|\dbAntrian.sdf;Password=antsoft;Persist Security Info=True;File Mode=Read Write"
    Private Sub ShowData()
        Conn = New SqlCeConnection(ds)
        Dim query As String = "SELECT * FROM tbLayananSMS ORDER BY ID"
        Try
            Conn.Open()
            da = New SqlCeDataAdapter(query, Conn)
            da.Fill(dset)
            Conn.Close()
            dgvLayanan.DataSource = dset.Tables(0)
        Catch

        End Try
        dgvLayanan.Columns(0).Visible = False
        dgvLayanan.Columns(1).HeaderText = "Nama Layanan"
        dgvLayanan.Columns(2).HeaderText = "Index Layanan"
        dgvLayanan.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvLayanan.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
        dgvLayanan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
        dgvLayanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub dgvLayanan_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvLayanan.RowHeaderMouseClick
        txtLayanan.Text = dgvLayanan.Item(1, e.RowIndex).Value.ToString.ToUpper
        numIndex.Text = dgvLayanan.Item(2, e.RowIndex).Value.ToString.ToUpper
        lblFormat.Text = "FORMAT SMS : " & txtFormat.Text.ToUpper & "#" & dgvLayanan.Item(1, e.RowIndex).Value.ToString.ToUpper
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If (txtLayanan.Text <> "") AndAlso (numIndex.Text <> "") Then
            Dim da As New ValasDataTabel()
            da.InsertLayananSMS(txtLayanan.Text, numIndex.Text)
            dgvLayanan.DataSource.Rows.Clear()
            ShowData()
        Else
            MessageBox.Show("Isi data dengan lengkap", "Info")
        End If
        txtLayanan.Clear()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim da As New ValasDataTabel()
        If (txtLayanan.Text <> "") Then 'AndAlso (numIndex.Text <> "") Then ' AndAlso (txtIsi2.Text <> "") AndAlso (txtIsi3.Text <> "") Then
            da.DeleteLayananSMS(txtLayanan.Text.Trim())
            dgvLayanan.DataSource.Rows.Clear()
            ShowData()
        Else
            MessageBox.Show("Isi Semua Field Dengan Lengkap", "Info")
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim da As New ValasDataTabel()
        If (txtLayanan.Text <> "") AndAlso (numIndex.Text <> "") Then ' AndAlso (txtIsi2.Text <> "") AndAlso (txtIsi3.Text <> "") Then
            da.UpdateLayananSMS(numIndex.Text.Trim(), txtLayanan.Text.Trim()) ', Ilbl.Text.Trim()) ', txtIsi2.Text.Trim(), txtIsi3.Text.Trim(), Ilbl.Text.Trim())
            dgvLayanan.DataSource.Rows.Clear()
            ShowData()
        Else
            MessageBox.Show("Isi Semua Field Dengan Lengkap", "Info")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Interaction.SaveSetting("AntServer\Server", "GSMS", "SMSFormat", txtFormat.Text)
    End Sub


    Private Sub btnSubmite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmite.Click
        Try
            Interaction.SaveSetting("AntServer\Server", "GSMS", "SMSFormat", txtFormat.Text)
        Catch ex As Exception

        End Try
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub
End Class