using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Application.Services;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class BrandsController : ControllerBase
{
    private readonly IBrandsService _brandsService;

    public BrandsController(IBrandsService brandsService)
    {
        _brandsService = brandsService;
    }

    [HttpGet("brands")]
    public async Task<IActionResult> GetBrands()
    {
        try
        {
            var brands = await _brandsService.GetBrandsAsync();
            return Ok(brands);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
