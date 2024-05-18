using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.Products;

public class ProductsValidateOut
{
    [JsonProperty("codigo_campanha_shelf")]
    public string CodigoCampanha { get; set; }

    [JsonProperty("data_validade")]
    public DateTime DataValidade { get; set; }

    [JsonProperty("estoque")]
    public int Estoque { get; set; }

    [JsonProperty("preco_promocional")]
    public decimal PrecoPromocional { get; set; }

    [JsonProperty("data_fabricacao")]
    public DateTime DataFabricacao { get; set; }

    [JsonProperty("dias_validade")]
    public int DiasValidade { get; set; }
}
