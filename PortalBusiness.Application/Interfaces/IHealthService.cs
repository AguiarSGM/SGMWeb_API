using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IHealthService
{
    Task<HealthStatus> CheckHealthAsync();
}
