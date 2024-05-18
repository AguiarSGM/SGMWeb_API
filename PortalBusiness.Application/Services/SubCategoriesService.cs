using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class SubCategoriesService : ISubCategoriesService
{
    private readonly ISubCategoriesRepository _subCategoriesRepository;
    public SubCategoriesService(ISubCategoriesRepository subCategoriesRepository)
    {
        _subCategoriesRepository = subCategoriesRepository;
    }
    public async Task<IEnumerable<SubCategories>> GetSubCategoriesServiceAsync(string sectionCode, string subcategories)
    {
        return await _subCategoriesRepository.GetSubCategoriesRepositoryAsync(sectionCode, subcategories);
    }
}
