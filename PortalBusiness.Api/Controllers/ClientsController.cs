using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Application.Services;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
[Authorize]
public class ClientsController : ControllerBase
{
    private readonly IContatoService _contatoService;
    private readonly IClientsService _clientsService;
    private readonly IAtendimentoService _atendimentoService;
    private int _userID;
    public ClientsController(IClientsService clientsService, 
                             IAtendimentoService atendimentoService, 
                             IContatoService contatoService)
    {
        _clientsService = clientsService;
        _atendimentoService = atendimentoService;
        _contatoService = contatoService;
    }

    [HttpGet("clients/resume")]
    public async Task<IActionResult> GetClients()
    {
        try
        {
            var clients = await _clientsService.RulesClientsServiceAsync(Int32.Parse(idUser()));
            return Ok(clients);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("clients/{id}")]
    public async Task<IActionResult> GetClient(int id)
    {
        try
        {
            var client = await _clientsService.RulesFullClientServiceAsync(id);
            return Ok(client);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("clients/clientesnew/{id}")]
    public async Task<IActionResult> GetClientNewId(int id)
    {
        try
        {
            var client = await _clientsService.GetClienteNewByIdServiceAsync(id);
            return Ok(client);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("clients/clientesnew")]
    public async Task<IActionResult> GetClientes()
    {
        try
        {
            var result = await _clientsService.GetClienteNewServiceAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("clients/sac/{clienteID}")]
    public async Task<IActionResult> GetClientesSac(string clienteID)
    {
        try
        {
            var result = await _clientsService.GetSacServiceAsync(clienteID);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("clients/{idCliente}/atendimento")]
    public async Task<IActionResult> GetAtendimento(int idCliente, [FromQuery(Name = "codigoUnidade")] int codigoUnidade)
    {
        try
        {
            var parameters = new Parameters
            {
                Id = idCliente,
                CodigoUnidade = codigoUnidade,
                CodigoRca = Int32.Parse(idRca())
            };

            var client = await _atendimentoService.GetAtendimentoServiceAsync(parameters);
            return Ok(client);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClientesNew(int id)
    {
        try
        {
            await _clientsService.DeleteClienteNewServiceAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpPost("clients/clientesnew")]
    public async Task<IActionResult> InsertClienteNew([FromBody] ClienteNew clienteNew)
    {
        try
        {
            var insertedId = await _clientsService.InsertClienteNewServiceAsync(clienteNew);

            return CreatedAtAction(nameof(GetClientNewId), new { id = insertedId }, clienteNew);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }

    [HttpGet("clients/historicocobranca/{codigoCliente}")]
    public async Task<IActionResult> HistoricoCobranca(string codigoCliente)
    {
        try
        {
            var result = await _clientsService.GetHistoricoCobrancaServiceAsync(codigoCliente);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClienteNew(int id, [FromBody] ClienteNew clienteNew)
    {
        try
        {
            clienteNew.Id = id;
            await _clientsService.UpdateClienteNewServiceAsync(clienteNew);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException?.Message);
        }
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
