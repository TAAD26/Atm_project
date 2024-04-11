using Atm.Interfaces;
using Atm.Model;

namespace Atm.Services
{
    public class AccountService(IAccountRepository _accountRepository) : IAccountService
    {
        public List<Account> CreateAccountWithoutSave(Guid customerKey, float startingBalance = 0)
        {
            List<Account> accounts =
            [
                new Account()
                { 
                    Number = GenerateAccountNumer(),
                    CustomerKey = customerKey,
                    Balance = startingBalance,
                }
            ];

            return accounts;
        }

        private static string GenerateAccountNumer()
        {
            string accountNumber = "LT";
            Random rand = new();

            for (int i = 0; i < 18; i++)
            {
                accountNumber += rand.Next(0, 10);
            }
            return accountNumber;
        }

        public string Transfer(string CustomerKey, string ToAccountNo, float amount)
        {
            return _accountRepository.Transfer(CustomerKey, ToAccountNo, amount);
        }

        public Account GetAccountDetails(string customerKey, string accountNumber)
        {
            return _accountRepository.GetAccountDetails(customerKey, accountNumber);
        }
    }
}
