using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Category

{
    [JsonProperty("codigo_sessao")]
    public int codigosessao { get; set; }

    [JsonProperty("codigo_categoria")]
    public int codigocategoria { get; set; }

    [JsonProperty("descricao_categoria")]
    public string descricaocategoria { get; set; }
}
