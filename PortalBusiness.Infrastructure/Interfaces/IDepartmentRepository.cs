using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IDepartmentRepository
{
    Task<IEnumerable<Department>> GetDepartmentsAsync();
}
