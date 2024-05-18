using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface ICategoriesService
{
    Task<IEnumerable<Category>> GetCategoriesSerivceAsync(int sectionCode);
}
