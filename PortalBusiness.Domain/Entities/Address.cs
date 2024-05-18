using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Address
{
    [JsonProperty("codigo_endereco")]
    public long codigoendereco { get; set; }

    [JsonProperty("endereco_entrega_cliente")]
    public string enderecoentregacliente { get; set; }

    [JsonProperty("numero_entrega_cliente")]
    public string numeroentregacliente { get; set; }

    [JsonProperty("bairro_entrega_cliente")]
    public string bairroentregacliente { get; set; }

    [JsonProperty("cidade_entrega_cliente")]
    public string cidadeentregacliente { get; set; }

    [JsonProperty("uf_entrega_cliente")]
    public string ufentregacliente { get; set; }

    [JsonProperty("cep_entrega_cliente")]
    public string cepentregacliente { get; set; }

    [JsonProperty("telefone_entrega_cliente")]
    public string telefoneentregacliente { get; set; }

    [JsonProperty("observacao_entrega_cliente")]
    public string observacaoentregacliente { get; set; }
}
