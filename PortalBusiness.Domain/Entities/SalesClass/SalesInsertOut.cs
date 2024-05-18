using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class SalesInsertOut
{
    [JsonProperty("Licenca")]
    public string Licenca { get; set; }

    [JsonProperty("CodigoPedidoRCA")]
    public double CodigoPedidoRca { get; set; }

    [JsonProperty("CodigoRCA")]
    public double CodigoRca { get; set; }

    [JsonProperty("DataHoraAbertura")]
    public DateTime DataHoraAberturaPedido { get; set; }
}
