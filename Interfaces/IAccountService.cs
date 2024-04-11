namespace Atm.Interfaces
{
    public interface IAccountService
    {
        bool CheckIfCustomerAccountExists(Guid customerKey, string accountNo);
        void ChangeBalance(string accountNo, float change);
        bool CanWithdraw(string accountNo, float change);
    }
}