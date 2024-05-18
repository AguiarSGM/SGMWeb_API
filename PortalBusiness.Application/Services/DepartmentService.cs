using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Services;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepository _departmentRepository;
    public DepartmentService(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }
    public async Task<IEnumerable<Department>> GetDepartmentsAsync()
    {
        return await _departmentRepository.GetDepartmentsAsync();
    }
}
