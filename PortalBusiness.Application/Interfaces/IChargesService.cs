using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IChargesService
{
    Task<IEnumerable<Charges>> GetChargesServiceAsync(string clientCode, string rcaCode);
}
