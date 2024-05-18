namespace PortalBusiness.Domain.Entities;

public class Oportunidade
{
    public int Idoportunidade { get; set; }
    public string Tipo { get; set; }
    public int Codigo { get; set; }
    public string Descricao { get; set; }
    public string Observacao { get; set; }
    public long CodigoCliente { get; set; }
    public string CodigoUnidade { get; set; }
    public long CodigoRca { get; set; }
    public string Status { get; set; }
}
