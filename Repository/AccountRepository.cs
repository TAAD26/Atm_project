using Atm.Database;
using Atm.Interfaces;
using Atm.Model;

namespace Atm.Repository
{
    public class AccountRepository(AtmContext context) : IAccountRepository
    {
        public void CreateAccount(List<Account> accounts)
        {
            context.Accounts.AddRange(accounts);
            context.SaveChanges();
        }
    }
}
