using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Entities;

namespace TheMovingCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ILogger<ServicesController> _logger;
        public ServicesController(ILogger<ServicesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetServices")]
        public IEnumerable<Service> Get()
        {
            return new List<Service>
            {
                new Service
                {
                    OrderId = 1,
                    ServiceType = "Moving",
                    Date = DateTime.Now,
                },
                new Service
                {
                    OrderId = 1,
                    ServiceType = "Packing",
                    Date = DateTime.Now,
                },
                new Service
                {
                    OrderId = 2,
                    ServiceType = "Moving",
                    Date = DateTime.Now,
                },
                new Service
                {
                    OrderId = 3,
                    ServiceType = "Cleaning",
                    Date = DateTime.Now,
                },
                new Service
                {
                    OrderId = 3,
                    ServiceType = "Moving",
                    Date = DateTime.Now,
                },
                new Service
                {
                    OrderId = 3,
                    ServiceType = "Cleaning",
                    Date = DateTime.Now,
                }
            };
        }
    }
}
