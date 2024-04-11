using Atm.Interfaces;

namespace Atm.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool CheckIfCustomerAccountExists(Guid customerKey, string accountNo)
        {
            return _accountRepository.CustomerAccountExists(customerKey, accountNo);
        }

        public void ChangeBalance(string accountNo, float change)
        {
            _accountRepository.ChangeBalance(accountNo, change);
        }
    }
}