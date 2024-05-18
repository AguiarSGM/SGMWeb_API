using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class SubCategoriesRepository : ISubCategoriesRepository
{
    private readonly IDbConnection _dbConnection;

    public SubCategoriesRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<IEnumerable<SubCategories>> GetSubCategoriesRepositoryAsync(string sectionCode, string subcategories)
    {
        try
        {

            string sql = SqlQueries.Subcategories(sectionCode, subcategories).Replace("@CODIGOSECAO", sectionCode)
                                                                             .Replace("@CODIGOCATEGORIA", subcategories);

            var result = await _dbConnection.QueryAsync<SubCategories>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
