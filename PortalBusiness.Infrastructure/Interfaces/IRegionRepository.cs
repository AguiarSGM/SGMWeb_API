using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IRegionRepository
{
    Task<IEnumerable<Regions>> GetRegionListAsync(int id);
}
