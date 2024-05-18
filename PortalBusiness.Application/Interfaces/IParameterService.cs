using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IParameterService
{
    Task<Parameter> GetAsync(string unitCode, string paramName = "");
    Task<IEnumerable<Parameter>> GetListAsync(string unitCode, string paramName = "");
}
