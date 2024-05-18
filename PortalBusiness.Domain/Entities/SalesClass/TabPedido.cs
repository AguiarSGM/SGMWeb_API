using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class TabPedido
{
    [JsonProperty("codigo_pedido_rca")]
    public int CodigoPedidoRca { get; set; }

    [JsonProperty("codigo_pedido")]
    public int? CodigoPedido { get; set; }

    [JsonProperty("codigo_rca")]
    public int CodigoRca { get; set; }

    [JsonProperty("nome_rca")]
    public string? NomeRca { get; set; }

    [JsonProperty("codigo_cliente")]
    public int? CodigoCliente { get; set; }

    [JsonProperty("fantasia_cliente")]
    public string? FantasiaCliente { get; set; }

    [JsonProperty("razao_social_cliente")]
    public string? RazaoSocialCliente { get; set; }

    [JsonProperty("cnpj_cpf_cliente")]
    public string? CnpjCpfCliente { get; set; }

    [JsonProperty("data_hora_abertura_pedido")]
    public DateTime DataHoraAberturaPedido { get; set; }

    [JsonProperty("data_hora_fechamento_pedido")]
    public DateTime? DataHoraFechamentoPedido { get; set; }

    [JsonProperty("numero_pedido_cliente")]
    public string? NumeroPedidoCliente { get; set; }

    [JsonProperty("data_entrega_pedido")]
    public DateTime? DataEntregaPedido { get; set; }

    [JsonProperty("codigo_unidade_pedido")]
    public string? CodigoUnidadePedido { get; set; }

    [JsonProperty("codigo_unidade_nf_pedido")]
    public string? CodigoUnidadeNfPedido { get; set; }

    [JsonProperty("codigo_unidade_retirada_pedido")]
    public string? CodigoUnidadeRetiradaPedido { get; set; }

    [JsonProperty("valor_frete_pedido")]
    public decimal ValorFretePedido { get; set; }

    [JsonProperty("codigo_cobranca_pedido")]
    public string? CodigoCobrancaPedido { get; set; }

    [JsonProperty("codigo_plan_pagamento_pedido")]
    public string? CodigoPlanoPagamentoPedido { get; set; }

    [JsonProperty("condicao_venda_pedido")]
    public string? CondicaoVendaPedido { get; set; }

    [JsonProperty("observacao_pedido")]
    public string? ObservacaoPedido { get; set; }

    [JsonProperty("observacao_entrega_pedido")]
    public string? ObservacaoEntregaPedido { get; set; }

    [JsonProperty("frete_despacho_pedido")]
    public string? FreteDespachoPedido { get; set; }

    [JsonProperty("frete_redespacho_pedido")]
    public string? FreteRedespachoPedido { get; set; }

    [JsonProperty("codigo_fornecedor_frete_pedido")]
    public string? CodigoFornecedorFretePedido { get; set; }

    [JsonProperty("prazo1_pedido")]
    public int? Prazo1Pedido { get; set; }

    [JsonProperty("prazo2_pedido")]
    public int? Prazo2Pedido { get; set; }

    [JsonProperty("prazo3_pedido")]
    public int? Prazo3Pedido { get; set; }

    [JsonProperty("prazo4_pedido")]
    public int? Prazo4Pedido { get; set; }

    [JsonProperty("prazo5_pedido")]
    public int? Prazo5Pedido { get; set; }

    [JsonProperty("prazo6_pedido")]
    public int? Prazo6Pedido { get; set; }

    [JsonProperty("prazo7_pedido")]
    public int? Prazo7Pedido { get; set; }

    [JsonProperty("prazo8_pedido")]
    public int? Prazo8Pedido { get; set; }

    [JsonProperty("prazo9_pedido")]
    public int? Prazo9Pedido { get; set; }

    [JsonProperty("prazo10_pedido")]
    public int? Prazo10Pedido { get; set; }

    [JsonProperty("prazo11_pedido")]
    public int? Prazo11Pedido { get; set; }

    [JsonProperty("prazo12_pedido")]
    public int? Prazo12Pedido { get; set; }

    [JsonProperty("origem_pedido")]
    public string? OrigemPedido { get; set; }

    [JsonProperty("numero_pedido_comprador")]
    public string? NumeroPedidoComprador { get; set; }

    [JsonProperty("posicao_atual_pedido")]
    public string? PosicaoAtualPedido { get; set; }

    [JsonProperty("saldo_atual_rca")]
    public decimal SaldoAtualRca { get; set; }

    [JsonProperty("tipo_prioridade_entrega_pedido")]
    public string? TipoPrioridadeEntregaPedido { get; set; }

    [JsonProperty("percentual_desconto_abatimento_pedido")]
    public decimal PercentualDescontoAbatimentoPedido { get; set; }

    [JsonProperty("custo_bonificacao_pedido")]
    public string? CustoBonificacaoPedido { get; set; }

    [JsonProperty("cod_fornecedor_bonificacao_pedido")]
    public string? CodFornecedorBonificacaoPedido { get; set; }

    [JsonProperty("codigo_bonificacao_pedido")]
    public string? CodigoBonificacaoPedido { get; set; }

    [JsonProperty("agrupamento_pedido")]
    public string? AgrupamentoPedido { get; set; }

    [JsonProperty("codigo_endereco_entrega_pedido")]
    public string? CodigoEnderecoEntregaPedido { get; set; }

    [JsonProperty("orcamento_pedido")]
    public string? OrcamentoPedido { get; set; }

    [JsonProperty("valor_desconto_abatimento_pedido")]
    public decimal ValorDescontoAbatimentoPedido { get; set; }

    [JsonProperty("valor_entrada_pedido")]
    public decimal ValorEntradaPedido { get; set; }

    [JsonProperty("status_pedido")]
    public string? StatusPedido { get; set; }

    [JsonProperty("total_itens_pedido")]
    public decimal TotalItensPedido { get; set; }

    [JsonProperty("total_pedido")]
    public decimal TotalPedido { get; set; }

    [JsonProperty("total_pedido_com_imposto")]
    public decimal ValorTotalComST { get; set; }

    [JsonProperty("observacao_retorno")]
    public string? ObservacaoRetorno { get; set; }

    [JsonProperty("saldo_verba")]
    public decimal SaldoVerba { get; set; }

    [JsonProperty("quebra_pedido_frete")]
    public string? QuebraPedidoFrete { get; set; }

    [JsonProperty("percentual_frete_outra_filial")]
    public decimal PercentualFreteOutraFilial { get; set; }

    [JsonProperty("codigo_filial_pedido_frete")]
    public string? CodigoFilialPedidoFrete { get; set; }

    [JsonProperty("codigo_produto_pedido_frete")]
    public string? CodigoProdutoPedidoFrete { get; set; }

    [JsonProperty("preco_produto_pedido_frete")]
    public decimal PrecoProdutoPedidoFrete { get; set; }

    [JsonProperty("codigo_pedido_rca_pedido_frete")]
    public int? CodigoPedidoRcaPedidoFrete { get; set; }

    [JsonProperty("cidade_cliente")]
    public string? CidadeCliente { get; set; }

    [JsonProperty("tipo_emissao")]
    public int? TipoEmissao { get; set; }

    [JsonProperty("quebra_pedido_prevenda")]
    public string? QuebraPedidoPrevenda { get; set; }

    [JsonProperty("codigo_pedido_rca_pedido_prevenda")]
    public int? CodigoPedidoRcaPedidoPrevenda { get; set; }

    [JsonProperty("codigo_filial_pedido_prevenda")]
    public string? CodigoFilialPedidoPrevenda { get; set; }

    [JsonProperty("retorno_numero_pedido_erp")]
    public int? RetornoNumeroPedidoErp { get; set; }

    [JsonProperty("retorno_motivo_bloqueio")]
    public string? RetornoMotivoBloqueio { get; set; }

    [JsonProperty("retorno_valor_pedido")]
    public decimal RetornoValorPedido { get; set; }

    [JsonProperty("retorno_valor_atendido")]
    public decimal RetornoValorAtendido { get; set; }

    [JsonProperty("numero_pedido_venda")]
    public string? NumeroPedidoVenda { get; set; }

    [JsonProperty("data_emissao_mapa")]
    public string? DataEmissaoMapa { get; set; }

    [JsonProperty("numero_pedido_erp_original")]
    public int? NumeroPedidoErpOriginal { get; set; }

    [JsonProperty("comissao")]
    public decimal Comissao { get; set; }

    [JsonProperty("peso")]
    public decimal Peso { get; set; }

    [JsonProperty("gerou_brinde")]
    public string? GerouBrinde { get; set; }

    [JsonProperty("codigo_motorista")]
    public string? CodigoMotorista { get; set; }

    [JsonProperty("nome_motorista")]
    public string? NomeMotorista { get; set; }

    [JsonProperty("celular_motorista")]
    public string? CelularMotorista { get; set; }

    [JsonProperty("data_cadastro")]
    public DateTime DataCadastro { get; set; }

    [JsonProperty("status_processamento")]
    public string? StatusProcessamento { get; set; }

    [JsonProperty("data_processamento")]
    public DateTime? DataProcessamento { get; set; }

    [JsonProperty("mensagem_processamento")]
    public string? MensagemProcessamento { get; set; }

    [JsonProperty("nome_arquivo_remessa")]
    public string? NomeArquivoRemessa { get; set; }

    [JsonProperty("id_usuario")]
    public int? IdUsuario { get; set; }

    [JsonProperty("endereco_cliente")]
    public string? EnderecoCliente { get; set; }

    [JsonProperty("qt_itens_gravado")]
    public int? QtItensGravado { get; set; }

    [JsonProperty("qt_itens_pedido")]
    public int? QtItensPedido { get; set; }
    
    public List<TabPedidoItens> Itens { get; set; }
}
