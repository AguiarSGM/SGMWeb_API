using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class AddressService: IAddressService
{
    private readonly IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task<IEnumerable<Address>> GetAddressAsync(int id)
    {
        return await _addressRepository.GetAddressRepositoryAsync(id);
    }
}
