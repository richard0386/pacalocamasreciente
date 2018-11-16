Public Class IDENTIFICATION
    Dim type1 As String

    Dim number1 As String

    Public Property Type As String
        Get
            Return type1
        End Get
        Set(value As String)
            type1 = value
        End Set
    End Property

    Public Property Number As String
        Get
            Return number1
        End Get
        Set(value As String)
            number1 = value
        End Set
    End Property
End Class
