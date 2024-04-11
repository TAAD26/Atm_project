using Atm.Model;

namespace Atm.Interfaces
{
    public interface IAccountRepository
    {
        public void CreateAccount(List<Account> accounts);
    }
}
