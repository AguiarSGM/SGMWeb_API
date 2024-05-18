using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IAddressRepository
{
    Task<IEnumerable<Address>> GetAddressRepositoryAsync(int id);
}
