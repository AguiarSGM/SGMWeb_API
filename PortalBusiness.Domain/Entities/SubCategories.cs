using System.Text.Json.Serialization;

namespace PortalBusiness.Domain.Entities;

public class SubCategories
{
    [JsonPropertyName("codigo_sessao")]
    public double codigosessao { get; set; }

    [JsonPropertyName("codigo_categoria")]
    public double codigocategoria { get; set; }

    [JsonPropertyName("codigo_subcategoria")]
    public double codigosubcategoria { get; set; }

    [JsonPropertyName("descricao_subcategoria")]
    public string descricaosubcategoria { get; set; }
}
