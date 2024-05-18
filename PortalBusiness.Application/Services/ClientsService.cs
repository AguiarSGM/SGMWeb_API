using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class ClientsService : IClientsService
{
    private readonly IClientsRepository _clientsRepository;

    public ClientsService(IClientsRepository clientsRepository)
    {
        _clientsRepository = clientsRepository;
    }

    public async Task DeleteClienteNewServiceAsync(int id)
    {
        await _clientsRepository.DeleteClienteNewRepositoryAsync(id);
    }

    public async Task<ClienteNew> GetClienteNewByIdServiceAsync(int id)
    {
        return await _clientsRepository.GetClienteNewByIdRepositoryAsync(id);
    }

    public async Task<IEnumerable<ClienteNew>> GetClienteNewServiceAsync()
    {
        return await _clientsRepository.GetClienteNewRepositoryAsync();
    }

    public async Task<Client> GetClientServiceAsync(int id)
    {
        return await _clientsRepository.GetClientbyIdRepositoryAsync(id);
    }

    public async Task<IEnumerable<HistorioCobranca>> GetHistoricoCobrancaServiceAsync(string codigoCliente)
    {
        return await _clientsRepository.GetHistoricoCobrancaRepositoryAsync(codigoCliente);
    }

    public Task<IEnumerable<Sac>> GetSacServiceAsync(string id)
    {
        return _clientsRepository.GetSacRepositoryAsync(id);
    }

    public async Task<int> InsertClienteNewServiceAsync(ClienteNew cliente)
    {
        return await _clientsRepository.InsertClienteNewRepositoryAsync(cliente);
    }

    public async Task<IEnumerable<Address>> RulesClientAddressServiceAsync(object parameters)
    {
        return await _clientsRepository.GetAddressRepositoryAsync(parameters);
    }

    public async Task<IEnumerable<Client>> RulesClientsServiceAsync(int idUser)
    {
        return await _clientsRepository.GetClientsRepositoryAsync(idUser);
    }

    public async Task<ClientFull> RulesFullClientServiceAsync(int id)
    {
        return await _clientsRepository.GetFullRepositoryAsync(id);
    }

    public async Task UpdateClienteNewServiceAsync(ClienteNew cliente)
    {
        await _clientsRepository.UpdateClienteNewRepositoryAsync(cliente);
    }
}
