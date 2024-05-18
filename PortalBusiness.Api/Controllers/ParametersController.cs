using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class ParametersController : ControllerBase
{
    private readonly IParameterService _parameterService;

    public ParametersController(IParameterService parameterService)
    {
        _parameterService = parameterService;
    }

    [HttpGet("params/{id}")]    
    public async Task<IActionResult> Parameter(string id, [FromQuery(Name = "name")] string nome = "")
    {
        try
        {
            if (string.IsNullOrEmpty(nome))
            {
                var parameters = await _parameterService.GetListAsync(id);
                return Ok(parameters);
            }
            else
            {
                var parameters = await _parameterService.GetAsync(id, nome);
                return Ok(parameters);
            }
            
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
