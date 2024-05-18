using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Services;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
public class HealthController : ControllerBase
{
    private readonly HealthService _healthService;

    public HealthController(HealthService healthService)
    {
        _healthService = healthService;
    }

    [HttpGet]
    public async Task<IActionResult> CheckHealth()
    {
        try
        {
            var healthStatus = await _healthService.CheckHealthAsync();

            if (healthStatus.IsHealthy)
            {
                return Ok("Healthy");
            }
            else
            {
                return BadRequest("Unhealthy");
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
