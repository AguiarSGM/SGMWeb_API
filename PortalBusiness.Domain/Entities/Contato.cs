using System.ComponentModel.DataAnnotations;

namespace PortalBusiness.Domain.Entities;

public class Contato
{
    public int Id { get; set; }
    public int Cliente_Id { get; set; }
    public string NomeContato { get; set; }
    public string CelularContato { get; set; }
    public string FixoContato { get; set; }
    public string EmailContato { get; set; }
    public string Tipo { get; set; }
    public string Status { get; set; }
}
