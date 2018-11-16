Public Class HEADER
    Dim date1 As DateTime
    Dim termOfSale1 As String

    Dim creditTerm1 As Integer

    Dim paymentMethod1 As String

    Public Property [Date] As DateTime

        Get
            Return date1
        End Get
        Set(value As Date)
            date1 = value
        End Set
    End Property

    Public Property TermOfSale As String
        Get
            Return termOfSale1
        End Get
        Set(value As String)
            termOfSale1 = value
        End Set
    End Property

    Public Property CreditTerm As Integer
        Get
            Return creditTerm1
        End Get
        Set(value As Integer)
            creditTerm1 = value
        End Set
    End Property

    Public Property PaymentMethod As String
        Get
            Return paymentMethod1
        End Get
        Set(value As String)
            paymentMethod1 = value
        End Set
    End Property
End Class
