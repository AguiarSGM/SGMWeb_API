using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IDashboardRepository
{
    Task<IEnumerable<Charges>> GetDashboardAsync();
    Task<ResumeMes> GetResumeMesRepositoryAsync(int id);
}
