using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities.Products;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _productRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<ProductsResumeOut>> GetProductResumeServiceAsync(string cod_unit, string cod_client, string per_acres_desc, string cod_reg_client, Dictionary<string, string> optionals)
    {
        return await _productRepository.GetProductResumeAsync(cod_unit, cod_client, per_acres_desc, cod_reg_client, optionals);
    }

    public async Task<IEnumerable<ProductsFullOut>> GetProductsFullServiceAsync(string cod_cliente, string cod_region_client, string uf, string cod_activity, string cod_network, string cod_rca, string cod_supervisor, string cod_plan, string cod_product, string cod_unit)
    {
        return await _productRepository.GetProductsFullAsync(cod_cliente, cod_region_client, uf, cod_activity, cod_network, cod_rca, cod_supervisor, cod_plan, cod_product, cod_unit);
    }

    public async Task<IEnumerable<ProductsOffersOut>> GetProductsOffersServiceAsync(string cod_unit, string cod_product, string codClient, string cod_region, string uf_client, string cod_activity, string cod_network, string cod_rca, string cod_supervizor, string cod_plan_payment)
    {
        return await _productRepository.GetProductsOffersAsync(cod_unit, cod_product, codClient, cod_region, uf_client, cod_activity, cod_network, cod_rca, cod_supervizor, cod_plan_payment);
    }

    public async Task<ProductsValidateOut> GetProductValidateServiceAsync(string unitCode, string productCode, string validCode)
    {
        return await _productRepository.GetProductValidateAsync(unitCode, productCode, validCode);
    }

    public async Task<IEnumerable<ProductsValidateOut>> GetProductValidateServiceAsync(string unitCode, string productCode)
    {
        return await _productRepository.GetProductValidateAsync(unitCode, productCode);
    }

    public async Task<IEnumerable<ProductsValidateOut>> GetProductValidationServiceAsync(string unitCode, string productCode)
    {
        return await _productRepository.GetProductValidateAsync(unitCode, productCode);
    }
}
