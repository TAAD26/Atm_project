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
        public string Login(string userId, string password)
        {
            return _customerRepository.Login(userId, password);
        }
    }
}
