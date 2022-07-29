Public Class Transfer
    Private Sub Transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbLayanan.Items.AddRange(Client.NamaLayanan)
        If Client.CurrentDisplay > 0 Then
            txtNomor.Text = Client.CurrentDisplay.ToString()
        Else
            txtNomor.Text = "1"
        End If
        Dim cc As New CounterComponent()
        cbLayanan.SelectedIndex = cc.Service - 1
    End Sub
    Private Sub txtSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubmit.Click
        If Not Client.isAdvance Then
            If (Not cbLayanan.Text.Equals("")) AndAlso ((Not txtNomor.Text.Equals(""))) Then
                If cbLayanan.SelectedIndex + 1 = Client.Layanan Then
                    MessageBox.Show("Anda tidak bisa melakukan proses transfer" & vbLf & "ke layanan yang sama", "Info")
                    Me.DialogResult = DialogResult.No
                    Me.Close()
                Else
                    Me.DialogResult = DialogResult.OK
                    Dim rndtrv As New RandomTransferValue(Integer.Parse(txtNomor.Text), cbLayanan.SelectedIndex + 1) 'int.Parse(txtLayanan.Text)
                    Me.Close()
                End If
            Else
                MessageBox.Show("Isi Textbox Layanan dan Nomor dengan lengkap")
            End If
        Else
            If Not cbLayanan.Text.Equals("") Then
                Me.DialogResult = DialogResult.OK
                Dim rndtrv As New RandomTransferValue(0, cbLayanan.SelectedIndex + 1) 'int.Parse(txtLayanan.Text)
                Me.Close()
            Else
                MessageBox.Show("Isi Textbox Layanan")
            End If
        End If
    End Sub

    Private Sub txtLayanan_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim isNumber As Integer = 0
        e.Handled = Not Integer.TryParse(e.KeyChar.ToString(), isNumber)
        If e.KeyChar = ChrW(8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtNomor_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNomor.KeyPress
        Dim isNumber As Integer = 0
        e.Handled = Not Integer.TryParse(e.KeyChar.ToString(), isNumber)
        If e.KeyChar = ChrW(8) Then
            e.Handled = False
        End If
    End Sub
End Class