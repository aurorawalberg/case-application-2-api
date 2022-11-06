using TheMovingCompanyAPI.Entities;

namespace TheMovingCompanyAPI.Models
{
    public class OrderRequest
    {
        public Order Order { get; set; }
        public List<Service> Services { get; set; }
        public Customer Customer { get; set; }
    }
}
