using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Parameter
{
    [JsonProperty("nome_parametro")]
    public string NOMEPARAMETRO { get; set; }

    [JsonProperty("valor_parametro")]
    public string VALORPARAMETRO { get; set; }
}
