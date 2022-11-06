namespace TheMovingCompanyAPI.Models
{
    public class Order
    {
        public OrderEntity OrderEntity { get; set; }
        public List<ServiceEntity> Services { get; set; }
        public CustomerEntity CustomerEntity { get; set; }
    }
}
