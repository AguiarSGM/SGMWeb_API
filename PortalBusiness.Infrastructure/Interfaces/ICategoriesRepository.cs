using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface ICategoriesRepository
{
    Task<IEnumerable<Category>> GetCategoriesRepositoryAsync(int sectionCode);
}
