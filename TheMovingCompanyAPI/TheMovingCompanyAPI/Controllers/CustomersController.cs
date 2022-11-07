using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.Services;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly IOrderService _orderService;
        public CustomersController(ILogger<CustomersController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            return _orderService.GetCustomers();
        }

        [HttpDelete("{id}", Name = "DeleteCustomer")]
        public ActionResult Delete(int id)
        {
            _orderService.DeleteCustomer(id);
            return Ok(new { message = "Customer deleted" });
        }
    }
}
