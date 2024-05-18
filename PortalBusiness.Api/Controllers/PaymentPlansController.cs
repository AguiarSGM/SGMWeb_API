using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class PaymentPlansController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentPlansController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpGet("payment-plans")]
    public async Task<IActionResult> GetPayment([FromQuery] string clientCode = "", string chargeCode = "", string rcaCode = "")
    {
        try
        {
            var payment = await _paymentService.GetPaymentAsync(clientCode, chargeCode, rcaCode);
            return Ok(payment);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("payment-plans/list")]
    public async Task<IActionResult> GetPaymentList()
    {
        try
        {
            var payment = await _paymentService.GetPaymentEAsync();
            return Ok(payment);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
}
