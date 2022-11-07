using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.MockData;
using TheMovingCompanyAPI.Services;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly IOrderService _orderService;
        private readonly MockOrderData _mockData = new();

        public CustomersController(ILogger<CustomersController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            // TODO - don't add mock data when adding/udpating database is working as intended
            var dbData = _orderService.GetCustomers().ToList();
            var mockData = _mockData.GetCustomers();
            mockData.AddRange(dbData);
            return mockData;
        }

        [HttpDelete("{id}", Name = "DeleteCustomer")]
        public ActionResult Delete(int id)
        {
            _orderService.DeleteCustomer(id);
            return Ok(new { message = "Customer deleted" });
        }
    }
}
