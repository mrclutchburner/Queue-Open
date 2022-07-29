Public Class UserLogin
    Dim Data As New DataAccess()
    Private Sub UserLoginLoad()
        If (TxtUser.Text <> "") AndAlso (TxtPassword.Text <> "") Then
            Dim da As New DataAccess()
            If da.CheckAdmin(TxtUser.Text.Trim(), TxtPassword.Text.Trim(), False) Then
                Server.AdminAktif = True
                Me.DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show("Anda Bukan Admin")
            End If
        Else
            MessageBox.Show("Isi data dengan lengkap", "Info")
        End If
    End Sub
    Private Sub TxtUser_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtUser.KeyPress
        If e.KeyChar = ChrW(13) Then
            UserLoginLoad()
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = ChrW(13) Then
            UserLoginLoad()
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        UserLoginLoad()
    End Sub

    Private Sub UserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class