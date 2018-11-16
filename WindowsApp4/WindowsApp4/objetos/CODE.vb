Public Class CODE
    Dim type1 As String
    Dim code1 As String

    Public Property Type As String
        Get
            Return type1
        End Get
        Set(value As String)
            type1 = value
        End Set
    End Property

    Public Property Code As String
        Get
            Return code1
        End Get
        Set(value As String)
            code1 = value
        End Set
    End Property
End Class
