using System.Text.Json.Serialization;

namespace PortalBusiness.Domain.Entities;

public class Sections
{
    [JsonPropertyName("codigo_departamento")]
    public double codigodepartamento { get; set; }

    [JsonPropertyName("codigo_secao")]
    public double codigosecao { get; set; }

    [JsonPropertyName("descricao_secao")]
    public string descricaosecao { get; set; }
}
