using Dapper;
using Microsoft.EntityFrameworkCore;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class TabObjetivoDiaRepository : ITabObjetivoDiaRepository
{
    private readonly AppDbContext _context;
    private readonly IDbConnection _dbConnection;
    public TabObjetivoDiaRepository(AppDbContext context, IDbConnection dbConnection)
    {
        _context = context;
        _dbConnection = dbConnection;
    }
    public async Task<TabObjetivoDiaIn> AddObjetivoDiaRepositoryAsync(TabObjetivoDiaIn entity)
    {
        await _context.TabObjetivoDia.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }
    public async Task<TabObjetivoDiaIn> UpdateObjetivoDiaRepositoryAsync(TabObjetivoDiaIn entity)
    {
        try
        {
            var sql = SqlQueries.TabOjetivoDiaUpdate.Replace("@CODIGOUNIDADE", entity.CodigoUnidade.ToString())
                                            .Replace("@SUPERVISORID", entity.CodigoSupervisor.ToString())
                                            .Replace("@DATA", entity.Data.ToString("yyyy-MM-dd"))
                                            .Replace("@VALORMETA", entity.ValorMeta.ToString().Replace(",","."));
            var result = await _dbConnection.QueryFirstOrDefaultAsync<TabObjetivoDiaIn>(sql);

            return result;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error updating entity: {ex.Message}", ex);
        }
    }

    public async Task<TabObjetivoDiaIn> FindObjetivoDiaRepositoryAsync(TabObjetivoDiaIn entity)
    {
        var startTime = entity.Data.AddMilliseconds(-entity.Data.Millisecond);
        var endTime = entity.Data.AddMilliseconds(1000 - entity.Data.Millisecond);

        var query = _context.TabObjetivoDia
            .Where(item => item.CodigoUnidade == entity.CodigoUnidade &&
                           item.CodigoSupervisor == entity.CodigoSupervisor &&
                           item.Data >= startTime &&
                           item.Data < endTime);

        return await query.FirstOrDefaultAsync();
    }

    public async Task<TabObjetivoDiaOut> GetbyUnidadeRepositoryAsync(string unidade, string supervisor)
    {
        var sql = SqlQueries.tabObjetivoDia.Replace("@CODIGOUNIDADE", unidade)
                                            .Replace("@SUPERVISORID", supervisor);
        var result = await _dbConnection.QueryFirstOrDefaultAsync<TabObjetivoDiaOut>(sql);

        return result;
    }
}
