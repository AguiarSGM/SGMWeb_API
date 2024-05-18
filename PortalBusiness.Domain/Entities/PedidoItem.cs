using System.Text.Json.Serialization;

namespace PortalBusiness.Domain.Entities;

public class PedidoItem
{
    [JsonPropertyName("codigo_pedido_rca")]
    public double CodigoPedidoRca { get; set; }

    [JsonPropertyName("codigo_rca")]
    public double CodigoRca { get; set; }

    [JsonPropertyName("data_hora_abertura_pedido")]
    public DateTime DataHoraAberturaPedido { get; set; }

    [JsonPropertyName("item")]
    public double Item { get; set; }

    [JsonPropertyName("codigo_produto")]
    public string CodigoProduto { get; set; }

    [JsonPropertyName("descricao_produto")]
    public string DescricaoProduto { get; set; }

    [JsonPropertyName("quantidade")]
    public double Quantidade { get; set; }

    [JsonPropertyName("preco_venda_original")]
    public double PrecoVendaOriginal { get; set; }

    [JsonPropertyName("preco_venda")]
    public double PrecoVenda { get; set; }

    [JsonPropertyName("codigo_barras")]
    public string CodigoBarras { get; set; }

    [JsonPropertyName("quantidade_faturada")]
    public double QuantidadeFaturada { get; set; }

    [JsonPropertyName("bonificacao")]
    public string Bonificacao { get; set; }

    [JsonPropertyName("codigo_combo")]
    public double CodigoCombo { get; set; }

    [JsonPropertyName("corte")]
    public string Corte { get; set; }

    [JsonPropertyName("percentual_desconto")]
    public double PercentualDesconto { get; set; }

    [JsonPropertyName("percnetual_desconto_boleto")]
    public double PercnetualDescontoBoleto { get; set; }

    [JsonPropertyName("sugestao")]
    public string Sugestao { get; set; }

    [JsonPropertyName("codigo_pedido")]
    public double CodigoPedido { get; set; }

    [JsonPropertyName("preco_venda_desconto")]
    public double PrecoVendaDesconto { get; set; }

    [JsonPropertyName("valor_total")]
    public double ValorTotal { get; set; }

    [JsonPropertyName("valor_total_com_imposto")]
    public double ValorTotalComImposto { get; set; }

    [JsonPropertyName("codigo_desconto3306")]
    public string CodigoDesconto3306 { get; set; }

    [JsonPropertyName("descricao_desconto3306")]
    public string DescricaoDesconto3306 { get; set; }

    [JsonPropertyName("codigo_produto_principal")]
    public string CodigoProdutoPrincipal { get; set; }

    [JsonPropertyName("observacao_retorno")]
    public string ObservacaoRetorno { get; set; }

    [JsonPropertyName("codigo_unidade_retirada")]
    public string CodigoUnidadeRetirada { get; set; }

    [JsonPropertyName("tipo_entrega")]
    public string TipoEntrega { get; set; }

    [JsonPropertyName("codigo_desconto561")]
    public string CodigoDesconto561 { get; set; }

    [JsonPropertyName("diferenca_preco")]
    public double DiferencaPreco { get; set; }

    [JsonPropertyName("saldo_verba")]
    public double SaldoVerba { get; set; }

    [JsonPropertyName("base_cred_deb_rca_descont561")]
    public string BaseCredDebRcaDescont561 { get; set; }

    [JsonPropertyName("aplica_automatico_desconto561")]
    public string AplicaAutomaticoDesconto561 { get; set; }

    [JsonPropertyName("percentual_desconto561")]
    public double PercentualDesconto561 { get; set; }

    [JsonPropertyName("codigo_auxiliar_embalagem")]
    public string CodigoAuxiliarEmbalagem { get; set; }

    [JsonPropertyName("quantidade_unitaria_embalagem")]
    public double QuantidadeUnitariaEmbalagem { get; set; }

    [JsonPropertyName("utiliza_venda_por_embalagem")]
    public string UtilizaVendaPorEmbalagem { get; set; }

    [JsonPropertyName("tipo_carga_produto")]
    public string TipoCargaProduto { get; set; }

    [JsonPropertyName("exibe_combo_embalagem")]
    public string ExibeComboEmbalagem { get; set; }

    [JsonPropertyName("item_negociado")]
    public string ItemNegociado { get; set; }

    [JsonPropertyName("unidade_venda")]
    public string UnidadeVenda { get; set; }

    [JsonPropertyName("tipo_estoque_produto")]
    public string TipoEstoqueProduto { get; set; }

    [JsonPropertyName("codigo_regiao")]
    public double CodigoRegiao { get; set; }

    [JsonPropertyName("percentual_acrescimo")]
    public double PercentualAcrescimo { get; set; }

    [JsonPropertyName("comissao")]
    public double Comissao { get; set; }

    [JsonPropertyName("peso")]
    public double Peso { get; set; }

    [JsonPropertyName("valor_st")]
    public double ValorSt { get; set; }

    [JsonPropertyName("preco_st")]
    public double PrecoSt { get; set; }

    [JsonPropertyName("valor_total_com_st")]
    public double ValorTotalComSt { get; set; }

    [JsonPropertyName("numero_carregamento")]
    public double NumeroCarregamento { get; set; }

    [JsonPropertyName("percentual_base_red")]
    public double PercentualBaseRed { get; set; }

    [JsonPropertyName("percentual_icm")]
    public double PercentualIcm { get; set; }

    [JsonPropertyName("data_validade_campanha_shelf")]
    public DateTime DataValidadeCampanhaShelf { get; set; } = DateTime.MinValue;

    [JsonPropertyName("preco_campanha_shelf")]
    public double PrecoCampanhaShelf { get; set; }

    [JsonPropertyName("codigo_campanha_shelf")]
    public string CodigoCampanhaShelf { get; set; }

    [JsonPropertyName("unidade_frios")]
    public string UnidadeFrios { get; set; }
}
