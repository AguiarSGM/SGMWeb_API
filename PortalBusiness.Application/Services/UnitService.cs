using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class UnitService : IUnitService
{
    private readonly IUnitRepository _unitRepository;
    public UnitService(IUnitRepository unitRepository)
    {
        _unitRepository = unitRepository;
    }
    public async Task<IEnumerable<Unit>> GetServiceAsync(int idUser)
    {
        return await _unitRepository.GetRepositoryAsync(idUser);
    }
}
