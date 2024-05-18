using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Application.Interfaces;

public interface IPaymentService
{
    Task<IEnumerable<Payment>> GetPaymentAsync(string clientCode, string chargeCode, string rcaCode);
    Task<IEnumerable<Payment>> GetPaymentEAsync();
}
