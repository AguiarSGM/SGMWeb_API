using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Application.Services;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class DashboardController : ControllerBase
{
    private readonly IDashboardService _dashboardService;

    public DashboardController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    [HttpGet("dashboard")]
    public async Task<IActionResult> GetDashboard()
    {
        try
        {
            var items = await _dashboardService.GetDashboardAsync();
            return Ok(items);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("dashboard/resumomes")]
    public async Task<IActionResult> GetResumoMes()
    {
        try
        {
            var items = await _dashboardService.GetResumeMesServiceAsync(Int32.Parse(idUser()));
            return Ok(items);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    private string idUser()
    {
        var userIdClaim = User.FindFirst("userId");

        return userIdClaim.Value;
    }
}
