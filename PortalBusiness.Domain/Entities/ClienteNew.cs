using System.ComponentModel.DataAnnotations;

namespace PortalBusiness.Domain.Entities;

public class ClienteNew
{
    public int Id { get; set; }
    public string CpfCnpj { get; set; }
    public string Ie { get; set; }
    public string TipoPessoa { get; set; }
    public string Contribuinte { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string Cep { get; set; }
    public string Cidade { get; set; }
    public string Endereco { get; set; }
    public string Numero { get; set; }
    public string Uf { get; set; }
    public string Status { get; set; } = "A";
    public virtual IEnumerable<Contato> Contatos { get; set; } = Enumerable.Empty<Contato>();
}
