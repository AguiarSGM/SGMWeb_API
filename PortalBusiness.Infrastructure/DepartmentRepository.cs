using Dapper;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly IDbConnection _dbConnection;

    public DepartmentRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Department>> GetDepartmentsAsync()
    {

        try
        {
            string sql = SqlQueries.Department;

            var result = await _dbConnection.QueryAsync<Department>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
