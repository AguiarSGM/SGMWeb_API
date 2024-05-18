using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class RegionService : IRegionService
{
    private readonly IRegionRepository _regionRepository;
    public RegionService (IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async Task<IEnumerable<Regions>> GetRegionListServiceAsync(int id)
    {
        return await _regionRepository.GetRegionListAsync(id);
    }
}
