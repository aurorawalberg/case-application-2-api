using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.MockData;
using TheMovingCompanyAPI.Models;
using TheMovingCompanyAPI.Services;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrderService _orderService;
        private readonly MockOrderData _mockData = new();


        public OrdersController(ILogger<OrdersController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet(Name = "GetOrders")]
        public IEnumerable<Order> Get()
        {
            // TODO - don't add mock data when adding/udpating database is working as intended
            var dbData = _orderService.GetOrders().ToList();
            var mockData = _mockData.GetOrders();
            mockData.AddRange(dbData);
            return mockData;
        }

        [HttpPost(Name = "CreateOrder")]
        public ActionResult Post([FromBody] OrderRequest body)
        {
            // TODO - handle errors better
            try
            {
                _orderService.CreateOrder(body.Order);
                return Ok(new { message = "Order created" });

            }
            catch (Exception e)
            {
                return BadRequest(new { message = $"Error: {e.Message}" });

            }
        }

        [HttpPut("{id}", Name = "UpdateOrder")]
        public ActionResult Put(int id, [FromBody] OrderRequest body)
        {
            // TODO - handle errors better
            try
            {
                _orderService.UpdateOrder(body.Order, id);
                return Ok(new { message = "Order updated" });

            }
            catch (Exception e)
            {
                return BadRequest(new { message = $"Error: {e.Message}" });
            }
        }

        [HttpDelete("{id}", Name = "DeleteOrder")]
        public ActionResult Delete(int id)
        {
            _orderService.DeleteOrder(id);
            return Ok(new { message = "Order deleted" });
        }
    }
}
