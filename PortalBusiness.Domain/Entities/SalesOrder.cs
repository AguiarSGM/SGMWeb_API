using PortalBusiness.Domain.Models.Shared;
using System.Text.Json.Serialization;

namespace PortalBusiness.Domain.Entities;

public class SalesOrder
{
    public DateTime data_cadastro { get; set; }
    public DateTime data_entrega_pedido { get; set; }
    public DateTime data_hora_abertura_pedido { get; set; }
    public DateTime data_hora_fechamento_pedido { get; set; }
    public DateTime? data_processamento { get; set; }
    public decimal comissao { get; set; }
    public decimal id_usuario { get; set; }
    public decimal numero_pedido_erp_origional { get; set; }
    public decimal perc_desc_abatimento_pedido { get; set; }
    public decimal percentual_frete_outra_filial { get; set; }
    public decimal peso { get; set; }
    public decimal prazo1_pedido { get; set; }
    public decimal prazo10_pedido { get; set; }
    public decimal prazo11_pedido { get; set; }
    public decimal prazo12_pedido { get; set; }
    public decimal prazo2_pedido { get; set; }
    public decimal prazo3_pedido { get; set; }
    public decimal prazo4_pedido { get; set; }
    public decimal prazo5_pedido { get; set; }
    public decimal prazo6_pedido { get; set; }
    public decimal prazo7_pedido { get; set; }
    public decimal prazo8_pedido { get; set; }
    public decimal prazo9_pedido { get; set; }
    public decimal preco_produto_pedido_frete { get; set; }
    public decimal qtitensgravado { get; set; }
    public decimal retorno_numero_pedido_erp { get; set; }
    public decimal retorno_valor_atendido { get; set; }
    public decimal retorno_valor_pedido { get; set; }
    public decimal saldo_atual_rca { get; set; }
    public decimal saldo_verba { get; set; }
    public decimal tipo_emissao { get; set; }
    public decimal total_itens_pedido { get; set; }
    public decimal total_pedido { get; set; }
    public decimal total_pedido_com_imposto { get; set; }
    public decimal valor_desconto_abatimento_pedido { get; set; }
    public decimal valor_entrada_pedido { get; set; }
    public decimal valor_frete_pedido { get; set; }
    public int codigo_cliente { get; set; }
    public int codigo_pedido { get; set; }
    public long codigo_pedido_rca { get; set; }
    public int codigo_pedido_rca_pedido_frete { get; set; }
    public int codigo_rca { get; set; }
    public string agrupamento_pedido { get; set; } = string.Empty;
    public string celular_motorista { get; set; } = string.Empty;
    public string cidade_cliente { get; set; } = string.Empty;
    public string cnpj_cpf_cliente { get; set; } = string.Empty;
    public string cod_fornec_bonificacao_pedido { get; set; } = string.Empty;
    public string codigo_bonificao_pedido { get; set; } = string.Empty;
    public string codigo_cobranca_pedido { get; set; } = string.Empty;
    public string codigo_endereco_entrega_pedido { get; set; } = string.Empty;
    public string codigo_filial_pedido_frete { get; set; } = string.Empty;
    public string codigo_filial_pedido_pre_venda { get; set; } = string.Empty;
    public string codigo_fornecedor_frete_pedido { get; set; } = string.Empty;
    public string codigo_motorista { get; set; } = string.Empty;
    public string codigo_pedido_rca_pedido_pre_venda { get; set; } = string.Empty;
    public string codigo_plan_pagamento_pedido { get; set; } = string.Empty;
    public string codigo_produto_pedido_frete { get; set; } = string.Empty;
    public string codigo_unidade_nf_pedido { get; set; } = string.Empty;
    public string codigo_unidade_pedido { get; set; } = string.Empty;
    public string codigo_unidade_retirada_pedido { get; set; } = string.Empty;
    public string condicao_venda_pedido { get; set; } = string.Empty;
    public string custo_bonificacao_pedido { get; set; } = string.Empty;
    public string data_emissao_mapa { get; set; } = string.Empty;
    public string endereco_cliente { get; set; } = string.Empty;
    public string fantasia_cliente { get; set; } = string.Empty;
    public string frete_despacho_pedido { get; set; } = string.Empty;
    public string frete_rede_despacho_pedido { get; set; } = string.Empty;
    public string gerou_brinde { get; set; } = string.Empty;
    public string mensagem_processamento { get; set; } = string.Empty;
    public string nome_arquivo_remessa { get; set; } = string.Empty;
    public string nome_motorista { get; set; } = string.Empty;
    public string nome_rca { get; set; } = string.Empty;
    public string numero_pedido_cliente { get; set; } = string.Empty;
    public string numero_pedido_comprador { get; set; } = string.Empty;
    public string numero_pedido_venda { get; set; } = string.Empty;
    public string observacao_entrega_pedido { get; set; } = string.Empty;
    public string observacao_pedido { get; set; } = string.Empty;
    public string observacao_retorno { get; set; } = string.Empty;
    public string orcamento_pedido { get; set; } = string.Empty;
    public string origem_pedido { get; set; } = string.Empty;
    public string posicao_atual_pedido { get; set; } = string.Empty;
    public string qtitenspedido { get; set; } = string.Empty;
    public string quebra_pedido_frete { get; set; } = string.Empty;
    public string quebra_pedido_pre_venda { get; set; } = string.Empty;
    public string razao_social { get; set; } = string.Empty;
    public string retorno_motivo_bloqueio { get; set; } = string.Empty;
    public string status_pedido { get; set; } = string.Empty;
    public string status_processamento { get; set; } = string.Empty;
    public string tipo_prioridade_entrega_pedido { get; set; } = string.Empty;
    public List<SalesOrderItem> itens { get; set; }


}
