using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class ItemIn
{
    [JsonProperty("codigo_pedido_rca")]
    public double CodigoPedidoRca { get; set; }

    [JsonProperty("codigo_rca")]
    public double CodigoRca { get; set; }

    [JsonProperty("data_hora_abertura_pedido")]
    public DateTime DataHoraAberturaPedido { get; set; }

    [JsonProperty("item")]
    public double Item { get; set; }

    [JsonProperty("codigo_produto")]
    public double CodigoProduto { get; set; }

    [JsonProperty("descricao_produto")]
    public string DescricaoProduto { get; set; }

    [JsonProperty("quantidade")]
    public double Quantidade { get; set; }

    [JsonProperty("preco_venda_original")]
    public double PrecoVendaOriginal { get; set; }

    [JsonProperty("preco_venda")]
    public double PrecoVenda { get; set; }

    [JsonProperty("codigo_barras")]
    public string CodigoBarras { get; set; }

    [JsonProperty("quantidade_faturada")]
    public double? QuantidadeFaturada { get; set; }

    [JsonProperty("bonificacao")]
    public string Bonificacao { get; set; }

    [JsonProperty("codigo_combo")]
    public double? CodigoCombo { get; set; }

    [JsonProperty("corte")]
    public string Corte { get; set; }

    [JsonProperty("percentual_desconto")]
    public double? PercentualDesconto { get; set; }

    [JsonProperty("percnetual_desconto_boleto")]
    public double? PercnetualDescontoBoleto { get; set; }

    [JsonProperty("sugestao")]
    public string Sugestao { get; set; }

    [JsonProperty("codigo_pedido")]
    public double? CodigoPedido { get; set; }

    [JsonProperty("preco_venda_desconto")]
    public double PrecoVendaDesconto { get; set; }

    [JsonProperty("valor_total")]
    public double ValorTotal { get; set; }

    [JsonProperty("valor_total_com_imposto")]
    public double ValorTotalComImposto { get; set; }

    [JsonProperty("codigo_desconto3306")]
    public string CodigoDesconto3306 { get; set; }

    [JsonProperty("descricao_desconto3306")]
    public string DescricaoDesconto3306 { get; set; }

    [JsonProperty("codigo_produto_principal")]
    public string CodigoProdutoPrincipal { get; set; }

    [JsonProperty("observacao_retorno")]
    public string ObservacaoRetorno { get; set; }

    [JsonProperty("codigo_unidade_retirada")]
    public string CodigoUnidadeRetirada { get; set; }

    [JsonProperty("tipo_entrega")]
    public string TipoEntrega { get; set; }

    [JsonProperty("codigo_desconto561")]
    public string CodigoDesconto561 { get; set; }

    [JsonProperty("diferenca_preco")]
    public double? DiferencaPreco { get; set; }

    [JsonProperty("saldo_verba")]
    public double? SaldoVerba { get; set; }

    [JsonProperty("base_cred_deb_rca_descont561")]
    public string BaseCredDebRcaDescont561 { get; set; }

    [JsonProperty("aplica_automatico_desconto561")]
    public string AplicaAutomaticoDesconto561 { get; set; }

    [JsonProperty("percentual_desconto561")]
    public double? PercentualDesconto561 { get; set; }

    [JsonProperty("codigo_auxiliar_embalagem")]
    public string CodigoAuxiliarEmbalagem { get; set; }

    [JsonProperty("quantidade_unitaria_embalagem")]
    public double? QuantidadeUnitariaEmbalagem { get; set; }

    [JsonProperty("utiliza_venda_por_embalagem")]
    public string UtilizaVendaPorEmbalagem { get; set; }

    [JsonProperty("tipo_carga_produto")]
    public string TipoCargaProduto { get; set; }

    [JsonProperty("exibe_combo_embalagem")]
    public string ExibeComboEmbalagem { get; set; }

    [JsonProperty("item_negociado")]
    public string ItemNegociado { get; set; }

    [JsonProperty("unidade_venda")]
    public string UnidadeVenda { get; set; }

    [JsonProperty("tipo_estoque_produto")]
    public string TipoEstoqueProduto { get; set; }

    [JsonProperty("codigo_regiao")]
    public double CodigoRegiao { get; set; }

    [JsonProperty("percentual_acrescimo")]
    public double? PercentualAcrescimo { get; set; }

    [JsonProperty("comissao")]
    public double? Comissao { get; set; }

    [JsonProperty("peso")]
    public double? Peso { get; set; }

    [JsonProperty("valor_st")]
    public double ValorSt { get; set; }

    [JsonProperty("preco_st")]
    public double PrecoSt { get; set; }

    [JsonProperty("valor_total_com_st")]
    public double ValorTotalComSt { get; set; }

    [JsonProperty("numero_carregamento")]
    public double? NumeroCarregamento { get; set; }

    [JsonProperty("percentual_base_red")]
    public double? PercentualBaseRed { get; set; }

    [JsonProperty("percentual_icm")]
    public double? PercentualIcm { get; set; }

    [JsonProperty("data_validade_campanha_shelf")]
    public DateTime? DataValidadeCampanhaShelf { get; set; }

    [JsonProperty("preco_campanha_shelf")]
    public double PrecoCampanhaShelf { get; set; }

    [JsonProperty("codigo_campanha_shelf")]
    public string CodigoCampanhaShelf { get; set; }

    [JsonProperty("unidade_frios")]
    public string UnidadeFrios { get; set; }
}
