using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IContatoRepository
{
    Task<IEnumerable<Contato>> GetContatoRepositoryAsync();
    Task<IEnumerable<Contato>> GetContatoByClienteIdRepositoryAsync(int id);
    Task<int> InsertContatoRepositoryAsync(Contato contato);
    Task UpdateContatoRepositoryAsync(Contato contato);
    Task DeleteContatoRepositoryAsync(int id);
}
