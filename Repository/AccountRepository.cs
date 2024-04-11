using Atm.Database;
using Atm.Interfaces;

namespace Atm.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AtmContext _context;

        public AccountRepository(AtmContext context)
        {
            _context = context;
        }

        public bool CustomerAccountExists(Guid customerKey, string accountNo)
        {
            return _context.Accounts.Where(o => o.CustomerKey.Equals(customerKey) && o.Number.Equals(accountNo)).Any();
        }

        public void ChangeBalance(string accountNo, float change)
        {
            int index = _context.Accounts.ToList().IndexOf(_context.Accounts.FirstOrDefault(o => o.Number.Equals(accountNo))!);

            _context.Accounts.ToList()[index].Balance = _context.Accounts.ToList()[index].Balance + change;

            _context.SaveChanges();
        }
    }
}