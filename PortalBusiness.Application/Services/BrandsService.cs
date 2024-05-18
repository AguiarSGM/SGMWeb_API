using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class BrandsService: IBrandsService
{
    private readonly IBrandsRepository _brandsRepository;

    public BrandsService(IBrandsRepository brandsRepository)
    {
        _brandsRepository = brandsRepository;
    }

    public async Task<IEnumerable<Brand>> GetBrandsAsync()
    {
        return await _brandsRepository.GetBrandsRepositoryAsync();
    }
}
