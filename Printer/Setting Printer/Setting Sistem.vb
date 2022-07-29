Imports System.Text.RegularExpressions
Imports System.Data.SqlServerCe

Public Class Setting_Sistem
    Dim Reg As New RegAcces
    Private Sub Setting_Sistem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Iptxt.Text = Reg.ReadRegValue("AntPrinter", "Printer", "IPServer")
        UpdateDataGridview()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Reg.CreateReg("AntPrinter", "Printer", "IPServer", Iptxt.Text)
        Me.DialogResult = DialogResult.OK
        'MainPrinter.Refresh()
        Close()
    End Sub

    'Private Sub Iptxt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Iptxt.LostFocus
    '    Dim rx As New Regex("^(?:(?:25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)(?(?=\.?\d)\.)){4}$")
    '    If Not rx.IsMatch(Iptxt.Text) Then
    '        Iptxt.SelectAll()
    '        MessageBox.Show("Format IP tidak sesuai, contoh IP 192.168.88.99", "Information")
    '    End If
    'End Sub
    Private Conn As SqlCeConnection
    Private da As SqlCeDataAdapter
    Private dset As New DataSet()
    Private ds As String = "Data Source=|DataDirectory|\dbValas.sdf;Password=antsoft;Persist Security Info=True;File Mode=Read Write"
    Private Sub UpdateDataGridview()
        Conn = New SqlCeConnection(ds)
        Dim query As String = "SELECT * FROM tbUSer ORDER BY ID"
        Try
            Conn.Open()
            da = New SqlCeDataAdapter(query, Conn)
            da.Fill(dset)
            Conn.Close()
            dgvUser.DataSource = dset.Tables(0)
        Catch
        End Try
        dgvUser.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvUser.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque
        dgvUser.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
        dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If (txtUser.Text <> "") AndAlso (txtPassword.Text <> "") Then
            If txtPassword.Text = txtConfirm.Text Then
                Dim da As New DataAccess()
                If Not da.CheckUseName(txtUser.Text, False) Then
                    da.InsertUser(txtUser.Text, txtPassword.Text, True)
                    dgvUser.DataSource.Rows.Clear()
                    UpdateDataGridview()
                Else
                    MessageBox.Show("Username sudah ada", "Info")
                End If
            Else
                MessageBox.Show("Password tidak sama", "Info")
            End If
        Else
            MessageBox.Show("Isi data dengan lengkap", "Info")
        End If
        txtConfirm.Clear()
        txtPassword.Clear()
        txtUser.Clear()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtUser.Text <> "" Then
            Dim da As New DataAccess()
            da.DeleteUser(txtUser.Text.Trim())
            dgvUser.DataSource.Rows.Clear()
            UpdateDataGridview()
        Else
            MessageBox.Show("Isi Field User Dengan Lengkap", "Info")
        End If
    End Sub

    'Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (txtUser.Text <> "") AndAlso (txtConfirm.Text <> "") Then
    '        Dim da As New DataAccess()
    '        If da.CheckLogin(txtUser.Text.Trim(), txtConfirm.Text.Trim()) Then
    '            da.UpdateUser(txtUser.Text.Trim(), txtUser.Text.Trim(), False)
    '            UpdateDataGridview()
    '        End If
    '    Else
    '        MessageBox.Show("Isi Semua Field Dengan Lengkap", "Info")
    '    End If
    'End Sub

    Private Sub dgvUser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUser.CellClick
        Dim tmpUser As String = dgvUser("UserName", e.RowIndex).Value.ToString()
        txtUser.Text = tmpUser
    End Sub
End Class