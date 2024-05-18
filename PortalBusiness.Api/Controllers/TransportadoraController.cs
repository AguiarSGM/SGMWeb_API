using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class TransportadoraController : ControllerBase
    {
        private readonly ITransportadoraService _transportadoraService;

        public TransportadoraController(ITransportadoraService transportadoraService)
        {
            _transportadoraService = transportadoraService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllTransportadora()
        {
            try
            {
                var result = await _transportadoraService.GetAllTransportadoraServiceAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }
    }
}
