using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;
using PortalBusiness.Infrastructure;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class OportunidadeService : IOportunidadeService
{
    private readonly IOportunidadeRepository _oportunidadeRepository;
    public OportunidadeService(IOportunidadeRepository oportunidadeRepository)
    {
        _oportunidadeRepository = oportunidadeRepository;
    }

    public async Task<IEnumerable<Oportunidade>> GetOportunidadeByParametersServiceAsync(Parameters parameters)
    {
        return await _oportunidadeRepository.GetOportunidadetbyParametersRepositoryAsync(parameters);
    }

    public async Task<IEnumerable<Oportunidade>> GetAllOportunidadesServiceAsync()
    {
        return await _oportunidadeRepository.GetAllOportunidadesRepositoryAsync();
    }

    public async Task DeleteOportunidadeServiceAsync(int id)
    {
        await _oportunidadeRepository.DeleteOportunidadeRepositoryAsync(id);
    }

    public async Task<int> InsertOportunidadeServiceAsync(Oportunidade oportunidade)
    {
        return await _oportunidadeRepository.InsertOportunidadeRepositoryAsync(oportunidade);
    }

    public async Task UpdateOportunidadeServiceAsync(Oportunidade oportunidade)
    {
        await _oportunidadeRepository.UpdateOportunidadeRepositoryAsync(oportunidade);
    }
}
