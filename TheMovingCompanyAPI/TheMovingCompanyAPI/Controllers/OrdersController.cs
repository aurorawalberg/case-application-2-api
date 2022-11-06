using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrders")]
        public IEnumerable<Order> Get()
        {
            return new List<Order>
            {
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    FromAdress = "123 Main St",
                    ToAdress = "456 Main St",
                    Note = "This is a note",
                },
                new Order
                {
                    OrderId = 2,
                    CustomerId = 1,
                    FromAdress = "123 Second St",
                    ToAdress = "456 Second St",
                    Note = "This is a note",
                },
                new Order
                {
                    OrderId = 3,
                    CustomerId = 2,
                    FromAdress = "123 Third St",
                    ToAdress = "456 Third St",
                    Note = "This is a note",
                },
                new Order
                {
                    OrderId = 4,
                    CustomerId = 3,
                    FromAdress = "123 Last St",
                    ToAdress = "456 Last St",
                    Note = "This is a note",
                }
            };
        }

        [HttpPost("{id}", Name = "CreateOrder")]
        public void Post([FromBody] string value)
        {

        }

        [HttpPut("{id}", Name = "UpdateOrder")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("{id}", Name = "DeleteOrder")]
        public void Delete(int id)
        {

        }
    }
}
