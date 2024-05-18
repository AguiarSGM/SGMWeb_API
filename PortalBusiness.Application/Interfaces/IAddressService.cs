using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IAddressService
{
    Task<IEnumerable<Address>> GetAddressAsync(int id);
}
