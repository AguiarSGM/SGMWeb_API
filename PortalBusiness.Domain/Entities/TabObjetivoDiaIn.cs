using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class TabObjetivoDiaIn
{

    private DateTime _data;

    [JsonProperty("DATA")]
    public DateTime Data
    {
        get { return _data.Date; }
        set { _data = value.Date; }
    }

    [JsonProperty("VALORMETA")]
    public decimal ValorMeta { get; set; }

    [JsonProperty("CODIGOSUPERVISOR")]
    public int? CodigoSupervisor { get; set; }

    [JsonProperty("CODIGOUNIDADE")]
    public int? CodigoUnidade { get; set; }
    
}
