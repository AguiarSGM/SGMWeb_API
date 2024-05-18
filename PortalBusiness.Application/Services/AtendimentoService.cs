using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;
using PortalBusiness.Infrastructure;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class AtendimentoService : IAtendimentoService
{
    private readonly IAtendimentoRepository _atendimentoRepository;
    public AtendimentoService(IAtendimentoRepository atendimentoRepository)
    {
        _atendimentoRepository = atendimentoRepository;
    }
    public async Task<IEnumerable<Atendimento>> GetAtendimentoServiceAsync(Parameters parameters)
    {
        return await _atendimentoRepository.GetAtendimentoRepositoryAsync(parameters);
    }
}
