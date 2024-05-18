using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IBrandsRepository
{
    Task<IEnumerable<Brand>> GetBrandsRepositoryAsync();
}
