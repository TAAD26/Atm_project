namespace Atm.Interfaces
{
    public interface IAccountService
    {
        string Transfer(string CustomerKey, string ToAccountNo, float amount);
    }
}
