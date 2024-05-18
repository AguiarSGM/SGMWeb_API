using PortalBusiness.Domain.Entities.SalesClass;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IPedidoRepository
{
    Task<TabPedido> GetByIdAsync(int id);
    Task<TabPedido> AddAsync(TabPedido entity);
    string ProcessaPedidoAsync(int codigoRCA);
    void Update(TabPedido entity);
    void Remove(TabPedido entity);
}
