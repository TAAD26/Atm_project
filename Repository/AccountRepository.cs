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

        public string Transfer(string CustomerKey, string ToAccountNo, float amount)
        {
            if (string.IsNullOrEmpty(CustomerKey)) throw new ArgumentNullException(nameof(CustomerKey));
            if (string.IsNullOrEmpty(ToAccountNo)) throw new ArgumentNullException(nameof(ToAccountNo));
            if (amount <= 0) throw new Exception("Invalid amount");
            var account = _context.Accounts.FirstOrDefault(a => a.CustomerKey == Guid.Parse(CustomerKey)) ?? throw new Exception("Invalid account");
            var toAccount = _context.Accounts.FirstOrDefault(a => a.Number == ToAccountNo) ?? throw new Exception("Invalid recipient account");
            if (account.Balance < amount) throw new Exception("Insufficient balance");
            account.Balance -= amount;
            toAccount.Balance += amount;
            _context.SaveChanges();
            return "Transaction successful";
        }
    }
}
