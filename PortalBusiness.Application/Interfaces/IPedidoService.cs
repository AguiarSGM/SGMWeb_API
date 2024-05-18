using PortalBusiness.Domain.Entities.SalesClass;

namespace PortalBusiness.Application.Interfaces;

public interface IPedidoService
{
    Task InsertSalesServiceAsync(TabPedido pedido);
}
