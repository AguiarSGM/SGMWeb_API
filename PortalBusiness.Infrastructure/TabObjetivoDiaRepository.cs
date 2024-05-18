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
        _context.TabObjetivoDia.Update(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<TabObjetivoDiaIn> FindObjetivoDiaRepositoryAsync(TabObjetivoDiaIn entity)
    {
        return await _context.TabObjetivoDia.FirstOrDefaultAsync(item => item.CodigoUnidade == entity.CodigoUnidade &&
                                                                         item.Data == entity.Data &&
                                                                         item.CodigoSupervisor == entity.CodigoSupervisor);
    }

    public async Task<TabObjetivoDiaOut> GetbyUnidadeRepositoryAsync(string unidade, string supervisor)
    {
        var sql = SqlQueries.tabObjetivoDia.Replace("@CODIGOUNIDADE", unidade)
                                            .Replace("@SUPERVISORID", supervisor);
        var result = await _dbConnection.QueryFirstOrDefaultAsync<TabObjetivoDiaOut>(sql);

        return result;
    }
}
