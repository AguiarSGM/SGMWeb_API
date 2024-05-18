using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IClientsService
{
    Task<Client> GetClientServiceAsync(int id);
    Task<IEnumerable<Client>> RulesClientsServiceAsync(int idUser);
    Task<ClientFull> RulesFullClientServiceAsync(int id);
    Task<IEnumerable<Address>> RulesClientAddressServiceAsync(object parameters);
    Task<IEnumerable<ClienteNew>> GetClienteNewServiceAsync();
    Task<ClienteNew> GetClienteNewByIdServiceAsync(int id);
    Task<int> InsertClienteNewServiceAsync(ClienteNew cliente);
    Task UpdateClienteNewServiceAsync(ClienteNew cliente);
    Task DeleteClienteNewServiceAsync(int id);

    Task<IEnumerable<Sac>> GetSacServiceAsync(string id);
    Task<IEnumerable<HistorioCobranca>> GetHistoricoCobrancaServiceAsync(string codigoCliente);
}
