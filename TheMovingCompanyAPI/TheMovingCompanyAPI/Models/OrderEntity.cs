namespace TheMovingCompanyAPI.Models
{
    public class OrderEntity
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string FromAdress { get; set; }
        public string ToAdress { get; set; }
        public string Note { get; set; }
    }
}
