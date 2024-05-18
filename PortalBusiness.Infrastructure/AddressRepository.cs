using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class AddressRepository : IAddressRepository
{

    private readonly IDbConnection _dbConnection;

    public AddressRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<IEnumerable<Address>> GetAddressRepositoryAsync(int id)
    {
        try
        {
            string sql = SqlQueries.Address.Replace("@CODIGOCLIENTE", id.ToString());

            var parameters = new { CODIGOCLIENTE = id };

            var address = await _dbConnection.QueryAsync<Address>(sql);

            return address;
        }
        catch (Exception ex)
        {
            
            throw ex;
        }
    }
}
