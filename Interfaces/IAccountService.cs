using Atm.Model;

namespace Atm.Interfaces
{
    public interface IAccountService
    {
        public List<Account> CreateAccountWithoutSave(Guid customerKey, float startingBalance = 0);
        string Transfer(string CustomerKey, string ToAccountNo, float amount);
    }
}
