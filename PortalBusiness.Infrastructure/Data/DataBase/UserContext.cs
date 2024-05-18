using Microsoft.AspNetCore.Http;
using PortalBusiness.Domain.Entities.Auth;

namespace PortalBusiness.Infrastructure.Data.DataBase;

public class UserContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserContext(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public AuthOutput AuthOutput
    {
        get
        {
            return _httpContextAccessor.HttpContext.Items["AuthOutput"] as AuthOutput;
        }
        set
        {
            _httpContextAccessor.HttpContext.Items["AuthOutput"] = value;
        }
    }
}
