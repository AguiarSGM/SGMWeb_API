using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface ISupplierRepository
{
    Task<IEnumerable<Supplier>> GetSupplierRepositoryAsync();
}
