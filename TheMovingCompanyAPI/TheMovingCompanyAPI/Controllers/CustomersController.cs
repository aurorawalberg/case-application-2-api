using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Models;

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
        public IEnumerable<CustomerEntity> Get()
        {
            return new List<CustomerEntity>
            {
                new CustomerEntity
                {
                    CustomerId = 1,
                    Name = "John Smith"
                },
                new CustomerEntity
                {
                    CustomerId = 2,
                    Name = "John Andrews"
                },
                new CustomerEntity
                {
                    CustomerId = 3,
                    Name = "John Kelly"
                }
            };
        }
    }
}
