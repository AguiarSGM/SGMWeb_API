namespace PortalBusiness.Domain.Entities;

public class Titulo
{
    public int Duplicata { get; set; }
    public string Parcela { get; set; }
    public string CodigoCobranca { get; set; }
    public string Cobranca { get; set; }
    public string ValorOriginal { get; set; }
    public int DiasAtraso { get; set; }
    public double ValorMulta { get; set; }
    public double ValorJuros { get; set; }
    public double ValorAtualizado { get; set; }
    public DateTime DataEmissao { get; set; }
    public DateTime DataVencimento { get; set; }
    public DateTime DataPagamento { get; set; }
    public string Situacao { get; set; }
    public string CodBarrasBoleto { get; set; }
}
