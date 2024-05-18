using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class PaymentRepository : IPaymentRepository
{
    private readonly IDbConnection _dbConnection;

    public PaymentRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Payment>> GetPaymentPlanAAsync(string clientCode)
    {
        try
        {
            SqlQueries.PaymentPlan("A");
            string sql = SqlQueries.PaymentPlan("A").Replace("@CODIGOCLIENTE", clientCode);

            var result = await _dbConnection.QueryAsync<Payment>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }

        
    }

    public async Task<IEnumerable<Payment>> GetPaymentPlanBAsync(string clientCode, string chargeCode)
    {
        try
        {
            string sql = SqlQueries.PaymentPlan("B").Replace("@CODIGOCLIENTE", clientCode)
                                                    .Replace("@CODIGOCOBRANCA", chargeCode);

            var result = await _dbConnection.QueryAsync<Payment>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
    }

    public async Task<IEnumerable<Payment>> GetPaymentPlanCAsync(string clientCode, string rcaCode)
    {
        try
        {
            string sql = SqlQueries.PaymentPlan("C").Replace("@CODIGOCLIENTE", clientCode)                                                    
                                                    .Replace("@CODIGORCA", rcaCode);

            var result = await _dbConnection.QueryAsync<Payment>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
    }

    public async Task<IEnumerable<Payment>> GetPaymentPlanDAsync(string clientCode, string rcaCode, string chargeCode)
    {
        try
        {
            string sql = SqlQueries.PaymentPlan("D").Replace("@CODIGOCLIENTE", clientCode)
                                                    .Replace("@CODIGOCOBRANCA", chargeCode)
                                                    .Replace("@CODIGORCA", rcaCode);

            var result = await _dbConnection.QueryAsync<Payment>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Payment>> GetPaymentPlanEAsync()
    {
        try
        {
            string sql = SqlQueries.PaymentPlan();

            var result = await _dbConnection.QueryAsync<Payment>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
