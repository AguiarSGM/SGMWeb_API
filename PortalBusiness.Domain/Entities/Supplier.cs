using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Supplier
{
    [JsonProperty("codigo")]
    public int codigo { get; set; }

    [JsonProperty("razao_social")]
    public string razaosocial { get; set; }

    [JsonProperty("fantasia")]
    public string fantasia { get; set; }
}
