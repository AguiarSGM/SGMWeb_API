using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class SectionService : ISectionService
{
    private readonly ISectionRepository _sectionRepository;

    public SectionService(ISectionRepository sectionRepository)
    {
        _sectionRepository = sectionRepository;
    }

    public async Task<IEnumerable<Sections>> GetSectionsAsync(string departmentCode)
    {
        return await _sectionRepository.GetSectionsAsync(departmentCode);
    }
}
