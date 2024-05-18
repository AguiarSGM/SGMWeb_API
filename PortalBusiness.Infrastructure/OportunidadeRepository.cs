using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class OportunidadeRepository: IOportunidadeRepository
{
    private readonly IDbConnection _dbConnection;

    public OportunidadeRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Oportunidade>> GetOportunidadetbyParametersRepositoryAsync(Parameters parameters)
    {
        try
        {
            string sql = SqlQueries.Oportunidades.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                                 .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString())
                                                 .Replace("@CODIGORCA", parameters.CodigoRca.ToString());

            var result = await _dbConnection.QueryAsync<Oportunidade>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Oportunidade>> GetAllOportunidadesRepositoryAsync()
    {
        try
        {
            string sql = SqlQueries.OportunidadesAll;

            var result = await _dbConnection.QueryAsync<Oportunidade>(sql);

            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<int> InsertOportunidadeRepositoryAsync(Oportunidade oportunidade)
    {
        try
        {
            string sql = SqlQueries.InsertOportunidade.Replace("@TIPO", oportunidade.Tipo.ToString())
                                                      .Replace("@CODIGO", oportunidade.Codigo.ToString())
                                                      .Replace("@DESCRICAO", oportunidade.Descricao.ToString())
                                                      .Replace("@OBSERVACAO", oportunidade.Observacao.ToString())
                                                      .Replace("@CODCLIENTE", oportunidade.CodigoCliente.ToString())
                                                      .Replace("@CODUNIDADE", oportunidade.CodigoUnidade.ToString())
                                                      .Replace("@CODRCA", oportunidade.CodigoRca.ToString())
                                                      .Replace("@STATUS", oportunidade.Status.ToString());

            // Execute a query de inserção e retorna o ID inserido
            var insertedId = await _dbConnection.ExecuteScalarAsync<int>(sql, oportunidade);

            var seq = await _dbConnection.QueryFirstOrDefaultAsync<int>("SELECT max(IDOPORTUNIDADE) AS IDOPORTUNIDADE FROM TABOPORTUNIDADE");

            return seq;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task UpdateOportunidadeRepositoryAsync(Oportunidade oportunidade)
    {
        try
        {
            string sql = SqlQueries.UpdateOportunidade.Replace("@TIPO", oportunidade.Tipo.ToString())
                                                      .Replace("@CODIGO", oportunidade.Codigo.ToString())
                                                      .Replace("@DESCRICAO", oportunidade.Descricao.ToString())
                                                      .Replace("@OBSERVACAO", oportunidade.Observacao.ToString())
                                                      .Replace("@CODCLIENTE", oportunidade.CodigoCliente.ToString())
                                                      .Replace("@CODUNIDADE", oportunidade.CodigoUnidade.ToString())
                                                      .Replace("@CODRCA", oportunidade.CodigoRca.ToString())
                                                      .Replace("@IDOPORTUNIDADE", oportunidade.Idoportunidade.ToString())
                                                      .Replace("@STATUS", oportunidade.Status.ToString());

            // Execute a query de atualização
            await _dbConnection.ExecuteAsync(sql, oportunidade);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task DeleteOportunidadeRepositoryAsync(int id)
    {
        try
        {
            string sql = SqlQueries.DeleteOportunidade;

            await _dbConnection.ExecuteAsync(sql, new { Id = id });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
