using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class RegionsController : ControllerBase
{
    private readonly IRegionService _regionService;

    public RegionsController(IRegionService regionService)
    {
        _regionService = regionService;
    }

    [HttpGet("regions/list")]
    public async Task<IActionResult> Regions()
    {
        var region = await _regionService.GetRegionListServiceAsync(Int32.Parse(idUser()));

        if (region == null)
        {
            return NotFound();
        }

        return Ok(region);
    }

    private string idUser()
    {
        var userIdClaim = User.FindFirst("userId");

        return userIdClaim.Value;
    }
}
