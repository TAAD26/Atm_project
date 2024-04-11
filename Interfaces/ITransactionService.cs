using Atm.Model;

namespace Atm.Interfaces
{
    public interface ITransactionService
    {
        Transaction MakeTransaction(string accountNo, float amount, string transactionType);
    }
}