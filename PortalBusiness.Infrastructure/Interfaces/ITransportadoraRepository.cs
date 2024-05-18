using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface ITransportadoraRepository
{
    Task<IEnumerable<Transportadora>> GetAllTransportadoraRepositoryAsync();
}
