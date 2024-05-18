using Dapper;
using PortalBusiness.Domain.Entities.Auth;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class UserRepository : IUserRepository
{
    private readonly IDbConnection _dbConnection;

    public UserRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    public async Task<AuthOutput> FindByUsernameAsync(AuthInput authInput)
    {
        try
        {
            var sql = SqlQueries.FindUserName().Replace("@NOMEUSUARIO", authInput.User).Replace("@PASSWORD", authInput.Password);
            var result = (await _dbConnection.QueryAsync<AuthOutput>(sql, authInput)).FirstOrDefault();

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }

        
    }
}
