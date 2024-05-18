using Newtonsoft.Json;

namespace PortalBusiness.Application.DTOs;

public class ClientOutDTO
{
    [JsonProperty("client_code")]
    public int ClientCode { get; set; }

    [JsonProperty("client_business_name")]
    public string ClientBusinessName { get; set; }

    [JsonProperty("client_fantasy_name")]
    public string ClientFantasyName { get; set; }

    [JsonProperty("client_cnpj")]
    public string ClientCNPJ { get; set; }

    [JsonProperty("limit_balance")]
    public decimal LimitBalance { get; set; }

    [JsonProperty("debit")]
    public string Debit { get; set; }

    [JsonProperty("client_block")]
    public string ClientBlock { get; set; }

    [JsonProperty("sefaz_block")]
    public string SEFAZBlock { get; set; }
}
