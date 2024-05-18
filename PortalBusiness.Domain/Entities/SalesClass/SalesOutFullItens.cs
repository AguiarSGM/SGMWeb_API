using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class SalesOutFullItens
{
    [JsonProperty("codigo_pedido_rca")]
    public double codigopedidorca { get; set; }

    [JsonProperty("codigo_rca")]
    public double codigorca { get; set; }

    [JsonProperty("data_hora_abertura_pedido")]
    public DateTime datahoraaberturapedido { get; set; }

    [JsonProperty("item")]
    public double item { get; set; }

    [JsonProperty("codigo_produto")]
    public double codigoproduto { get; set; }

    [JsonProperty("descricao_produto")]
    public string descricaoproduto { get; set; }

    [JsonProperty("quantidade")]
    public double quantidade { get; set; }

    [JsonProperty("preco_venda_original")]
    public double precovendaoriginal { get; set; }

    [JsonProperty("preco_venda")]
    public double precovenda { get; set; }

    [JsonProperty("codigo_barras")]
    public string codigobarras { get; set; }

    [JsonProperty("quantidade_faturada")]
    public double quantidadefaturada { get; set; }

    [JsonProperty("bonificacao")]
    public string bonificacao { get; set; }

    [JsonProperty("codigo_combo")]
    public double codigocombo { get; set; }

    [JsonProperty("corte")]
    public string corte { get; set; }

    [JsonProperty("percentual_desconto")]
    public double percentualdesconto { get; set; }

    [JsonProperty("percnetual_desconto_boleto")]
    public double percentualdescontoboleto { get; set; }

    [JsonProperty("sugestao")]
    public string sugestao { get; set; }

    [JsonProperty("codigo_pedido")]
    public double codigopedido { get; set; }

    [JsonProperty("preco_venda_desconto")]
    public double precovendadesconto { get; set; }

    [JsonProperty("valor_total")]
    public double valortotal { get; set; }

    [JsonProperty("valor_total_com_imposto")]
    public double valortotalcomimposto { get; set; }

    [JsonProperty("codigo_desconto3306")]
    public string codigodesconto3306 { get; set; }

    [JsonProperty("descricao_desconto3306")]
    public string descricaodesconto3306 { get; set; }

    [JsonProperty("codigo_produto_principal")]
    public string codigoprodutoprincipal { get; set; }

    [JsonProperty("observacao_retorno")]
    public string observacaoretorno { get; set; }

    [JsonProperty("codigo_unidade_retirada")]
    public string codigounidaderetira { get; set; }

    [JsonProperty("tipo_entrega")]
    public string tipoentrega { get; set; }

    [JsonProperty("codigo_desconto561")]
    public string codigodesconto561 { get; set; }

    [JsonProperty("diferenca_preco")]
    public double diferencapreco { get; set; }

    [JsonProperty("saldo_verba")]
    public double saldoverba { get; set; }

    [JsonProperty("base_cred_deb_rca_descont561")]
    public string basecreddebracadesconto561 { get; set; }

    [JsonProperty("aplica_automatico_desconto561")]
    public string aplicaautomaticodesconto561 { get; set; }

    [JsonProperty("percentual_desconto561")]
    public double percentualdesconto561 { get; set; }

    [JsonProperty("codigo_auxiliar_embalagem")]
    public string codigoauxiliarembalagem { get; set; }

    [JsonProperty("quantidade_unitaria_embalagem")]
    public double quantidadeunitariaembalagem { get; set; }

    [JsonProperty("utiliza_venda_por_embalagem")]
    public string utilizavendaporembalagem { get; set; }

    [JsonProperty("tipo_carga_produto")]
    public string tipocargaproduto { get; set; }

    [JsonProperty("exibe_combo_embalagem")]
    public string exibecomboembalagem { get; set; }

    [JsonProperty("item_negociado")]
    public string itemnegociado { get; set; }

    [JsonProperty("unidade_venda")]
    public string unidadevenda { get; set; }

    [JsonProperty("tipo_estoque_produto")]
    public string tipoestoqueproduto { get; set; }

    [JsonProperty("codigo_regiao")]
    public double codigoregiao { get; set; }

    [JsonProperty("percentual_acrescimo")]
    public double percentualacrescimo { get; set; }

    [JsonProperty("comissao")]
    public double comissao { get; set; }

    [JsonProperty("peso")]
    public double peso { get; set; }

    [JsonProperty("valor_st")]
    public double valorst { get; set; }

    [JsonProperty("preco_st")]
    public double precocomst { get; set; }

    [JsonProperty("valor_total_com_st")]
    public double valortotalcomst { get; set; }

    [JsonProperty("numero_carregamento")]
    public double numerocarregamento { get; set; }

    [JsonProperty("percentual_base_red")]
    public double percentualbasered { get; set; }

    [JsonProperty("percentual_icm")]
    public double percentualicm { get; set; }

    [JsonProperty("data_validade_campanha_shelf", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime? datavalidadecampanhashelf { get; set; }

    [JsonProperty("preco_campanha_shelf")]
    public double precocampanhashelf { get; set; }

    [JsonProperty("codigo_campanha_shelf")]
    public string codigocampanhashelf { get; set; }

    [JsonProperty("unidade_frios")]
    public string unidadefrios { get; set; }
    public string imgproduto { get; set; }

    public static implicit operator List<object>(SalesOutFullItens v)
    {
        throw new NotImplementedException();
    }
}