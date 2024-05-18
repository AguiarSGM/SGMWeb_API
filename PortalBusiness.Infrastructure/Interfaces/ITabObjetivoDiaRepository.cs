using PortalBusiness.Domain.Entities.SalesClass;
using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface ITabObjetivoDiaRepository
{
    Task<TabObjetivoDiaIn> AddObjetivoDiaRepositoryAsync(TabObjetivoDiaIn entity);
    Task<TabObjetivoDiaIn> UpdateObjetivoDiaRepositoryAsync(TabObjetivoDiaIn entity);
    Task<TabObjetivoDiaIn> FindObjetivoDiaRepositoryAsync(TabObjetivoDiaIn entity);
    Task<TabObjetivoDiaOut> GetbyUnidadeRepositoryAsync(string unidade, string supervisor);
}
