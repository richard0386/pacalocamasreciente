Public Class EXONERATION
    Dim documentType1 As String

    Dim documentNumber1 As String
    Dim institutionName1 As String
    Dim issueDate1 As DateTime
    Dim taxAmountas1 As Decimal
    Dim purchasePercentage1 As Decimal

    Public Property DocumentType As String
        Get
            Return documentType1
        End Get
        Set(value As String)
            documentType1 = value
        End Set
    End Property

    Public Property DocumentNumber As String
        Get
            Return documentNumber1
        End Get
        Set(value As String)
            documentNumber1 = value
        End Set
    End Property

    Public Property InstitutionName As String
        Get
            Return institutionName1
        End Get
        Set(value As String)
            institutionName1 = value
        End Set
    End Property

    Public Property IssueDate As Date
        Get
            Return issueDate1
        End Get
        Set(value As Date)
            issueDate1 = value
        End Set
    End Property

    Public Property TaxAmountas As Decimal
        Get
            Return taxAmountas1
        End Get
        Set(value As Decimal)
            taxAmountas1 = value
        End Set
    End Property

    Public Property PurchasePercentage As Decimal
        Get
            Return purchasePercentage1
        End Get
        Set(value As Decimal)
            purchasePercentage1 = value
        End Set
    End Property
End Class
