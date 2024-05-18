using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IChargesRepository
{
    Task<IEnumerable<Charges>> GetChargesARepositoryAsync(string clientCode);

    Task<IEnumerable<Charges>> GetChargesBRepositoryAsync(string clientCode, string rcaCode);

    Task<IEnumerable<Charges>> GetChargesCRepositoryAsync(string clientCode);
}
