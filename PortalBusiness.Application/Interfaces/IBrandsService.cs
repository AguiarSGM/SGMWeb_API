using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IBrandsService
{
    Task<IEnumerable<Brand>> GetBrandsAsync();
}
