using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using System.Net;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController (IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("products/resume")]
    public IActionResult ProductsResume(
            [FromQuery] string codigoUnidade = "",
            [FromQuery] string codigoCliente = "",
            [FromQuery] string acrescimoDesconto = "",
            [FromQuery] string codigoRegiao = "",
            [FromQuery] string codigoDepartamento = "",
            [FromQuery] string codigoSecao = "",
            [FromQuery] string codigoCategoria = "",
            [FromQuery] string codigoSubCategoria = "",
            [FromQuery] string codigoMarca = "",
            [FromQuery] string codigoFornecedor = "",
            [FromQuery] string estoque = "",
            [FromQuery] string mixCliente = "")
    {
        Dictionary<string, string> optionals = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(codigoDepartamento))
        {
            optionals["CODIGODEPARTAMENTO"] = codigoDepartamento;
        }
        if (!string.IsNullOrEmpty(codigoSecao))
        {
            optionals["CODIGOSECAO"] = codigoSecao;
        }
        if (!string.IsNullOrEmpty(codigoCategoria))
        {
            optionals["CODIGOCATEGORIA"] = codigoCategoria;
        }
        if (!string.IsNullOrEmpty(codigoSubCategoria))
        {
            optionals["CODIGOSUBCATEGORIA"] = codigoSubCategoria;
        }
        if (!string.IsNullOrEmpty(codigoMarca))
        {
            optionals["CODIGOMARCA"] = codigoMarca;
        }
        if (!string.IsNullOrEmpty(codigoFornecedor))
        {
            optionals["CODIGOFORNECEDOR"] = codigoFornecedor;
        }
        if (!string.IsNullOrEmpty(estoque))
        {
            optionals["ESTOQUEDISPONIVEL"] = estoque;
        }
        if (!string.IsNullOrEmpty(mixCliente))
        {
            optionals["MIXCLIENTE"] = mixCliente;
        }
        try
        {
            var result = _productService.GetProductResumeServiceAsync(codigoUnidade, codigoCliente, acrescimoDesconto, codigoRegiao, optionals);
            return Ok(result.Result);
        }   
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
    
    [HttpGet("products")]
    public IActionResult ProductsFull(
        [FromQuery] string codigoCliente,
        [FromQuery] string codigoRegiao,
        [FromQuery] string uf,
        [FromQuery] string codigoAtividade,
        [FromQuery] string codigoRede,
        [FromQuery] string codigoRCA,
        [FromQuery] string codigoSupervisor,
        [FromQuery] string codigoPlanoPagamento,
        [FromQuery] string codigoProduto,
        [FromQuery] string codigoUnidade)
    {
        try
        {
            var result = _productService.GetProductsFullServiceAsync(codigoCliente, codigoRegiao, uf, codigoAtividade, codigoRede, codigoRCA, codigoSupervisor, codigoPlanoPagamento, codigoProduto, codigoUnidade);
            return Ok(result.Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    
    [HttpGet("products/validate")]
    public IActionResult ProductsValidate([FromQuery] string unitCode, [FromQuery] string productCode)
    {
        if (string.IsNullOrEmpty(unitCode) || string.IsNullOrEmpty(productCode))
        {
            return BadRequest();
        }

        try
        {
            var result = _productService.GetProductValidationServiceAsync(unitCode, productCode);
            return Ok(result.Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("products/offers")]
    public IActionResult ProductsOffers(
        [FromQuery] string codigoUnidade,
        [FromQuery] string codigoProduto,
        [FromQuery] string codigoCliente,
        [FromQuery] string codigoRegiao,
        [FromQuery] string ufCliente,
        [FromQuery] string codigoAtividade,
        [FromQuery] string codigoRede,
        [FromQuery] string codigoRCA,
        [FromQuery] string codigoSupervisor,
        [FromQuery] string codigoPlanoPagamento)
    {
        try
        {
            var result = _productService.GetProductsOffersServiceAsync(codigoUnidade, codigoProduto, codigoCliente, codigoRegiao, ufCliente, codigoAtividade, codigoRede, codigoRCA, codigoSupervisor, codigoPlanoPagamento);
            return Ok(result.Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("products/validate/{id}")]
    public IActionResult ProductValidateId(string id, [FromQuery] string unitCode, [FromQuery] string productCode)
    {
        if (string.IsNullOrEmpty(unitCode) || string.IsNullOrEmpty(productCode))
        {
            return BadRequest();
        }

        try
        {
            var result = _productService.GetProductValidateServiceAsync(unitCode, productCode, id);

            return Ok(result.Result);
        }
        catch (Exception)
        {
            return StatusCode((int)HttpStatusCode.NoContent);
        }
    }
}
