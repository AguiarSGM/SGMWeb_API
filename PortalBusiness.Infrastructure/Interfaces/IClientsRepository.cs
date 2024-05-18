using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IClientsRepository
{
    Task<Client> GetClientbyIdRepositoryAsync(int id);
    Task<IEnumerable<Client>> GetClientsRepositoryAsync(int user);
    Task<ClientFull> GetFullRepositoryAsync(int id);
    Task<IEnumerable<Address>> GetAddressRepositoryAsync(object parameters);
    Task<IEnumerable<ClienteNew>> GetClienteNewRepositoryAsync();
    Task<ClienteNew> GetClienteNewByIdRepositoryAsync(int id);
    Task<int> InsertClienteNewRepositoryAsync(ClienteNew cliente);
    Task UpdateClienteNewRepositoryAsync(ClienteNew cliente);
    Task DeleteClienteNewRepositoryAsync(int id);
    Task<IEnumerable<Sac>> GetSacRepositoryAsync(string id);
    Task<IEnumerable<HistorioCobranca>> GetHistoricoCobrancaRepositoryAsync(string codigoCliente);

}
