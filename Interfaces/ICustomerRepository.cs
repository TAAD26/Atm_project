using Atm.Dto;

namespace Atm.Interfaces
{
    public interface ICustomerRepository
    {
        string Login(CustomerLoginDto customer);
    }
}
