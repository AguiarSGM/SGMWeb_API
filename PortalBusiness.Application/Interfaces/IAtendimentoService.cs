using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;

namespace PortalBusiness.Application.Interfaces;

public interface IAtendimentoService
{
    Task<IEnumerable<Atendimento>> GetAtendimentoServiceAsync(Parameters parameters);
}
