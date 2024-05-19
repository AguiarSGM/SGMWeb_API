using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Client
{
    [JsonProperty("client_code")]
    public int codigocliente { get; set; }

    [JsonProperty("client_business_name")]
    public string razaosocialcliente { get; set; }

    [JsonProperty("client_fantasy_name")]
    public string fantasiacliente { get; set; }

    [JsonProperty("client_cnpj")]
    public string cnpjcliente { get; set; }

    [JsonProperty("limit_balance")]
    public decimal limitecreditocliente { get; set; }

    [JsonProperty("debit")]
    public int debitocliente { get; set; } = 0;

    [JsonProperty("client_block")]
    public string bloqueiocliente { get; set; }

    [JsonProperty("sefaz_block")]
    public string bloqueadosefazcliente { get; set; }

    [JsonProperty("client_uf")]
    public string cliente_uf { get; set; }

    [JsonProperty("client_cidade")]
    public string client_cidade { get; set; }

    [JsonProperty("client_bairro")]
    public string client_bairro { get; set; }

    [JsonProperty("bloqueio_definitivo")]
    public string bloqueio_definitivo { get; set; }

    [JsonProperty("dataultimopedido")]
    public string dataultimopedido { get; set; }
    
}
