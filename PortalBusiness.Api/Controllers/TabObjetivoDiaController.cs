using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
[Authorize]
public class TabObjetivoDiaController : ControllerBase
{
    private readonly ITabObjetivoDiaService _tabObjetivoDiaService;
    public TabObjetivoDiaController(ITabObjetivoDiaService tabObjetivoDiaService)
    {
        _tabObjetivoDiaService = tabObjetivoDiaService;
    }

    [HttpPost]
    public async Task<IActionResult> AddObjetivoDia([FromBody] TabObjetivoDiaIn tabObjetivoDia)
    {
        try
        {
            var result = new TabObjetivoDiaIn();

            var tabOjetivo = await _tabObjetivoDiaService.FindObjetivoDiaServiceAsync(tabObjetivoDia);

            if (tabOjetivo == null)
            {
                result = await _tabObjetivoDiaService.AddObjetivoDiaServiceAsync(tabObjetivoDia);
            }
            else
            {
                result = tabOjetivo;
            }
            
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{unidade}/{supervisor}")]
    public async Task<IActionResult> GetbyUnidade(string unidade, string supervisor)
    {
        try
        {
            var result = await _tabObjetivoDiaService.GetbyUnidadeServiceAsync(unidade, supervisor);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
