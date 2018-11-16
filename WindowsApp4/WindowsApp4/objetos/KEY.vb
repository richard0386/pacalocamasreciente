Public Class KEY
    Dim branch1 As String
    Dim terminal1 As String
    Dim type1 As String
    Dim voucher1 As String
    Dim country1 As String
    Dim situation1 As String

    Public Property Branch As String
        Get
            Return branch1
        End Get
        Set(value As String)
            branch1 = value
        End Set
    End Property

    Public Property Terminal As String
        Get
            Return terminal1
        End Get
        Set(value As String)
            terminal1 = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return type1
        End Get
        Set(value As String)
            type1 = value
        End Set
    End Property

    Public Property Voucher As String
        Get
            Return voucher1
        End Get
        Set(value As String)
            voucher1 = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return country1
        End Get
        Set(value As String)
            country1 = value
        End Set
    End Property

    Public Property Situation As String
        Get
            Return situation1
        End Get
        Set(value As String)
            situation1 = value
        End Set
    End Property
End Class
