using Atm.Dto;
using Atm.Model;

namespace Atm.Interfaces
{
    public interface ITransactionRespository
    {
        void CreateTransaction(TransactionDto transaction);
        List<Transaction> GetTransactionDetails(string accountNo, string CustomerKey, int limit);
    }
}
