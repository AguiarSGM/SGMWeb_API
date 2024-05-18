using System.Text.Json.Serialization;

namespace PortalBusiness.Domain.Entities;

public class SalesOrderItem
{
    [JsonPropertyName("codigo_pedido_rca")]
    public int codigo_pedido_rca { get; set; }

    [JsonPropertyName("codigo_rca")]
    public int codigo_rca { get; set; }

    [JsonPropertyName("data_hora_abertura_pedido")]
    public DateTime data_hora_abertura_pedido { get; set; }

    [JsonPropertyName("item")]
    public int Item { get; set; }

    [JsonPropertyName("codigo_produto")]
    public string codigo_produto { get; set; } = string.Empty;

    [JsonPropertyName("descricao_produto")]
    public string descricao_produto { get; set; } = string.Empty;

    [JsonPropertyName("quantidade")]
    public decimal quantidade { get; set; }

    [JsonPropertyName("preco_venda_original")]
    public decimal preco_venda_original { get; set; }

    [JsonPropertyName("preco_venda")]
    public decimal preco_venda { get; set; }

    [JsonPropertyName("codigo_barras")]
    public string codigo_barras { get; set; } = string.Empty;

    [JsonPropertyName("quantidade_faturada")]
    public decimal quantidade_faturada { get; set; }

    [JsonPropertyName("bonificacao")]
    public string bonificacao { get; set; } = string.Empty;

    [JsonPropertyName("codigo_combo")]
    public int codigo_combo { get; set; }

    [JsonPropertyName("corte")]
    public string corte { get; set; } = string.Empty;

    [JsonPropertyName("percentual_desconto")]
    public decimal percentual_desconto { get; set; }

    [JsonPropertyName("percnetual_desconto_boleto")]
    public decimal percnetual_desconto_boleto { get; set; }

    [JsonPropertyName("sugestao")]
    public string sugestao { get; set; } = string.Empty;

    [JsonPropertyName("codigo_pedido")]
    public int codigo_pedido { get; set; }

    [JsonPropertyName("preco_venda_desconto")]
    public decimal preco_venda_desconto { get; set; }

    [JsonPropertyName("valor_total")]
    public decimal valor_total { get; set; }

    [JsonPropertyName("valor_total_com_imposto")]
    public decimal valor_total_com_imposto { get; set; }

    [JsonPropertyName("codigo_desconto3306")]
    public string codigo_desconto3306 { get; set; } = string.Empty;

    [JsonPropertyName("descricao_desconto3306")]
    public string descricao_desconto3306 { get; set; } = string.Empty;

    [JsonPropertyName("codigo_produto_principal")]
    public string codigo_produto_principal { get; set; } = string.Empty;

    [JsonPropertyName("observacao_retorno")]
    public string observacao_retorno { get; set; } = string.Empty;

    [JsonPropertyName("codigo_unidade_retirada")]
    public string codigo_unidade_retirada { get; set; } = string.Empty;

    [JsonPropertyName("tipo_entrega")]
    public string tipo_entrega { get; set; } = string.Empty;

    [JsonPropertyName("codigo_desconto561")]
    public string codigo_desconto561 { get; set; }

    [JsonPropertyName("diferenca_preco")]
    public decimal diferenca_preco { get; set; }

    [JsonPropertyName("saldo_verba")]
    public decimal saldo_verba { get; set; }

    [JsonPropertyName("base_cred_deb_rca_descont561")]
    public string base_cred_deb_rca_descont561 { get; set; } = string.Empty;

    [JsonPropertyName("aplica_automatico_desconto561")]
    public string aplica_automatico_desconto561 { get; set; } = string.Empty;

    [JsonPropertyName("percentual_desconto561")]
    public decimal percentual_desconto561 { get; set; }

    [JsonPropertyName("codigo_auxiliar_embalagem")]
    public string codigo_auxiliar_embalagem { get; set; }

    [JsonPropertyName("quantidade_unitaria_embalagem")]
    public decimal quantidade_unitaria_embalagem { get; set; }

    [JsonPropertyName("utiliza_venda_por_embalagem")]
    public string utiliza_venda_por_embalagem { get; set; } = string.Empty;

    [JsonPropertyName("tipo_carga_produto")]
    public string tipo_carga_produto { get; set; } = string.Empty;

    [JsonPropertyName("exibe_combo_embalagem")]
    public string exibe_combo_embalagem { get; set; } = string.Empty;

    [JsonPropertyName("item_negociado")]
    public string item_negociado { get; set; } = string.Empty;

    [JsonPropertyName("unidade_venda")]
    public string unidade_venda { get; set; } = string.Empty;

    [JsonPropertyName("tipo_estoque_produto")]
    public string tipo_estoque_produto { get; set; } = string.Empty;

    [JsonPropertyName("codigo_regiao")]
    public int codigo_regiao { get; set; }

    [JsonPropertyName("percentual_acrescimo")]
    public decimal percentual_acrescimo { get; set; }

    [JsonPropertyName("comissao")]
    public decimal comissao { get; set; }

    [JsonPropertyName("peso")]
    public decimal peso { get; set; }

    [JsonPropertyName("valor_st")]
    public decimal valor_st { get; set; }

    [JsonPropertyName("preco_st")]
    public decimal preco_st { get; set; }

    [JsonPropertyName("valor_total_com_st")]
    public decimal valor_total_com_st { get; set; }

    [JsonPropertyName("numero_carregamento")]
    public decimal numero_carregamento { get; set; }

    [JsonPropertyName("percentual_base_red")]
    public decimal percentual_base_red { get; set; }

    [JsonPropertyName("percentual_icm")]
    public decimal percentual_icm { get; set; }

    [JsonPropertyName("data_validade_campanha_shelf")]
    public string data_validade_campanha_shelf { get; set; } = string.Empty;

    [JsonPropertyName("preco_campanha_shelf")]
    public decimal preco_campanha_shelf { get; set; }

    [JsonPropertyName("codigo_campanha_shelf")]
    public string codigo_campanha_shelf { get; set; } = string.Empty;

    [JsonPropertyName("unidade_frios")]
    public string unidade_frios { get; set; } = string.Empty;
}
