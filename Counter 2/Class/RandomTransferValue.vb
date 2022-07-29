Imports System.Text

Friend Class RandomTransferValue
    Private Shared nomor_Renamed As Integer
    Private Shared layanan As Integer
    Public Sub New(ByVal _nomor As Integer, ByVal _layanan As Integer)
        nomor_Renamed = _nomor
        layanan = _layanan
    End Sub

    Public Sub New()

    End Sub

    Public ReadOnly Property Nomor() As Integer
        Get
            Return nomor_Renamed
        End Get
    End Property
    Public ReadOnly Property Service() As Integer
        Get
            Return layanan
        End Get
    End Property
End Class
