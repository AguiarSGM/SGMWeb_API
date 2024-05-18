using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Regions
{
    [JsonProperty("codigo_regiao")]
    public int codigoregiao { get; set; }

    [JsonProperty("descricao_regiao")]
    public string descricaoregiao { get; set; }
}
