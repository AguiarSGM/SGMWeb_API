using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IUnitRepository
{
    Task<IEnumerable<Unit>> GetRepositoryAsync(int idUser);
}
