using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class SalesOutFullOrder
{
    [JsonProperty("codigo_pedido_rca")]
    public long codigopedidorca { get; set; }

    [JsonProperty("codigo_pedido")]
    public int codigopedido { get; set; }

    [JsonProperty("codigo_rca")]
    public int codigorca { get; set; }

    [JsonProperty("nome_rca")]
    public string nomerca { get; set; }

    [JsonProperty("codigo_cliente")]
    public double codigocliente { get; set; }

    [JsonProperty("fantasia_cliente")]
    public string fantasiacliente { get; set; }

    [JsonProperty("razao_social")]
    public string razaosocialcliente { get; set; }

    [JsonProperty("cnpj_cpf_cliente")]
    public string cnpjcpfcliente { get; set; }

    [JsonProperty("data_hora_abertura_pedido")]
    public DateTime datahoraaberturapedido { get; set; }

    [JsonProperty("data_hora_fechamento_pedido")]
    public DateTime datahorafechamentopedido { get; set; }

    [JsonProperty("numero_pedido_cliente")]
    public string numeropedidocliente { get; set; }

    [JsonProperty("data_entrega_pedido")]
    public DateTime dataentregapedido { get; set; }

    [JsonProperty("codigo_unidade_pedido")]
    public string codigounidadepedido { get; set; }

    [JsonProperty("codigo_unidade_nf_pedido")]
    public string codigounidadenfpedido { get; set; }

    [JsonProperty("codigo_unidade_retirada_pedido")]
    public string codigounidaderetiradapedido { get; set; }

    [JsonProperty("valor_frete_pedido")]
    public decimal valorfretepedido { get; set; }

    [JsonProperty("codigo_cobranca_pedido")]
    public string codigocobrancapedido { get; set; }

    [JsonProperty("codigo_plan_pagamento_pedido")]
    public int codigoplanpagamentopedido { get; set; }

    [JsonProperty("condicao_venda_pedido")]
    public string condicaovendapedido { get; set; }

    [JsonProperty("observacao_pedido")]
    public string observacaopedido { get; set; }

    [JsonProperty("observacao_entrega_pedido")]
    public string observacaoentregapedido { get; set; }

    [JsonProperty("frete_despacho_pedido")]
    public string fretedespachopedido { get; set; }

    [JsonProperty("frete_rede_despacho_pedido")]
    public string freterededespachopedido { get; set; }

    [JsonProperty("codigo_fornecedor_frete_pedido")]
    public string codigofornecedorfretepedido { get; set; }

    [JsonProperty("prazo1_pedido")]
    public decimal prazo1pedido { get; set; }

    [JsonProperty("prazo2_pedido")]
    public decimal prazo2pedido { get; set; }

    [JsonProperty("prazo3_pedido")]
    public decimal prazo3pedido { get; set; }

    [JsonProperty("prazo4_pedido")]
    public decimal prazo4pedido { get; set; }

    [JsonProperty("prazo5_pedido")]
    public decimal prazo5pedido { get; set; }

    [JsonProperty("prazo6_pedido")]
    public decimal prazo6pedido { get; set; }

    [JsonProperty("prazo7_pedido")]
    public decimal prazo7pedido { get; set; }

    [JsonProperty("prazo8_pedido")]
    public decimal prazo8pedido { get; set; }

    [JsonProperty("prazo9_pedido")]
    public decimal prazo9pedido { get; set; }

    [JsonProperty("prazo10_pedido")]
    public decimal prazo10pedido { get; set; }

    [JsonProperty("prazo11_pedido")]
    public decimal prazo11pedido { get; set; }

    [JsonProperty("prazo12_pedido")]
    public decimal prazo12pedido { get; set; }

    [JsonProperty("origem_pedido")]
    public string origempedido { get; set; }

    [JsonProperty("numero_pedido_comprador")]
    public string numeropedidocomprador { get; set; }

    [JsonProperty("posicao_atual_pedido")]
    public string posicaoatualpedido { get; set; }

    [JsonProperty("saldo_atual_rca")]
    public decimal saldoatualrca { get; set; }

    [JsonProperty("tipo_prioridade_entrega_pedido")]
    public string tipoprioridadeentregapedido { get; set; }

    [JsonProperty("perc_desc_abatimento_pedido")]
    public decimal percdescabatimentopedido { get; set; }

    [JsonProperty("custo_bonificacao_pedido")]
    public string custobonificacaopedido { get; set; }

    [JsonProperty("cod_fornec_bonificacao_pedido")]
    public string codfornecbonificacaopedido { get; set; }

    [JsonProperty("codigo_bonificao_pedido")]
    public string codigobonificaopedido { get; set; }

    [JsonProperty("agrupamento_pedido")]
    public string agrupamentopedido { get; set; }

    [JsonProperty("codigo_endereco_entrega_pedido")]
    public int codigoenderecoentregapedido { get; set; }

    [JsonProperty("orcamento_pedido")]
    public string orcamentopedido { get; set; }

    [JsonProperty("valor_desconto_abatimento_pedido")]
    public decimal valordescontoabatimentopedido { get; set; }

    [JsonProperty("valor_entrada_pedido")]
    public decimal valorentradapedido { get; set; }

    [JsonProperty("status_pedido")]
    public string statuspedido { get; set; }

    [JsonProperty("total_itens_pedido")]
    public decimal totalitenspedido { get; set; }

    [JsonProperty("total_pedido")]
    public decimal totalpedido { get; set; }

    [JsonProperty("total_pedido_com_imposto")]
    public decimal totalpedidocomimposto { get; set; }

    [JsonProperty("observacao_retorno")]
    public string observacaoretorno { get; set; }

    [JsonProperty("saldoverba")]
    public decimal saldoverba { get; set; }

    [JsonProperty("quebrapedidofrete")]
    public string quebrapedidofrete { get; set; }

    [JsonProperty("percentual_frete_outra_filial")]
    public decimal percentualfreteoutrafilial { get; set; }

    [JsonProperty("codigo_filial_pedido_frete")]
    public string codigofilialpedidofrete { get; set; }

    [JsonProperty("codigo_produto_pedido_frete")]
    public string codigoprodutopedidofrete { get; set; }

    [JsonProperty("preco_produto_pedido_frete")]
    public decimal precoprodutopedidofrete { get; set; }

    [JsonProperty("codigo_pedido_rca_pedido_frete")]
    public int codigopedidorcapedidofrete { get; set; }

    [JsonProperty("cidade_cliente")]
    public string cidadecliente { get; set; }

    [JsonProperty("tipo_emissao")]
    public int tipoemissao { get; set; }

    [JsonProperty("quebrapedidoprevenda")]
    public string quebrapedidoprevenda { get; set; }

    [JsonProperty("codigo_pedidorca_pedido_prevenda")]
    public string codigopedidorcapedidoprevenda { get; set; }

    [JsonProperty("codigo_filial_pedido_prevenda")]
    public string codigofilialpedidoprevenda { get; set; }

    [JsonProperty("retorno_numero_pedido_erp")]
    public int retornonumeropedidoerp { get; set; }

    [JsonProperty("retorno_motivo_bloqueio")]
    public string retornomotivobloqueio { get; set; }

    [JsonProperty("retorno_valor_pedido")]
    public int retornovalorpedido { get; set; }

    [JsonProperty("retorno_valor_atendido")]
    public int retornovaloratendido { get; set; }

    [JsonProperty("numero_pedido_venda")]
    public string numeropedidovenda { get; set; }

    [JsonProperty("data_emissao_mapa")]
    public string dataemissaomapa { get; set; }

    [JsonProperty("numero_pedido_erp_origional")]
    public int numeropedidoerporigional { get; set; }

    [JsonProperty("comissao")]
    public int comissao { get; set; }

    [JsonProperty("peso")]
    public decimal peso { get; set; }

    [JsonProperty("gerou_brinde")]
    public string geroubrinde { get; set; }

    [JsonProperty("codigo_motorista")]
    public string codigomotorista { get; set; }

    [JsonProperty("nome_motorista")]
    public string nomemotorista { get; set; }

    [JsonProperty("celular_motorista")]
    public string celularmotorista { get; set; }

    [JsonProperty("data_cadastro")]
    public DateTime datacadastro { get; set; }

    [JsonProperty("status_processamento")]
    public string statusprocessamento { get; set; }

    [JsonProperty("data_processamento")]
    public DateTime dataprocessamento { get; set; }

    [JsonProperty("mensagem_processamento")]
    public string mensagemprocessamento { get; set; }

    [JsonProperty("nome_arquivo_remessa")]
    public string nomearquivoremessa { get; set; }

    [JsonProperty("id_usuario")]
    public double idusuario { get; set; }

    [JsonProperty("endereco_cliente")]
    public string enderecocliente { get; set; }

    [JsonProperty("itens")]
    public List<SalesOutFullItens> Itens { get; set; }
}
