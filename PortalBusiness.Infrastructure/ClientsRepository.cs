using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class ClientsRepository : IClientsRepository
{
    private readonly IDbConnection _dbConnection;

    public ClientsRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<Client> GetClientbyIdRepositoryAsync(int id)
    {
        try
        {
            string sql = SqlQueries.Client.Replace("@CODIGOCLIENTE", id.ToString());               

            var result = await _dbConnection.QueryFirstOrDefaultAsync<Client>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Client>> GetClientsRepositoryAsync(int id)
    {
        try
        {

            string sql = SqlQueries.Clients.Replace("@IDUSUARIO", id.ToString());

            var result = await _dbConnection.QueryAsync<Client>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<ClientFull> GetFullRepositoryAsync(int id)
    {
        try
        {

            string sql = SqlQueries.Client.Replace("@CODIGOCLIENTE", id.ToString());

            var result = await _dbConnection.QueryFirstAsync<ClientFull>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Address>> GetAddressRepositoryAsync(object parameters)
    {
        try
        {
            string sql = SqlQueries.Address;

            var result = await _dbConnection.QueryAsync<Address>(sql, parameters);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<ClienteNew>> GetClienteNewRepositoryAsync()
    {
        try
        {

            string sql = SqlQueries.ClientesNew;

            var result = await _dbConnection.QueryAsync<ClienteNew>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<ClienteNew> GetClienteNewByIdRepositoryAsync(int id)
    {
        try
        {

            string sql = SqlQueries.ClientesByIdNew.Replace("@ID", id.ToString());

            var result = await _dbConnection.QueryFirstAsync<ClienteNew>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<int> InsertClienteNewRepositoryAsync(ClienteNew cliente)
    {
        try
        {
            string sql = SqlQueries.ClientesNewInsert.Replace("@CPFCNPJ", cliente.CpfCnpj.ToString())
                                                      .Replace("@IE", cliente.Ie.ToString())
                                                      .Replace("@CONTRIBUINTE", cliente.Contribuinte.ToString())
                                                      .Replace("@RAZAOSOCIAL", cliente.RazaoSocial.ToString())
                                                      .Replace("@NOMEFANTASIA", cliente.NomeFantasia.ToString())
                                                      .Replace("@CEP", cliente.Cep.ToString())
                                                      .Replace("@CIDADE", cliente.Cidade.ToString())
                                                      .Replace("@ENDERECO", cliente.Endereco.ToString())
                                                      .Replace("@NUMERO", cliente.Numero.ToString())
                                                      .Replace("@UF", cliente.Uf.ToString())
                                                      .Replace("@STATUS", cliente.Status.ToString());

            // Execute a query de inserção e retorna o ID inserido
            var insertedId = await _dbConnection.ExecuteScalarAsync<int>(sql, cliente);

            return insertedId;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task UpdateClienteNewRepositoryAsync(ClienteNew cliente)
    {
        try
        {
            string sql = SqlQueries.ClientesNewUpdate.Replace("@CPFCNPJ", cliente.CpfCnpj.ToString())
                                                      .Replace("@IE", cliente.Ie.ToString())
                                                      .Replace("@CONTRIBUINTE", cliente.Contribuinte.ToString())
                                                      .Replace("@RAZAOSOCIAL", cliente.RazaoSocial.ToString())
                                                      .Replace("@NOMEFANTASIA", cliente.NomeFantasia.ToString())
                                                      .Replace("@CEP", cliente.Cep.ToString())
                                                      .Replace("@CIDADE", cliente.Cidade.ToString())
                                                      .Replace("@ENDERECO", cliente.Endereco.ToString())
                                                      .Replace("@NUMERO", cliente.Numero.ToString())
                                                      .Replace("@UF", cliente.Uf.ToString())
                                                      .Replace("@STATUS", cliente.Status.ToString())
                                                      .Replace("@ID", cliente.Id.ToString());


            // Execute a query de atualização
            await _dbConnection.ExecuteAsync(sql, cliente);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task DeleteClienteNewRepositoryAsync(int id)
    {
        try
        {
            string sql = SqlQueries.ClientesNewDelete;

            await _dbConnection.ExecuteAsync(sql, new { Id = id });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<Sac>> GetSacRepositoryAsync(string id)
    {
        try
        {
            string sql = SqlQueries.ClientesSac.Replace("@CODIGOCLIENTE", id);

            var result = await _dbConnection.QueryAsync<Sac>(sql);

            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<HistorioCobranca>> GetHistoricoCobrancaRepositoryAsync(string codigoCliente)
    {
        try
        {
            string sql = SqlQueries.HistoricoCobranca.Replace("@CODIGOCLIENTE", codigoCliente);

            var result = await _dbConnection.QueryAsync<HistorioCobranca>(sql);

            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
