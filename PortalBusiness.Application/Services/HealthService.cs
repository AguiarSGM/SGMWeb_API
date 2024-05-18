using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class HealthService: IHealthService
{
    private readonly IHealthRepository _healthRepository;

    public HealthService(IHealthRepository healthRepository)
    {
        _healthRepository = healthRepository;
    }

    public async Task<HealthStatus> CheckHealthAsync()
    {
        var isHealthy = await _healthRepository.CheckHealthAsync();

        return isHealthy;
    }
}
