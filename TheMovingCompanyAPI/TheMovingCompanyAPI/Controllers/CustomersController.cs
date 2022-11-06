using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            return new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    Name = "John Smith"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "John Andrews"
                },
                new Customer
                {
                    CustomerId = 3,
                    Name = "John Kelly"
                }
            };
        }
    }
}
