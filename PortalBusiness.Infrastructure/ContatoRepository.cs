using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class ContatoRepository : IContatoRepository
{
    private readonly IDbConnection _dbConnection;

    public ContatoRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task DeleteContatoRepositoryAsync(int id)
    {
        try
        {
            string sql = SqlQueries.ContatoDelete;

            await _dbConnection.ExecuteAsync(sql, new { Id = id });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<Contato>> GetContatoByClienteIdRepositoryAsync(int id)
    {
        try
        {
            string sql = SqlQueries.ContatoByIdCliente.Replace("@CLIENTE_ID", id.ToString());

            var result = await _dbConnection.QueryAsync<Contato>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Contato>> GetContatoRepositoryAsync()
    {
        try
        {
            string sql = SqlQueries.Contato;

            var result = await _dbConnection.QueryAsync<Contato>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<int> InsertContatoRepositoryAsync(Contato contato)
    {
        try
        {
            string sql = SqlQueries.ContatoInsert.Replace("@CLIENTE_ID", contato.Cliente_Id.ToString())
                                                .Replace("@NOMECONTATO", contato.NomeContato.ToString())
                                                .Replace("@CELULARCONTATO", contato.CelularContato.ToString())
                                                .Replace("@FIXOCONTATO", contato.FixoContato.ToString())
                                                .Replace("@EMAILCONTATO", contato.EmailContato.ToString())
                                                .Replace("@TIPO", contato.Tipo.ToString())
                                                .Replace("@STATUS", contato.Status.ToString());

            var insertedId = await _dbConnection.ExecuteScalarAsync<int>(sql, contato);

            return insertedId;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task UpdateContatoRepositoryAsync(Contato contato)
    {
        try
        {

            string sql = SqlQueries.ContatoUpdate.Replace("@ID", contato.Id.ToString())
                                                .Replace("@CLIENTE_ID", contato.Cliente_Id.ToString())
                                                .Replace("@NOMECONTATO", contato.NomeContato.ToString())
                                                .Replace("@CELULARCONTATO", contato.CelularContato.ToString())
                                                .Replace("@FIXOCONTATO", contato.FixoContato.ToString())
                                                .Replace("@EMAILCONTATO", contato.EmailContato.ToString())
                                                .Replace("@TIPO", contato.Tipo.ToString())
                                                .Replace("@STATUS", contato.Status.ToString()); 


            await _dbConnection.ExecuteAsync(sql, contato);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
