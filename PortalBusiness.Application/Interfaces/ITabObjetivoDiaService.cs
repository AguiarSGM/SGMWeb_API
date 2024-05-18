using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface ITabObjetivoDiaService
{
    Task<TabObjetivoDiaIn> AddObjetivoDiaServiceAsync(TabObjetivoDiaIn entity);
    Task<TabObjetivoDiaIn> UpdateObjetivoDiaServiceAsync(TabObjetivoDiaIn entity);
    Task<TabObjetivoDiaIn> FindObjetivoDiaServiceAsync(TabObjetivoDiaIn entity);
    Task<TabObjetivoDiaOut> GetbyUnidadeServiceAsync(string unidade, string supervisor);
}
