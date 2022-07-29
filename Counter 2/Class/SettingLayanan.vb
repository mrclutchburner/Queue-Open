Imports System.Text

Namespace Counters
	Friend Class SettingLayanan
		Private Shared arrayLayanan() As String
		Public Shared araySub() As String
		Public Sub New()
		End Sub

		Public Sub New(ByVal arraylayanan() As String, ByVal arraysub() As String)
			SettingLayanan.arrayLayanan = arraylayanan
			araySub = arraysub
		End Sub


		Public ReadOnly Property getArray() As String()
			Get
				Return arrayLayanan
			End Get
		End Property
	End Class
End Namespace
