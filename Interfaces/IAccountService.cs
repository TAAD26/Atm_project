using Atm.Model;

namespace Atm.Interfaces
{
    public interface IAccountService
    {
        public List<Account> CreateAccountWithoutSave(Guid customerKey, float startingBalance = 0);
    }
}
