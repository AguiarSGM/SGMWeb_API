using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;

namespace PortalBusiness.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class OportunidadeController : ControllerBase
    {
        private readonly IOportunidadeService _oportunidadeservice;

        public OportunidadeController(IOportunidadeService oportunidadeservice)
        {
            _oportunidadeservice = oportunidadeservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetOportunidadesByParameters([FromQuery] string clientCode, string unidCode, string rcaCode = "")
        {
            try
            {
                var userIdClaim = User.FindFirst("UserId");

                var parameters = new Parameters
                {
                    Id = Int32.Parse(clientCode),
                    CodigoUnidade = Int32.Parse(unidCode),
                    CodigoRca = String.IsNullOrEmpty(rcaCode) ? Int32.Parse(userIdClaim.Value) : Int32.Parse(rcaCode)
                };

                var result = await _oportunidadeservice.GetOportunidadeByParametersServiceAsync(parameters);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllOportunidades()
        {
            try
            {
                var result = await _oportunidadeservice.GetAllOportunidadesServiceAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOportunidade(int id)
        {
            try
            {
                await _oportunidadeservice.DeleteOportunidadeServiceAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertOportunidade([FromBody] Oportunidade oportunidade)
        {
            try
            {
                var insertedId = await _oportunidadeservice.InsertOportunidadeServiceAsync(oportunidade);

                oportunidade.Idoportunidade = insertedId;

                return CreatedAtAction(nameof(GetOportunidadesByParameters), new { id = insertedId }, oportunidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOportunidade(int id, [FromBody] Oportunidade oportunidade)
        {
            try
            {
                oportunidade.Idoportunidade = id;
                await _oportunidadeservice.UpdateOportunidadeServiceAsync(oportunidade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
        }
    }
}
