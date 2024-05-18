using Dapper;
using Microsoft.EntityFrameworkCore;
using PortalBusiness.Domain.Entities.SalesClass;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure.ClassSales;

public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;
    private readonly IDbConnection _dbConnection;
    public PedidoRepository(AppDbContext context, IDbConnection dbConnection)
    {
        _context = context;
        _dbConnection = dbConnection;
    }

    public async Task<TabPedido> AddAsync(TabPedido entity)
    {

        var codPedidoRCA = (await NumeroPedidoRCA(entity.IdUsuario.ToString()));

        entity.CodigoPedidoRca = codPedidoRCA;

        var i = 0;
        while (i < entity.Itens.Count)
        {
            entity.Itens[i].CodigoPedidoRca = codPedidoRCA;
            entity.Itens[i].DataHoraAberturaPedido = entity.DataHoraAberturaPedido;
            entity.Itens[i].CodigoRca = entity.CodigoRca;

            i++;
        }

        await _context.TabPedidos.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<TabPedido> GetByIdAsync(int id)
    {
        return await _context.TabPedidos.Where(x => x.CodigoPedidoRca == id).FirstOrDefaultAsync();
    }

    public string ProcessaPedidoAsync(int codigoRCA)
    {
        var parameters = new DynamicParameters();

        parameters.Add("pcodigopedidorca", codigoRCA, DbType.Int32, ParameterDirection.Input);
        parameters.Add("pnumpedrca", dbType: DbType.Int32, direction: ParameterDirection.Output);
        parameters.Add("pstatus", dbType: DbType.String, size: 50, direction: ParameterDirection.Output);

        _dbConnection.Execute("sgmcontrol.PROCESSAR_PEDIDO", parameters, commandType: CommandType.StoredProcedure);

        string pstatus = parameters.Get<string>("pstatus");

        return pstatus;
    }

    public void Remove(TabPedido entity)
    {
        _context.TabPedidos.Remove(entity);
    }

    public void Update(TabPedido entity)
    {
        _context.TabPedidos.Update(entity);
    }

    private async Task<int> NumeroPedidoRCA(string userid)
    {
        var sql = SqlQueries.NumeroPedidoRca.Replace("@IDUSUARIO", userid);
        var result = await _dbConnection.QueryFirstOrDefaultAsync<int>(sql);

        return result;
    }
}
