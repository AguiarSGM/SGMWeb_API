using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities.SalesClass;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services;

public class PedidoService : IPedidoService
{
    private readonly IPedidoRepository _pedidoRepository;
    public PedidoService(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    public async Task InsertSalesServiceAsync(TabPedido pedido)
    {
        await _pedidoRepository.AddAsync(pedido);
    }
}
