using Atm.Interfaces;
using Atm.Model;

namespace Atm.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRespository _transactionRespository;

        public TransactionService(ITransactionRespository transactionRespository)
        {
            _transactionRespository = transactionRespository;
        }

        public Transaction MakeTransaction(string accountNo, float amount, string transactionType)
        {
            Transaction transaction = new Transaction();

            transaction.AccountNo = accountNo;
            transaction.Amount = amount;
            transaction.Type = transactionType;
            transaction.Date = DateTime.Now;

            _transactionRespository.AddTransaction(transaction);

            return transaction;
        }
    }
}