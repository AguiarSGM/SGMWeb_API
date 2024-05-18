using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Entities.Auth;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IUserRepository
{
    Task<AuthOutput> FindByUsernameAsync(AuthInput authInput);
}
