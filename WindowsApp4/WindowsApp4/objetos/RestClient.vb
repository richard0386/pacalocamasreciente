Imports System.Net
Imports System.IO


Public Class RestClient : Implements IDisposable



    Public Sub New()
        endpoint = ""
        httpMethod = httpVerb.POST
    End Sub

    Public Enum httpVerb

        POST
        PUT
        DELETE
    End Enum


    Private endpoint As String
    Private httpMethod As httpVerb
    Private request As HttpWebRequest
    Private strResponseValue = ""
    Private response As HttpWebResponse

    Public Property Endpoint1 As String
        Get
            Return endpoint
        End Get
        Set(value As String)
            endpoint = value
        End Set
    End Property

    Public Property HttpMethod1 As httpVerb
        Get
            Return httpMethod
        End Get
        Set(value As httpVerb)
            httpMethod = value
        End Set
    End Property



    Public Function makeRequest(ByVal parametro As String)

        strResponseValue = String.Empty

        request = CType(WebRequest.Create(endpoint), HttpWebRequest)
        request.Timeout = 5000
        request.Method = httpMethod.ToString()
        request.ContentType = "application/json"



        Using payload As New StreamWriter(request.GetRequestStream)
            payload.Write(parametro)
            payload.Close()
        End Using


        response = Nothing

        Try

            response = CType(request.GetResponse(), HttpWebResponse)




            Using responseStream As Stream = response.GetResponseStream

                'Falta validar que responsestream no sea nulo

                Using reader As New StreamReader(responseStream)
                    strResponseValue = reader.ReadToEnd()
                End Using

            End Using

        Catch nueveunouno As Exception
            MessageBox.Show(nueveunouno.Message)
        Catch ex As Exception

            strResponseValue = ex.ToString()


        End Try

        Return strResponseValue

    End Function

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        strResponseValue = Nothing
        request = Nothing
        response = Nothing
    End Sub
End Class
