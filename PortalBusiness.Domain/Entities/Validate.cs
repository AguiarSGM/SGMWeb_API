using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Validate
{
    [JsonProperty("data_validade")]
    public DateTime ValidateDate { get; set; }

    [JsonProperty("estoque")]
    public double Stock { get; set; }

    [JsonProperty("preco_promocional")]
    public double PromotionalPrice { get; set; }
}
