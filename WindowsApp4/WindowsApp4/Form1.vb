Imports Newtonsoft.Json
Imports System.Net
Imports System.IO

Public Class Form1
    Dim detalles As New List(Of DETAIL)
    Dim json As String
    Dim res As New RestClient()
    Dim urlAPI As String
    Dim httpWebRequest As HttpWebRequest
    Dim httpResponse As HttpWebResponse
    Dim result As String
    Dim respuesta As Respuesta



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        crearjson()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub crearjson()
        Dim f As New FE()

        f.CompanyAPI = "e355cf45-d9ae-423d-bace-d58a5f1fdaff"





        Dim key As New KEY()
        key.Branch = "04"
        key.Terminal = "1"
        key.Type = "04"
        key.Voucher = "123456"
        key.Country = "506"
        key.Situation = "1"


        f.Key = key


        Dim header As New HEADER()

        header.Date = DateTime.Now.Date
        header.TermOfSale = "01"
        header.CreditTerm = 0
        header.PaymentMethod = "01"

        f.Header = header



        Dim identification As New IDENTIFICATION()
        identification.Type = "01"
        identification.Number = "000000000"



        Dim receiver As New RECEIVER()

        receiver.Name = "prueba"
        receiver.Identification = identification
        receiver.Email = "correo@correo.com"


        f.Receiver = receiver


        'detalles.Clear();


        Dim losimpuestos As New TAX()
        losimpuestos = Nothing


        Dim code As New CODE()
        code.Type = "01"
        code.Code = "01"


        Dim detail As New DETAIL()

        detail.Number = 1
        detail.Code = code
        'detail.Tax.Add(losimpuestos)

        detail.Tax = New List(Of TAX)
        detail.Tax = Nothing
        detail.Quantity = 1.0
        detail.UnitOfMeasure = "Unid"
        detail.CommercialUnitOfMeasure = Nothing
        detail.Detail = "detalle"
        detail.UnitPrice = 100
        detail.TotalAmount = 100
        detail.Discount = 0
        detail.NatureOfDiscount = ""
        detail.SubTotal = 100
        detail.TotalLineAmount = 100

        f.Detail = New List(Of DETAIL)
        f.Detail.Add(detail)



        f.Reference = Nothing

        Dim summary As New SUMMARY


        summary.Currency = "CRC"
        summary.ExchangeRate = 1.0
        summary.TotalTaxedService = 0
        summary.TotalExemptService = 0
        summary.TotalTaxedGoods = 0
        summary.TotalExemptGoods = 100
        summary.TotalTaxed = 0
        summary.TotalExempt = 100
        summary.TotalSale = 100
        summary.TotalDiscounts = 0
        summary.TotalNetSale = 100
        summary.TotalTaxes = 0
        summary.TotalVoucher = 100


        f.Summary = summary


        json = JsonConvert.SerializeObject(f, Newtonsoft.Json.Formatting.Indented)

        res.Endpoint1 = "http://104.43.136.13:8080/api/invoice/"


        Dim strJSON As String = String.Empty


        SendInvoicesAGC(f)


        'strJSON = res.makeRequest(json)

        'debug2(strJSON)
        RichTextBox1.Text = ""
        RichTextBox1.Text = json



    End Sub

    'Private Sub debug2(str As String)
    '    Dim response As Object
    '    'response = JsonConvert.DeserializeObject(Of Object)(str)
    '    response = JsonConvert.DeserializeObject(Of Object)(str)
    '    MessageBox.Show(response.ToString)
    'End Sub
    Public Function SendInvoicesAGC(factura As FE) As Respuesta
        Try

            urlAPI = "http://104.43.136.13:8080/api/invoice/"
            httpWebRequest = CType(WebRequest.Create(urlAPI), HttpWebRequest)
            httpWebRequest.ContentType = "application/json"
            httpWebRequest.Method = "POST"


            Using streamWriter As New StreamWriter(httpWebRequest.GetRequestStream)

                json = JsonConvert.SerializeObject(factura, Formatting.Indented)
                streamWriter.WriteAsync(json)

            End Using


            httpResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)

            Using streamReader As New StreamReader(httpResponse.GetResponseStream())

                result = streamReader.ReadToEnd()

            End Using

            respuesta = JsonConvert.DeserializeObject(Of Respuesta)(result)
            MessageBox.Show(result)
        Catch estad As WebException
            MessageBox.Show("Estado= " +
                            estad.Status + "   Mensaje= " +
                            estad.Message)
        Catch estado As Exception
            MessageBox.Show(estado.Message)
        End Try

        Return respuesta
    End Function




End Class
