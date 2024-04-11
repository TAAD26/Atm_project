namespace Atm.Interfaces
{
    public interface ICustomerRepository
    {
        bool CustomerExists(Guid customerKey);
    }
}