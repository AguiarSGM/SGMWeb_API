using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface ISupplierService
{
    Task<IEnumerable<Supplier>> GetSupplierServiceAsync();
}
