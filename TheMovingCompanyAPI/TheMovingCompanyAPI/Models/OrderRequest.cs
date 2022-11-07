using TheMovingCompanyAPI.Entities;

namespace TheMovingCompanyAPI.Models
{
    public class OrderRequest
    {
        public Order Order { get; set; } = null!;
        public List<Service> Services { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
    }
}
