using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class CategoriesRepository : ICategoriesRepository
{

    private readonly IDbConnection _dbConnection;

    public CategoriesRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<IEnumerable<Category>> GetCategoriesRepositoryAsync(int sectionCode)
    {
        try
        {
            
            string sql = SqlQueries.Categories(sectionCode.ToString()).Replace("@CODIGOSECAO", sectionCode.ToString());

            var result = await _dbConnection.QueryAsync<Category>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
