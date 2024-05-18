using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class SupplierRepository : ISupplierRepository
{
    private readonly IDbConnection _dbConnection;

    public SupplierRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<IEnumerable<Supplier>> GetSupplierRepositoryAsync()
    {
        try
        {
            string sql = SqlQueries.Supplier;

            var result = await _dbConnection.QueryAsync<Supplier>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
