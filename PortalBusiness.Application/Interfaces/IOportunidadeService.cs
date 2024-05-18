using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;

namespace PortalBusiness.Application.Interfaces;

public interface IOportunidadeService
{
    Task<IEnumerable<Oportunidade>> GetOportunidadeByParametersServiceAsync(Parameters parameters);
    Task<IEnumerable<Oportunidade>> GetAllOportunidadesServiceAsync();
    Task DeleteOportunidadeServiceAsync(int id);
    Task<int> InsertOportunidadeServiceAsync(Oportunidade oportunidade);
    Task UpdateOportunidadeServiceAsync(Oportunidade oportunidade);
}
