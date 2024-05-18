using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Charges
{
    [JsonProperty("codigo_cobranca")]
    public string codigocobranca { get; set; }

    [JsonProperty("nome_cobranca")]
    public string nomecobranca { get; set; }

    [JsonProperty("nivel_venda_cobranca")]
    public decimal nivelvendacobranca { get; set; }

    [JsonProperty("aceita_cartao_cobranca")]
    public string aceitacartaocobranca { get; set; }

    [JsonProperty("aceita_boleto_cobranca")]
    public string aceitaboletocobranca { get; set; }

    [JsonProperty("valor_minimo_cobranca")]
    public decimal valorminimocobranca { get; set; }

    [JsonProperty("codigo_unidade")]
    public string codigounidade { get; set; }

    [JsonProperty("usa_tabela_especial")]
    public string usatabelaespecial { get; set; }
}
