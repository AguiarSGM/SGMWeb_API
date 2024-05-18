using Microsoft.AspNetCore.Mvc;

namespace PortalBusiness.Api.Controllers.Sales;

[Route("api/v1")]
[ApiController]
public class SalesItensDetailController : ControllerBase
{
    [HttpPost("sales/{rcaOrderCode}/itens")]
    public IActionResult InsertSalesItens(string rcaOrderCode)
    {
        return Ok("Post Controller");
    }

    [HttpPut("sales/{rcaOrderCode}/itens/{code}/{product}")]
    public IActionResult UpdateSalesItens(string rcaOrderCode, string code, string product)
    {
        return Ok("Put Controller");
    }

    [HttpDelete("sales/{rcaOrderCode}/itens")]
    public IActionResult DeleteSalesItens(string rcaOrderCode)
    {
        return Ok("Delete Controller");
    }
}
