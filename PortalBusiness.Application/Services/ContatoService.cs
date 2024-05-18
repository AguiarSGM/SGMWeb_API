using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class ContatoService : IContatoService
{
    private readonly IContatoRepository _contatoRepository;

    public ContatoService(IContatoRepository contatoRepository)
    {
        _contatoRepository = contatoRepository;
    }
    public async Task DeleteContatoServiceAsync(int id)
    {
        await _contatoRepository.DeleteContatoRepositoryAsync(id);
    }

    public async Task<IEnumerable<Contato>> GetContatoByClienteIdServiceAsync(int clienteid)
    {
        return await _contatoRepository.GetContatoByClienteIdRepositoryAsync(clienteid);
    }

    public async Task<IEnumerable<Contato>> GetContatoServiceAsync()
    {
        return await _contatoRepository.GetContatoRepositoryAsync();
    }

    public async Task<int> InsertContatoServiceAsync(Contato contato)
    {
        return await _contatoRepository.InsertContatoRepositoryAsync(contato);
    }

    public async Task UpdateContatoServiceAsync(Contato contato)
    {
        await _contatoRepository.UpdateContatoRepositoryAsync(contato);
    }
}
