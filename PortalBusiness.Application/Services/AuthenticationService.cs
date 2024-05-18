using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using PortalBusiness.Application.DTOs;
using PortalBusiness.Domain.Constant;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Infrastructure.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using PortalBusiness.Domain.Entities.Auth;
using PortalBusiness.Shared;
using PortalBusiness.Domain.Entities;
using Microsoft.Extensions.Configuration;
using PortalBusiness.Domain.Models;

namespace PortalBusiness.Application.Services;

public class AuthenticationService: IAuthenticationServices
{
    private readonly IUserRepository _userRepository;
    private readonly IConfiguration _configuration;
    public AuthenticationService(IUserRepository userRepository, IConfiguration configuration)
    {
        _userRepository = userRepository;
        _configuration = configuration;
    }

    public async Task<AuthOutput> AuthenticateAsync(AuthInput request)
    {
        try
        {
            var user = await _userRepository.FindByUsernameAsync(request);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (user.Password != request.Password)
            {
                throw new Exception("Not Authorized");
            }

            if (user.UserSituation != "A")
            {
                throw new Exception("Not Authorized");
            }

            var token = GenerateJwtToken(user);


            user.Token = token.Token;
            user.Expiration = token.Expiration;

            return user;
        }
        catch (Exception ex)
        {
            throw new Exception("Not Authorized");
        }
    }

    private TokenModel GenerateJwtToken(AuthOutput user)
    {
        var claims = new[]
        {
            new Claim("userId", user.ID.ToString()),
            new Claim("userLogin", user.Login),
            new Claim("userCodRca", user.codRCA.ToString()),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));

        var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

        var expiration = DateTime.UtcNow.AddHours(24);

        JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: credentials
            );

        var resultToken = new JwtSecurityTokenHandler().WriteToken(token);

        return new TokenModel()
        {
            Token = resultToken,
            Expiration = expiration
        };
        
    }
}
