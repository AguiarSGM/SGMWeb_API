using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Brand
{
    [JsonProperty("codigo_marca_produto")]
    public int codigomarcaproduto { get; set; }

    [JsonProperty("descricao_marca_produto")]
    public string descricaomarcaproduto { get; set; }
}
