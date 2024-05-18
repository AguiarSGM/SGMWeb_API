using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class TabObjetivoDiaOut
{
    
    [JsonProperty("DATA")]
    public DateTime Data { get; set; }

    [JsonProperty("VALORMETA")]
    public decimal ValorMeta { get; set; }

    [JsonProperty("VALORVENDIDO")]
    public decimal ValorVendido { get; set; }
    
}
