using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class RegionRepository : IRegionRepository
{
    private readonly IDbConnection _dbConnection;

    public RegionRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Regions>> GetRegionListAsync(int id)
    {
        var sql = SqlQueries.RegionList.Replace("@IDUSUARIO", id.ToString());

        return await _dbConnection.QueryAsync<Regions>(sql);
    }
}
