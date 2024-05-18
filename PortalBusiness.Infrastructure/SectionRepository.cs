using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class SectionRepository : ISectionRepository
{
    private readonly IDbConnection _dbConnection;

    public SectionRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<IEnumerable<Sections>> GetSectionsAsync(string departmentCode)
    {
        var sql = SqlQueries.Sections(departmentCode).Replace("@CODIGODEPARTAMENTO", departmentCode);
        
        return await _dbConnection.QueryAsync<Sections>(sql);
    }
}
