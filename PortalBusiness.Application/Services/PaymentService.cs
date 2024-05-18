using PortalBusiness.Application.Interfaces;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Infrastructure.Interfaces;

namespace PortalBusiness.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public async Task<IEnumerable<Payment>> GetPaymentAsync(string clientCode, string chargeCode, string rcaCode)
        {
            try
            {
                if (!string.IsNullOrEmpty(clientCode) && string.IsNullOrEmpty(chargeCode) && string.IsNullOrEmpty(rcaCode))
                {
                    return await _paymentRepository.GetPaymentPlanAAsync(clientCode);
                }
                else if (!string.IsNullOrEmpty(clientCode) && !string.IsNullOrEmpty(chargeCode) && string.IsNullOrEmpty(rcaCode))
                {
                    return await _paymentRepository.GetPaymentPlanBAsync(clientCode, chargeCode);
                }
                else if (!string.IsNullOrEmpty(clientCode) && string.IsNullOrEmpty(chargeCode) && !string.IsNullOrEmpty(rcaCode))
                {
                    return await _paymentRepository.GetPaymentPlanCAsync(clientCode, rcaCode);
                }
                else if (!string.IsNullOrEmpty(clientCode) && !string.IsNullOrEmpty(chargeCode) && !string.IsNullOrEmpty(rcaCode))
                {
                    return await _paymentRepository.GetPaymentPlanDAsync(clientCode, rcaCode, chargeCode);
                }

                return await _paymentRepository.GetPaymentPlanEAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Payment>> GetPaymentEAsync()
        {
            return await _paymentRepository.GetPaymentPlanEAsync();
        }
    }
}
