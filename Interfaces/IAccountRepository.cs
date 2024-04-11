namespace Atm.Interfaces
{
    public interface IAccountRepository
    {
        bool CustomerAccountExists(Guid customerKey, string accountNo);
        void ChangeBalance(string accountNo, float change);
        bool CanWithdraw(string accountNo, float change);
    }
}