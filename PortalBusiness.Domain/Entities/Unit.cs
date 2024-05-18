using System.Text.Json.Serialization;

namespace PortalBusiness.Domain.Entities;

public class Unit
{
    [JsonPropertyName("codigo_unidade")]
    public string codigo_unidade { get; set; }

    [JsonPropertyName("razao_social_unidade")]
    public string razao_social_unidade { get; set; }

    [JsonPropertyName("cpnj_unidade")]
    public string cpnj_unidade { get; set; }

    [JsonPropertyName("inscricao_estadual_unidade")]
    public string inscricao_estadual_unidade { get; set; }

    [JsonPropertyName("endereco_unidade")]
    public string endereco_unidade { get; set; }

    [JsonPropertyName("bairro_unidade")]
    public string bairro_unidade { get; set; }

    [JsonPropertyName("cidade_unidade")]
    public string cidade_unidade { get; set; }

    [JsonPropertyName("uf_unidade")]
    public string uf_unidade { get; set; }

    [JsonPropertyName("cep_unidade")]
    public string cep_unidade { get; set; }

    [JsonPropertyName("telefone_unidade")]
    public string telefone_unidade { get; set; }

    [JsonPropertyName("fax_unidade")]
    public string fax_unidade { get; set; }

    [JsonPropertyName("cod_cli_unidade")]
    public string cod_cli_unidade { get; set; }

    [JsonPropertyName("usa_wms_unidade")]
    public string usa_wms_unidade { get; set; }

    [JsonPropertyName("logo_empresa")]
    public byte[] logo_empresa { get; set; }
}
