using Atm.Dto;
using Atm.Interfaces;
using Atm.Model;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Atm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(ICustomerService customerService) : ControllerBase
    {
        [HttpPost("CreateCustomer")]
        public ActionResult<Customer> CreateCustomer([FromBody] CustomerDto customerDto, [FromQuery][Required] string userName, [FromQuery][Required] string pass)
        {
            try
            {
                Customer customerToCreate = customerService.CreateCustomer(customerDto, userName, pass);
                if (customerToCreate is not null)
                    return Ok(customerToCreate);
                else return BadRequest(customerDto);
            }
            catch { return BadRequest(new()); }
        }
    }
}
