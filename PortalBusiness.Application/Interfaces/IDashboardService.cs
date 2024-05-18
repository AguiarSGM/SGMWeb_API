using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IDashboardService
{
    Task<IEnumerable<Charges>> GetDashboardAsync();

    Task<ResumeMes> GetResumeMesServiceAsync(int id);
}
