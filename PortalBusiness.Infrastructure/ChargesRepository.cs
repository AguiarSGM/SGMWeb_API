using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class ChargesRepository : IChargesRepository
{
    private readonly IDbConnection _dbConnection;

    public ChargesRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Charges>> GetChargesARepositoryAsync(string clientCode)
    {
        try
        {
            string sql = SqlQueries.Bills("A").Replace("@CODIGOCLIENTE", clientCode);

            var result = await _dbConnection.QueryAsync<Charges>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Charges>> GetChargesBRepositoryAsync(string clientCode, string rcaCode)
    {
        try
        {
            string sql = SqlQueries.Bills("B").Replace("@CODIGOCLIENTE", clientCode)
                                              .Replace("@CODIGORCA", rcaCode);

            var result = await _dbConnection.QueryAsync<Charges>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Charges>> GetChargesCRepositoryAsync(string clientCode)
    {
        try
        {
            string sql = SqlQueries.Bills("C").Replace("@CODIGOCLIENTE", clientCode);

            var result = await _dbConnection.QueryAsync<Charges>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
