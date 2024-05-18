using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services
{
    public class ParameterService : IParameterService
    {
        private readonly IParameterRepository _parameterRepository;
        public ParameterService(IParameterRepository parameterRepository)
        {
            _parameterRepository = parameterRepository;
        }

        public async Task<Parameter> GetAsync(string unitCode, string paramName = "")
        {
            var result = await _parameterRepository.GetAsync(unitCode, paramName);
            return result;
        }

        public async Task<IEnumerable<Parameter>> GetListAsync(string unitCode, string paramName = "")
        {
            var result = await _parameterRepository.GetListAsync(unitCode, paramName);
            return result;
        }
    }
}
