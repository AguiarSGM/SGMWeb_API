using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class UnitController : ControllerBase
{
    private readonly IUnitService _unitService;

    public UnitController(IUnitService unitService)
    {
        _unitService = unitService;
    }

    [HttpGet("unit")]
    public async Task<IActionResult> Unit()
    {
        try
        {
            var result = await _unitService.GetServiceAsync(Int32.Parse(idUser()));
            return Ok(result);
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
