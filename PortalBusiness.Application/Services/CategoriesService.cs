using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class CategoriesService: ICategoriesService
{
    private readonly ICategoriesRepository _categoriesRepository;

    public CategoriesService(ICategoriesRepository categoriesRepository)
    {
        _categoriesRepository = categoriesRepository;
    }

    public async Task<IEnumerable<Category>> GetCategoriesSerivceAsync(int sectionCode)
    {
        return await _categoriesRepository.GetCategoriesRepositoryAsync(sectionCode);
    }
}
