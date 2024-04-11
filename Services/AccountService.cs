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
        public string Transfer(string CustomerKey, string ToAccountNo, float amount)
        {
            return _accountRepository.Transfer(CustomerKey, ToAccountNo, amount);
        }
    }
}
