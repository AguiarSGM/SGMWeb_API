using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface ISubCategoriesRepository
{
    Task<IEnumerable<SubCategories>> GetSubCategoriesRepositoryAsync(string sectionCode, string subcategories);
}
