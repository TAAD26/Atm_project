using Atm.Interfaces;

namespace Atm.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public bool CheckIfCustomerExists(Guid customerKey)
        {
            return _customerRepository.CustomerExists(customerKey);
        }
    }
}