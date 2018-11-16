Imports WindowsApp4


Public Class Respuesta



    Dim codificacion1 As Codificacion
    Dim status1 As String
    Dim message1 As String

    Public Property Codificacion As Codificacion
        Get
            Return codificacion1
        End Get
        Set(value As Codificacion)
            codificacion1 = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return status1
        End Get
        Set(value As String)
            status1 = value
        End Set
    End Property

    Public Property Message As String
        Get
            Return message1
        End Get
        Set(value As String)
            message1 = value
        End Set
    End Property
End Class
