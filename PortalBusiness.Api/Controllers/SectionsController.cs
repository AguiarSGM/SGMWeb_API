using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class SectionsController : ControllerBase
{
    private readonly ISectionService _sectionService;

    public SectionsController(ISectionService sectionService)
    {
        _sectionService = sectionService;
    }

    [HttpGet("sections")]
    public async Task<IActionResult> GetSections([FromQuery] string departmentCode = "")
    {
        try
        {
            var result = await _sectionService.GetSectionsAsync(departmentCode);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
