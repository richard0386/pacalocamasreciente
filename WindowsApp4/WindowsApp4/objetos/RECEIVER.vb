Imports WindowsApp4

Public Class RECEIVER
    Dim name1 As String
    Dim identification1 As IDENTIFICATION
    Dim email1 As String

    Public Property Name As String
        Get
            Return name1
        End Get
        Set(value As String)
            name1 = value
        End Set
    End Property

    Public Property Identification As IDENTIFICATION
        Get
            Return identification1
        End Get
        Set(value As IDENTIFICATION)
            identification1 = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return email1
        End Get
        Set(value As String)
            email1 = value
        End Set
    End Property
End Class
