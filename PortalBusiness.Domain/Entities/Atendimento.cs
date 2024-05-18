namespace PortalBusiness.Domain.Entities;

public class Atendimento
{

    public int codigo_cliente { get; set; }
    public string razao_social { get; set; }
    public string fantasia { get; set; }
    public string cnpj { get; set; }
    public string endereco_entrega { get; set; }
    public string numero_entrega { get; set; }
    public string bairro_entrega { get; set; }
    public string cidade_entrega { get; set; }
    public string uf_entrega { get; set; }
    public decimal limite_credito { get; set; }
    public decimal saldo_disponivel { get; set; }
    public DateTime data_primeira_compra { get; set; }
    public DateTime data_ultima_compra { get; set; }
    public int tempo_relacionamento { get; set; }
    public int dias_sem_compra { get; set; }
    public decimal media_atraso { get; set; }
    public decimal titulos_vencidos { get; set; }
    public decimal titulos_a_vencer { get; set; }
    public decimal maior_compra { get; set; }
    public decimal menor_compra { get; set; }
    public decimal ticket_medio { get; set; }
    public decimal prazo_medio_pagamento { get; set; }
    public decimal mix_ideal { get; set; }
    public List<CardDevolucao>? CardDevolucao { get; set; } = new List<CardDevolucao>();
    public Vendas? vendas { get; set; }
    public List<HistoricoPedido>? pedidos { get; set; } = new List<HistoricoPedido>();
    public List<Oportunidade>? oportunidades { get; set; } = new List<Oportunidade>();
    public List<Titulo>? Titulos { get; set; } = new List<Titulo>();
    public List<Devolucao>? Devolucoes { get; set; } = new List<Devolucao>();
    public List<MixIdeal>? MixIdealItens { get; set; } = new List<MixIdeal>();

}

