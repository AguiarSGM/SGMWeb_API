using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Infrastructure;

public class HealthRepository : IHealthRepository
{
    public async Task<HealthStatus> CheckHealthAsync()
    {
        using (var connection = DapperConfiguration.GetSqlConnection())
        {
            await connection.OpenAsync();

            var sql = SqlQueries.Bills("A");
            var healt = (await connection.QueryAsync<HealthStatus>(sql)).FirstOrDefault();

            return healt;
        }
    }
}
