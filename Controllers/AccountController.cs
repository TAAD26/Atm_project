using Atm.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Atm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("Transfer/{CustomerKey}")]
        public ActionResult<string> Transfer([FromRoute] string CustomerKey, [FromQuery] string toAccountNo, [FromQuery] float amount)
        {
            try
            {
                var result = _accountService.Transfer(CustomerKey, toAccountNo, amount);
                return Ok(result);
            }
            catch (ArgumentNullException Ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, Ex.Message);
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, Ex.Message);
            }
        }
    }
}
