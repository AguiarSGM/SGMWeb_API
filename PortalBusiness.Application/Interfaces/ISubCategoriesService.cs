using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface ISubCategoriesService
{
    Task<IEnumerable<SubCategories>> GetSubCategoriesServiceAsync(string sectionCode, string subcategories);
}
