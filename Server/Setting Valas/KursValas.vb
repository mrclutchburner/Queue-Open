Imports System.Data.SqlServerCe
Imports System.IO

Public Class KursValas
    Private Conn As SqlCeConnection
    Private da As SqlCeDataAdapter
    Private dset As New DataSet()
    Private cBuilder As SqlCeCommandBuilder
    Private ds As String = "Data Source=|DataDirectory|\dbAntrian.sdf;Password=antsoft;Persist Security Info=True;File Mode=Read Write"

    Public Sub New()
        ' Me.Icon = My.Resources.Logo
        ' This call is required by the designer.
        InitializeComponent()
        UpdateKursValas()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region "KursValas"
    Private Const ItemHeight As Integer = 50
    Private Const ItemWidth As Integer = 150
    Public Sub UpdateKursValas()
        Conn = New SqlCeConnection(ds)
        Dim query As String = "SELECT * FROM tbKursValas ORDER BY ID"
        Try
            Conn.Open()
            da = New SqlCeDataAdapter(query, Conn)
            da.Fill(dset)
            Conn.Close()
            dgvValas.DataSource = dset.Tables(0)
        Catch
        End Try
        dgvValas.Columns(0).Visible = False
        dgvValas.Columns(1).HeaderText = "Kode Negara"
        dgvValas.Columns(2).HeaderText = "Jual"
        dgvValas.Columns(3).HeaderText = "Beli"
        dgvValas.Columns(4).HeaderText = "Nama Negara"
        dgvValas.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvValas.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
        dgvValas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
        dgvValas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub dgvValas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvValas.CellEndEdit
        Try
            cBuilder = New SqlCeCommandBuilder(da)
            da.Update(dset)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Data As New ValasDataTabel()
        If (txtFlag.Text <> "") AndAlso (txtJual.Text <> "") AndAlso (txtBeli.Text <> "") AndAlso (txtNegara.Text <> "") Then
            Try
                Data.InsertDataKurs(txtFlag.Text, txtJual.Text, txtBeli.Text, txtNegara.Text)
                dgvValas.Rows.Clear()
                UpdateKursValas()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
        End Try
        Else
            MessageBox.Show("Isi Data Dengan Lengkap", "Info")
        End If

    End Sub
    Public Shared FilePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\Flag"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New OpenFileDialog()
        f.InitialDirectory = FilePath
        f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|PNG|*.png*"
        f.FilterIndex = 5
        If f.ShowDialog() = DialogResult.OK Then
            lblNegara.Text = f.FileName
            pbFlag.ImageLocation = lblNegara.Text
        End If
    End Sub

    Private Sub dgvValas_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvValas.RowHeaderMouseClick
        Idlbl.Text = dgvValas.Item(0, e.RowIndex).Value.ToString
        txtFlag.Text = dgvValas.Item(1, e.RowIndex).Value.ToString
        txtJual.Text = dgvValas.Item(2, e.RowIndex).Value.ToString
        txtBeli.Text = dgvValas.Item(3, e.RowIndex).Value.ToString
        txtNegara.Text = dgvValas.Item(4, e.RowIndex).Value.ToString
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Data As New ValasDataTabel()
        If (txtNegara.Text <> "") AndAlso (txtFlag.Text <> "") AndAlso (txtJual.Text <> "") AndAlso (txtBeli.Text <> "") Then
            Data.UpdateValas(txtFlag.Text.Trim(), txtJual.Text.Trim(), txtBeli.Text.Trim(), txtNegara.Text.Trim(), Integer.Parse(Idlbl.Text.Trim()))
            dgvValas.Rows.Clear()
            UpdateKursValas()
        Else
            MessageBox.Show("Isi Semua Field Dengan Lengkap", "Info")
        End If
    End Sub
#End Region

  
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim Data As New ValasDataTabel()
        Data.DeleteKursValas(Integer.Parse(Idlbl.Text.Trim()))
        dgvValas.Rows.Clear()
        UpdateKursValas()
    End Sub
End Class