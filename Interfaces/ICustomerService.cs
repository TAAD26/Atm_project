using Atm.Dto;
using Atm.Model;

namespace Atm.Interfaces
{
    public interface ICustomerService
    {
        public Customer CreateCustomer(CustomerDto customerDto, string userName, string pass);
    }
}
