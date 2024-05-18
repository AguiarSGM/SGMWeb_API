using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface ITransportadoraService
{
    Task<IEnumerable<Transportadora>> GetAllTransportadoraServiceAsync();
}
