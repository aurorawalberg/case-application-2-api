using Microsoft.AspNetCore.Mvc;
using TheMovingCompanyAPI.Models;

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
        public IEnumerable<ServiceEntity> Get()
        {
            return new List<ServiceEntity>
            {
                new ServiceEntity
                {
                    OrderId = 1,
                    ServiceType = "Moving",
                    Date = DateTime.Now,
                },
                new ServiceEntity
                {
                    OrderId = 1,
                    ServiceType = "Packing",
                    Date = DateTime.Now,
                },
                new ServiceEntity
                {
                    OrderId = 2,
                    ServiceType = "Moving",
                    Date = DateTime.Now,
                },
                new ServiceEntity
                {
                    OrderId = 3,
                    ServiceType = "Cleaning",
                    Date = DateTime.Now,
                },
                new ServiceEntity
                {
                    OrderId = 3,
                    ServiceType = "Moving",
                    Date = DateTime.Now,
                },
                new ServiceEntity
                {
                    OrderId = 3,
                    ServiceType = "Cleaning",
                    Date = DateTime.Now,
                }
            };
        }
    }
}
