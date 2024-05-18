using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class BrandsRepository : IBrandsRepository
{
    private readonly IDbConnection _dbConnection;

    public BrandsRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<IEnumerable<Brand>> GetBrandsRepositoryAsync()
    {
        try
        {
            string sql = SqlQueries.Brands;

            var result = await _dbConnection.QueryAsync<Brand>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
