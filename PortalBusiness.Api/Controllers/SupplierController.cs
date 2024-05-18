using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class SupplierController : ControllerBase
{
    private readonly ISupplierService _supplierService;

    public SupplierController(ISupplierService supplierServic)
    {
        _supplierService = supplierServic;
    }

    [HttpGet("suppliers")]
    public async Task<IActionResult> GetSuppliers()
    {
        try
        {
            var brands = await _supplierService.GetSupplierServiceAsync();
            return Ok(brands);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
