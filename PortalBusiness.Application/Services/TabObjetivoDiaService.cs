using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class TabObjetivoDiaService : ITabObjetivoDiaService
{
    private readonly ITabObjetivoDiaRepository _tabObjetivoDiaRepository;
    public TabObjetivoDiaService(ITabObjetivoDiaRepository tabObjetivoDiaRepository)
    {
        _tabObjetivoDiaRepository = tabObjetivoDiaRepository;
    }
    public async Task<TabObjetivoDiaIn> AddObjetivoDiaServiceAsync(TabObjetivoDiaIn entity)
    {
        return await _tabObjetivoDiaRepository.AddObjetivoDiaRepositoryAsync(entity);
    }

    public async Task<TabObjetivoDiaIn> FindObjetivoDiaServiceAsync(TabObjetivoDiaIn entity)
    {
        return await _tabObjetivoDiaRepository.FindObjetivoDiaRepositoryAsync(entity);
    }

    public async Task<TabObjetivoDiaOut> GetbyUnidadeServiceAsync(string unidade, string supervisor)
    {
        return await _tabObjetivoDiaRepository.GetbyUnidadeRepositoryAsync(unidade, supervisor);
    }

    public async Task<TabObjetivoDiaIn> UpdateObjetivoDiaServiceAsync(TabObjetivoDiaIn entity)
    {
        return await _tabObjetivoDiaRepository.UpdateObjetivoDiaRepositoryAsync(entity);
    }
}
