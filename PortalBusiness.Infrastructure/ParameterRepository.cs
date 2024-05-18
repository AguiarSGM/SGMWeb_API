using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure
{
    public class ParameterRepository : IParameterRepository
    {
        private readonly IDbConnection _dbConnection;

        public ParameterRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Parameter>> GetListAsync(string unitCode, string paramName = "")
        {
            try
            {
                string sql = SqlQueries.Params(false).Replace("@CODIGOUNIDADE", unitCode.ToString());

                var result = await _dbConnection.QueryAsync<Parameter>(sql);

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<Parameter> GetAsync(string unitCode, string paramName = "")
        {
            try
            {
                string sql = SqlQueries.Params(true).Replace("@CODIGOUNIDADE", unitCode.ToString())
                                                     .Replace("@NOMEPARAMETRO", paramName.ToString());

                var result = await _dbConnection.QueryFirstOrDefaultAsync<Parameter>(sql);

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
