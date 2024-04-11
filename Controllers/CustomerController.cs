using Atm.Dto;
using Atm.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Atm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("login")]
        public ActionResult<string> Login([FromBody] CustomerLoginDto customer)
        {
            try
            {
                var result = _customerService.Login(customer);
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
