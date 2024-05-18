using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class DadosComerciais
{
    [JsonProperty("precoTabela")]
    public decimal precoTabela { get; set; }

    [JsonProperty("precoSemImposto")]
    public decimal precoSemImposto { get; set; }

    [JsonProperty("precoMaximo")]
    public decimal precoMaximo { get; set; }

    [JsonProperty("precoMinimo")]
    public decimal precoMinimo { get; set; }

    [JsonProperty("percentualDescontoFlexivel")]
    public decimal percentualDescontoFlexivel { get; set; }

    [JsonProperty("percentualDescontoAutomatico")]
    public decimal percentualDescontoAutomatico { get; set; }

    [JsonProperty("percentualAcrescimoMaximo")]
    public decimal percentualAcrescimoMaximo { get; set; }
}
