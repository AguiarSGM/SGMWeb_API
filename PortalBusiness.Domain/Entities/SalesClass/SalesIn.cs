using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class SalesIn
{
    [JsonProperty("codigo_pedido_rca")]
    public double CodigoPedidoRca { get; set; }

    [JsonProperty("codigo_pedido")]
    public double? CodigoPedido { get; set; }

    [JsonProperty("codigo_rca")]
    public double CodigoRca { get; set; }

    [JsonProperty("nome_rca")]
    public string NomeRca { get; set; }

    [JsonProperty("codigo_cliente")]
    public double CodigoCliente { get; set; }

    [JsonProperty("fantasia_cliente")]
    public string FantasiaCliente { get; set; }

    [JsonProperty("razao_social")]
    public string RazaoSocial { get; set; }

    [JsonProperty("cnpj_cpf_cliente")]
    public string CnpjCpfCliente { get; set; }

    [JsonProperty("data_hora_abertura_pedido")]
    public DateTime DataHoraAberturaPedido { get; set; }

    [JsonProperty("data_hora_fechamento_pedido")]
    public DateTime DataHoraFechamentoPedido { get; set; }

    [JsonProperty("numero_pedido_cliente")]
    public string NumeroPedidoCliente { get; set; }

    [JsonProperty("data_entrega_pedido")]
    public DateTime DataEntregaPedido { get; set; }

    [JsonProperty("codigo_unidade_pedido")]
    public string CodigoUnidadePedido { get; set; }

    [JsonProperty("codigo_unidade_nf_pedido")]
    public string CodigoUnidadeNfPedido { get; set; }

    [JsonProperty("codigo_unidade_retirada_pedido")]
    public string CodigoUnidadeRetiradaPedido { get; set; }

    [JsonProperty("valor_frete_pedido")]
    public double? ValorFretePedido { get; set; }

    [JsonProperty("codigo_cobranca_pedido")]
    public string CodigoCobrancaPedido { get; set; }

    [JsonProperty("codigo_plan_pagamento_pedido")]
    public double CodigoPlanPagamentoPedido { get; set; }

    [JsonProperty("condicao_venda_pedido")]
    public string CondicaoVendaPedido { get; set; }

    [JsonProperty("observacao_pedido")]
    public string ObservacaoPedido { get; set; }

    [JsonProperty("observacao_entrega_pedido")]
    public string ObservacaoEntregaPedido { get; set; }

    [JsonProperty("frete_despacho_pedido")]
    public string FreteDespachoPedido { get; set; }

    [JsonProperty("frete_rede_despacho_pedido")]
    public string FreteRedeDespachoPedido { get; set; }

    [JsonProperty("codigo_fornecedor_frete_pedido")]
    public string CodigoFornecedorFretePedido { get; set; }

    [JsonProperty("prazo1_pedido")]
    public double? Prazo1Pedido { get; set; }

    [JsonProperty("prazo2_pedido")]
    public double? Prazo2Pedido { get; set; }

    [JsonProperty("prazo3_pedido")]
    public double? Prazo3Pedido { get; set; }

    [JsonProperty("prazo4_pedido")]
    public double? Prazo4Pedido { get; set; }

    [JsonProperty("prazo5_pedido")]
    public double? Prazo5Pedido { get; set; }

    [JsonProperty("prazo6_pedido")]
    public double? Prazo6Pedido { get; set; }

    [JsonProperty("prazo7_pedido")]
    public double? Prazo7Pedido { get; set; }

    [JsonProperty("prazo8_pedido")]
    public double? Prazo8Pedido { get; set; }

    [JsonProperty("prazo9_pedido")]
    public double? Prazo9Pedido { get; set; }

    [JsonProperty("prazo10_pedido")]
    public double? Prazo10Pedido { get; set; }

    [JsonProperty("prazo11_pedido")]
    public double? Prazo11Pedido { get; set; }

    [JsonProperty("prazo12_pedido")]
    public double? Prazo12Pedido { get; set; }

    [JsonProperty("origem_pedido")]
    public string OrigemPedido { get; set; }

    [JsonProperty("numero_pedido_comprador")]
    public string NumeroPedidoComprador { get; set; }

    [JsonProperty("posicao_atual_pedido")]
    public string PosicaoAtualPedido { get; set; }

    [JsonProperty("saldo_atual_rca")]
    public double? SaldoAtualRca { get; set; }

    [JsonProperty("tipo_prioridade_entrega_pedido")]
    public string TipoPrioridadeEntregaPedido { get; set; }

    [JsonProperty("perc_desc_abatimento_pedido")]
    public double? PercDescAbatimentoPedido { get; set; }

    [JsonProperty("custo_bonificacao_pedido")]
    public string CustoBonificacaoPedido { get; set; }

    [JsonProperty("cod_fornec_bonificacao_pedido")]
    public string CodFornecBonificacaoPedido { get; set; }

    [JsonProperty("codigo_bonificao_pedido")]
    public string CodigoBonificaoPedido { get; set; }

    [JsonProperty("agrupamento_pedido")]
    public string AgrupamentoPedido { get; set; }

    [JsonProperty("codigo_endereco_entrega_pedido")]
    public double? CodigoEnderecoEntregaPedido { get; set; }

    [JsonProperty("orcamento_pedido")]
    public string OrcamentoPedido { get; set; }

    [JsonProperty("valor_desconto_abatimento_pedido")]
    public double? ValorDescontoAbatimentoPedido { get; set; }

    [JsonProperty("valor_entrada_pedido")]
    public double? ValorEntradaPedido { get; set; }

    [JsonProperty("status_pedido")]
    public string StatusPedido { get; set; }

    [JsonProperty("total_itens_pedido")]
    public double TotalItensPedido { get; set; }

    [JsonProperty("total_pedido")]
    public double TotalPedido { get; set; }

    [JsonProperty("total_pedido_com_imposto")]
    public double TotalPedidoComImposto { get; set; }

    [JsonProperty("observacao_retorno")]
    public string ObservacaoRetorno { get; set; }

    [JsonProperty("saldo_verba")]
    public double? SaldoVerba { get; set; }

    [JsonProperty("quebra_pedido_frete")]
    public string QuebraPedidoFrete { get; set; }

    [JsonProperty("percentual_frete_outra_filial")]
    public double? PercentualFreteOutraFilial { get; set; }

    [JsonProperty("codigo_filial_pedido_frete")]
    public string CodigoFilialPedidoFrete { get; set; }

    [JsonProperty("codigo_produto_pedido_frete")]
    public string CodigoProdutoPedidoFrete { get; set; }

    [JsonProperty("preco_produto_pedido_frete")]
    public double? PrecoProdutoPedidoFrete { get; set; }

    [JsonProperty("codigo_pedido_rca_pedido_frete")]
    public double? CodigoPedidoRcaPedidoFrete { get; set; }

    [JsonProperty("cidade_cliente")]
    public string CidadeCliente { get; set; }

    [JsonProperty("tipo_emissao")]
    public double? TipoEmissao { get; set; }

    [JsonProperty("quebra_pedido_pre_venda")]
    public string QuebraPedidoPreVenda { get; set; }

    [JsonProperty("codigo_pedido_rca_pedido_pre_venda")]
    public string CodigoPedidoRcaPedidoPreVenda { get; set; }

    [JsonProperty("codigo_filial_pedido_pre_venda")]
    public string CodigoFilialPedidoPreVenda { get; set; }

    [JsonProperty("retorno_numero_pedido_erp")]
    public double? RetornoNumeroPedidoErp { get; set; }

    [JsonProperty("retorno_motivo_bloqueio")]
    public string RetornoMotivoBloqueio { get; set; }

    [JsonProperty("retorno_valor_pedido")]
    public double? RetornoValorPedido { get; set; }

    [JsonProperty("retorno_valor_atendido")]
    public double? RetornoValorAtendido { get; set; }

    [JsonProperty("numero_pedido_venda")]
    public string NumeroPedidoVenda { get; set; }

    [JsonProperty("data_emissao_mapa")]
    public string DataEmissaoMapa { get; set; }

    [JsonProperty("numero_pedido_erp_origional")]
    public double? NumeroPedidoErpOriginal { get; set; }

    [JsonProperty("comissao")]
    public double? Comissao { get; set; }

    [JsonProperty("peso")]
    public double? Peso { get; set; }

    [JsonProperty("gerou_brinde")]
    public string GerouBrinde { get; set; }

    [JsonProperty("codigo_motorista")]
    public string CodigoMotorista { get; set; }

    [JsonProperty("nome_motorista")]
    public string NomeMotorista { get; set; }

    [JsonProperty("celular_motorista")]
    public string CelularMotorista { get; set; }

    [JsonProperty("data_cadastro")]
    public DateTime DataCadastro { get; set; }

    [JsonProperty("status_processamento")]
    public string StatusProcessamento { get; set; }

    [JsonProperty("data_processamento")]
    public DateTime? DataProcessamento { get; set; }

    [JsonProperty("mensagem_processamento")]
    public string MensagemProcessamento { get; set; }

    [JsonProperty("nome_arquivo_remessa")]
    public string NomeArquivoRemessa { get; set; }

    [JsonProperty("id_usuario")]
    public double IDUsuario { get; set; }

    [JsonProperty("endereco_cliente")]
    public string EnderecoCliente { get; set; }

    [JsonProperty("itens")]
    public List<ItemIn> Itens { get; set; }
}
