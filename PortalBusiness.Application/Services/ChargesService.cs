using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;
using System.Security.Cryptography;

namespace PortalBusiness.Application.Services;

public class ChargesService : IChargesService
{
    private readonly IChargesRepository _chargesRepository;

    public ChargesService(IChargesRepository chargesRepository)
    {
        _chargesRepository = chargesRepository;
    }

    public async Task<IEnumerable<Charges>> GetChargesServiceAsync(string clientCode, string rcaCode)
    {
        try
        {
            if (!string.IsNullOrEmpty(clientCode) && string.IsNullOrEmpty(rcaCode))
            {
                var charegeA = await _chargesRepository.GetChargesARepositoryAsync(clientCode);
                if (charegeA != null)
                {
                    return charegeA;
                }
            }

            if (!string.IsNullOrEmpty(clientCode) && !string.IsNullOrEmpty(rcaCode))
            {
                var charegeB = await _chargesRepository.GetChargesBRepositoryAsync(clientCode, rcaCode);
                if (charegeB != null)
                {
                    return charegeB;
                }
            }

            if (string.IsNullOrEmpty(clientCode) && !string.IsNullOrEmpty(rcaCode))
            {
                var charegeC = await _chargesRepository.GetChargesCRepositoryAsync(clientCode);
                if (charegeC != null)
                {
                    return charegeC;
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            throw ex; 
        }
    }
}
