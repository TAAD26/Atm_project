using Atm.Dto;
using Atm.Model;

namespace Atm.Interfaces
{
    public interface ITransactionService
    {
        void CreateTransaction(TransactionDto transaction);
        List<Transaction> GetTransactionDetails(string accountNo, string CustomerKey, int limit);
    }
}
