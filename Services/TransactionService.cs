using Atm.Dto;
using Atm.Interfaces;
using Atm.Model;

namespace Atm.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ITransactionRespository _transactionRepository;

        public TransactionService(IAccountRepository accountRepository, ITransactionRespository transactionRepository)
        {
            _accountRepository = accountRepository;
            _transactionRepository = transactionRepository;
        }

        public void CreateTransaction(TransactionDto transaction)
        {
            _transactionRepository.CreateTransaction(transaction);
        }

        public List<Transaction> GetTransactionDetails(string accountNo, string CustomerKey, int limit)
        {
            return _transactionRepository.GetTransactionDetails(accountNo, CustomerKey, limit);
        }
    }
}
