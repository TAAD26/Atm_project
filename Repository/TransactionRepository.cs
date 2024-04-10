using Atm.Database;
using Atm.Interfaces;
using Atm.Model;

namespace Atm.Repository
{
    public class TransactionRepository : ITransactionRespository
    {
        private readonly AtmContext _context;
        public TransactionRepository(AtmContext context)
        {
            _context = context;
        }
        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
        public List<Transaction> GetTransactions(string accountNo, string CustomerKey)
        {
            if (String.IsNullOrEmpty(CustomerKey)) throw new ArgumentNullException(nameof(CustomerKey));
            return _context.Transactions.Where(t => t.AccountNo == accountNo && t.Account.CustomerKey == Guid.Parse(CustomerKey)).ToList();
        }
    }
}
