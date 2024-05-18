namespace PortalBusiness.Domain.Entities;

public class ResumeMes
{
    public int IdUsuario { get; set; }
    public decimal ValorFaturadoMes { get; set; }
    public decimal PercentualCrescimento { get; set; }
    public int QuantidadeClientePositivoMes { get; set; }
    public decimal PercentCrescimentoPositivacao { get; set; }
    public decimal TicketMedio { get; set; }
    public decimal ProjecaoResultado { get; set; }
    public int QtCliCarteira { get; set; }

}
