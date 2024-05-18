using Dapper;
using Microsoft.Extensions.Options;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Entities.Products;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _dbConnection;

    public ProductRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<ProductsResumeOut>> GetProductResumeAsync(string cod_unit, string cod_client, string per_acres_desc, string cod_reg_client, Dictionary<string, string> optionals)
    {
        try
        {
            string sql = SqlQueries.ProductsResume(optionals).Replace(":CODIGOCLIENTE", cod_client)
                                                             .Replace(":PERACRESCIMODESCONTO", per_acres_desc)
                                                             .Replace(":CODIGOUNIDADE", cod_unit)
                                                             .Replace(":CODIGOREGIAO", cod_reg_client)
                                                             .Replace("            ","");

            var results = await _dbConnection.QueryAsync<ProductsResumeOut>(sql.Trim());
            return results;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<ProductsFullOut>> GetProductsFullAsync(string cod_cliente, 
                                                                         string cod_region_client, 
                                                                         string uf, 
                                                                         string cod_activity, 
                                                                         string cod_network, 
                                                                         string cod_rca, 
                                                                         string cod_supervisor, 
                                                                         string cod_plan, 
                                                                         string cod_product, 
                                                                         string cod_unit)
    {
        try
        {
            string sql = SqlQueries.ProductsFull.Replace("@CODIGOCLIENTE", cod_cliente)
                                                .Replace("@CODIGOREGIAO", cod_region_client)
                                                .Replace("@UF", uf)
                                                .Replace("@CODIGOATIVIDADE", cod_activity)
                                                .Replace("@CODIGOREDE", cod_network)
                                                .Replace("@CODIGORCA", cod_rca)
                                                .Replace("@CODIGOPLANO", cod_plan)
                                                .Replace("@CODIGOPRODUTO", cod_product)
                                                .Replace("@CODIGOUNIDADE", cod_unit)
                                                .Replace("@CODIGOSUPERVISOR", cod_supervisor);

            var results = await _dbConnection.QueryAsync<ProductsFullOut>(sql);

            var graficoSql = SqlQueries.ProdutoGrafico.Replace("@CODIGOPRODUTO", cod_product)
                                                       .Replace("@CODIGOUNIDADE", cod_unit)
                                                       .Replace("@CODIGOCLIENTE", cod_cliente);

            var graficoResult = await _dbConnection.QueryFirstOrDefaultAsync<ProdutoGrafico>(graficoSql);


            var produtosComGrafico = results.Select(p =>
            {
                p.ProdutoGrafico = graficoResult;
                return p;
            });

            return produtosComGrafico;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<ProductsValidateOut>> GetProductValidateAsync(string unitCode, string productCode)
    {
        try
        {
            string sql = SqlQueries.ProductsValidate.Replace("@CODIGOUNIDADE", unitCode)
                                                    .Replace("@CODIGOPRODUTO", productCode);

            var results = await _dbConnection.QueryAsync<ProductsValidateOut>(sql);

            return results;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<ProductsValidateOut> GetProductValidateAsync(string unitCode, string productCode, string validCode)
    {
        try
        {
            string sql = SqlQueries.ProductValidate.Replace("@CODIGOUNIDADE", unitCode)
                                                   .Replace("@CODIGOPRODUTO", productCode)
                                                   .Replace("@CODIGOCAMPANHA", validCode); 

            var result = await _dbConnection.QueryFirstOrDefaultAsync<ProductsValidateOut>(sql);

            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<ProductsOffersOut>> GetProductsOffersAsync(string cod_unit, string cod_product, string codClient, string cod_region, string uf_client, string cod_activity, string cod_network, string cod_rca, string cod_supervizor, string cod_plan_payment)
    {
        try
        {
            string sql = SqlQueries.ProductsOffers.Replace("@CODIGOCLIENTE", codClient)
                                                .Replace("@CODIGOREGIAOCLIENTE", cod_region)
                                                .Replace("@UFCLIENTE", uf_client)
                                                .Replace("@CODIGOATIVIDADECLIENTE", cod_activity)
                                                .Replace("@CODIGOREDECLIENTE", cod_network)
                                                .Replace("@CODIGORCA", cod_rca)
                                                .Replace("@CODIGOPLANOPAGAMENTO", cod_plan_payment)
                                                .Replace("@CODIGOPRODUTO", cod_product)
                                                .Replace("@CODIGOUNIDADE", cod_unit)
                                                .Replace("@CODIGOSUPERVISOR", cod_supervizor); ;


            var results = await _dbConnection.QueryAsync<ProductsOffersOut>(sql);

            return results;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        var parameters = new
        {
            id = id
        };

        using (var connection = DapperConfiguration.GetSqlConnection())
        {
            await connection.OpenAsync();

            var sql = SqlQueries.ProductsFull;
            var products = (await connection.QueryAsync<Product>(sql, parameters)).FirstOrDefault();

            return products;
        }
    }


}
