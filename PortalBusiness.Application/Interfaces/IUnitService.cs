using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IUnitService
{
    Task<IEnumerable<Unit>> GetServiceAsync(int idUser);
}
