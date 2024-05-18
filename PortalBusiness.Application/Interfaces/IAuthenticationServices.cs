using PortalBusiness.Application.DTOs;
using PortalBusiness.Domain.Entities.Auth;

namespace PortalBusiness.Application.Interfaces;

public interface IAuthenticationServices
{
    Task<AuthOutput> AuthenticateAsync(AuthInput request);
}
