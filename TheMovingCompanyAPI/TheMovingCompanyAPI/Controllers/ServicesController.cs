using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.MockData;
using TheMovingCompanyAPI.Services;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly IOrderService _orderService;
        private readonly MockOrderData _mockData = new();


        public ServicesController(ILogger<ServicesController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet(Name = "GetServices")]
        public IEnumerable<Service> Get()
        {
            // TODO - don't add mock data when adding/udpating database is working as intended
            var dbData = _orderService.GetServices().ToList();
            var mockData = _mockData.GetServices();
            mockData.AddRange(dbData);
            return mockData;
        }

        [HttpDelete("{id}", Name = "DeleteService")]
        public ActionResult Delete(int id)
        {
            _orderService.DeleteService(id);
            return Ok(new { message = "Service deleted" });
        }
    }
}
