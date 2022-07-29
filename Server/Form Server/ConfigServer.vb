Public Class ConfigServer
    Dim Reg As New RegAcces
    Public Shared RegrisName As String = "DleuxAntrian"
    Private Sub ConfigServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tmpServer As String = Reg.ReadRegValue("AntServer", RegrisName, "Connection")
        If tmpServer <> "" Then
            Dim server, db, id, psw As String
            server = ""
            db = ""
            id = ""
            psw = ""
            Dim arraytmpServer() As String = tmpServer.Split(New String() {";"}, StringSplitOptions.None)
            Dim i As Integer = 0
            For Each s As String In arraytmpServer
                Dim tmp() As String = s.Split(New String() {"="}, StringSplitOptions.None)
                If i = 0 Then
                    server = tmp(1).Trim()
                ElseIf i = 1 Then
                    db = tmp(1).Trim()
                ElseIf i = 2 Then
                    id = tmp(1).Trim()
                ElseIf i = 3 Then
                    psw = tmp(1).Trim()
                End If
                i += 1
            Next s
            ServerTxt.Text = server
            DbTxt.Text = db
            UserTxt.Text = id
            PasswordTxt.Text = psw
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If (ServerTxt.Text <> "") AndAlso (DbTxt.Text <> "") AndAlso (UserTxt.Text <> "") AndAlso (PasswordTxt.Text <> "") Then
            Server.Scon = "server=" & ServerTxt.Text.Trim() & ";database=" & DbTxt.Text.Trim() & ";user id=" & UserTxt.Text.Trim() & ";password=" & PasswordTxt.Text.Trim()
            Reg.CreateReg("AntServer", RegrisName, "Connection", Server.Scon)
        Else
            MessageBox.Show("Isi Semua Field Dengan Lengkap", "Info")
        End If
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub
End Class