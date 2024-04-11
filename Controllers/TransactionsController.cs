using Atm.Interfaces;
using Atm.Model;
using Microsoft.AspNetCore.Mvc;

namespace Atm.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly ICustomerService _customerService;
        private readonly IAccountRepository _accountRepository;

        public TransactionsController(ITransactionService transactionService, ICustomerService customerService, IAccountRepository accountRepository)
        {
            _transactionService = transactionService;
            _customerService = customerService;
            _accountRepository = accountRepository;
        }

        [HttpPost]
        public ActionResult<Transaction> Deposit([FromQuery] Guid customerKey, [FromQuery] string accountNo, [FromQuery] float amount)
        {
            if (amount <= 0)
            {
                return BadRequest("Cannot deposit negative amount.");
            }

            try
            {
                bool customerExists = _customerService.CheckIfCustomerExists(customerKey);
                if (!customerExists)
                {
                    return NotFound("Customer does not exist.");
                }

                bool customerAccountExists = _accountRepository.CustomerAccountExists(customerKey, accountNo);
                if (!customerAccountExists)
                {
                    return NotFound("Account does not exist.");
                }

                Transaction deposit = _transactionService.MakeTransaction(accountNo, amount, "Deposit");

                _accountRepository.ChangeBalance(accountNo, amount);

                return Ok(deposit);
            }
            catch (Exception exception)
            {
                return Problem($"Error: {exception.Message}");
            }
        }

        [HttpPost]
        public ActionResult<Transaction> Withdraw([FromQuery] Guid customerKey, [FromQuery] string accountNo, [FromQuery] float amount)
        {
            if (amount <= 0)
            {
                return BadRequest("Cannot withdraw negative amount.");
            }

            try
            {
                bool customerExists = _customerService.CheckIfCustomerExists(customerKey);
                if (!customerExists)
                {
                    return NotFound("Customer does not exist.");
                }

                bool customerAccountExists = _accountRepository.CustomerAccountExists(customerKey, accountNo);
                if (!customerAccountExists)
                {
                    return NotFound("Account does not exist.");
                }

                bool canWithdraw = _accountRepository.CanWithdraw(accountNo, amount);
                if (!canWithdraw)
                {
                    return BadRequest("Cannot withdraw. Insufficient balance.");
                }

                Transaction withdraw = _transactionService.MakeTransaction(accountNo, amount, "Withdraw");

                _accountRepository.ChangeBalance(accountNo, amount * -1);

                return Ok(withdraw);
            }
            catch (Exception exception)
            {
                return Problem($"Error: {exception.Message}");
            }
        }
    }
}