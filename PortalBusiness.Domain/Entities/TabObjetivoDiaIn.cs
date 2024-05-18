using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class TabObjetivoDiaIn
{
    
    [JsonProperty("DATA")]
    public DateTime Data { get; set; }

    [JsonProperty("VALORMETA")]
    public decimal ValorMeta { get; set; }

    [JsonProperty("CODIGOSUPERVISOR")]
    public int? CodigoSupervisor { get; set; }

    [JsonProperty("CODIGOUNIDADE")]
    public int? CodigoUnidade { get; set; }
    
}
