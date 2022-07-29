Imports System.Data.SqlServerCe

Public Class DepositoForm
    Private Conn As SqlCeConnection
    Private da As SqlCeDataAdapter
    Private cBuilder As SqlCeCommandBuilder
    Private dset As New DataSet()
    Private ds As String = "Data Source=|DataDirectory|\dbAntrian.sdf;Password=antsoft;Persist Security Info=True"

    Public Sub New()
        'Me.Icon = My.Resources.Logo
        ' This call is required by the designer.
        InitializeComponent()
        UpdateKursValas()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Valas_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub UpdateKursValas()
        Conn = New SqlCeConnection(ds)
        Dim query As String = "SELECT * FROM tbDeposito ORDER BY ID"
        Try
            Conn.Open()
            da = New SqlCeDataAdapter(query, Conn)
            da.Fill(dset)
            Conn.Close()
            dgvValas.DataSource = dset.Tables(0)
        Catch
        End Try
        dgvValas.Columns(0).Visible = False
        dgvValas.Columns(1).HeaderText = "Jangka Waktu"
        dgvValas.Columns(2).HeaderText = "<100 Juta"
        dgvValas.Columns(3).HeaderText = "100 Juta - 1 Milyar"
        dgvValas.Columns(4).HeaderText = "> 1 Milyar"
        dgvValas.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvValas.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
        dgvValas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
        dgvValas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
  
    Private Sub dgvValas_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvValas.RowHeaderMouseClick
        Ilbl.Text = dgvValas.Item(0, e.RowIndex).Value.ToString
        txtJangka.Text = dgvValas.Item(1, e.RowIndex).Value.ToString
        txtIsi1.Text = dgvValas.Item(2, e.RowIndex).Value.ToString
        txtIsi2.Text = dgvValas.Item(3, e.RowIndex).Value.ToString
        txtIsi3.Text = dgvValas.Item(4, e.RowIndex).Value.ToString
    End Sub

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim Data As New ValasDataTabel()
        If (txtJangka.Text <> "") AndAlso (txtIsi1.Text <> "") AndAlso (txtIsi2.Text <> "") AndAlso (txtIsi3.Text <> "") Then
            Try
                Data.InsertDeposito(txtJangka.Text, txtIsi1.Text, txtIsi2.Text, txtIsi3.Text)
                dgvValas.Rows.Clear()
                UpdateKursValas()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            MessageBox.Show("Isi Data Dengan Lengkap", "Info")
        End If
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        Dim Data As New ValasDataTabel()
        If (txtJangka.Text <> "") AndAlso (txtIsi1.Text <> "") AndAlso (txtIsi2.Text <> "") AndAlso (txtIsi3.Text <> "") Then
            Data.UpdateDeposito(txtJangka.Text.Trim(), txtIsi1.Text.Trim(), txtIsi2.Text.Trim(), txtIsi3.Text.Trim(), Integer.Parse(Ilbl.Text.Trim()))
            dgvValas.Rows.Clear()
            UpdateKursValas()
        Else
            MessageBox.Show("Isi Semua Field Dengan Lengkap", "Info")
        End If
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim Data As New ValasDataTabel()
        Data.DeleteDeposito(Integer.Parse(Ilbl.Text.Trim()))
        dgvValas.Rows.Clear()
        UpdateKursValas()
    End Sub
End Class