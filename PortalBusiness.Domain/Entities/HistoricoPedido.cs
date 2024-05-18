namespace PortalBusiness.Domain.Entities;

public class HistoricoPedido
{
    public DateTime DataPedido { get; set; }
    public long NumeroPedido { get; set; }
    public string OrigemVenda { get; set; }
    public string DescricaoCondVenda { get; set; }
    public string DescricaoPlanoPagamento { get; set; }
    public string Cobranca { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal PesoBruto { get; set; }
    public string Observacoes { get; set; }
    public string Situacao { get; set; }
    public string NumeroPedidoCliente { get; set; }
    public List<HistoricoPedidoItem> Itens { get; set; }
}
