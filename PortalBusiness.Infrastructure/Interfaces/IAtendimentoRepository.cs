using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IAtendimentoRepository
{
    Task<IEnumerable<Atendimento>> GetAtendimentoRepositoryAsync(Parameters parameters);
}
