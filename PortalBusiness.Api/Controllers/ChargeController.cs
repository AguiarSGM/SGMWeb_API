using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Application.Services;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
[Authorize]
public class ChargeController : ControllerBase
{
    private readonly IChargesService _chargesService;

    public ChargeController(IChargesService chargesService)
    {
        _chargesService = chargesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCharge([FromQuery] string clientCode, [FromQuery] string rcaCode)
    {
        try
        {
            var charges = await _chargesService.GetChargesServiceAsync(clientCode, rcaCode);
            return Ok(charges);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
