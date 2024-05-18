using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface ISectionRepository
{
    Task<IEnumerable<Sections>> GetSectionsAsync(string departmentCode);
}
