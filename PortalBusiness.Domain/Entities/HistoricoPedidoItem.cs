namespace PortalBusiness.Domain.Entities;

public class HistoricoPedidoItem
{
    public int CodigoProduto { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public string Unidade { get; set; }
    public string Embalagem { get; set; }
    public decimal Total { get; set; }
}
