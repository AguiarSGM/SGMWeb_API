using PortalBusiness.Domain.Entities.Products;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IProductRepository
{
    Task<Product> GetByIdAsync(int id);
    Task<IEnumerable<ProductsValidateOut>> GetProductValidateAsync(string unitCode, string productCode);
    Task<ProductsValidateOut> GetProductValidateAsync(string unitCode, string productCode, string validCode);
    Task<IEnumerable<ProductsResumeOut>> GetProductResumeAsync(string cod_unit, string cod_client, string per_acres_desc, string cod_reg_client, Dictionary<string, string> optionals);
    Task<IEnumerable<ProductsFullOut>> GetProductsFullAsync(string cod_cliente, string cod_region_client, string uf, string cod_activity, string cod_network, string cod_rca, string cod_supervisor, string cod_plan, string cod_product, string cod_unit);
    Task<IEnumerable<ProductsOffersOut>> GetProductsOffersAsync(string cod_unit, string cod_product, string codClient, string cod_region, string uf_client, string cod_activity, string cod_network, string cod_rca, string cod_supervizor, string cod_plan_payment);
}
