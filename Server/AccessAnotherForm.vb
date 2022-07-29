Imports System.Text
Imports System.Threading
Imports System.Runtime.Remoting.Messaging

Friend Class AccessForm
    Private Shared Function FindOpenForm(ByVal typ As Type) As Form
        For i1 As Integer = 0 To Application.OpenForms.Count - 1
            If (Not Application.OpenForms(i1).IsDisposed) AndAlso (Application.OpenForms(i1).GetType() Is typ) Then
                Return Application.OpenForms(i1)
            End If
        Next i1
        Return Nothing
    End Function

    Public Shared Sub SetVolume()
        Try
            Dim frm1 As Server = CType(FindOpenForm(GetType(Server)), Server)
            If frm1 IsNot Nothing Then
                frm1.SetVolumeVideo()
            End If
        Catch
        End Try
    End Sub
End Class
