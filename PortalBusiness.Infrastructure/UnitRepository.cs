using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class UnitRepository : IUnitRepository
{
    private readonly IDbConnection _dbConnection;

    public UnitRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<IEnumerable<Unit>> GetRepositoryAsync(int idUser)
    {
        try
        {
            string sql = SqlQueries.Unit.Replace("@IDUSUARIO", idUser.ToString());

            var result = await _dbConnection.QueryAsync<Unit>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
