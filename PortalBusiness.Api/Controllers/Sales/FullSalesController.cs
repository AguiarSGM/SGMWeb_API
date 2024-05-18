using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers.Sales;

[Route("api/v1")]
[ApiController]
[Authorize]
public class FullSalesController : ControllerBase
{
    private readonly ISalesService _salesService;
    public FullSalesController(ISalesService salesService)
    {
        _salesService = salesService;
    }


    [HttpGet("sales/{rcaOrderCode}")]
    public async Task<IActionResult> FullSalesRCA(string rcaOrderCode)
    {
        try
        {
            var result = await _salesService.GetSalesFullServiceAsync(rcaOrderCode);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    
}
