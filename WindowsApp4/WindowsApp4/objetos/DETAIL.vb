Imports WindowsApp4

Public Class DETAIL
    Dim number1 As Integer
    Dim code1 As CODE

    Dim quantity1 As Decimal

    Dim unitOfMeasure1 As String

    Dim commercialUnitOfMeasure1 As String
    Dim detail1 As String
    Dim unitPrice1 As Decimal
    Dim totalAmount1 As Decimal
    Dim discount1 As Decimal

    Dim natureOfDiscount1 As String

    Dim subTotal1 As Decimal

    Dim tax1 As List(Of TAX)
    Dim totalLineAmount1 As Decimal

    Public Property Number As Integer
        Get
            Return number1
        End Get
        Set(value As Integer)
            number1 = value
        End Set
    End Property

    Public Property Code As CODE
        Get
            Return code1
        End Get
        Set(value As CODE)
            code1 = value
        End Set
    End Property

    Public Property Quantity As Decimal
        Get
            Return quantity1
        End Get
        Set(value As Decimal)
            quantity1 = value
        End Set
    End Property

    Public Property UnitOfMeasure As String
        Get
            Return unitOfMeasure1
        End Get
        Set(value As String)
            unitOfMeasure1 = value
        End Set
    End Property

    Public Property CommercialUnitOfMeasure As String
        Get
            Return commercialUnitOfMeasure1
        End Get
        Set(value As String)
            commercialUnitOfMeasure1 = value
        End Set
    End Property

    Public Property Detail As String
        Get
            Return detail1
        End Get
        Set(value As String)
            detail1 = value
        End Set
    End Property

    Public Property UnitPrice As Decimal
        Get
            Return unitPrice1
        End Get
        Set(value As Decimal)
            unitPrice1 = value
        End Set
    End Property

    Public Property TotalAmount As Decimal
        Get
            Return totalAmount1
        End Get
        Set(value As Decimal)
            totalAmount1 = value
        End Set
    End Property

    Public Property Discount As Decimal
        Get
            Return discount1
        End Get
        Set(value As Decimal)
            discount1 = value
        End Set
    End Property

    Public Property NatureOfDiscount As String
        Get
            Return natureOfDiscount1
        End Get
        Set(value As String)
            natureOfDiscount1 = value
        End Set
    End Property

    Public Property SubTotal As Decimal
        Get
            Return subTotal1
        End Get
        Set(value As Decimal)
            subTotal1 = value
        End Set
    End Property

    Public Property Tax As List(Of TAX)
        Get
            Return tax1
        End Get
        Set(value As List(Of TAX))
            tax1 = value
        End Set
    End Property

    Public Property TotalLineAmount As Decimal
        Get
            Return totalLineAmount1
        End Get
        Set(value As Decimal)
            totalLineAmount1 = value
        End Set
    End Property
End Class
