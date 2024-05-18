using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Application.Services;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentService _departmentService;
    public DepartmentsController (IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpGet("departments")]
    public async Task<IActionResult> GetDepartments()
    {
        try
        {
            var departments = await _departmentService.GetDepartmentsAsync();
            return Ok(departments);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
