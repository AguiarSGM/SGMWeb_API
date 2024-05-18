using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class DashboardRepository : IDashboardRepository
{
    private readonly IDbConnection _dbConnection;

    public DashboardRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Charges>> GetDashboardAsync()
    {
        try
        {
            string sql = SqlQueries.Bills("D");

            var result = await _dbConnection.QueryAsync<Charges>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<ResumeMes> GetResumeMesRepositoryAsync(int id)
    {
        try
        {
            string sql = SqlQueries.ResumoMes.Replace("@IDUSUARIOLOGADO", id.ToString());

            var result = await _dbConnection.QueryFirstAsync<ResumeMes>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
