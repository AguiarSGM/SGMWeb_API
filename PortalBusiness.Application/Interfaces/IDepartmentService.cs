using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IDepartmentService
{
    Task<IEnumerable<Department>> GetDepartmentsAsync();
}
