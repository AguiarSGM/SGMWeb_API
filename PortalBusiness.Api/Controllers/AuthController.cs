using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PortalBusiness.Application.DTOs;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Constant;
using PortalBusiness.Domain.Entities.Auth;
using PortalBusiness.Infrastructure.Data.DataBase;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace PortalBusiness.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationServices _authenticationService;
        private readonly UserContext _userContext;

        public AuthController(IAuthenticationServices authenticationService, UserContext userContext)
        {
            _authenticationService = authenticationService;
            _userContext = userContext;
        }

        [HttpPost("authentication")]
        public async Task<IActionResult> Authentication([FromBody]AuthInput authInput)
        {
            try
            {
                var result = await _authenticationService.AuthenticateAsync(authInput);

                if (result == null)
                {
                    return Unauthorized();
                }                

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Falha na autenticação" });
            }
        }
    }
}
