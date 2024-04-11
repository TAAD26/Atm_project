using Atm.Dto;

namespace Atm.Interfaces
{
    public interface ICustomerService
    {
        string Login(CustomerLoginDto customer);
    }
}
