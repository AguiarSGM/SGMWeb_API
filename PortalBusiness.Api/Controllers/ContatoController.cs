using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Application.Services;
using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoService _contatoService;
        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        [HttpGet("contato/{idCliente}")]
        public async Task<IActionResult> GetContatoIdClient(int idCliente)
        {
            try
            {
                var client = await _contatoService.GetContatoByClienteIdServiceAsync(idCliente);
                return Ok(client);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetContato()
        {
            try
            {
                var client = await _contatoService.GetContatoServiceAsync();
                return Ok(client);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertContato([FromBody] Contato contato)
        {
            try
            {
                var insertedId = await _contatoService.InsertContatoServiceAsync(contato);

                return CreatedAtAction(nameof(GetContatoIdClient), new { id = insertedId }, contato);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOportunidade(int id, [FromBody] Contato contato)
        {
            try
            {
                contato.Id = id;
                await _contatoService.UpdateContatoServiceAsync(contato);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }
    }
}
