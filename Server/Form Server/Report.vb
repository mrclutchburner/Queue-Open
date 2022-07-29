Imports System.ComponentModel
Imports System.Text
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Globalization
Imports System.Data.SqlServerCe

Partial Public Class Report
    Inherits Form
    Public Shared scon As String = ""
    Private KantorCabang As String = ""
    Public Shared btBawah As String = "00:05:00"
    Public Shared btAtas As String = "00:10:00"
    Public Shared usr As String = ""
    Public Shared psw As String = ""
    Private dt As DataTable
    Private Header As New List(Of String)()
    Private ReportPerLoket As New List(Of PerCounterReport)()
    Private namaFile As String = ""
    Private namaLokets As New List(Of String)()
    Private pdfPage As Integer = 0
    Private Gapgb As Integer = 0
    Private Gapdgv As Integer = 0
    Private dgvTop As Integer
    Private gbBottom As Integer
    Private idxReport, idxLast As Integer
    Public Sub New()
        InitializeComponent()
        rbHourly.Checked = True
        rbService.Checked = True
        dgvTop = dgvReport.Top
        Gapdgv = dgvReport.Left
        rbtnCounter.Checked = True
        Try
            Dim da As New DataAccess()
            Dim tmp As List(Of String) = da.CounterName()
            namaLokets = tmp
            cbCounter.Items.Clear()
            cbCounter.Items.Add("none")
            cbCounter.Items.AddRange(tmp.ToArray())
            Dim tmpLayanan As List(Of String) = da.ReadLayanan()
            cbLayanan.Items.Clear()
            cbLayanan.Items.Add("none")
            cbLayanan.Items.AddRange(tmpLayanan.ToArray())
            Dim NamaUser As List(Of String) = da.ReadNamaUser(1)
            cbUser.Items.Clear()
            cbUser.Items.Add("none")
            cbUser.Items.AddRange(NamaUser.ToArray())
        Catch
        End Try

    End Sub
#Region "Global Function"
    Public Function ConvertJamToInt(ByVal var As String) As Integer
        Dim result As Integer = 0
        var = var.Replace(" ", "")
        Dim tmpAngka() As String = var.Split(New String() {":"}, StringSplitOptions.None)
        result = (Integer.Parse(tmpAngka(0)) * 3600) + (Integer.Parse(tmpAngka(1)) * 60) + Integer.Parse(tmpAngka(2))
        Return result
    End Function

    Public Function SLA(ByVal waktulayan As String, ByVal batasbawah As String, ByVal batasatas As String) As String
        Dim retValue As String = ""
        If waktulayan <> "" Then
            Dim waktuLayan_Renamed As Integer = ConvertJamToInt(waktulayan)
            Dim batasBawah_Renamed As Integer = ConvertJamToInt(batasbawah)
            Dim batasAtas_Renamed As Integer = ConvertJamToInt(batasatas)
            If waktuLayan_Renamed < batasBawah_Renamed Then
                retValue = "Sangat Bagus"
            ElseIf (waktuLayan_Renamed >= batasBawah_Renamed) AndAlso (waktuLayan_Renamed <= batasAtas_Renamed) Then
                retValue = "Bagus"
            ElseIf waktuLayan_Renamed > batasAtas_Renamed Then
                retValue = "Buruk"
            End If
        End If
        Return retValue
    End Function
#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub IsiHeader()
        label4.Text = ""
        label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        For i As Integer = 0 To 2
            label4.Text += Header(i).Trim()
            If i < 2 Then
                label4.Text += vbCrLf
            End If
        Next i
    End Sub

    Private Sub PagingDataTable(ByVal idx As Integer)
        Dim tmpDT As New DataTable()
        Dim dr As DataRow = Nothing
        idxReport = idx
        gbReport.Show()
        If dt.Rows.Count Mod 50 = 0 Then
            idxLast = dt.Rows.Count \ 50
        Else
            idxLast = (dt.Rows.Count \ 50) + 1

        End If
        lbPage.Text = (idxReport + 1).ToString()
        lbLast.Text = idxLast.ToString()
        For i As Integer = 0 To dt.Columns.Count - 1
            tmpDT.Columns.Add(dt.Columns(i).ToString())
        Next i
        For i As Integer = 0 To 49
            dr = tmpDT.NewRow()
            For n As Integer = 0 To dt.Columns.Count - 1
                dr(n) = dt.Rows(i)(n)
            Next n
            tmpDT.Rows.Add(dr)
        Next i
        dgvReport.DataSource = tmpDT
    End Sub
    Public ReportActive As Boolean
    Private Sub btnSOverall_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSOverall.Click
        ReportActive = True
        Dim da As New DataAccess()
        Try
            Dim rdr As SqlCeDataReader = da.RowBukopin(dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
            dt = New DataTable()
            dt.Clear()
            dt.Load(rdr)
            rdr.Close()
            Header.Clear()
            Header.Add("Jenis Laporan     : Service Overall")
            Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
            Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
            Header.Add("")
            Header.Add("")
            IsiHeader()
            If dt.Rows.Count <= 50 Then
                gbReport.Enabled = False
                dgvReport.DataSource = dt
            Else
                gbReport.Enabled = True
                PagingDataTable(0)
            End If
            dgvReport.Columns(0).HeaderText = "Jenis Layanan"
            dgvReport.Columns(1).HeaderText = "Nomor Antrian"
            ' dgvReport.Columns(2).HeaderText = "Foto Customer"
            dgvReport.Columns(2).HeaderText = "Waktu Daftar"
            dgvReport.Columns(3).HeaderText = "Start Pelayanan"
            dgvReport.Columns(4).HeaderText = "Finish Pelayanan"
            dgvReport.Columns(5).HeaderText = "Waktu Menunggu"
            dgvReport.Columns(6).HeaderText = "Waktu Pelayanan"
            dgvReport.Columns(7).HeaderText = "Proses"
            dgvReport.Columns(8).HeaderText = "Counter"
            '  dgvReport.Columns(9).HeaderText = "Petugas Pelayanan"
            dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
            dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dgvReport.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnReportAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportAll.Click
        Dim da As New DataAccess()
        ReportActive = False
        Try
            Dim rdr As SqlCeDataReader = da.RowBukopinAll(dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
            dt = New DataTable()
            dt.Clear()
            dt.Load(rdr)
            rdr.Close()
            Header.Clear()
            Header.Add("Jenis Laporan     : Service Overall")
            Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
            Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
            Header.Add("")
            Header.Add("")
            IsiHeader()
            If dt.Rows.Count <= 50 Then
                gbReport.Enabled = False
                dgvReport.DataSource = dt
            Else
                gbReport.Enabled = True
                PagingDataTable(0)
            End If
            dgvReport.Columns(0).HeaderText = "Jenis Layanan"
            dgvReport.Columns(1).HeaderText = "Nomor Antrian"
            dgvReport.Columns(2).HeaderText = "Waktu Daftar"
            dgvReport.Columns(3).HeaderText = "Start Pelayanan"
            dgvReport.Columns(4).HeaderText = "Finish Pelayanan"
            dgvReport.Columns(5).HeaderText = "Waktu Menunggu"
            dgvReport.Columns(6).HeaderText = "Waktu Pelayanan"
            dgvReport.Columns(7).HeaderText = "Proses"
            dgvReport.Columns(8).HeaderText = "Counter"
            dgvReport.Columns(9).HeaderText = "Petugas Pelayanan"
            dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
            dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dgvReport.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnDetail_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDetail.Click
        gbReport.Enabled = False
        ReportActive = False
        Dim da As New DataAccess()
        dt = New DataTable()
        If cbLayanan.Text = "" Then
            Try
                Dim dr As DataRow = Nothing
                Dim i As Integer = 0
                Dim tmpLayanan As List(Of String) = da.ReadLayanan()
                For Each s As String In tmpLayanan
                    dr = dt.NewRow()
                    dr("Nama Layanan") = s
                    dr("Nomor Antrian") = da.TotalTiketPerlayanan(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Berhasil") = da.TotalFinishPerlayanan(i + 1, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Gagal") = da.TotalGagalPerlayanan(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Total Counter") = da.TotalCounterPerlayanan(i + 1, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    Dim timeComponent() As String = da.GetTimeComponentPerLayanan(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Min Waktu menunggu") = timeComponent(0)
                    dr("Mak Waktu menunggu") = timeComponent(1)
                    dr("Rata-rata Waktu menunggu") = timeComponent(2)
                    dr("Min Waktu Pelayanan") = timeComponent(3)
                    dr("Mak Waktu Pelayanan") = timeComponent(4)
                    dr("Rata-rata Waktu Pelayanan") = timeComponent(5)
                    dt.Rows.Add(dr)
                    i += 1
                Next s
                If dt.Rows.Count <= 50 Then
                    gbReport.Enabled = False
                    dgvReport.DataSource = dt
                Else
                    gbReport.Enabled = True
                    PagingDataTable(0)
                End If
                'dgvReport.Columns(0).HeaderText = "Nama Layanan"
                'dgvReport.Columns(1).HeaderText = "Total Tiket"
                'dgvReport.Columns(2).HeaderText = "Berhasil"
                'dgvReport.Columns(3).HeaderText = "Gagal"
                'dgvReport.Columns(4).HeaderText = "Total Counter"
                'dgvReport.Columns(5).HeaderText = "Minimal Waktu Menunggu"
                'dgvReport.Columns(6).HeaderText = "Maximal Waktu Pelayanan"
                'dgvReport.Columns(7).HeaderText = "Rata-rata Waktu Pelayanan"
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                dgvReport.Refresh()
                namaFile = "Summary"
                Header.Clear()
                Header.Add("Jenis Laporan     : Detail")
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
                IsiHeader()
            Catch ex As Exception
                MessageBox.Show("Pilih Layanan", "Information", MessageBoxButtons.OK)
            End Try

        Else
            Dim rdr As SqlCeDataReader = da.RowBukopin(dtpFrom.Value, dtpTo.Value, cbLayanan.Text)
            dt = New DataTable()
            dt.Clear()
            dt.Load(rdr)
            rdr.Close()
            If dt.Rows.Count <= 50 Then
                gbReport.Enabled = False
                dgvReport.DataSource = dt
            Else
                gbReport.Enabled = True
                PagingDataTable(0)
            End If
            ' dgvReport.Columns(0).HeaderText = "Nama Layanan"
            'dgvReport.Columns(1).HeaderText = "Nomor Antrian"
            'dgvReport.Columns(2).HeaderText = "Regristrasi"
            'dgvReport.Columns(3).HeaderText = "Minimal Waktu Menunggu"
            'dgvReport.Columns(4).HeaderText = "Maximal Waktu Pelayanan"
            'dgvReport.Columns(5).HeaderText = "Rata-rata Waktu Pelayanan"
            'dgvReport.Columns(6).HeaderText = "Operation"
            'dgvReport.Columns(7).HeaderText = "Petugas"
            dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
            dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dgvReport.Refresh()
            namaFile = "Summary"
            Header.Clear()
            Header.Add("Jenis Laporan     : Detail")
            Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
            Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
            Header.Add("")
            Header.Add("")
            IsiHeader()
        End If


    End Sub

    Private Sub btnPeak_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeak.Click
        gbReport.Enabled = False
        ReportActive = False
        If rbHourly.Checked Then
            Try
                dt = New DataTable()
                Dim dr As DataRow = Nothing
                Dim da As New DataAccess()
                dt.Columns.Add("Jam")
                dt.Columns.Add("Nama Layanan")
                dt.Columns.Add("Total Tiket")
                dt.Columns.Add("Berhasil Pelayanan")
                dt.Columns.Add("Rata-rata Waktu Menunggu")
                dt.Columns.Add("Rata-rata Waktu Pelayanan")
                For jam As Integer = 0 To 7
                    Dim i As Integer = 0
                    Dim tmpLayanan As List(Of String) = da.ReadLayanan()
                    For Each s As String In tmpLayanan
                        dr = dt.NewRow()
                        dr("Jam") = String.Format("{0:00.00}", jam + 8) & " - " & String.Format("{0:00.00}", jam + 9)
                        dr("Nama Layanan") = s
                        dr("Total Tiket") = da.TotalTiketPerJamPerlayanan(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), jam + 8)
                        dr("Berhasil Pelayanan") = da.TotalFinishPerjamPerlayanan(i + 1, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), jam + 8)
                        Dim timeComponent() As String = da.GetTimeComponentPerjamPerLayanan(i + 1, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), jam + 8)
                        dr("Rata-rata Waktu Menunggu") = timeComponent(0)
                        dr("Rata-rata Waktu Pelayanan") = timeComponent(1)
                        dt.Rows.Add(dr)
                        i += 1
                    Next s
                Next jam
                dgvReport.DataSource = dt
                dgvReport.DataSource = dt
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReport.Refresh()
                namaFile = "Summary"
                Header.Clear()
                Header.Add("Jenis Laporan     : Hourly Base Peak Sevice Time")
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
                pdfPage = 1
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

        ElseIf rbDaily.Checked Then
            Dim hari() As String = {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"}
            Try
                dt = New DataTable()
                Dim dr As DataRow = Nothing
                Dim da As New DataAccess()
                dt.Columns.Add("Hari")
                dt.Columns.Add("Nama Layanan")
                dt.Columns.Add("Total Tiket")
                dt.Columns.Add("Berhasil Pelayanan")
                dt.Columns.Add("Rata-rata Waktu Menunggu")
                For jam As Integer = 0 To 5
                    Dim i As Integer = 0
                    Dim tmpLayanan As List(Of String) = da.ReadLayanan()
                    For Each s As String In tmpLayanan
                        dr = dt.NewRow()
                        dr("Hari") = hari(jam)
                        dr("Nama Layanan") = s
                        dr("Total Tiket") = da.TotalTiketPerhariPerlayanan(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), jam + 2)
                        dr("Berhasil Pelayanan") = da.TotalFinishPerhariPerlayanan(i + 1, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), jam + 2)
                        Dim timeComponent() As String = da.GetTimeComponentPerhariPerLayanan(i + 1, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), jam + 2)
                        dr("Rata-rata Waktu Menunggu") = timeComponent(0)
                        ' dr("Rata-rata Waktu Menunggu 2") = timeComponent(0)
                        dt.Rows.Add(dr)
                        i += 1
                    Next s
                Next jam
                dgvReport.DataSource = dt
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReport.Refresh()
                namaFile = "Summary"
                Header.Clear()
                Header.Add("Jenis Laporan     : Daily Base Peak Service Time")
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
                pdfPage = 1
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
        IsiHeader()
    End Sub

    Private Sub btnPerformance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPerformance.Click
        gbReport.Enabled = False
        ReportActive = False
        If rbService.Checked Then
            Try
                dt = New DataTable()
                Dim dr As DataRow = Nothing
                Dim da As New DataAccess()
                dt.Columns.Add("Layanan")
                dt.Columns.Add("Berhasil")
                dt.Columns.Add("Gagal")
                dt.Columns.Add("Min Waktu menunggu")
                dt.Columns.Add("Mak Waktu menunggu")
                dt.Columns.Add("Rata-rata Waktu menunggu")
                dt.Columns.Add("Min Waktu Pelayanan")
                dt.Columns.Add("Mak Waktu Pelayanan")
                dt.Columns.Add("Rata-rata Waktu Pelayanan")
                dt.Columns.Add("Persentasi SLA")
                Dim i As Integer = 0
                Dim tmpLayanan As List(Of String) = da.ReadLayanan()
                'foreach (string s in MasterController.arrayLayanan)
                For Each s As String In tmpLayanan
                    dr = dt.NewRow()
                    dr("Layanan") = s
                    dr("Berhasil") = da.TotalFinishPerlayanan(i + 1, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Gagal") = da.TotalGagalPerlayanan(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    Dim timeComponent() As String = da.GetTimeComponentPerLayanan(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Min Waktu menunggu") = timeComponent(0)
                    dr("Mak Waktu menunggu") = timeComponent(1)
                    dr("Rata-rata Waktu menunggu") = timeComponent(2)
                    dr("Min Waktu Pelayanan") = timeComponent(3)
                    dr("Mak Waktu Pelayanan") = timeComponent(4)
                    dr("Rata-rata Waktu Pelayanan") = timeComponent(5)
                    dr("Persentasi SLA") = SLA(timeComponent(5), btBawah, btAtas)
                    dt.Rows.Add(dr)
                    i += 1
                Next s
                dgvReport.DataSource = dt
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReport.Refresh()
                Header.Clear()
                Header.Add("Jenis Laporan     : Service Name Base Service Performance Overall")
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            namaFile = "Summary"


        ElseIf rbCounter.Checked Then
            Try
                dt = New DataTable()
                Dim dr As DataRow = Nothing
                Dim da As New DataAccess()
                dt.Columns.Add("Nama loket")
                dt.Columns.Add("Berhasil")
                dt.Columns.Add("Gagal")
                dt.Columns.Add("Min Waktu menunggu")
                dt.Columns.Add("Mak Waktu menunggu")
                dt.Columns.Add("Rata-rata Waktu menunggu")
                dt.Columns.Add("Min Waktu Pelayanan")
                dt.Columns.Add("Mak Waktu Pelayanan")
                dt.Columns.Add("Rata-rata Waktu Pelayanan")
                dt.Columns.Add("Persentasi SLA")
                Dim i As Integer = 0
                Dim NamaLoket As List(Of String) = da.ReadNamaLoket()
                For Each s As String In NamaLoket
                    dr = dt.NewRow()
                    dr("Nama Loket") = s
                    Dim ttFinish As Integer = da.TotalFinishPerloket(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Berhasil") = ttFinish
                    dr("Gagal") = da.TotalGagalPerloket(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23)) ' -ttFinish;
                    Dim timeComponent() As String = da.GetTimeComPerloket(s, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23))
                    dr("Min Waktu menunggu") = timeComponent(0)
                    dr("Mak Waktu menunggu") = timeComponent(1)
                    dr("Rata-rata Waktu menunggu") = timeComponent(2)
                    dr("Min Waktu Pelayanan") = timeComponent(3)
                    dr("Mak Waktu Pelayanan") = timeComponent(4)
                    dr("Rata-rata Waktu Pelayanan") = timeComponent(5)
                    dr("Persentasi SLA") = SLA(timeComponent(5), btBawah, btAtas)
                    dt.Rows.Add(dr)
                    i += 1
                Next s
                dgvReport.DataSource = dt
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReport.Refresh()
                Header.Clear()
                Header.Add("Jenis Laporan     : Counter Base Service Performance Overall")
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            namaFile = "Summary"

        ElseIf rbUser.Checked Then
            Try
                dt = New DataTable()
                Dim dr As DataRow = Nothing
                Dim da As New DataAccess()
                dt.Columns.Add("NIK")
                dt.Columns.Add("User")
                dt.Columns.Add("Berhasil")
                dt.Columns.Add("Gagal")
                dt.Columns.Add("Min Waktu menunggu")
                dt.Columns.Add("Mak Waktu menunggu")
                dt.Columns.Add("Rata-rata Waktu menunggu")
                dt.Columns.Add("Min Waktu Pelayanan")
                dt.Columns.Add("Mak Waktu Pelayanan")
                dt.Columns.Add("Rata-rata Waktu Pelayanan")
                dt.Columns.Add("Persentasi SLA")
                Dim i As Integer = 0
                'List<string> NamaUser = da.ReadNamaUser(1);
                'foreach (string s in MasterController.AllUser)
                Dim NamaUser As List(Of DataPetugas) = da.ReadNamaUserAntrian()
                For Each s As DataPetugas In NamaUser
                    dr = dt.NewRow()
                    dr("NIK") = s.NIK
                    dr("User") = s.Nama
                    Dim ttFinish As Integer = da.TotalFinishPeruser(s.Nama, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), s.NIK)
                    dr("Berhasil") = ttFinish ' da.TotalFinishPeruser(s, dtpFrom.Value, dtpTo.Value);
                    dr("Gagal") = da.TotalGagalPeruser(s.Nama, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), s.NIK) ' -ttFinish;
                    Dim timeComponent() As String = da.GetWaitTimePerUser(s.Nama, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), s.NIK)
                    dr("Min Waktu menunggu") = timeComponent(0)
                    dr("Mak Waktu menunggu") = timeComponent(1)
                    dr("Rata-rata Waktu menunggu") = timeComponent(2)
                    Dim timeComponent2() As String = da.GetTimeComPerUser(s.Nama, dtpFrom.Value, (dtpTo.Value - dtpTo.Value.TimeOfDay).AddHours(23), s.NIK)
                    dr("Min Waktu Pelayanan") = timeComponent(0)
                    dr("Mak Waktu Pelayanan") = timeComponent(1)
                    dr("Rata-rata Waktu Pelayanan") = timeComponent(2)
                    dr("Persentasi SLA") = SLA(timeComponent2(2), btBawah, btAtas)
                    dt.Rows.Add(dr)
                    i += 1
                Next s
                dgvReport.DataSource = dt
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReport.Refresh()
                Header.Clear()
                Header.Add("Jenis Laporan     : User Name Base Service Performance Overall")
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            namaFile = "Summary"
        End If
        IsiHeader()
    End Sub
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Dim tmpDT As New DataTable()
        Dim dr As DataRow = Nothing
        idxReport = 0
        lbPage.Text = (idxReport + 1).ToString()
        For i As Integer = 0 To dt.Columns.Count - 1
            tmpDT.Columns.Add(dt.Columns(i).ToString())
        Next i
        If idxReport < idxLast Then
            For i As Integer = idxReport * 50 To (idxReport + 1) * 50 - 1
                dr = tmpDT.NewRow()
                For n As Integer = 0 To dt.Columns.Count - 1
                    dr(n) = dt.Rows(i)(n)
                Next n
                tmpDT.Rows.Add(dr)
            Next i
        End If
        dgvReport.DataSource = tmpDT
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim tmpDT As New DataTable()
            Dim dr As DataRow = Nothing
            idxReport = idxLast - 1
            lbPage.Text = (idxReport + 1).ToString()
            For i As Integer = 0 To dt.Columns.Count - 1
                tmpDT.Columns.Add(dt.Columns(i).ToString())
            Next i
            For i As Integer = idxReport * 50 To dt.Rows.Count - 1
                dr = tmpDT.NewRow()
                For n As Integer = 0 To dt.Columns.Count - 1
                    dr(n) = dt.Rows(i)(n)
                Next n
                tmpDT.Rows.Add(dr)
            Next i
            dgvReport.DataSource = tmpDT
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrev.Click
        Dim tmpDT As New DataTable()
        Dim dr As DataRow = Nothing
        If idxReport > 0 Then
            idxReport -= 1
        End If
        lbPage.Text = (idxReport + 1).ToString()
        For i As Integer = 0 To dt.Columns.Count - 1
            tmpDT.Columns.Add(dt.Columns(i).ToString())
        Next i
        If idxReport < idxLast Then
            For i As Integer = idxReport * 50 To (idxReport + 1) * 50 - 1
                dr = tmpDT.NewRow()
                For n As Integer = 0 To dt.Columns.Count - 1
                    dr(n) = dt.Rows(i)(n)
                Next n
                tmpDT.Rows.Add(dr)
            Next i
        End If
        dgvReport.DataSource = tmpDT
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Try
            Dim tmpDT As New DataTable()
            Dim dr As DataRow = Nothing
            idxReport = idxLast - 1
            lbPage.Text = (idxReport + 1).ToString()
            For i As Integer = 0 To dt.Columns.Count - 1
                tmpDT.Columns.Add(dt.Columns(i).ToString())
            Next i
            For i As Integer = idxReport * 50 To dt.Rows.Count - 1

                dr = tmpDT.NewRow()
                For n As Integer = 0 To dt.Columns.Count - 1
                    dr(n) = dt.Rows(i)(n)
                Next n
                tmpDT.Rows.Add(dr)
            Next i
            dgvReport.DataSource = tmpDT
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Report_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        gbReport.Enabled = False
    End Sub

    Private Sub setingKoneksiToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnDetailCounter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDetailCounter.Click
        Dim da As New DataAccess()
        ReportActive = False
        If rbtnCounter.Checked Then
            If cbCounter.Text = "" OrElse cbCounter.Text = "none" Then
                'Dim dr As DataRow = Nothing
                'Dim i As Integer = 0
                'Dim tmpLayanan As List(Of String) = da.ReadNamaLoket
                dt = New DataTable()
                gbReport.Enabled = False
                Dim rdr As SqlCeDataReader = da.RowBukopin(dtpFrom.Value, dtpTo.Value, cbCounter.SelectedIndex)
                dt = New DataTable()
                dt.Clear()
                dt.Load(rdr)
                rdr.Close()
                If dt.Rows.Count <= 50 Then
                    gbReport.Enabled = False
                    dgvReport.DataSource = dt
                Else
                    gbReport.Enabled = True
                    PagingDataTable(0)
                End If
                namaFile = "Summary"
                Header.Clear()
                Header.Add("Jenis Laporan     : Detail Report " & cbCounter.Text)
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
                IsiHeader()
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReport.Refresh()
            Else
                dt = New DataTable()
                gbReport.Enabled = False
                Dim rdr As SqlCeDataReader = da.RowBukopin(dtpFrom.Value, dtpTo.Value, cbCounter.SelectedIndex)
                dt = New DataTable()
                dt.Clear()
                dt.Load(rdr)
                rdr.Close()
                If dt.Rows.Count <= 50 Then
                    gbReport.Enabled = False
                    dgvReport.DataSource = dt
                Else
                    gbReport.Enabled = True
                    PagingDataTable(0)
                End If
                namaFile = "Summary"
                Header.Clear()
                Header.Add("Jenis Laporan     : Detail Report " & cbCounter.Text)
                Header.Add("Durasi            : " & dtpFrom.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")) & "          Sampai   : " & dtpTo.Value.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString("dddd, d/MM/yyyy" & "  " & "HH:mm:ss", CultureInfo.CreateSpecificCulture("id-ID")))
                Header.Add("")
                Header.Add("")
                IsiHeader()
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReport.Refresh()
            End If
        End If

        If rbtnUser.Checked Then
            If cbUser.Text = "" OrElse cbUser.Text = "none" Then
                gbReport.Enabled = False
                Dim rdr As SqlCeDataReader = da.RowBukopinUser(dtpFrom.Value, dtpTo.Value, cbUser.Text)
                dt = New DataTable()
                dt.Clear()
                dt.Load(rdr)

                If dt.Rows.Count <= 50 Then
                    gbReport.Enabled = False
                    dgvReport.DataSource = dt
                Else
                    gbReport.Enabled = True
                    PagingDataTable(0)
                End If
                dgvReport.DataSource = dt
                rdr.Close()
                dgvReport.DataSource = dt
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                dgvReport.Refresh()
                namaFile = "Summary"
                Header.Clear()
                Header.Add("Jenis Laporan     : Detail User " & cbUser.Text)
                Header.Add("Durasi            : " & dtpFrom.Value.ToShortDateString() & " - " & dtpTo.Value.ToShortDateString())
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString())
                Header.Add("")
                Header.Add("")
                IsiHeader()
            Else
                gbReport.Enabled = False
                Dim rdr As SqlCeDataReader = da.RowBukopinUser(dtpFrom.Value, dtpTo.Value, cbUser.Text)
                dt = New DataTable()
                dt.Clear()
                dt.Load(rdr)

                If dt.Rows.Count <= 50 Then
                    gbReport.Enabled = False
                    dgvReport.DataSource = dt
                Else
                    gbReport.Enabled = True
                    PagingDataTable(0)
                End If
                dgvReport.DataSource = dt
                rdr.Close()
                dgvReport.DataSource = dt
                dgvReport.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
                dgvReport.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                dgvReport.Refresh()
                namaFile = "Summary"
                Header.Clear()
                Header.Add("Jenis Laporan     : Detail User " & cbUser.Text)
                Header.Add("Durasi            : " & dtpFrom.Value.ToShortDateString() & " - " & dtpTo.Value.ToShortDateString())
                Header.Add("Waktu Pengambilan : " & Date.Now.ToString())
                Header.Add("")
                Header.Add("")
                IsiHeader()
            End If
        End If
    End Sub

    Public Function djieGetDataToImage(ByVal pData As Byte()) As Drawing.Image
        Try
            Dim imgConverter As New System.Drawing.ImageConverter()
            Return TryCast(imgConverter.ConvertFrom(pData), Drawing.Image)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dt = New DataTable()
        Dim da As New DataAccess()
        Dim rdr As SqlCeDataReader = da.ReadAllData()
        dt = New DataTable()
        dt.Clear()
        dt.Load(rdr)

        If dt.Rows.Count <= 50 Then
            gbReport.Enabled = False
            dgvReport.DataSource = dt
        Else
            gbReport.Enabled = True
            'PagingDataTable(0)
        End If
        dgvReport.DataSource = dt
    End Sub

    Private Sub dgvReport_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReport.CellClick
        ' If ReportActive = True Then
        ' pbFotoCustomer.Image = djieGetDataToImage(dgvReport.CurrentRow.Cells(2).Value)
        lblNomor.Text = dgvReport.CurrentRow.Cells(1).Value.ToString
        lblJenis.Text = dgvReport.CurrentRow.Cells(0).Value.ToString
        lblWaktu.Text = dgvReport.CurrentRow.Cells(9).Value.ToString
        lblCounter.Text = dgvReport.CurrentRow.Cells(8).Value.ToString
        'ElseIf ReportActive = False Then
        '' pbFotoCustomer.Image = Nothing
        'lblNomor.Text = "........................."
        'lblJenis.Text = "........................."
        'lblWaktu.Text = "........................."
        'lblCounter.Text = "........................."
        'End If

    End Sub
End Class
