using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Entities.SalesClass;

namespace PortalBusiness.Infrastructure.Interfaces.ContractSales;

public interface ISalesRepository
{
    Task<SalesOutFullOrder> GetSalesFullRepositoryAsync(string codpedidorca);
    Task<IEnumerable<Sales>> GetSalesRepositoryAsync(string iduser);

    Task RulesSalesSoap(int codigoPedidoRCA, int codigoRCA, string dataHoraAbertura);
    Task<SalesOrder> InsertSalesAsync(TabPedido pedido);
    Task<IEnumerable<SalesItem>> GetSalesItensRepositoryAsync(int iduser, string codrca);
    Task<int> UpdateSalesAsync(SalesOrder salesOrder);
    Task<int> DeleteSalesAsync(string codpedidorca);
}
