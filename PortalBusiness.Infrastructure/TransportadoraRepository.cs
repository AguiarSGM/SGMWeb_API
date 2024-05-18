using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class TransportadoraRepository : ITransportadoraRepository
{
    private readonly IDbConnection _dbConnection;

    public TransportadoraRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    
    public async Task<IEnumerable<Transportadora>> GetAllTransportadoraRepositoryAsync()
    {
        try
        {
            string sql = SqlQueries.GetTransportadora;

            var result = await _dbConnection.QueryAsync<Transportadora>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
