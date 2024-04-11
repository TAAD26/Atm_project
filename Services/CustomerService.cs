using Atm.Dto;
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
        public string Login(CustomerLoginDto customer)
        {
            return _customerRepository.Login(customer);
        }
    }
}

