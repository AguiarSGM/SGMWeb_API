using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet("clients/{id}/address")]
    public async Task<IActionResult> GetAddress(int id)
    {
        try
        {
            var result = await _addressService.GetAddressAsync(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
