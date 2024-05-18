using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IParameterRepository
{
    Task<IEnumerable<Parameter>> GetListAsync(string unitCode, string paramName = "");
    Task<Parameter> GetAsync(string unitCode, string paramName = "");
}
