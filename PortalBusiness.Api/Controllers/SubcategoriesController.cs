using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class SubcategoriesController : ControllerBase
{
    private readonly ISubCategoriesService _subCategoriesService;
    public SubcategoriesController(ISubCategoriesService subCategoriesService)
    {
        _subCategoriesService = subCategoriesService;
    }

    [HttpGet("subcategories")]
    public async Task<IActionResult> GetSubcategories([FromQuery] string sectionCode = "", [FromQuery] string subcategories = "")
    {
        try
        {
            var client = await _subCategoriesService.GetSubCategoriesServiceAsync(sectionCode, subcategories);
            return Ok(client);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
