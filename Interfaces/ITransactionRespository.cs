using Atm.Model;

namespace Atm.Interfaces
{
    public interface ITransactionRespository
    {
        void AddTransaction(Transaction transaction);
    }
}
