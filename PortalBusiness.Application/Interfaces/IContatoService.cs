using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IContatoService
{
    Task<IEnumerable<Contato>> GetContatoServiceAsync();
    Task<IEnumerable<Contato>> GetContatoByClienteIdServiceAsync(int clienteid);
    Task<int> InsertContatoServiceAsync(Contato contato);
    Task UpdateContatoServiceAsync(Contato contato);
    Task DeleteContatoServiceAsync(int id);
}
