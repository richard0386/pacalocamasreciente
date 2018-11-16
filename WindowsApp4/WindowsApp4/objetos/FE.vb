Imports WindowsApp4

Public Class FE


    Dim companyAPI1 As String

    Dim key1 As KEY
    Dim header1 As HEADER

    Dim receiver1 As RECEIVER

    Dim detail1 As List(Of DETAIL)

    Dim summary1 As SUMMARY

    Dim reference1 As REFERENCE

    Dim other1 As OTHER

    Public Property CompanyAPI As String
        Get
            Return companyAPI1
        End Get
        Set(value As String)
            companyAPI1 = value
        End Set
    End Property

    Public Property Key As KEY
        Get
            Return key1
        End Get
        Set(value As KEY)
            key1 = value
        End Set
    End Property

    Public Property Header As HEADER
        Get
            Return header1
        End Get
        Set(value As HEADER)
            header1 = value
        End Set
    End Property

    Public Property Receiver As RECEIVER
        Get
            Return receiver1
        End Get
        Set(value As RECEIVER)
            receiver1 = value
        End Set
    End Property

    Public Property Detail As List(Of DETAIL)
        Get
            Return detail1
        End Get
        Set(value As List(Of DETAIL))
            detail1 = value
        End Set
    End Property

    Public Property Summary As SUMMARY
        Get
            Return summary1
        End Get
        Set(value As SUMMARY)
            summary1 = value
        End Set
    End Property

    Public Property Reference As REFERENCE
        Get
            Return reference1
        End Get
        Set(value As REFERENCE)
            reference1 = value
        End Set
    End Property

    Public Property Other As OTHER
        Get
            Return other1
        End Get
        Set(value As OTHER)
            other1 = value
        End Set
    End Property
End Class
