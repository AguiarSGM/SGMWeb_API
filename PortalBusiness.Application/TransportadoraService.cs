using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application;

public class TransportadoraService : ITransportadoraService
{
    private readonly ITransportadoraRepository _transportadoraRepository;
    public TransportadoraService(ITransportadoraRepository transportadoraRepository)
    {
        _transportadoraRepository = transportadoraRepository;
    }
    public async Task<IEnumerable<Transportadora>> GetAllTransportadoraServiceAsync()
    {
        return await _transportadoraRepository.GetAllTransportadoraRepositoryAsync();
    }
}
