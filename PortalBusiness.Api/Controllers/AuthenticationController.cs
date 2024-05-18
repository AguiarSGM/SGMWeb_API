using Microsoft.AspNetCore.Mvc;
using PortalBusiness.Application.DTOs;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities.Auth;
using PortalBusiness.Infrastructure.Data.DataBase;
using System.Security.Authentication;

namespace PortalBusiness.Api.Controllers;

[Route("api/v1")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationServices _authenticationService;
    private readonly UserContext _userContext;

    public AuthenticationController(IAuthenticationServices authenticationService, UserContext userContext)
    {
        _authenticationService = authenticationService;
        _userContext = userContext;
    }

    [HttpPost("authentication")]
    public async Task<IActionResult> Authentication([FromBody] AuthInput authInput)
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
