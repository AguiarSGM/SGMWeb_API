using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces
{
    public interface ISectionService
    {
        Task<IEnumerable<Sections>> GetSectionsAsync(string departmentCode);
    }
}
