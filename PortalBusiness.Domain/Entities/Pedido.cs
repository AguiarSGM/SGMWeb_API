using System.Text.Json.Serialization;

namespace PortalBusiness.Domain.Entities;

public class Pedido
{
    [JsonPropertyName("codigo_pedido_rca")]
    public double CodigoPedidoRca { get; set; }

    [JsonPropertyName("codigo_pedido")]
    public double CodigoPedido { get; set; }

    [JsonPropertyName("codigo_rca")]
    public double CodigoRca { get; set; }

    [JsonPropertyName("nome_rca")]
    public string NomeRca { get; set; }

    [JsonPropertyName("codigo_cliente")]
    public double CodigoCliente { get; set; }

    [JsonPropertyName("fantasia_cliente")]
    public string FantasiaCliente { get; set; }

    [JsonPropertyName("razao_social")]
    public string RazaoSocial { get; set; }

    [JsonPropertyName("cnpj_cpf_cliente")]
    public string CnpjCpfCliente { get; set; }

    [JsonPropertyName("data_hora_abertura_pedido")]
    public DateTime DataHoraAberturaPedido { get; set; }

    [JsonPropertyName("data_hora_fechamento_pedido")]
    public DateTime DataHoraFechamentoPedido { get; set; }

    [JsonPropertyName("numero_pedido_cliente")]
    public string NumeroPedidoCliente { get; set; }

    [JsonPropertyName("data_entrega_pedido")]
    public DateTime DataEntregaPedido { get; set; }

    [JsonPropertyName("codigo_unidade_pedido")]
    public string? CodigoUnidadePedido { get; set; } // Nullable since it's optional

    [JsonPropertyName("codigo_unidade_nf_pedido")]
    public string CodigoUnidadeNfPedido { get; set; }

    [JsonPropertyName("codigo_unidade_retirada_pedido")]
    public string CodigoUnidadeRetiradaPedido { get; set; }

    [JsonPropertyName("valor_frete_pedido")]
    public double ValorFretePedido { get; set; }

    [JsonPropertyName("codigo_cobranca_pedido")]
    public string CodigoCobrancaPedido { get; set; }

    [JsonPropertyName("codigo_plan_pagamento_pedido")]
    public string CodigoPlanPagamentoPedido { get; set; }

    [JsonPropertyName("condicao_venda_pedido")]
    public string CondicaoVendaPedido { get; set; }

    [JsonPropertyName("observacao_pedido")]
    public string ObservacaoPedido { get; set; }

    [JsonPropertyName("observacao_entrega_pedido")]
    public string ObservacaoEntregaPedido { get; set; }

    [JsonPropertyName("frete_despacho_pedido")]
    public string FreteDespachoPedido { get; set; }

    [JsonPropertyName("frete_rede_despacho_pedido")]
    public string FreteRedeDespachoPedido { get; set; }

    [JsonPropertyName("codigo_fornecedor_frete_pedido")]
    public string CodigoFornecedorFretePedido { get; set; }

    [JsonPropertyName("prazo1_pedido")]
    public double Term1 { get; set; }

    [JsonPropertyName("prazo2_pedido")]
    public double Term2 { get; set; }

    [JsonPropertyName("prazo3_pedido")]
    public double Term3 { get; set; }

    [JsonPropertyName("prazo4_pedido")]
    public double Term4 { get; set; }

    [JsonPropertyName("prazo5_pedido")]
    public double Term5 { get; set; }

    [JsonPropertyName("prazo6_pedido")]
    public double Term6 { get; set; }

    [JsonPropertyName("prazo7_pedido")]
    public double Term7 { get; set; }

    [JsonPropertyName("prazo8_pedido")]
    public double Term8 { get; set; }

    [JsonPropertyName("prazo9_pedido")]
    public double Term9 { get; set; }

    [JsonPropertyName("prazo10_pedido")]
    public double Term10 { get; set; }

    [JsonPropertyName("prazo11_pedido")]
    public double Term11 { get; set; }

    [JsonPropertyName("prazo12_pedido")]
    public double Term12 { get; set; }

    [JsonPropertyName("origem_pedido")]
    public string OrigemPedido { get; set; }

    [JsonPropertyName("numero_pedido_comprador")]
    public string NumeroPedidoComprador { get; set; }

    [JsonPropertyName("posicao_atual_pedido")]
    public string PosicaoAtualPedido { get; set; }

    [JsonPropertyName("saldo_atual_rca")]
    public double SaldoAtualRca { get; set; }

    [JsonPropertyName("tipo_prioridade_entrega_pedido")]
    public string TipoPrioridadeEntregaPedido { get; set; }

    [JsonPropertyName("perc_desc_abatimento_pedido")]
    public double PercDescAbatimentoPedido { get; set; }

    [JsonPropertyName("custo_bonificacao_pedido")]
    public string CustoBonificacaoPedido { get; set; }

    [JsonPropertyName("cod_fornec_bonificacao_pedido")]
    public string CodFornecBonificacaoPedido { get; set; }

    [JsonPropertyName("codigo_bonificao_pedido")]
    public string CodigoBonificaoPedido { get; set; }

    [JsonPropertyName("agrupamento_pedido")]
    public string AgrupamentoPedido { get; set; }

    [JsonPropertyName("codigo_endereco_entrega_pedido")]
    public string CodigoEnderecoEntregaPedido { get; set; }

    [JsonPropertyName("orcamento_pedido")]
    public string OrcamentoPedido { get; set; }

    [JsonPropertyName("valor_desconto_abatimento_pedido")]
    public double ValorDescontoAbatimentoPedido { get; set; }

    [JsonPropertyName("valor_entrada_pedido")]
    public double ValorEntradaPedido { get; set; }

    [JsonPropertyName("status_pedido")]
    public string StatusPedido { get; set; }

    [JsonPropertyName("total_itens_pedido")]
    public double TotalItensPedido { get; set; }

    [JsonPropertyName("total_pedido")]
    public double TotalPedido { get; set; }

    [JsonPropertyName("total_pedido_com_imposto")]
    public double TotalPedidoComImposto { get; set; }

    [JsonPropertyName("observacao_retorno")]
    public string ObservacaoRetorno { get; set; }

    [JsonPropertyName("saldo_verba")]
    public double SaldoVerba { get; set; }

    [JsonPropertyName("quebra_pedido_frete")]
    public string QuebraPedidoFrete { get; set; }

    [JsonPropertyName("percentual_frete_outra_filial")]
    public double PercentualFreteOutraFilial { get; set; }

    [JsonPropertyName("codigo_filial_pedido_frete")]
    public string CodigoFilialPedidoFrete { get; set; }

    [JsonPropertyName("codigo_produto_pedido_frete")]
    public string CodigoProdutoPedidoFrete { get; set; }

    [JsonPropertyName("preco_produto_pedido_frete")]
    public double PrecoProdutoPedidoFrete { get; set; }

    [JsonPropertyName("codigo_pedido_rca_pedido_frete")]
    public double CodigoPedidoRcaPedidoFrete { get; set; }

    [JsonPropertyName("cidade_cliente")]
    public string CidadeCliente { get; set; }

    [JsonPropertyName("tipo_emissao")]
    public double TipoEmissao { get; set; }

    [JsonPropertyName("quebra_pedido_pre_venda")]
    public string QuebraPedidoPreVenda { get; set; }

    [JsonPropertyName("codigo_pedido_rca_pedido_pre_venda")]
    public string CodigoPedidoRcaPedidoPreVenda { get; set; }

    [JsonPropertyName("codigo_filial_pedido_pre_venda")]
    public string CodigoFilialPedidoPreVenda { get; set; }

    [JsonPropertyName("retorno_numero_pedido_erp")]
    public double RetornoNumeroPedidoErp { get; set; }

    [JsonPropertyName("retorno_motivo_bloqueio")]
    public string RetornoMotivoBloqueio { get; set; }

    [JsonPropertyName("retorno_valor_pedido")]
    public double RetornoValorPedido { get; set; }

    [JsonPropertyName("retorno_valor_atendido")]
    public double RetornoValorAtendido { get; set; }

    [JsonPropertyName("numero_pedido_venda")]
    public string NumeroPedidoVenda { get; set; }

    [JsonPropertyName("data_emissao_mapa")]
    public string DataEmissaoMapa { get; set; }

    [JsonPropertyName("numero_pedido_erp_origional")]
    public double NumeroPedidoErpOriginal { get; set; }

    [JsonPropertyName("comissao")]
    public double Comissao { get; set; }

    [JsonPropertyName("peso")]
    public double Peso { get; set; }

    [JsonPropertyName("gerou_brinde")]
    public string GerouBrinde { get; set; }

    [JsonPropertyName("codigo_motorista")]
    public string CodigoMotorista { get; set; }

    [JsonPropertyName("nome_motorista")]
    public string NomeMotorista { get; set; }

    [JsonPropertyName("celular_motorista")]
    public string CelularMotorista { get; set; }

    [JsonPropertyName("data_cadastro")]
    public DateTime DataCadastro { get; set; }

    [JsonPropertyName("status_processamento")]
    public string StatusProcessamento { get; set; }

    [JsonPropertyName("data_processamento")]
    public DateTime DataProcessamento { get; set; }

    [JsonPropertyName("mensagem_processamento")]
    public string MensagemProcessamento { get; set; }

    [JsonPropertyName("nome_arquivo_remessa")]
    public string NomeArquivoRemessa { get; set; }

    [JsonPropertyName("id_usuario")]
    public double IDUsuario { get; set; }

    [JsonPropertyName("endereco_cliente")]
    public string EnderecoCliente { get; set; }

    [JsonPropertyName("itens")]
    public List<PedidoItem> Itens { get; set; }

    


}
