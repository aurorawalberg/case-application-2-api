using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;
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

        public OrdersController(ILogger<OrdersController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet(Name = "GetOrders")]
        public IEnumerable<Order> Get()
        {
            return _orderService.GetOrders();
        }

        [HttpPost(Name = "CreateOrder")]
        public OkObjectResult Post([FromBody] OrderRequest body)
        {
            _orderService.CreateOrder(body.Order);
            body.Services.ForEach(s =>
            {
                _orderService.CreateService(s);
            });
            return Ok(new { message = "Order created" });
        }

        [HttpPut("{id}", Name = "UpdateOrder")]
        public OkObjectResult Put(int id, [FromBody] OrderRequest body)
        {
            _orderService.UpdateOrder(body.Order);
            return Ok(new { message = "Order updated" });
        }

        [HttpDelete("{id}", Name = "DeleteOrder")]
        public OkObjectResult Delete(int id)
        {
            _orderService.DeleteOrder(id);
            return Ok(new { message = "Order deleted" });
        }
    }
}
