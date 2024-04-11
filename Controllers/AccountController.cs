using Atm.Model;
using Atm.Services;
using Microsoft.AspNetCore.Mvc;

namespace Atm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(AccountService accountService) : ControllerBase
    {
        //[HttpGet("CreateCustomerAndAccount")]
        //public IActionResult(Account account) => accountService.CreateAccount(account);
    }
}
