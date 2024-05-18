using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities.SalesClass;

namespace PortalBusiness.Api.Controllers.Sales;

[Route("api/v1/[controller]")]
[ApiController]
[Authorize]
public class SalesController : ControllerBase
{
    private readonly ISalesService _salesService;
    private readonly IPedidoService _pedidoService;
    public SalesController(ISalesService salesService, IPedidoService pedidoService)
    {
        _salesService = salesService;
        _pedidoService = pedidoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetSales()
    {
        try
        {            
            var result = await _salesService.GetServiceAsync(idUser());
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("{id}/itens")]
    public async Task<IActionResult> GetSalesItens(long id)
    {
        try
        {
            var result = await _salesService.GetSalesItensServiceAsync(Int32.Parse(idUser()), id.ToString());
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> InsertSales([FromBody] TabPedido pedido)
    {
        try
        {
            pedido.CodigoRca = Int32.Parse(idRca());
            pedido.IdUsuario = Int32.Parse(idUser());

            var salesInsertOut = await _salesService.InsertSalesServiceAsync(pedido);

            return Ok(salesInsertOut);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPut("{rcaOrderCode}")]
    public async Task<IActionResult> UpdateSales(string rcaOrderCode, [FromBody] TabPedido pedido)
    {
        try
        {
            
            pedido.CodigoPedidoRca = Int32.Parse(rcaOrderCode);
            
            _salesService.UpdateSalesServiceAsync(pedido);

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpDelete("{rcaOrderCode}")]
    public async Task<IActionResult> DeleteSales(int rcaOrderCode)
    {
        try
        {
            await _salesService.DeleteSalesServiceAsync(rcaOrderCode);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpDelete("cancel/{codigoPedidoRCA}")]
    public async Task<IActionResult> CancelSales(string codigoPedidoRCA)
    {
        // Implemente a lógica para a rota DELETE /api/sales/cancel/{codigoPedidoRCA} aqui
        return NoContent();
    }

    [HttpPost("{rcaOrderCode}/itens")]
    public async Task<IActionResult> InsertSalesItens(string rcaOrderCode)
    {
        // Implemente a lógica para a rota POST /api/sales/{rcaOrderCode}/itens aqui
        return CreatedAtAction(nameof(GetSalesItens), new { id = 1 }, null);
    }

    [HttpPut("{rcaOrderCode}/itens/{code}/{product}")]
    public async Task<IActionResult> UpdateSalesItens(string rcaOrderCode, string code, string product)
    {
        // Implemente a lógica para a rota PUT /api/sales/{rcaOrderCode}/itens/{code}/{product} aqui
        return NoContent();
    }

    [HttpDelete("{rcaOrderCode}/itens")]
    public async Task<IActionResult> DeleteSalesItens(string rcaOrderCode)
    {
        // Implemente a lógica para a rota DELETE /api/sales/{rcaOrderCode}/itens aqui
        return NoContent();
    }

    private string idUser()
    {
        var userIdClaim = User.FindFirst("userId");

        return userIdClaim.Value;
    }

    private string idRca()
    {
        var userIdClaim = User.FindFirst("userCodRca");

        return userIdClaim.Value;
    }
}
