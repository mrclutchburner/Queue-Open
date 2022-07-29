Imports System.IO

Public Class LoginConfig
    Public Shared User, Password As String
    Public Shadows SkinThm As String = Path.GetDirectoryName(Application.ExecutablePath) & "\Themes.ssk"
    Private Sub LoginConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PasswordTxt.Clear()
        UserTxt.Clear()
    End Sub

    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        If (PasswordTxt.Text <> "") AndAlso (UserTxt.Text <> "") Then
            User = UserTxt.Text.Trim()
            Password = PasswordTxt.Text.Trim()
            Me.DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Place Username and Password data content")
        End If
    End Sub

    Private Sub PasswordTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTxt.KeyPress
        If e.KeyChar = ChrW(13) Then
            If (PasswordTxt.Text <> "") AndAlso (UserTxt.Text <> "") Then
                User = UserTxt.Text.Trim()
                Password = PasswordTxt.Text.Trim()
                Me.DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show("Place Username and Password data content")
            End If
            PasswordTxt.Clear()
        End If
    End Sub

    Private Sub UserTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UserTxt.KeyPress
        If e.KeyChar = ChrW(13) Then
            If (PasswordTxt.Text <> "") AndAlso (UserTxt.Text <> "") Then
                User = UserTxt.Text.Trim()
                Password = PasswordTxt.Text.Trim()
                Me.DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show("Place Username and Password data content")
            End If
            PasswordTxt.Clear()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class