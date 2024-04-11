using Atm.Dto;
using Atm.Interfaces;
using Atm.Model;
using Microsoft.IdentityModel.Tokens;

namespace Atm.Services
{
    public class CustomerService(ICustomerRepository customerRepository, IAccountService accountService) : ICustomerService
    {
        public Customer CreateCustomer(CustomerDto customerDto, string userName, string pass)
        {
            ArgumentNullException.ThrowIfNull(customerDto);

            Customer customer = new()
                {
                    CustomerKey = Guid.NewGuid(),
                    PersonalId = customerDto.PersonalId,
                    FirstName = customerDto.FirstName,
                    LastName = customerDto.LastName,
                    PhoneNumber = customerDto.PhoneNumber,
                    Address = customerDto.Address,
                    UserId = userName,
                    Password = pass,
                    Accounts = customerDto.Accounts.IsNullOrEmpty() ? accountService.CreateAccountWithoutSave(customerDto.CustomerKey) : customerDto.Accounts
                };

                customerRepository.CreateCustomer(customer);

            return customer;
        }
    }
}
