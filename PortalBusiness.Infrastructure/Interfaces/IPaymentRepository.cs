using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Interfaces;

public interface IPaymentRepository
{
    Task<IEnumerable<Payment>> GetPaymentPlanAAsync(string clientCode);
    Task<IEnumerable<Payment>> GetPaymentPlanBAsync(string clientCode, string chargeCode);
    Task<IEnumerable<Payment>> GetPaymentPlanCAsync(string clientCode, string rcaCode);
    Task<IEnumerable<Payment>> GetPaymentPlanDAsync(string clientCode, string rcaCode, string chargeCode);
    Task<IEnumerable<Payment>> GetPaymentPlanEAsync();
}
