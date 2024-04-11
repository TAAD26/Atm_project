namespace Atm.Interfaces
{
    public interface ICustomerService
    {
        bool CheckIfCustomerExists(Guid customerKey);
    }
}