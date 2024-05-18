using Microsoft.Extensions.Configuration;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Entities.SalesClass;
using PortalBusiness.Infrastructure.Interfaces;
using PortalBusiness.Infrastructure.Interfaces.ContractSales;

namespace PortalBusiness.Application.Services;

public class SalesService : ISalesService
{
    private readonly ISalesRepository _salesRepository;
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IConfiguration _configuration;
    public SalesService(ISalesRepository salesRepository, IPedidoRepository pedidoRepository, IConfiguration configuration)
    {
        _salesRepository = salesRepository;
        _pedidoRepository = pedidoRepository;
        _configuration = configuration;
    }

    public async Task<IEnumerable<Sales>> GetServiceAsync(string iduser)
    {
        return await _salesRepository.GetSalesRepositoryAsync(iduser);
    }

    public async Task<SalesOutFullOrder> GetSalesFullServiceAsync(string codpedidorca)
    {
        return await _salesRepository.GetSalesFullRepositoryAsync(codpedidorca);
    }

    public async Task<SalesInsertOut> InsertSalesServiceAsync(TabPedido pedido)
    {
        try
        {
            var pedidoReturn = await _pedidoRepository.AddAsync(pedido);
            
            var retornoStatusProcessamento = _pedidoRepository.ProcessaPedidoAsync(pedidoReturn.CodigoPedidoRca);

            var salesInsertOut = new SalesInsertOut();

            salesInsertOut.CodigoPedidoRca = pedidoReturn.CodigoPedidoRca;
            salesInsertOut.DataHoraAberturaPedido = pedidoReturn.DataHoraAberturaPedido;
            salesInsertOut.CodigoRca = pedidoReturn.CodigoRca;

            return salesInsertOut;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<SalesItem>> GetSalesItensServiceAsync(int iduser, string codrca)
    {
        return await _salesRepository.GetSalesItensRepositoryAsync(iduser, codrca);
    }

    public void UpdateSalesServiceAsync(TabPedido salesOrder)
    {
        _pedidoRepository.Update(salesOrder);
    }

    public async Task DeleteSalesServiceAsync(int codpedidorca)
    {

        var pedido = await _pedidoRepository.GetByIdAsync(codpedidorca);

        _pedidoRepository.Remove(pedido);
    }
}
