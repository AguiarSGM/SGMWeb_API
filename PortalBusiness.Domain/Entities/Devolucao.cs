namespace PortalBusiness.Domain.Entities;

public class Devolucao
{
    public DateTime DtEnt { get; set; }
    public int NumNota { get; set; }
    public int CodProd { get; set; }
    public string Produto { get; set; }
    public int Qtd { get; set; }
    public decimal VlTotal { get; set; }    
    public string Motivo { get; set; }
}
