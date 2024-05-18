using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Entities.SalesClass;

namespace PortalBusiness.Application.Interfaces;

public interface ISalesService
{
    Task<SalesOutFullOrder> GetSalesFullServiceAsync(string codpedidorca);
    Task<IEnumerable<Sales>> GetServiceAsync(string iduser);
    Task<IEnumerable<SalesItem>> GetSalesItensServiceAsync(int iduser, string codrca);
    Task<SalesInsertOut> InsertSalesServiceAsync(TabPedido pedido);
    void UpdateSalesServiceAsync(TabPedido salesOrder);
    Task DeleteSalesServiceAsync(int codpedidorca);
    
}
