using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardRepository _dashboardRepository;
        public DashboardService(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
        public async Task<IEnumerable<Charges>> GetDashboardAsync()
        {
            return await _dashboardRepository.GetDashboardAsync();
        }

        public async Task<ResumeMes> GetResumeMesServiceAsync(int id)
        {
            return await _dashboardRepository.GetResumeMesRepositoryAsync(id);
        }
    }
}
