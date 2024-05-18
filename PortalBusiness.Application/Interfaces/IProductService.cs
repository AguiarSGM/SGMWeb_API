using PortalBusiness.Domain.Entities.Products;

namespace PortalBusiness.Application.Interfaces;

public interface IProductService
{
    Task<Product> GetByIdAsync(int id);
    Task<IEnumerable<ProductsValidateOut>> GetProductValidationServiceAsync(string unitCode, string productCode);
    Task<ProductsValidateOut> GetProductValidateServiceAsync(string unitCode, string productCode, string validCode);
    Task<IEnumerable<ProductsValidateOut>> GetProductValidateServiceAsync(string unitCode, string productCode);
    Task<IEnumerable<ProductsResumeOut>> GetProductResumeServiceAsync(string cod_unit, string cod_client, string per_acres_desc, string cod_reg_client, Dictionary<string, string> optionals);
    Task<IEnumerable<ProductsFullOut>> GetProductsFullServiceAsync(string cod_cliente, string cod_region_client, string uf, string cod_activity, string cod_network, string cod_rca, string cod_supervisor, string cod_plan, string cod_product, string cod_unit);
    Task<IEnumerable<ProductsOffersOut>> GetProductsOffersServiceAsync(string cod_unit, string cod_product, string codClient, string cod_region, string uf_client, string cod_activity, string cod_network, string cod_rca, string cod_supervizor, string cod_plan_payment);
}
