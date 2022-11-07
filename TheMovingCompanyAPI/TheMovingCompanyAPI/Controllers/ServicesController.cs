using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.Services;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly IOrderService _orderService;

        public ServicesController(ILogger<ServicesController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet(Name = "GetServices")]
        public IEnumerable<Service> Get()
        {
            return _orderService.GetServices();
        }

        [HttpDelete("{id}", Name = "DeleteService")]
        public ActionResult Delete(int id)
        {
            _orderService.DeleteService(id);
            return Ok(new { message = "Service deleted" });
        }
    }
}
