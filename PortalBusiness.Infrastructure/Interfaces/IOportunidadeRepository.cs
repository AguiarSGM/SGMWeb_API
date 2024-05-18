using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IOportunidadeRepository
{
    Task<IEnumerable<Oportunidade>> GetOportunidadetbyParametersRepositoryAsync(Parameters parameters);
    Task<IEnumerable<Oportunidade>> GetAllOportunidadesRepositoryAsync();
    Task DeleteOportunidadeRepositoryAsync(int id);
    Task<int> InsertOportunidadeRepositoryAsync(Oportunidade oportunidade);
    Task UpdateOportunidadeRepositoryAsync(Oportunidade oportunidade);
}
