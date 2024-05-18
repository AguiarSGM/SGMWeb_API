using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IHealthRepository
{
    Task<HealthStatus> CheckHealthAsync();
}
