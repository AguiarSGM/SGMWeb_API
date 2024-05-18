using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class TabPedidoItens
{
    [JsonProperty("codigo_pedido_rca")]
    public int CodigoPedidoRca { get; set; }

    [JsonProperty("codigo_rca")]
    public int CodigoRca { get; set; }

    [JsonProperty("data_hora_abertura_pedido")]
    public DateTime DataHoraAberturaPedido { get; set; }

    [JsonProperty("item")]
    public int Item { get; set; }

    [JsonProperty("codigo_produto")]
    public string? CodigoProduto { get; set; }

    [JsonProperty("descricao_produto")]
    public string? DescricaoProduto { get; set; }

    [JsonProperty("quantidade")]
    public decimal Quantidade { get; set; }

    [JsonProperty("preco_venda_original")]
    public decimal PrecoVendaOriginal { get; set; }

    [JsonProperty("preco_venda")]
    public decimal PrecoVenda { get; set; }

    [JsonProperty("codigo_barras")]
    public string? CodigoBarras { get; set; }

    [JsonProperty("quantidade_faturada")]
    public decimal QuantidadeFaturada { get; set; }

    [JsonProperty("bonificacao")]
    public string? Bonificacao { get; set; }

    [JsonProperty("codigo_combo")]
    public int? CodigoCombo { get; set; }

    [JsonProperty("corte")]
    public string? Corte { get; set; }

    [JsonProperty("percentual_desconto")]
    public decimal PercentualDesconto { get; set; }

    [JsonProperty("percentual_desconto_boleto")]
    public decimal PercentualDescontoBoleto { get; set; }

    [JsonProperty("sugestao")]
    public string? Sugestao { get; set; }

    [JsonProperty("codigo_pedido")]
    public int CodigoPedido { get; set; }

    [JsonProperty("preco_venda_desconto")]
    public decimal PrecoVendaDesconto { get; set; }

    [JsonProperty("valor_total")]
    public decimal ValorTotal { get; set; }

    [JsonProperty("valor_total_com_imposto")]
    public decimal ValorTotalComImposto { get; set; }

    [JsonProperty("codigo_desconto_3306")]
    public string? CodigoDesconto3306 { get; set; }

    [JsonProperty("descricao_desconto_3306")]
    public string? DescricaoDesconto3306 { get; set; }

    [JsonProperty("codigo_produto_principal")]
    public string? CodigoProdutoPrincipal { get; set; }

    [JsonProperty("observacao_retorno")]
    public string? ObservacaoRetorno { get; set; }

    [JsonProperty("codigo_unidade_retira")]
    public string? CodigoUnidadeRetira { get; set; }

    [JsonProperty("tipo_entrega")]
    public string? TipoEntrega { get; set; }

    [JsonProperty("codigo_desconto_561")]
    public string? CodigoDesconto561 { get; set; }

    [JsonProperty("diferenca_preco")]
    public decimal DiferencaPreco { get; set; }

    [JsonProperty("saldo_verba")]
    public decimal SaldoVerba { get; set; }

    [JsonProperty("base_cred_deb_rca_desconto_561")]
    public string? BaseCredDebRcaDesconto561 { get; set; }

    [JsonProperty("aplica_automatico_desconto_561")]
    public string? AplicaAutomaticoDesconto561 { get; set; }

    [JsonProperty("percentual_desconto_561")]
    public decimal PercentualDesconto561 { get; set; }

    [JsonProperty("codigo_auxiliar_embalagem")]
    public string? CodigoAuxiliarEmbalagem { get; set; }

    [JsonProperty("quantidade_unitaria_embalagem")]
    public decimal QuantidadeUnitariaEmbalagem { get; set; }

    [JsonProperty("utiliza_venda_por_embalagem")]
    public string? UtilizaVendaPorEmbalagem { get; set; }

    [JsonProperty("tipo_carga_produto")]
    public string? TipoCargaProduto { get; set; }

    [JsonProperty("exibe_combo_embalagem")]
    public string? ExibeComboEmbalagem { get; set; }

    [JsonProperty("item_negociado")]
    public string? ItemNegociado { get; set; }

    [JsonProperty("unidade_venda")]
    public string? UnidadeVenda { get; set; }

    [JsonProperty("tipo_estoque_produto")]
    public string? TipoEstoqueProduto { get; set; }

    [JsonProperty("codigo_regiao")]
    public int CodigoRegiao { get; set; }

    [JsonProperty("percentual_acrescimo")]
    public decimal PercentualAcrescimo { get; set; }

    [JsonProperty("comissao")]
    public decimal Comissao { get; set; }

    [JsonProperty("peso")]
    public decimal Peso { get; set; }

    [JsonProperty("valor_st")]
    public decimal ValorST { get; set; }

    [JsonProperty("preco_com_st")]
    public decimal PrecoComST { get; set; }

    [JsonProperty("valor_total_com_st")]
    public decimal valortotalcomst { get; set; }

    [JsonProperty("numero_carregamento")]
    public int NumeroCarregamento { get; set; }

    [JsonProperty("percentual_base_red")]
    public decimal PercentualBaseRed { get; set; }

    [JsonProperty("percentual_icm")]
    public decimal PercentualICM { get; set; }

    [JsonProperty("data_validade_campanha_shelf")]
    public DateTime DataValidadeCampanhaShelf { get; set; }

    [JsonProperty("preco_campanha_shelf")]
    public decimal PrecoCampanhaShelf { get; set; }

    [JsonProperty("codigo_campanha_shelf")]
    public string? CodigoCampanhaShelf { get; set; }

    [JsonProperty("unidade_frios")]
    public string? UnidadeFrios { get; set; }
    public TabPedido? Pedido { get; set; }
}
