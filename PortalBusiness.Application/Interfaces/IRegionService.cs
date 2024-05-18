using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IRegionService
{
    Task<IEnumerable<Regions>> GetRegionListServiceAsync(int id);
}
