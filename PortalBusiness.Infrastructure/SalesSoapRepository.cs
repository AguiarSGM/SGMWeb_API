using PortalBusiness.Domain.Entities;
using System.Text;
using System.Xml.Serialization;

namespace PortalBusiness.Infrastructure;

public static class SalesSoapRepository
{
    public static async Task<string> RulesSalesSoap(int codigoPedidoRCA, int codigoRCA, string dataHoraAbertura)
    {
        HttpClient httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromMilliseconds(100500)
        };

        string soapRequest =
            $@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"">
                <soapenv:Header/>
                <soapenv:Body>
                    <tem:ProcessarPedidosTabela>
                        <tem:jsonProcessarPedidoCommand>{{""Licenca"":""2023DELLYS"",""Pedidos"":[{{""CodigoPedidoRCA"":{codigoPedidoRCA},""CodigoRCA"":{codigoRCA},""DataHoraAbertura"":""{dataHoraAbertura}""}}]}}</tem:jsonProcessarPedidoCommand>
                    </tem:ProcessarPedidosTabela>
                </soapenv:Body>
            </soapenv:Envelope>";

        HttpRequestMessage request = new HttpRequestMessage
        {
            RequestUri = new Uri("http://10.100.71.24:8975/WebService/SGMBusiness.asmx"),
            Method = HttpMethod.Post,
            Content = new StringContent(soapRequest, Encoding.UTF8, "text/xml")
        };
        request.Headers.Add("SOAPAction", "http://tempuri.org/ProcessarPedidosTabela");

        HttpResponseMessage response = await httpClient.SendAsync(request);


        if (response.IsSuccessStatusCode)
        {
            string soapResponse = await response.Content.ReadAsStringAsync();

            ProcessarPedidosTabelaResponseBody envelope;
            using (TextReader reader = new StringReader(soapResponse))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ProcessarPedidosTabelaResponseBody));
                //envelope = (ProcessarPedidosTabelaResponseBody)serializer.Deserialize(reader);
            }

            return "";
        }
        else
        {
            throw new Exception($"Failed to call the SOAP service. StatusCode: {response.StatusCode}");
        }
    }
}
